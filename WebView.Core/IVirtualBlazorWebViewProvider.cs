using WebView.Core.Models;
using WebView.Core.Events;
using System;

namespace WebView.Core;
public interface IVirtualBlazorWebViewProvider
{
    Uri BaseUri { get; }

    bool ResourceRequestedFilterProvider(object? requester, out WebScheme filter);

    bool PlatformWebViewResourceRequested(object? sender, WebResourceRequest request, out WebResourceResponse? response);

    void PlatformWebViewMessageReceived(object? sender, WebViewMessageReceivedEventArgs arg);

}
