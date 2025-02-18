using System.Collections.Generic;
using System.Threading.Tasks;
using WebView.Core.Models;

namespace WebView.Core;
public interface IWebViewCookies
{
    Task AddCookie(AvaloniaWebViewCookie cookie);
    Task<List<AvaloniaWebViewCookie>?> GetCookies(string url);
    Task RemoveCookie(AvaloniaWebViewCookie cookie);
    Task ClearCookies();
}
