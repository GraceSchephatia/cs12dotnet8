# Chapter 4 – Good Practices

This file captures "Good Practice" guidance highlighted in
*C# 12 and .NET 8 – Modern Cross-Platform Development Fundamentals*
by Mark J. Price, paraphrased and documented for learning purposes.
``
---

## Table of Contents
[Good Practice 1 - Configuring trace listeners](#good-practice-1---configuring-trace-listeners)
## Good Practice 1 - Configuring trace listeners
**Source:** Mark J. Price, Chapter 4  
**Practice:** 
- Any type that represents a file usually implements a buffer to improve performance.
- Data is written to an in-memory buffer instead of being writing immediately to the file.
- Enabling *AutoFlush* : *Flush* methods is called automatically after every write.

**Why this matters:**
We SHOULD ONLY set it during debugging and NOT in production, as it reduces performance
