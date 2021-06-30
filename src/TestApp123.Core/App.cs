using Microsoft.EntityFrameworkCore;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TestApp123.Core.DAL;
using TestApp123.Core.Repository;
using TestApp123.Core.ViewModels.Home;

namespace TestApp123.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsDynamic();

            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsDynamic();

            Mvx.IoCProvider.RegisterType<Context>();
            Mvx.IoCProvider.Resolve<Context>().Database.Migrate();

            Mvx.IoCProvider.RegisterType(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            Mvx.IoCProvider.RegisterType<IUnitOfWork, UnitOfWork>();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
