using Avalonia.Controls;
using WebView.Core;
namespace Avalonia.WebView.Shared.Interfaces
{
    public interface IViewHandler
    {
        Control AttachableControl { get; }
        IPlatformWebView PlatformWebView { get; }
    }
}


