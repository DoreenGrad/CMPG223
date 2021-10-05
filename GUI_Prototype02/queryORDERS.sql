CREATE TABLE ORDERS(
	Order_ID int IDENTITY(1,1) PRIMARY KEY,
	User_ID int FOREIGN KEY REFERENCES USERS(User_ID),
	Date_Ordered date,
	Date_Received date
);