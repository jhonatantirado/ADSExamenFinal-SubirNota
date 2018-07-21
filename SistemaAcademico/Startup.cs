using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Fibonacci.Repository.Implementation;
using Fibonacci.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Common.Infrastructure.Repository;
using Common;
using AutoMapper;
using Estudiantes.Application;
using SistemaAcademico.Automapper;

namespace SistemaAcademico
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IFibonacciRepository, FibonacciLinealRepository>();
            services.AddDbContext<PracticaExamenContext>(opt => opt.UseInMemoryDatabase("PracticaExamenDB"));
            services.AddScoped<IEstudianteApplicationService, EstudianteApplicationService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddCors();

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutomapperProfile());
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddTransient<DbInitializer>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DbInitializer seeder)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

			app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
