CREATE TABLE ORDERS(
	Order_ID int IDENTITY(1,1) PRIMARY KEY,
	User_ID int not null, 
	Date_Ordered date,
	Date_Received date,
);