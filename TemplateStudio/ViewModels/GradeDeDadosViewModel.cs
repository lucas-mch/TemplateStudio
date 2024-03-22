using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using TemplateStudio.Contracts.ViewModels;
using TemplateStudio.Core.Contracts.Services;
using TemplateStudio.Core.Models;

namespace TemplateStudio.ViewModels;

public partial class GradeDeDadosViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public GradeDeDadosViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
