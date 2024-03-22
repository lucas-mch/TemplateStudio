using CommunityToolkit.Mvvm.ComponentModel;

using TemplateStudio.Contracts.ViewModels;
using TemplateStudio.Core.Contracts.Services;
using TemplateStudio.Core.Models;

namespace TemplateStudio.ViewModels;

public partial class GradeDeConteúdoDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    [ObservableProperty]
    private SampleOrder? item;

    public GradeDeConteúdoDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
