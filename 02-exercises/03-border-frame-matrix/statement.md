# Exercise 03: Border Frame Matrix

## Problem Statement

<p align="justify">
Develop a program in C# that creates a 5x15 two-dimensional array named <code>marco</code> and fills it so that all border cells (first row, last row, first column, last column) receive the value <code>1</code>, while all interior cells receive the value <code>0</code>, forming a rectangular frame. The resulting matrix is then displayed on screen.
</p>

## Objective

<p align="justify">
Develop a program that:
</p>

1. Creates a 5x15 rectangular array named `marco`
2. Assigns `1` to every cell located on the outer border of the matrix
3. Assigns `0` to every interior cell
4. Displays the complete matrix as a grid on screen
5. Implements a `FrameMatrix` class with methods to build and display the frame

## Input Specifications

- **Input**: None — cell values are determined entirely by position logic

### Constraints

- The array must be exactly 5 rows by 15 columns
- Border cells (`row == 0`, `row == 4`, `col == 0`, or `col == 14`) must hold `1`
- All other cells must hold `0`

## Output Specifications

- **Output**: The 5x15 frame matrix printed as a space-separated grid

## Example Test Cases

### Test Case 1: Expected Frame Output

**Input:**
```
(no input — values are position-based)
```

**Output:**
```
1 1 1 1 1 1 1 1 1 1 1 1 1 1 1
1 0 0 0 0 0 0 0 0 0 0 0 0 0 1
1 0 0 0 0 0 0 0 0 0 0 0 0 0 1
1 0 0 0 0 0 0 0 0 0 0 0 0 0 1
1 1 1 1 1 1 1 1 1 1 1 1 1 1 1
```

**Explanation:**
- Row 0 and Row 4 are entirely filled with `1` (top and bottom borders)
- Column 0 and Column 14 are entirely filled with `1` (left and right borders)
- All remaining cells in rows 1–3 and columns 1–13 hold `0`

### Test Case 2: Verify Individual Cells

**Input:**
```
(no input)
```

**Output (cell checks):**
```
marco[0,0]  = 1   marco[0,7]  = 1   marco[0,14] = 1
marco[2,0]  = 1   marco[2,7]  = 0   marco[2,14] = 1
marco[4,0]  = 1   marco[4,7]  = 1   marco[4,14] = 1
```

**Explanation:**
- Corner and edge cells all yield `1`
- The center cell (2, 7) is fully interior → `0`

## Key Concepts

<p align="justify">
This exercise focuses on:
</p>

- **Two-Dimensional Arrays**: Declaring and initializing a rectangular `int[,]` array with different row and column counts
- **Boundary Detection**: Using compound boolean conditions to identify border positions
- **Conditional Assignment**: Applying `row == 0 || row == lastRow || col == 0 || col == lastCol` to set cell values
- **Nested Loops**: Iterating over all rows and columns to fill and display the matrix
- **Object-Oriented Programming**: Creating a `FrameMatrix` class with encapsulated methods

## Approach & Hints

### Step 1: Create the FrameMatrix Class

<p align="justify">
Design a <code>FrameMatrix</code> class that holds the 5x15 array and exposes methods for building the border pattern and displaying the result.
</p>

**Class Structure:**
- Field: `int[,] marco` — 5x15 array to store the values
- Method: `BuildFrame()` — fills border cells with `1` and interior cells with `0`
- Method: `DisplayMatrix()` — prints the matrix as a grid

### Step 2: Build the Border Pattern

<p align="justify">
Iterate over every cell and apply the boundary condition: assign <code>1</code> if the cell is on any edge, <code>0</code> otherwise.
</p>

```csharp
public void BuildFrame()
{
    int lastRow = marco.GetLength(0) - 1;
    int lastCol = marco.GetLength(1) - 1;

    for (int row = 0; row <= lastRow; row++)
    {
        for (int col = 0; col <= lastCol; col++)
        {
            bool isBorder = row == 0 || row == lastRow || col == 0 || col == lastCol;
            marco[row, col] = isBorder ? 1 : 0;
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
    for (int row = 0; row < marco.GetLength(0); row++)
    {
        for (int col = 0; col < marco.GetLength(1); col++)
        {
            Console.Write($"{marco[row, col]} ");
        }
        Console.WriteLine();
    }
}
```

## Implementation Guidelines

### Recommended Structure

**FrameMatrix.cs**
```csharp
namespace Exercise03.BorderFrameMatrix
{
    public class FrameMatrix
    {
        private int[,] marco;

        public FrameMatrix()
        {
            marco = new int[5, 15];
        }

        public void BuildFrame()
        {
            // Assign 1 on borders, 0 on interior cells
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
namespace Exercise03.BorderFrameMatrix
{
    class Program
    {
        static void Main()
        {
            FrameMatrix fm = new FrameMatrix();
            fm.BuildFrame();
            fm.DisplayMatrix();
        }
    }
}
```

### Complexity Analysis

- **Time Complexity**: O(n×m) — every cell of the 5×15 matrix is visited once to assign its value and once to display it.
- **Space Complexity**: O(n×m) — storage for the 5×15 array.

---

*Good luck with your implementation!*
