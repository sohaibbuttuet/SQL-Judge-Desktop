USE `dublinbikes_dummy`;

-- ------------------------------------------------------
-- 1. CLEANUP (Safe truncation order)
-- ------------------------------------------------------
SET FOREIGN_KEY_CHECKS = 0;
TRUNCATE TABLE `bike_rentals`;
TRUNCATE TABLE `repairs`;
TRUNCATE TABLE `vans`;
TRUNCATE TABLE `bike_status`;
TRUNCATE TABLE `bikes`;
TRUNCATE TABLE `station_status`;
TRUNCATE TABLE `stations`;
TRUNCATE TABLE `payments`;
TRUNCATE TABLE `customers`;
TRUNCATE TABLE `customer_details`;
TRUNCATE TABLE `payment_method`;
TRUNCATE TABLE `old_staff`;
TRUNCATE TABLE `staff`;
SET FOREIGN_KEY_CHECKS = 1;

-- ------------------------------------------------------
-- 2. MASTER TABLES (Level 0 - No Foreign Keys)
-- ------------------------------------------------------

-- customer_details
INSERT INTO `customer_details` (`Customer_ID`, `Lname`, `Fname`, `Address`, `County`, `DOB`, `Joined`) VALUES
(4001, 'O\'Connor', 'Liam', '12 George\'s Street', 'Dublin', '1992-05-14', '2024-01-10'),
(4002, 'Murphy', 'Aoife', '44 Rathmines Road', 'Dublin', '1995-11-22', '2024-02-15'),
(4003, 'Byrne', 'Sean', '88 Malahide Road', 'Dublin', '1988-08-03', '2024-03-01'),
(4004, 'Doyle', 'Ciara', '105 Clontarf Strand', 'Dublin', '2001-02-27', '2024-04-12');

-- payment_method
INSERT INTO `payment_method` (`Method_ID`, `Method`, `Account_No`, `Bank`, `Address`, `Subscription`) VALUES
(301, 'Credit Card', 'IE99BOFI90000123456789', 'Bank of Ireland', 'Baggot Street, Dublin 2', 'Annual Leap Premium'),
(302, 'Debit Card', 'IE88AIBK93000098765432', 'Allied Irish Banks', 'O\'Connell Street, Dublin 1', '3-Day Explorer'),
(303, 'Digital Wallet', 'IE77ULSB95000045612378', 'Permanent TSB', 'Henry Street, Dublin 1', 'Annual Standard');

-- staff
INSERT INTO `staff` (`Staff_ID`, `Lname`, `Fname`, `Address`, `County`, `Phone`, `DOB`, `Joined`) VALUES
(501, 'Walsh', 'Darragh', '3 Albany Mews', 'Dublin', '+353871234567', '1984-06-15', '2021-05-01'),
(502, 'Kennedy', 'Niamh', '17 Custom House Quay', 'Dublin', '+353869876543', '1990-09-30', '2022-08-15'),
(503, 'Gallagher', 'Eoin', '52 Phibsborough Road', 'Dublin', '+353855554433', '1993-01-20', '2023-11-10');

-- stations
INSERT INTO `stations` (`Station_ID`, `Location`, `Address`, `Latitude`, `Longitude`, `Banking`) VALUES
(101, 'Smithfield Square', 'Smithfield, Dublin 7', 53.348200, -6.277800, 1),
(102, 'Parnell Square', 'Parnell Street, Dublin 1', 53.353400, -6.264500, 0),
(103, 'Merrion Square', 'Merrion Square South, Dublin 2', 53.339800, -6.249700, 1),
(104, 'Portobello Harbour', 'Grand Canal, Dublin 8', 53.330400, -6.267100, 0);

-- ------------------------------------------------------
-- 3. DEPENDENT TABLES (Level 1)
-- ------------------------------------------------------

-- customers (Depends on customer_details)
INSERT INTO `customers` (`Customer_ID`, `Username`, `Pass_word`, `Email`, `Phone`) VALUES
(4001, 'liam_oc', 'p@ssword123', 'liam.oc@email.ie', '+353831112222'),
(4002, 'aoife_m', 'secure_bik3', 'aoife.murphy@email.com', '+353852223333'),
(4003, 'sean_b', 'dublin_rider', 's.byrne@webmail.ie', '+353863334444'),
(4004, 'ciara_d', 'clontarf2026', 'ciaradoyle@email.ie', '+353874445555');

-- old_staff (Depends on staff)
INSERT INTO `old_staff` (`Old_Staff_ID`, `Staff_ID`, `Lname`, `Fname`, `Address`, `County`, `Phone`, `DOB`, `Joined`) VALUES
(901, 503, 'Brady', 'James', '14 Dame Street', 'Dublin', '+353891234555', '1980-03-11', '2019-02-10');

-- station_status (Depends on stations)
INSERT INTO `station_status` (`S_Status_ID`, `Station_ID`, `S_Status`, `Capacity`, `Parking`, `Bikes`, `Updated`) VALUES
(701, 101, 'Full Service', 30, 12, 18, '2026-06-03 18:45:00.000000'),
(702, 102, 'Full Service', 20, 15, 5, '2026-06-03 19:10:00.000000'),
(703, 103, 'Full Service', 40, 2, 38, '2026-06-03 19:20:00.000000'),
(704, 104, 'Maintenance Mode', 25, 25, 0, '2026-06-03 16:30:00.000000');

-- bikes (Depends on stations)
INSERT INTO `bikes` (`Bike_ID`, `Station_ID`, `Model`) VALUES
(2001, 101, '2022-03-15'),
(2002, 101, '2022-03-15'),
(2003, 102, '2023-07-20'),
(2004, 103, '2024-05-11'),
(2005, 103, '2025-01-18');

-- payments (Depends on customers, payment_method)
INSERT INTO `payments` (`Payment_ID`, `Customer_ID`, `Method_ID`, `Rate`, `Date_stamp`, `Time_stamp`, `Amount`) VALUES
(801, 4001, 301, 3.50, '2026-05-10', '14:23:11', 35.00),
(802, 4002, 302, 5.00, '2026-05-15', '09:05:44', 5.00),
(803, 4003, 301, 3.50, '2026-05-20', '18:12:02', 12.50),
(804, 4004, 303, 0.00, '2026-06-01', '11:34:50', 0.00);

-- vans (Depends on staff, stations)
INSERT INTO `vans` (`Licence_ID`, `Station_ID`, `Staff_ID`, `Date_stamp`, `Bikes`, `Station_end`) VALUES
('241-D-1024', 103, 501, '2026-06-02', 15, 'Portobello Harbour'),
('252-D-8891', 101, 502, '2026-06-03', 8, 'Parnell Square');

-- ------------------------------------------------------
-- 4. DEPENDENT TABLES (Level 2)
-- ------------------------------------------------------

-- bike_status (Depends on bikes)
INSERT INTO `bike_status` (`B_Status_ID`, `Bike_ID`, `B_Status`, `Last_Station`, `Distance`, `Mileage`) VALUES
(601, 2001, 'Operational', 101, 4.20, 145.80),
(602, 2002, 'Operational', 101, 8.50, 312.10),
(603, 2003, 'Requires Repair', 102, 1.10, 89.40),
(604, 2004, 'Operational', 103, 12.00, 24.50),
(605, 2005, 'In Transit', 104, 0.00, 415.00);

-- bike_rentals (Depends on customers, bikes, payments, stations)
INSERT INTO `bike_rentals` (`Rental_ID`, `Customer_ID`, `Bike_ID`, `Payment_ID`, `Station_ID`, `Start_Time`, `End_Time`, `Start_Station`, `End_Station`) VALUES
(5001, 4001, 2001, 801, 101, '2026-05-10 14:30:00', '2026-05-10 15:15:00', 101, 102),
(5002, 4002, 2003, 802, 102, '2026-05-15 09:10:00', '2026-05-15 09:35:00', 102, 102),
(5003, 4003, 2004, 803, 103, '2026-05-20 18:15:00', '2026-05-20 19:05:00', 103, 104);

-- repairs (Depends on bike_status, staff)
INSERT INTO `repairs` (`Repair_ID`, `B_Status_ID`, `Staff_ID`, `Delivered`, `Price`, `Parts`) VALUES
(1101, 603, 503, '2026-06-03', 45.50, 2);