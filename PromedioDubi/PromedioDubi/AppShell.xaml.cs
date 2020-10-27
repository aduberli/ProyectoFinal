using System;
using System.Collections.Generic;
using PromedioDubi.ViewModels;
using PromedioDubi.Views;
using Xamarin.Forms;

namespace PromedioDubi
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
