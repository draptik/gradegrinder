using Microsoft.Practices.Prism.Regions;

namespace GradeGrinder.Interfaces.Misc
{
    public interface INeedsScopedRegionManager
    {
        void SetRegionManager(IRegionManager scopedRegionManager);
    }
}
