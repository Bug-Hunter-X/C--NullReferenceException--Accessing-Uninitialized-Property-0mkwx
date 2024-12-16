# C# NullReferenceException: Accessing Uninitialized Property

This repository demonstrates a common C# error: a `NullReferenceException` that occurs when accessing a class property that might not have been initialized.  The example highlights a scenario where a property's value is assumed to be set but could be null in some code paths.

The `bug.cs` file contains the problematic code, and `bugSolution.cs` shows how to fix the issue.

## Problem

The problem lies in accessing `MyProperty` before explicitly assigning it a value. If `MyProperty` remains in its default, uninitialized state (0 for `int`), accessing it directly will not cause an error, however, issues arise when a more complex object is the property type.

## Solution

The solution involves ensuring that `MyProperty` is always initialized before being used. This can be done either by providing a default value in the property declaration, or by adding null checks before accessing the property.  The `bugSolution.cs` demonstrates both techniques.