# Open/Closed Principle

This is the open/closed principle. It basically tells us that:

> Each software module/class must be open for extensions and closed for modifications.

Imagine a system that needs to generate reports in different output formats (Word, PDF, etc.). Each of these formats needs different logic to generate a report.

But what if our client asks us to add a new report format? What are we going to do with our implementation that is already tested and working?

Should we change its logic to support issuing the new report format? The Open/Closed principle states that **no**

## Explaining the example

In the example code, we use this scenario where we need to consider issuing reports in different formats.
  

In the bad example [ruim](https://github.com/ehsandarvishi2003/SOLID-Principles-In-CSharp-2024/tree/master/OCP.OpenClosePrensiple/Bad), we have all the reporting logic concentrated in ReportGenerationHelper.cs only. This is terrible because, when a new type of format arrives, we have to change the class to check the type of the new report and implement its generation logic right there, invalidating the tests already guaranteed previously in the class.

In the good example [bom](https://github.com/ehsandarvishi2003/SOLID-Principles-In-CSharp-2024/tree/master/OCP.OpenClosePrensiple/Good), we work with an abstract class ReportGenerationHelper.cs that exposes a method to contain the report generation implementation. This way, we can create classes for each type of report - just as we saw in the single responsibility principle - that inherit our abstract class and each one will have its own logic for how the report should be generated.