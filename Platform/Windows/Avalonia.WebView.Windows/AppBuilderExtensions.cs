﻿using Avalonia.WebView.Shared.Interfaces;
using WebView.Core.Ioc;
using DryIoc.Shared;
using DryIoc.Shared.Extensions;
using WebView.Core;

namespace Avalonia.WebView.Windows;
public static class AppBuilderExtensions
{
    public static AppBuilder UseWindowWebView(this AppBuilder appBuilder)
    {
        return appBuilder.AfterPlatformServicesSetup(app =>
        {
            WebViewLocator.s_Registrator.RegisterSingleton<IViewHandlerProvider, ViewHandlerProvider>();
            WebViewLocator.s_Registrator.RegisterSingleton<IPlatformBlazorWebViewProvider, BlazorWebViewHandlerProvider>();
        });
    }
}
