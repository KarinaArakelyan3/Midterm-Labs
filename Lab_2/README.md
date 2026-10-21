# Lab 2. Method Overloading and Default Parameters

## Task

Ստեղծել `static` մեթոդ `ToMultiplicate` երեք տարբերակով.

- Մեթոդը ընդունում է `x` և `N`։
- `N`-ը `int` է, և լռելյայն արժեքը `2` է։
- `x`-ը լինում է երեք տիպով՝ `int`, `double` և `string`։
- Մեթոդը վերադարձնում է `N` հատ `x`-երի գումարը։ `string`-ի դեպքում դա նույն տեքստի կրկնությունն է։
- `Main` մեթոդում ստուգել overloading-ի աշխատանքը։

## Files

| File | Role |
| --- | --- |
| `Program.cs` | Three `ToMultiplicate` overloads and `Main` |
| `Lab_2.sln` | Visual Studio solution |
| `Lab_2.csproj` | Project file |

## How to run

1. Open `Lab_2.sln` in Visual Studio.
2. Press Start (F5).

## Program behavior

`Main` calls the `int`, `double`, and `string` overloads. Some calls pass `N`, and some use the default value `2`.
