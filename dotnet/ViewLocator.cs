using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using dotnet.Common.Presentation;

namespace dotnet;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? data)
    {
        if (data is null)
            return null;
        
        var viewModelType = data.GetType();
        var viewModelNamespace = viewModelType.Namespace;

        var viewNamespace = viewModelNamespace!.Replace("ViewModels", "Presentation.Views", StringComparison.Ordinal);
        
        // Construct full name of the view class
        var viewTypeName = $"{viewNamespace}.{viewModelType.Name.Replace("ViewModel", "View")}";
        var viewType = Type.GetType(viewTypeName);

        if (viewType != null)
        {
            var control = (Control)Activator.CreateInstance(viewType)!;
            control.DataContext = data;
            return control;
        }
        
        return new TextBlock { Text = "Not Found: " + viewTypeName };
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}
