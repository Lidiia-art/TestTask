using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.ViewModels
{
    internal partial class SourcesRollViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool isActiveBtn1 = false;

        [ObservableProperty]
        private bool isActiveBtn2 = false;

        [ObservableProperty]
        private bool isActiveBtn3 = false;

        [ObservableProperty]
        private bool isActiveBtn4 = false;

        [ObservableProperty]
        private string value = "0.00";

        [ObservableProperty]
        private int valueSlider = 20;


        [RelayCommand]
        public void ChangeValue()
        {
           
            Value = "***";
            
        }


        partial void OnIsActiveBtn1Changed(bool value)
        {
            if (Value == "***")
            {
                Value = "0.00";
            }
        }

        partial void OnIsActiveBtn2Changed(bool value)
        {

            if (Value == "0.00")
            {
                Value = "***";
            }
        }

        partial void OnIsActiveBtn3Changed(bool value)
        {

            
        }

        [RelayCommand]
        public void ChangeActiveBtn4()
        {
            IsActiveBtn4 = !IsActiveBtn4;
        }

        partial void OnValueSliderChanged(int value)
        {
            ValueSlider = value;
        }

    }
}
