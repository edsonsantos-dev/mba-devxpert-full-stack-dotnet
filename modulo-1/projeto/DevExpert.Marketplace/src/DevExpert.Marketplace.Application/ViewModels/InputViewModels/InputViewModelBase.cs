using DevExpert.Marketplace.Core.Entities.AuditableEntities;
using DevExpert.Marketplace.Core.Interfaces;

namespace DevExpert.Marketplace.Application.ViewModels.InputViewModels;

public abstract class InputViewModelBase<TEntity>(INotifier notifier) : ViewModelBase where TEntity : Entity
{
    public abstract TEntity ToModel();
}