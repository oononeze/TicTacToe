using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUI.ModuleManager
{
    public class GameModuleManager : IModule
    {
      
            IRegionManager regionManager;

            public GameModuleManager(IRegionManager regionManager)
            {
                this.regionManager = regionManager;
            }
            public void Initialize()
            {               
                regionManager.RegisterViewWithRegion("CopyrightRegion", typeof(Views.Copyright));
                regionManager.RegisterViewWithRegion("GameSelectorRegion", typeof(Views.ChooseGamePlay)); 
            }
        }
    }

