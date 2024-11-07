using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using SkiaSharp;
using Svg.Skia;
using ReactiveUI;
using Avalonia.ReactiveUI;
using dotnet.Features.SensorManagement.Presentation.ViewModels;

namespace dotnet.Features.SensorManagement.Presentation.Views
{
    public partial class TemperatureManagementView : ReactiveUserControl<TemperatureManagementViewModel>
    {
        public TemperatureManagementView()
        {
            //used for ReactiveUI
            AvaloniaXamlLoader.Load(this);
            this.WhenActivated(disposable => { });
        }
    }
}