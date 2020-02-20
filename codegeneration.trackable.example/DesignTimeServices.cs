using EntityFrameworkCore.Scaffolding.Handlebars;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace codegeneration.trackable.example
{
    public class BaseEntity
    {
        public string IsDeleted { get; set; } 
    }
    public class DesignTimeServices
    {
        public class ScaffoldingDesignTimeServices : IDesignTimeServices
        {
            public void ConfigureDesignTimeServices(IServiceCollection services)
            {
                // Add Handlebars scaffolding templates
                services.AddHandlebarsScaffolding(options =>
                {
                    // Generate both context and entities
                    options.ReverseEngineerOptions = ReverseEngineerOptions.DbContextAndEntities;

                    // Exclude some tables
                    options.ExcludedTables = new List<string> { "Territory", "EmployeeTerritories" };

                    // Add custom template data
                    options.TemplateData = new Dictionary<string, object>
                    {
                        { "models-namespace", "ScaffoldingSample.Models" },
                        { "base-class", "EntityBase" },
                    };

                });

                // Register Handlebars helper
                var baseHelper = (helperName: "baseEntityHelper", helperFunction: (Action<TextWriter, Dictionary<string, object>, object[]>)MyHbsHelper);
                var listContains = (helperName: "nonBaseEntityProperties", helperFunction: (Action<TextWriter, Dictionary<string, object>, object[]>)SetProperties);

                var baseEntityProps = typeof(BaseEntity).GetProperties().Select(x=>x.Name).ToList();

                
                // Add optional Handlebars helpers
                services.AddHandlebarsHelpers(baseHelper);


                // Add Handlebars transformer for Country property
                services.AddHandlebarsTransformers(
                    propertyTransformer: e =>
                        e.PropertyName == "Country"
                            ? new EntityPropertyInfo("Country", e.PropertyName)
                            : new EntityPropertyInfo(e.PropertyType, e.PropertyName));


                // Add optional Handlebars transformers
                //services.AddHandlebarsTransformers(
                //    entityNameTransformer: n => n + "Foo",
                //    entityFileNameTransformer: n => n + "Foo",
                //    constructorTransformer: e => new EntityPropertyInfo(e.PropertyType + "Foo", e.PropertyName + "Foo"),
                //    propertyTransformer: e => new EntityPropertyInfo(e.PropertyType, e.PropertyName + "Foo"),
                //    navPropertyTransformer: e => new EntityPropertyInfo(e.PropertyType + "Foo", e.PropertyName + "Foo"));
            }

            // Sample Handlebars helper
            void MyHbsHelper(TextWriter writer, Dictionary<string, object> context, object[] parameters)
            {
                writer.Write("// My Handlebars Helper");
            }

            void SetProperties(TextWriter writer, Dictionary<string, object> context, object[] parameters)
            {
                

            }
        }
    }
}
