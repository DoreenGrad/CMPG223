CREATE TABLE SALE_DETAIL(
	Sale_Detail int IDENTITY (1,1) PRIMARY KEY,
	Sale_ID int FOREIGN KEY REFERENCES SALE(Sale_ID), 
	Stock_ID int FOREIGN KEY REFERENCES STOCK(Stock_ID),
	Sales_Price_per_Unit smallmoney,
	Qty_Sold smallint
);