# Two-Dimensional Arrays in C#

## Table of Contents
- [Overview](#overview)
- [Declaration and Initialization](#declaration-and-initialization)
- [Element Access and Manipulation](#element-access-and-manipulation)
- [Implementation Example](#implementation-example)
- [Best Practices](#best-practices)

---

## Overview

<p align="justify">
A <b>two-dimensional array</b> is a data structure that organizes elements in a grid of rows and columns, forming a matrix. Each element is accessed using two indices: one for the row and one for the column. Like all arrays in C#, two-dimensional arrays are objects derived from the <code>System.Array</code> class.
</p>

<p align="justify">
Rectangular arrays define a <b>fixed grid</b> where the number of rows and columns is set at initialization and cannot change. They are ideal for representing matrices, grids, game boards, or tabular data with uniform row lengths.
</p>

<center>
  <img src="https://deen3evddmddt.cloudfront.net/uploads/content-images/two-dimensional-arrays-in-c.webp" width="600" />
</center>

### Key Characteristics

- **Zero-Based Indexing**: Row and column indices both start at `0`.
- **Fixed Dimensions**: Both row count and column count are immutable after initialization.
- **Uniform Structure**: Every row has exactly the same number of columns.
- **Type Safety**: Strongly typed — only elements of the specified type can be stored.
- **Reference Type**: Stored on the heap as a reference type.
- **Contiguous Memory**: The entire grid is stored in a single contiguous block, enabling cache-friendly access.
- **Fast Access**: Element retrieval by index is performed in O(1) time complexity.
- **API**: Accessed via `GetLength(dimension)` and double-index syntax `[row, col]`.

---

## Declaration and Initialization

```csharp
// Declaration with fixed dimensions (default values assigned)
int[,] matrix = new int[3, 4];

// Initialization with explicit values
int[,] grid = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

// Shorthand initialization
string[,] schedule =
{
    { "Monday",    "Math",    "Science" },
    { "Tuesday",   "History", "English" },
    { "Wednesday", "Art",     "PE"      }
};
```

---

## Element Access and Manipulation

```csharp
// Accessing elements
int center   = grid[1, 1];                         // row 1, column 1 → 5
int lastCell = grid[2, grid.GetLength(1) - 1];     // row 2, last column → 9

// Modifying elements
grid[0, 0] = 10;

// Getting dimensions
int rows    = grid.GetLength(0); // number of rows
int columns = grid.GetLength(1); // number of columns
int total   = grid.Length;       // total element count
```

---

## Implementation Example

```csharp
using System;

namespace RectangularArrayDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] scores = new int[,]
            {
                { 85, 90, 78 },
                { 92, 88, 95 },
                { 70, 75, 80 }
            };

            Console.WriteLine("Student Score Board:");
            for (int row = 0; row < scores.GetLength(0); row++)
            {
                for (int col = 0; col < scores.GetLength(1); col++)
                {
                    Console.Write($"{scores[row, col],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nRows: {scores.GetLength(0)}");
            Console.WriteLine($"Columns: {scores.GetLength(1)}");
            Console.WriteLine($"Total elements: {scores.Length}");
        }
    }
}
```

---

## Best Practices

### When to Use Rectangular Arrays

1. **Uniform Data**: When every row is guaranteed to have the same number of columns (e.g., a chessboard, an image pixel grid).
2. **Mathematical Operations**: When performing matrix arithmetic where consistent dimensions are required.
3. **Readability**: When the two-dimensional nature of the data should be immediately obvious from the declaration.

### Performance Optimization

1. **Cache Locality**: All elements are stored contiguously in memory. Traverse row by row to maximize cache utilization.
   ```csharp
   for (int row = 0; row < matrix.GetLength(0); row++)
       for (int col = 0; col < matrix.GetLength(1); col++)
           Process(matrix[row, col]);
   ```

2. **Pre-size at Declaration**: Since dimensions are fixed, determine the required size before initializing to avoid creating intermediate throwaway arrays.
   ```csharp
   int[,] buffer = new int[expectedRows, expectedCols];
   ```

3. **Use `foreach` for Read-Only Traversal**: When indices are not needed, `foreach` is cleaner and equally performant.
   ```csharp
   foreach (int value in matrix)
       Console.WriteLine(value);
   ```

---

*Documentation updated on Monday Mar 23, 2026.*
