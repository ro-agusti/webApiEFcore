using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApiPersonas.Data;//agregar
using Microsoft.EntityFrameworkCore; //agregar

namespace WebApiPersonas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.


        //-------------------
        //se registra el DBcontext y otros componentes
        public void ConfigureServices(IServiceCollection services)
        {
            //registrar EF-Indicar que usaremos SQL Server-Pasa la clave de la cadena de conexi�n de la DB GetConnectionString("KeyDB")
                        services.AddDbContext<PeopleDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("KeyDB")));
            services.AddControllers();
        }
        //-------------------



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
