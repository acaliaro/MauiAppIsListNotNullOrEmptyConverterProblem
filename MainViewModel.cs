using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;

namespace MauiApp4
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<string> lista;

        public MainViewModel()
        {
            Lista = new ObservableCollection<string>();
        }

        [RelayCommand]
        private void add()
        {
            Lista.Add("AAAAA");
        }


        [RelayCommand]
        private void remove()
        {
            if(Lista.Count > 0)
            {
                Lista.RemoveAt(0);
            }
        }


    }
}
