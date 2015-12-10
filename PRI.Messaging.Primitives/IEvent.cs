using System;

namespace PRI.Messaging.Primitives
{
	public interface IEvent : IMessage
	{
		DateTime OccurreDateTime { get; set; }
	}
}