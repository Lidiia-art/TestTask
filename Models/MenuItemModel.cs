using Avalonia;
using Avalonia.Controls;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace testTask.Models
{
    public  partial class MenuItemModel : ObservableObject
    {
        [ObservableProperty]
        private bool isExpanded;

        [ObservableProperty]
        private bool isActive;

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
                Icon = new Bitmap(AssetLoader.Open(new Uri("avares://testTask/Assets/icons/sideBarIcons/" + path)));
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"Помилка завантаження іконки: {ex.Message}");
            }
        }

        public ObservableCollection<MenuItemModel>? Children { get; set; }

        public bool HasChildren => Children != null && Children.Any();

        private void Toggle()
        {
            if (HasChildren)
            {
                IsExpanded = !IsExpanded;
            }

             SetActive();
        }

        private void SetActive()
        {
            if (!HasChildren)
            {
                IsActive = true;
            }

            if (HasChildren)
            {
                Console.WriteLine("set");
                Children?.First().SetActive(); 
            }
        }

    }
}
