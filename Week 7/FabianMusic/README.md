# IT2030Fall2023FabianAbarca

Week 7 Lab Directions:

For this assignment, you will add a Products page to your retail application. The Products page will include and display six products to customers. We will add a model, a view, and a controller to our application. Start with your completed Week 5 lab files. 
1. In your Views/Shared/_Layout.cshtml file, add a link named Products for the Products page. The link will be after the Home link and before the About link.
Change the asp-controller from Home to Product and the asp-action from Index to ListProducts and change the display name to Products. We will add code to the controller to make this link work in a later step.
2. Add a model class to the Models folder, name it ProductModel.cs, and use the instructions on page 55 of the textbook to add the class.
Add the following five properties to this class which are ProductId, ProductName, ProductDescription, ProductImage, and ProductPrice.
Use an int data type for ProductId, a string data type for the ProductName, ProductDescription, and ProductImage, and a decimal data type for ProductPrice.
The ProductImage will store the file paths of the images in the images folder. Add images for your products to the wwwroot/images folder.
3. Add another class to the Models folder to store the data for our Products. Name this class ProductData.cs and store the products in a List.
You are to use the List<T> generic collection class from namespace System.Collections.Generic to store your Products. List<ProductModel> will be used to store your products. The ProductData class will have two static methods –
GetProducts( ) which creates and initializes 6 products and returns a list of products and returns a List<ProductModel> objects. For the ProductImage field store the file path of your image for each of your 6 products. For example, your file path would be /images/pic1.jpg
GetProduct(int id) which accepts as input an id, searches for the product and if found returns the product and if not found returns a new product (returns a ProductModel object).
4.Add a new folder, named Product, to your Views folder.
Add two views to your Product folder and name them, ListProducts.cshtml and Detail.cshtml. The Product folder will contain these two views to display products to customers.
The first view is ListProducts.cshtml (Views/Product/ListProducts.cshtml) and the second view is Detail.cshtml(Views/Product/Detail.cshtml).
5. For the Views/Product/ListProducts.cshtml page, use a strongly typed view (@model List<ProductModel>), display a title and a heading for this page.
Display the six products in a table with four columns and seven rows. The table headings are Product Name, Product Description and Product Price.
The fourth column has no heading and will be used to display a link to the Detail page. Use a foreach loop to display the products in the rows of the table.
Display the Product Image and the Product Description in the same column, with the image above the description.
Apply the table-hover, and table-responsive Bootstrap CSS classes to your table. Add img-fluid rounded Bootstrap CSS classes to the images in the table.
Using the Bootstrap CSS classes, change the text color of the heading on the Products page to either text-primary (dark blue), or text-secondary (gray), or text-success (green).
Include a link below the table that sends the customer back to the Home page when clicked. Style this link as a button. See sample image of ListProducts page below:
 Picture of ListProducts page
 
6. For the Views/Product/Detail.cshtml page, use a strongly typed view (@model ProductModel), display a title and a heading for this page.
Display each product’s detail in a table with two columns and four rows, using Name, Image, Description, and Price in the first column and their corresponding values displayed in the second column of the table.
Apply the table-hover, and table-responsive Bootstrap CSS classes to your table. Change the text color of the heading on the Detail page to either text-primary (dark blue), or text-secondary (gray), or text-success (green) using the Bootstrap CSS classes.
Include a link below the table that sends the customer back to the Products page when clicked. Style this link as a button. See sample image of Detail page below:
 Image of Product Detail Page
 
7. Add a new controller to your Controllers folder named ProductController.cs and code an action method called ListProducts that gets a list of products from the ProductData class and returns the view.
Code a second action method called Detail that accepts an int id and returns the view for the product that matches the id given as input if found and returns a new ProductModel if not found.
Include the using directive for the Models class in your ProductController. 