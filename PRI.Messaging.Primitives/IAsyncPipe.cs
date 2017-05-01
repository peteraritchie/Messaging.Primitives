namespace PRI.Messaging.Primitives
{
#if SUPPPORT_ASYNC_CONSUMER
	public interface IAsyncPipe<in TIn, out TOut> : IAsyncConsumer<TIn>, IAsyncProducer<TOut> where TIn : IMessage where TOut : IMessage
	{
	}
#endif
}