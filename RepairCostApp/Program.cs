using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RepairCostApp.Data;
using RepairCostApp.Forms;
using RepairCostApp.Repositories;
using RepairCostApp.Repositories.Implementations;
using Serilog;
using Serilog.Extensions.Logging;
using Unity;
using Unity.Microsoft.Logging;

namespace RepairCostApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            var loggerFactory = new LoggerFactory().AddSerilog(Log.Logger);

            var container = CreateContainer(loggerFactory);

            Application.Run(container.Resolve<MainForm>());
        }

        private static IUnityContainer CreateContainer(ILoggerFactory loggerFactory)
        {
            var container = new UnityContainer();


            container.AddExtension(new LoggingExtension(loggerFactory));


            container.RegisterType<DataContext>();


            container.RegisterType<IRoomRepository, RoomRepository>();
            container.RegisterType<IContractorRepository, ContractorRepository>();
            container.RegisterType<ICostArticleRepository, CostArticleRepository>();
            container.RegisterType<IRepairWorkRepository, RepairWorkRepository>();
            container.RegisterType<IEstimateRepository, EstimateRepository>();

            return container;
        }
    }
}