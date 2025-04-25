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
                IconPath = "AoG.png",
                Group="Group1"
            },
            new ImageItem
            {
                IconPath = "Same.png",
                Group="Group1"
            },
            new ImageItem
            {
                IconPath = "Challenger.png",
                Group="Group1"
            },
            new ImageItem
            {
                IconPath = "JohnDeere.png",
                Group="Group1"
            },
            new ImageItem
            {
               IconPath = "JCB.png",
               Group="Group1"
            },
        };

        public static ObservableCollection<ImageItem> GetGroup2() => new()
        {
            new ImageItem
            {
                IconPath = "AoG.png",
                Group="Group2"
            },
            new ImageItem
            {
                IconPath = "JCB.png",
                Group="Group2"
            },
            new ImageItem
            {
                IconPath = "Massey.png",
                Group="Group2"
            },
            new ImageItem
            {
                IconPath = "JohnDeere.png",
                Group="Group2"
            },
            new ImageItem
            {
                IconPath = "NewHolland.png",
                Group="Group2"
            },
            new ImageItem
            {
                IconPath = "Challenger.png",
                Group="Group2"
            },
             new ImageItem
            {
                IconPath = "NewHolland.png",
                Group="Group2"
            }
        };


        public static ObservableCollection<ImageItem> GetGroup3() => new()
        {
            new ImageItem
            {
                IconPath = "AoG.png",
                Group="Group3"
            },
            new ImageItem
            {
                IconPath = "JCB.png",
                Group="Group3"
            },
            new ImageItem
            {
                IconPath = "Massey.png",
                Group="Group3"
            },
            new ImageItem
            {
                IconPath = "JohnDeere.png",
                Group="Group3"
            },
            new ImageItem
            {
                IconPath = "NewHolland.png",
                Group="Group3"
            },
            new ImageItem
            {
                IconPath = "Challenger.png",
                Group="Group3"
            },
             new ImageItem
            {
                IconPath = "NewHolland.png",
                Group="Group3"
            }
        };

        public static Bitmap image = new Bitmap(AssetLoader.Open(new Uri("avares://testTask/Assets/icons/VehicleTypePage/TriangleVehicle.png")));

        public static Bitmap GetImage(string path)
        {
            return new Bitmap(AssetLoader.Open(new Uri("avares://testTask/Assets/icons/" + path)));
        }
    }

}
