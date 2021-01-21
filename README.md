<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-stubble

Extensions to solve common problems when working with Stubble

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-stubble?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=35&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.Stubble.svg)](https://www.nuget.org/packages/Zeats.Legacy.Stubble)

## Installation

```PM>
Install-Package Zeats.Legacy.Stubble
```

## Extensions

### IpValidator.IsIpV4(string stubble)
Checks if the content of a string is a valid Stubble V4
```c#
IpValidator.IsIpV4("10.a.30.40") /* return false */
IpValidator.IsIpV4("10.0.0.150") /* return true */
```
---
