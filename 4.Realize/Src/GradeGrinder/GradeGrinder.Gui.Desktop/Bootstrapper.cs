using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;

namespace GradeGrinder.Gui.Desktop
{
    public class Bootstrapper : UnityBootstrapper
    {
        #region Overrides of Bootstrapper

        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)Shell;
            Application.Current.MainWindow.Show();
        }

        #region Configure ModuleCatalog via app.config
        
        /// <summary>
        /// Use this method when configuring the ModuleCatalog via app.config.
        /// Be sure to comment the methods 'ConfigureModuleCatalog' and 'InitializeModules'.
        /// </summary>
        /// <returns></returns>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }
        
        #endregion
        
        #region Configure ModuleCatalog from Code

        //protected override void ConfigureModuleCatalog()
        //{
        //    ModuleCatalog catalog = new ConfigurationModuleCatalog();
        //    base.ConfigureModuleCatalog();

        //    //ModuleCatalog moduleCatalog = (ModuleCatalog)ModuleCatalog;
        //    //moduleCatalog.AddModule(new ModuleInfo(ModuleNames.MainMenuModule, "GradeGrinder.MainMenuModule.MainMenuModule, GradeGrinder.MainMenuModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
        //    //moduleCatalog.AddModule(new ModuleInfo(ModuleNames.StatusBarModule, "GradeGrinder.StatusBarModule.StatusBarModule, GradeGrinder.StatusBarModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
        //    //moduleCatalog.AddModule(new ModuleInfo(ModuleNames.CustomerDataModule, "GradeGrinder.CustomerDataModule.CustomerDataModule, GradeGrinder.CustomerDataModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ModuleNames.MasterDataModule, ModuleNames.MainMenuModule));
        //    //moduleCatalog.AddModule(new ModuleInfo(ModuleNames.MasterDataModule, "GradeGrinder.MasterDataModule.MasterDataModule, GradeGrinder.MasterDataModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"));
        //}

        //protected override void InitializeModules()
        //{
        //    base.InitializeModules();

        //    //ServiceLocator.Current.GetInstance<IStatusBarService>().ShowStatusText("Ready");
        //}

        #endregion

        #endregion
    }
}
