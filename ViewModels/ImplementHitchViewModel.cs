using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.ViewModels
{
    internal partial class ImplementHitchViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool isActiveBtn1 = false;

        [ObservableProperty]
        private bool isActiveBtn2 = false;
    }
}
