# FlynnSqlEfPractical

Before you begin, please make sure you install the following on your machine:
-	Visual Studio 2015 Community: https://www.visualstudio.com/downloads/
-	SQL Server 2016 Express: https://www.microsoft.com/en-us/download/details.aspx?id=52679
Other versions of Visual Studio or SQL Server may work, but this exercise has only been tested using these configurations.
Please also ensure you have an SQL Server instance set up on your machine when you install.

Instructions:

1.	Download the attached archive, inside you will find a SQL Server backup .bak file. Restore the database inside (FlynnPracticalTest) on to your SQL Server instance.
2.	Open up Visual Studio, create a new C# console application.
3.	Add an “ADO.NET Entity Data Model” (Entity Framework Model) item to your project, link it up with the database that was restored and generate models for the two tables.
4.	In the Main method of your console application, using the DbContext created with your Entity Framework model, do the following joins on the two entities in the DbContext using LINQ and write the results, including all columns of both tables, to the console output:
	a.	Inner Join
	b.	Left Join
	c.	Right Join
	d.	Outer Join
5.	Save your project, create a git repository on github.com, and upload your project to that repository, share the repository with alan.zych@flynncompanies.com. 
6.	The timestamp on your last commit to the repository will be used to judge your completion time.
