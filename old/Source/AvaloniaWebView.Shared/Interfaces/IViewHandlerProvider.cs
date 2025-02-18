using WebViewCore;
using WebViewCore.Configurations;

namespace AvaloniaWebView.Shared.Interfaces;

public interface IViewHandlerProvider
{
    IViewHandler CreatePlatformWebViewHandler(IVirtualWebView virtualView, IVirtualWebViewControlCallBack virtualViewCallBack, IVirtualBlazorWebViewProvider? virtualBlazorWebViewCallBack ,Action<WebViewCreationProperties>? configDelegate = default);
}
