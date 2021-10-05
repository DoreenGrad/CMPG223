CREATE TABLE ORDERS(
	OrderID int IDENTITY(1,1) PRIMARY KEY,
	UserID int FOREIGN KEY REFERENCES USERS(UserID),
	Date_Ordered date,
	Date_Received date
);