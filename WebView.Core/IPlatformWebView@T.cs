﻿namespace WebView.Core;

public interface IPlatformWebView<T> : IPlatformWebView
{
    T PlatformView { get; }

}
