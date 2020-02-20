using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;

namespace PureHBS
{
    public class TableDefinition
    {
        public TableDefinition()
        {
            ColumnDefinitions = new List<ColumnDefinition>();
        }
        public List<ColumnDefinition> ColumnDefinitions { get; set; }
        public string Name { get; set; }

    }
    public class ColumnDefinition
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public bool IsForeign { get; set; }

        public string ForeignEntity { get; set; }
    }
    public class SqlConnectionHelper
    {
        private readonly string ConString = "Data Source=.;Initial Catalog=ExampleSchoolDb; Integrated Security=true;";

        public List<TableDefinition> GetTableDefinitions()
        {
            List<TableDefinition> definitions = new List<TableDefinition>();
            var tableNames = GetTableNames();
            foreach (var tableName in tableNames)
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    TableDefinition definition = new TableDefinition();

                    using (SqlCommand cmd = new SqlCommand(cmdText: $"Select top 1 * from {tableName}", con))
                    {
                        definition.Name = tableName;
                        con.Open();
                        var result = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                        for (int i = 0; i < result.FieldCount; i++)
                        {
                            var isForeign = Regex.IsMatch(result.GetName(i), "^[A-Z][a-z]+(?:[A-Z][a-z]+)*$") && result.GetName(i).EndsWith("Id")&&result.GetName(i).Length>3;
                            definition.ColumnDefinitions.Add(new ColumnDefinition
                            {
                                Name = result.GetName(i),
                                Type = result.GetFieldType(i).Name,
                                IsForeign = isForeign,
                                ForeignEntity = result.GetName(i).Substring(0, result.GetName(i).Length - 2)
                            });
                        }
                    }
                    definitions.Add(definition);
                }
            }
            return definitions;
        }

        public List<string> GetTableNames()
        {
            List<string> tableNames = new List<string>();
            using (SqlConnection con = new SqlConnection(ConString))
            {

                using (SqlCommand tCmd = new SqlCommand("SELECT name FROM sysobjects WHERE xtype = 'U'", con))
                {
                    con.Open();
                    var reader = tCmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        tableNames.Add(reader["name"].ToString());
                    }
                    reader.Close();
                }
            }
            return tableNames;
        }
    }
}
