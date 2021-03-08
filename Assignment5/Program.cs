using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Assignment5
{
    public class Program
    {
        public static void Main(string[] args) // very first method/line of code that's run when the program is built
                                                // has string[] args so that options can be flagged when running from command line

        {
            CreateHostBuilder(args).Build().Run();  //trust shilton; this is what it's using to run the code
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();  // know that it's calling startup.cs. Go there
                });
    }
}
