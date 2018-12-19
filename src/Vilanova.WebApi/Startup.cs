//using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Vilanova.Application;
using Vilanova.Application.Interfaces;
using Vilanova.Domain.Interfaces.Repository;
using Vilanova.Domain.Interfaces.Services;
using Vilanova.Domain.Services;
using Vilanova.Infrastructure.Data;
using Vilanova.Infrastructure.Repository;

namespace Vilanova.WebApi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //Config Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "API - Vilanova", Version = "v1" });
            });

            //services.AddMvc()
            //.AddFluentValidation(fvc =>
            //    fvc.RegisterValidatorsFromAssemblyContaining<Startup>());

            //// Add framework services.
            //services.AddMvc();

            services.AddDbContext<VilanovaContext>(options =>
                        options.UseSqlServer(Configuration.GetConnectionString("MyConnectionString")));

            
            services.AddTransient<IAlunoRepository, AlunoRepository>();

            services.AddTransient<IAlunoService, AlunoService>();

            services.AddTransient<IAlunoAppService, AlunoAppService>();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //Config Swagger
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Vilanova v1");
            });
            //

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
