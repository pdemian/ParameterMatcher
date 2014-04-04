# Parameter Matcher

## Purpose
This project deals with defining a function based on the parameter value of the function.
I based this off of Haskell's parameter matching. An example would be

    factorial 0 = 1
    factorial n | n > 0 = n * factorial( n - 1)
    
This code defines a recursive factorial in Haskell.
Essentially:
If the parameter given is 0, return 1
If the parameter given is greater than 0, return n * factorial (n - 1)

This project essentially emulates that in C# (unfortunately though, not elegantly)

Additionally, the project at the moment is current limited to a predefined number of parameters, thus overloading the function is not possible in the current version.

## Usage
To define a function, first we must declare it as any other class
    
    MatchFunction<TSource1, TSource2, ... TSourceN, TResult> example = new MatchFunction<TSource1, TSource2, ... TSourceN, TResult>();
    
Then, a match must be defined. This takes the form of the following

    example.Match( result, predicate );
    
Where result is a function, either anonymous or declared as Func<TSource1, TSource2... TSourceN, TResult> and predicate is a similar function but the result returns a boolean expression.
If the predicate is true, the result function will be run, otherwise, it checks other matches. If non exist, 0 is returned by default.
The code is then run in the following form

    example.Run( parameter1, parameter2, ... parameterN );
    
Which matches parameters based on the predicate and runs the result function. 
The parameters must be of types TSource1...TSourceN and the return type will be TResult.


    
## Examples
A factorial in Haskell is defined as
    
    factorial 0 = 1
    factorial n | n > 0 = n * factorial( n - 1)
    
Similarly, a factorial using this library is defined as

    MatchFunction<int, int> factorial = new MatchFunction<int, int>();
    
    factorial.Match(n => 1,                        n => n == 0);
    factorial.Match(n => n * factorial.Run(n - 1), n => n > 0);

And can print out the 10th factorial as follows:

    factorial.Run(10);

See Example.cs for more examples

## Installation
Copy MatchFunction.cs into your project

