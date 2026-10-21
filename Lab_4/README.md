# Lab 4. in, out, ref, params, and Default Parameters

## Task

- Ստեղծել `static` մեթոդներ `A`, `B` և `C`, համապատասխանաբար `in`, `out` և `ref` մոդիֆիկատորները ցույց տալու համար։
- Ստեղծել `SumValues(params ...)` մեթոդ, որը գումարում է մուտքին տրված ամբողջ թվերը։ Թվերի քանակը ֆիքսված չէ։
- Ցույց տալ նաև լռելյայն արժեքով պարամետր։
- `Main` մեթոդում ցույց տալ, թե ինչպես են աշխատում այս մեթոդները։

## Files

| File | Role |
| --- | --- |
| `Program.cs` | `A`, `B`, `C`, `SumValues`, `DefaultParameter`, and `Main` |
| `Lab_4.sln` | Visual Studio solution |
| `Lab_4.csproj` | Project file |

## How to run

1. Open `Lab_4.sln` in Visual Studio.
2. Press Start (F5).

## Program behavior

`Main` calls `A` with `in`, `B` with `out`, and `C` with `ref`. It then sums two different lists through `params`, and calls `DefaultParameter` once with the default value and once with an explicit value.
