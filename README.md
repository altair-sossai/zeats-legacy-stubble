<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-stubble

Methods to solve common problems when working with Stubble

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-stubble?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=35&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.Stubble.svg)](https://www.nuget.org/packages/Zeats.Legacy.Stubble)

## Installation

```PM>
Install-Package Zeats.Legacy.Stubble
```

## Extensions

### StubbleHelper.Parse(string template, object data)
Parse a template using an object value
```c#
var template = "hello {{name}}";
var data = new { name = "Altair" };

StubbleHelper.Parse(string template, object data) /* return "hello Altair" */
```
---
