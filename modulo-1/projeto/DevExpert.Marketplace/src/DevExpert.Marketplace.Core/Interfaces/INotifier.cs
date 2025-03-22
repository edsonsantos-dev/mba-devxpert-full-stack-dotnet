using DevExpert.Marketplace.Core.Notifications;

namespace DevExpert.Marketplace.Core.Interfaces;

public interface INotifier
{
    bool HaveNotification();
    List<Notification> GetNotifications();
    void AddNotification(Notification notification);
}