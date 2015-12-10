namespace PRI.Messaging.Primitives
{
	public interface IProducer<out T> where T:IMessage
	{
		void AttachConsumer(IConsumer<T> consumer);
	}
}