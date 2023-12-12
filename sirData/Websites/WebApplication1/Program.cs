namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                //pattern: "{controller=Default}/{action=Index}/{id?}/{a?}/{b?}");
                 pattern: "{controller=Default}/{action=Index}/{id?}");

            //app.MapControllerRoute(
            //   name: "default2",
            //   pattern: "{controller=Home}/{action=Index}/{a}/{b}");

            app.Run();
        }
    }
}