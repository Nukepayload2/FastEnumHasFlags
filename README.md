# FastEnumHasFlags
Provides a faster Enum.HasFlag implementation.

## Build dependencies
- Microsoft Visual Studio 2017 (Recommended)
- .NET Framework 4.6.1 SDK (Required)
- [ILSupport(Required)](https://github.com/ins0mniaque/ILSupport)

## Test output
### Environment
|Category|Value|
|-|-|
|System|Windows 10 x64 pro 10.0.17134|
|Culture|zh-CN|
|CPU|Intel(R) Core(TM) i5-6400 CPU @ 2.70GHz|
|RAM|16.0 GB, 2133 MHz|

### Configuration
#### Release Any CPU
```
Loop count:=10,000,000, Enum type:=Microsoft.VisualBasic.MsgBoxStyle, Enum values count:=19
Enum constraint and embedded IL has flag: 91ms.
Net461 has flag: 4211ms.
Done.
```
#### Release x64
```
Loop count:=10,000,000, Enum type:=Microsoft.VisualBasic.MsgBoxStyle, Enum values count:=19
Enum constraint and embedded IL has flag: 138ms.
Net461 has flag: 4757ms.
Done.
```
#### Release x86
```
Loop count:=10,000,000, Enum type:=Microsoft.VisualBasic.MsgBoxStyle, Enum values count:=19
Enum constraint and embedded IL has flag: 90ms.
Net461 has flag: 4206ms.
Done.
```