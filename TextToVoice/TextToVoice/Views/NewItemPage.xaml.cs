using System;
using System.Collections.Generic;
using System.ComponentModel;
using TextToVoice.Models;
using TextToVoice.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextToVoice.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}