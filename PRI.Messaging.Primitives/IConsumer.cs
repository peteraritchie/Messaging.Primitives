namespace PRI.Messaging.Primitives
{
	public interface IConsumer<in T> where T:IMessage
	{
		void Handle(T message);
	}
}