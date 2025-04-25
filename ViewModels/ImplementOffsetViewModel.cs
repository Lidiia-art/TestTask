using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.ViewModels
{
    internal  partial class ImplementOffsetViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string value1 = "0";

        [ObservableProperty]
        private string value2 = "0";

        [RelayCommand]
        public void Clean1()
        {
            Value1 = "0";
        }

        [RelayCommand]
        public void Clean2()
        {
            Value2 = "0";
        }

    }
}
