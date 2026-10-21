# Lab 3. Strings, Formatting, and Enum

## Task

Ստեղծել `Movie` կլասը հետևյալ դաշտերով՝ ֆիլմի համար, անուն, տարեթիվ, ժանր, դիտումների քանակ, լայքերի քանակ.

- Ժանրի համար ստեղծել `enum` 5 արժեքով։
- Տվյալները կարդալ `Console.ReadLine()`-ով։ Ժանրը մուտքագրել `1`-ից `5` թիվ, տողը բաժանել `Split`-ով և լցնել դաշտերը։
- Ստեղծել մեթոդ, որը հաշվում է ռեյտինգը `Sqrt(Likes ^ 2 / Views)` բանաձևով (`double`)։
- Override անել `ToString()`-ը այս ձևաչափով.
  - ֆիլմի համարը՝ 4 նիշ, աջից
  - ֆիլմի անունը՝ 15 նիշ, ձախից
  - տարեթիվը՝ 8 նիշ, ձախից, փակագծերում, օրինակ `(2011)`
  - ժանրը՝ 12 նիշ, տեքստով, ձախից
  - ռեյտինգը՝ 8 նիշ, 3 նիշ ստորակետից հետո, զրոները ցույց տալ
- `Main`-ում սկզբում կարդալ ֆիլմերի քանակը, հետո այդքան ֆիլմ, ապա արտածել ֆորմատավորված տողերը։
- Դաշտերն ու մեթոդները `public` են։

## Files

| File | Role |
| --- | --- |
| `Movie.cs` | `genres` enum, `Movie` class, rating, and `ToString` |
| `Program.cs` | Reads the movie count and prints every movie |
| `Lab_3.sln` | Visual Studio solution |
| `Lab_3.csproj` | Project file |

## How to run

1. Open `Lab_3.sln` in Visual Studio.
2. Press Start (F5).
3. Enter the number of movies, then one line per movie:

```
number name year genre views likes
```

Example:

```
1
1 Inception 2010 1 1000 800
```

Genre numbers are `1` SciFi, `2` Action, `3` Horror, `4` Fantasy, and `5` Romance. If a movie name has more than one word, type it with an underscore, for example `The_Matrix`.

## Program behavior

Each line is split by spaces into six fields. The genre number is stored in the `genres` enum. `ToString` prints the movie with the column widths from the task, and the rating is `Sqrt(likes² / views)`.
