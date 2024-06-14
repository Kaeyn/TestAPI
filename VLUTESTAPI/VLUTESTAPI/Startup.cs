using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using VLUTESTAPI.Models;
using Microsoft.OpenApi.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

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
            string connectionString = Environment.GetEnvironmentVariable("MYSQL_CONNECTION_STRING");
            

            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(connectionString,
                mySqlOptions =>
                {
                    mySqlOptions.CharSetBehavior(CharSetBehavior.AppendToAllColumns)
                                .CharSet(CharSet.Utf8Mb4)
                                .ServerVersion(ServerVersion.AutoDetect(connectionString));
                }

             ));

            using (var scope = services.BuildServiceProvider().CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbContext.Database.EnsureCreated();
                var firstEntity = dbContext.Product.FirstOrDefaultAsync();
            }

            services.AddControllers();

            /*// Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VLUTESTAPI", Version = "v1" });
            });*/
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

            // Create an HTTP client
            var client = new HttpClient();

            // Make a request to the warmup endpoint
           /* async Task WarmupAsync()
            {
                var response = await client.GetAsync("http://testapi-ibo5.onrender.com/api/warmup");

                // Log the response
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Warmup Successful");
                }
                else
                {
                    Console.WriteLine("Warmup Failed");
                }
            }

            // Call the async method
            WarmupAsync().GetAwaiter().GetResult();*/

            /*// Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "VLUTESTAPI v1");
                c.RoutePrefix = string.Empty; // Set Swagger UI at app's root
            });*/


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
