using HandlebarsDotNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PureHBS
{
    public class ExecutingHandleBarsService
    {
        private string TemplateDirectory => "/CodeTemplates/";
        public void Execute()
        {
            var root = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location.Substring(0, Assembly.GetEntryAssembly().Location.IndexOf("bin\\")));
            var basePropes = new[] { "IsDeleted" };

            string source = File.ReadAllText(root + TemplateDirectory + "CSharpEntityType/Class.hbs");
            string importsSource = File.ReadAllText(root + TemplateDirectory + "CSharpEntityType/Partials/Imports.hbs");
            string constructorSource = File.ReadAllText(root + TemplateDirectory + "CSharpEntityType/Partials/Constructor.hbs");
            string propertiesSource = File.ReadAllText(root + TemplateDirectory + "CSharpEntityType/Partials/Properties1.hbs");

            Handlebars.RegisterTemplate("constructor", constructorSource);
            Handlebars.RegisterTemplate("properties", propertiesSource);
            Handlebars.RegisterTemplate("imports", importsSource);

            Handlebars.RegisterHelper("spaces", (w, c, p) =>
            {
                string s = "";
                for (int i = 0; i < Convert.ToInt32(p[0]); i++)
                {
                    s += " ";
                }
                w.Write(s);
            });


            var template = Handlebars.Compile(source);
            SqlConnectionHelper helper = new SqlConnectionHelper();
            var tables = helper.GetTableDefinitions();
            var datas = new List<dynamic>();
            tables.ForEach(x =>
            {
                datas.Add(new
                {
                    base_class = "BaseEntity",
                    @namespace = "Models",
                    @class = x.Name,
                    properties = x.ColumnDefinitions.Where(x=>!basePropes.Contains(x.Name)&&!x.IsForeign).Select(x => new { propertyType = ResolveTypeName(x.Type), propertyName = x.Name }),
                    foreignProperties = x.ColumnDefinitions.Where(x=>!basePropes.Contains(x.Name)&&x.IsForeign).Select(x => new { propertyType = ResolveTypeName(x.Type), propertyName = x.Name, foreign=x.ForeignEntity })
                });
            });


            foreach (var data in datas)
            {
                var result = template(data);
                var folder = Path.Combine(root, "Models");
                var path = Path.Combine(folder, data.@class + ".cs");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
                {
                    writer.WriteLine(result);
                }
                //File.AppendAllText(path, result);
            }
        }
        public string ResolveTypeName(string name)
        {
            if (name == "Int32")
                return "int";
            if (name == "String")
                return "string";
            if (name == "Boolean")
                return "bool";
            return name;
        }
    }
}
