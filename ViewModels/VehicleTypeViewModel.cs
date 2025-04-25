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


        private string currentGroup;

        public ICommand DecreaseCommand1 { get; }
        public ObservableCollection<ImageItem> Group1 { get; }
        public ObservableCollection<ImageItem> Group2 { get; }

        public ObservableCollection<ImageItem> Group3 { get; }


        public VehicleTypeViewModel()
        {
            Group1 = DefaultValues.GetGroup1();
            Group2 = DefaultValues.GetGroup2();
            Group3 = DefaultValues.GetGroup3();
            CurrentImage = DefaultValues.image;
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
                IsChecked1 = false;
                IsChecked2 = false;
                IsChecked3 = false;
            }
            else
            {
                IsChecked1 = true;
            }
            cleanGroup(currentGroup);
            CurrentImage = DefaultValues.image;
        }

        public void OnCheckedBChanged(ImageItem item)
        {
            CurrentImage = item.Icon;

            if (item.Group != currentGroup)
            {
                cleanGroup(currentGroup);
            }

            currentGroup = item.Group;

        }

        private void cleanGroup(string Group)
        {
            switch (Group)
            {
                case "Group1":
                    {
                        for (int i = 1; i < Group1.Count(); i++)
                        {
                            Group1[i].IsChecked = false;
                        }
                        break;
                    }

                case "Group2":
                    {
                        for (int i = 1; i < Group2.Count(); i++)
                        {
                            Group2[i].IsChecked = false;
                        }
                        break;
                    }

                case "Group3":
                    {
                        for (int i = 1; i < Group3.Count(); i++)
                        {
                            Group3[i].IsChecked = false;
                        }
                        break;
                    }

                default:
                    {

                        break;
                    }
            }
        }

    }
}
