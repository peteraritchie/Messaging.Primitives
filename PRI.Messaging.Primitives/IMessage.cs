namespace PRI.Messaging.Primitives
{
	public interface IMessage
	{
		string CorrelationId { get; set; }
	}
}