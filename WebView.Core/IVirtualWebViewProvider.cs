using System;

namespace WebView.Core;
public interface IVirtualWebViewProvider
{
    string AppHostAddress { get; }
    Uri BaseUri { get; }
}
