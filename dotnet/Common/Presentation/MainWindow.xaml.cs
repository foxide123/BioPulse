using ReactiveUI;
using Avalonia.ReactiveUI;
using Avalonia.Markup.Xaml;

namespace dotnet.Common.Presentation
{
    public class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
