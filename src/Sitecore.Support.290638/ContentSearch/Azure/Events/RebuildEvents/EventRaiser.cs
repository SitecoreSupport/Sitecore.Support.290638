using Sitecore.ContentSearch.Azure.Events.RebuildEvents;
using Sitecore.Eventing;
using Sitecore.Events;

namespace Sitecore.Support.ContentSearch.Azure.Events.RebuildEvents
{
    public static class EventRaiser
    {
        public static void RaiseRebuildEndEvent(SwitchOnRebuildEventRemote @event)
        {
            var parameters = new object[]
            {
                @event.IndexName,
                @event.PrimaryCloudIndexName,
                @event.SecondaryCloudIndexName
            };

            Event.RaiseEvent("index:switchonrebuild", parameters);
            EventManager.QueueEvent(@event, true, false);
        }
    }
}