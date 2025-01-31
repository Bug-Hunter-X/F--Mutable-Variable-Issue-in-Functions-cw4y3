# F# Mutable Variable Issue in Functions

This example demonstrates a common issue with mutable variables in F# functions. When mutable variables are passed as arguments to a function, the function operates on copies of the variables, not on the original variables themselves.  As a result, changes made to the variables within the function do not affect the original variables outside the function.

## Bug

The `bug.fs` file contains code demonstrating the issue. The `add` function correctly adds the initial values of `x` and `y`. However, modifying `x` and `y` after the initial call to `add` does not change the result of subsequent calls to `add`. 

## Solution

The `bugSolution.fs` file demonstrates a way to resolve the problem, either using ref cells or by modifying the function to operate directly on mutable variables passed by reference.