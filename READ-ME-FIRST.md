							--------- DEESCRIPTION ----------


I have implemented the task with: .NET8 MVC + Blazor, Entity Framework Core8, SQL Server 2022, Dependency Injection, Repository Pattern.

Used Dependency Injection for acheieving Inversion of Control (principles) between classes and their dependencies which provides the way to seperate the creation of an object from its usage and using dependency injection is powerful for improving the design, testability, flexibility and modularity the application.
Used Repository Pattern because is a powerful design pattern that promotes maintability, testabality and scalability the application by abstracting
data access logic from the rest of the application which provides a layer of abstraction between the business logic and the data source (database).
Used Entity Framework as a ORM framework that simplifies the process of working with relational database by allowing us to work with database objects.
Testing CRUD operation from Views in MVC and Blazor.

	
							 --------- IMPORTANT ----------

Used asynchronous programming logic because allows tasks to run in the background, ensuring that the process is not blocked which means the application remains responsive even when it`s performing heavy tasks. Another reason is performance because avoiding performance bottlenecks and enhancing responsiviness and asynchronous programming which can lead to a more efficient application and the latest one is parallelization 
in which asynchronous programming allow two or more indenpendent taasks to run in parallel, so this can lead to better utilization of system resources and improved performance.


		
							--------- HOW TO RUN ----------
When you open RonwellTask.sln,
1. configure your database at appsettings.json - 
	"DefaultConnection": "Server=YOUR-DATABASE-NAME;Database=UMS-Db;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
2. at package manager console write update-database.
3. RUN.



							--------- NOTE ----------
For this task I have created MVC project and Blazor project. 
In blazor I have demonstrated List of Employee, Create new Employee and delete employee and in MVC project is implemented CRUD operation. 
