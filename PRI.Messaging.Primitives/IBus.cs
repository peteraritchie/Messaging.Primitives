using System;

namespace PRI.Messaging.Primitives
{
	/// <summary>
	/// supports patterns like pipe (translator: enricher, filter), TODO: splitter, aggregator, invalid messages, publish, subscribe
	/// </summary>
	public interface IBus : IAsyncConsumer<IMessage>
	{
		void AddTranslator<TIn, TOut>(IPipe<TIn, TOut> pipe) where TIn : IMessage where TOut : IMessage;
		object AddHandler<TIn>(IConsumer<TIn> consumer) where TIn : IMessage;
		[Obsolete("Please use IBus.RemoveHandler<TMessage>(IConsumer<TMessage> consumer, object token) with the return value of AddHandler as the token.")]
		void RemoveHandler<TMessage>(IConsumer<TMessage> consumer) where TMessage : IMessage;
		void RemoveHandler<TMessage>(IConsumer<TMessage> consumer, object token) where TMessage : IMessage;
	}
}
