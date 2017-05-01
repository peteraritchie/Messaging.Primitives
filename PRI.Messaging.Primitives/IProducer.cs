namespace PRI.Messaging.Primitives
{
	/// <summary>
	/// A producer of a message of type <typeparamref name="T"/>
	/// Messages must implement <see cref="IMessage"/>, or an <see cref="IMessage"/>-derivative like <see cref="IEvent"/> or <see cref="ICommand"/>
	/// As messages are produced they are sent to the attached consumer.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IProducer<out T> where T:IMessage
	{
		void AttachConsumer(IConsumer<T> consumer);
	}
}