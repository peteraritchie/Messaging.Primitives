namespace PRI.Messaging.Primitives
{
	/// <summary>
	/// supports patterns like pipe (translator: enricher, filter), TODO: splitter, aggregator, invalid messages, publish, subscribe
	/// </summary>
    public interface IBus : IConsumer<IMessage>
	{
		void AddTranslator<TIn, TOut>(IPipe<TIn, TOut> pipe) where TIn : IMessage where TOut : IMessage;
		void AddHandler<TIn>(IConsumer<TIn> consumer) where TIn : IMessage;
	}
}
