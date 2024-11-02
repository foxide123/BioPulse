using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using dotnet.Common.Data;
using dotnet.Common.Presentation;
using dotnet.Features.Dashboard.Presentation;
using Microsoft.EntityFrameworkCore;


namespace dotnet;

public partial class App : Application
{
    public override void Initialize()
    {
        InitializeDatabase();
        AvaloniaXamlLoader.Load(this);
    }

    private void InitializeDatabase()
    {
        using var dbContext = new MyDbContext();
        dbContext.Database.Migrate(); // Apply any migrations (optional)
    }
    public override void OnFrameworkInitializationCompleted()
    {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
                desktop.MainWindow = new MainWindow();
            else if (ApplicationLifetime is ISingleViewApplicationLifetime singleView)
                singleView.MainView = new DashboardSingleView();

            base.OnFrameworkInitializationCompleted();
    }
}
