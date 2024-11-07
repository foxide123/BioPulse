using System.Reactive;
using ReactiveUI;
using dotnet.Features.Dashboard.Presentation.ViewModels;

namespace dotnet.Common.Presentation
{

    public class MainWindowViewModel : ReactiveObject, IScreen
    {
        public RoutingState Router { get; } = new RoutingState();

        public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }
        
        public ReactiveCommand<Unit, IRoutableViewModel> GoBack => Router.NavigateBack;

        public MainWindowViewModel()
        {
            // Use Router.Navigate.Execute
            // command to navigate to different view models.
            GoNext = ReactiveCommand.CreateFromObservable(
                    () => Router.Navigate.Execute(new DashboardViewModel(this))
            );
        }

    //#pragma warning disable CA1822 // Mark members as static
    //#pragma warning restore CA1822 // Mark members as static
    }

}