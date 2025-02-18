namespace Avalonia.WebView.Windows.Core;

public partial class WebView2Core : IPlatformWebView<WebView2Core>, IWebViewCookies
{


    public Task AddCookie(AvaloniaWebViewCookie cookie)
    {
        _coreWebView2Controller?.CoreWebView2.CookieManager.CreateCookie(cookie.Name, cookie.Value, cookie.Domain,
            cookie.Path);
        
        return Task.CompletedTask;
    }

    public async Task<List<AvaloniaWebViewCookie>?> GetCookies(string url)
    {
        if (_coreWebView2Controller is null)
        {
            return null;
        }
        
        var cookies = await _coreWebView2Controller.CoreWebView2.CookieManager.GetCookiesAsync(url);
        
        return cookies.Select(c => new AvaloniaWebViewCookie(name: c.Name, value: c.Value, domain: c.Domain, path: c.Path)).ToList();
    }

    public async Task RemoveCookie(AvaloniaWebViewCookie cookie)
    {
        if (_coreWebView2Controller is null)
        {
            return;
        }

        var cookies = await _coreWebView2Controller.CoreWebView2.CookieManager.GetCookiesAsync(cookie.Domain);
        
        if (cookies is null)
        {
            throw new InvalidOperationException("Cookies not found.");
        }
        
        var cookieToRemove = cookies.FirstOrDefault(c => c.Name == cookie.Name && c.Value == cookie.Value);
        
        if (cookieToRemove is null)
        {
            throw new InvalidOperationException("Cookie not found.");
        }
        
        _coreWebView2Controller.CoreWebView2.CookieManager.DeleteCookie(cookieToRemove);
    }

    public Task ClearCookies()
    {
        _coreWebView2Controller?.CoreWebView2.CookieManager.DeleteAllCookies();
        return Task.CompletedTask;
    }
}
