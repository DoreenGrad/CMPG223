﻿CREATE TABLE SALE_DETAIL(
	Sale_Detail_ID int IDENTITY(1,1) PRIMARY KEY,
	Sale_ID int not null, 
	Stock_ID int not null,
	Sales_Price_per_Unit smallmoney,
	Qty_Sold smallint
	FOREIGN KEY(Sale_ID) REFERENCES SALE(Sale_ID),
	FOREIGN KEY(Stock_ID) REFERENCES STOCK(Stock_ID)
);