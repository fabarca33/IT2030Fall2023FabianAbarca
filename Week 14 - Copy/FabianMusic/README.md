# IT2030Fall2023FabianAbarca

Week 14 Lab Objectives:
The objective of this assignment is to demonstrate the importance of databases and learn how they are used in ASP.NET Core MVC. When working with databases, Create, Read, Update, and Delete
(CRUD) are the four ways that we operate on stored data. CRUD is a mnemonic for the four basic functions of persistent storage. These functions are typically reserved for those with
administrative privileges to the application. We will add a new link to our navbar to display the products and contact information views which will be different than what we had in 
earlier labs. Typically, we would create a separate section and store the code in the Areas folder but for the purposes of this lab, we will simply add a link to the navbar. In 
retail applications, customers would not see the links that we are adding. It would be for administrators. In the administrative view, we can add new products, view a product, 
update products, and delete products. These functionalities should not be available to customers. The admin view should have a login which we will not be completing in this lab.
 
Week 14 Lab Directions:
Start with your completed working Week 11 lab files.
It is important that all errors are fixed and that your code runs before completing the steps in this lab.
Also, it is important to use a Windows based PC to complete this lab as the Visual Studio tools for Mac computers lack some of the necessary tools required for the steps in this lab.
For this assignment, we are using a database to store our products. Recall that in Week 7 lab, we stored our 6 products in a List. In this lab, we are creating a database that will be 
used by the administrator of our retail store to store our Products and also store the data from our Contact page. Our database will have a table for our Products and a table for 
our Contacts. Visual Studio offers tools to help us complete this process. This lab illustrates the advantages of using databases to store information. We need to add the EF(Entity 
Framework) Core tools to our project before we can start working with the objects of our database.
The following steps will walk you through creating your database using a tool called Scaffolding. Scaffolding produces Create, Read, Update and Delete (CRUD) pages for your data model.

1. (Refer to pages 138-139 as a guide.) Add the NuGet packages. From the Tools menu, select NuGet Package Manager > Package Manager Console (PMC). In the PMC type and run the following
commands (NOTE: use version 7.0.14 when installing as version 8 will not install if your project is using .NET 6 framework, for those whose project is using .NET 7 framework, you may 
be able to install version 8 for both packages)
Install-Package Microsoft.EntityFrameworkCore.SqlServer 
Install-Package Microsoft.EntityFrameworkCore.Tools
These commands adds the following
The EF Core SQL Server provider. The provider package installs the EF Core package as a dependency.
The utilities used by the packages installed automatically in the scaffolding step.
Build the project to check for compiler errors. Fix all errors and build again.


2. In the ContactModel class, add a new integer field named ContactId to your class and add the [Key] attribute to the ContactId. Add validation to the Address and Message 
fields – required, with a custom error message displayed to the user if you do not have validation for the Address and Message fields.

3. In the ProductModel class, add the [Key] attribute to the ProductId.

4. Add a new folder named Data to your project. The Data folder will be at the same level as the Controllers, Views, and Models folder. Add the DbContext class for your project to the 
Data folder. Add the directive using Microsoft.EntityFrameworkCore; to your DbContext class. Add the directive to include your Models folder in the DbContext class code for your project.
For a student named Jesse whose project is JesseSoundVibes, the DbContext class will be named JesseSoundVibesContext.cs and will be in the Data folder.
The ProductModel is the entity type. Use ProductDb as the property for your DbSet<ProductModel> type. The ContactModel is the entity type. Use ContactDb for the property for your 
DbSet<ContactModel> type. (use page 141 as a guide for writing the code for the DbContext class for your project).
"EF Core uses DbSet properties to generate database tables with the specified names" (Delamater & Murach, 2023, p. 140). So our database tables will be named ProductDb and ContactDb. 
They will store our products and contacts.
Be sure the name of your DbContext class reflects your project name to avoid errors. We will add the links to our navbar in a later step. Our link names will be ContactDb and ProductDb.

5. (Refer to pages 144-145 as a guide.) Add connection strings to the appsettings.json file (the code must be added on one line in your project, or you will have errors) The code for 
the connection strings is provided for you. Change the JesseSoundVibesContext in the connection strings to the name of your DbContext class. Add your first Name and first letter of 
your last name to the beginning of the database name in the Connection strings. Student named Jesse V would have Database=JesseVWk14Lab
"ConnectionStrings": { "JesseSoundVibesContext": "Server=(localdb)\\mssqllocaldb;Database=Wk14Lab; Trusted_Connection=True;MultipleActiveResultSets=true" }

6. (Refer to pages 144-145 as a guide.) Add code to Program.cs file to enable dependency injection. The code to add is given below: (be sure to change the JesseSoundVibesContext to
the name of your DbContext class or you will have errors.) The given code must be added after the line builder.Services.AddControllersWithViews(); and before the line 
var app = builder.build();
Also add using JesseSoundVibes.Data; to Program.cs (change the JesseSoundVibes.Data to the name of your project or you will have errors) and add the directive 
using Microsoft.EntityFrameworkCore; as well
builder.Services.AddDbContext<JesseSoundVibesContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("JesseSoundVibesContext") ?? throw new InvalidOperationException("Connection string 'JesseSoundVibesContext' not found.")));

7. Save and build your project. Fix all errors before moving on to the next step.
8. Add links to the navbar for the ContactDb and ProductDb. These should be the last two links on your navbar. Use the information in the table below to complete this step.
asp-controller name
asp-action name
Link name
ProductModels
Index
ProductDb
ContactModels
Index
ContactDb
 The links will not work until we have completed the database creation steps.

9. We are now creating the views and controller. Use the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for your Product model.
a.  To use the scaffolding tool, in Solution Explorer, right-click the Controllers folder and select Add > New Scaffolded Item.

Screenshot of New Scaffolded Item

b. In the Add New Scaffold Item dialog, select MVC Controller with views, using Entity Framework > Add

Screenshot of Add New Scaffolded Item dialog box
 
Complete the Add MVC Controller with views, using Entity Framework dialog:
In the Model class drop down, select ProductModel.cs 
In the DbContext class row, select the arrow and select your DbContext class. My example is JesseSoundVibesContext(JesseSoundVibes.Data)
Views and Controller name: Keep the default.
Select Add.

Screenshot of Add MVC Controller with views, using Entity Framework dialog box
 
The scaffolding process runs and when successful creates and updates the necessary files.
If you get an error message, fix all errors using the error list window, save and build your project and select Add a second time to try it again. If you get an error message, select Tools on the menu > Get Tools and Features. The Visual Studio Installer dialog box pops up, then select Installed and click Modify (See https://github.com/dotnet/AspNetDocs/issues/591)
Scaffolding updates the following:
Inserts required package references in the .csproj project file.
Registers the database context in the Program.cs file.
Adds a database connection string to the appsettings.json file.
Scaffolding creates the following:
A product controller: Controllers/ProductModelsController.cs (you can open and look at the code created for you)
Razor view files for Create, Delete, Details, Edit, and Index pages: (you can open and look at the code created for you)    
Views/ProductModels/Create.cshtml
Views/ProductModels/Delete.cshtml
Views/ProductModels/Details.cshtml
Views/ProductModels/Edit.cshtml
  Views/ProductModels/Index.cshtml
The automatic creation of these files and file updates is known as scaffolding.
The scaffolded pages can't be used yet because the database doesn't exist. Running the app and selecting the ProductDb link or ContactDb link results in the following error “SqlException: Cannot open database "JesseVWk14Lab" requested by the login. The login failed…”
10. Repeat step 9 to create the CRUD pages for the ContactModel class. This will create the following:
A contact controller: Controllers/ContactModelsController.cs
Razor view files for Create, Delete, Details, Edit, and Index pages:    
                      Views/ContactModels/Create.cshtml
  Views/ContactModels/Delete.cshtml
  Views/ContactModels/Details.cshtml
  Views/ContactModels/Edit.cshtml
     Views/ContactModels/Index.cshtml

11. (Refer to pages 146-147) Next, we will use the EF Core Migrations feature to create the database. Migrations is a set of tools that create and update a database to match the
data model. “A migration is a file that contains C# code for creating, modifying, or deleting database objects” (Delamater & Murach, 2023, p. 146).
From the Tools menu, select NuGet Package Manager > Package Manager Console.
In the Package Manager Console (PMC), enter the following command and press enter:
Add-Migration Initial
This creates and adds a Migrations folder to your project with an InitialCreate.cs file in the Migrations folder. Next type and run the following command in the PMC
Update-Database
This creates a ModelSnapshot.cs file in the Migrations folder. You can view the contents of both files.
To view the database that was created, follow the instructions at the bottom of page 147 in the textbook.

12. In this step, four contacts will be added to the ContactDb table in our database. Open the Views/ContactModels/Index.cshtml file and change the heading from Index to ContactDb. 
Also, change the ViewData["Title"] from Index to Index-ContactDb. Save and run your code. Click on ContactDb link on the navbar and click Create New link. Add 4 contacts to your 
ContactDb table in the database. After adding all 4 contacts, take a screenshot of the ContactDb page with your 4 contacts and upload it with your project files. Notice that this 
view should not be available to customers but will be available to those who have admin privileges to maintain the contact information.

13. In order to display the images on the ProductDb page, make the following changes 
Filename	Line to be changed	Change to be made
Views/ProductModels/Index.cshtml	Find the line with @Html.DisplayFor(modelItem => item.ProductImage)	Replace with <img src="@item.ProductImage" alt="Product picture" class="img-fluid rounded" />
Views/ProductModels/Details.cshtml	Find the line with @Html.DisplayFor(model => model.ProductImage)	 Replace with <img src="@Model.ProductImage" alt="Product picture" class="img-fluid rounded" />
Views/ProductModels/Delete.cshtml	 Find the line with @Html.DisplayFor(model => model.ProductImage)	Replace with <img src="@Model.ProductImage" alt="Product picture" class="img-fluid rounded" />

Open the Views/ProductModels/Index.cshtml file and change the heading from Index to ProductDb. Also, change the ViewData["Title"] from Index to Index-ProductDb. Save and run your code. 
Click on ProductDb link on the navbar and click Create New link. Add 6 products to your ProductDb table in the database (They should be the same as the products that you have on your 
Products link). When adding each product, type the file path of your images in the ProductImage input box i.e. /images/pic1.jpg and after adding all 6 products take a screenshot of 
the ProductDb page showing the 6 products and upload it with your files. Notice that this view should not be available to customers but will be available to those who have admin privileges
to maintain the products