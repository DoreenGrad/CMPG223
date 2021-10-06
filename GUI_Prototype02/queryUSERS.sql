create table USERS(
	User_ID int IDENTITY(1,1) PRIMARY KEY,
	Username varchar(30),
	Password varchar(30),
	Description varchar(30)
);