# IT2030Fall2023FabianAbarca

Week 11 Lab Directions:
For this assignment, you will add additional data validation to the ContactModel and the ProductModel. We will also add an
Events page that gives customers a list of events that your retail store is sponsoring. Start with your completed working Week 9 lab files.

1.Add the following data validation to the fields in the ContactModel,
FirstName – 30 characters or less and include a custom error message to the user; cannot contain special characters or numbers
and include a custom error message to the user.
LastName – 30 characters or less and include a custom error message to the user; cannot contain special characters or numbers 
and include a custom error message to the user.
Phone – 10 digits and include a custom error message to the user, use the RegularExpression attribute to ensure that the phone
is numbers only and does not include any letters.
Email – valid email address and include a custom error message to the user (use the EmailAddress attribute - see 
https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-6.0 for a list of validation attributes)
Note: You will be able to test the validation added to the ContactModel class using the Contact form

2. Add the following data validation to the fields in the ProductModel, (Be sure to include the directive for the DataAnnotations namespace)
ProductName – required and include a custom error message to the user.
ProductDescription – required and include a custom error message to the user.  
ProductImage – required and include a custom error message to the user. 
ProductPrice – use the DataType attribute to apply Currency to the ProductPrice field.
(See https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/validation?view=aspnetcore-6.0 for an example)
Note: We will test the validation added to the ProductModel class in a later lab.

3. Add a link for an Events page to your application. The Events page should be after the Tools link and is part of the Home Controller.

4. Add an Events view page and include the following for this page:
A title for the page.
A heading for the page.
Four events that your retail store is sponsoring.
For each event, include a description of the event and a title for the event.
Each event must include the specific age groups that can attend example students, staff, faculty, or all ages.
Each event must include a date and time.
Location of each event - either online (must specify medium - Zoom, Teams, WebEx) or in-person (must specify a physical address).
How to register for each event

5. The content on your Events page must be styled with each events' detail separated from the others and use any appropriate Bootstrap 
CSS classes for styling your content. You may use Bootstrap’s Card feature (see https://getbootstrap.com/docs/5.3/components/card/ for 
more details) or any other appropriate styling that provides distinction between one event's details from the other. 

6. Include an action method that will display the Events page view in the HomeController.

7. Run and test your app. Upload your completed Visual Studio project files (including the solution file) to your GitHub Week 11 folder. 
Include a Readme.md file in your Week 11 GitHub folder.