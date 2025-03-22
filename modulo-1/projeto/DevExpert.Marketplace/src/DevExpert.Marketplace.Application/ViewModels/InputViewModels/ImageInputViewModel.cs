using DevExpert.Marketplace.Core.Entities;
using DevExpert.Marketplace.Core.Interfaces;
using Microsoft.AspNetCore.Http;

namespace DevExpert.Marketplace.Application.ViewModels.InputViewModels;

public class ImageInputViewModel(INotifier notifier) : InputViewModelBase<Image>(notifier)
{
    public int DisplayPosition { get; set; }
    public string? Path { get; set; }
    public Guid ProductId { get; set; }
    public IFormFile File { get; set; }
    
    public override Image ToModel()
    {
        return new Image(DisplayPosition, Path, ProductId, notifier);
    }
}