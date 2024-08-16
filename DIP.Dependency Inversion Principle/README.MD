# Dependency Inversion Principle

This is the principle of dependency inversion and it tells us that:

> High-level modules should not depend on low-level modules. Both must be based on abstractions.

In other words, if a class needs some tool, it will express that need. This does not allow the need to simply offer itself to be used by the class.

Imagine that all the people with cell phones turn to you and say they will call you at any time to talk. Okay, to maintain a relationship, two people must communicate. But suppose you don't really like talking on the phone and only use this feature when it's really necessary. So in this case you are responsible for making the call to that person, with a specific purpose.

## Explaining the example

In the example code, we want to use a mechanism for sending messages via Email, SMS or Whatsapp.

In the [bad](https://github.com/ehsandarvishi2003/SOLID-Principles-In-CSharp-2024/tree/master/DIP.Dependency%20Inversion%20Principle/Bad) example, the notification means have implementations within the notification service which completely depends on knowing what the shipping methods are to treat each one independently. This is horrible for maintainability and code evolution as the notification module and shipping methods are tightly tied.

In the [good](https://github.com/ehsandarvishi2003/SOLID-Principles-In-CSharp-2024/tree/master/DIP.Dependency%20Inversion%20Principle/Good) example, we solved this problem when we created an `IMessageType. cs` which serves as the basis for all forms of notification sending, guarantees that our application is divided into interfaces that will characterize existing and new media, opening the code for extensions.
Next, the notification mechanism decides what its sending strategy will be. The notification service, in turn, is created knowing which method of sending should be used and can send the notification without needing to have different implementations for sending.

Thus, the notification service only needs to know which strategy to use to proceed with sending the message. It does not depend on how Email or SMS works, allowing any other way of sending messages to be added to the project and continue using the same service.