using GradeGrinder.Infrastructure.Constants;
using GradeGrinder.Interfaces.Services;
using GradeGrinder.Interfaces.ViewModels;
using GradeGrinder.Interfaces.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace GradeGrinder.MainMenuModule
{
    public class MainMenuModule : IModule
    {
        #region fields

        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        #endregion

        #region constructors

        public MainMenuModule(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        #endregion

        #region Implementation of IModule

        public void Initialize()
        {
            //_container.RegisterInstance<INavigationService>(new Services.NavigationService(), new ContainerControlledLifetimeManager());

            _container.RegisterType<IMainMenuViewModel, ViewModels.MainMenuViewModel>();
            _container.RegisterType<IMainMenuView, Views.MainMenuView>();
            _regionManager.RegisterViewWithRegion(RegionNames.MainMenuRegion, typeof(IMainMenuView));

 
        }

        #endregion
    }
}
