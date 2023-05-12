create table Sales.Promotion(
SalesID int,
ProductID int,
Quantity int,
price money not null,
productName varChar(20) unique,
OrderDate DateTime not null,
ShippingPlace varchar(20) not null,
primary key(SalesID),
check(Quantity>=1 and price>=1000)
);

INSERT INTO Sales.Promotion (SalesID, ProductID, Quantity, price, productName, OrderDate, ShippingPlace)
VALUES
  (1, 1001, 5, 1500.00, 'Product A', '2023-05-01 10:00:00', 'Place X'),
  (2, 1002, 3, 1200.00, 'Product B', '2023-05-02 14:30:00', 'Place Y'),
  (3, 1003, 2, 2000.00, 'Product C', '2023-05-03 09:15:00', 'Place Z'),
  (4, 1004, 1, 1800.00, 'Product D', '2023-05-04 16:45:00', 'Place X'),
  (5, 1005, 4, 2500.00, 'Product E', '2023-05-05 11:30:00', 'Place Y'),
  (6, 1006, 3, 1300.00, 'Product F', '2023-05-06 13:00:00', 'Place Z'),
  (7, 1007, 2, 1100.00, 'Product G', '2023-05-07 15:45:00', 'Place X'),
  (8, 1008, 1, 1900.00, 'Product H', '2023-05-08 10:30:00', 'Place Y'),
  (9, 1009, 4, 2200.00, 'Product I', '2023-05-09 12:15:00', 'Place Z'),
  (10, 1010, 2, 1700.00, 'Product J', '2023-05-10 14:00:00', 'Place X');


INSERT INTO Sales.Promotion (SalesID, ProductID, Quantity, price, productName, OrderDate, ShippingPlace)
VALUES
(11, 1010, 0, 1700.00, 'Product J', '2023-05-10 14:00:00', 'Place X');


  select * from Sales.Promotion;