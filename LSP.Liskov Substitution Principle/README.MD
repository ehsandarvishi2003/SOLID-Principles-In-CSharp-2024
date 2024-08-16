# Liskov Substitution Principle

This is the principle of Liskov substitution. It can be considered one of the most confusing principles to understand or exemplify. It basically tells us that:

> We should be able to use any derived class in place of the parent class and have it behave the same way without modifications

In other words, this principle is an extension of the Open/Closed principle. Here a derived class does not affect the behavior of the base class. This way, we can use the base class to represent any derived class.

Imagine that a father is a bus driver and his son wants to be a football player. This way, the son cannot replace the father, even if they are from the same family.

## Explaining the example

In the example code, we use a subscription plan that has different access levels: articles, courses and mentoring.
  
In the [bad](https://github.com/ehsandarvishi2003/SOLID-Principles-In-CSharp-2024/tree/master/LSP.Liskov%20Substitution%20Principle/Bad), the subscription manager allows you to get the details of all access levels. 

The implementation of each level overwrites the way of obtaining levels and, if it does not offer some type of level, it simply does not implement it, leaving an unimplemented method.

When collecting information from all signatures, when trying to obtain a detail of some feature that a more basic derived signature does not have in relation to a more complex signature, then an exception will be raised at run time, as it will try to access that method that does not has been implemented.

In the [good](https://github.com/ehsandarvishi2003/SOLID-Principles-In-CSharp-2024/tree/master/LSP.Liskov%20Substitution%20Principle/Good), we were able to extend our base class and separate the characteristics ( access level) that each subscription must offer.

This way, if you try to perform the same operation in the bad example, of listing the details of all signature types, when we create the collection that contains the signatures, according to the base class, we may have a signature derived from the base that does not implements obtaining the most complex details that another class has.

Therefore, the editor already displays an error message saying that the type does not belong to the type defined in the collection and will not be able to execute some more complex method that the base class is unaware of. This prevents the previously triggered exception from happening and surprising the user with a run-time error.