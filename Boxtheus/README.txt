Group: Theta 
Group Members:	Sarala Ponnuraj
				Dheeru Harshavardhan Rao Erabelly
				Eshika Lad
Subject: - Web Application Security
Instructor: - Mr. Andrew Steele
===========================================================================================================================================================================

Discussion

Date: 2024-02-15
1434

Our first meeting was about research on the Box and various products surrounding it, we discussed and decided on a name
'Boxetheus' discussed further steps and subsequent development efforts for our web application in dividing the task and 
meetings, timings going forward. Simultaneously created groups for easy communication.

Research :
We visited happybox website to get more idea about entities.

Errors:
We faced issues while creating class names, model name.
We were facing issue for adding background images.
Database connection error.
Runtime error while fetching the database.
While updating the database their was an error.
Adding search by particular column we faced issue in updating the index view.

Solution:
We managed to review our code and name the class names, model names.
We sorted it out by using resource from online.
Made sure the check Connection String is correct,and restarted the visual studio
Identifying and resolving database fetching errors in Visual Studio 2022 involves ensuring connectivity and schema integrity, managing null values, implementing robust exception handling, verifying permissions, optimizing queries, monitoring server performance, updating dependencies, and utilizing debugging tools for effective troubleshooting.
Encountering errors while updating the database or integrating search functionality into a specific column within the index view in Visual Studio can be resolved by carefully reviewing database update procedures and ensuring the correct implementation of search features, promptly addressing any issues that arise.

Migration Time: 
Initial Migration: 20240219040441
New column Migration: 20240221025510

Time taken:
5 hours 30 mins

Branch History:
All worked on "Sarala's Laptop" as we worked together on teams and at college and pushed it from the same laptop.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Date: 2024-03-04
1042
Done by : Dheeru

Web Application implementation

Task 1:

Created the project with the name Boxetheus by using the ASP.NET Core web application with the model-view-controller architecture
we checked the application's functionality, it was running successfully.
We discussed about entities brand, order date, design, shape, size, quantity, price and category for various products

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Task 2:

We created the "BoxWorldController.cs" controller folder to Perform the function and call it using the URL routing logic format
identified in the "program.cs" file.
Added the image to the homepage.
We added a view folder and modified the contents in the paragraph of index file with hello from our view.
We changed the title of the page, footer and the menu link as per our requirement in the layout file.

---------------------------------------------------------------------------------------------------------ta----------------------------------------------------------------
Task 3:

We updated the BoxView class and added the entites in the BoxView class.
Added a Scaffolder Boxetheuscontext and initiated initial the migration.
Then we tested the app by clicking on the Boxetheus app link.
We examined the generated database context class and registration in BoxetheusContext class.
Checked for dependency injection in progrom class.
We examined the generated database connection string in appsettings class. 
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Task 4:
Done by : Dheeru
Working with the database
Seeded the database with the data of boxetheus entities.
Added the seed initializer to the program class.
Executed the code to check when the seeded data is stored in the database and able to view it on  the web page.


===========================================================================================================================================================================

Date: 2024-03-04
0207

Task 5:
Edited the displayname of orderdate for better presentation in BoxViews class.
Examined whether when we hover over edit option the link should be displayed in the footer.
Examined the HTTP POST edit method to see whether Bind attritube is added or not.
Examined the view source code of the edit option.
Validated the text box by entering incorrect format to throw error message.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Task 6:
Done by Sarala:

New action methods with search capabilities have been added to the controller that displays data. Based on the given search
parameters, data extraction and filtering were improved.The relevant views were modified to incorporate a search form and
efficiently display the search results.created and put into use an HTML search form that collects user input and uses it for 
searches inside the display.

Introduced an action method in the controller to manage form submissions. took the search query out of the form and used it to 
filter the data.enhanced data access logic to support search capabilities by implementing search logic. Based on the supplied 
search query, data was filtered, and the returning results were carefully examined.
Verified the search results that were shown and adjusted the view layout to properly display the results.Utilized Razor syntax 
to conditionally render the search results within the view.Rigorously tested the web application to ensure the search 
functionality operates as expected.


===========================================================================================================================================================================
Done by Eshika
Date: 2024-03-05
1010

Task 7:


Perform SQL operations by analyzing the database design and adding the ViewData class into the model. Improve basic functionality by introducing controller methods and views, and make any changes as needed. Increase security by adding the HttpPost property, which specifies that the method is only enabled for POST requests.
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Done by Sarala:
Task 8:
 Include the @model directive at the top of the view to signal that it expects the model to be used in the view templates. Add a search functionality to the index action method, letting users search for objects by name using a LINQ query. Increase the search capacity by including a genre search tool in the Index view.

Add the new field in the core. Mitigate the new field in the database
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Done by Sarala:
Task 9:
Opened the ASP.NET Core MVC app in Visual Studio: Navigated to the Model Class: Identify and open the model class that corresponds to the data entity requiring validation.
Apply Data Annotations for Validation Within the model class, use data annotations (attributes) to define validation rules for the properties. For instance, use [Required] for mandatory fields, [StringLength] for maximum length, or custom annotations for specific requirements.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Observation:

ASP.NET Core allows developers to create custom validation logic, supports both client-side and server-side validation, and provides users with instant feedback. This gives users quick feedback on their input, which improves the user experience. In accordance with user choices, programs can show error messages in many languages thanks to the system's support for error message localization. This improves user experience and enables more seamless integration with other systems.
Quick Responses to Users: By adding validation, the user experience is improved as users receive quick feedback on their input.
I could become more knowledgeable about server-side and client-side validation. Both client-side and server-side validation are supported by ASP.NET Core. Client-side validation is mainly managed via data annotations, whereas server-side validation makes sure that the data is intact on the server.
Custom Validation Logic: In addition to normal annotations, custom validation logic enables developers to apply certain business rules.
Localization of Error Messages: ASP.NET Core Boxetheus allows apps to display error messages in many languages according to user preferences.

Task 10:
2024-02-22
1140

Updated the images in home page, privacy page, and updated the README file.

Task 11:
2024-02-22
1313

Created a new layout product to navigate the table values to new product named Boxetheus Product.
Creeated a new product value.
Edited existing product value and examined whether the values are updated in the web page.
Deleted the existing product and examined whether the product is deleted or not.


----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2024-03-07
1101
Create a login.aspx page and switch it to HTML view
Create register login.

2024-03-12 
21:30
Made changes in program.cs file and appsettings.Production.json file

2024-03-13
17:00
Deployed successfully in Azure