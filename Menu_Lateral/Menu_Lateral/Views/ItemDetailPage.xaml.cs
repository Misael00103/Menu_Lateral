using Menu_Lateral.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Menu_Lateral.Views
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