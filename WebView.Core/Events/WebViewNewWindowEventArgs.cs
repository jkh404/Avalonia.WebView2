using System;
using WebView.Core.Enums;

namespace WebView.Core.Events;
public class WebViewNewWindowEventArgs : EventArgs
{
    public Uri? Url { get; set; }
    public required UrlRequestStrategy UrlLoadingStrategy { get; set; }

    public object? RawArgs { get; set; }
}
