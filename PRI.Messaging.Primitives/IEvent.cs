using System;

namespace PRI.Messaging.Primitives
{
	public interface IEvent : IMessage
	{
		DateTime OccurredDateTime { get; set; }
	}
}