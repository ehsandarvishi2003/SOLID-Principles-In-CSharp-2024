# Single Responsibility Principle

This is the principle of single responsibility. It basically tells us that:

> Each software module/class must have only one reason to change

Imagine a Swiss tool. It has multiple functions. Cool, but don't you sometimes think this tool is overloaded with too many functions?

So, what if I had all these features in separate items?

This way everything will seem simpler and I won't need to worry if something else is affected by something.

## Explicando o exemplo

In the example code, we need to insert a user into the database. Our user has `name` and `email`. Therefore, we want:
 * Validate your `email`;
 * Enter the bank registration;
 * Send a welcome email;

In the bad [bad](https://github.com/ehsandarvishi2003/SOLID-Principles-In-CSharp-2024/tree/master/SRP.Single%20Risponsibility%20Prenciple/Bad)example, we perform all these steps in the UserService.cs class.

In the good [good](https://github.com/ehsandarvishi2003/SOLID-Principles-In-CSharp-2024/tree/master/SRP.Single%20Risponsibility%20Prenciple/Good)example, we separate our classes making each part responsible for carrying out a specific task.