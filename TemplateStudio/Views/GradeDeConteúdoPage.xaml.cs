using Microsoft.UI.Xaml.Controls;

using TemplateStudio.ViewModels;

namespace TemplateStudio.Views;

public sealed partial class GradeDeConteúdoPage : Page
{
    public GradeDeConteúdoViewModel ViewModel
    {
        get;
    }

    public GradeDeConteúdoPage()
    {
        ViewModel = App.GetService<GradeDeConteúdoViewModel>();
        InitializeComponent();
    }
}
