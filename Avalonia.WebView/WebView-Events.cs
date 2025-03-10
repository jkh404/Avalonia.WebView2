﻿using WebView.Core.Events;

namespace Avalonia.WebView
{
    partial class WebView
    {
        public event EventHandler<WebViewCreatingEventArgs>? WebViewCreating;
        public event EventHandler<WebViewCreatedEventArgs>? WebViewCreated;
        public event EventHandler<WebViewUrlLoadingEventArg>? NavigationStarting;
        public event EventHandler<WebViewUrlLoadedEventArg>? NavigationCompleted;
        public event EventHandler<WebViewMessageReceivedEventArgs>? WebMessageReceived;
        public event EventHandler<WebViewNewWindowEventArgs>? WebViewNewWindowRequested;
    }

}
