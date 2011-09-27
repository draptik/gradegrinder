using Microsoft.Practices.Prism.Regions;

namespace GradeGrinder.Gui.Interfaces.Misc
{
    public interface INeedsScopedRegionManager
    {
        void SetRegionManager(IRegionManager scopedRegionManager);
    }
}
