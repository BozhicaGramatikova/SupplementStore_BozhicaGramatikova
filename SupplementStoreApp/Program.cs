using FluentValidation;
using FluentValidation.AspNetCore;
using SupplementStoreApp.HealthChecks;
using SupplementStoreBL.Interfaces;
using SupplementStoreBL.Services;
using SupplementStoreDL.Interfaces;
using SupplementStoreDL.Repositories;

namespace SupplementStoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IStoreRepository, StoreRepository>();
            builder.Services.AddSingleton<ISupplementRepository, SupplementRepository>();

            builder.Services.AddSingleton<IStoreService, StoreService>();
            builder.Services.AddSingleton<ISupplementService, SupplementService>();
            builder.Services.AddSingleton<IBrandService, BrandService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddFluentValidationAutoValidation();
            builder.Services.AddValidatorsFromAssemblyContaining(typeof(Program));
            builder.Services.AddHealthChecks().AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
