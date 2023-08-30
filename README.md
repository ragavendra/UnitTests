## UnitTests
Repos having common tests for testing for different cases like to check if an array is sorted. Check if a number is even and so on.

This repository helps in building functionality based on `Test driven development`. Essentially one may not want to write say `sorting` method each time it is needed as there are chances are high that it may not be successful in edge cases. In such cases it is wise enough to have one method with all the data permutations needed to test it.

Please refer to [BMITests](Mathe/BMITests) for a valid example showing how the test data is generated in a range, dynamically to test the BMI method. 

### Conventions
The methods will be contained in `Class.cs` file and its test(s) in the `ClassTests.cs` file like say `MergeSort.cs` will have its test in `MergeSortTests.cs` file.

### CLI

To run all the test(s)

```
dotnet test
```

Run a specific test

```
dotnet test --filter "FullyQualifiedName=UnitTests.Tests.CheckSorted.CheckPositive"
```

## Donations
If you like using this repository and like to donate, please visit the below link. This work is made possible with donations like yours. PM for customizations and implementations .

<a href="https://www.buymeacoffee.com/ragavendra"><img src="https://img.buymeacoffee.com/button-api/?text=Buy me a pop&emoji=🥃&slug=ragavendra&button_colour=FFDD00&font_colour=000000&font_family=Cookie&outline_colour=000000&coffee_colour=ffffff" /></a>

[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=ZKRHDCLG22EJA)