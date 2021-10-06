CREATE TABLE STOCK(
	Stock_ID int IDENTITY(1,1) PRIMARY KEY,
	Stock_Key varchar(10),
	Stock_Description varchar(30),
	Weight_per_Unit float,
	Qty_on_Hand smallint
);