using DevExpert.Marketplace.Business.Notifications;

namespace DevExpert.Marketplace.Business.Interfaces;

public interface INotifier
{
    bool HaveNotification();
    List<Notification> GetNotifications();
    void AddNotification(Notification notification);
}