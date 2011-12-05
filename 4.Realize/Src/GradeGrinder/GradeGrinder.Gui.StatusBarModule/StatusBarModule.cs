using GradeGrinder.Gui.Interfaces.ViewModels;
using GradeGrinder.Gui.Interfaces.Views;
using GradeGrinder.Infrastructure.Constants;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace GradeGrinder.Gui.StatusBarModule
{
    public class StatusBarModule : IModule
    {
        #region fields

        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        #endregion

        #region constructors

        public StatusBarModule(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        #endregion

        #region Implementation of IModule
        
        public void Initialize()
        {
            _container.RegisterType<IStatusBarViewModel, ViewModels.StatusBarViewModel>();
            _container.RegisterType<IStatusBarView, Views.StatusBarView>();
            _regionManager.RegisterViewWithRegion(RegionNames.StatusBarRegion, typeof(IStatusBarView));
        }

        #endregion
    }
}
