# Interface Segregation Principle

This is the principle of interface segregation. . Here, we have to:

> Whoever uses the interface should not be obliged or forced to implement what will not be used. Instead of having an inflated interface, it is preferable to have several smaller interfaces based on groups of methods, each corresponding to a submodule of the domain.

We can see that this principle also shares the characteristic of SRP (Single Responsibility). We should not create interfaces with several methods and properties, if it is not necessary for everyone who will implement it.

An analogy to be made is that we currently have different types of cell phone charger connectors that have a USB on the other end. Now imagine if there was just one object that contained all types of charger inputs plugged into it, with 10, 20 different connectors. That's not what we want. We don't want to carry so much unnecessary stuff when we only need one.

## Explaining the example

In the example code, we have the separation of control for creating, reviewing and executing tasks within a department.

In the [bad](https://github.com/ehsandarvishi2003/SOLID-Principles-In-CSharp-2024/tree/master/ISP.Interface%20Segregation%20Principle/Bad) example, our `Manager` is associated with the create activity , review and execute tasks just like any leader.

What happens is that managers are generally not responsible for carrying out tasks common to those of leaders. The domain in which they operate is different.

Therefore, the manager has to discard the function of performing tasks.

In the [good](https://github.com/ehsandarvishi2003/SOLID-Principles-In-CSharp-2024/tree/master/ISP.Interface%20Segregation%20Principle/Good) example, we were able to separate the methods that were all grouped in the interface `ILead.cs` in another interface called `IProgrammer.cs`.

In this new interface, we define that it will perform tasks. Therefore, our `Manager` can lead without worrying about performing common tasks from another domain. While on the other side, a leader can perform such tasks and also lead his programmers.