using System.ComponentModel;
using Xamarin.Forms;
using PromedioDubi.ViewModels;

namespace PromedioDubi.Views
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