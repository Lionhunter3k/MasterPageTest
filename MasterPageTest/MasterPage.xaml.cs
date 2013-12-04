using Windows.UI.Xaml;

namespace MasterPageTest
{
    public sealed partial class MasterPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            NavigateService.Instance.NavigateToMainPage();
        }
        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            NavigateService.Instance.NavigateToSecondPage();
        }
        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            NavigateService.Instance.NavigateToLoginPage();
        }
    }
}
