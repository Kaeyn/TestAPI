using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLUTESTAPI.Models;
using MongoDB.Driver;
using MongoDB.Bson;

using VLUTESTAPI.Services;
using Microsoft.OpenApi.Models;
using System.Diagnostics;

namespace VLUTESTAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*services.Configure<MongoSetting>(Configuration.GetSection(nameof(MongoSetting)));

            services.AddSingleton<IMongoSettings>(sp => sp.GetRequiredService<IOptions<MongoSetting>>().Value);

            services.AddSingleton<MongoClient>(s => new MongoClient(Configuration.GetValue<string>("MongoSettings:ConnectionString")));

            services.AddScoped(s => s.GetRequiredService<MongoClient>().GetDatabase(Configuration.GetValue<string>("MongoSettings:DatabaseName")));

            services.AddScoped<TestService>();*/

           /* MongoClient client = new MongoClient(Configuration.GetConnectionString("MongoDB"));

            List<string> databases = client.ListDatabaseNames().ToList();

            foreach (string database in databases)
            {
                Console.WriteLine(database);
            }

            var _collection = client.GetDatabase("VLUTESTDB").GetCollection<BsonDocument>("TESTCOLLECTION").Find(Builders<BsonDocument>.Filter.Empty).ToList();
            foreach (var document in _collection)
            {
                Console.WriteLine(document);
            }*/

            // Configure MongoDB client
            services.AddSingleton<IMongoClient>(sp =>
            {
                string connectionString = Configuration.GetConnectionString("MongoDB").Value;
                return new MongoClient(connectionString);
            });


            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VLUTESTAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "VLUTESTAPI v1");
                c.RoutePrefix = string.Empty; // Set Swagger UI at app's root
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
