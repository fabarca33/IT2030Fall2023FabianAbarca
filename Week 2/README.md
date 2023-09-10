# IT2030Fall2023FabianAbarca

Week 2 Lab Directions:
For this assignment, you will create the Home page for your retail app. This Home page 
includes a navigation bar and some menu options for later assignments

Start a web app that is based on the ASP.NET Core Model-View-Controller template. 
Include your first name as part of the project name. 

In your Views/Home/Index.cshtml file add the summary description of your retail store 
from your Week 1 lab. At least two paragraphs are required for the description of your 
retail store. These two paragraphs must have a minimum of three sentences each.

Add an image to your Home page. Create an images folder in the wwwroot folder of your 
project files and store your images in this folder. All images that will be used for 
your application will be stored here.

Use the given custom CSS file (custom.css). Use the custom.css file as given, or you 
can modify it to reflect your own design for your page. Add the following line to your 
Views/Shared/_Layout.cshtml file (Make sure to add it after the link for the bootstrap 
style sheet). 
<link rel="stylesheet" href="~/css/custom.css" asp-append-version="true" />
