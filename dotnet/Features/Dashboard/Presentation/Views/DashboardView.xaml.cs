using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SkiaSharp;
using Svg.Skia;
using ReactiveUI;
using Avalonia.ReactiveUI;
using dotnet.Features.Dashboard.Presentation.ViewModels;

namespace dotnet.Features.Dashboard.Presentation.Views
{
    public partial class DashboardView : ReactiveUserControl<DashboardViewModel>
    {
        public DashboardView()
        {
            this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
