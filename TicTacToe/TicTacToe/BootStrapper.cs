using GameUI.ModuleManager;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Windows;

namespace TicTacToe
{
    class BootStrapper: UnityBootstrapper
    {

            protected override DependencyObject CreateShell()
            {
                return Container.TryResolve<GameShell>();
            }

            protected override void InitializeModules()
            {
                base.InitializeModules();
                Application.Current.MainWindow = (GameShell)Shell;
                Application.Current.MainWindow.Show();
            }

            protected override void ConfigureModuleCatalog()
            {
                base.ConfigureModuleCatalog();
                ModuleCatalog moduleCatalog = (ModuleCatalog)ModuleCatalog;
                 moduleCatalog.AddModule(typeof(GameModuleManager));
            }
        }
}
