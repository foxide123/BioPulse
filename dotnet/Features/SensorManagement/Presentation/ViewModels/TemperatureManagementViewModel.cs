using System.Reactive;
using System.Reactive.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using ReactiveUI;
using Avalonia.ReactiveUI;
using System;
using Avalonia.Platform;

namespace dotnet.Features.SensorManagement.Presentation.ViewModels
{
    [DataContract]
public class TemperatureManagementViewModel : ReactiveObject, IRoutableViewModel
{
    //https://docs.avaloniaui.net/docs/concepts/reactiveui/routing
    //Coming from IRoutableViewModel
    //Reference to IScreen that owns the routable view model. 
    public IScreen HostScreen { get; }

    //Coming from IRoutableViewModel
    //Unique identifier for the routable view model
    public string? UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public TemperatureManagementViewModel(IScreen screen) => HostScreen = screen;
        /*
private string _searchQuery;

public TemperatureManagementViewModel() 
{
var canSearch = this
.WhenAnyValue(x => x.SearchQuery)
.Select(query => !string.IsNullOrWhiteSpace(query));

Search = ReactiveCommand.CreateFromTask(
() => Task.Delay(1000), // a long-running operation
canSearch);
}

//Recreate. Don't want to save the state of the command
[IgnoreDataMember]
public ReactiveCommand<Unit, Unit> Search { get; }

//Save and Restore
[DataMember]
public string SearchQuery 
{
get => _searchQuery;
set => this.RaiseAndSetIfChanged(ref _searchQuery, value);
}
*/
    }
}