# Chapter 4 - Writing, Debugging, and Testing Functions

## What This Chapter Covers
- Writing functions
- Debugging during development
- Logging during development and runtime
- Unit testing
- Throwing and catching exceptions in functions
- Practicing and exploring
- Summary

---

## Chapter Goals
- Understand how to declare and use functions effectively
- Learn debugging techniques available in .NET
- Use logging to observe application behavior
- Write and run unit tests
- Handle errors using exceptions

---

## Unit testing

- Understanding usage errors and execution errors
	- Usage errors
		- When programmers misused a function, typically by passing invalid values as parameteres.
		- Should be fixed before production runtime
	- Execution errors
		- When something happens at runtime that cannot be fixed by writing “better” code.
		- It can be split into program errors and system errors
		- Examples: 
			- When we attempt to access a network but the network is down. In that case, writting a "better" code won't solve the issue. We'll need to wait for the network to be back.
				- In that case, we need to be able to handle that system error by logging an exception
	- Commonly thrown exceptions in functions
		- When defining your own functions with parameters, the code should check the parameter values and throw exceptions if they have values that will prevent your function from properly functioning.
		- For example, if a parameter to a function should not be null => throw ArgumentNullException.
		- For other problems => throw ArgumentException, NotSupportedException, InvalidOperationException
		- For any exception, include a message that describes the problem for whoever will have read it.
			- For Devs => add messages for class librairies and functions
			- For end users => add messages if it's the highest level of a GUI app
			- **Good practice:** If a function cannot successfully perform its operation, you should consider it a function failure and report it by throwing an exception.
			- Instead of writing an if statement and then throwing a new exception, we could directly add those guard clause methods:
				- ArgumentException: ThrowIfNullOrEmpty, ThrowIfNullOrWhiteSpace
				- ArgumentNullException: ThrowIfNull
				- ArgumentOutOfRangeException:
					- ThrowIfEqual,ThrowIfGreaterThan, ThrowIfGreaterThanOrEqual, ThrowIfLessThan, ThrowIfLessThanOrEqual, ThrowIfNegative, ThrowIfNegativeOrZero, ThrowIfNotEqual, ThrowIfZero
	- Throwing exceptions using guard clauses
		- Rethrowing exceptions
		- Three ways to rethrow an exception inside a catch block:
			- To throw the caught exception with its original call stack, call throw.
			- To throw the caught exception as if it was thrown at the current level in the call stack: call throw with the caught exception, for example, throw ex. 
				- Usually poor practice because you have lost some potentially useful information for debugging
				- can be useful when you want to deliberately remove that information when it contains sensitive data.