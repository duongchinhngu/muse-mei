
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MuseMeiV2.Models;
using MuseMeiV2.Services.CategoryServices;
using MuseMeiV2.Services.ClothServices;
using MuseMeiV2.Services.OrderDetailServices;
using MuseMeiV2.Services.OrderServices;
using MuseMeiV2.Services.RoleServices;
using MuseMeiV2.Services.UserServices;
using MuseMeiV2.UnitOfWorks;
using System;

namespace MuseMeiV2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void AddScopeToConfig(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IClothService, ClothService>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserService, UserService>();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MuseMeiDbContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:MuseMeiDB"]));

            //add scope to config
            AddScopeToConfig(services);
            // mapper
            services.AddAutoMapper(typeof(Startup));
            
            services.AddControllers();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc(
                    "v1",
                    new OpenApiInfo { 
                        Title = "MuseMei API", 
                        Version = "v1", 
                        Description = "MuseMei ASP.NET Core Web API",
                        TermsOfService = new Uri("https://www.thecodebuzz.com/resolved-failed-to-load-api-definition-undefined-swagger-v1-swagger-json/"),
                        Contact = new OpenApiContact
                    {
                        Name = "Duong Chinh Ngu",
                        Email = string.Empty,
                        Url = new Uri("https://www.thecodebuzz.com/resolved-failed-to-load-api-definition-undefined-swagger-v1-swagger-json/"),
                    },
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "MuseMei V1");
                c.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "MuseMei V2");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
   

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
