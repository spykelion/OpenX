using OpenX.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace OpenX.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}