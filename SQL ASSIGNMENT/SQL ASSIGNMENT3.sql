
--********************************************Transaction SQL ASSIGNMENTS***************************************************** 
-------------------------------------------------------------------------SQL ASSIGNMENT 3------------------------------ 

--1*
/*1.	Write a T-SQL Program to generate complete payslip of a given employee with respect to the following condition
a)	HRA  as 10% Of sal
b)	DA as  20% of sal
c)	PF as 8% of sal
d)	IT as 5% of sal
e)	Deductions as sum of PF and IT
f)	Gross Salary as sum of SAL,HRA,DA and Deductions
g)	Net salary as  Gross salary- Deduction*/

begin
declare @salary float=33000
declare @HRA float, @DA float, @PF float, @IT float,@Deduction float,@Gross_salary float
declare @Net_salary float,@sum float
set @HRA=@salary*0.1


--set @salary=@salary-@hra
print '*****Salary Slip*****'

print 'HRA is'
print @HRA
set @DA=@salary*0.2
print 'DA is'
print @DA
set @PF=@salary*0.08
print 'PF is'
print @PF
set @IT=@salary*0.05
set @Deduction=@Pf+@IT
set @sum=@salary-(@hra+@Da+@Deduction)
set @Gross_salary=@sum+(@hra+@Da+@Deduction)
print 'Gross Salary is:'
print @Gross_salary
set @Net_salary=@Gross_salary-@Deduction
print 'Net salary is:'
print @Net_salary
end

---------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------
--2.	Write a T-SQL Program to Display complete result of a given student.
      --(Note: Consider 10th standard result sheet and Student table structure as (sno,sname,maths,phy,comp)


begin
declare @Sno int,@Sname varchar(20),@Maths int,@Physics int,@Computer int
declare @Total_Marks int,@Total_Percentage float
declare @Result varchar(20)

set @Sno = 100
set @Sname = 'suhail'
set @Maths = 85
set @Physics = 90
set @Computer = 99
set @Total_Marks = (@Maths+@Physics+@Computer)
set @Total_Percentage = (@Total_Marks*100)/300
print @Total_Percentage

create table Result
(Sno int,Sname varchar(20),Maths int,Physics int,Computer int,Total int,Total_Percentage int)
insert into Result
values(@SNo,@SName,@Maths,@Physics,@Computer,@Total_Marks,@Total_Percentage)
select *from Result
end

drop table Result 

--------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------

--3.Write a T-SQL Program to find the factorial of a given number.

create procedure Factorial @num int
as
begin
declare @fact int=1;

while(@num > 1)
begin
    set @fact = @fact * @num;
    set @num = @num - 1;
end
PRINT @fact
end

exec Factorial @num = 3

----------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------

--4.Create a stored procedure to generate multiplication tables up to a given number. 

create procedure multiplication_Table  @num int
as
begin
declare @i int = 1;
declare @j int = 1;
print '***********Multipliction Table Upto ' +  convert(varchar,@num) + '************'
while (@j <= @num)
begin
while (@i <= 10)
begin
print convert(varchar, @j) + ' x ' + convert(varchar,@i) + '= ' + convert(varchar, @i*@j);
set @i = @i + 1;
end
print '************************************************'
set @i = 1
set @j = @j + 1;
end
end


exec multiplication_Table @num=3

---------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------------------------------------------

--5.	Create a user defined function calculate Bonus for all employees of a  given job using following conditions
--5a.	       For Deptno10 employees 15% of sal as bonus.
--5b.	       For Deptno20 employees  20% of sal as bonus
--5c.	      For Others employees 5%of sal as bonus


--CREATE FUNCTION function_Name(input_arguments) RETURNS output_parameter

create table EMP (Empid int,Empname varchar(20),Salary float,Dept int)

insert into EMP values 
(101,'A',1200,10),
(111,'B',9000,30),
(121,'C',1100,20),
(131,'D',5500,10),
(141,'E',8500,40),
(151,'F',10000,20),
(161,'G',14000,10),
(171,'H',70200,20),
(181,'I',80300,30),
(191,'J',89900,20)

select * from EMP


create or alter function Emp_bonus1 (@deptid int)
returns @EmpBonus table (Empid int,Empname varchar(20),Salary float,bonus float,Dept int)
as begin
if @deptid = 10
begin
insert into @EmpBonus
select Empid, Empname, Salary,Salary/100*15 as Bonus,Dept from EMP where Dept = @deptid
end
else if @deptid = 20
begin
insert into @EmpBonus
select Empid, Empname, Salary,Salary/100*20 as Bonus,Dept from EMP where Dept = @deptid
end
else
begin
insert into @EmpBonus
select Empid, Empname, Salary,Salary/100*5 as Bonus,Dept from EMP where Dept = @deptid
end
return
end

select * from Emp_bonus1(10)
select * from Emp_bonus1(20)
select * from Emp_bonus1(30)
select * from Emp_bonus1(40)


  





  













TEXT DOCUMENT For QUERIES






create database SpecialAssignment
use SpecialAssignment


create table Client(Client_ID int,Cname varchar(40) not null,Address varchar(30),Email varchar(30),Phone int,Business varchar(20))


--modifying  DataType in a column in a table named client  
Alter table Client 
Alter COLUMN Phone bigint




insert into Client values
(1001,'Khyber Group Kashmir','kashmir','Contact@acmeutil.com',9567880032,'Manufacturing'),
(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant'),
(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller'),
(1004,'Lawful Corp','Chennai','justice@lawful.com',9210342219,'Professional')


select * from Client


create table Employee (Empno int primary key,Ename varchar(20) not null,Job varchar(15),Salary float,Deptno int)


insert into Employee values(7001,'Sandeep','Analyst',25000,10),
(7002,'Rajesh','Designer',30000,10),(7003,'Madhav','Developer',40000,20),
(7004,'Manoj','Developer',40000,20),(7005,'Abhay','Designer',35000,10),
(7006,'Uma','Tester',30000,30),(7007,'Gita','Tech.Writer',30000,40),
(7008,'Priya','Tester',35000,30),(7009,'Nutan','Developer',45000,20),
(7010,'Smita','Analyst',20000,10),(7011,'Anand','Project Mgr',65000,10)


select * from Employee
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Department (Deptno int primary key,Dname varchar(15) not null,Loc varchar(20))


insert into Department values
(10,'Design','Pune'),
(20,'Development','Pune'),
(30,'Testing','Mumbai'),
(40,'Document','Mumbai')


select * from Department
----------------------------------------------------------------------------------------------------------------------------------------------------------------
create table Projects (Project_ID int primary key,Deser varchar(30) not null,Start_Date DATE,Planned_End_Date DATE,Actual_End_Date DATE,Budget int,Client_ID int)


insert into Projects values(401,'Inventory','01-Apr-11','01-Oct-11','31-Oct-11',150000,1001),
(402,'Accounting','01-Aug-11','01-Jan-12',null,500000,1002),
(403,'Payroll','01-Oct-11','31-Dec-11',null,75000,1003),
(404,'Contact Mgmt','01-Nov-11','31-Dec-11',null,50000,1004)


select * from Projects
----------------------------------------------------------------------------------------------------------------------------------------------------------------
create table EmpProjectTaskA (Project_ID int,Empno int,Start_Date DATE,End_Date DATE,Task varchar(25) not null,Status varchar(15) not null)


insert into EmpProjectTaskA values(401,7001,'01-Apr-11','20-Apr-11','System Analysis','Completed'),
(401,7002,'21-Apr-11','30-May-11','System Design','Completed'),
(401,7003,'01-Jun-11','15-Jul-11','Coding','Completed'),
(401,7004,'18-Jul-11','01-Sep-11','Coding','Completed'),
(401,7006,'03-Sep-11','15-Sep-11','Testing','Completed'),
(401,7009,'18-Sep-11','05-Oct-11','Code Change','Completed'),
(401,7008,'06-Oct-11','16-Oct-11','Testing','Completed'),
(401,7007,'06-Oct-11','22-Oct-11','Documentation','Completed'),
(401,7011,'22-Oct-11','31-Oct-11','Sign off','Completed'),
(402,7010,'01-Aug-11','20-Aug-11','System Analysis','Completed'),
(402,7002,'22-Aug-11','30-Sep-11','System Design','Completed'),
(402,7004,'01-Oct-11',null,'Coding','In Progress')


select * from EmpProjectTaskA


sp_help EmpProjectTaskA