# Exercise 02: Identity Matrix

## Problem Statement

<p align="justify">
Develop a program in C# that creates a 5x5 two-dimensional array named <code>diagonal</code> and fills it to form an identity matrix: cells where the row index equals the column index receive the value <code>1</code>, while all remaining cells receive the value <code>0</code>. The final matrix is then displayed on screen.
</p>

## Objective

<p align="justify">
Develop a program that:
</p>

1. Creates a 5x5 rectangular array named `diagonal`
2. Assigns `1` to every cell where `row == col`
3. Assigns `0` to every other cell
4. Displays the complete matrix as a grid on screen
5. Implements a `DiagonalMatrix` class with methods to build and display the matrix

## Input Specifications

- **Input**: None — cell values are determined entirely by position logic

### Constraints

- The array must be exactly 5 rows by 5 columns
- Diagonal cells (`row == col`) must hold `1`; all others must hold `0`

## Output Specifications

- **Output**: The 5x5 identity matrix printed as a space-separated grid

## Example Test Cases

### Test Case 1: Expected Identity Matrix

**Input:**
```
(no input — values are position-based)
```

**Output:**
```
1 0 0 0 0
0 1 0 0 0
0 0 1 0 0
0 0 0 1 0
0 0 0 0 1
```

**Explanation:**
- Cells (0,0), (1,1), (2,2), (3,3), (4,4) are on the main diagonal → value `1`
- All other cells → value `0`

### Test Case 2: Verify Individual Cells

**Input:**
```
(no input)
```

**Output (cell checks):**
```
diagonal[0,0] = 1   diagonal[0,1] = 0
diagonal[2,2] = 1   diagonal[2,3] = 0
diagonal[4,4] = 1   diagonal[4,0] = 0
```

**Explanation:**
- The condition `row == col` uniquely identifies the five diagonal positions
- Any position where `row != col` yields `0`

## Key Concepts

<p align="justify">
This exercise focuses on:
</p>

- **Two-Dimensional Arrays**: Declaring and initializing a rectangular `int[,]` array
- **Conditional Assignment**: Using `row == col` to differentiate diagonal from non-diagonal cells
- **Nested Loops**: Iterating over all rows and columns to fill and display the matrix
- **Pattern Recognition**: Mapping a mathematical concept (identity matrix) to array index logic
- **Object-Oriented Programming**: Creating a `DiagonalMatrix` class with encapsulated methods

## Approach & Hints

### Step 1: Create the DiagonalMatrix Class

<p align="justify">
Design a <code>DiagonalMatrix</code> class that holds the 5x5 array and exposes methods for building and displaying the identity pattern.
</p>

**Class Structure:**
- Field: `int[,] diagonal` — 5x5 array to store the values
- Method: `BuildMatrix()` — fills the array using the `row == col` condition
- Method: `DisplayMatrix()` — prints the matrix as a grid

### Step 2: Build the Identity Pattern

<p align="justify">
Iterate over every cell and apply the conditional: assign <code>1</code> on the diagonal, <code>0</code> elsewhere.
</p>

```csharp
public void BuildMatrix()
{
    for (int row = 0; row < diagonal.GetLength(0); row++)
    {
        for (int col = 0; col < diagonal.GetLength(1); col++)
        {
            diagonal[row, col] = (row == col) ? 1 : 0;
        }
    }
}
```

### Step 3: Display the Grid

<p align="justify">
Print each row on its own line with space-separated values.
</p>

```csharp
public void DisplayMatrix()
{
    for (int row = 0; row < diagonal.GetLength(0); row++)
    {
        for (int col = 0; col < diagonal.GetLength(1); col++)
        {
            Console.Write($"{diagonal[row, col]} ");
        }
        Console.WriteLine();
    }
}
```

## Implementation Guidelines

### Recommended Structure

**DiagonalMatrix.cs**
```csharp
namespace Exercise02.IdentityMatrix
{
    public class DiagonalMatrix
    {
        private int[,] diagonal;

        public DiagonalMatrix()
        {
            diagonal = new int[5, 5];
        }

        public void BuildMatrix()
        {
            // Assign 1 on diagonal, 0 elsewhere
        }

        public void DisplayMatrix()
        {
            // Print the grid row by row
        }
    }
}
```

**Program.cs**
```csharp
namespace Exercise02.IdentityMatrix
{
    class Program
    {
        static void Main()
        {
            DiagonalMatrix dm = new DiagonalMatrix();
            dm.BuildMatrix();
            dm.DisplayMatrix();
        }
    }
}
```

### Complexity Analysis

- **Time Complexity**: O(n²) — every cell is visited once to assign its value and once to display it.
- **Space Complexity**: O(n²) — storage for the 5×5 array.

---

*Good luck with your implementation!*
