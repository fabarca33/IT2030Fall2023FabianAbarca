# IT2030Fall2023FabianAbarca

Week 16 Lab Objectives:

Instructions:
1.	During an interview for a job, you were asked about your ASP.NET Web programming class. Respond to the question by listing three things that you learned in the course. 
	In your GitHub Week 16 lab Readme.md file, list three things you learned in ASP.NET Core MVC web programming course. Be specific and include a brief description with 
	details.
2.	List three features that can be added to your application to improve the application for users. Be specific and include a brief description with details. 
	List your three features in your GitHub Week 16 Readme.md file.
3.	Code one of the features listed in (2) above and provide information of what you coded in your blackboard submission. Note: The information provided in your blackboard 
	submission should give a summary of what was coded in your project as well as the file(s) that has the code feature applied to it.
4.	Make a copy of your Week 14 lab files and using the copy, make 4 style updates to your application. Specify the filename(s) that has the 4 updates and specify 
	the 4 style updates as well in your Readme.md file. Include entire filename path when specifying filename(s).
5.	 Upload your completed files to your Week 16 lab folder in GitHub and submit your link in Blackboard.

1.	I learnt that many functions of a retail application can be coded with bootstrap, especially the front-end of the app. Bootstrap is great for coding templates 
	to create forms, cards, navigation templates, colors, and font sizes.
I learnt the way that Views, Models, and Controllers work and communicate with each other. The controllers are where actions are processed, it gets the data from the 
model to feed to the view. The view is responsible for displaying the information for the user. The model deals with data, data storage and retrieval.
I also learnt how to effectively debug an application. I learnt how to run an app with debugging, Hot Reload, the Developer Tools, the Internal Server Error, the 
Exception Helper, enabling and disabling breakpoints.

2.	The three features I recognize that could be added to the application are:
-	Adding a cart page so users can add multiple items and checkout easily.
-	Creating accounts for users, so they can login to the application and keep their preferences.
-	Adding Lists by Artist and by Album

3.	I tried to code Lists of Artists and Albums. I created the files: 
-	Album Controller and Artist Controller.
-	A Repository folder with the classes IRepository and Repository
-	Extension Method: StringExtensionMethods
-	Grids: AlbumGridData, ArtistGridData, and GridData
-	View Models: AlbumListViewModel and ArtistListViewModel
-	Models: Album and Artist models
-	Views: AlbumList and ArtistList.
-	Updated the Program.cs file.
Unfortunately, I couldn’t compile the updated application. I will continue debugging the application.

4.	The file that has the styling changes is called custom.css and it is located at:
/wwwroot/css/custom.css.
The 4 style updates are:
-	I updated the background color of the application’s header to darkred for all pages.
-	I updated the accordion button of the FAQ page. Background color to lightskyblue and border 0.25em.
-	I updated the cards of the Events page: background color deepskyblue, border-width: 0.5em, border-color: lightsteelblue.
-	I updated the tables of the Product List, ContactDb and ProductDb: background-color: deepskyblue, border-width: 0.5em, border-color: lightsteelblue. 

Note: I didn’t quite understand how I should present these changes in GitHub, so I made a copy of the Week 14 folder, updated the custom.css, and posted in GitHub. 
The folder is called “Week 14 – Copy” and it is a different folder than the Week 16 folder that contains the new code (that I couldn’t fully debug).
