using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using IMIS_DataEntity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using App.Web;
using IMIS_DataEntity.EntityClass;
using IMIS_Service.IMenuService;
using IMIS_Service.IAccountHead;
using IMIS_Service.GlobalFunction;
using IMIS_Service.Setup.IItemUnit;
using IMIS_Service.Setup.IItemBrand;
using IMIS_Service.Setup.IItemCategories;
using IMIS_Service.Setup.IItemPurchaseType;
using IMIS_Service.Setup.IItemSpecification;
using IMIS_Service.Setup.IItemOtherSetupType;
using IMIS_Service.Setup.IOrganizationType;
using IMIS_Service.Setup.IRoomDetials;
using IMIS_Service.Setup.IWareHouse;
using IMIS_Service.Setup.IDepartment;
using IMIS_Service.Setup.IProjectSetup;
using IMIS_Service.Setup.IItemMaster;
using IMIS_Service.Setup.IIncomeRecordKeeping;
using IMIS_Service.Setup.IReceiptDistribution;
using IMIS_Service.Setup.ITaxRate;
using IMIS_Service.Setup.IItemPurMasterPlan;

namespace IMIS
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
            });

            services.AddDbContext<IMISDbContext>(options =>
                options.UseNpgsql(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<Usermaster>().AddEntityFrameworkStores<IMISDbContext>();
            //services.AddIdentity<IMISUser, IdentityRole>(option =>
            //{
            //    option.Password.RequiredLength = 5;
            //    option.Password.RequiredUniqueChars = 1;
            //}).AddEntityFrameworkStores<IMISDbContext>();
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(40);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
            //services.AddControllersWithViews()
            //    .AddNewtonsoftJson();
            services.AddRazorPages();
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromHours(1);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });
          
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("VueCorsPolicy", builder =>
            //    {
            //        builder
            //          .AllowAnyHeader()
            //          .AllowAnyMethod()
            //          .AllowCredentials()
            //          .WithOrigins("http://localhost:44329");
            //    });
            //});
            services.AddMvc(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });
            //Add service for accessing current HttpContext
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<MenuService>();
            services.AddScoped<GlobalFunction>();
            services.AddScoped<IAccountHead, AccountHead>();
            services.AddScoped<IItemUnit, ItemUnit>();
            services.AddScoped<IItemBrand, ItemBrand>();
            services.AddScoped<IItemCategories, ItemCategories>();
            services.AddScoped<IItemPurchaseType, ItemPurchaseType>();
            services.AddScoped<IItemSpecification, ItemSpecification>();
            services.AddScoped<IItemOtherSetupType, ItemOtherSetupType>();
            services.AddScoped<IOrganizationType, OrganizationType>();
            services.AddScoped<IRoomDetials, RoomDetials>();
            services.AddScoped<IWareHouse, WareHouse>();
            services.AddScoped<IDepartment, Department>();
            services.AddScoped<IProjectSetup, ProjectSetup>();
            services.AddScoped<IItemMaster, ItemMaster>();
            services.AddScoped<IIncomeRecordKeeping, IncomeRecordKeeping>();
            services.AddScoped<IReceiptDistribution, ReceiptDistribution>();
            services.AddScoped<ITaxRate, TaxRate>();
            services.AddScoped<IItemPurMasterPlan, ItemPurMasterPlan>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseCookiePolicy();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            //app.UseMvc(); 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            AppHttpContext.Services = app.ApplicationServices;
        }
    }
}
