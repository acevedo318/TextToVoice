using System.ComponentModel;
using TextToVoice.ViewModels;
using Xamarin.Forms;

namespace TextToVoice.Views
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