USE `northwind_dummy`;

-- ------------------------------------------------------
-- 1. CLEANUP (Optional: Safe deletion order)
-- ------------------------------------------------------
SET FOREIGN_KEY_CHECKS = 0;
TRUNCATE TABLE `orderdetails`;
TRUNCATE TABLE `orders`;
TRUNCATE TABLE `products`;
TRUNCATE TABLE `categories`;
TRUNCATE TABLE `suppliers`;
TRUNCATE TABLE `shippers`;
TRUNCATE TABLE `employees`;
TRUNCATE TABLE `customers`;
SET FOREIGN_KEY_CHECKS = 1;

-- ------------------------------------------------------
-- 2. POPULATE MASTER TABLES (No Foreign Keys)
-- ------------------------------------------------------

-- Categories
INSERT INTO `categories` (`CategoryID`, `CategoryName`, `Description`) VALUES
(1, 'Organic Produce', 'Fresh farm-to-table fruits and vegetables'),
(2, 'Artisanal Bakery', 'Small-batch rustic breads and pastries'),
(3, 'Eco-Friendly Cleaners', 'Plant-based commercial cleaning solutions'),
(4, 'Herbal Infusions', 'Loose-leaf teas and botanical blends');

-- Shippers
INSERT INTO `shippers` (`ShipperID`, `ShipperName`, `Phone`) VALUES
(1, 'Apex Freight Systems', '(555) 019-2834'),
(2, 'Velocity Couriers', '(555) 014-9922'),
(3, 'Oceanic Bulk Cargo', '(555) 017-8811');

-- Employees
INSERT INTO `employees` (`EmployeeID`, `LastName`, `FirstName`, `BirthDate`, `Photo`, `Notes`) VALUES
(1, 'Sterling', 'Eleanor', '1985-04-12 00:00:00', 'emp1_sterling.png', 'Specializes in international accounts and logistics.'),
(2, 'Garrison', 'Tyler', '1990-11-23 00:00:00', 'emp2_garrison.png', 'Manages regional retail distribution.'),
(3, 'Vance', 'Sofia', '1994-07-08 00:00:00', 'emp3_vance.png', 'Focuses on e-commerce client success.');

-- Customers (Note: CustomerID is an INT in this schema)
INSERT INTO `customers` (`CustomerID`, `CustomerName`, `ContactName`, `Address`, `City`, `PostalCode`, `Country`) VALUES
(1, 'Alpha Retail Group', 'Sarah Jenkins', '452 Innovation Way', 'Austin', '78701', 'USA'),
(2, 'Vortex Wholesale', 'Marcus Miller', '88 Titanium Blvd', 'Manchester', 'M1 1AE', 'UK'),
(3, 'Aura Wellness Corp', 'Elena Rostova', '712 Birch Avenue', 'Munich', '80331', 'Germany'),
(4, 'Prism Ventures', 'Chloe Dubois', '14 Rue de la Paix', 'Paris', '75002', 'France');

-- Suppliers
INSERT INTO `suppliers` (`SupplierID`, `SupplierName`, `ContactName`, `Address`, `City`, `PostalCode`, `Country`, `Phone`) VALUES
(1, 'Summit Agro Labs', 'David Vance', '109 Peak Ridge Road', 'Calgary', 'T2P 2M1', 'Canada', '(403) 555-8121'),
(2, 'Nova Botanicals', 'Clara Rossi', '8 Via Fontana', 'Milan', '20121', 'Italy', '02 8842 1192'),
(3, 'Zephyr Processing', 'Arthur Pendelton', '55 Industrial Estates', 'Cork', 'T12 X8R', 'Ireland', '021 496 1100');


-- ------------------------------------------------------
-- 3. POPULATE DEPENDENT TABLES
-- ------------------------------------------------------

-- Products
INSERT INTO `products` (`ProductID`, `ProductName`, `SupplierID`, `CategoryID`, `Unit`, `Price`) VALUES
(1, 'Glacier Raw Honey', 1, 2, '12 - 500g jars', 19.00),
(2, 'Crimson Crisp Apples', 1, 1, '20 kg crate', 32.00),
(3, 'Cold-Pressed Olive Oil', 2, 2, '6 - 750ml bottles', 43.00),
(4, 'Eucalyptus Multi-Surface', 3, 3, '4 - 1 Gallon jugs', 25.00),
(5, 'Chamomile Lavender Blend', 2, 4, '24 boxes x 20 bags', 15.00);

-- Orders
INSERT INTO `orders` (`OrderID`, `CustomerID`, `EmployeeID`, `OrderDate`, `ShipperID`) VALUES
(1001, 1, 2, '2026-05-01 10:30:00', 1),
(1002, 2, 2, '2026-05-12 14:15:00', 2),
(1003, 3, 3, '2026-05-28 09:00:00', 3),
(1004, 4, 1, '2026-06-02 16:45:00', 1);

-- Order Details
INSERT INTO `orderdetails` (`OrderDetailID`, `OrderID`, `ProductID`, `Quantity`) VALUES
(1, 1001, 1, 5),
(2, 1001, 2, 2),
(3, 1002, 3, 12),
(4, 1003, 4, 10),
(5, 1004, 5, 25),
(6, 1004, 1, 3);