using Application.Interfaces.Auths;
using Application.Interfaces.EncryptAndDecrypt;
using Application.Interfaces.PageCredentials;
using Application.Interfaces.Store;
using Application.Interfaces.Sales;
using Application.Interfaces.User;
using Application.Services.Auths;
using Application.Services.EncryptAndDecrypt;
using Application.Services.PageCredentials;
using Application.Services.Store;
using Application.Services.Sales;
using Application.Services.User;
using Domain.Interfaces;
using Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Ioc
{
    public static class ApplicationDependencycontainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            // Auth
            services.AddScoped<IAuthService, AuthService>();
            // User
            services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IRolService, RolService>();
            // Password
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            // PageCredentials
            services.AddScoped<IPageCredentialsService, PageCredentialsService>();
            // EncryptAndDecrypt
            services.AddScoped<IEncryptAndDecryptService, EncryptAndDecryptService>();
            // Store
            services.AddScoped<IStore, Store>();

            services.AddScoped<ISales, Sales>();



        }
    }
}
