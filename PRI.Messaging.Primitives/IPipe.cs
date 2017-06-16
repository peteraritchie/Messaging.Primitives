namespace PRI.Messaging.Primitives
{
	/// <summary>
	/// A pipe is a consumer/producer that processes a message to perform a specific function.  This function could be
	/// as a filter (consuming a message to produce a smaller message, or a different message), and enricher (consuming
	///  a message to produce a larger message)
	/// </summary>
	/// <typeparam name="TIn">Message type of the incoming message</typeparam>
	/// <typeparam name="TOut">Message type of the outgoing message</typeparam>
	public interface IPipe<in TIn, out TOut> : IConsumer<TIn>, IProducer<TOut> where TIn : IMessage where TOut : IMessage
	{
	}
}