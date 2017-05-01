namespace PRI.Messaging.Primitives
{
#if SUPPPORT_ASYNC_CONSUMER
	public interface IAsyncProducer<out T> where T : IMessage
	{
		void AttachConsumer(IAsyncConsumer<T> consumer);
	}
#endif
}