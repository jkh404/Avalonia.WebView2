using WebView.Core.Models;
using WebView.Core;

namespace Avalonia.WebView
{
    partial class WebView
    {
        IWebViewCookies GetCookeisImpl()
        {
            if (_platformWebView is null || !_platformWebView.IsInitialized)
            {
                throw new InvalidOperationException("WebView is not initialized.");
            }

            if (_platformWebView is IWebViewCookies cookies)
            {
                return cookies;
            }

            throw new PlatformNotSupportedException("Cookies are not supported on this platform.");
        }

        public bool SupportsCookies
        {
            get
            {
                if (_platformWebView is null || !_platformWebView.IsInitialized)
                {
                    throw new InvalidOperationException("WebView is not initialized.");
                }

                return _platformWebView is IWebViewCookies;
            }
        }

        public Task AddCookie(AvaloniaWebViewCookie cookie)
        {
            return GetCookeisImpl().AddCookie(cookie);
        }

        public Task<List<AvaloniaWebViewCookie>?> GetCookies(string url)
        {
            return GetCookeisImpl().GetCookies(url);
        }

        public Task RemoveCookie(AvaloniaWebViewCookie cookie)
        {
            return GetCookeisImpl().RemoveCookie(cookie);
        }

        public Task ClearCookies()
        {
            return GetCookeisImpl().ClearCookies();
        }
    }

}

