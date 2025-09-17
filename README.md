# Task.Select

*This project requires **C# 10.0** or higher and targets **.NET 10.0**.*

## Usage

```csharp

// Before
var fooTask = Foo();
var barTask = Bar();
var foo = await fooTask;
var bar = await barTask;

// After
var (foo, bar) = await Task.Select(Foo(), Bar());

```