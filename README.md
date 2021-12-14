# Railflow.xUnit.TestRail.Reporter Examples

Examples on how to use [Railflow.xUnit.TestRail.Reporter](https://www.nuget.org/packages/Railflow.xUnit.TestRail.Reporter/) package with xUnit tests for TestRail integration.



Installing (NuGet)
============

Use this command to add the package to your test project.

```powershell
Install-Package Railflow.xUnit.TestRail.Reporter
```



Writing tests
=============



## Using RailflowAttribute

Apply this custom attribute to test methods/classes to mark them with TestRail metadata. See [railflow-xunit](https://github.com/railflow/railflow-xunit)  for more info.

Here is an example test:

```c#
[Railflow(Title = "class-title")]
public class RailflowAttributeExamples
{
	[Railflow(Title = "func-title-1", TestRailIds = new[] { 1, 2, 3 })]
	[Fact]
	public void Test1()
	{
	}

	[Railflow(Title = "func-title-2", ResultFields = new[] { "func-result-field-1", "func-result-field-2" })]
	[Fact]
	public void Test2()
	{
	}

	[Fact]
	public void Test3()
	{
	}
}
```



# Running tests

Use [xunit.runner.console](https://www.nuget.org/packages/xunit.runner.console) or [dotnet CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test) to run your tests and generate output XML.

E.g. 

```powershell
xunit.console.exe MyTestAssembly.dll -xml TestResults.xml
```

OR

```powershell
dotnet test MyTestProject.csproj --logger:"xunit;LogFilePath=TestResults.xml"
```

**NOTE:** Should install [XunitXml.TestLogger](https://www.nuget.org/packages/XunitXml.TestLogger/) NuGet package in order to use "xunit" logger with **dotnet CLI**



XML output
===========

Here is the output of tests from example above (<u>non-relevant pieces are skipped</u>).

```xml
<collection name="Test collection for Example.RailflowAttributeExamples">
  <test name="Example.RailflowAttributeExamples.Test1">
    <traits>
      <trait name="railflow-markers" value="{'Title':'func-title-1','TestRailIds':[1,2,3]}"/>
      <trait name="railflow-markers" value="{'Title':'class-title'}"/>
    </traits>
  </test>
  <test name="Example.RailflowAttributeExamples.Test2">
    <traits>
      <trait name="railflow-markers" value="{'Title':'func-title-2','ResultFields':['func-result-field-1','func-result-field-2']}"/>
      <trait name="railflow-markers" value="{'Title':'class-title'}"/>
    </traits>
  </test>
  <test name="Example.RailflowAttributeExamples.Test3">
    <traits>
      <trait name="railflow-markers" value="{'Title':'class-title'}"/>
    </traits>
  </test>
</collection>
```
