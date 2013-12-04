using System;
using Windows.UI.Xaml.Controls;

namespace MasterPageTest
{
    public class NavigateService
    {
        private static readonly Lazy<NavigateService> lazy = new Lazy<NavigateService>(() => new NavigateService());
        public static NavigateService Instance { get { return lazy.Value; } }

        public Frame Frame { get; set; }

        public void NavigateToLoginPage()
        {
            Frame.Navigate(typeof(LoginPage));
        }

        public void NavigateToMainPage()
        {
            Navigate(typeof(MainPage), typeof(MasterPage));
        }

        public void NavigateToSecondPage()
        {
            Navigate(typeof(SecondPage), typeof(MasterPage));
        }

        public void Navigate(Type pageType, Type masterPageType)
        {
            Page masterPage = Frame.Content as Page;
            if (masterPage != null && masterPage.GetType() != masterPageType)
            {
                Frame.Navigate(masterPageType);
                masterPage = Frame.Content as Page;
            }
            var contentFrame = masterPage.FindName("ContentFrame") as Frame;
            contentFrame.Navigate(pageType);
        }
    }
}