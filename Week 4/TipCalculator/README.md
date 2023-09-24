# IT2030Fall2023FabianAbarca


For this lab you will debug the Tip Calculator app that is provided for you in the TipCalculator-Wk4 
folder. This app only calculates the tip amount that a user has to pay for their meal. It does not 
calculate the total. In your Week 4 Lab/Readme.md file, list and identify all errors that you find. 
Specify which file had the errors, what the error was and state what you did to fix the error.

Errors found:

1. Syntax error in the TipCalculator.cs file, line 16. The CalculateTip method is missing a ";" symbol 
after "return tip". To fix the error, I added a ";" at the end of the statement.

2. Syntax error in the HomeController.cs file, line 14. The name Viewbag doesn't exist in the current
context. To fix the error, I changed the name "Viewbag" to "ViewBag".

3. Syntax error in the HomeController.cs file, line 10. Not all code paths return a value. The code is 
missing a "return" statement. To fix the error, I added a "return" statement before "View();".

4. Unhandled exception in the Index.cshtml file, line 16: Cannot perform runtime binding on a null reference. 
The statement "<label>@ViewBag.Fifteem.ToString("c2")</label>" has a syntax error. To fix the error, 
I changed the word "Fifteem" to "Fifteen".

5. After using breakpoint in the Models class, I found a logic error. The application was giving the wrong tip 
percent because the method was dividing the Meal Cost by the percent. I fixed the error by changing the "/" 
symbol by a "*" symbol.

6. Syntax error in the CSS file is preventing the label elements from displaying the correct width. To fix the error,
I changed the word "widht" to "width". 


