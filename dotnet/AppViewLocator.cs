using System;
using ReactiveUI;
using Avalonia.ReactiveUI;
using dotnet.Features.Dashboard.Presentation.Views;
using dotnet.Features.Dashboard.Presentation.ViewModels;

namespace dotnet
{
    public class AppViewLocator: ReactiveUI.IViewLocator
    {
        public IViewFor ResolveView<T>(T viewModel, string contract = null) => viewModel switch
        {
            DashboardViewModel context => new DashboardView { DataContext = context },
            _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
        };
    }
}