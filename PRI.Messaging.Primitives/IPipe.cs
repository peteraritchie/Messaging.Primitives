namespace PRI.Messaging.Primitives
{
	public interface IPipe<in TIn, out TOut> : IConsumer<TIn>, IProducer<TOut> where TIn : IMessage where TOut : IMessage
	{
	}
}