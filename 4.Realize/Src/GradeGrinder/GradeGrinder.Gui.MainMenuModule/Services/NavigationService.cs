using GradeGrinder.Gui.Interfaces.Services;

namespace GradeGrinder.Gui.MainMenuModule.Services
{
    public class NavigationService : INavigationService
    {
        #region Implementation of INavigationService

        public void Navigate(string viewName, string viewIdentifier, string regionName, bool createScopedRegionManager, object parameter)
        {
            //IRegionManager regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            //IRegion region = regionManager.Regions[regionName];
            //object existingView = region.GetView(viewIdentifier);

            //if (existingView == null) {
            //    object newView = ServiceLocator.Current.GetInstance<object>(viewName);
            //    IRegionManager scopedRegionManager = region.Add(newView, viewIdentifier, createScopedRegionManager);

            //    UserControl userControl = newView as UserControl;
            //    if (userControl != null) {
            //        object dataContext = userControl.DataContext;

            //        INeedsScopedRegionManager needingScopedRegionManager = dataContext as INeedsScopedRegionManager;
            //        if (needingScopedRegionManager != null)
            //            needingScopedRegionManager.SetRegionManager(scopedRegionManager);

            //        IAcceptsParameter acceptingParameter = dataContext as IAcceptsParameter;
            //        if (acceptingParameter != null)
            //            acceptingParameter.SetParameter(parameter);
            //    }

            //    region.Activate(newView);
            //}
            //else {
            //    region.Activate(existingView);
            //}
        }

        #endregion
    }
}
