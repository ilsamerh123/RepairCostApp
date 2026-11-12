using RepairCostApp.Forms; 
using RepairCostApp.Repositories;
using RepairCostApp.Repositories.Implementations;
using Unity;
using RepairCostApp.Data;

namespace RepairCostApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var container = CreateContainer();

            Application.Run(container.Resolve<MainForm>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();
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