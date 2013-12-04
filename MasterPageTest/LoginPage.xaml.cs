using Windows.UI.Xaml;
namespace MasterPageTest
{
    public sealed partial class LoginPage
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            NavigateService.Instance.NavigateToMainPage();
        }
    }
}
