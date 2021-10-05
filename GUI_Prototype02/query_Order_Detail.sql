CREATE TABLE Order_Detail(
	Order_Detail_ID int IDENTITY (1,1) PRIMARY KEY,
	Order_ID int FOREIGN KEY REFERENCES ORDERS(Order_ID),
	Stock_ID int FOREIGN KEY REFERENCES STOCK(Stock_ID),
	Qty_Ordered smallint,
	Price_per_KG smallmoney,
	Price_per_Unit smallmoney
);