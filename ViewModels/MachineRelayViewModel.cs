using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testTask.Models;

namespace testTask.ViewModels
{
    internal partial class MachineRelayViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool isActiveBtn1 = false;

        [ObservableProperty]
        private bool isActiveBtn2 = false;

        [ObservableProperty]
        public ObservableCollection<ComboItem> itemsIndexes = new();

        public MachineRelayViewModel()
        {
            for (int i = 0; i < 15; i++) { 
            itemsIndexes.Add(new ComboItem { 
            
                index=0,
                value1 = i+1,
            });
            }

        }

        [RelayCommand]
        public void Clean()
        {
           
            for (int i = 0; i < ItemsIndexes.Count(); i++)
            {
                ItemsIndexes[i].Index = 0;

            }
        }

        [RelayCommand]
        public void Initial()
        {
            for (int i = 0; i < 3; i++)
            {
                ItemsIndexes[i].Index =i;
            }

            for (int i = 3; i < ItemsIndexes.Count(); i++)
            {
                ItemsIndexes[i].Index = 0;
            }
        }
    }
}
