using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuickXamarinFormsDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DatePickerId.Date = DateTime.Now;
            TimePickerId.Time = DateTime.Now.TimeOfDay;
        }

        private void ButtonId_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Notification", "Hello " + EntryId.Text, "Okay");
        }

        private void ButtonNavToPage1Id_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void SwitchId_Toggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Notification", "Switch Value " + e.Value.ToString(), "Okay");
        }

        private void SliderId_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LabelSliderValueId.Text = SliderId.Value.ToString();
        }
    }
}
