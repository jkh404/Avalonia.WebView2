using WebView.Core.Configurations;
using WebView.Core;
namespace Avalonia.WebView.Shared.Interfaces
{
    public interface IViewHandlerProvider
    {
        IViewHandler CreatePlatformWebViewHandler(IVirtualWebView virtualView, 
            IVirtualWebViewControlCallBack virtualViewCallBack, 
            IVirtualBlazorWebViewProvider? virtualBlazorWebViewCallBack, 
            Action<WebViewCreationProperties>? configDelegate = default);
    }

}

