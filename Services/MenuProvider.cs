using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testTask.Models;

namespace testTask.Services
{
    internal class MenuProvider
    {
        public static ObservableCollection<MenuItemModel> GetMenuItems() => new()
      {
        new MenuItemModel
        {
            IconPath = "Con_VehicleMenu.png",
            Children = new ObservableCollection<MenuItemModel>
            {
                new MenuItemModel {  IconPath = "ConS_ImplementConfig.png" },
                new MenuItemModel {  IconPath = "ConS_ImplementHitch.png" },
                new MenuItemModel {  IconPath = "ConS_ImplementAntenna.png" }
            }
        },
        new MenuItemModel
        {
            IconPath = "Con_ImplementMenu.png",
            Children = new ObservableCollection<MenuItemModel>
            {
                new MenuItemModel {  IconPath = "ConS_ImplementConfig2.png" },
                new MenuItemModel {  IconPath = "ConS_ImplementHitch2.png" },
                new MenuItemModel {  IconPath = "ConS_ImplementPivot.png" },
                new MenuItemModel {  IconPath = "ConS_ImplementOffset.png" },
                new MenuItemModel {  IconPath = "ConS_ImplementSection.png" },
                new MenuItemModel {  IconPath = "ConS_ImplementSettings.png" },
                new MenuItemModel {  IconPath = "ConS_ImplementSwitch.png" },
            }
        },
        new MenuItemModel
        {
            IconPath = "Con_SourcesMenu.png",
            Children = new ObservableCollection<MenuItemModel>
            {
                new MenuItemModel { IconPath = "ConS_SourcesHeading.png" },
                new MenuItemModel { IconPath = "ConS_SourcesRoll.png" }
            }
        },
        new MenuItemModel { IconPath = "Con_UTurnMenu.png" },
        new MenuItemModel
        {
            IconPath = "Con_ModulesMenu.png",
            Children = new ObservableCollection<MenuItemModel>
            {
                new MenuItemModel { IconPath = "ConS_ModulesMachine.png" },
                new MenuItemModel { IconPath = "ConS_Pins.png" }
            }
        },
        new MenuItemModel { IconPath = "Con_TramMenu.png" },
        new MenuItemModel { IconPath = "Con_Display.png" },
        new MenuItemModel { IconPath = "Con_FeatureMenu.png" },
    };
    }
}
