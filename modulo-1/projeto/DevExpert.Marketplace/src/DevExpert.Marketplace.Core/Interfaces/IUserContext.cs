namespace DevExpert.Marketplace.Core.Interfaces;

public interface IUserContext
{
    Guid GetUserId();
    bool IsAuthenticated();
}