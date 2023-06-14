using App.Infrastructure.Data.SqlServer;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using App.Domain.Core.Contracts.Service;
using App.Domain.Service;
using App.Domain.Core.Contracts.Repository;
using App.Infrastructure.Repository.ef;
using System.Security.Claims;
using Market_Place.AutoMapper;

namespace Market_Place
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MarketPlaceContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Database:ConnectionString")));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentity<IdentityUser<int>, IdentityRole<int>>()
                .AddEntityFrameworkStores<MarketPlaceContext>();

            builder.Services.AddScoped<IAdminService, AdminService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<ISalesManService, SalesManService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IAdminRepository, AdminRepository>();
            builder.Services.AddScoped<IBoothRepository, BoothRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<ICommentRepository, CommentRepository>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<ISalesManRepository, SalesManRepository>();
            builder.Services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();
            builder.Services.AddScoped<ICommentService, CommentService>();
            builder.Services.AddScoped<IBoothService, BoothService>();
            builder.Services.AddScoped<IBidRepository, BidRepository>();
            builder.Services.AddScoped<IBidService, BidService>();

            builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

            builder.Services.ConfigureApplicationCookie(options => options.LoginPath = "/Identity/AuthAdmin/Login");
            builder.Services.ConfigureApplicationCookie(options => options.AccessDeniedPath = "/Home/Index");

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("ISAdmin", policy => policy.RequireClaim("AuthorizedRole", "ISAdmin"));
                options.AddPolicy("ISCustomer", policy => policy.RequireClaim("AuthorizedRole", "ISCustomer"));
                options.AddPolicy("ISSalesMan", policy => policy.RequireClaim("AuthorizedRole", "ISSalesMan"));
            });


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

            app.MapAreaControllerRoute(
                name: "areas",
                areaName: "Admin",
                pattern: "Admin/{controller=Admin}/{action=Dashboard}/{id?}");

            app.MapAreaControllerRoute(
                name: "areas",
                areaName: "Identity",
                pattern: "Identity/{controller=AuthCustomer}/{action=Login}/{id?}");

            app.MapAreaControllerRoute(
                name: "areas",
                areaName: "SalesMan",
                pattern: "Identity/{controller}/{action}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseAuthentication();

            app.UseAuthorization();

            app.Run();
        }
    }
}