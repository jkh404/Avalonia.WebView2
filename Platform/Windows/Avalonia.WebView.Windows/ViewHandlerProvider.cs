using System;
using Avalonia.WebView.Shared.Interfaces;
using WebView.Core;
using WebView.Core.Configurations;

namespace Avalonia.WebView.Windows;
internal class ViewHandlerProvider : IViewHandlerProvider
{
    IViewHandler IViewHandlerProvider.CreatePlatformWebViewHandler(IVirtualWebView virtualView, IVirtualWebViewControlCallBack virtualViewCallBack, IVirtualBlazorWebViewProvider? provider, Action<WebViewCreationProperties>? configDelegate)
    {
        var creatonProperty = new WebViewCreationProperties();
        configDelegate?.Invoke(creatonProperty);

        return new WebViewHandler(virtualView, virtualViewCallBack, provider, creatonProperty);
    }
}
