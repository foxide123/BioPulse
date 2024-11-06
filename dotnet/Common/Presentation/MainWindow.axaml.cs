using Avalonia.Controls;

namespace dotnet.Common.Presentation;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        this.Width = 582;
        this.Height = 372+30; 
    }
}