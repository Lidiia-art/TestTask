using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTask.Models
{
    public partial class ComboItem : ObservableObject
    {
        [ObservableProperty]
        public int index;

        [ObservableProperty]
        public int value1;

        [ObservableProperty]
        public int value2;


        [ObservableProperty]
        public bool last;

    }
}
