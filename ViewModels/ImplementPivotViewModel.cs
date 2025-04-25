using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.ViewModels
{
    internal partial class ImplementPivotViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string value = "0";

        [RelayCommand]
        public void Clean()
        {
            Value = "0";
        }
    }
}
