using CoreImage;

namespace Avalonia.WebView.iOS.Core;

public partial class IosWebViewCore: IPlatformWebView<IosWebViewCore>, IWebViewCookies
{
    public Task AddCookie(AvaloniaWebViewCookie cookie)
    {
        var tcs = new TaskCompletionSource<bool>();

        WebView.Configuration.WebsiteDataStore.HttpCookieStore.SetCookie(new NSHttpCookie(cookie.Name, cookie.Value, cookie.Path, cookie.Domain),
            () =>
            {
                tcs.SetResult(true);
            });
        return tcs.Task;
    }

    public async Task<List<AvaloniaWebViewCookie>?> GetCookies(string url)
    {
        var cookies = await WebView.Configuration.WebsiteDataStore.HttpCookieStore.GetAllCookiesAsync();
        
        if (cookies.Length == 0)
            return null;

        return cookies.Select(cookie => new AvaloniaWebViewCookie(cookie.Name, cookie.Value, cookie.Path, cookie.Domain)).ToList();
    }

    public Task RemoveCookie(AvaloniaWebViewCookie cookie)
    {
        var tcs = new TaskCompletionSource<bool>();

        WebView.Configuration.WebsiteDataStore.HttpCookieStore.DeleteCookie(new NSHttpCookie(cookie.Name, cookie.Value, cookie.Path, cookie.Domain),
            () =>
            {
                tcs.SetResult(true);
            });
        return tcs.Task;
    }

    public Task ClearCookies()
    {
        var tcs = new TaskCompletionSource<bool>();

        WebView.Configuration.WebsiteDataStore.HttpCookieStore.GetAllCookies(cookies =>
        {
            foreach (var cookie in cookies)
            {
                WebView.Configuration.WebsiteDataStore.HttpCookieStore.DeleteCookie(cookie, () => { });
            }
            tcs.SetResult(true);
        });

        return tcs.Task;
    }
}

