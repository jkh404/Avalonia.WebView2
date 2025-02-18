using System.Collections.Generic;
using System.Threading.Tasks;
using Linux.WebView.Core;

namespace Avalonia.WebView.Linux.Core;

public partial class LinuxWebViewCore : IPlatformWebView<LinuxWebViewCore>
{
    //public Task AddCookie(AvaloniaWebViewCookie cookie)
    //{
    //    throw new NotImplementedException();
    //}

    //public Task<List<AvaloniaWebViewCookie>?> GetCookies(string url)
    //{
    //    WebView.Context.CookieManager.GetCookies(url);
    //    var a = WebView.Context.CookieManager.GetCookiesFinish(new GLib.Task(,));
    //    return Task.FromResult<List<AvaloniaWebViewCookie>?>(null);
    //}

    //public Task RemoveCookie(AvaloniaWebViewCookie cookie)
    //{
        
    //    WebView.Context.CookieManager.DeleteCookieFinish(GLib.IAsyncResult);
    //    WebView.Context.CookieManager.DeleteCookiesForDomain(cookie.Domain);
    //    return Task.CompletedTask;
    //}

    //public Task ClearCookies()
    //{
    //    WebView.Context.CookieManager.DeleteAllCookies();
    //    return Task.CompletedTask;
    //}
}
