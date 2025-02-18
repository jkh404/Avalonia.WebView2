using WebViewCore.Models;

namespace WebViewCore;
public interface IWebViewCookies
{
    Task AddCookie(AvaloniaWebViewCookie cookie);
    Task<List<AvaloniaWebViewCookie>?> GetCookies(string url);
    Task RemoveCookie(AvaloniaWebViewCookie cookie);
    Task ClearCookies();
}
