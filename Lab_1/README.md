# Lab 1. Class, Random, Matrix, Properties, Constructor

## Task

Ստեղծել կլաս, որը պարունակում է N×N մատրիցա.

- Կլասում պահել `private` դաշտեր `N`, `A` և `B` (ամբողջ թվեր) և դրանց համար տալ `{ get; set; }` կարճ գրելաձևով։
- Ստեղծել `private` մեթոդ `FillMatrix`, որը մատրիցան լրացնում է `[A, B]` միջակայքի պատահական թվերով։
- Ստեղծել `public` մեթոդ `ShowMatrix`, որը արտածում է մատրիցայի պարունակությունը։
- Ստեղծել մեթոդ, որը վերադարձնում է մատրիցայի կենտ թվերի քանակը։
- Պարամետրերով կոնստրուկտորում վերագրել `N`, `A` և `B`, ապա կանչել `FillMatrix`։
- `Main` մեթոդում ցույց տալ կլասի աշխատանքը։

## Files

| File | Role |
| --- | --- |
| `MatrixClass.cs` | Matrix class: fields, constructor, fill, print, odd count |
| `Program.cs` | `Main`: creates a matrix and prints it |
| `Lab_1.sln` | Visual Studio solution |
| `Lab_1.csproj` | Project file |

## How to run

1. Open `Lab_1.sln` in Visual Studio.
2. Press Start (F5).

## Program behavior

`Main` creates a `MatrixClass` with `N = 5`, `A = 1`, and `B = 10`. The constructor fills a 5×5 matrix with random integers from that range. The program then prints every cell and the count of odd values.
