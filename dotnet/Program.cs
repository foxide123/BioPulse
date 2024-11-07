using Avalonia;
using System;
using System.Linq;
using System.Threading;
using Avalonia.Svg.Skia;
using Serilog;
using System.Runtime.InteropServices;
using Avalonia.ReactiveUI;

namespace dotnet;

sealed class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
   
    public static int Main(string[] args)
    {
		var builder = BuildAvaloniaApp();
		if (args.Contains("--drm"))
		{
			SilenceConsole();
			return builder.StartLinuxDrm(args: args, card: null, scaling: 1.0);
		}

		if (args.Contains("--fbdev"))
		{
			SilenceConsole();
			return builder.StartLinuxFbDev(args: args, fbdev: "/dev/fb0", scaling: 1.0);
		}
		Architecture processArchitecture = RuntimeInformation.ProcessArchitecture;

		if(processArchitecture == Architecture.Arm || processArchitecture == Architecture.Arm64 || processArchitecture == Architecture.Armv6)
        {
			//I2cInterface.CheckAndInitiateI2C();
		}
		
		return builder.StartWithClassicDesktopLifetime(args);
    } 

    private static void SilenceConsole()
    {
		new Thread(() =>
			{
				Console.CursorVisible = false;
				while(true)
				Console.ReadKey(true);
			})
			{ IsBackground = true }.Start();
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
	{
		// These 2 lines are necessary for Avalonia.Svg package
		GC.KeepAlive(typeof(SvgImageExtension).Assembly);
        GC.KeepAlive(typeof(Avalonia.Svg.Skia.Svg).Assembly);

		return AppBuilder.Configure<App>()
			.UseReactiveUI()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
	}
}
