using Avalonia.Media.Imaging;
using Avalonia.Platform;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.Models
{
    internal partial class ImageItem : ObservableObject
    {
        [ObservableProperty]
        public bool isChecked = false;

        [ObservableProperty]
        public Bitmap? icon;

        private string? iconPath;
        public string? IconPath
        {
            get => iconPath;
            set
            {
                SetProperty(ref iconPath, value);
                LoadIconFromPath(iconPath);
            }
        }

        private void LoadIconFromPath(string path)
        {
            try
            {
                Icon = new Bitmap(AssetLoader.Open(new Uri("avares://testTask/Assets/icons/VehicleTypePage/" + path)));
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Помилка завантаження іконки: {ex.Message}");
            }
        }
    }
}
