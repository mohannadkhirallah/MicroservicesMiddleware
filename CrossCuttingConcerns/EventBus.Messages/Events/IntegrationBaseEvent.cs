using System;

namespace EventBus.Messages.Events
{
   public class IntegrationBaseEvent
    {
        public IntegrationBaseEvent(Guid id, DateTime creationDate)
        {
            EventId = id;
            CreationDate = creationDate;
        }
        public IntegrationBaseEvent()
        {
            EventId = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public Guid EventId { get; private set; }
        public DateTime CreationDate { get; private set; }
    }
}
