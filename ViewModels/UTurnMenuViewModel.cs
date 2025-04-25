using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.ViewModels
{
    internal partial class UTurnMenuViewModel : ViewModelBase
    {
        [ObservableProperty]
        private int value1 = 20;

        [ObservableProperty]
        private int value2 = 30;


        [RelayCommand]
        public void IncrementVal1()
        {
            Value1++;
        }

        [RelayCommand]
        public void IncrementVal2()
        {
            Value2= Value2 + 2;
        }

        [RelayCommand]
        public void DecrementVal1()
        {
            Value1--;
        }

        [RelayCommand]
        public void DecrementVal2()
        {
            Value2= Value2 - 2;
        }
    }
}
