using Avalonia.Interactivity;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using testTask.Models;
using testTask.Services;

namespace testTask.ViewModels
{
    internal partial class VehicleTypeViewModel : ViewModelBase
    {

        [ObservableProperty]
        private bool isChecked1 = true;

        [ObservableProperty]
        private bool isChecked2 = false;

        [ObservableProperty]
        private bool isChecked3 = false;

        [ObservableProperty]
        private double opacity = 0.2;

        [ObservableProperty]
        private Bitmap currentImage;
        public ICommand DecreaseCommand1 { get; }
        public ObservableCollection<ImageItem> Group1 { get; }
        public ObservableCollection<ImageItem> Group2 { get; }

        public ObservableCollection<ImageItem> Group3 { get; }
    

        public VehicleTypeViewModel()
        {
            Group1 = DefaultValues.GetGroup1();
            Group2 = DefaultValues.GetGroup2();
            CurrentImage = Group1[0].icon;
        }

        [RelayCommand]
        private void Increase()
        {
            if (Opacity < 1)
            {
                Opacity += 0.2;
            }
        }

        [RelayCommand]
        private void Decrease()
        {
            if (Opacity > 0.2)
            {
                Opacity -= 0.2;
            }
        }
    
        [RelayCommand]
        private void NoImage()
        {
            if (CurrentImage != DefaultValues.image || IsChecked1 == true)
            {
                CurrentImage = DefaultValues.image;
                IsChecked1 = false;
                IsChecked2 = false;
                IsChecked3 = false;
            }
            else
            {
                IsChecked1 = true;
            }
        }

        public void OnCheckedBChanged(ImageItem item)
        {
            CurrentImage = item.icon;
        }

    }
}
