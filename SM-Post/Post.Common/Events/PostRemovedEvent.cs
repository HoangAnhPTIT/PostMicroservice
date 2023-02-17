using CQRS.Core.Events;

namespace Post.Common.Events
{
    internal class PostRemovedEvent : BaseEvent
    {
        public PostRemovedEvent() : base(nameof(PostRemovedEvent))
        {
        }
    }
}