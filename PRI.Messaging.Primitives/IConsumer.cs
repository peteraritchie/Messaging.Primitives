namespace PRI.Messaging.Primitives
{
	/// <summary>
	/// A consumer of a message of type <typeparamref name="T"/>
	/// Messages must implement <see cref="IMessage"/>, or an <see cref="IMessage"/>-derivative like <see cref="IEvent"/> or <see cref="ICommand"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IConsumer<in T> where T:IMessage
	{
		void Handle(T message);
	}
}