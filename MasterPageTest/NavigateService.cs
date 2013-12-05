using System;
using Windows.UI.Xaml.Controls;

namespace MasterPageTest
{
    public class NavigateService
    {
        private static readonly Lazy<NavigateService> lazy = new Lazy<NavigateService>(() => new NavigateService());
        public static NavigateService Instance { get { return lazy.Value; } }

        public Frame Frame { get; set; }

        public void Navigate(Type pageType)
        {
            Frame.Navigate(pageType);
        }

        public void Navigate(Type pageType, Type masterPageType)
        {
            var masterPage = Frame.Content as Page;
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