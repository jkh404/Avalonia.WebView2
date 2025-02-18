using Avalonia.Controls;
using WebViewCore;

namespace AvaloniaWebView.Shared.Interfaces;

public interface IViewHandler
{
    Control AttachableControl { get; }
    IPlatformWebView PlatformWebView { get; }
}
