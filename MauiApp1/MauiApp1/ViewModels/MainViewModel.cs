using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Models;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    int foo = 18;

    [ObservableProperty]
    public ObservableCollection<MyThing> myStuff = [
        new MyThing { Name = "Thing 1", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 2", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 3", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 4", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 5", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 6", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 7", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 8", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 9", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 10", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 11", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 12", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 13", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 14", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 15", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 16", ImageUrl = "https://picsum.photos/500" },
        new MyThing { Name = "Thing 17", ImageUrl = "https://picsum.photos/500" },
    ];

    [RelayCommand]
    public void LoadMore()
    {
        MyStuff.Add(new MyThing { Name = $"Thing {foo++}", ImageUrl = "https://picsum.photos/500" });
    }
}
