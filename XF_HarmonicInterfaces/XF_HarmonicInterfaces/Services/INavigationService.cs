using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XF_HarmonicInterfaces.Services
{
    public interface INavigationService
    {
        Page MainPage { get; }

        void Configure(string key, Type pageType);

        void GoBack();

        void NavigateTo(string pageKey, object parameter = null);
    }
}
