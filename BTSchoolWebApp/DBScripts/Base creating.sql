IF DB_ID('BTSchoolData') IS NOT NULL
    DROP DATABASE BTSchoolData;
GO

--IF EXISTS(SELECT 1 FROM sys.tables WHERE object_id = OBJECT_ID('BTSchoolData'))
--    DROP DATABASE BTSchoolData;
--GO

CREATE DATABASE BTSchoolData;
GO

USE BTSchoolData;

-- Table Accounts
DROP TABLE IF EXISTS Accounts;

CREATE TABLE Accounts
(
	Id					   BIGINT IDENTITY(1, 1),
	Role                   TINYINT                 DEFAULT NULL,
	FirstName			   NVARCHAR(50)			   NOT NULL,
	LastName			   NVARCHAR(50)			   NOT NULL,
	Email				   NVARCHAR(80)			   NOT NULL,
	Password			   NVARCHAR(50)			   NOT NULL,
	Birthday			   DATE,
    PhoneNumber			   NVARCHAR(20),
	IsActive               BIT                     DEFAULT 1,

	CONSTRAINT    PK_Account           PRIMARY KEY (Id),
	CONSTRAINT    UQ_EmailAccounts     UNIQUE (Email),
);

-- Table Accountants
DROP TABLE IF EXISTS Accountants;

CREATE TABLE Accountants (
    Id           BIGINT IDENTITY(1, 1)    NOT NULL,
    AccountId    BIGINT                   NOT NULL,

    CONSTRAINT    PK_Accountant            PRIMARY KEY (Id),
    CONSTRAINT    FK_AccountAccountants    FOREIGN KEY (AccountId)    REFERENCES Accounts (Id),
    CONSTRAINT    UQ_AccountAccountants    UNIQUE (AccountId)
);

DROP TABLE IF EXISTS Customers;

CREATE TABLE Customers(
    Id                    BIGINT IDENTITY(1, 1)    NOT NULL,
	AccountId             BIGINT                   NOT NULL,

	CONSTRAINT    PK_Customers            PRIMARY KEY (Id),
    CONSTRAINT    FK_AccountCustomers     FOREIGN KEY (AccountId)    REFERENCES Accounts (Id),
    CONSTRAINT    UQ_AccountCustomers     UNIQUE (AccountId)
   );  

-- Table Products
DROP TABLE IF EXISTS Products;

CREATE TABLE Products(
	Id                BIGINT IDENTITY(1, 1)    NOT NULL,
	ProductType       NVARCHAR(30)             NULL,
	Brend             NVARCHAR(30)             NULL,
	Name              NVARCHAR(100)            NOT NULL,
	Price             SMALLMONEY               NOT NULL,
	Description       NVARCHAR(30)             NULL,

    CONSTRAINT PK_Product_Id                PRIMARY KEY (Id),
	CONSTRAINT UQ_NameProduct               UNIQUE (Name)
	);

-- Table Sales
DROP TABLE IF EXISTS Sales;

CREATE TABLE Sales(
    Id                BIGINT IDENTITY(1, 1)    NOT NULL,
	Data			  SMALLDATETIME            NOT NULL,
	CustomerId        BIGINT                   NOT NULL,
	ProductId         BIGINT                   NOT NULL

	CONSTRAINT PK_Sale_Id                PRIMARY KEY (Id),
	CONSTRAINT FK_Sale_Customer_Id       FOREIGN KEY (CustomerId)           REFERENCES Customers (Id),
	CONSTRAINT FK_Sale_Product_Id        FOREIGN KEY (ProductId)            REFERENCES Products (Id)
	);

-- Table Masters
DROP TABLE IF EXISTS Trainers;

CREATE TABLE Trainers
(
	Id                    BIGINT IDENTITY(1, 1),
	AccountId             BIGINT,

	CONSTRAINT    PK_Trainers            PRIMARY KEY (Id),
    CONSTRAINT    FK_AccountTrainers     FOREIGN KEY (AccountId)    REFERENCES Accounts (Id),
    CONSTRAINT    UQ_AccountTrainers     UNIQUE (AccountId)
);

-- Table Students
DROP TABLE IF EXISTS Students;

CREATE TABLE Students (
    Id           BIGINT IDENTITY(1, 1)    NOT NULL,
    AccountId    BIGINT                   NOT NULL,

    CONSTRAINT    PK_Student            PRIMARY KEY (Id),
    CONSTRAINT    FK_AccountStudents    FOREIGN KEY (AccountId)    REFERENCES Accounts (Id),
    CONSTRAINT    UQ_AccountStudents    UNIQUE (AccountId)
);

-- Table Services
DROP TABLE IF EXISTS Services;

CREATE TABLE Services
(
    Id                     BIGINT IDENTITY,
	Name                   NVARCHAR(100),
	ServiceLevel		   TINYINT,
    Time				   TIME,
	Price				   SMALLMONEY

	CONSTRAINT    PK_Service            PRIMARY KEY (Id),
);

-- Table Courses
DROP TABLE IF EXISTS Courses;

CREATE TABLE Courses (
    ID          BIGINT IDENTITY(1, 1)    NOT NULL,
    IsActive    BIT                      DEFAULT 1,
	ProductId   BIGINT                   NOT NULL

    CONSTRAINT    PK_Course                 PRIMARY KEY (ID),
    CONSTRAINT    FK_Product_Course_Id           FOREIGN KEY (ProductId)          REFERENCES Products (Id)
);

-- Table TrainersOfCourses
DROP TABLE IF EXISTS TrainersOfCourses;

CREATE TABLE TrainersOfCourses (
    ID           BIGINT IDENTITY(1, 1)    NOT NULL,
    TrainerID    BIGINT                   NOT NULL,
    CourseID     BIGINT                   NOT NULL,

    CONSTRAINT    PK_TrainerOfCourse     PRIMARY KEY (ID),
    CONSTRAINT    FK_TrainerOfCourses    FOREIGN KEY (TrainerID)           REFERENCES Trainers (ID),
    CONSTRAINT    FK_CourseOfTrainers    FOREIGN KEY (CourseID)            REFERENCES Courses (ID),
    CONSTRAINT    UQ_TrainerAndCourse    UNIQUE (TrainerID, CourseID)
);

-- Table ServicesOfCourses
DROP TABLE IF EXISTS ServicesOfCourses;

CREATE TABLE ServicesOfCourses (
    Id           BIGINT IDENTITY(1, 1)    NOT NULL,
    CourseId     BIGINT                   NOT NULL,
    ServiceId    BIGINT                   NOT NULL,

    CONSTRAINT    PK_CoursesOfServices    PRIMARY KEY (Id),
    CONSTRAINT    FK_CourseOfServices     FOREIGN KEY (CourseId)            REFERENCES Courses (Id),
    CONSTRAINT    FK_ServiceOfCourses     FOREIGN KEY (ServiceId)           REFERENCES Services (Id),
    CONSTRAINT    UQ_MasterAndService     UNIQUE (CourseId, ServiceId)
);

-- Table Groups
DROP TABLE IF EXISTS Groups;

CREATE TABLE Groups (
    ID            BIGINT IDENTITY(1, 1)    NOT NULL,
    CourseID      BIGINT                   NOT NULL,
    Name          VARCHAR(100)             NOT NULL,
    StartDate     DATE                     NOT NULL,
    FinishDate    DATE                     NOT NULL,

    CONSTRAINT    PK_Group           PRIMARY KEY (ID),
    CONSTRAINT    FK_CourseGroups    FOREIGN KEY (CourseID)    REFERENCES Courses (ID),
    CONSTRAINT    UQ_NameGroups      UNIQUE (Name)
);

-- Table StudentsOfStudentGroups
DROP TABLE IF EXISTS StudentsOfGroups;

CREATE TABLE StudentsOfGroups (
    ID                BIGINT IDENTITY(1, 1)    NOT NULL,
    GroupID           BIGINT                   NOT NULL,
    StudentID         BIGINT                   NOT NULL,

    CONSTRAINT    PK_StudentOfGroup     PRIMARY KEY (ID),
    CONSTRAINT    FK_GroupOfStudents    FOREIGN KEY (GroupID)            REFERENCES Groups (ID),
    CONSTRAINT    FK_StudentOfGroups    FOREIGN KEY (StudentID)          REFERENCES Students (ID),
    CONSTRAINT    UQ_StudentAndGroup    UNIQUE (StudentID, GroupID)
);

-- Table MentorsOfCourses
DROP TABLE IF EXISTS TrainersOfCourses;

CREATE TABLE TrainersOfCourses (
    ID           BIGINT IDENTITY(1, 1)    NOT NULL,
    TrainerID    BIGINT                   NOT NULL,
    CourseID     BIGINT                   NOT NULL,

    CONSTRAINT    PK_TrainerOfCourse     PRIMARY KEY (ID),
    CONSTRAINT    FK_TrainerOfCourses    FOREIGN KEY (TrainerID)           REFERENCES Trainers (ID),
    CONSTRAINT    FK_CourseOfTrainers    FOREIGN KEY (CourseID)            REFERENCES Courses (ID),
    CONSTRAINT    UQ_TrainerAndCourse    UNIQUE (TrainerID, CourseID)
);

-- Table MentorsOfStudentGroups
DROP TABLE IF EXISTS TrainersOfGroups;

CREATE TABLE TrainersOfGroups (
    ID                 BIGINT IDENTITY(1, 1)    NOT NULL,
    TrainerID          BIGINT                   NOT NULL,
    GroupID            BIGINT                   NOT NULL,

    CONSTRAINT    PK_TrainerOfGroup           PRIMARY KEY (ID),
    CONSTRAINT    FK_TrainerOfGroups          FOREIGN KEY (TrainerID)                REFERENCES Trainers (ID),
    CONSTRAINT    FK_StudentGroupOfMentors    FOREIGN KEY (GroupID)                  REFERENCES Groups (ID),
    CONSTRAINT    UQ_TrainerAndGroup          UNIQUE (TrainerID, GroupID)
);

-- Table Themes
DROP TABLE IF EXISTS Themes;

CREATE TABLE Themes (
    ID      BIGINT IDENTITY(1, 1)    NOT NULL,
    Name    VARCHAR(100)             NOT NULL,

    CONSTRAINT    PK_Theme         PRIMARY KEY (ID),
    CONSTRAINT    UQ_NameThemes    UNIQUE (Name)
);

-- Table Lessons
DROP TABLE IF EXISTS Lessons;

CREATE TABLE Lessons (
    ID                BIGINT IDENTITY(1, 1)    NOT NULL,
    TrainerID         BIGINT                   NOT NULL,
    GroupID           BIGINT                   NOT NULL,
    ThemeID           BIGINT                   NOT NULL,
    LessonDate        DATETIME                 NOT NULL,     -- Use UTC time,

    CONSTRAINT    PK_Lesson                 PRIMARY KEY (ID),
    CONSTRAINT    FK_TrainerLessons         FOREIGN KEY (TrainerID)         REFERENCES Trainers (ID),
    CONSTRAINT    FK_GroupLessons           FOREIGN KEY (GroupID)           REFERENCES Groups (ID),
    CONSTRAINT    FK_ThemeLessons           FOREIGN KEY (ThemeID)           REFERENCES Themes (ID)
);