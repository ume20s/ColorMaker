using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ColorMaker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // 赤スライダー
        void rSliderChanged(object sender, ValueChangedEventArgs args)
        {
            rLabel.Text = String.Format("赤: {0:D3}", (int)rSlider.Value);
            rDisplay.Color = Color.FromRgb((int)rSlider.Value, 0, 0);
            rgbDisp();
        }

        // 緑スライダー
        void gSliderChanged(object sender, ValueChangedEventArgs args)
        {
            gLabel.Text = String.Format("緑: {0:D3}", (int)gSlider.Value);
            gDisplay.Color = Color.FromRgb(0, (int)gSlider.Value, 0);
            rgbDisp();
        }

        // 青スライダー
        void bSliderChanged(object sender, ValueChangedEventArgs args)
        {
            bLabel.Text = String.Format("青: {0:D3}", (int)bSlider.Value);
            bDisplay.Color = Color.FromRgb(0, 0, (int)bSlider.Value);
            rgbDisp();
        }
        
        // カラーパネルの表示
        void rgbDisp()
        {
            rgbLabel.Text = "code = #" + String.Format("{0:X2}{1:X2}{2:X2}",
                                                       (int)rSlider.Value,
                                                       (int)gSlider.Value,
                                                       (int)bSlider.Value);
            rgbDisplay.Color = Color.FromRgb((int)rSlider.Value,
                                             (int)gSlider.Value,
                                             (int)bSlider.Value);
        }

    }
}
