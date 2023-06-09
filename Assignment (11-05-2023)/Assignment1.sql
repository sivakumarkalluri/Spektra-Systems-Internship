
Create Table Production.Quantity (
	ProductID INT ,
	availableQuantity INT Not NULL,
	unitPrice Money,
	TotalPrice Money,
	Primary Key(ProductID),
);


Create Table Production.Sales(
	ProductID INT ,
	ProductName Varchar(30) Not NULL,
	Quantity INT Not NULL,
	unitPrice Money,
	TotalPrice Money,
	DateOfSales DateTime,
	Discount int ,
	Primary Key(ProductID),
	Foreign Key(ProductID) references Production.Quantity(ProductID)
);

	
Insert Into Production.Quantity values 
   (101,10,250.00,3000.00),(102,15,300.00,2000.00),
   (103,18,150.00,2500.00),(104,19,450.00,4000.00),
   (105,22,302.00,3838.00),(106,32,838.00,3838.00),
   (107,42,848.00,4848.00),(108,83,472.00,9482.00),
   (109,21,949.00,8574.00),(110,22,484.00,9273.00);


  
Insert Into Production.Sales (productID,productName,Quantity,unitPrice,TotalPrice,DateOfSales,Discount) values
	(101,'Adjustable Race',3,250.00,750.00,'2011-02-05 00:00:00.000',20),
	(102,'All-Purpose Bike Stand',5,300.00,1500.00,'2012-03-05 00:00:00.000',15),
	(103,'Blade',2,150.00,300.00,'2011-08-05 00:00:00.000',30),
	(104,'Cable Lock',6,450.00,2700,'2013-09-05 00:00:00.000',23),
	(105,'Chainring Bolts',2,302.00,604.00,'2011-01-02 00:00:00.000',25),
	(106,'Head Tube',5,838.00,4190.00,'2011-01-02 00:00:00.000',10),
	(107,'Headlights - Dual-Beam',10,848.00,8480.00,'2010-01-02 00:00:00.000',13),
	(108,'Internal Lock Washer 1',7,472.00,3304.00,'2013-05-02 00:00:00.000',15),
	(109,'LL Road Tire',4,949.00,3796.00,'2013-05-02 00:00:00.000',10),
	(110,'ML Mountain Tire',6,949.00,5694.00,'2013-05-02 00:00:00.000',20);

	
select * from Production.Sales where Quantity=(Select max(Quantity) from Production.Sales);






	
	
	
	
	
	'ML Mountain Tire'
	






Adjustable Race
All-Purpose Bike Stand
AWC Logo Cap
BB Ball Bearing
Bearing Ball
Bike Wash - Dissolver
Blade
Cable Lock
Chain
Chain Stays
Chainring
Chainring Bolts
Chainring Nut
Classic Vest, L
Classic Vest, M
Classic Vest, S
Cone-Shaped Race
Crown Race
Cup-Shaped Race
Decal 1
Decal 2
Down Tube
External Lock Washer 1
External Lock Washer 2
External Lock Washer 3
External Lock Washer 4
External Lock Washer 5
External Lock Washer 6
External Lock Washer 7
External Lock Washer 8
External Lock Washer 9
Fender Set - Mountain
Flat Washer 1
Flat Washer 2
Flat Washer 3
Flat Washer 4
Flat Washer 5
Flat Washer 6
Flat Washer 7
Flat Washer 8
Flat Washer 9
Fork Crown
Fork End
Freewheel
Front Brakes
Front Derailleur
Front Derailleur Cage
Front Derailleur Linkage
Full-Finger Gloves, L
Full-Finger Gloves, M
Full-Finger Gloves, S
Guide Pulley
Half-Finger Gloves, L
Half-Finger Gloves, M
Half-Finger Gloves, S
Handlebar Tube
Head Tube
Headlights - Dual-Beam
Headlights - Weatherproof
Headset Ball Bearings
Hex Nut 1
Hex Nut 10
Hex Nut 11
Hex Nut 12
Hex Nut 13
Hex Nut 14
Hex Nut 15
Hex Nut 16
Hex Nut 17
Hex Nut 18
Hex Nut 19
Hex Nut 2
Hex Nut 20
Hex Nut 21
Hex Nut 22
Hex Nut 23
Hex Nut 3
Hex Nut 4
Hex Nut 5
Hex Nut 6
Hex Nut 7
Hex Nut 8
Hex Nut 9
Hitch Rack - 4-Bike
HL Bottom Bracket
HL Crankarm
HL Crankset
HL Fork
HL Grip Tape
HL Headset
HL Hub
HL Mountain Frame - Black, 38
HL Mountain Frame - Black, 42
HL Mountain Frame - Black, 44
HL Mountain Frame - Black, 46
HL Mountain Frame - Black, 48
HL Mountain Frame - Silver, 38
HL Mountain Frame - Silver, 42
HL Mountain Frame - Silver, 44
HL Mountain Frame - Silver, 46
HL Mountain Frame - Silver, 48
HL Mountain Front Wheel
HL Mountain Handlebars
HL Mountain Pedal
HL Mountain Rear Wheel
HL Mountain Rim
HL Mountain Seat Assembly
HL Mountain Seat/Saddle
HL Mountain Tire
HL Nipple
HL Road Frame - Black, 44
HL Road Frame - Black, 48
HL Road Frame - Black, 52
HL Road Frame - Black, 58
HL Road Frame - Black, 62
HL Road Frame - Red, 44
HL Road Frame - Red, 48
HL Road Frame - Red, 52
HL Road Frame - Red, 56
HL Road Frame - Red, 58
HL Road Frame - Red, 62
HL Road Front Wheel
HL Road Handlebars
HL Road Pedal
HL Road Rear Wheel
HL Road Rim
HL Road Seat Assembly
HL Road Seat/Saddle
HL Road Tire
HL Shell
HL Spindle/Axle
HL Touring Frame - Blue, 46
HL Touring Frame - Blue, 50
HL Touring Frame - Blue, 54
HL Touring Frame - Blue, 60
HL Touring Frame - Yellow, 46
HL Touring Frame - Yellow, 50
HL Touring Frame - Yellow, 54
HL Touring Frame - Yellow, 60
HL Touring Handlebars
HL Touring Seat Assembly
HL Touring Seat/Saddle
Hydration Pack - 70 oz.
Internal Lock Washer 1
Internal Lock Washer 10
Internal Lock Washer 2
Internal Lock Washer 3
Internal Lock Washer 4
Internal Lock Washer 5
Internal Lock Washer 6
Internal Lock Washer 7
Internal Lock Washer 8
Internal Lock Washer 9
Keyed Washer
LL Bottom Bracket
LL Crankarm
LL Crankset
LL Fork
LL Grip Tape
LL Headset
LL Hub
LL Mountain Frame - Black, 40
LL Mountain Frame - Black, 42
LL Mountain Frame - Black, 44
LL Mountain Frame - Black, 48
LL Mountain Frame - Black, 52
LL Mountain Frame - Silver, 40
LL Mountain Frame - Silver, 42
LL Mountain Frame - Silver, 44
LL Mountain Frame - Silver, 48
LL Mountain Frame - Silver, 52
LL Mountain Front Wheel
LL Mountain Handlebars
LL Mountain Pedal
LL Mountain Rear Wheel
LL Mountain Rim
LL Mountain Seat Assembly
LL Mountain Seat/Saddle
LL Mountain Tire
LL Nipple
LL Road Frame - Black, 44
LL Road Frame - Black, 48
LL Road Frame - Black, 52
LL Road Frame - Black, 58
LL Road Frame - Black, 60
LL Road Frame - Black, 62
LL Road Frame - Red, 44
LL Road Frame - Red, 48
LL Road Frame - Red, 52
LL Road Frame - Red, 58
LL Road Frame - Red, 60
LL Road Frame - Red, 62
LL Road Front Wheel
LL Road Handlebars
LL Road Pedal
LL Road Rear Wheel
LL Road Rim
LL Road Seat Assembly
LL Road Seat/Saddle
LL Road Tire
LL Shell
LL Spindle/Axle
LL Touring Frame - Blue, 44
LL Touring Frame - Blue, 50
LL Touring Frame - Blue, 54
LL Touring Frame - Blue, 58
LL Touring Frame - Blue, 62
LL Touring Frame - Yellow, 44
LL Touring Frame - Yellow, 50
LL Touring Frame - Yellow, 54
LL Touring Frame - Yellow, 58
LL Touring Frame - Yellow, 62
LL Touring Handlebars
LL Touring Seat Assembly
LL Touring Seat/Saddle
Lock Nut 1
Lock Nut 10
Lock Nut 11
Lock Nut 12
Lock Nut 13
Lock Nut 14
Lock Nut 15
Lock Nut 16
Lock Nut 17
Lock Nut 18
Lock Nut 19
Lock Nut 2
Lock Nut 20
Lock Nut 21
Lock Nut 22
Lock Nut 23
Lock Nut 3
Lock Nut 4
Lock Nut 5
Lock Nut 6
Lock Nut 7
Lock Nut 8
Lock Nut 9
Lock Ring
Lock Washer 1
Lock Washer 10
Lock Washer 11
Lock Washer 12
Lock Washer 13
Lock Washer 2
Lock Washer 3
Lock Washer 4
Lock Washer 5
Lock Washer 6
Lock Washer 7
Lock Washer 8
Lock Washer 9
Long-Sleeve Logo Jersey, L
Long-Sleeve Logo Jersey, M
Long-Sleeve Logo Jersey, S
Long-Sleeve Logo Jersey, XL
Lower Head Race
Men's Bib-Shorts, L
Men's Bib-Shorts, M
Men's Bib-Shorts, S
Men's Sports Shorts, L
Men's Sports Shorts, M
Men's Sports Shorts, S
Men's Sports Shorts, XL
Metal Angle
Metal Bar 1
Metal Bar 2
Metal Plate 1
Metal Plate 2
Metal Plate 3
Metal Sheet 1
Metal Sheet 2
Metal Sheet 3
Metal Sheet 4
Metal Sheet 5
Metal Sheet 6
Metal Sheet 7
Metal Tread Plate
Minipump
ML Bottom Bracket
ML Crankarm
ML Crankset
ML Fork
ML Grip Tape
ML Headset
ML Mountain Frame - Black, 38
ML Mountain Frame - Black, 40
ML Mountain Frame - Black, 44
ML Mountain Frame - Black, 48
ML Mountain Frame-W - Silver, 38
ML Mountain Frame-W - Silver, 40
ML Mountain Frame-W - Silver, 42
ML Mountain Frame-W - Silver, 46
ML Mountain Front Wheel
ML Mountain Handlebars
ML Mountain Pedal
ML Mountain Rear Wheel
ML Mountain Rim
ML Mountain Seat Assembly
ML Mountain Seat/Saddle
ML Mountain Tire
ML Road Frame - Red, 44
ML Road Frame - Red, 48
ML Road Frame - Red, 52
ML Road Frame - Red, 58
ML Road Frame - Red, 60
ML Road Frame-W - Yellow, 38
ML Road Frame-W - Yellow, 40
ML Road Frame-W - Yellow, 42
ML Road Frame-W - Yellow, 44
ML Road Frame-W - Yellow, 48
ML Road Front Wheel
ML Road Handlebars
ML Road Pedal
ML Road Rear Wheel
ML Road Rim
ML Road Seat Assembly
ML Road Seat/Saddle
ML Road Tire
ML Touring Seat Assembly
ML Touring Seat/Saddle
Mountain Bike Socks, L
Mountain Bike Socks, M
Mountain Bottle Cage
Mountain End Caps
Mountain Pump
Mountain Tire Tube
Mountain-100 Black, 38
Mountain-100 Black, 42
Mountain-100 Black, 44
Mountain-100 Black, 48
Mountain-100 Silver, 38
Mountain-100 Silver, 42
Mountain-100 Silver, 44
Mountain-100 Silver, 48
Mountain-200 Black, 38
Mountain-200 Black, 42
Mountain-200 Black, 46
Mountain-200 Silver, 38
Mountain-200 Silver, 42
Mountain-200 Silver, 46
Mountain-300 Black, 38
Mountain-300 Black, 40
Mountain-300 Black, 44
Mountain-300 Black, 48
Mountain-400-W Silver, 38
Mountain-400-W Silver, 40
Mountain-400-W Silver, 42
Mountain-400-W Silver, 46
Mountain-500 Black, 40
Mountain-500 Black, 42
Mountain-500 Black, 44
Mountain-500 Black, 48
Mountain-500 Black, 52
Mountain-500 Silver, 40
Mountain-500 Silver, 42
Mountain-500 Silver, 44
Mountain-500 Silver, 48
Mountain-500 Silver, 52
Paint - Black
Paint - Blue
Paint - Red
Paint - Silver
Paint - Yellow
Patch Kit/8 Patches
Pinch Bolt
Racing Socks, L
Racing Socks, M
Rear Brakes
Rear Derailleur
Rear Derailleur Cage
Reflector
Road Bottle Cage
Road End Caps
Road Tire Tube
Road-150 Red, 44
Road-150 Red, 48
Road-150 Red, 52
Road-150 Red, 56
Road-150 Red, 62
Road-250 Black, 44
Road-250 Black, 48
Road-250 Black, 52
Road-250 Black, 58
Road-250 Red, 44
Road-250 Red, 48
Road-250 Red, 52
Road-250 Red, 58
Road-350-W Yellow, 40
Road-350-W Yellow, 42
Road-350-W Yellow, 44
Road-350-W Yellow, 48
Road-450 Red, 44
Road-450 Red, 48
Road-450 Red, 52
Road-450 Red, 58
Road-450 Red, 60
Road-550-W Yellow, 38
Road-550-W Yellow, 40
Road-550-W Yellow, 42
Road-550-W Yellow, 44
Road-550-W Yellow, 48
Road-650 Black, 44
Road-650 Black, 48
Road-650 Black, 52
Road-650 Black, 58
Road-650 Black, 60
Road-650 Black, 62
Road-650 Red, 44
Road-650 Red, 48
Road-650 Red, 52
Road-650 Red, 58
Road-650 Red, 60
Road-650 Red, 62
Road-750 Black, 44
Road-750 Black, 48
Road-750 Black, 52
Road-750 Black, 58
Seat Lug
Seat Post
Seat Stays
Seat Tube
Short-Sleeve Classic Jersey, L
Short-Sleeve Classic Jersey, M
Short-Sleeve Classic Jersey, S
Short-Sleeve Classic Jersey, XL
Spokes
Sport-100 Helmet, Black
Sport-100 Helmet, Blue
Sport-100 Helmet, Red
Steerer
Stem
Taillights - Battery-Powered
Tension Pulley
Thin-Jam Hex Nut 1
Thin-Jam Hex Nut 10
Thin-Jam Hex Nut 11
Thin-Jam Hex Nut 12
Thin-Jam Hex Nut 13
Thin-Jam Hex Nut 14
Thin-Jam Hex Nut 15
Thin-Jam Hex Nut 16
Thin-Jam Hex Nut 2
Thin-Jam Hex Nut 3
Thin-Jam Hex Nut 4
Thin-Jam Hex Nut 5
Thin-Jam Hex Nut 6
Thin-Jam Hex Nut 7
Thin-Jam Hex Nut 8
Thin-Jam Hex Nut 9
Thin-Jam Lock Nut 1
Thin-Jam Lock Nut 10
Thin-Jam Lock Nut 11
Thin-Jam Lock Nut 12
Thin-Jam Lock Nut 13
Thin-Jam Lock Nut 14
Thin-Jam Lock Nut 15
Thin-Jam Lock Nut 16
Thin-Jam Lock Nut 2
Thin-Jam Lock Nut 3
Thin-Jam Lock Nut 4
Thin-Jam Lock Nut 5
Thin-Jam Lock Nut 6
Thin-Jam Lock Nut 7
Thin-Jam Lock Nut 8
Thin-Jam Lock Nut 9
Top Tube
Touring End Caps
Touring Front Wheel
Touring Pedal
Touring Rear Wheel
Touring Rim
Touring Tire
Touring Tire Tube
Touring-1000 Blue, 46
Touring-1000 Blue, 50
Touring-1000 Blue, 54
Touring-1000 Blue, 60
Touring-1000 Yellow, 46
Touring-1000 Yellow, 50
Touring-1000 Yellow, 54
Touring-1000 Yellow, 60
Touring-2000 Blue, 46
Touring-2000 Blue, 50
Touring-2000 Blue, 54
Touring-2000 Blue, 60
Touring-3000 Blue, 44
Touring-3000 Blue, 50
Touring-3000 Blue, 54
Touring-3000 Blue, 58
Touring-3000 Blue, 62
Touring-3000 Yellow, 44
Touring-3000 Yellow, 50
Touring-3000 Yellow, 54
Touring-3000 Yellow, 58
Touring-3000 Yellow, 62
Touring-Panniers, Large
Water Bottle - 30 oz.
Women's Mountain Shorts, L
Women's Mountain Shorts, M
Women's Mountain Shorts, S
Women's Tights, L
Women's Tights, M
Women's Tights, S