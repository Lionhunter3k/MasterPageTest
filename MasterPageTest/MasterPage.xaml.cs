using System;
using Windows.UI.Xaml;

namespace MasterPageTest
{
    public sealed partial class MasterPage
    {
        public MasterPage()
        {
            InitializeComponent();
            Loaded += delegate
            {
                search.Text = DateTime.Now.Millisecond + "";
            };
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            NavigateService.Instance.Navigate(typeof(MainPage), typeof(MasterPage));
        }
        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            NavigateService.Instance.Navigate(typeof(SecondPage), typeof(MasterPage));
        }
        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            NavigateService.Instance.Navigate(typeof(LoginPage));
        }
    }
}
