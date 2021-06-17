using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Services;

namespace Website
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
            services.AddHttpClient();
            services.AddRazorPages().AddRazorPagesOptions(options =>
            {
                options.Conventions
                       .ConfigureFilter(new IgnoreAntiforgeryTokenAttribute());
                //Need to be logged in.
                options.Conventions.AuthorizePage("/AdminSearchCarEngine");
                options.Conventions.AuthorizePage("/AdminSearchCarManufacturer");
                options.Conventions.AuthorizePage("/AdminSearchCarModel");
                options.Conventions.AuthorizePage("/AdminSearchCarEconomyReports");
                options.Conventions.AuthorizePage("/AdminSearchCarUser");
            });
            services.AddServerSideBlazor();
            services.AddTransient<UserServices>();
            services.AddTransient<LoginServices>();
            services.AddTransient<SearchService>();
            services.AddTransient<ManufacturerServices>();
            services.AddTransient<ModelServices>();
            services.AddTransient<EngineServices>();
            services.AddTransient<CommentService>();
            services.AddTransient<Manufacturer>();
            services.AddTransient<User>();
            services.AddTransient<Model>();
            services.AddTransient<Engine>();
            services.AddTransient<EconomyReportElectric>();
            services.AddTransient<EconomyReportICE>();
            services.AddTransient<EcoService>();
            services.AddTransient<EconomySummaryICE>();
            services.AddTransient<EconomySummaryElectric>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options =>
            {

            });

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddTransient<UserServices>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithRedirects("/Error");

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
            });
        }
    }
}
