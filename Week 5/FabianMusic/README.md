# IT2030Fall2023FabianAbarca

Week 5 Lab Directions:
For this assignment, you will add 2 more pages to your retail application - an About page and a 
Contact page.

1. Using your completed Week 2 project files, apply the Bootstrap CSS classes to style your 
Home page by doing the following:
* Put the text on your home page in 2 columns [refer to page 95 of the textbook]
* In the Views/Shared/_Layout.cshtml file, in the nav element of the header, change the 
background color of the nav bar to either dark blue, or gray, or green using the context 
classes that are available with Bootstrap. [refer to page 111 of the textbook]
* Apply the img-fluid rounded class to the image. [refer to page 101 of the textbook]
* Change the heading on your home page from “Welcome” to “Welcome to Jesse’s Sound Vibes” 
replacing Jesse’s Sound Vibes with the name of your retail store. If your app is missing a 
Welcome heading, add it to your application.

2. In your Views/Shared/_Layout.cshtml file, add a link named About for an About Us page. The 
link will be after the Home link and before the Privacy link. Do this by making a copy of the 
li element for the Home link and pasting it after the Home link. Change the asp-action from 
Index to About and change the display name to About. We will add code to the controller to make 
this link work in a later step.

3. Add a Razor view for the About page. Add this view to the Views/Home folder and name it 
About.cshtml.  Add code to this page to display information about your retail store. Your 
information must include a brief history of your store (3 sentences), the mission of the store 
(3 sentences),  and a vision of the store (3 sentences). Include a title and heading for this 
page. Include the following subheadings on this page – History, Mission, and Vision. Look at 
sample websites to get ideas of content included in About us pages.

4. Add an action method for the About Us page to the HomeController.cs file. You will need a 
simple action method like the following:
                     public IActionResult About( )
                   {
                          return View();
                    }
5. Save your work, run, and test your application. The About page should display when the link 
is clicked. Fix any errors before moving on to the next step.

6. In your Views/Shared/_Layout.cshtml file, add a link named Contact for the Contact page. The 
link will be after the About link and before the Privacy link. Do this by  making a  copy of the 
li element for the About link and pasting it after the About link. Change the asp-controller 
from Home to Contact, the asp-action from About to Index, and change the display name to Contact. 
We will add code to the controller to make this link work in a later step.

7. Add a model class to the Models folder, name it ContactModel.cs, and use the instructions on 
page 55 of the textbook to add the class. Add six properties to the model class, ContactModel.cs 
which are FirstName, LastName, Address, Phone, Email, and Message. Use a string data type for the 
six properties. Include the DataAnnotations namespace (i.e. include the using directive for the 
DataAnnotations). Each field is required. Use pages 72-77 as a guide in validating the user input 
and display validation error messages for all six properties.

8. Add a new folder named Contact to your Views folder. Add a Razor view to this folder and use 
the default name, Index.cshtml (Views/Contact/Index.cshtml). Follow the instructions on page 71 
of the textbook to add your Contact view. Use a strongly typed view. Use the code on page 105 of 
the textbook for the view of the Contact page. Make changes to this code to reflect the 6 
properties in your Contact view. Use the asp-validation-for tag helper to display your validation 
messages and display them in red. Include a title and a heading for the Contact page. On your 
contact page, include a mailing address for your store, a phone number, an email, and hours of 
operation. This page will display a contact form for customers to enter their information. When 
creating your Contact page, add to your Custom.css file, the css for the label and div element 
that is on page 65 of the textbook.  See attached sample images for layout ideas.

9. Add a new controller to your Controllers folder and name it ContactController.cs which will 
have two Index action methods. The first one will use the HttpGet attribute and return a View 
and the second one will use the HttpPost attribute and will accept a ContactModel object as 
input and return a view of the model. Use instructions on page 61 to complete this step.

10. Run and test your app. Upload your completed Visual Studio project files (including the 
solution file) to your GitHub Week 5 folder. Include a Readme.md file in your Week 5 GitHub 
folder with a summary of your lab.

11. Submit your Week 5 GitHub repo link to Blackboard. 