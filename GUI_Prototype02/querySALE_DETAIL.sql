CREATE TABLE SALE_DETAIL(
	Sale_Detail_ID int IDENTITY(1,1) PRIMARY KEY,
	Sale_ID int not null, 
	Stock_Key varchar(10),
	Sales_Price_per_Unit smallmoney,
	Qty_Sold smallint
);