using Microsoft.Maui.Controls;
using System;

namespace HomeworkApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Bind Slider and Stepper
            AgeSlider.ValueChanged += (s, e) => AgeStepper.Value = e.NewValue;
            AgeStepper.ValueChanged += (s, e) => AgeSlider.Value = e.NewValue;

            // Phone Number Entry TextChanged Logic
            PhoneNumberEntry.TextChanged += (s, e) =>
            {
                if (PhoneNumberEntry.Text.Length == 11)
                {
                    PhoneNumberEntry.TextColor = Colors.Green;
                }
                else
                {
                    PhoneNumberEntry.TextColor = Colors.Red;
                }
            };

            // Enable Submit Button when AgreementSwitch is ON
            AgreementSwitch.Toggled += (s, e) =>
            {
                SubmitButton.IsEnabled = e.Value;
            };
        }
    }
}