using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace logicielfactpdaniel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            double CalculatePyramidVolume(double baseArea, double height)
            {
                double volume = NewMethod(baseArea, height);
                return volume;
            }
        }

        private static double NewMethod(double baseArea, double height)
        {
            return (baseArea * height) / 3;
        }


    }
}
