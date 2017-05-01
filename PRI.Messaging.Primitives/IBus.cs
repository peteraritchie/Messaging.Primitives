using System;

namespace PRI.Messaging.Primitives
{
	/// <summary>
	/// supports patterns like pipe (translator: enricher, filter), TODO: splitter, aggregator, invalid messages, publish, subscribe
	/// </summary>
	public interface IBus :
#if SUPPPORT_ASYNC_CONSUMER
		IAsyncConsumer<IMessage>
#else
		IConsumer<IMessage>
#endif
	{
		void AddTranslator<TIn, TOut>(IPipe<TIn, TOut> pipe) where TIn : IMessage where TOut : IMessage;
		object AddHandler<TIn>(IConsumer<TIn> consumer) where TIn : IMessage;
		void RemoveHandler<TMessage>(IConsumer<TMessage> consumer, object token) where TMessage : IMessage;
	}
}
