CREATE TABLE Employee (
	ID int not null,
	DepartmentID int not null,
	ChiefId int null,
	Name varchar(255) not null,
	Salary decimal not null,
	PRIMARY KEY (ID),
	CONSTRAINT fk_Employee_Employee FOREIGN KEY (ChiefId) REFEReNCES Employee (ID),
	CONSTRAINT fk_Employee_Department FOREIGN KEY (DepartmentID) REFEReNCES Department (ID),
)
CREATE TABLE Department (
	ID int not null,
	Name varchar(255) not null,
	PRIMARY KEY (ID)
)

/*1.task */
SELECT Department.Name, Employee.Name,Employee.ChiefId,Employee.Salary FROM Employee
JOIN Department ON Employee.DepartmentID = Department.ID
AND Employee.Salary = (Select MAX(Employee.Salary) FROM Employee
WHERE Employee.DepartmentID = Department.ID)
GROUP BY Department.Name,Employee.Name,Employee.ChiefId,Employee.Salary

/*2.task*/
SELECT Department.Name,Employee.Name FRom Employee
JOIN Department ON Employee.DepartmentID = Department.ID
WHERE Employee.ChiefId IS NULL

/* 3.task */
SELECT Department.Name, STR(AVG(Employee.Salary),10,2) as ExpensePerPerson FROM Employee
JOIN Department ON Employee.DepartmentID = Department.ID
GROUP BY Department.Name
Order BY AVG(Employee.Salary) ASC

/* 4.task */
WITH Hierachy AS 
(
    SELECT ID, DepartmentID, Name, ChiefId, 1 AS Level
    FROM Employee 
	WHERE ChiefId IS NULL

    UNION ALL

    SELECT e.ID,e.DepartmentID,e.Name,e.ChiefId, Level + 1 
    FROM Employee e 
	INNER JOIN Hierachy d ON e.ChiefId = d.ID
)
Select * from Hierachy
ORDER BY DepartmentID

