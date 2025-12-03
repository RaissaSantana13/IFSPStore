
using AutoMapper;
using IFSPStore.app.Register;
using IFSPStore.app.ViewModel;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net.NetworkInformation;

namespace IFSPStore.app.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;
        public static void ConfigureServices()
        {
            // data base config
            var dbConfigFile = "Config/DBCOnfig.txt";
            var strCon=File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<IFSPStoreContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
            );

            #region Repository
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseRepository<City>, BaseRepository<City>>();
            services.AddScoped<IBaseRepository<Customer>, BaseRepository<Customer>>();
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();
            services.AddScoped<IBaseRepository<SaleItem>, BaseRepository<SaleItem>>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            #endregion

            #region Service
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<IBaseService<City>, BaseService<City>>();
            #endregion

            #region Forms
            services.AddScoped<CategoryForm, CategoryForm>();
            services.AddScoped<UserForm, UserForm>();
            services.AddScoped<CityForm, CityForm>();
            #endregion


            services.AddSingleton(
                new MapperConfiguration(
                    config => {
                        config.CreateMap<User, UserViewModel>();
                        config.CreateMap<City, CityViewModel>();
                        config.CreateMap<Category, CategoryViewModel>(); 
                    },
                    NullLoggerFactory.Instance).CreateMapper()
                );
            serviceProvider = services.BuildServiceProvider();

        }
    }
}
