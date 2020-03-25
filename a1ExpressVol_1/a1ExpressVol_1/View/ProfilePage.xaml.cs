using a1ExpressVol_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a1ExpressVol_1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public List<Data> people = new List<Data>()
        {
            new Data{Name="Durganand", Address="Bara"},
            new Data{Name="Mukesh", Address="Bara Kakadi"},
            new Data{Name="Baiju", Address="Bara Nepal"}
        };
        public ProfilePage()
        {
            InitializeComponent();
            mylist.ItemsSource = people;
        }
    }
}