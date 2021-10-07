CREATE TABLE ORDERS_DETAIL(
	Order_Detail_ID int IDENTITY(1,1) PRIMARY KEY,
	Order_ID int not null,
	Stock_ID int not null,
	Qty_Ordered smallint,
	Price_per_KG smallmoney,
	Price_per_Unit smallmoney,
);