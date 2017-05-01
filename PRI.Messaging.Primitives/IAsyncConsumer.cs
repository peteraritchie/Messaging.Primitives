using System.Threading.Tasks;

namespace PRI.Messaging.Primitives
{
	/// <summary>
	/// A consumer of a message of type <typeparamref name="T"/> that can handle the message asynchronously
	/// Messages must implement <see cref="IMessage"/>, or an <see cref="IMessage"/>-derivative like <see cref="IEvent"/> or <see cref="ICommand"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
#if SUPPORT_ASYNC_CONSUMER
	public
#else
	internal
#endif
	interface IAsyncConsumer<in T> : IConsumer<T> where T : IMessage
	{
		Task HandleAsync(T message);
	}
}