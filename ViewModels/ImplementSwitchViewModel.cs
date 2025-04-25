using Avalonia.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;

namespace testTask.ViewModels
{
    internal partial class ImplementSwitchViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool isActiveBtn1 = false;

        [ObservableProperty]
        private bool isActiveBtn2 = false;

        [ObservableProperty]
        private bool notActive1 = true;

        [ObservableProperty]
        private bool notActive2 = true;

        [ObservableProperty]
        private bool check = false;


        [RelayCommand]
        public void Active1()
        {
            IsActiveBtn1 = !IsActiveBtn1;
            NotActive1 = !IsActiveBtn1;
        }

        [RelayCommand]
        public void Active2()
        {
            IsActiveBtn2 = !IsActiveBtn2;

            NotActive2 = !IsActiveBtn2; 
        }

        [RelayCommand]
        public void CheckImage()
        {
            Check = !Check;
        }
    }
}
