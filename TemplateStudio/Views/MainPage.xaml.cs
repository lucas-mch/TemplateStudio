using Microsoft.UI.Xaml.Controls;

using TemplateStudio.ViewModels;

namespace TemplateStudio.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
