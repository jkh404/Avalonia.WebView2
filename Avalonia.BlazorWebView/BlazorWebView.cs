﻿using AvaloniaBlazorWebView.Components;
using AvaloniaBlazorWebView.Configurations;
using AvaloniaBlazorWebView.Core;
using Avalonia.Controls;
using Avalonia.WebView.Shared.Interfaces;
using WebView.Core.Configurations;
using WebView.Core.Ioc;
using WebView.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Options;

namespace AvaloniaBlazorWebView
{
    public sealed partial class BlazorWebView : Control, IVirtualWebView<BlazorWebView>, IWebViewEventHandler, IVirtualWebViewControlCallBack, IWebViewControl, IAsyncDisposable
    {
        static BlazorWebView()
        {
            LoadDependencyObjectsChanged();
            LoadHostDependencyObjectsChanged();
        }

        public BlazorWebView()
            : this(default)
        {

        }

        public BlazorWebView(IServiceProvider? serviceProvider = default)
        {
            var properties = WebViewLocator.s_ResolverContext.GetRequiredService<WebViewCreationProperties>();
            _creationProperties = properties ?? new WebViewCreationProperties();
            _viewHandlerProvider = WebViewLocator.s_ResolverContext.GetRequiredService<IViewHandlerProvider>();
            _platformBlazorWebViewProvider = WebViewLocator.s_ResolverContext.GetRequiredService<IPlatformBlazorWebViewProvider>();
            var blazorBuilder = WebViewLocator.s_ResolverContext.GetRequiredService<IBlazorWebViewApplicationBuilder>();
            var blazorApplication = blazorBuilder.Build();
            _blazorApplication = blazorApplication;
            _serviceProvider = blazorApplication.ServiceProvider;

            _dispatcher = _serviceProvider.GetRequiredService<AvaloniaDispatcher>();
            _jsComponents = _serviceProvider.GetRequiredService<JSComponentConfigurationStore>();
            var setting = _serviceProvider.GetRequiredService<IOptions<BlazorWebViewSetting>>();

            if (setting.Value.ComponentType is not null && !string.IsNullOrWhiteSpace(setting.Value.Selector))
            {
                RootComponents.Add(new BlazorRootComponent()
                {
                    ComponentType = setting.Value.ComponentType,
                    Selector = setting.Value.Selector
                });
            }

            _setting = setting.Value;
            _appScheme = _platformBlazorWebViewProvider.Scheme;
            _appHostAddress = setting.Value.AppAddress;
            _baseUri = new Uri($"{_appScheme}://{_appHostAddress}/");
            _startAddress = setting.Value.StartAddress;

            RootComponents.CollectionChanged += RootComponents_CollectionChanged;

        }

        readonly WebViewCreationProperties _creationProperties;
        readonly IViewHandlerProvider _viewHandlerProvider;

        readonly string _appScheme;
        readonly string _appHostAddress;
        readonly Uri _baseUri;
        readonly string _startAddress;
        readonly BlazorWebViewSetting _setting;
        readonly IBlazorWebViewApplication _blazorApplication;
        readonly IServiceProvider _serviceProvider;
        readonly AvaloniaDispatcher _dispatcher;
        readonly JSComponentConfigurationStore _jsComponents;
        readonly IPlatformBlazorWebViewProvider _platformBlazorWebViewProvider;

        bool _isDisposed = false;
        AvaloniaWebViewManager? _webviewManager;

        IPlatformWebView? _platformWebView;
        public IPlatformWebView? PlatformWebView => _platformWebView;
    }

}

