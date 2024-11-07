using System.Reactive;
using System.Reactive.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using ReactiveUI;
using Avalonia.ReactiveUI;
using System;
using Avalonia.Platform;

namespace dotnet.Features.Dashboard.Presentation.ViewModels
{
    [DataContract]
public class DashboardViewModel : ReactiveObject, IRoutableViewModel
{
    //https://docs.avaloniaui.net/docs/concepts/reactiveui/routing
    //Coming from IRoutableViewModel
    //Reference to IScreen that owns the routable view model. 
    public IScreen HostScreen { get; }

    //Coming from IRoutableViewModel
    //Unique identifier for the routable view model
    public string? UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public DashboardViewModel(IScreen screen) => HostScreen = screen;

    }
}