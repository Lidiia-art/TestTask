using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testTask.Models;

namespace testTask.Services
{
    internal class DefaultValues
    {
        public static ObservableCollection<ImageItem> GetGroup1() => new()
        {
            new ImageItem
            {
                IsChecked = true,
                IconPath = "AoG.png",
            },
            new ImageItem
            {
                IconPath = "Same.png",
            },
            new ImageItem
            {
                IconPath = "Challenger.png",
            },
            new ImageItem
            {
                IconPath = "JohnDeere.png",
            },
            new ImageItem
            {
               IconPath = "JCB.png",
            },
        };

        public static ObservableCollection<ImageItem> GetGroup2() => new()
        {
            new ImageItem
            {
                IsChecked = true,
                IconPath = "AoG.png",
            },
            new ImageItem
            {
                IconPath = "JCB.png",
            },
            new ImageItem
            {
                IconPath = "Massey.png",
            },
            new ImageItem
            {
                IconPath = "JohnDeere.png",
            },
            new ImageItem
            {
                IconPath = "NewHolland.png",
            },
            new ImageItem
            {
                IconPath = "Challenger.png",
            },
             new ImageItem
            {
                IconPath = "NewHolland.png",
            }
        };

        public static Bitmap image = new Bitmap(AssetLoader.Open(new Uri("avares://testTask/Assets/icons/VehicleTypePage/TriangleVehicle.png")));

        public static Bitmap GetImage(string path)
        {
            return new Bitmap(AssetLoader.Open(new Uri("avares://testTask/Assets/icons/" + path)));
        }
    }

}
