namespace PRI.Messaging.Primitives
{
	/// <summary>
	/// The basic message type.  Types to be used as messages should implement this, <see cref="IEvent"/> or <see cref="ICommand"/>
	/// </summary>
	public interface IMessage
	{
		string CorrelationId { get; set; }
	}
}