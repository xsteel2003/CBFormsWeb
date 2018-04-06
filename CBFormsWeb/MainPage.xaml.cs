using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CBFormsWeb
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            myButton.Clicked += MyButton_Clicked;
        }
        void MyButton_Clicked(object sender, EventArgs e)
        {
            myLabel.Text = myEntry.Text;
        }
    }
}