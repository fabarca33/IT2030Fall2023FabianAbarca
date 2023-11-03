# IT2030Fall2023FabianAbarca

Week 9 Lab Directions:

For this assignment, you will add a FAQ (Frequently Asked Questions) page to your retail application. The FAQ page will include and display 
six questions with answers to customers. You will add a link to the FAQ page, a view, and an action method to the Home Controller. In this 
lab you will demonstrate using session state. Start with your completed Week 7 lab files. Use attached images as a guide.

1. Add a link to the navbar for your FAQ page. The FAQ page will be after the Contact link and will be part of the Home Controller. Add an 
action method to the Home Controller for the FAQ page.

2. Add the following to the FAQ page:
- A Razor view for the FAQ page. Your Views/Home folder should contain a file named FAQ.cshtml
- A heading and a title for the FAQ page. Use Frequently Asked Questions for your heading and FAQ for the title of the page.
- Six commonly asked questions about your retail store. Look at sample websites to get ideas of questions you should include.
- Answers to each of the six questions.
- Use Bootstrap CSS classes to style the content of your FAQ page (see https://getbootstrap.com/docs/5.3/components/accordion/ or 
https://getbootstrap.com/docs/5.3/components/list-group/ for ideas. You can use accordion or list group to display your questions and answers)

3. Add the code for the required session state services to your Program.cs file. Follow the instructions on pages 332-333 of your textbook 
to add these services.

4. Add a class MySession.cs to your Models folder with the following variables – FirstName (string data type), LastName (string data type), 
Course (string data type), and FavNum (int data type). Note: The variables represent your First Name, Last Name, Our course number (IT2030) 
and your favorite number. We will add the values for these variables in a later step.

5. Add another link named Tools to your navbar. The Tools page will be used to display the session state information variables. The Tools page 
will be after the FAQ page and will be part of the Home Controller.

6. Add two Tools action method to the HomeController – one will set the four variables and the other will get the four variables and have the 
view display them. In the first Tools action method, set the values for the four variables using FirstName, LastName, Course, and FavNum as 
the keys and your first name, your last name, our course number IT2030, and your favorite number as the corresponding values. When a user 
clicks the Display Session Variables button in the view, the assigned values should display in the View’s input boxes. The second Tools action 
method should clear the values in the input boxes.

7. Add a Tools view to your Views/Home folder. Use a strongly typed view and use the MySession model class. Include a title for the Tools page 
and a heading also. Display the four variables in a form with labels and readonly input elements. Include a button (Display Session Variables) 
that displays the values of the four variables when it is clicked. Include a link styled as a button that clears the values of the four variables 
in the input boxes when clicked. Style this page like the Contact page.  

8. Run and test your app. Upload your completed Visual Studio project files (including the solution file) to your GitHub Week 9 folder. Include 
a Readme.md file in your Week 9 GitHub folder.

9. Submit your Week 9 GitHub repo link to Blackboard. 