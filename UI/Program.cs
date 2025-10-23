using Business; // Manager sýnýflarýn
using Business.Interface; // Servis arayüzlerin
using DataAccess; // Repository sýnýflarýn
using DataAccess.Context; // DbContext'in (Scontext)
using DataAccess.Interface; // Repository arayüzlerin
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    ConfigureServices(services);
                })
                .Build();

            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<Main>());
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            services.AddSingleton<IConfiguration>(configuration);
            services.AddDbContext<Scontext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IMarka, MarkaD>();
            services.AddTransient<IKategori, KategoriD>();
            services.AddTransient<IIlac, IlacD>();
            services.AddTransient<IStok, StokD>();
            services.AddTransient<ISatis, SatisD>();
            services.AddTransient<ISatisDetay, SatisDetayD>();
            services.AddScoped<ITedarikci, TedarikciD>();
            services.AddTransient<IMarkaS, MarkaS>();
            services.AddTransient<IKategoriS, KategoriS>();
            services.AddTransient<IIlacS, IlacS>();
            services.AddTransient<IStokS, StokS>();
            services.AddTransient<ISatisS, SatisS>();
            services.AddTransient<ITedarikS, TedarikS>();



            services.AddTransient<Main>();
            services.AddTransient<frmIlaclar>();
            services.AddTransient<frmMarkalar>();
            services.AddTransient<frmKategoriler>();
            services.AddTransient<frmTedarikciler>();
            services.AddTransient<frmStokGiris>();

        }
    }
}