using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.ViewModels
{
    internal partial class DefaultComponentViewModel : ViewModelBase
    {
       
        [ObservableProperty]
        private bool isActiveBtn1 = false;

        [ObservableProperty]
        private bool isActiveBtn2 = false;

        [ObservableProperty]
        private bool isActiveBtn3 = false;

        [ObservableProperty]
        private bool iswaitBtn1 = false;

        [ObservableProperty]
        private bool iswaitBtn2 = false;

        [ObservableProperty]
        private string name = "";

        [ObservableProperty]
        private string fromDisc = "";

        private ObservableCollection<string> items = new();

        [ObservableProperty]
        private string itemsText;

        public DefaultComponentViewModel()
        {
            items.CollectionChanged += OnItemsChanged;

        }

        private void OnItemsChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            ItemsText = string.Join("\n", items);
        }

        [RelayCommand]
        private void Clean()
        {
            items.Clear();
        }


        [RelayCommand]
        private void AddItem(string? newItem)
        {
            if (!string.IsNullOrWhiteSpace(newItem))
            {
                items.Add(newItem);
                IsActiveBtn3 = true;
            }
        }

        //автоматично
        partial void OnNameChanged(string value)
        {
            if (IsActiveBtn2) { IswaitBtn2 = true; }
            IsActiveBtn1 = !string.IsNullOrWhiteSpace(value);
            IswaitBtn1 = !IsActiveBtn1;
        }

        partial void OnFromDiscChanged(string value)
        {
            if (IsActiveBtn1) { IswaitBtn1 = true; }
            IsActiveBtn2 = !string.IsNullOrWhiteSpace(value);
            IswaitBtn2 = !IsActiveBtn2;
        }
    }
}
