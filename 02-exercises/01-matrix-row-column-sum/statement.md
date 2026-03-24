# Exercise 01: Matrix Row and Column Sum

## Problem Statement

<p align="justify">
Develop a program in C# that creates a 5x5 two-dimensional array named <code>matriz</code>, fills it with integer values, and calculates the sum of all elements in each row and each column, displaying every result on screen.
</p>

## Objective

<p align="justify">
Develop a program that:
</p>

1. Creates a 5x5 rectangular array named `matriz`
2. Fills every cell with integer values
3. Calculates the sum of all elements for each row
4. Calculates the sum of all elements for each column
5. Displays each row sum and each column sum on screen
6. Implements a `Matrix` class with methods to perform the calculations

## Input Specifications

- **Input**: `matriz` (5x5 `int[,]` array) — integer values for each cell of the matrix

### Constraints

- The array must be exactly 5 rows by 5 columns
- All values must be integers

## Output Specifications

- **Output**: A report containing:
  - Sum of elements for each row (Row 0 through Row 4)
  - Sum of elements for each column (Column 0 through Column 4)

## Example Test Cases

### Test Case 1: Uniform Values

**Input:**
```
matriz =
{ 1, 1, 1, 1, 1 }
{ 1, 1, 1, 1, 1 }
{ 1, 1, 1, 1, 1 }
{ 1, 1, 1, 1, 1 }
{ 1, 1, 1, 1, 1 }
```

**Output:**
```
Row 0 sum: 5
Row 1 sum: 5
Row 2 sum: 5
Row 3 sum: 5
Row 4 sum: 5
Column 0 sum: 5
Column 1 sum: 5
Column 2 sum: 5
Column 3 sum: 5
Column 4 sum: 5
```

**Explanation:**
- Every row contains five 1s, so each row sum is 5
- Every column contains five 1s, so each column sum is 5

### Test Case 2: Mixed Values

**Input:**
```
matriz =
{  1,  2,  3,  4,  5 }
{  6,  7,  8,  9, 10 }
{ 11, 12, 13, 14, 15 }
{ 16, 17, 18, 19, 20 }
{ 21, 22, 23, 24, 25 }
```

**Output:**
```
Row 0 sum: 15
Row 1 sum: 40
Row 2 sum: 65
Row 3 sum: 90
Row 4 sum: 115
Column 0 sum: 55
Column 1 sum: 60
Column 2 sum: 65
Column 3 sum: 70
Column 4 sum: 75
```

**Explanation:**
- Row 0: 1+2+3+4+5 = 15
- Row 4: 21+22+23+24+25 = 115
- Column 0: 1+6+11+16+21 = 55
- Column 4: 5+10+15+20+25 = 75

## Key Concepts

<p align="justify">
This exercise focuses on:
</p>

- **Two-Dimensional Arrays**: Declaring, initializing, and traversing a rectangular `int[,]` array
- **Nested Loops**: Using two nested `for` loops to iterate over rows and columns independently
- **Accumulator Pattern**: Resetting and accumulating a sum variable for each row/column pass
- **Index Awareness**: Distinguishing between fixing the row index vs. fixing the column index during iteration
- **Object-Oriented Programming**: Creating a `Matrix` class with encapsulated methods

## Approach & Hints

### Step 1: Create the Matrix Class

<p align="justify">
Design a <code>Matrix</code> class that holds the 5x5 array and exposes methods for filling, summing, and displaying.
</p>

**Class Structure:**
- Field: `int[,] matriz` — 5x5 array to store the values
- Method: `FillMatrix()` — assigns integer values to every cell
- Method: `CalculateRowSums()` — iterates columns for each fixed row
- Method: `CalculateColumnSums()` — iterates rows for each fixed column
- Method: `DisplayResults()` — prints all row and column sums

### Step 2: Row Sum Logic

<p align="justify">
Fix the row index in the outer loop and accumulate values across all columns in the inner loop.
</p>

```csharp
public void CalculateRowSums()
{
    for (int row = 0; row < matriz.GetLength(0); row++)
    {
        int sum = 0;
        for (int col = 0; col < matriz.GetLength(1); col++)
        {
            sum += matriz[row, col];
        }
        Console.WriteLine($"Row {row} sum: {sum}");
    }
}
```

### Step 3: Column Sum Logic

<p align="justify">
Fix the column index in the outer loop and accumulate values across all rows in the inner loop.
</p>

```csharp
public void CalculateColumnSums()
{
    for (int col = 0; col < matriz.GetLength(1); col++)
    {
        int sum = 0;
        for (int row = 0; row < matriz.GetLength(0); row++)
        {
            sum += matriz[row, col];
        }
        Console.WriteLine($"Column {col} sum: {sum}");
    }
}
```

## Implementation Guidelines

### Recommended Structure

**Matrix.cs**
```csharp
namespace Exercise01.MatrixRowColumnSum
{
    public class Matrix
    {
        private int[,] matriz;

        public Matrix()
        {
            matriz = new int[5, 5];
        }

        public void FillMatrix()
        {
            // Assign integer values to every cell
        }

        public void CalculateRowSums()
        {
            // Sum and display each row
        }

        public void CalculateColumnSums()
        {
            // Sum and display each column
        }

        public void DisplayResults()
        {
            // Call row and column sum methods
        }
    }
}
```

**Program.cs**
```csharp
namespace Exercise01.MatrixRowColumnSum
{
    class Program
    {
        static void Main()
        {
            Matrix m = new Matrix();
            m.FillMatrix();
            m.DisplayResults();
        }
    }
}
```

### Complexity Analysis

- **Time Complexity**: O(n²) — filling and each sum pass both iterate over all n×n cells.
- **Space Complexity**: O(n²) — storage for the 5×5 array.

---

*Good luck with your implementation!*
