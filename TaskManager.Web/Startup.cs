using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Web;
using TaskManager.Infrastructure.Data;
using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using TaskManager.Core.Services;
using TaskManager.Web.Services;
using TaskManager.Web.Models;
using TaskManager.Web.Interfaces;
using TaskManager.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace TaskManager.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WorkContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            services.AddIdentity<User, IdentityRole>(opts => {
                opts.Password.RequiredLength = 5;   
                opts.Password.RequireNonAlphanumeric = false;   
                opts.Password.RequireLowercase = false; 
                opts.Password.RequireUppercase = false; 
                opts.Password.RequireDigit = false; 
                opts.User.RequireUniqueEmail = true;   
                opts.User.AllowedUserNameCharacters = ".@abcdefghijklmnopqrstuvwxyz"; 
            })
    .AddEntityFrameworkStores<WorkContext>();

            services.AddScoped<IWorkService, WorkService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IUserService, UserService>();
            services.AddSingleton<IMapper<WorkViewModel, Work>, WorkMapper>();
            services.AddSingleton<IMapper<CommentViewModel, Comment>, CommentMapper>();
            services.AddRazorPages();

            services.AddControllersWithViews();
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
      
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
