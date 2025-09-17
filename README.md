# Task.Select

*This project requires **C# 14.0** or higher and targets **.NET 10.0**.*

## Usage

```sh
dotnet add package Task.Select
```

In your code, you can use the `Task.Select` method to run multiple tasks in parallel and await their results in a more concise way.

```csharp

// Before
var fooTask = Foo();
var barTask = Bar();
var foo = await fooTask;
var bar = await barTask;

// After
var (foo, bar) = await Task.Select(Foo(), Bar());

```