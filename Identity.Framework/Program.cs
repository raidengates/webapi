using Microsoft.AspNetCore.Hosting;

namespace Identity.Framework
{
    public class Program
    {
        public static void Main()
        {
            var host = new WebHostBuilder()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }
    }
}
