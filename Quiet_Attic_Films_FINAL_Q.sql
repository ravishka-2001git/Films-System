CREATE DATABASE Quiet_Attic_Films_FINAL ;
CREATE TABLE Sing_Up(
Fast_Name Varchar (50) not null,
last_Name varchar (50) not null,
UserName varchar (50) not null,
Email varchar (100),
Password_ varchar (50) not null,
Confirm_Password varchar (50) not null
);

CREATE TABLE Admin_Login(
Admin_Name Varchar (50) not null,
Admin_UserName Varchar (50) not null,
Admin_Password Varchar (50) not null,
Admin_Position varchar (50) not null,
);

SELECT * FROM Sing_Up;