namespace WebView.Core;

public interface IVirtualWebView
{
    object VirtualViewObject { get; }
    IPlatformWebView? PlatformView { get; }
}
