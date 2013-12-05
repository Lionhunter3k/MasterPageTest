using Windows.UI.Xaml;
namespace MasterPageTest
{
    public sealed partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            NavigateService.Instance.Navigate(typeof(MainPage), typeof(MasterPage));
        }
    }
}
