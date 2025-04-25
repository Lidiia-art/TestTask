using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.ViewModels
{
    internal partial class SourcesHeadingViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool isActiveBtn1 = false;

        [ObservableProperty]
        private bool isActiveBtn2 = true;

        [ObservableProperty]
        private bool mute = false;

        [ObservableProperty]
        private bool step = false;

        [ObservableProperty]
        private bool fixAlarm = true;

        [ObservableProperty]
        private bool alarmStop = false;

        [ObservableProperty]
        private bool reverse = false;

        [ObservableProperty]
        private string min = "5 cm";

        [ObservableProperty]
        private string fix = "50 cm";

        [ObservableProperty]
        private double sliderValue=70;

        [ObservableProperty]
        private string left = "15%";

        [ObservableProperty]
        private string have = "95%";

        [RelayCommand]
        public void ChangeStep()
        {
            Step = !Step;

            if (Step)
            {
                Min = "10 cm";
                Fix = "100 cm";
            }
            else 
            {
                Min = "5 cm";
                Fix = "50 cm";
            }
        }

        [RelayCommand]
        public void isActiveBtn1Change()
        {
            IsActiveBtn1 = !IsActiveBtn1;
        }

        [RelayCommand]
        public void isActiveBtn2Change()
        {
            IsActiveBtn2 = !IsActiveBtn2;
        }

        [RelayCommand]
        public void SetFixAlrm()
        {
            FixAlarm = !FixAlarm;
        }

        [RelayCommand]
        public void SetAlrmStop()
        {
            AlarmStop = !AlarmStop;
        }


        [RelayCommand]
        public void MuteSet()
        {
            Mute = true;
        }

        [RelayCommand]
        public void SetReverse()
        {
            Reverse = !Reverse;
        }

        partial void OnSliderValueChanged(double value)
        {
            Left = Convert.ToString(Math.Round(100 - value)) + "%";
            Have = Convert.ToString(Math.Round(100 - (100 - value))) + "%";

        }
    }
}
