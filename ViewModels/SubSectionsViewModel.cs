using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testTask.Models;
using Tmds.DBus.Protocol;

namespace testTask.ViewModels
{
    internal partial class SubSectionsViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool boundary = true;

        [ObservableProperty]
        private bool choose1 = true;
        [ObservableProperty]
        private bool choose2 = false;

        [ObservableProperty]
        private string width;

        [ObservableProperty]
        private int count;

        [ObservableProperty]
        private string countZones1;

        [ObservableProperty]
        private string countZone2;

        [ObservableProperty]
        private int zones;

        [ObservableProperty]
        private double res;

        [ObservableProperty]
        public ObservableCollection<ComboItem> countItems = new ObservableCollection<ComboItem>();

        public SubSectionsViewModel()
        {
            width = "200";
            Count = 0;
            Zones = 1;
            countZones1 = "0";
            if (!choose1) {
                GenerateCountItems(countZones1, Zones);
                res = Convert.ToDouble(width) * (Convert.ToDouble(countZones1) + 1);
            }
            else
            {
                res = Convert.ToDouble(width) * (count + 1);
                for (int i = 1; i <= count + 1; i++)
                {
                    CountItems.Add(new ComboItem
                    {
                        Index = i,
                        Value1 = i
                    });
                }
            }
        }


        partial void OnCountChanged(int oldValue, int newValue)
        {
            try
            {
                if (newValue != -1)
                {
                    CountItems.Clear();
                    Count = newValue;
                    if(!string.IsNullOrWhiteSpace(Width))
                    Res = Convert.ToDouble(Width) * (Count + 1);
                    else Res = 1 * (Count + 1);
                    for (int i = 1; i <= Count + 1; i++)
                    {
                        CountItems.Add(new ComboItem
                        {
                            Index = i,
                            Value1 = i
                        });
                    }
                }
            }
            catch (Exception ex)
            { 
            
            }

        }

        partial void OnCountZones1Changed(string value)
        {
            try
            {
                GenerateCountItems(value, Zones);
            }
            catch (Exception ex)
            {

            }

        }
        partial void OnWidthChanged(string oldValue)
        {
            if (!string.IsNullOrWhiteSpace(Width))
                Width = oldValue;
            else Width = "1";

        }

        [RelayCommand]
        public void setChoose()
        {
            Count = 1;
            Zones= 1;
            CountZones1 = "1";
            Choose1 = !Choose1;
            Choose2 = !Choose2;
            Console.WriteLine();
        }

        [RelayCommand]
        public void setBound()
        {
            Boundary = !Boundary;
        }

        public void GenerateCountItems(string max, int count)
        {
            Res = Convert.ToDouble(Width) * (Convert.ToDouble(max) - 1);

            CountItems = new ObservableCollection<ComboItem>();
            var val = 0;
            if (!string.IsNullOrWhiteSpace(max))
                val = Convert.ToInt16(max);
            else val = 0;

            int index = 1;
            int current = 2;

            for (int i = 0; i < count; i++)
            {
                if (current + 2 > val)
                {
                    // останній елемент — встановити max, якщо наступний перевищить
                    CountItems.Add(new ComboItem
                    {
                        Index = index,
                        Value1 = current-2,
                        Value2 = val
                    });
                    break;
                }

                CountItems.Add(new ComboItem
                {
                    Index = index,
                    Value1 = current - 2,
                    Value2 = current
                });

                current += 2;
                index++;
            }
        }

    }
}
