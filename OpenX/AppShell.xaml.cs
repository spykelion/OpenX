using OpenX;
using OpenX.ViewModels;
using OpenX.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace OpenX
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
       // public ListView ListView;
       // public Label LogoutLinkLabel;
      //  public Grid HeaderGrid;

        public AppShell()
        {
            InitializeComponent();
        }

        class ViewModelFlyoutItem
        {
            public ObservableCollection<FlyoutMenuItem> MenuItems { get; set; }
          //  public FlyoutMenuItem LogOutLink { get; set; }

            public ViewModelFlyoutItem()
            {
                int IdCount = 0;
                MenuItems = new ObservableCollection<FlyoutMenuItem>(new[]
                {
                  
                    new FlyoutMenuItem { Id = IdCount++, Title = "Devices as Member",TargetType = typeof(Nullable), Icon = "my_devices_icon.png" },         
                    new FlyoutMenuItem { Id = IdCount++, Title = "Guest Schedules", TargetType = typeof(Nullable), Icon = "guest_icon.png" },                 
                    new FlyoutMenuItem { Id = IdCount++, Title = "Panic Setup", TargetType = typeof(Nullable), Icon = "panic_icon.png" },
                    new FlyoutMenuItem { Id = IdCount++, Title = "Messages", TargetType = typeof(Nullable), Icon = "message.jpg" }
                });
              
            }
        }
        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
