using System.Configuration;
using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccess.Base;
using MyBlog.DataAccess.Implement;
using MyBlog.DataAccess.Interface;

namespace MyBlog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //db
            builder.Services.AddDbContext<BlogContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("BlogConnection")));
            builder.Services.AddScoped<IBlogDao, BlogDao>();
            builder.Services.AddScoped<IBlogContent, BlogContent>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}