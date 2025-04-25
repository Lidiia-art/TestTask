using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using testTask.Models;
using testTask.Services;

namespace testTask.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private object? currentPage = new DefaultComponentViewModel();
        public ObservableCollection<MenuItemModel> Items { get; }

        public ICommand SelectItemCommand { get; }

        public MainWindowViewModel()
        {
            Items = MenuProvider.GetMenuItems();
            SelectItemCommand = new RelayCommand<MenuItemModel>(SelectItem);
        }

        private void SelectItem(MenuItemModel item)
        {
            if (item.Children == null || !item.Children.Any())
            {
                if (!item.IsActive)
                {
                    item.IsActive = true;
                    NavigateTo(item.IconPath);
                }
                else
                {
                    item.IsActive = false;
                    CurrentPage = new DefaultComponentViewModel();
                };
            }
            else
            {
                item.IsExpanded = !item.IsExpanded;
                if(item.IsExpanded ==false)
                 CurrentPage = new DefaultComponentViewModel();


                var firstChild = item.Children.FirstOrDefault();
                if (firstChild != null && item.IsExpanded)
                {
                  
                    if (item.IsExpanded)
                    {
                        NavigateTo(firstChild.IconPath);
                    }
                    foreach (var child in item.Children)
                    {
                        child.IsActive = (child == firstChild);
                    }
                    
                }
            }

            foreach (var otherItem in Items)
            {
                if (otherItem != item )
                {
                    otherItem.IsActive = false;
                    if(otherItem.Children?.Contains(item)==false)
                    otherItem.IsExpanded = false;
                    foreach (var child in otherItem.Children ?? new ObservableCollection<MenuItemModel>())
                    {
                        if (child != item)
                            child.IsActive = false;
                    }
                }
            }
        }

        private void NavigateTo(string pageKey)
        {
             CurrentPage = pageKey switch
             {
                 "ConS_ImplementConfig.png" => new VehicleTypeViewModel(),
                 "ConS_ImplementHitch.png" => new ImplementHitchViewModel(),
                 "ConS_ImplementAntenna.png" => new ImplementAntennaViewModel(),
                 "ConS_ImplementConfig2.png" => new SettingsStyleViewModel(),
                 "ConS_ImplementHitch2.png" => new UnitsViewModel(),
                 "ConS_ImplementPivot.png" => new ImplementPivotViewModel(),
                 "ConS_ImplementOffset.png" => new ImplementOffsetViewModel(),
                 "ConS_ImplementSection.png" => new SubSectionsViewModel(),
                 "ConS_ImplementSwitch.png" => new ImplementSwitchViewModel(),
                 "ConS_ImplementSettings.png" => new ImplementSettingsViewModel(),
                 "ConS_SourcesHeading.png" => new SourcesHeadingViewModel(),
                 "ConS_SourcesRoll.png" => new SourcesRollViewModel(),
                 "Con_UTurnMenu.png" => new UTurnMenuViewModel(),
                 "ConS_ModulesMachine.png" => new MachineModelViewModel(),
                 "ConS_Pins.png" => new MachineRelayViewModel(),
                 "Con_TramMenu.png" => new TramMenuViewModel(),
                 "Con_FeatureMenu.png" => new DisplayViewModel(),
                 "Con_Display.png"  => new FeatureMenuViewModel(),
                 _ => null
             };
        }
    }
}
