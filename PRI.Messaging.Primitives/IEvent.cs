using System;

namespace PRI.Messaging.Primitives
{
	/// <summary>
	/// A marker interface to signify an Event message
	/// </summary>
	public interface IEvent : IMessage
	{
		DateTime OccurredDateTime { get; set; }
	}
}