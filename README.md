The DiceRoller class has 3 variables:
1. NumOfDice = Represents the number of dice to be rolled, must be an Integer with a value of at least 1
2. Sides = Represents how many sides a single die has, must be an Integer with a value of at least 1
3. Modifier = A simple number that is added on after all of the dice have been rolled, must be an Integer

You may create an actual DiceRoller object to store the values and call methods from later, or you may use the static methods from the class without needing to create the object. 

Whether using the Constructors or the Static Methods there are *usually* 3 different variations of each with the distinction being the number of arguments.

The different variations are:

(int Sides) 
This means you only want to roll a singular die. The other variables are set to { NumOfDice = 1, Modifier = 0}

(int NumOfDice, int Sides)
The variable {Modifier = 0} is set by default.

(int NumOfDice, int Sides, int Modifier)

The Roll() method will return a radomized number based on the dice values you passed in either through the constructor or the static method.

There are also Maximum(), Minimum() and Mean() methods for the actual objects at the moment, static versions not implemented.
Maximum() returns the highest possible value that can be aquired from the rolls.
Minimum() returns the lowest possible value that can be aquired from the rolls.
Mean() returns the average value that can be aquired from the rolls. The value returned may not be attainable from rolling them as the average might be a decimal.

Future Additions:
- Implement String() and StandardDeviation() methods
- Implement all static methods
- Implement custom sides with arrays as the input
- Implement heterogeneous dice rolls, Example: "3d6 + 1d4" having full method support
