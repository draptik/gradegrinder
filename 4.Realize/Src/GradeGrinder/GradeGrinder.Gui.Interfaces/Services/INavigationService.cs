namespace GradeGrinder.Gui.Interfaces.Services
{
    public interface INavigationService
    {
        void Navigate(string viewName, string viewIdentifier, string regionName, bool createScopedRegionManager, object parameter);
    }
}
