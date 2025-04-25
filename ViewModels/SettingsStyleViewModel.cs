using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.ViewModels
{
    internal partial class SettingsStyleViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool isChecked = false;
    }
}
