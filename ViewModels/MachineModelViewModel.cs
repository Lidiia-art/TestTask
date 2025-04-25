using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.ViewModels
{
    internal partial class MachineModelViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool isActive = false;

        [ObservableProperty]
        private bool isActiveRele = false;

        [RelayCommand]
        public void changeActive()
        {
            IsActive = !IsActive;
        }

        [RelayCommand]
        public void changeRele()
        {
            IsActiveRele = !IsActiveRele;
        }
    }
}
