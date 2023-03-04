using Investment.Domain;
using Investment.Domain.Repositories.Abstract;
using Investment.Domain.Repositories.EntityFramework;
using Investment;
using Investment.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Investment
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //ვინახავთ კონფიგურაციას appsettings.json-დან
            Configuration.Bind("Project", new Config());

            //აიდენთითის პარამეტრები
            services.AddIdentity<IdentityUser, IdentityRole>(opt =>
            {
                opt.User.RequireUniqueEmail = true;
                opt.Password.RequiredLength = 6;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            //
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            //services.AddControllersWithViews().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();
            services.AddControllersWithViews().AddDataAnnotationsLocalization(option =>
            {
                var type = typeof(SharedResource);
                var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
                var factory = services.BuildServiceProvider().GetService<IStringLocalizerFactory>();
                var localizer = factory.Create("SharedResource", assemblyName.Name);
                option.DataAnnotationLocalizerProvider = (t, f) => localizer;
            });

            //სერვისების სახით გვაქვს საჭირო ფუნქციონალი
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();


            //ვუკავშირდებით ბაზას
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));


            //ქუქიების აუთენთიფიკაციის დაყენება
            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "investemntAuth";
                opt.Cookie.HttpOnly = true;
                opt.LoginPath = "/account/login";
                opt.AccessDeniedPath = "/account/accessdenied"; 
                opt.SlidingExpiration = true;
            });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[] { "en-US", "ka" };
                options.SetDefaultCulture(supportedCultures[0])
                    .AddSupportedCultures(supportedCultures)
                    .AddSupportedUICultures(supportedCultures);
            });

            //admin area-ს ავტორიზაციის პოლიტიკა
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", polivy => { polivy.RequireRole("admin"); });
            });

            //ვამატებთ კონტროლერებისა და ვიუს მხარდაჭერას
            services.AddControllersWithViews(x => 
            { 
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddSessionStateTempDataProvider();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //მნიშვნელოვანია თანმიმდევრობის დაცვა

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            var supportedCultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("ka-GE")
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });



            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            //შემოგვაქვს აუთენთიფიკაცია და ავტორიზაცია
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
