--- Object: Database 'LibraryManagementBD' -------------

GO

USE master;

GO

If DB_ID ('LibraryManagementBD') IS NOT NULL DROP DATABASE LibraryManagementBD;

GO

CREATE DATABASE LibraryManagementBD;

GO

USE LibraryManagementBD;

GO

CREATE TABLE Login (    ID			INT				IDENTITY		PRIMARY KEY,
						UserName	VARCHAR(20)		NOT NULL,
						Password	VARCHAR(20));

Go
INSERT INTO Login VALUES ( 'User', 'user123');

GO



Go

CREATE TABLE Faculty (    FacultyID			INT				IDENTITY		PRIMARY KEY,
						  FacultyName		VARCHAR(20)		NOT NULL);
Go

INSERT INTO Faculty		 VALUES		('Arts'), ('Science'), ('Business Studies');

Go

CREATE TABLE Books (	BookID				INT				IDENTITY		PRIMARY KEY,
						BookTitle			VARCHAR(100),
						AuthorName			VARCHAR(50)		NOT NULL,
						ISBN				VARCHAR(20),
						NoOfPage			INT,
						FacultyID			INT				REFERENCES		Faculty (FacultyID),
						ImageFile			VARCHAR(200));



GO

CREATE TABLE Students (	 StudentID			INT				IDENTITY		PRIMARY KEY,
						 StudentName		VARCHAR (30)	NOT NULL,
						 Gender				VARCHAR(10)		NOT NULL,
						 Address			VARCHAR (50)	NOT NULL,
						 ContactNo			VARCHAR(15)		NOT NULL,
						 FacultyID			INT				REFERENCES		Faculty (FacultyID));


GO
				
CREATE TABLE IssueingBookDetails (
						SerialID			INT				IDENTITY		PRIMARY KEY,
						StudentID			INT				REFERENCES		Students (StudentID),
						BookID				INT				REFERENCES		Books (BookID),
						DateofIssue			DATE,
						DateofReceived 		DATE,  
						ActualReturnDate	VARCHAR(30));



GO


INSERT INTO Books	 VALUES			('The Bluest Eye', 'G.B.Shaw', 'O-671-854216', 520, 1, '~/Image/The Bluest Eye.jpg'),	 
									('Color Farm', 'Toni Morrison', 'O-14-0505867',150, 1, '~/Image/Color Farm.jpg' ),
									('Theretical concept in physics', 'Jeo Pullizzi', '1255-36598-89', 260, 2, '~/Image/Theretical concept in physics.jpg' ), 
									('General Chemistry', 'Ray H. Garrison', '123-35353-62', 190, 2, '~/Image/General Chemistry.jpg' ), 
									('Financial Management', 'F W Taylor', 'O-12535-55', 340, 3, '~/Image/Financial Management.jpg' ),
									('Basic Principal of Marketing', 'Robert S. Witte & John E. Wittte', 'B-3695478', 290, 3, '~/Image/Basic Principal of Marketing.jpg' ),
									('Noukadubi', 'Rabindranath Tagor','122365448', 120, 1,'~/Image/Noukadubi.jpg' ),
									('Pricipal of Account', 'Charles E. Menifield', 'A-2356-9658', 340, 3,'~/Image/Pricipal of Account.jpg' ),
									('You never can tell', 'William Shakespere', '5684-4568-52', 200, 1,'~/Image/You never can tell.jpg' ), 
									('The Economist Guid to Financial Managemant', 'Jonathan Clayden', 'E-12348797', 290, 3,'~/Image/The Economist Guid to Financial Managemant.jpg' ),
									('Staticstics 10th Edition', 'James T. Macclave', 'S-35469-89', 310, 2, '~/Image/Staticstics 10th Edition.jpg' ),
									('Principal of Management', 'F W Taylor', '475-5686-5446', 255, 3, '~/Image/Principal of Management.jpg' ), 
									('Organic Chemistry', 'Michacl Proter', '258-1585-84', 201, 2,'~/Image/Organic Chemistry.jpg' ); 

GO

INSERT INTO Students VALUES			('Sharmin Akter',	 'Female',	'Narayanganj',		'01688-656198', 2),
									('Jewel Rana',		 'Male',	'Puran Dhaka',		'01678-656198',	 1),
									('Israt Jahan',		'Female',	 'Barishal',		'01777-656198',	3),
									('Kawser Ahmed',	 'Male',	'PoltonD haka',		'01778-656198',	 3),
									('Md. Akram Hossain', 'Male',	'Dhandmondi Dhaka', '01668-656198',  1),
									('Ala Uddin',		 'Male',	'Sadorghat Dhaka',  '01878-656198',  1),
									('Rokey Akter',		 'FeMale',  'Meghna Sonarga',   '01818-656198',  2),
									('Robiul Hossain',	 'Male',	 'Gulistan Dhaka',  '01678-656198',	 3),
									('Md. Imarn Hossain', 'Male',	'Sonarga',		    '01678-656198',	  1),
									('Sharmin Rumpa',	 'FeMale',  'Narayanganj',      '01558-656198', 2);
								

GO

INSERT INTO IssueingBookDetails VALUES  (3, 12, '2014-01-10', '2014-01-15', '2014-01-16'),		
										(8, 9, '2014-05-10', '2014-05-20', '2014-05-14'),
										(1, 7, '2014-05-10', '2014-05-25', '2014-05-27'),		
										(7, 12, '2014-07-15', '2014-07-20', '2014-07-20'),		
										(2, 1, '2015-01-10', '2015-01-20', '2015-01-15'),
										(2, 3, '2019-07-10', '2019-07-25', 'Not Back Yet'),	
										(1, 4, '2019-07-20', '2019-07-30', 'Not Back Yet');

Go


CREATE VIEW BookDetails AS
	SELECT BookID, BookTitle, AuthorName, ImageFile, FacultyName, StudentName, Address, ContactNo  
	FROM Books JOIN Faculty ON Books.FacultyID = Faculty.FacultyID
	JOIN Students on Faculty.FacultyID = Students.FacultyID;

Go


SELECT BookID, BookTitle, AuthorName, ImageFile, FacultyName, StudentName, Address, ContactNo  
	FROM Books JOIN Faculty ON Books.FacultyID = Faculty.FacultyID
	JOIN Students on Faculty.FacultyID = Students.FacultyID;

Go
select * from Books;

------------------------- 1252366 - Sharmin Akter ---------------------