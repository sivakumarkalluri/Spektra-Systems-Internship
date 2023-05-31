CREATE DATABASE EcommerceDB;

USE EcommerceDB;

CREATE TABLE products (
  id INT PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  price DECIMAL(10, 2) NOT NULL,
  discount DECIMAL(4, 2) NOT NULL,
  description TEXT NOT NULL,
  image VARCHAR(255) NOT NULL,
  productCategory VARCHAR(50) NOT NULL,
    productSubCategory VARCHAR(50) NOT NULL,
	gender varchar(10) NOT NULL

);


INSERT INTO products (id, name, price, discount, description, image,productCategory,productSubCategory,gender)
VALUES
  (1, 'Mens T-Shirt', 19.99, 0.2, 'Comfortable and stylish mens t-shirt in various colors.', 'assets/products/product1.jpg','Top-Wear','T-Shirt','male'),
  (2, 'Womens Dress', 39.99, 0.1, 'Elegant and fashionable dress for women suitable for any occasion.', 'assets/products/product2.jpg','Top-Wear','dress','female'),
  (3, 'Mens Jeans', 49.99, 0.15, 'Classic mens jeans with a modern fit and durable material.', 'assets/products/product3.jpg','Bottom-Wear','Pant','male'),
  (4, 'Unisex Sneakers', 59.99, 0.25, 'Versatile and comfortable sneakers suitable for both men and women.', 'assets/products/product4.jpg','Shoes','Sneakers','unisex'),
  (5, 'Mens Polo Shirt', 34.99, 0.2, 'Classic and casual mens polo shirt for a stylish look.', 'assets/products/product5.jpg','Top-Wear','Shirt','male'),
  (6, 'Mens Shorts', 19.99, 0.15, 'Comfortable and lightweight mens shorts for casual wear.', 'assets/products/product6.jpg','Top-Wear','Shorts','male'),
  (7, 'Womens Sweater', 44.99, 0.2, 'Warm and cozy sweater for women to stay fashionable in colder weather.', 'assets/products/product7.jpg','Top-Wear','dress','female'),
  (8, 'Mens Jacket', 79.99, 0.1, 'Durable and stylish jacket for men to stay warm and fashionable.', 'assets/products/product9.jpg','Top-Wear','Shirt','male'),
  (9, 'Unisex Hat', 14.99, 0.05, 'Stylish and versatile hat suitable for both men and women.', 'assets/products/product8.jpg','Top-Wear','Hat','unisex'),
  (10, 'Rover Bag', 24.99, 0.15, 'Rover Pack Anti Theft Backpack with 15.6 inch Laptop Compartment, Patented Design.', 'assets/products/product10.jpg','Bags','luggage-bag','unisex'),
  (11, 'Unisex Hoodie', 49.99, 0.2, 'Cozy and warm hoodie suitable for both men and women.', 'assets/products/product11.jpg','Top-Wear','Shirt','unisex'),
  (12, 'Mens Formal Shirt', 43, 0.1, 'Elegant and sophisticated formal shirt for men for special occasions.', 'assets/products/product12.jpg','Top-Wear','Shirt','male');


  -- Create the "purchases" table
CREATE TABLE purchases (
    id INT PRIMARY KEY,
    name NVARCHAR(100),
    price DECIMAL(10, 2),
    quantity INT,
    discount DECIMAL(10, 2),
    description NVARCHAR(MAX),
    image NVARCHAR(MAX)
);

-- Insert the JSON data into the "purchases" table
INSERT INTO purchases (id, name, price, quantity, discount, description, image)
VALUES 
    (1, 'Men''s T-Shirt', 19.99, 1, 0.2, 'Comfortable and stylish men''s t-shirt in various colors.', 'assets/products/product1.jpg'),
    (2, 'Women''s Dress', 39.99, 1, 0.1, 'Elegant and fashionable dress for women suitable for any occasion.', 'assets/products/product2.jpg'),
    (3, 'Men''s Jeans', 49.99, 2, 0.15, 'Classic men''s jeans with a modern fit and durable material.', 'assets/products/product3.jpg');


	ALTER TABLE products
ADD productCategory VARCHAR(50),
    productSubCategory VARCHAR(50),
	gender varchar(10);

CREATE TABLE Images (
  Id INT PRIMARY KEY,
  FileName VARCHAR(255) NOT NULL,
  FileDescription VARCHAR(255),
  FileExtension VARCHAR(50) NOT NULL,
  FileSizeInBytes BIGINT NOT NULL,
  FilePath VARCHAR(255) NOT NULL
);

select * from Images;

