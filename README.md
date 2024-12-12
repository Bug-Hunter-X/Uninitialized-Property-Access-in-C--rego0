# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been initialized.  Uninitialized properties will have default values (0 for ints, null for objects, etc.), which may not always be what's expected.  This can lead to subtle and hard-to-debug issues.

## The Bug

The `bug.cs` file contains a simple class with a method that accesses a property before it's assigned a value.  This results in the property having its default value, potentially causing unexpected behavior.

## The Solution

The `bugSolution.cs` file shows the corrected code. It initializes the property before accessing it, ensuring the correct value is used.