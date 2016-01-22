Messaging.Primitives
====================
[![Build status](https://ci.appveyor.com/api/projects/status/ewdko4tv63tudbcf?svg=true)](https://ci.appveyor.com/project/peteraritchie/messaging-primitives)

Messaging.Primities is a small, independent and decoupled, class library to contain message-oriented abstractions. For the most part this library will only contain interfaces but may contain base classes in the future

##IMessage
Mostly a [marker interface](https://en.wikipedia.org/wiki/Marker_interface_pattern), but does contain a string `CorrelationId` property.  This interface provides a [message](http://www.enterpriseintegrationpatterns.com/patterns/messaging/Message.html) abstraction for other interfaces/implementations.
##IEvent
A [marker interface](https://en.wikipedia.org/wiki/Marker_interface_pattern) to provide an event abstraction.  An event is a type of message; but a unique [event](http://www.enterpriseintegrationpatterns.com/patterns/messaging/EventMessage.html) abstraction allows messages and events to be handled separately.  An event is the representation of a immutable fact that describes something that occured in the past.
##ICommand
A [marker interface](https://en.wikipedia.org/wiki/Marker_interface_pattern) that provides an abstraction of a [command message](http://www.enterpriseintegrationpatterns.com/patterns/messaging/CommandMessage.html) specific to requesting a change in state, i.e. the execution of a command.
##IConsumer
A generic interface that provides an abstrction for something that consumes or handles a message.   `IConsumer` has a `Handle` method to consume a messsage derived from `IMessage` and has the signature `void Handle<T>(T message)`
##IProducer
A generic interface that provides an abstraction for something that produces a message.  `IProducer` has a `AttachConsumer` method to attach something that implements a `IConsmer` so that the producer and send the mesages that are produced to the consumer.  This interface promotes the idea that messages are asynchronous and aren't singular.  The `AttachConsumer` method allows consumers to consume any number of messages that the producer will produce in the future.
##IPipe
A convienient marker interface for something that is both a consumer and a producer, a [pipe](http://www.enterpriseintegrationpatterns.com/patterns/messaging/PipesAndFilters.html) (or filter).  It implements both `IConsumer` and `IProducer` and able to consume a message of one type and produce a method of another type.
##IBus
A abstraction for a [bus](http://www.enterpriseintegrationpatterns.com/patterns/messaging/MessageBus.html) that when implemented would faciliate a decoupled architecture whose responsibility is to facilitate the connection of producers and consumers.
