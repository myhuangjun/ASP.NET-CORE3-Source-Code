using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace _1._1._3.helloword
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一种
            //Host.CreateDefaultBuilder().ConfigureWebHost(
            //    webHostBuild => webHostBuild.
            //    UseKestrel().
            //    //UseUrls("http://localhost:8000","https://localhost:8001").显示指定url
            //    Configure(app => app.Run(
            //            context => context.Response.WriteAsync("Hello Word")
            //        )
            //    )
            // ).Build().Run();
            //ConfigureWebHostDefaults方式
            //Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webHostBuild =>
            //{
            //    webHostBuild.Configure(app => app.Run(context => context.Response.WriteAsync("Hello Word")));
            //}).Build().Run();

            //MVC方式
            //Host.CreateDefaultBuilder()
            //    .ConfigureWebHostDefaults(webBuilder => webBuilder.
            //    ConfigureServices(service => service.
            //    AddRouting()
            //    .AddControllersWithViews()).
            //    Configure(app => app.UseRouting().UseEndpoints(endpoint => endpoint.MapControllers())))
            //    .Build().
            //    Run();

            //Startup.cs方式
            Host.CreateDefaultBuilder().ConfigureWebHostDefaults(
                webBuilder => webBuilder.UseStartup<Startup>())
                .Build()
                .Run();
        }

    }
}
