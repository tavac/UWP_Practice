using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_LessonPlanner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page2 : Page
    {
        public Page2()
        {
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(1920, 1080));
            this.InitializeComponent();
            bool rtn = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TryResizeView(new Size(1920, 1080));
        }

        static System.Timers.Timer _Timer = new System.Timers.Timer();
        int _Stop = 0;

        //private void This_Loaded(object sender, RoutedEventArgs e)
        //{
        //    _Timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Tick);
        //    _Timer.Interval = (20);

        //    resize(1920, 1080);
        //}

        //double _RatioHeight, _RatioWidth;
        //private void timer_Tick(Object myObject, EventArgs myEventArgs)
        //{
        //    if (_Stop == 0)
        //    {
        //        _RatioHeight = ((this.Height - Height) / 12) * -1;
        //        _RatioWidth = ((this.Width - Width) / 12) * -1;
        //    }
        //    _Stop++;

        //    this.Height += _RatioHeight;
        //    this.Width += _RatioWidth;

        //    if (_Stop == 12)
        //    {
        //        _Timer.Stop();
        //        _Timer.Enabled = false;
        //        _Timer.Dispose();

        //        _Stop = 0;

        //        this.Height = Height;
        //        this.Width = Width;
        //    }
        //}

        //public void resize(double _PassedHeight, double _PassedWidth)
        //{
        //    Height = _PassedHeight;
        //    Width = _PassedWidth;

        //    _Timer.Enabled = true;
        //    _Timer.Start();
        //}
    }
}
