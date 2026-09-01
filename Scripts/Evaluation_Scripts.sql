-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: localhost    Database: northwind_judge
-- ------------------------------------------------------
-- Server version	8.0.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `CategoryID` int NOT NULL AUTO_INCREMENT,
  `CategoryName` varchar(25) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CategoryID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Beverages','Soft drinks, coffees, teas, beers, and ales'),(2,'Condiments','Sweet and savory sauces, relishes, spreads, and seasonings'),(3,'Confections','Desserts, candies, and sweet breads'),(4,'Dairy Products','Cheeses'),(5,'Grains/Cereals','Breads, crackers, pasta, and cereal'),(6,'Meat/Poultry','Prepared meats'),(7,'Produce','Dried fruit and bean curd'),(8,'Seafood','Seaweed and fish');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `CustomerID` int NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(50) DEFAULT NULL,
  `ContactName` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `City` varchar(20) DEFAULT NULL,
  `PostalCode` varchar(10) DEFAULT NULL,
  `Country` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`CustomerID`)
) ENGINE=InnoDB AUTO_INCREMENT=92 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'Alfreds Futterkiste','Maria Anders','Obere Str. 57','Berlin','12209','Germany'),(2,'Ana Trujillo Emparedados y helados','Ana Trujillo','Avda. de la Constitución 2222','México D.F.','5021','Mexico'),(3,'Antonio Moreno Taquería','Antonio Moreno','Mataderos 2312','México D.F.','5023','Mexico'),(4,'Around the Horn','Thomas Hardy','120 Hanover Sq.','London','WA1 1DP','UK'),(5,'Berglunds snabbköp','Christina Berglund','Berguvsvägen 8','Luleå','S-958 22','Sweden'),(6,'Blauer See Delikatessen','Hanna Moos','Forsterstr. 57','Mannheim','68306','Germany'),(7,'Blondel père et fils','Frédérique Citeaux','24, place Kléber','Strasbourg','67000','France'),(8,'Bólido Comidas preparadas','Martín Sommer','C/ Araquil, 67','Madrid','28023','Spain'),(9,'Bon app\'\'','Laurence Lebihans','12, rue des Bouchers','Marseille','13008','France'),(10,'Bottom-Dollar Marketse','Elizabeth Lincoln','23 Tsawassen Blvd.','Tsawassen','T2F 8M4','Canada'),(11,'B\'\'s Beverages','Victoria Ashworth','Fauntleroy Circus','London','EC2 5NT','UK'),(12,'Cactus Comidas para llevar','Patricio Simpson','Cerrito 333','Buenos Aires','1010','Argentina'),(13,'Centro comercial Moctezuma','Francisco Chang','Sierras de Granada 9993','México D.F.','5022','Mexico'),(14,'Chop-suey Chinese','Yang Wang','Hauptstr. 29','Bern','3012','Switzerland'),(15,'Comércio Mineiro','Pedro Afonso','Av. dos Lusíadas, 23','São Paulo','05432-043','Brazil'),(16,'Consolidated Holdings','Elizabeth Brown','Berkeley Gardens 12 Brewery','London','WX1 6LT','UK'),(17,'Drachenblut Delikatessend','Sven Ottlieb','Walserweg 21','Aachen','52066','Germany'),(18,'Du monde entier','Janine Labrune','67, rue des Cinquante Otages','Nantes','44000','France'),(19,'Eastern Connection','Ann Devon','35 King George','London','WX3 6FW','UK'),(20,'Ernst Handel','Roland Mendel','Kirchgasse 6','Graz','8010','Austria'),(21,'Familia Arquibaldo','Aria Cruz','Rua Orós, 92','São Paulo','05442-030','Brazil'),(22,'FISSA Fabrica Inter. Salchichas S.A.','Diego Roel','C/ Moralzarzal, 86','Madrid','28034','Spain'),(23,'Folies gourmandes','Martine Rancé','184, chaussée de Tournai','Lille','59000','France'),(24,'Folk och fä HB','Maria Larsson','Åkergatan 24','Bräcke','S-844 67','Sweden'),(25,'Frankenversand','Peter Franken','Berliner Platz 43','München','80805','Germany'),(26,'France restauration','Carine Schmitt','54, rue Royale','Nantes','44000','France'),(27,'Franchi S.p.A.','Paolo Accorti','Via Monte Bianco 34','Torino','10100','Italy'),(28,'Furia Bacalhau e Frutos do Mar','Lino Rodriguez','Jardim das rosas n. 32','Lisboa','1675','Portugal'),(29,'Galería del gastrónomo','Eduardo Saavedra','Rambla de Cataluña, 23','Barcelona','8022','Spain'),(30,'Godos Cocina Típica','José Pedro Freyre','C/ Romero, 33','Sevilla','41101','Spain'),(31,'Gourmet Lanchonetes','André Fonseca','Av. Brasil, 442','Campinas','04876-786','Brazil'),(32,'Great Lakes Food Market','Howard Snyder','2732 Baker Blvd.','Eugene','97403','USA'),(33,'GROSELLA-Restaurante','Manuel Pereira','5ª Ave. Los Palos Grandes','Caracas','1081','Venezuela'),(34,'Hanari Carnes','Mario Pontes','Rua do Paço, 67','Rio de Janeiro','05454-876','Brazil'),(35,'HILARIÓN-Abastos','Carlos Hernández','Carrera 22 con Ave. Carlos Soublette #8-35','San Cristóbal','5022','Venezuela'),(36,'Hungry Coyote Import Store','Yoshi Latimer','City Center Plaza 516 Main St.','Elgin','97827','USA'),(37,'Hungry Owl All-Night Grocers','Patricia McKenna','8 Johnstown Road','Cork','','Ireland'),(38,'Island Trading','Helen Bennett','Garden House Crowther Way','Cowes','PO31 7PJ','UK'),(39,'Königlich Essen','Philip Cramer','Maubelstr. 90','Brandenburg','14776','Germany'),(40,'La corne d\'\'abondance','Daniel Tonini','67, avenue de l\'\'Europe','Versailles','78000','France'),(41,'La maison d\'\'Asie','Annette Roulet','1 rue Alsace-Lorraine','Toulouse','31000','France'),(42,'Laughing Bacchus Wine Cellars','Yoshi Tannamuri','1900 Oak St.','Vancouver','V3F 2K1','Canada'),(43,'Lazy K Kountry Store','John Steel','12 Orchestra Terrace','Walla Walla','99362','USA'),(44,'Lehmanns Marktstand','Renate Messner','Magazinweg 7','Frankfurt a.M.','60528','Germany'),(45,'Let\'\'s Stop N Shop','Jaime Yorres','87 Polk St. Suite 5','San Francisco','94117','USA'),(46,'LILA-Supermercado','Carlos González','Carrera 52 con Ave. Bolívar #65-98 Llano Largo','Barquisimeto','3508','Venezuela'),(47,'LINO-Delicateses','Felipe Izquierdo','Ave. 5 de Mayo Porlamar','I. de Margarita','4980','Venezuela'),(48,'Lonesome Pine Restaurant','Fran Wilson','89 Chiaroscuro Rd.','Portland','97219','USA'),(49,'Magazzini Alimentari Riuniti','Giovanni Rovelli','Via Ludovico il Moro 22','Bergamo','24100','Italy'),(50,'Maison Dewey','Catherine Dewey','Rue Joseph-Bens 532','Bruxelles','B-1180','Belgium'),(51,'Mère Paillarde','Jean Fresnière','43 rue St. Laurent','Montréal','H1J 1C3','Canada'),(52,'Morgenstern Gesundkost','Alexander Feuer','Heerstr. 22','Leipzig','4179','Germany'),(53,'North/South','Simon Crowther','South House 300 Queensbridge','London','SW7 1RZ','UK'),(54,'Océano Atlántico Ltda.','Yvonne Moncada','Ing. Gustavo Moncada 8585 Piso 20-A','Buenos Aires','1010','Argentina'),(55,'Old World Delicatessen','Rene Phillips','2743 Bering St.','Anchorage','99508','USA'),(56,'Ottilies Käseladen','Henriette Pfalzheim','Mehrheimerstr. 369','Köln','50739','Germany'),(57,'Paris spécialités','Marie Bertrand','265, boulevard Charonne','Paris','75012','France'),(58,'Pericles Comidas clásicas','Guillermo Fernández','Calle Dr. Jorge Cash 321','México D.F.','5033','Mexico'),(59,'Piccolo und mehr','Georg Pipps','Geislweg 14','Salzburg','5020','Austria'),(60,'Princesa Isabel Vinhoss','Isabel de Castro','Estrada da saúde n. 58','Lisboa','1756','Portugal'),(61,'Que Delícia','Bernardo Batista','Rua da Panificadora, 12','Rio de Janeiro','02389-673','Brazil'),(62,'Queen Cozinha','Lúcia Carvalho','Alameda dos Canàrios, 891','São Paulo','05487-020','Brazil'),(63,'QUICK-Stop','Horst Kloss','Taucherstraße 10','Cunewalde','1307','Germany'),(64,'Rancho grande','Sergio Gutiérrez','Av. del Libertador 900','Buenos Aires','1010','Argentina'),(65,'Rattlesnake Canyon Grocery','Paula Wilson','2817 Milton Dr.','Albuquerque','87110','USA'),(66,'Reggiani Caseifici','Maurizio Moroni','Strada Provinciale 124','Reggio Emilia','42100','Italy'),(67,'Ricardo Adocicados','Janete Limeira','Av. Copacabana, 267','Rio de Janeiro','02389-890','Brazil'),(68,'Richter Supermarkt','Michael Holz','Grenzacherweg 237','Genève','1203','Switzerland'),(69,'Romero y tomillo','Alejandra Camino','Gran Vía, 1','Madrid','28001','Spain'),(70,'Santé Gourmet','Jonas Bergulfsen','Erling Skakkes gate 78','Stavern','4110','Norway'),(71,'Save-a-lot Markets','Jose Pavarotti','187 Suffolk Ln.','Boise','83720','USA'),(72,'Seven Seas Imports','Hari Kumar','90 Wadhurst Rd.','London','OX15 4NB','UK'),(73,'Simons bistro','Jytte Petersen','Vinbæltet 34','København','1734','Denmark'),(74,'Spécialités du monde','Dominique Perrier','25, rue Lauriston','Paris','75016','France'),(75,'Split Rail Beer & Ale','Art Braunschweiger','P.O. Box 555','Lander','82520','USA'),(76,'Suprêmes délices','Pascale Cartrain','Boulevard Tirou, 255','Charleroi','B-6000','Belgium'),(77,'The Big Cheese','Liz Nixon','89 Jefferson Way Suite 2','Portland','97201','USA'),(78,'The Cracker Box','Liu Wong','55 Grizzly Peak Rd.','Butte','59801','USA'),(79,'Toms Spezialitäten','Karin Josephs','Luisenstr. 48','Münster','44087','Germany'),(80,'Tortuga Restaurante','Miguel Angel Paolino','Avda. Azteca 123','México D.F.','5033','Mexico'),(81,'Tradição Hipermercados','Anabela Domingues','Av. Inês de Castro, 414','São Paulo','05634-030','Brazil'),(82,'Trail\'\'s Head Gourmet Provisioners','Helvetius Nagy','722 DaVinci Blvd.','Kirkland','98034','USA'),(83,'Vaffeljernet','Palle Ibsen','Smagsløget 45','Århus','8200','Denmark'),(84,'Victuailles en stock','Mary Saveley','2, rue du Commerce','Lyon','69004','France'),(85,'Vins et alcools Chevalier','Paul Henriot','59 rue de l\'\'Abbaye','Reims','51100','France'),(86,'Die Wandernde Kuh','Rita Müller','Adenauerallee 900','Stuttgart','70563','Germany'),(87,'Wartian Herkku','Pirkko Koskitalo','Torikatu 38','Oulu','90110','Finland'),(88,'Wellington Importadora','Paula Parente','Rua do Mercado, 12','Resende','08737-363','Brazil'),(89,'White Clover Markets','Karl Jablonski','305 - 14th Ave. S. Suite 3B','Seattle','98128','USA'),(90,'Wilman Kala','Matti Karttunen','Keskuskatu 45','Helsinki','21240','Finland'),(91,'Wolski','Zbyszek','ul. Filtrowa 68','Walla','01-012','Poland');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `EmployeeID` int NOT NULL AUTO_INCREMENT,
  `LastName` varchar(15) DEFAULT NULL,
  `FirstName` varchar(15) DEFAULT NULL,
  `BirthDate` datetime DEFAULT NULL,
  `Photo` varchar(25) DEFAULT NULL,
  `Notes` varchar(1024) DEFAULT NULL,
  PRIMARY KEY (`EmployeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'Davolio','Nancy','1968-12-08 00:00:00','EmpID1.pic','Education includes a BA in psychology from Colorado State University. She also completed (The Art of the Cold Call). Nancy is a member of \'Toastmasters International\'.'),(2,'Fuller','Andrew','1952-02-19 00:00:00','EmpID2.pic','Andrew received his BTS commercial and a Ph.D. in international marketing from the University of Dallas. He is fluent in French and Italian and reads German. He joined the company as a sales representative, was promoted to sales manager and was then named vice president of sales. Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.'),(3,'Leverling','Janet','1963-08-30 00:00:00','EmpID3.pic','Janet has a BS degree in chemistry from Boston College). She has also completed a certificate program in food retailing management. Janet was hired as a sales associate and was promoted to sales representative.'),(4,'Peacock','Margaret','1958-09-19 00:00:00','EmpID4.pic','Margaret holds a BA in English literature from Concordia College and an MA from the American Institute of Culinary Arts. She was temporarily assigned to the London office before returning to her permanent post in Seattle.'),(5,'Buchanan','Steven','1955-03-04 00:00:00','EmpID5.pic','Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree. Upon joining the company as a sales representative, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London, where he was promoted to sales manager. Mr. Buchanan has completed the courses \'Successful Telemarketing\' and \'International Sales Management\'. He is fluent in French.'),(6,'Suyama','Michael','1963-07-02 00:00:00','EmpID6.pic','Michael is a graduate of Sussex University (MA, economics) and the University of California at Los Angeles (MBA, marketing). He has also taken the courses \'Multi-Cultural Selling\' and \'Time Management for the Sales Professional\'. He is fluent in Japanese and can read and write French, Portuguese, and Spanish.'),(7,'King','Robert','1960-05-29 00:00:00','EmpID7.pic','Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the University of Michigan and then joining the company. After completing a course entitled \'Selling in Europe\', he was transferred to the London office.'),(8,'Callahan','Laura','1958-01-09 00:00:00','EmpID8.pic','Laura received a BA in psychology from the University of Washington. She has also completed a course in business French. She reads and writes French.'),(9,'Dodsworth','Anne','1969-07-02 00:00:00','EmpID9.pic','Anne has a BA degree in English from St. Lawrence College. She is fluent in French and German.'),(10,'West','Adam','1928-09-19 00:00:00','EmpID10.pic','An old chum.');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderdetails`
--

DROP TABLE IF EXISTS `orderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderdetails` (
  `OrderDetailID` int NOT NULL AUTO_INCREMENT,
  `OrderID` int DEFAULT NULL,
  `ProductID` int DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  PRIMARY KEY (`OrderDetailID`),
  KEY `OrderID` (`OrderID`),
  KEY `ProductID` (`ProductID`),
  CONSTRAINT `orderdetails_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderID`),
  CONSTRAINT `orderdetails_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `products` (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=519 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderdetails`
--

LOCK TABLES `orderdetails` WRITE;
/*!40000 ALTER TABLE `orderdetails` DISABLE KEYS */;
INSERT INTO `orderdetails` VALUES (1,10248,11,12),(2,10248,42,10),(3,10248,72,5),(4,10249,14,9),(5,10249,51,40),(6,10250,41,10),(7,10250,51,35),(8,10250,65,15),(9,10251,22,6),(10,10251,57,15),(11,10251,65,20),(12,10252,20,40),(13,10252,33,25),(14,10252,60,40),(15,10253,31,20),(16,10253,39,42),(17,10253,49,40),(18,10254,24,15),(19,10254,55,21),(20,10254,74,21),(21,10255,2,20),(22,10255,16,35),(23,10255,36,25),(24,10255,59,30),(25,10256,53,15),(26,10256,77,12),(27,10257,27,25),(28,10257,39,6),(29,10257,77,15),(30,10258,2,50),(31,10258,5,65),(32,10258,32,6),(33,10259,21,10),(34,10259,37,1),(35,10260,41,16),(36,10260,57,50),(37,10260,62,15),(38,10260,70,21),(39,10261,21,20),(40,10261,35,20),(41,10262,5,12),(42,10262,7,15),(43,10262,56,2),(44,10263,16,60),(45,10263,24,28),(46,10263,30,60),(47,10263,74,36),(48,10264,2,35),(49,10264,41,25),(50,10265,17,30),(51,10265,70,20),(52,10266,12,12),(53,10267,40,50),(54,10267,59,70),(55,10267,76,15),(56,10268,29,10),(57,10268,72,4),(58,10269,33,60),(59,10269,72,20),(60,10270,36,30),(61,10270,43,25),(62,10271,33,24),(63,10272,20,6),(64,10272,31,40),(65,10272,72,24),(66,10273,10,24),(67,10273,31,15),(68,10273,33,20),(69,10273,40,60),(70,10273,76,33),(71,10274,71,20),(72,10274,72,7),(73,10275,24,12),(74,10275,59,6),(75,10276,10,15),(76,10276,13,10),(77,10277,28,20),(78,10277,62,12),(79,10278,44,16),(80,10278,59,15),(81,10278,63,8),(82,10278,73,25),(83,10279,17,15),(84,10280,24,12),(85,10280,55,20),(86,10280,75,30),(87,10281,19,1),(88,10281,24,6),(89,10281,35,4),(90,10282,30,6),(91,10282,57,2),(92,10283,15,20),(93,10283,19,18),(94,10283,60,35),(95,10283,72,3),(96,10284,27,15),(97,10284,44,21),(98,10284,60,20),(99,10284,67,5),(100,10285,1,45),(101,10285,40,40),(102,10285,53,36),(103,10286,35,100),(104,10286,62,40),(105,10287,16,40),(106,10287,34,20),(107,10287,46,15),(108,10288,54,10),(109,10288,68,3),(110,10289,3,30),(111,10289,64,9),(112,10290,5,20),(113,10290,29,15),(114,10290,49,15),(115,10290,77,10),(116,10291,13,20),(117,10291,44,24),(118,10291,51,2),(119,10292,20,20),(120,10293,18,12),(121,10293,24,10),(122,10293,63,5),(123,10293,75,6),(124,10294,1,18),(125,10294,17,15),(126,10294,43,15),(127,10294,60,21),(128,10294,75,6),(129,10295,56,4),(130,10296,11,12),(131,10296,16,30),(132,10296,69,15),(133,10297,39,60),(134,10297,72,20),(135,10298,2,40),(136,10298,36,40),(137,10298,59,30),(138,10298,62,15),(139,10299,19,15),(140,10299,70,20),(141,10300,66,30),(142,10300,68,20),(143,10301,40,10),(144,10301,56,20),(145,10302,17,40),(146,10302,28,28),(147,10302,43,12),(148,10303,40,40),(149,10303,65,30),(150,10303,68,15),(151,10304,49,30),(152,10304,59,10),(153,10304,71,2),(154,10305,18,25),(155,10305,29,25),(156,10305,39,30),(157,10306,30,10),(158,10306,53,10),(159,10306,54,5),(160,10307,62,10),(161,10307,68,3),(162,10308,69,1),(163,10308,70,5),(164,10309,4,20),(165,10309,6,30),(166,10309,42,2),(167,10309,43,20),(168,10309,71,3),(169,10310,16,10),(170,10310,62,5),(171,10311,42,6),(172,10311,69,7),(173,10312,28,4),(174,10312,43,24),(175,10312,53,20),(176,10312,75,10),(177,10313,36,12),(178,10314,32,40),(179,10314,58,30),(180,10314,62,25),(181,10315,34,14),(182,10315,70,30),(183,10316,41,10),(184,10316,62,70),(185,10317,1,20),(186,10318,41,20),(187,10318,76,6),(188,10319,17,8),(189,10319,28,14),(190,10319,76,30),(191,10320,71,30),(192,10321,35,10),(193,10322,52,20),(194,10323,15,5),(195,10323,25,4),(196,10323,39,4),(197,10324,16,21),(198,10324,35,70),(199,10324,46,30),(200,10324,59,40),(201,10324,63,80),(202,10325,6,6),(203,10325,13,12),(204,10325,14,9),(205,10325,31,4),(206,10325,72,40),(207,10326,4,24),(208,10326,57,16),(209,10326,75,50),(210,10327,2,25),(211,10327,11,50),(212,10327,30,35),(213,10327,58,30),(214,10328,59,9),(215,10328,65,40),(216,10328,68,10),(217,10329,19,10),(218,10329,30,8),(219,10329,38,20),(220,10329,56,12),(221,10330,26,50),(222,10330,72,25),(223,10331,54,15),(224,10332,18,40),(225,10332,42,10),(226,10332,47,16),(227,10333,14,10),(228,10333,21,10),(229,10333,71,40),(230,10334,52,8),(231,10334,68,10),(232,10335,2,7),(233,10335,31,25),(234,10335,32,6),(235,10335,51,48),(236,10336,4,18),(237,10337,23,40),(238,10337,26,24),(239,10337,36,20),(240,10337,37,28),(241,10337,72,25),(242,10338,17,20),(243,10338,30,15),(244,10339,4,10),(245,10339,17,70),(246,10339,62,28),(247,10340,18,20),(248,10340,41,12),(249,10340,43,40),(250,10341,33,8),(251,10341,59,9),(252,10342,2,24),(253,10342,31,56),(254,10342,36,40),(255,10342,55,40),(256,10343,64,50),(257,10343,68,4),(258,10343,76,15),(259,10344,4,35),(260,10344,8,70),(261,10345,8,70),(262,10345,19,80),(263,10345,42,9),(264,10346,17,36),(265,10346,56,20),(266,10347,25,10),(267,10347,39,50),(268,10347,40,4),(269,10347,75,6),(270,10348,1,15),(271,10348,23,25),(272,10349,54,24),(273,10350,50,15),(274,10350,69,18),(275,10351,38,20),(276,10351,41,13),(277,10351,44,77),(278,10351,65,10),(279,10352,24,10),(280,10352,54,20),(281,10353,11,12),(282,10353,38,50),(283,10354,1,12),(284,10354,29,4),(285,10355,24,25),(286,10355,57,25),(287,10356,31,30),(288,10356,55,12),(289,10356,69,20),(290,10357,10,30),(291,10357,26,16),(292,10357,60,8),(293,10358,24,10),(294,10358,34,10),(295,10358,36,20),(296,10359,16,56),(297,10359,31,70),(298,10359,60,80),(299,10360,28,30),(300,10360,29,35),(301,10360,38,10),(302,10360,49,35),(303,10360,54,28),(304,10361,39,54),(305,10361,60,55),(306,10362,25,50),(307,10362,51,20),(308,10362,54,24),(309,10363,31,20),(310,10363,75,12),(311,10363,76,12),(312,10364,69,30),(313,10364,71,5),(314,10365,11,24),(315,10366,65,5),(316,10366,77,5),(317,10367,34,36),(318,10367,54,18),(319,10367,65,15),(320,10367,77,7),(321,10368,21,5),(322,10368,28,13),(323,10368,57,25),(324,10368,64,35),(325,10369,29,20),(326,10369,56,18),(327,10370,1,15),(328,10370,64,30),(329,10370,74,20),(330,10371,36,6),(331,10372,20,12),(332,10372,38,40),(333,10372,60,70),(334,10372,72,42),(335,10373,58,80),(336,10373,71,50),(337,10374,31,30),(338,10374,58,15),(339,10375,14,15),(340,10375,54,10),(341,10376,31,42),(342,10377,28,20),(343,10377,39,20),(344,10378,71,6),(345,10379,41,8),(346,10379,63,16),(347,10379,65,20),(348,10380,30,18),(349,10380,53,20),(350,10380,60,6),(351,10380,70,30),(352,10381,74,14),(353,10382,5,32),(354,10382,18,9),(355,10382,29,14),(356,10382,33,60),(357,10382,74,50),(358,10383,13,20),(359,10383,50,15),(360,10383,56,20),(361,10384,20,28),(362,10384,60,15),(363,10385,7,10),(364,10385,60,20),(365,10385,68,8),(366,10386,24,15),(367,10386,34,10),(368,10387,24,15),(369,10387,28,6),(370,10387,59,12),(371,10387,71,15),(372,10388,45,15),(373,10388,52,20),(374,10388,53,40),(375,10389,10,16),(376,10389,55,15),(377,10389,62,20),(378,10389,70,30),(379,10390,31,60),(380,10390,35,40),(381,10390,46,45),(382,10390,72,24),(383,10391,13,18),(384,10392,69,50),(385,10393,2,25),(386,10393,14,42),(387,10393,25,7),(388,10393,26,70),(389,10393,31,32),(390,10394,13,10),(391,10394,62,10),(392,10395,46,28),(393,10395,53,70),(394,10395,69,8),(395,10396,23,40),(396,10396,71,60),(397,10396,72,21),(398,10397,21,10),(399,10397,51,18),(400,10398,35,30),(401,10398,55,120),(402,10399,68,60),(403,10399,71,30),(404,10399,76,35),(405,10399,77,14),(406,10400,29,21),(407,10400,35,35),(408,10400,49,30),(409,10401,30,18),(410,10401,56,70),(411,10401,65,20),(412,10401,71,60),(413,10402,23,60),(414,10402,63,65),(415,10403,16,21),(416,10403,48,70),(417,10404,26,30),(418,10404,42,40),(419,10404,49,30),(420,10405,3,50),(421,10406,1,10),(422,10406,21,30),(423,10406,28,42),(424,10406,36,5),(425,10406,40,2),(426,10407,11,30),(427,10407,69,15),(428,10407,71,15),(429,10408,37,10),(430,10408,54,6),(431,10408,62,35),(432,10409,14,12),(433,10409,21,12),(434,10410,33,49),(435,10410,59,16),(436,10411,41,25),(437,10411,44,40),(438,10411,59,9),(439,10412,14,20),(440,10413,1,24),(441,10413,62,40),(442,10413,76,14),(443,10414,19,18),(444,10414,33,50),(445,10415,17,2),(446,10415,33,20),(447,10416,19,20),(448,10416,53,10),(449,10416,57,20),(450,10417,38,50),(451,10417,46,2),(452,10417,68,36),(453,10417,77,35),(454,10418,2,60),(455,10418,47,55),(456,10418,61,16),(457,10418,74,15),(458,10419,60,60),(459,10419,69,20),(460,10420,9,20),(461,10420,13,2),(462,10420,70,8),(463,10420,73,20),(464,10421,19,4),(465,10421,26,30),(466,10421,53,15),(467,10421,77,10),(468,10422,26,2),(469,10423,31,14),(470,10423,59,20),(471,10424,35,60),(472,10424,38,49),(473,10424,68,30),(474,10425,55,10),(475,10425,76,20),(476,10426,56,5),(477,10426,64,7),(478,10427,14,35),(479,10428,46,20),(480,10429,50,40),(481,10429,63,35),(482,10430,17,45),(483,10430,21,50),(484,10430,56,30),(485,10430,59,70),(486,10431,17,50),(487,10431,40,50),(488,10431,47,30),(489,10432,26,10),(490,10432,54,40),(491,10433,56,28),(492,10434,11,6),(493,10434,76,18),(494,10435,2,10),(495,10435,22,12),(496,10435,72,10),(497,10436,46,5),(498,10436,56,40),(499,10436,64,30),(500,10436,75,24),(501,10437,53,15),(502,10438,19,15),(503,10438,34,20),(504,10438,57,15),(505,10439,12,15),(506,10439,16,16),(507,10439,64,6),(508,10439,74,30),(509,10440,2,45),(510,10440,16,49),(511,10440,29,24),(512,10440,61,90),(513,10441,27,50),(514,10442,11,30),(515,10442,54,80),(516,10442,66,60),(517,10443,11,6),(518,10443,28,12);
/*!40000 ALTER TABLE `orderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `CustomerID` int DEFAULT NULL,
  `EmployeeID` int DEFAULT NULL,
  `OrderDate` datetime DEFAULT NULL,
  `ShipperID` int DEFAULT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `EmployeeID` (`EmployeeID`),
  KEY `CustomerID` (`CustomerID`),
  KEY `ShipperID` (`ShipperID`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employees` (`EmployeeID`),
  CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`CustomerID`) REFERENCES `customers` (`CustomerID`),
  CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`ShipperID`) REFERENCES `shippers` (`ShipperID`)
) ENGINE=InnoDB AUTO_INCREMENT=10444 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (10248,90,5,'1996-07-04 00:00:00',3),(10249,81,6,'1996-07-05 00:00:00',1),(10250,34,4,'1996-07-08 00:00:00',2),(10251,84,3,'1996-07-08 00:00:00',1),(10252,76,4,'1996-07-09 00:00:00',2),(10253,34,3,'1996-07-10 00:00:00',2),(10254,14,5,'1996-07-11 00:00:00',2),(10255,68,9,'1996-07-12 00:00:00',3),(10256,88,3,'1996-07-15 00:00:00',2),(10257,35,4,'1996-07-16 00:00:00',3),(10258,20,1,'1996-07-17 00:00:00',1),(10259,13,4,'1996-07-18 00:00:00',3),(10260,55,4,'1996-07-19 00:00:00',1),(10261,61,4,'1996-07-19 00:00:00',2),(10262,65,8,'1996-07-22 00:00:00',3),(10263,20,9,'1996-07-23 00:00:00',3),(10264,24,6,'1996-07-24 00:00:00',3),(10265,7,2,'1996-07-25 00:00:00',1),(10266,87,3,'1996-07-26 00:00:00',3),(10267,25,4,'1996-07-29 00:00:00',1),(10268,33,8,'1996-07-30 00:00:00',3),(10269,89,5,'1996-07-31 00:00:00',1),(10270,87,1,'1996-08-01 00:00:00',1),(10271,75,6,'1996-08-01 00:00:00',2),(10272,65,6,'1996-08-02 00:00:00',2),(10273,63,3,'1996-08-05 00:00:00',3),(10274,85,6,'1996-08-06 00:00:00',1),(10275,49,1,'1996-08-07 00:00:00',1),(10276,80,8,'1996-08-08 00:00:00',3),(10277,52,2,'1996-08-09 00:00:00',3),(10278,5,8,'1996-08-12 00:00:00',2),(10279,44,8,'1996-08-13 00:00:00',2),(10280,5,2,'1996-08-14 00:00:00',1),(10281,69,4,'1996-08-14 00:00:00',1),(10282,69,4,'1996-08-15 00:00:00',1),(10283,46,3,'1996-08-16 00:00:00',3),(10284,44,4,'1996-08-19 00:00:00',1),(10285,63,1,'1996-08-20 00:00:00',2),(10286,63,8,'1996-08-21 00:00:00',3),(10287,67,8,'1996-08-22 00:00:00',3),(10288,66,4,'1996-08-23 00:00:00',1),(10289,11,7,'1996-08-26 00:00:00',3),(10290,15,8,'1996-08-27 00:00:00',1),(10291,61,6,'1996-08-27 00:00:00',2),(10292,81,1,'1996-08-28 00:00:00',2),(10293,80,1,'1996-08-29 00:00:00',3),(10294,65,4,'1996-08-30 00:00:00',2),(10295,85,2,'1996-09-02 00:00:00',2),(10296,46,6,'1996-09-03 00:00:00',1),(10297,7,5,'1996-09-04 00:00:00',2),(10298,37,6,'1996-09-05 00:00:00',2),(10299,67,4,'1996-09-06 00:00:00',2),(10300,49,2,'1996-09-09 00:00:00',2),(10301,86,8,'1996-09-09 00:00:00',2),(10302,76,4,'1996-09-10 00:00:00',2),(10303,30,7,'1996-09-11 00:00:00',2),(10304,80,1,'1996-09-12 00:00:00',2),(10305,55,8,'1996-09-13 00:00:00',3),(10306,69,1,'1996-09-16 00:00:00',3),(10307,48,2,'1996-09-17 00:00:00',2),(10308,2,7,'1996-09-18 00:00:00',3),(10309,37,3,'1996-09-19 00:00:00',1),(10310,77,8,'1996-09-20 00:00:00',2),(10311,18,1,'1996-09-20 00:00:00',3),(10312,86,2,'1996-09-23 00:00:00',2),(10313,63,2,'1996-09-24 00:00:00',2),(10314,65,1,'1996-09-25 00:00:00',2),(10315,38,4,'1996-09-26 00:00:00',2),(10316,65,1,'1996-09-27 00:00:00',3),(10317,48,6,'1996-09-30 00:00:00',1),(10318,38,8,'1996-10-01 00:00:00',2),(10319,80,7,'1996-10-02 00:00:00',3),(10320,87,5,'1996-10-03 00:00:00',3),(10321,38,3,'1996-10-03 00:00:00',2),(10322,58,7,'1996-10-04 00:00:00',3),(10323,39,4,'1996-10-07 00:00:00',1),(10324,71,9,'1996-10-08 00:00:00',1),(10325,39,1,'1996-10-09 00:00:00',3),(10326,8,4,'1996-10-10 00:00:00',2),(10327,24,2,'1996-10-11 00:00:00',1),(10328,28,4,'1996-10-14 00:00:00',3),(10329,75,4,'1996-10-15 00:00:00',2),(10330,46,3,'1996-10-16 00:00:00',1),(10331,9,9,'1996-10-16 00:00:00',1),(10332,51,3,'1996-10-17 00:00:00',2),(10333,87,5,'1996-10-18 00:00:00',3),(10334,84,8,'1996-10-21 00:00:00',2),(10335,37,7,'1996-10-22 00:00:00',2),(10336,60,7,'1996-10-23 00:00:00',2),(10337,25,4,'1996-10-24 00:00:00',3),(10338,55,4,'1996-10-25 00:00:00',3),(10339,51,2,'1996-10-28 00:00:00',2),(10340,9,1,'1996-10-29 00:00:00',3),(10341,73,7,'1996-10-29 00:00:00',3),(10342,25,4,'1996-10-30 00:00:00',2),(10343,44,4,'1996-10-31 00:00:00',1),(10344,89,4,'1996-11-01 00:00:00',2),(10345,63,2,'1996-11-04 00:00:00',2),(10346,65,3,'1996-11-05 00:00:00',3),(10347,21,4,'1996-11-06 00:00:00',3),(10348,86,4,'1996-11-07 00:00:00',2),(10349,75,7,'1996-11-08 00:00:00',1),(10350,41,6,'1996-11-11 00:00:00',2),(10351,20,1,'1996-11-11 00:00:00',1),(10352,28,3,'1996-11-12 00:00:00',3),(10353,59,7,'1996-11-13 00:00:00',3),(10354,58,8,'1996-11-14 00:00:00',3),(10355,4,6,'1996-11-15 00:00:00',1),(10356,86,6,'1996-11-18 00:00:00',2),(10357,46,1,'1996-11-19 00:00:00',3),(10358,41,5,'1996-11-20 00:00:00',1),(10359,72,5,'1996-11-21 00:00:00',3),(10360,7,4,'1996-11-22 00:00:00',3),(10361,63,1,'1996-11-22 00:00:00',2),(10362,9,3,'1996-11-25 00:00:00',1),(10363,17,4,'1996-11-26 00:00:00',3),(10364,19,1,'1996-11-26 00:00:00',1),(10365,3,3,'1996-11-27 00:00:00',2),(10366,29,8,'1996-11-28 00:00:00',2),(10367,83,7,'1996-11-28 00:00:00',3),(10368,20,2,'1996-11-29 00:00:00',2),(10369,75,8,'1996-12-02 00:00:00',2),(10370,14,6,'1996-12-03 00:00:00',2),(10371,41,1,'1996-12-03 00:00:00',1),(10372,62,5,'1996-12-04 00:00:00',2),(10373,37,4,'1996-12-05 00:00:00',3),(10374,91,1,'1996-12-05 00:00:00',3),(10375,36,3,'1996-12-06 00:00:00',2),(10376,51,1,'1996-12-09 00:00:00',2),(10377,72,1,'1996-12-09 00:00:00',3),(10378,24,5,'1996-12-10 00:00:00',3),(10379,61,2,'1996-12-11 00:00:00',1),(10380,37,8,'1996-12-12 00:00:00',3),(10381,46,3,'1996-12-12 00:00:00',3),(10382,20,4,'1996-12-13 00:00:00',1),(10383,4,8,'1996-12-16 00:00:00',3),(10384,5,3,'1996-12-16 00:00:00',3),(10385,75,1,'1996-12-17 00:00:00',2),(10386,21,9,'1996-12-18 00:00:00',3),(10387,70,1,'1996-12-18 00:00:00',2),(10388,72,2,'1996-12-19 00:00:00',1),(10389,10,4,'1996-12-20 00:00:00',2),(10390,20,6,'1996-12-23 00:00:00',1),(10391,17,3,'1996-12-23 00:00:00',3),(10392,59,2,'1996-12-24 00:00:00',3),(10393,71,1,'1996-12-25 00:00:00',3),(10394,36,1,'1996-12-25 00:00:00',3),(10395,35,6,'1996-12-26 00:00:00',1),(10396,25,1,'1996-12-27 00:00:00',3),(10397,60,5,'1996-12-27 00:00:00',1),(10398,71,2,'1996-12-30 00:00:00',3),(10399,83,8,'1996-12-31 00:00:00',3),(10400,19,1,'1997-01-01 00:00:00',3),(10401,65,1,'1997-01-01 00:00:00',1),(10402,20,8,'1997-01-02 00:00:00',2),(10403,20,4,'1997-01-03 00:00:00',3),(10404,49,2,'1997-01-03 00:00:00',1),(10405,47,1,'1997-01-06 00:00:00',1),(10406,62,7,'1997-01-07 00:00:00',1),(10407,56,2,'1997-01-07 00:00:00',2),(10408,23,8,'1997-01-08 00:00:00',1),(10409,54,3,'1997-01-09 00:00:00',1),(10410,10,3,'1997-01-10 00:00:00',3),(10411,10,9,'1997-01-10 00:00:00',3),(10412,87,8,'1997-01-13 00:00:00',2),(10413,41,3,'1997-01-14 00:00:00',2),(10414,21,2,'1997-01-14 00:00:00',3),(10415,36,3,'1997-01-15 00:00:00',1),(10416,87,8,'1997-01-16 00:00:00',3),(10417,73,4,'1997-01-16 00:00:00',3),(10418,63,4,'1997-01-17 00:00:00',1),(10419,68,4,'1997-01-20 00:00:00',2),(10420,88,3,'1997-01-21 00:00:00',1),(10421,61,8,'1997-01-21 00:00:00',1),(10422,27,2,'1997-01-22 00:00:00',1),(10423,31,6,'1997-01-23 00:00:00',3),(10424,51,7,'1997-01-23 00:00:00',2),(10425,41,6,'1997-01-24 00:00:00',2),(10426,29,4,'1997-01-27 00:00:00',1),(10427,59,4,'1997-01-27 00:00:00',2),(10428,66,7,'1997-01-28 00:00:00',1),(10429,37,3,'1997-01-29 00:00:00',2),(10430,20,4,'1997-01-30 00:00:00',1),(10431,10,4,'1997-01-30 00:00:00',2),(10432,75,3,'1997-01-31 00:00:00',2),(10433,60,3,'1997-02-03 00:00:00',3),(10434,24,3,'1997-02-03 00:00:00',2),(10435,16,8,'1997-02-04 00:00:00',2),(10436,7,3,'1997-02-05 00:00:00',2),(10437,87,8,'1997-02-05 00:00:00',1),(10438,79,3,'1997-02-06 00:00:00',2),(10439,51,6,'1997-02-07 00:00:00',3),(10440,71,4,'1997-02-10 00:00:00',2),(10441,55,3,'1997-02-10 00:00:00',2),(10442,20,3,'1997-02-11 00:00:00',2),(10443,66,8,'1997-02-12 00:00:00',1);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `ProductID` int NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(50) DEFAULT NULL,
  `SupplierID` int DEFAULT NULL,
  `CategoryID` int DEFAULT NULL,
  `Unit` varchar(25) DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`ProductID`),
  KEY `CategoryID` (`CategoryID`),
  KEY `SupplierID` (`SupplierID`),
  CONSTRAINT `products_ibfk_1` FOREIGN KEY (`CategoryID`) REFERENCES `categories` (`CategoryID`),
  CONSTRAINT `products_ibfk_2` FOREIGN KEY (`SupplierID`) REFERENCES `suppliers` (`SupplierID`)
) ENGINE=InnoDB AUTO_INCREMENT=78 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Chais',1,1,'10 boxes x 20 bags',18),(2,'Chang',1,1,'24 - 12 oz bottles',19),(3,'Aniseed Syrup',1,2,'12 - 550 ml bottles',10),(4,'Chef Anton\'s Cajun Seasoning',2,2,'48 - 6 oz jars',22),(5,'Chef Anton\'s Gumbo Mix',2,2,'36 boxes',21),(6,'Grandma\'s Boysenberry Spread',3,2,'12 - 8 oz jars',25),(7,'Uncle Bob\'s Organic Dried Pears',3,7,'12 - 1 lb pkgs.',30),(8,'Northwoods Cranberry Sauce',3,2,'12 - 12 oz jars',40),(9,'Mishi Kobe Niku',4,6,'18 - 500 g pkgs.',97),(10,'Ikura',4,8,'12 - 200 ml jars',31),(11,'Queso Cabrales',5,4,'1 kg pkg.',21),(12,'Queso Manchego La Pastora',5,4,'10 - 500 g pkgs.',38),(13,'Konbu',6,8,'2 kg box',6),(14,'Tofu',6,7,'40 - 100 g pkgs.',23),(15,'Genen Shouyu',6,2,'24 - 250 ml bottles',16),(16,'Pavlova',7,3,'32 - 500 g boxes',17),(17,'Alice Mutton',7,6,'20 - 1 kg tins',39),(18,'Carnarvon Tigers',7,8,'16 kg pkg.',63),(19,'Teatime Chocolate Biscuits',8,3,'10 boxes x 12 pieces',9),(20,'Sir Rodney\'s Marmalade',8,3,'30 gift boxes',81),(21,'Sir Rodney\'s Scones',8,3,'24 pkgs. x 4 pieces',10),(22,'Gustaf\'s Knäckebröd',9,5,'24 - 500 g pkgs.',21),(23,'Tunnbröd',9,5,'12 - 250 g pkgs.',9),(24,'Guaraná Fantástica',10,1,'12 - 355 ml cans',5),(25,'NuNuCa Nuß-Nougat-Creme',11,3,'20 - 450 g glasses',14),(26,'Gumbär Gummibärchen',11,3,'100 - 250 g bags',31),(27,'Schoggi Schokolade',11,3,'100 - 100 g pieces',44),(28,'Rössle Sauerkraut',12,7,'25 - 825 g cans',46),(29,'Thüringer Rostbratwurst',12,6,'50 bags x 30 sausgs.',124),(30,'Nord-Ost Matjeshering',13,8,'10 - 200 g glasses',26),(31,'Gorgonzola Telino',14,4,'12 - 100 g pkgs',13),(32,'Mascarpone Fabioli',14,4,'24 - 200 g pkgs.',32),(33,'Geitost',15,4,'500 g',3),(34,'Sasquatch Ale',16,1,'24 - 12 oz bottles',14),(35,'Steeleye Stout',16,1,'24 - 12 oz bottles',18),(36,'Inlagd Sill',17,8,'24 - 250 g jars',19),(37,'Gravad lax',17,8,'12 - 500 g pkgs.',26),(38,'Côte de Blaye',18,1,'12 - 75 cl bottles',264),(39,'Chartreuse verte',18,1,'750 cc per bottle',18),(40,'Boston Crab Meat',19,8,'24 - 4 oz tins',18),(41,'Jack\'s New England Clam Chowder',19,8,'12 - 12 oz cans',10),(42,'Singaporean Hokkien Fried Mee',20,5,'32 - 1 kg pkgs.',14),(43,'Ipoh Coffee',20,1,'16 - 500 g tins',46),(44,'Gula Malacca',20,2,'20 - 2 kg bags',19),(45,'Røgede sild',21,8,'1k pkg.',10),(46,'Spegesild',21,8,'4 - 450 g glasses',12),(47,'Zaanse koeken',22,3,'10 - 4 oz boxes',10),(48,'Chocolade',22,3,'10 pkgs.',13),(49,'Maxilaku',23,3,'24 - 50 g pkgs.',20),(50,'Valkoinen suklaa',23,3,'12 - 100 g bars',16),(51,'Manjimup Dried Apples',24,7,'50 - 300 g pkgs.',53),(52,'Filo Mix',24,5,'16 - 2 kg boxes',7),(53,'Perth Pasties',24,6,'48 pieces',33),(54,'Tourtière',25,6,'16 pies',7),(55,'Pâté chinois',25,6,'24 boxes x 2 pies',24),(56,'Gnocchi di nonna Alice',26,5,'24 - 250 g pkgs.',38),(57,'Ravioli Angelo',26,5,'24 - 250 g pkgs.',20),(58,'Escargots de Bourgogne',27,8,'24 pieces',13),(59,'Raclette Courdavault',28,4,'5 kg pkg.',55),(60,'Camembert Pierrot',28,4,'15 - 300 g rounds',34),(61,'Sirop d\'érable',29,2,'24 - 500 ml bottles',29),(62,'Tarte au sucre',29,3,'48 pies',49),(63,'Vegie-spread',7,2,'15 - 625 g jars',44),(64,'Wimmers gute Semmelknödel',12,5,'20 bags x 4 pieces',33),(65,'Louisiana Fiery Hot Pepper Sauce',2,2,'32 - 8 oz bottles',21),(66,'Louisiana Hot Spiced Okra',2,2,'24 - 8 oz jars',17),(67,'Laughing Lumberjack Lager',16,1,'24 - 12 oz bottles',14),(68,'Scottish Longbreads',8,3,'10 boxes x 8 pieces',13),(69,'Gudbrandsdalsost',15,4,'10 kg pkg.',36),(70,'Outback Lager',7,1,'24 - 355 ml bottles',15),(71,'Fløtemysost',15,4,'10 - 500 g pkgs.',22),(72,'Mozzarella di Giovanni',14,4,'24 - 200 g pkgs.',35),(73,'Röd Kaviar',17,8,'24 - 150 g jars',15),(74,'Longlife Tofu',4,7,'5 kg pkg.',10),(75,'Rhönbräu Klosterbier',12,1,'24 - 0.5 l bottles',8),(76,'Lakkalikööri',23,1,'500 ml',18),(77,'Original Frankfurter grüne Soße',12,2,'12 boxes',13);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shippers`
--

DROP TABLE IF EXISTS `shippers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shippers` (
  `ShipperID` int NOT NULL AUTO_INCREMENT,
  `ShipperName` varchar(25) DEFAULT NULL,
  `Phone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`ShipperID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shippers`
--

LOCK TABLES `shippers` WRITE;
/*!40000 ALTER TABLE `shippers` DISABLE KEYS */;
INSERT INTO `shippers` VALUES (1,'Speedy Express','(503) 555-9831'),(2,'United Package','(503) 555-3199'),(3,'Federal Shipping','(503) 555-9931');
/*!40000 ALTER TABLE `shippers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `SupplierID` int NOT NULL AUTO_INCREMENT,
  `SupplierName` varchar(50) DEFAULT NULL,
  `ContactName` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `City` varchar(20) DEFAULT NULL,
  `PostalCode` varchar(10) DEFAULT NULL,
  `Country` varchar(15) DEFAULT NULL,
  `Phone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'Exotic Liquid','Charlotte Cooper','49 Gilbert St.','Londona','EC1 4SD','UK','(171) 555-2222'),(2,'New Orleans Cajun Delights','Shelley Burke','P.O. Box 78934','New Orleans','70117','USA','(100) 555-4822'),(3,'Grandma Kelly\'s Homestead','Regina Murphy','707 Oxford Rd.','Ann Arbor','48104','USA','(313) 555-5735'),(4,'Tokyo Traders','Yoshi Nagase','9-8 Sekimai Musashino-shi','Tokyo','100','Japan','(03) 3555-5011'),(5,'Cooperativa de Quesos \'Las Cabras\'','Antonio del Valle Saavedra','Calle del Rosal 4','Oviedo','33007','Spain','(98) 598 76 54'),(6,'Mayumi\'s','Mayumi Ohno','92 Setsuko Chuo-ku','Osaka','545','Japan','(06) 431-7877'),(7,'Pavlova, Ltd.','Ian Devling','74 Rose St. Moonie Ponds','Melbourne','3058','Australia','(03) 444-2343'),(8,'Specialty Biscuits, Ltd.','Peter Wilson','29 King\'s Way','Manchester','M14 GSD','UK','(161) 555-4448'),(9,'PB Knäckebröd AB','Lars Peterson','Kaloadagatan 13','Göteborg','S-345 67','Sweden','031-987 65 43'),(10,'Refrescos Americanas LTDA','Carlos Diaz','Av. das Americanas 12.890','São Paulo','5442','Brazil','(11) 555 4640'),(11,'Heli Süßwaren GmbH & Co. KG','Petra Winkler','Tiergartenstraße 5','Berlin','10785','Germany','(010) 9984510'),(12,'Plutzer Lebensmittelgroßmärkte AG','Martin Bein','Bogenallee 51','Frankfurt','60439','Germany','(069) 992755'),(13,'Nord-Ost-Fisch Handelsgesellschaft mbH','Sven Petersen','Frahmredder 112a','Cuxhaven','27478','Germany','(04721) 8713'),(14,'Formaggi Fortini s.r.l.','Elio Rossi','Viale Dante, 75','Ravenna','48100','Italy','(0544) 60323'),(15,'Norske Meierier','Beate Vileid','Hatlevegen 5','Sandvika','1320','Norway','(0)2-953010'),(16,'Bigfoot Breweries','Cheryl Saylor','3400 - 8th Avenue Suite 210','Bend','97101','USA','(503) 555-9931'),(17,'Svensk Sjöföda AB','Michael Björn','Brovallavägen 231','Stockholm','S-123 45','Sweden','08-123 45 67'),(18,'Aux joyeux ecclésiastiques','Guylène Nodier','203, Rue des Francs-Bourgeois','Paris','75004','France','(1) 03.83.00.68'),(19,'New England Seafood Cannery','Robb Merchant','Order Processing Dept. 2100 Paul Revere Blvd.','Boston','2134','USA','(617) 555-3267'),(20,'Leka Trading','Chandra Leka','471 Serangoon Loop, Suite #402','Singapore','512','Singapore','555-8787'),(21,'Lyngbysild','Niels Petersen','Lyngbysild Fiskebakken 10','Lyngby','2800','Denmark','43844108'),(22,'Zaanse Snoepfabriek','Dirk Luchte','Verkoop Rijnweg 22','Zaandam','9999 ZZ','Netherlands','(12345) 1212'),(23,'Karkki Oy','Anne Heikkonen','Valtakatu 12','Lappeenranta','53120','Finland','(953) 10956'),(24,'G\'day, Mate','Wendy Mackenzie','170 Prince Edward Parade Hunter\'s Hill','Sydney','2042','Australia','(02) 555-5914'),(25,'Ma Maison','Jean-Guy Lauzon','2960 Rue St. Laurent','Montréal','H1J 1C3','Canada','(514) 555-9022'),(26,'Pasta Buttini s.r.l.','Giovanni Giudici','Via dei Gelsomini, 153','Salerno','84100','Italy','(089) 6547665'),(27,'Escargots Nouveaux','Marie Delamare','22, rue H. Voiron','Montceau','71300','France','85.57.00.07'),(28,'Gai pâturage','Eliane Noz','Bat. B 3, rue des Alpes','Annecy','74000','France','38.76.98.06'),(29,'Forêts d\'érables','Chantal Goulet','148 rue Chasseur','Ste-Hyacinthe','J2S 7S8','Canada','(514) 555-2955');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-13  0:04:13
-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: localhost    Database: northwind_dummy
-- ------------------------------------------------------
-- Server version	8.0.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `CategoryID` int NOT NULL AUTO_INCREMENT,
  `CategoryName` varchar(25) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CategoryID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Organic Produce','Fresh farm-to-table fruits and vegetables'),(2,'Artisanal Bakery','Small-batch rustic breads and pastries'),(3,'Eco-Friendly Cleaners','Plant-based commercial cleaning solutions'),(4,'Herbal Infusions','Loose-leaf teas and botanical blends');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `CustomerID` int NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(50) DEFAULT NULL,
  `ContactName` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `City` varchar(20) DEFAULT NULL,
  `PostalCode` varchar(10) DEFAULT NULL,
  `Country` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`CustomerID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'Alpha Retail Group','Sarah Jenkins','452 Innovation Way','Austin','78701','USA'),(2,'Vortex Wholesale','Marcus Miller','88 Titanium Blvd','Manchester','M1 1AE','UK'),(3,'Aura Wellness Corp','Elena Rostova','712 Birch Avenue','Munich','80331','Germany'),(4,'Prism Ventures','Chloe Dubois','14 Rue de la Paix','Paris','75002','France');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `EmployeeID` int NOT NULL AUTO_INCREMENT,
  `LastName` varchar(15) DEFAULT NULL,
  `FirstName` varchar(15) DEFAULT NULL,
  `BirthDate` datetime DEFAULT NULL,
  `Photo` varchar(25) DEFAULT NULL,
  `Notes` varchar(1024) DEFAULT NULL,
  PRIMARY KEY (`EmployeeID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'Sterling','Eleanor','1985-04-12 00:00:00','emp1_sterling.png','Specializes in international accounts and logistics.'),(2,'Garrison','Tyler','1990-11-23 00:00:00','emp2_garrison.png','Manages regional retail distribution.'),(3,'Vance','Sofia','1994-07-08 00:00:00','emp3_vance.png','Focuses on e-commerce client success.');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderdetails`
--

DROP TABLE IF EXISTS `orderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderdetails` (
  `OrderDetailID` int NOT NULL AUTO_INCREMENT,
  `OrderID` int DEFAULT NULL,
  `ProductID` int DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  PRIMARY KEY (`OrderDetailID`),
  KEY `OrderID` (`OrderID`),
  KEY `ProductID` (`ProductID`),
  CONSTRAINT `orderdetails_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderID`),
  CONSTRAINT `orderdetails_ibfk_2` FOREIGN KEY (`ProductID`) REFERENCES `products` (`ProductID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderdetails`
--

LOCK TABLES `orderdetails` WRITE;
/*!40000 ALTER TABLE `orderdetails` DISABLE KEYS */;
INSERT INTO `orderdetails` VALUES (1,1001,1,5),(2,1001,2,2),(3,1002,3,12),(4,1003,4,10),(5,1004,5,25),(6,1004,1,3);
/*!40000 ALTER TABLE `orderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `CustomerID` int DEFAULT NULL,
  `EmployeeID` int DEFAULT NULL,
  `OrderDate` datetime DEFAULT NULL,
  `ShipperID` int DEFAULT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `EmployeeID` (`EmployeeID`),
  KEY `CustomerID` (`CustomerID`),
  KEY `ShipperID` (`ShipperID`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employees` (`EmployeeID`),
  CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`CustomerID`) REFERENCES `customers` (`CustomerID`),
  CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`ShipperID`) REFERENCES `shippers` (`ShipperID`)
) ENGINE=InnoDB AUTO_INCREMENT=1005 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1001,1,2,'2026-05-01 10:30:00',1),(1002,2,2,'2026-05-12 14:15:00',2),(1003,3,3,'2026-05-28 09:00:00',3),(1004,4,1,'2026-06-02 16:45:00',1);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `ProductID` int NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(50) DEFAULT NULL,
  `SupplierID` int DEFAULT NULL,
  `CategoryID` int DEFAULT NULL,
  `Unit` varchar(25) DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`ProductID`),
  KEY `CategoryID` (`CategoryID`),
  KEY `SupplierID` (`SupplierID`),
  CONSTRAINT `products_ibfk_1` FOREIGN KEY (`CategoryID`) REFERENCES `categories` (`CategoryID`),
  CONSTRAINT `products_ibfk_2` FOREIGN KEY (`SupplierID`) REFERENCES `suppliers` (`SupplierID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Glacier Raw Honey',1,2,'12 - 500g jars',19),(2,'Crimson Crisp Apples',1,1,'20 kg crate',32),(3,'Cold-Pressed Olive Oil',2,2,'6 - 750ml bottles',43),(4,'Eucalyptus Multi-Surface',3,3,'4 - 1 Gallon jugs',25),(5,'Chamomile Lavender Blend',2,4,'24 boxes x 20 bags',15);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shippers`
--

DROP TABLE IF EXISTS `shippers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shippers` (
  `ShipperID` int NOT NULL AUTO_INCREMENT,
  `ShipperName` varchar(25) DEFAULT NULL,
  `Phone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`ShipperID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shippers`
--

LOCK TABLES `shippers` WRITE;
/*!40000 ALTER TABLE `shippers` DISABLE KEYS */;
INSERT INTO `shippers` VALUES (1,'Apex Freight Systems','(555) 019-2834'),(2,'Pricelocity Couriers','(555) 014-9922'),(3,'prieanic Bulk Cargo','(555) 017-8811');
/*!40000 ALTER TABLE `shippers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `SupplierID` int NOT NULL AUTO_INCREMENT,
  `SupplierName` varchar(50) DEFAULT NULL,
  `ContactName` varchar(50) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `City` varchar(20) DEFAULT NULL,
  `PostalCode` varchar(10) DEFAULT NULL,
  `Country` varchar(15) DEFAULT NULL,
  `Phone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'Summit Agro Labs','David Vance','109 Peak Ridge Road','Calgary','T2P 2M1','Canada','(403) 555-8121'),(2,'Nova Botanicals','Clara Rossi','8 Via Fontana','Milan','20121','Italy','02 8842 1192'),(3,'Zephyr Processing','Arthur Pendelton','55 Industrial Estates','Cork','T12 X8R','Ireland','021 496 1100');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-13  0:04:14
-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: localhost    Database: dublinbikes_dummy
-- ------------------------------------------------------
-- Server version	8.0.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bike_rentals`
--

DROP TABLE IF EXISTS `bike_rentals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bike_rentals` (
  `Rental_ID` int NOT NULL,
  `Customer_ID` int NOT NULL,
  `Bike_ID` int NOT NULL,
  `Payment_ID` int NOT NULL,
  `Station_ID` int NOT NULL,
  `Start_Time` varchar(50) NOT NULL,
  `End_Time` varchar(50) NOT NULL,
  `Start_Station` int NOT NULL,
  `End_Station` int NOT NULL,
  PRIMARY KEY (`Rental_ID`),
  KEY `Bike_FK_rent` (`Bike_ID`),
  KEY `Customer_FK_rent` (`Customer_ID`),
  KEY `Payment_FK_rent` (`Payment_ID`),
  KEY `Station_FK_rent` (`Station_ID`),
  CONSTRAINT `Bike_FK_rent` FOREIGN KEY (`Bike_ID`) REFERENCES `bikes` (`Bike_ID`),
  CONSTRAINT `Customer_FK_rent` FOREIGN KEY (`Customer_ID`) REFERENCES `customers` (`Customer_ID`),
  CONSTRAINT `Payment_FK_rent` FOREIGN KEY (`Payment_ID`) REFERENCES `payments` (`Payment_ID`),
  CONSTRAINT `Station_FK_rent` FOREIGN KEY (`Station_ID`) REFERENCES `stations` (`Station_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bike_rentals`
--

LOCK TABLES `bike_rentals` WRITE;
/*!40000 ALTER TABLE `bike_rentals` DISABLE KEYS */;
INSERT INTO `bike_rentals` VALUES (5001,4001,2001,801,101,'2026-05-10 14:30:00','2026-05-10 15:15:00',101,102),(5002,4002,2003,802,102,'2026-05-15 09:10:00','2026-05-15 09:35:00',102,102),(5003,4003,2004,803,103,'2026-05-20 18:15:00','2026-05-20 19:05:00',103,104);
/*!40000 ALTER TABLE `bike_rentals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bike_status`
--

DROP TABLE IF EXISTS `bike_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bike_status` (
  `B_Status_ID` int NOT NULL,
  `Bike_ID` int NOT NULL,
  `B_Status` varchar(40) NOT NULL DEFAULT 'Operational',
  `Last_Station` int NOT NULL DEFAULT '0',
  `Distance` decimal(10,2) NOT NULL DEFAULT '10.00',
  `Mileage` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`B_Status_ID`),
  KEY `Bike_FK_status` (`Bike_ID`),
  CONSTRAINT `Bike_FK_status` FOREIGN KEY (`Bike_ID`) REFERENCES `bikes` (`Bike_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bike_status`
--

LOCK TABLES `bike_status` WRITE;
/*!40000 ALTER TABLE `bike_status` DISABLE KEYS */;
INSERT INTO `bike_status` VALUES (601,2001,'Operational',101,4.20,145.80),(602,2002,'Operational',101,8.50,312.10),(603,2003,'Requires Repair',102,1.10,89.40),(604,2004,'Operational',103,12.00,24.50),(605,2005,'In Transit',104,0.00,415.00);
/*!40000 ALTER TABLE `bike_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bikes`
--

DROP TABLE IF EXISTS `bikes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bikes` (
  `Bike_ID` int NOT NULL,
  `Station_ID` int NOT NULL,
  `Model` date NOT NULL,
  PRIMARY KEY (`Bike_ID`),
  KEY `Station_FK_bikes` (`Station_ID`),
  CONSTRAINT `Station_FK_bikes` FOREIGN KEY (`Station_ID`) REFERENCES `stations` (`Station_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bikes`
--

LOCK TABLES `bikes` WRITE;
/*!40000 ALTER TABLE `bikes` DISABLE KEYS */;
INSERT INTO `bikes` VALUES (2001,101,'2022-03-15'),(2002,101,'2022-03-15'),(2003,102,'2023-07-20'),(2004,103,'2024-05-11'),(2005,103,'2025-01-18');
/*!40000 ALTER TABLE `bikes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_details`
--

DROP TABLE IF EXISTS `customer_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer_details` (
  `Customer_ID` int NOT NULL,
  `Lname` varchar(40) NOT NULL,
  `Fname` varchar(40) NOT NULL,
  `Address` varchar(40) NOT NULL,
  `County` varchar(40) NOT NULL,
  `DOB` date DEFAULT NULL,
  `Joined` date NOT NULL,
  PRIMARY KEY (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_details`
--

LOCK TABLES `customer_details` WRITE;
/*!40000 ALTER TABLE `customer_details` DISABLE KEYS */;
INSERT INTO `customer_details` VALUES (4001,'O\'Connor','Liam','12 George\'s Street','Dublin','1992-05-14','2024-01-10'),(4002,'Murphy','Aoife','44 Rathmines Road','Dublin','1995-11-22','2024-02-15'),(4003,'Byrne','Sean','88 Malahide Road','Dublin','1988-08-03','2024-03-01'),(4004,'Doyle','Ciara','105 Clontarf Strand','Dublin','2001-02-27','2024-04-12');
/*!40000 ALTER TABLE `customer_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `Customer_ID` int NOT NULL,
  `Username` varchar(40) NOT NULL,
  `Pass_word` varchar(40) NOT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Customer_ID`),
  CONSTRAINT `FK__Customers__Custo__5AEE82B9` FOREIGN KEY (`Customer_ID`) REFERENCES `customer_details` (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (4001,'liam_oc','p@ssword123','liam.oc@email.ie','+353831112222'),(4002,'aoife_m','secure_bik3','aoife.murphy@email.com','+353852223333'),(4003,'sean_b','dublin_rider','s.byrne@webmail.ie','+353863334444'),(4004,'ciara_d','clontarf2026','ciaradoyle@email.ie','+353874445555');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `old_staff`
--

DROP TABLE IF EXISTS `old_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `old_staff` (
  `Old_Staff_ID` int NOT NULL,
  `Staff_ID` int NOT NULL,
  `Lname` varchar(40) NOT NULL,
  `Fname` varchar(40) NOT NULL,
  `Address` varchar(40) NOT NULL,
  `County` varchar(40) NOT NULL,
  `Phone` varchar(40) NOT NULL,
  `DOB` date NOT NULL,
  `Joined` date NOT NULL,
  PRIMARY KEY (`Old_Staff_ID`),
  KEY `Staff_FK_OLD` (`Staff_ID`),
  CONSTRAINT `Staff_FK_OLD` FOREIGN KEY (`Staff_ID`) REFERENCES `staff` (`Staff_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `old_staff`
--

LOCK TABLES `old_staff` WRITE;
/*!40000 ALTER TABLE `old_staff` DISABLE KEYS */;
INSERT INTO `old_staff` VALUES (901,503,'Brady','James','14 Dame Street','Dublin','+353891234555','1980-03-11','2019-02-10');
/*!40000 ALTER TABLE `old_staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment_method`
--

DROP TABLE IF EXISTS `payment_method`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment_method` (
  `Method_ID` int NOT NULL,
  `Method` varchar(40) NOT NULL,
  `Account_No` varchar(40) NOT NULL,
  `Bank` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Subscription` varchar(50) NOT NULL,
  PRIMARY KEY (`Method_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment_method`
--

LOCK TABLES `payment_method` WRITE;
/*!40000 ALTER TABLE `payment_method` DISABLE KEYS */;
INSERT INTO `payment_method` VALUES (301,'Credit Card','IE99BOFI90000123456789','Bank of Ireland','Baggot Street, Dublin 2','Annual Leap Premium'),(302,'Debit Card','IE88AIBK93000098765432','Allied Irish Banks','O\'Connell Street, Dublin 1','3-Day Explorer'),(303,'Digital Wallet','IE77ULSB95000045612378','Permanent TSB','Henry Street, Dublin 1','Annual Standard');
/*!40000 ALTER TABLE `payment_method` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payments` (
  `Payment_ID` int NOT NULL,
  `Customer_ID` int NOT NULL,
  `Method_ID` int NOT NULL,
  `Rate` decimal(10,2) NOT NULL,
  `Date_stamp` date NOT NULL,
  `Time_stamp` varchar(50) NOT NULL,
  `Amount` decimal(7,2) NOT NULL,
  PRIMARY KEY (`Payment_ID`),
  KEY `Payments_FK_customer` (`Customer_ID`),
  KEY `Payments_FK_method` (`Method_ID`),
  CONSTRAINT `Payments_FK_customer` FOREIGN KEY (`Customer_ID`) REFERENCES `customers` (`Customer_ID`),
  CONSTRAINT `Payments_FK_method` FOREIGN KEY (`Method_ID`) REFERENCES `payment_method` (`Method_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (801,4001,301,3.50,'2026-05-10','14:23:11',35.00),(802,4002,302,5.00,'2026-05-15','09:05:44',5.00),(803,4003,301,3.50,'2026-05-20','18:12:02',12.50),(804,4004,303,0.00,'2026-06-01','11:34:50',0.00);
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `repairs`
--

DROP TABLE IF EXISTS `repairs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `repairs` (
  `Repair_ID` int NOT NULL,
  `B_Status_ID` int NOT NULL,
  `Staff_ID` int NOT NULL,
  `Delivered` date NOT NULL,
  `Price` decimal(9,2) NOT NULL,
  `Parts` int NOT NULL,
  PRIMARY KEY (`Repair_ID`),
  KEY `B_Status_FK_repair` (`B_Status_ID`),
  KEY `Staff_FK_repair` (`Staff_ID`),
  CONSTRAINT `B_Status_FK_repair` FOREIGN KEY (`B_Status_ID`) REFERENCES `bike_status` (`B_Status_ID`),
  CONSTRAINT `Staff_FK_repair` FOREIGN KEY (`Staff_ID`) REFERENCES `staff` (`Staff_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `repairs`
--

LOCK TABLES `repairs` WRITE;
/*!40000 ALTER TABLE `repairs` DISABLE KEYS */;
INSERT INTO `repairs` VALUES (1101,603,503,'2026-06-03',45.50,2);
/*!40000 ALTER TABLE `repairs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `Staff_ID` int NOT NULL,
  `Lname` varchar(40) NOT NULL,
  `Fname` varchar(40) NOT NULL,
  `Address` varchar(40) NOT NULL,
  `County` varchar(40) NOT NULL,
  `Phone` varchar(40) NOT NULL,
  `DOB` date NOT NULL,
  `Joined` date NOT NULL,
  PRIMARY KEY (`Staff_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (501,'Walsh','Darragh','3 Albany Mews','Dublin','+353871234567','1984-06-15','2021-05-01'),(502,'Kennedy','Niamh','17 Custom House Quay','Dublin','+353869876543','1990-09-30','2022-08-15'),(503,'Gallagher','Eoin','52 Phibsborough Road','Dublin','+353855554433','1993-01-20','2023-11-10');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `station_status`
--

DROP TABLE IF EXISTS `station_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `station_status` (
  `S_Status_ID` int NOT NULL,
  `Station_ID` int NOT NULL,
  `S_Status` varchar(40) NOT NULL,
  `Capacity` int NOT NULL,
  `Parking` int NOT NULL,
  `Bikes` int NOT NULL,
  `Updated` datetime(6) NOT NULL,
  PRIMARY KEY (`S_Status_ID`),
  KEY `Station_FK` (`Station_ID`),
  CONSTRAINT `Station_FK` FOREIGN KEY (`Station_ID`) REFERENCES `stations` (`Station_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `station_status`
--

LOCK TABLES `station_status` WRITE;
/*!40000 ALTER TABLE `station_status` DISABLE KEYS */;
INSERT INTO `station_status` VALUES (701,101,'Full Service',30,12,18,'2026-06-03 18:45:00.000000'),(702,102,'Full Service',20,15,5,'2026-06-03 19:10:00.000000'),(703,103,'Full Service',40,2,38,'2026-06-03 19:20:00.000000'),(704,104,'Maintenance Mode',25,25,0,'2026-06-03 16:30:00.000000');
/*!40000 ALTER TABLE `station_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stations`
--

DROP TABLE IF EXISTS `stations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stations` (
  `Station_ID` int NOT NULL,
  `Location` varchar(40) NOT NULL,
  `Address` varchar(40) NOT NULL,
  `Latitude` decimal(9,6) NOT NULL,
  `Longitude` decimal(9,6) NOT NULL,
  `Banking` tinyint(1) NOT NULL,
  PRIMARY KEY (`Station_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stations`
--

LOCK TABLES `stations` WRITE;
/*!40000 ALTER TABLE `stations` DISABLE KEYS */;
INSERT INTO `stations` VALUES (101,'Smithfield Square','Smithfield, Dublin 7',53.348200,-6.277800,1),(102,'Parnell Square','Parnell Street, Dublin 1',53.353400,-6.264500,0),(103,'Merrion Square','Merrion Square South, Dublin 2',53.339800,-6.249700,1),(104,'Portobello Harbour','Grand Canal, Dublin 8',53.330400,-6.267100,0);
/*!40000 ALTER TABLE `stations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vans`
--

DROP TABLE IF EXISTS `vans`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vans` (
  `Licence_ID` varchar(10) NOT NULL,
  `Station_ID` int NOT NULL,
  `Staff_ID` int NOT NULL,
  `Date_stamp` date NOT NULL,
  `Bikes` int NOT NULL,
  `Station_end` varchar(50) NOT NULL,
  PRIMARY KEY (`Licence_ID`),
  KEY `Staff_FK` (`Staff_ID`),
  KEY `Station_FK_van` (`Station_ID`),
  CONSTRAINT `Staff_FK` FOREIGN KEY (`Staff_ID`) REFERENCES `staff` (`Staff_ID`),
  CONSTRAINT `Station_FK_van` FOREIGN KEY (`Station_ID`) REFERENCES `stations` (`Station_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vans`
--

LOCK TABLES `vans` WRITE;
/*!40000 ALTER TABLE `vans` DISABLE KEYS */;
INSERT INTO `vans` VALUES ('241-D-1024',103,501,'2026-06-02',15,'Portobello Harbour'),('252-D-8891',101,502,'2026-06-03',8,'Parnell Square');
/*!40000 ALTER TABLE `vans` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-13  0:04:14
-- MySQL dump 10.13  Distrib 8.0.45, for Win64 (x86_64)
--
-- Host: localhost    Database: dublinbikes_judge
-- ------------------------------------------------------
-- Server version	8.0.45

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bike_rentals`
--

DROP TABLE IF EXISTS `bike_rentals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bike_rentals` (
  `Rental_ID` int NOT NULL,
  `Customer_ID` int NOT NULL,
  `Bike_ID` int NOT NULL,
  `Payment_ID` int NOT NULL,
  `Station_ID` int NOT NULL,
  `Start_Time` varchar(50) NOT NULL,
  `End_Time` varchar(50) NOT NULL,
  `Start_Station` int NOT NULL,
  `End_Station` int NOT NULL,
  PRIMARY KEY (`Rental_ID`),
  KEY `Bike_FK_rent` (`Bike_ID`),
  KEY `Customer_FK_rent` (`Customer_ID`),
  KEY `Payment_FK_rent` (`Payment_ID`),
  KEY `Station_FK_rent` (`Station_ID`),
  CONSTRAINT `Bike_FK_rent` FOREIGN KEY (`Bike_ID`) REFERENCES `bikes` (`Bike_ID`),
  CONSTRAINT `Customer_FK_rent` FOREIGN KEY (`Customer_ID`) REFERENCES `customers` (`Customer_ID`),
  CONSTRAINT `Payment_FK_rent` FOREIGN KEY (`Payment_ID`) REFERENCES `payments` (`Payment_ID`),
  CONSTRAINT `Station_FK_rent` FOREIGN KEY (`Station_ID`) REFERENCES `stations` (`Station_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bike_rentals`
--

LOCK TABLES `bike_rentals` WRITE;
/*!40000 ALTER TABLE `bike_rentals` DISABLE KEYS */;
INSERT INTO `bike_rentals` VALUES (2,2,33,2,5,'15:27','2:23 PM',16,2),(3,3,11,3,7,'15:19','1:13 PM',6,28),(4,4,2,4,8,'17:33','6:33 AM',30,26),(5,5,35,5,9,'12:51','3:49 PM',15,9),(6,6,45,6,12,'11:39','10:58 AM',16,13),(7,7,22,7,7,'18:45','10:35 AM',3,5),(8,8,3,8,2,'16:24','6:13 AM',16,12),(9,9,2,9,4,'20:29','5:13 AM',5,8),(10,10,35,10,6,'12:45','6:11 PM',2,13),(11,10,41,11,1,'12:47','5:58 PM',17,18);
/*!40000 ALTER TABLE `bike_rentals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bike_status`
--

DROP TABLE IF EXISTS `bike_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bike_status` (
  `B_Status_ID` int NOT NULL,
  `Bike_ID` int NOT NULL,
  `B_Status` varchar(40) NOT NULL DEFAULT 'Operational',
  `Last_Station` int NOT NULL DEFAULT '0',
  `Distance` decimal(10,2) NOT NULL DEFAULT '10.00',
  `Mileage` decimal(10,2) NOT NULL DEFAULT '0.00',
  PRIMARY KEY (`B_Status_ID`),
  KEY `Bike_FK_status` (`Bike_ID`),
  CONSTRAINT `Bike_FK_status` FOREIGN KEY (`Bike_ID`) REFERENCES `bikes` (`Bike_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bike_status`
--

LOCK TABLES `bike_status` WRITE;
/*!40000 ALTER TABLE `bike_status` DISABLE KEYS */;
INSERT INTO `bike_status` VALUES (1,8,'tertiary',0,4.25,21.64),(2,4,'support',0,3.89,34.70),(3,10,'bi-directional',0,4.67,40.41),(4,3,'Synergized',0,4.59,33.88),(5,7,'Self-enabling',0,3.28,31.96),(6,7,'tangible',0,4.22,27.60),(7,10,'Stand-alone',0,4.30,41.40),(8,7,'firmware',0,4.37,44.70),(9,7,'Team-oriented',0,4.70,22.51),(10,4,'actuating',0,3.84,44.45),(11,5,'bandwidth-monitored',0,3.80,42.72),(12,9,'Public-key',0,4.10,34.93),(13,6,'instruction set',0,3.45,42.78),(14,2,'heuristic',0,3.60,48.26),(15,2,'context-sensitive',0,3.27,36.77),(16,8,'optimizing',0,4.09,21.20),(17,4,'groupware',0,3.68,31.66),(18,2,'exuding',0,3.24,37.93),(19,12,'array',0,4.64,26.94),(20,8,'Graphic Interface',0,3.86,32.46),(21,11,'Monitored',0,4.66,24.29),(22,6,'6th generation',0,3.82,39.94),(23,10,'Exclusive',0,3.85,37.14),(24,11,'contingency',0,3.63,24.96),(25,10,'pricing structure',0,4.32,28.83),(26,7,'Multi-tiered',0,3.65,25.51),(27,11,'knowledge user',0,3.44,22.02),(28,12,'alliance',0,4.16,46.04),(29,11,'explicit',0,3.25,48.70),(30,2,'scalable',0,3.76,24.66),(31,2,'definition',0,4.67,42.83),(32,2,'artificial intelligence',0,4.56,33.29),(33,5,'3rd generation',0,4.69,36.11),(34,4,'mobile',0,4.60,35.25),(35,5,'Ameliorated',0,3.36,43.22),(36,3,'product',0,4.76,41.86),(37,9,'Triple-buffered',0,3.97,23.28),(38,7,'system-worthy',0,4.13,36.58),(39,7,'complexity',0,4.71,30.23),(40,11,'asynchronous',0,4.26,47.94),(41,10,'Front-line',0,3.68,24.02),(42,12,'budgetary management',0,4.15,27.32),(43,10,'Reverse-engineered',0,4.13,32.40),(44,10,'explicit',0,3.51,48.99),(45,6,'asynchronous',0,4.73,41.11),(46,8,'process improvement',0,4.36,22.08),(47,8,'neural-net',0,3.64,38.94),(48,3,'composite',0,4.32,49.58),(49,2,'Integrated',0,3.24,31.00),(50,50,'zero tolerance',0,3.91,32.84),(51,50,'zero tolerance',0,3.91,32.84);
/*!40000 ALTER TABLE `bike_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bikes`
--

DROP TABLE IF EXISTS `bikes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bikes` (
  `Bike_ID` int NOT NULL,
  `Station_ID` int NOT NULL,
  `Model` date NOT NULL,
  PRIMARY KEY (`Bike_ID`),
  KEY `Station_FK_bikes` (`Station_ID`),
  CONSTRAINT `Station_FK_bikes` FOREIGN KEY (`Station_ID`) REFERENCES `stations` (`Station_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bikes`
--

LOCK TABLES `bikes` WRITE;
/*!40000 ALTER TABLE `bikes` DISABLE KEYS */;
INSERT INTO `bikes` VALUES (1,7,'2011-01-15'),(2,28,'2012-08-28'),(3,6,'2012-03-04'),(4,19,'2011-01-14'),(5,8,'2011-03-19'),(6,18,'2011-08-23'),(7,10,'2011-08-21'),(8,19,'2012-04-06'),(9,10,'2011-04-02'),(10,12,'2011-04-28'),(11,29,'2010-08-02'),(12,15,'2010-03-15'),(13,4,'2010-07-07'),(14,7,'2011-07-04'),(15,24,'2010-11-02'),(16,8,'2010-07-31'),(17,24,'2011-05-11'),(18,10,'2011-08-07'),(19,9,'2010-09-16'),(20,19,'2012-01-18'),(21,28,'2010-08-06'),(22,13,'2010-05-13'),(23,20,'2012-06-18'),(24,29,'2011-03-20'),(25,5,'2012-04-10'),(26,7,'2011-06-10'),(27,20,'2010-12-30'),(28,6,'2011-08-15'),(29,22,'2011-11-23'),(30,28,'2012-06-26'),(31,24,'2012-02-19'),(32,18,'2011-04-24'),(33,15,'2010-08-28'),(34,23,'2012-09-27'),(35,24,'2010-06-15'),(36,26,'2011-07-04'),(37,5,'2010-11-11'),(38,21,'2012-09-28'),(39,21,'2010-12-07'),(40,23,'2011-06-16'),(41,24,'2012-04-03'),(42,10,'2010-11-13'),(43,26,'2010-06-03'),(44,7,'2012-07-21'),(45,19,'2010-10-13'),(46,14,'2010-07-15'),(47,15,'2011-12-04'),(48,22,'2011-07-30'),(49,3,'2011-09-19'),(50,24,'2010-09-23');
/*!40000 ALTER TABLE `bikes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer_details`
--

DROP TABLE IF EXISTS `customer_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer_details` (
  `Customer_ID` int NOT NULL,
  `Lname` varchar(40) NOT NULL,
  `Fname` varchar(40) NOT NULL,
  `Address` varchar(40) NOT NULL,
  `County` varchar(40) NOT NULL,
  `DOB` date DEFAULT NULL,
  `Joined` date NOT NULL,
  PRIMARY KEY (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer_details`
--

LOCK TABLES `customer_details` WRITE;
/*!40000 ALTER TABLE `customer_details` DISABLE KEYS */;
INSERT INTO `customer_details` VALUES (2,'Lane','Arthur','281 Northview Crossing','Ireland','1946-11-05','2012-05-18'),(3,'Bailey','Carl','970 Lillian Drive','Ireland','1954-07-07','2012-10-15'),(4,'Murray','Lori','148 Victoria Parkway','Ireland','1990-01-14','2013-09-13'),(5,'Lewis','Nicole','9 Washington Trail','Ireland','1981-10-14','2013-01-20'),(6,'Hall','Carol','0 Buell Alley','Ireland','1934-06-18','2011-07-04'),(7,'Carroll','Carol','20187 Dapin Center','Ireland','1930-05-01','2015-10-09'),(8,'Daniels','Todd','68 Graedel Park','Ireland','1944-12-24','2013-08-08'),(9,'Flores','Debra','7 Waxwing Hill','Ireland','1953-02-13','2016-05-17'),(10,'Reid','Evelyn','62 Namekagon Point','Ireland','1962-01-07','2016-10-10'),(11,'Watkins','Lillian','87593 Coolidge Place','Ireland','1994-05-15','2014-05-19');
/*!40000 ALTER TABLE `customer_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `Customer_ID` int NOT NULL,
  `Username` varchar(40) NOT NULL,
  `Pass_word` varchar(40) NOT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Customer_ID`),
  CONSTRAINT `FK__Customers__Custo__5AEE82B9` FOREIGN KEY (`Customer_ID`) REFERENCES `customer_details` (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (2,'swilliams0','t2hlBwO5i2bT','jcoleman0@jalbum.net','7-(202)256-3821'),(3,'bdean1','CCch4ln','jlane1@deviantart.com','86-(720)876-7624'),(4,'jnelson2','1I7h500Y','mhicks2@yellowpages.com','51-(342)834-7891'),(5,'cholmes3','dOmYs7znu','ryoung3@unblog.fr','507-(517)172-1820'),(6,'tpierce4','P9ZMck','loliver4@sbwire.com','57-(209)278-7822'),(7,'wlong5','IR2tqayJ','ewalker5@abc.net.au','86-(212)824-7249'),(8,'sgomez6','IpzDPeAmz0I','wryan6@phpbb.com','46-(842)147-9547'),(9,'jmason7','R1nHWzPHkLnr','thunter7@dailymotion.com','357-(463)783-4797'),(10,'ekelly8','xOIrtSToskF6','clynch8@walmart.com','591-(139)662-2063'),(11,'jfisher9','G4iYceHSsy','dpatterson9@123-reg.co.uk','55-(602)907-2261');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `old_staff`
--

DROP TABLE IF EXISTS `old_staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `old_staff` (
  `Old_Staff_ID` int NOT NULL,
  `Staff_ID` int NOT NULL,
  `Lname` varchar(40) NOT NULL,
  `Fname` varchar(40) NOT NULL,
  `Address` varchar(40) NOT NULL,
  `County` varchar(40) NOT NULL,
  `Phone` varchar(40) NOT NULL,
  `DOB` date NOT NULL,
  `Joined` date NOT NULL,
  PRIMARY KEY (`Old_Staff_ID`),
  KEY `Staff_FK_OLD` (`Staff_ID`),
  CONSTRAINT `Staff_FK_OLD` FOREIGN KEY (`Staff_ID`) REFERENCES `staff` (`Staff_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `old_staff`
--

LOCK TABLES `old_staff` WRITE;
/*!40000 ALTER TABLE `old_staff` DISABLE KEYS */;
/*!40000 ALTER TABLE `old_staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment_method`
--

DROP TABLE IF EXISTS `payment_method`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment_method` (
  `Method_ID` int NOT NULL,
  `Method` varchar(40) NOT NULL,
  `Account_No` varchar(40) NOT NULL,
  `Bank` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Subscription` varchar(50) NOT NULL,
  PRIMARY KEY (`Method_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment_method`
--

LOCK TABLES `payment_method` WRITE;
/*!40000 ALTER TABLE `payment_method` DISABLE KEYS */;
INSERT INTO `payment_method` VALUES (2,'americanexpress','GB46 WZGX 5802 2377 9984 02','Jones-Ritchie','655 Butternut Alley','L'),(3,'jcb','SK70 1477 3896 9950 3644 4474','Muller, Treutel and Schmeler','8636 Sage Trail','L'),(4,'jcb','RO61 UVTO YY95 DZVR 45HJ GJLR','Flatley-Pfannerstill','65082 Warbler Hill','M'),(5,'mastercard','HU68 9740 5913 8971 2266 9709 7531','Rosenbaum, Gutkowski and Dare','41947 Dayton Drive','2XL'),(6,'instapayment','PL36 5634 9132 0596 4161 1527 6358','Sauer LLC','06596 Lien Circle','M'),(7,'mastercard','MD57 IVXG OBMZ MVJS MLXJ ADMH','Bergnaum-Simonis','31 Elka Place','XL'),(8,'instapayment','LB36 0858 NUNL 1CIH IJS4 DFET TIVS','Bernier-Maggio','42295 Butternut Circle','3XL'),(9,'jcb','FO49 3224 3961 2425 50','Medhurst and Sons','918 Gateway Park','S'),(10,'bankcard','CZ58 7610 9220 8817 6130 9000','Schimmel, Marks and Grady','42 Delladonna Plaza','S'),(11,'jcb','HR85 3139 0015 3167 4499 5','Wolff-Hilpert','7 Lakewood Gardens Crossing','2XL');
/*!40000 ALTER TABLE `payment_method` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payments` (
  `Payment_ID` int NOT NULL,
  `Customer_ID` int NOT NULL,
  `Method_ID` int NOT NULL,
  `Rate` decimal(10,2) NOT NULL,
  `Date_stamp` date NOT NULL,
  `Time_stamp` varchar(50) NOT NULL,
  `Amount` decimal(7,2) NOT NULL,
  PRIMARY KEY (`Payment_ID`),
  KEY `Payments_FK_customer` (`Customer_ID`),
  KEY `Payments_FK_method` (`Method_ID`),
  CONSTRAINT `Payments_FK_customer` FOREIGN KEY (`Customer_ID`) REFERENCES `customers` (`Customer_ID`),
  CONSTRAINT `Payments_FK_method` FOREIGN KEY (`Method_ID`) REFERENCES `payment_method` (`Method_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (2,2,2,3.13,'2004-04-23','10:49',7.70),(3,3,3,3.15,'2010-09-22','21:00',3.01),(4,4,4,3.10,'2011-03-09','20:42',5.69),(5,5,5,3.07,'2005-06-26','13:49',8.41),(6,6,6,3.10,'2007-06-26','12:54',8.88),(7,7,7,3.12,'2001-10-02','15:57',6.68),(8,8,8,3.06,'2003-12-24','10:25',5.69),(9,9,9,3.09,'2015-08-04','11:57',4.07),(10,10,10,3.07,'2004-01-21','19:06',3.03),(11,10,11,3.13,'2008-09-07','12:20',5.98),(12,7,11,3.57,'2015-07-13','8:37 PM',3.90),(13,4,2,4.47,'2017-03-10','10:27 PM',4.37),(14,4,7,4.39,'2015-08-31','8:49 AM',3.62),(15,4,8,3.70,'2015-09-22','12:17 PM',2.91),(16,8,7,3.89,'2016-02-15','6:23 PM',3.95),(17,9,4,3.64,'2016-07-25','3:08 PM',3.50),(18,5,6,3.82,'2015-06-25','11:52 AM',3.55),(19,11,9,4.37,'2015-02-06','1:53 PM',2.90),(20,9,3,4.04,'2016-02-20','10:39 AM',3.00),(21,3,8,3.32,'2015-02-11','3:50 PM',4.47),(22,2,8,4.05,'2016-02-08','9:05 AM',3.26),(23,10,6,3.23,'2016-07-06','10:58 PM',4.26),(24,3,8,3.80,'2016-06-14','10:15 PM',3.24),(25,3,5,3.29,'2016-06-04','9:54 AM',2.53),(26,11,11,3.50,'2017-02-04','7:35 AM',3.50),(27,8,7,3.74,'2015-12-25','7:47 PM',4.05),(28,11,7,3.29,'2017-03-07','12:41 PM',2.71),(29,4,8,4.48,'2016-05-05','4:27 PM',3.27),(30,6,8,4.41,'2017-02-23','9:05 AM',4.43),(31,10,7,3.25,'2016-09-26','6:09 AM',3.15),(32,9,7,3.85,'2016-12-21','8:08 AM',3.32),(33,3,4,3.89,'2016-05-19','12:22 PM',2.88),(34,10,11,3.90,'2015-06-19','7:20 AM',4.04),(35,8,5,3.15,'2016-12-23','8:25 PM',3.16),(36,2,6,3.99,'2016-09-08','1:02 PM',3.50),(37,7,4,3.58,'2015-05-07','6:56 PM',2.91),(38,9,5,4.40,'2016-04-25','8:48 PM',4.17),(39,5,7,3.37,'2016-04-12','3:01 PM',2.54),(40,6,11,3.71,'2015-03-09','7:41 PM',3.18),(41,10,2,3.59,'2017-02-06','10:52 AM',4.02),(42,8,8,4.18,'2016-08-13','8:18 AM',3.46),(43,4,3,3.60,'2015-09-10','11:51 AM',2.73),(44,4,4,3.33,'2017-04-08','10:27 PM',4.46),(45,9,4,3.46,'2015-07-01','12:44 PM',3.60),(46,4,11,4.27,'2015-03-17','12:41 PM',3.02),(47,6,9,3.29,'2015-12-03','1:29 PM',3.02),(48,5,8,4.04,'2015-01-27','8:08 PM',2.57),(49,10,6,3.90,'2015-04-20','2:07 PM',3.35),(50,10,6,3.06,'2015-01-17','7:07 AM',3.65),(51,5,10,3.04,'2016-02-28','4:38 PM',2.82),(52,2,7,3.66,'2016-03-15','6:44 PM',2.72),(53,11,3,3.42,'2016-08-01','2:21 PM',3.70),(54,9,2,3.37,'2016-04-21','3:00 PM',3.77),(55,10,3,3.80,'2015-05-14','12:55 PM',2.77),(56,4,2,3.15,'2015-03-26','8:55 AM',2.83),(57,4,4,4.38,'2016-03-23','7:35 PM',3.69),(58,4,9,3.95,'2016-10-03','10:30 PM',2.55),(59,5,3,4.32,'2016-06-12','1:07 PM',2.90),(60,4,8,4.14,'2017-04-14','6:48 PM',3.91),(61,9,8,3.89,'2017-04-08','11:25 AM',3.92),(62,5,3,3.10,'2016-06-12','10:30 PM',3.12),(63,8,10,3.81,'2016-07-16','7:29 PM',3.04),(64,4,3,4.48,'2017-03-03','10:37 PM',3.59),(65,11,5,3.27,'2015-01-05','2:56 PM',4.32),(66,6,11,3.23,'2016-02-09','5:43 PM',3.01),(67,7,3,3.02,'2017-03-31','2:16 PM',3.03),(68,10,11,3.15,'2016-01-30','1:49 PM',2.75),(69,8,9,4.48,'2015-06-01','11:44 AM',2.74),(70,7,11,3.24,'2017-03-06','3:51 PM',2.52),(71,4,9,4.35,'2016-11-03','6:36 PM',4.14),(72,5,2,3.53,'2015-08-20','7:23 AM',4.38),(73,8,8,3.04,'2016-06-20','9:05 PM',3.47),(74,5,4,3.69,'2015-05-24','10:31 PM',3.51),(75,10,7,3.25,'2016-09-16','2:42 PM',3.79),(76,6,11,3.01,'2016-11-05','10:05 AM',2.87),(77,7,8,4.14,'2016-01-11','5:37 PM',3.30),(78,8,6,3.06,'2015-08-25','10:15 AM',4.41),(79,6,11,3.65,'2016-02-02','4:08 PM',2.90),(80,3,8,3.07,'2015-03-23','7:10 AM',3.05),(81,5,10,3.88,'2016-09-27','9:50 AM',3.05),(82,4,10,3.48,'2017-01-27','10:05 PM',3.73),(83,3,3,3.64,'2017-01-01','8:39 AM',3.16),(84,7,2,4.25,'2017-02-05','10:24 AM',3.30),(85,4,11,3.10,'2017-03-31','4:30 PM',2.59),(86,2,6,3.79,'2016-07-23','5:39 PM',2.75),(87,7,7,3.64,'2015-04-14','8:11 PM',4.22),(88,9,4,3.74,'2015-07-11','1:08 PM',3.51),(89,6,3,3.53,'2015-02-16','9:00 AM',4.12),(90,6,5,3.05,'2015-09-11','12:06 PM',2.59),(91,8,4,3.50,'2015-03-26','7:46 PM',3.66),(92,5,5,3.89,'2015-08-01','4:22 PM',3.76),(93,3,7,3.68,'2015-08-05','12:26 PM',3.88),(94,2,2,3.13,'2015-02-09','6:00 PM',4.33),(95,9,2,3.20,'2017-02-23','10:04 PM',4.01),(96,7,8,3.53,'2015-01-27','12:31 PM',3.69),(97,8,5,3.60,'2015-09-03','5:57 PM',4.05),(98,3,11,3.66,'2015-08-10','7:15 AM',2.67),(99,7,5,3.31,'2016-12-16','9:18 AM',2.91),(100,4,2,3.15,'2017-02-14','10:07 AM',3.07),(101,4,3,4.10,'2016-03-08','9:08 PM',3.93),(102,4,7,4.27,'2015-10-05','7:47 AM',2.88),(103,11,10,4.42,'2015-04-03','12:52 PM',3.17),(104,4,9,3.18,'2015-06-12','7:58 PM',3.07),(105,4,10,3.76,'2015-09-26','8:25 PM',4.31),(106,3,9,3.51,'2016-09-25','8:26 PM',4.45),(107,11,8,3.06,'2017-01-10','2:55 PM',3.37),(108,2,3,4.29,'2015-01-23','10:36 AM',2.67),(109,4,11,3.71,'2015-01-18','10:05 AM',3.77),(110,10,8,3.74,'2015-05-23','4:48 PM',3.67),(111,3,3,3.79,'2015-10-08','10:26 AM',3.32),(112,2,11,3.43,'2016-06-30','11:57 AM',3.85),(113,4,3,4.25,'2016-02-19','2:46 PM',2.60),(114,7,11,3.25,'2015-11-26','12:38 PM',4.04),(115,2,6,4.39,'2015-04-10','1:38 PM',3.38),(116,7,11,4.14,'2015-10-14','6:46 AM',2.82),(117,8,9,3.63,'2015-09-22','10:52 AM',3.03),(118,5,4,3.95,'2015-11-15','7:47 PM',4.37),(119,7,2,4.46,'2016-08-28','8:49 AM',3.83),(120,4,7,4.47,'2015-03-30','2:12 PM',4.23),(121,8,4,4.27,'2015-12-02','11:07 AM',2.54),(122,5,7,3.35,'2016-07-24','8:32 PM',2.69),(123,8,10,3.70,'2016-06-26','6:57 PM',4.14),(124,3,3,3.78,'2015-11-23','6:08 AM',4.27),(125,3,3,4.02,'2016-11-03','1:11 PM',3.67),(126,4,5,4.37,'2016-11-26','4:57 PM',2.60),(127,3,11,4.28,'2017-01-04','10:55 AM',4.20),(128,8,11,3.97,'2017-01-31','10:37 PM',3.55),(129,4,8,3.05,'2016-11-05','6:17 AM',3.44),(130,10,9,3.87,'2017-02-05','11:42 AM',4.08),(131,9,7,4.05,'2016-03-10','6:43 PM',2.60),(132,9,5,3.06,'2016-07-24','12:33 PM',3.09),(133,8,10,3.16,'2016-10-29','10:14 AM',3.32),(134,4,10,3.34,'2016-07-04','2:05 PM',3.67),(135,3,3,3.57,'2016-08-03','7:13 PM',3.12),(136,7,2,3.70,'2016-05-01','11:38 AM',3.12),(137,11,2,3.37,'2016-04-05','6:14 AM',3.14),(138,7,4,4.30,'2016-10-13','7:42 AM',3.86),(139,8,4,4.39,'2016-10-27','6:38 AM',2.68),(140,5,9,3.52,'2015-08-13','10:12 AM',3.89),(141,11,11,4.42,'2015-01-15','10:46 AM',4.16),(142,6,9,3.86,'2016-09-26','11:19 AM',2.74),(143,7,3,4.37,'2015-07-16','2:22 PM',3.29),(144,6,2,3.69,'2017-03-09','9:26 AM',3.59),(145,5,2,3.57,'2015-09-08','2:45 PM',3.76),(146,6,11,3.62,'2015-12-31','8:25 PM',3.85),(147,8,5,4.38,'2016-10-31','10:42 AM',3.47),(148,7,9,3.34,'2017-02-28','6:32 AM',4.42),(149,7,9,3.29,'2015-12-20','7:44 PM',3.73),(150,11,9,3.93,'2015-01-01','3:53 PM',3.73),(151,8,7,3.96,'2015-06-10','6:44 AM',4.26),(152,8,2,3.90,'2015-11-17','5:31 PM',3.15),(153,10,3,4.14,'2015-03-21','3:30 PM',2.69),(154,4,2,3.66,'2015-01-31','12:14 PM',3.13),(155,8,5,3.25,'2016-10-24','3:23 PM',4.17),(156,5,4,3.96,'2015-02-13','6:05 PM',4.31),(157,5,2,4.21,'2016-06-28','9:58 PM',4.10),(158,8,3,3.68,'2016-10-30','7:53 PM',4.47),(159,7,8,3.27,'2016-03-28','1:29 PM',4.31),(160,5,2,4.21,'2015-05-06','1:42 PM',3.79),(161,4,11,3.52,'2015-08-30','1:16 PM',2.67),(162,7,3,4.32,'2015-12-14','7:02 PM',4.27),(163,11,9,3.28,'2016-08-24','9:11 PM',2.80),(164,10,5,3.87,'2015-08-10','7:28 PM',2.87),(165,7,6,3.63,'2017-01-20','6:23 PM',2.77),(166,5,5,3.20,'2015-12-07','4:07 PM',4.22),(167,10,3,3.27,'2015-10-27','7:39 AM',2.50),(168,8,7,3.45,'2015-08-24','2:32 PM',3.02),(169,11,3,4.02,'2015-07-13','8:00 PM',4.12),(170,8,5,3.88,'2016-06-12','4:28 PM',2.66),(171,5,3,3.36,'2015-06-12','9:02 AM',3.62),(172,6,2,3.05,'2017-02-06','4:29 PM',2.52),(173,11,10,4.18,'2015-02-12','3:43 PM',2.91),(174,6,4,3.53,'2015-05-22','10:33 AM',2.77),(175,5,11,3.06,'2015-08-28','2:57 PM',3.40),(176,5,5,3.33,'2017-01-25','1:26 PM',4.24),(177,6,3,4.23,'2015-01-07','12:51 PM',3.85),(178,11,9,3.29,'2016-08-15','10:29 PM',4.48),(179,5,8,4.34,'2017-01-12','7:01 AM',3.66),(180,9,11,3.95,'2016-05-20','4:41 PM',3.41),(181,2,2,3.03,'2015-11-15','8:17 PM',2.73),(182,10,9,3.71,'2015-04-29','2:00 PM',4.39),(183,3,5,3.96,'2015-02-11','3:17 PM',3.57),(184,3,11,4.04,'2016-02-25','9:32 AM',2.67),(185,6,8,4.01,'2016-09-15','2:43 PM',3.29),(186,11,7,4.34,'2015-08-18','9:29 PM',3.32),(187,4,5,3.50,'2017-03-08','12:34 PM',3.16),(188,4,10,3.64,'2016-08-31','4:54 PM',3.69),(189,5,3,4.14,'2015-08-04','10:59 AM',3.00),(190,7,9,3.53,'2015-11-27','8:11 AM',3.53),(191,6,6,4.21,'2016-02-23','8:04 PM',2.73),(192,6,8,3.49,'2016-02-29','3:44 PM',2.65),(193,7,9,3.56,'2015-09-30','8:52 PM',3.96),(194,5,8,4.12,'2016-01-04','10:10 PM',3.44),(195,11,2,4.00,'2015-11-26','11:40 AM',3.17),(196,6,2,3.32,'2016-01-23','1:35 PM',4.50),(197,8,10,4.23,'2016-04-01','3:45 PM',2.91),(198,6,8,3.86,'2016-05-17','10:19 PM',4.00),(199,5,10,3.70,'2017-03-11','9:25 AM',4.42),(200,11,7,4.04,'2016-06-06','1:47 PM',2.71),(201,3,6,4.31,'2015-06-19','2:31 PM',3.67),(202,3,10,3.66,'2016-02-21','1:58 PM',3.12),(203,9,8,3.85,'2015-10-17','8:15 PM',3.65),(204,2,9,3.06,'2015-12-08','3:04 PM',3.08),(205,7,2,3.70,'2015-07-26','12:28 PM',4.30),(206,11,10,3.86,'2016-11-10','2:23 PM',2.74),(207,8,2,4.19,'2016-09-14','9:45 AM',4.47),(208,8,8,3.31,'2016-12-04','10:26 AM',2.99),(209,2,5,3.94,'2016-11-24','4:41 PM',3.45),(210,5,3,3.04,'2017-02-26','7:55 AM',3.47),(211,11,5,3.54,'2016-06-23','9:16 PM',4.33),(212,6,10,4.03,'2015-10-12','6:24 PM',3.08),(213,10,9,4.07,'2017-04-07','6:43 PM',2.82),(214,3,8,3.06,'2017-01-18','7:13 PM',4.35),(215,6,4,3.39,'2016-04-16','11:16 AM',4.47),(216,9,8,3.04,'2015-01-30','5:40 PM',3.64),(217,6,8,4.45,'2016-08-07','7:13 AM',2.92),(218,7,10,4.23,'2016-06-09','12:23 PM',3.33),(219,10,6,3.76,'2016-08-26','10:14 PM',3.24),(220,8,3,3.22,'2015-03-05','12:04 PM',4.44),(221,3,10,3.44,'2016-09-16','6:34 AM',4.43),(222,6,11,3.76,'2016-01-02','7:34 AM',3.89),(223,8,2,3.65,'2016-05-13','4:42 PM',4.06),(224,7,5,3.15,'2016-02-15','6:28 AM',3.96),(225,2,2,4.03,'2015-11-08','1:10 PM',3.43),(226,7,11,4.40,'2016-06-13','7:14 PM',2.59),(227,2,7,3.20,'2016-11-17','8:10 PM',3.11),(228,3,4,4.06,'2015-05-07','6:50 PM',3.98),(229,7,5,3.50,'2015-03-19','6:59 AM',3.39),(230,4,11,3.88,'2015-10-18','1:25 PM',3.12),(231,10,11,3.50,'2015-09-07','2:52 PM',3.97),(232,2,7,4.38,'2015-12-20','5:44 PM',2.81),(233,4,11,4.27,'2016-07-09','7:08 AM',3.77),(234,10,9,4.13,'2015-10-20','9:54 PM',4.10),(235,5,6,3.65,'2016-06-21','8:57 AM',3.92),(236,10,9,3.01,'2015-10-09','12:32 PM',3.31),(237,5,2,3.37,'2016-06-01','5:45 PM',3.70),(238,4,6,3.03,'2015-02-28','10:48 PM',2.89),(239,4,5,3.72,'2016-11-01','7:25 PM',3.72),(240,2,10,4.11,'2015-06-27','2:01 PM',3.83),(241,9,2,4.18,'2015-02-22','8:35 PM',3.43),(242,9,10,3.58,'2016-12-12','2:01 PM',3.00),(243,11,11,4.46,'2015-04-10','1:16 PM',3.52),(244,11,7,3.59,'2015-07-26','9:02 PM',3.30),(245,7,6,3.27,'2016-04-20','10:46 PM',3.25),(246,6,7,3.73,'2016-03-06','10:53 PM',3.52),(247,11,7,3.45,'2017-03-03','9:16 AM',4.36),(248,2,6,3.22,'2016-07-12','8:40 AM',3.63),(249,3,4,4.28,'2017-01-08','10:34 AM',3.47),(250,2,4,4.28,'2016-11-11','8:03 AM',2.80),(251,4,11,3.16,'2016-01-08','8:07 AM',4.27),(252,3,3,4.10,'2015-08-18','10:31 PM',3.74),(253,9,4,4.02,'2015-04-30','12:36 PM',2.97),(254,2,8,3.36,'2017-04-08','11:35 AM',4.09),(255,3,6,4.26,'2016-08-07','7:25 PM',3.62),(256,10,5,3.83,'2015-10-15','7:17 PM',3.05),(257,7,10,3.94,'2015-06-28','6:49 AM',2.67),(258,10,8,3.73,'2016-07-10','9:32 PM',4.47),(259,9,7,4.48,'2017-01-16','7:59 PM',3.75),(260,11,2,4.08,'2015-07-23','1:10 PM',4.41),(261,2,2,3.99,'2017-01-08','7:59 PM',2.90),(262,6,5,4.43,'2015-12-28','8:43 PM',3.87),(263,4,5,3.34,'2016-03-26','7:30 AM',3.26),(264,7,3,3.41,'2015-02-16','1:16 PM',3.63),(265,9,2,3.72,'2017-02-04','9:57 PM',2.66),(266,11,9,4.37,'2016-02-12','8:22 PM',4.23),(267,8,2,4.32,'2016-02-23','5:36 PM',4.48),(268,8,2,3.45,'2016-04-04','10:28 PM',3.22),(269,11,5,3.69,'2015-12-12','12:59 PM',4.11),(270,3,2,4.24,'2017-01-25','9:26 PM',4.27),(271,9,11,4.13,'2015-09-15','7:21 AM',4.10),(272,2,4,3.85,'2016-07-09','7:05 AM',4.33),(273,5,7,3.11,'2015-11-21','7:03 PM',4.42),(274,7,9,3.60,'2015-07-08','10:33 AM',3.59),(275,3,5,4.38,'2015-02-25','10:09 AM',2.90),(276,5,8,3.07,'2016-02-04','8:32 AM',4.11),(277,7,7,3.86,'2016-06-02','6:27 AM',4.39),(278,9,5,3.63,'2016-06-03','5:39 PM',2.96),(279,2,9,4.45,'2016-05-13','7:11 PM',4.17),(280,8,10,4.15,'2017-03-06','8:32 PM',2.51),(281,11,2,4.21,'2015-08-30','12:32 PM',4.49),(282,11,7,3.05,'2015-04-08','10:22 AM',3.01),(283,3,10,4.23,'2016-07-14','11:26 AM',3.15),(284,10,5,4.44,'2016-10-21','7:49 AM',4.27),(285,4,10,3.85,'2017-03-23','9:13 PM',2.94),(286,7,10,3.86,'2016-12-23','1:26 PM',4.04),(287,8,8,3.62,'2015-07-14','3:55 PM',3.57),(288,4,11,3.14,'2015-02-25','2:29 PM',3.02),(289,8,3,3.73,'2016-05-09','4:44 PM',2.60),(290,2,4,4.31,'2017-04-10','9:10 PM',2.59),(291,2,4,3.84,'2015-12-07','9:54 PM',2.71),(292,7,3,3.01,'2015-11-20','12:42 PM',3.56),(293,3,11,4.44,'2015-02-26','1:03 PM',2.98),(294,10,11,4.31,'2015-10-12','11:39 AM',2.60),(295,6,3,3.13,'2015-09-16','8:17 PM',3.59),(296,10,10,3.30,'2016-07-08','10:00 AM',2.58),(297,2,5,3.56,'2016-09-25','6:41 PM',3.42),(298,6,3,3.20,'2016-10-28','10:59 AM',3.29),(299,10,3,3.40,'2017-04-03','3:10 PM',4.11),(300,2,10,3.89,'2015-11-16','12:07 PM',4.43),(301,5,5,4.07,'2016-03-27','9:55 PM',3.30),(302,5,9,3.85,'2016-11-03','9:52 PM',3.52),(303,8,2,3.45,'2015-07-21','8:45 PM',2.61),(304,9,10,3.43,'2016-10-22','9:27 AM',3.13),(305,3,4,4.39,'2015-07-14','12:14 PM',3.92),(306,7,9,4.18,'2015-11-23','1:20 PM',4.07),(307,9,3,3.97,'2016-09-05','7:21 AM',4.40),(308,4,7,4.38,'2016-09-04','5:43 PM',3.17),(309,5,2,3.02,'2015-08-03','10:05 AM',4.32),(310,3,2,3.79,'2015-09-20','6:03 AM',4.40),(311,7,4,3.17,'2016-09-06','3:54 PM',3.11),(312,10,3,4.43,'2016-07-14','10:46 AM',3.05),(313,4,11,4.13,'2015-07-07','9:05 AM',2.60),(314,10,9,3.27,'2015-02-03','3:32 PM',4.20),(315,2,8,3.57,'2017-01-03','10:35 AM',3.40),(316,3,7,4.28,'2016-08-19','11:33 AM',3.65),(317,10,8,4.25,'2015-03-02','4:45 PM',4.06),(318,6,2,3.64,'2015-09-27','6:17 PM',2.99),(319,6,9,4.30,'2016-08-29','8:02 AM',4.01),(320,9,6,3.09,'2015-09-27','7:38 AM',3.41),(321,5,5,4.06,'2016-03-26','12:05 PM',2.62),(322,3,2,4.16,'2016-03-23','1:11 PM',4.42),(323,4,11,4.12,'2015-05-30','10:44 PM',3.76),(324,9,7,3.99,'2015-11-20','2:28 PM',3.45),(325,11,6,4.27,'2016-11-18','1:22 PM',4.18),(326,8,2,4.26,'2015-10-22','7:29 PM',2.59),(327,5,3,4.25,'2016-08-23','6:49 AM',3.39),(328,2,6,3.70,'2016-04-03','7:36 AM',3.45),(329,9,11,3.76,'2017-03-02','11:22 AM',3.62),(330,2,7,3.56,'2015-06-22','8:21 AM',2.65),(331,9,2,3.00,'2015-12-09','8:04 AM',4.20),(332,3,5,4.31,'2015-10-17','7:52 PM',4.27),(333,10,9,4.24,'2016-06-21','2:20 PM',3.05),(334,2,5,3.47,'2016-06-13','7:19 AM',4.30),(335,2,3,3.73,'2016-05-08','7:19 PM',3.36),(336,8,9,4.11,'2015-05-03','2:50 PM',3.28),(337,3,3,3.45,'2016-11-13','9:36 AM',3.13),(338,7,5,4.38,'2015-08-29','2:56 PM',3.24),(339,8,5,3.68,'2016-10-10','6:21 PM',3.23),(340,5,4,4.39,'2015-09-14','10:14 PM',3.17),(341,7,11,3.59,'2015-12-01','7:39 AM',4.39),(342,3,7,3.59,'2016-06-01','11:53 AM',4.00),(343,10,8,3.77,'2016-06-14','6:24 PM',3.40),(344,2,3,3.27,'2015-05-15','6:01 AM',3.87),(345,2,10,4.18,'2015-03-31','9:17 PM',3.43),(346,9,2,3.24,'2016-02-19','10:23 PM',3.36),(347,6,4,3.09,'2015-03-13','10:04 AM',3.28),(348,8,9,3.27,'2015-09-09','11:48 AM',3.41),(349,8,5,3.65,'2015-12-05','2:07 PM',3.85),(350,3,6,3.54,'2015-10-03','6:28 AM',3.47),(351,11,10,3.84,'2016-05-16','7:18 PM',4.42),(352,5,2,3.58,'2016-05-18','7:13 AM',2.92),(353,3,3,3.03,'2016-09-14','10:43 AM',2.52),(354,2,10,3.32,'2016-04-23','8:35 PM',3.28),(355,2,8,3.86,'2016-05-01','8:43 AM',3.58),(356,6,8,3.14,'2016-09-07','9:26 PM',3.67),(357,9,10,3.06,'2016-08-26','6:27 AM',3.23),(358,6,10,3.46,'2015-08-09','8:58 AM',2.60),(359,9,7,4.00,'2016-09-15','8:42 PM',3.82),(360,3,3,3.64,'2015-11-15','4:47 PM',2.79),(361,4,9,3.98,'2016-01-21','5:05 PM',3.41),(362,10,2,3.88,'2015-12-11','10:59 AM',3.52),(363,3,3,4.12,'2015-01-10','6:18 PM',2.55),(364,3,5,3.73,'2016-06-05','11:30 AM',2.55),(365,11,10,3.95,'2015-06-09','12:43 PM',2.88),(366,10,2,3.57,'2016-05-16','2:10 PM',3.08),(367,6,2,3.32,'2016-04-13','3:50 PM',3.60),(368,6,4,3.27,'2016-12-24','9:12 PM',2.73),(369,11,7,4.45,'2015-08-29','6:20 AM',3.72),(370,2,9,3.64,'2016-07-25','9:46 AM',3.00),(371,6,2,3.63,'2017-02-27','10:19 AM',4.21),(372,5,11,4.13,'2016-07-21','12:28 PM',2.87),(373,4,9,3.43,'2015-03-08','7:42 PM',3.62),(374,6,2,3.45,'2015-07-20','7:19 AM',4.14),(375,8,10,3.15,'2016-06-22','6:29 PM',3.38),(376,8,6,3.39,'2016-09-30','2:39 PM',2.81),(377,3,9,3.72,'2016-10-30','7:45 PM',2.97),(378,6,3,4.45,'2015-08-18','7:11 AM',2.78),(379,7,9,3.61,'2016-11-12','6:06 PM',4.46),(380,9,7,4.02,'2016-07-01','9:07 PM',3.63),(381,6,3,3.58,'2017-01-15','8:43 AM',3.57),(382,5,7,3.39,'2015-05-10','5:57 PM',3.14),(383,3,9,4.08,'2016-11-27','7:02 AM',4.18),(384,8,4,4.36,'2015-07-15','3:36 PM',4.41),(385,2,8,3.58,'2016-06-04','7:59 AM',4.02),(386,9,2,3.23,'2016-10-31','10:09 PM',3.91),(387,10,9,3.77,'2016-11-21','7:23 PM',2.52),(388,5,2,3.07,'2015-09-16','12:25 PM',3.70),(389,5,10,4.38,'2016-07-13','9:54 AM',4.23),(390,11,10,4.39,'2015-03-18','10:32 PM',3.72),(391,4,2,3.60,'2015-04-12','5:44 PM',4.13),(392,4,5,3.35,'2017-03-22','11:05 AM',4.20),(393,7,5,3.62,'2017-01-02','5:24 PM',3.21),(394,9,9,3.58,'2015-08-11','10:10 AM',3.25),(395,6,8,4.11,'2016-11-22','2:54 PM',4.10),(396,6,3,3.93,'2016-08-28','9:26 AM',2.87),(397,11,5,4.21,'2015-10-19','5:12 PM',3.70),(398,9,4,3.33,'2015-11-16','5:36 PM',3.57),(399,9,8,4.32,'2016-07-04','3:17 PM',3.60),(400,5,3,3.03,'2015-07-09','11:41 AM',4.35),(401,7,10,3.88,'2015-12-28','4:56 PM',3.39),(402,11,11,3.36,'2015-11-09','2:11 PM',3.01),(403,10,9,3.42,'2016-06-15','12:43 PM',3.04),(404,7,9,4.32,'2016-05-31','9:45 AM',3.25),(405,3,8,3.07,'2016-01-27','4:24 PM',3.57),(406,9,10,4.04,'2016-03-20','6:46 AM',4.18),(407,5,3,3.76,'2015-10-29','4:30 PM',2.87),(408,2,6,3.93,'2015-03-21','10:50 AM',3.98),(409,7,11,4.33,'2015-11-30','5:17 PM',2.78),(410,11,10,3.98,'2016-08-05','4:57 PM',3.03),(411,8,4,3.68,'2015-11-29','10:34 PM',3.60),(412,8,5,3.35,'2015-04-05','1:49 PM',2.82),(413,3,3,3.04,'2016-03-12','6:11 PM',4.42),(414,2,3,3.43,'2015-03-29','6:29 AM',4.14),(415,4,4,4.09,'2016-12-29','8:37 AM',3.23),(416,9,7,3.57,'2016-04-22','5:56 PM',3.81),(417,3,6,4.14,'2017-03-10','8:12 AM',3.88),(418,3,3,4.37,'2017-02-02','11:30 AM',3.30),(419,6,11,3.06,'2016-12-19','11:10 AM',3.71),(420,8,9,3.70,'2015-10-21','5:34 PM',3.32),(421,9,11,3.08,'2016-03-05','8:46 PM',2.95),(422,10,4,3.49,'2016-12-18','11:38 AM',2.83),(423,5,10,4.39,'2015-07-14','6:48 AM',2.62),(424,11,2,3.08,'2016-04-03','2:59 PM',3.28),(425,8,7,3.88,'2015-04-16','8:21 PM',4.27),(426,9,10,3.70,'2015-12-07','9:59 AM',3.37),(427,11,11,3.83,'2017-01-26','6:23 PM',3.81),(428,11,4,4.22,'2016-10-10','6:40 AM',3.35),(429,3,7,3.36,'2016-12-02','9:12 PM',2.90),(430,2,3,4.35,'2015-09-07','10:44 AM',3.59),(431,3,10,4.11,'2015-11-26','6:26 PM',3.43),(432,3,2,3.91,'2016-10-22','11:21 AM',4.25),(433,4,2,4.28,'2016-06-02','3:57 PM',3.94),(434,11,4,3.01,'2015-11-06','3:24 PM',3.71),(435,10,3,3.56,'2016-07-24','7:56 PM',4.47),(436,2,9,3.50,'2015-08-11','7:13 PM',3.27),(437,7,8,3.14,'2017-01-26','10:21 AM',3.13),(438,8,8,4.20,'2015-09-07','12:23 PM',3.23),(439,4,5,3.08,'2016-11-28','1:12 PM',3.87),(440,6,11,3.55,'2017-03-24','10:36 AM',3.20),(441,4,7,3.86,'2015-04-14','2:45 PM',2.71),(442,7,10,3.18,'2015-10-28','9:21 PM',3.71),(443,8,3,3.80,'2016-04-14','8:50 PM',4.20),(444,7,2,3.99,'2016-07-21','7:15 PM',4.02),(445,8,6,3.93,'2015-08-27','6:12 AM',4.02),(446,8,8,3.81,'2016-01-30','1:23 PM',2.89),(447,5,7,3.07,'2015-02-08','8:39 AM',3.42),(448,3,6,3.55,'2016-12-30','6:08 PM',4.35),(449,3,5,3.08,'2015-12-22','3:00 PM',3.38),(450,2,6,3.14,'2016-05-16','10:43 AM',2.84),(451,9,8,4.43,'2015-03-18','7:59 PM',4.44),(452,9,7,3.45,'2016-09-25','4:18 PM',4.28),(453,3,6,4.16,'2016-05-28','8:59 PM',3.67),(454,5,10,4.18,'2016-05-01','10:55 AM',3.55),(455,3,11,4.29,'2015-02-13','6:03 AM',3.69),(456,7,10,3.26,'2016-10-08','10:44 AM',2.80),(457,5,5,4.20,'2016-01-18','4:43 PM',3.03),(458,7,3,4.26,'2015-06-02','12:42 PM',2.68),(459,5,4,3.70,'2016-09-18','7:21 PM',2.76),(460,7,3,4.43,'2015-10-26','8:07 AM',3.95),(461,2,2,3.93,'2016-05-02','10:47 PM',3.98),(462,8,7,3.08,'2017-03-22','5:23 PM',3.09),(463,5,7,4.39,'2015-04-15','5:48 PM',3.01),(464,6,10,4.16,'2016-12-01','9:40 PM',2.75),(465,10,9,4.20,'2015-04-24','5:59 PM',4.08),(466,11,4,4.24,'2016-05-19','11:44 AM',2.84),(467,11,2,3.99,'2016-12-20','10:57 AM',2.80),(468,11,9,3.21,'2016-02-14','8:43 PM',3.41),(469,9,3,3.43,'2016-02-10','9:48 PM',3.05),(470,5,2,4.18,'2016-11-22','9:37 PM',2.59),(471,6,9,4.01,'2015-09-28','3:54 PM',2.53),(472,7,6,4.10,'2016-09-17','1:39 PM',2.63),(473,9,9,4.08,'2016-03-19','12:04 PM',2.57),(474,5,9,4.22,'2015-10-05','4:49 PM',3.50),(475,10,2,3.06,'2016-03-25','4:59 PM',4.12),(476,10,8,4.21,'2017-04-08','8:52 AM',3.70),(477,2,9,3.37,'2015-05-01','8:56 PM',2.71),(478,6,2,4.05,'2016-11-19','6:39 PM',3.64),(479,4,5,3.58,'2016-10-03','12:54 PM',3.95),(480,6,11,3.98,'2015-04-07','7:02 PM',3.16),(481,2,10,3.60,'2016-05-14','10:31 PM',2.79),(482,8,5,3.07,'2016-12-29','10:02 AM',3.66),(483,3,10,4.20,'2016-04-04','4:49 PM',3.19),(484,4,2,3.84,'2015-03-06','7:01 AM',2.73),(485,9,7,3.38,'2016-05-01','11:38 AM',2.53),(486,8,11,4.47,'2016-06-03','5:40 PM',3.56),(487,3,9,3.39,'2017-02-07','5:16 PM',3.22),(488,9,5,3.96,'2016-11-03','7:17 PM',4.16),(489,11,4,3.01,'2016-12-18','6:41 PM',3.06),(490,10,3,4.36,'2016-06-05','12:25 PM',4.27),(491,5,5,3.04,'2015-09-22','7:26 AM',4.01),(492,4,11,3.96,'2017-04-21','8:44 AM',3.87),(493,3,7,3.60,'2016-04-17','8:05 AM',4.33),(494,11,7,3.18,'2017-03-25','1:15 PM',3.48),(495,10,5,3.03,'2015-11-30','6:46 AM',2.53),(496,4,7,4.05,'2017-02-09','10:14 AM',2.66),(497,4,2,4.19,'2017-01-29','1:35 PM',3.52),(498,9,8,4.45,'2017-01-25','12:39 PM',2.77),(499,5,6,3.17,'2017-01-26','10:35 PM',4.28),(500,10,2,4.49,'2017-04-17','2:49 PM',4.08),(501,8,9,4.43,'2016-08-25','10:19 PM',4.46),(502,4,6,3.85,'2015-07-06','2:11 PM',3.76),(503,9,3,4.08,'2015-10-11','12:18 PM',2.79),(504,9,2,4.24,'2016-08-16','8:34 PM',2.93),(505,10,7,3.87,'2015-05-25','12:26 PM',3.64),(506,5,10,3.49,'2015-12-05','1:45 PM',2.92),(507,10,3,3.70,'2017-02-17','2:23 PM',3.36),(508,8,8,4.37,'2016-11-22','8:49 AM',3.89),(509,10,3,3.58,'2015-08-04','6:19 AM',4.35),(510,7,4,3.06,'2015-06-18','4:08 PM',3.11),(511,11,4,3.63,'2015-02-27','4:41 PM',4.30),(512,9,6,3.87,'2016-04-09','6:07 PM',4.05),(513,11,9,4.22,'2017-04-06','10:59 PM',2.51),(514,3,5,3.79,'2016-06-12','11:22 AM',4.44),(515,8,2,3.56,'2016-06-26','9:03 PM',3.93),(516,3,3,4.24,'2016-10-20','9:47 PM',3.21),(517,10,10,3.38,'2015-09-14','6:34 AM',4.23),(518,2,3,3.66,'2016-03-06','8:34 AM',3.47),(519,6,2,4.00,'2016-04-14','6:05 AM',2.64),(520,10,5,4.40,'2017-02-19','7:43 PM',3.62),(521,6,7,3.73,'2016-03-08','9:29 PM',3.94),(522,11,11,3.95,'2016-03-19','11:20 AM',4.04),(523,5,10,3.03,'2015-09-27','10:33 AM',2.96),(524,5,7,3.22,'2015-02-18','10:28 PM',4.08),(525,2,5,3.17,'2015-01-11','6:52 AM',3.70),(526,10,11,4.48,'2016-01-17','9:55 PM',3.44),(527,7,4,3.76,'2015-09-06','3:06 PM',3.84),(528,8,6,3.49,'2016-10-27','1:47 PM',3.90),(529,3,3,4.05,'2015-03-12','1:07 PM',4.19),(530,4,3,3.02,'2017-02-19','9:22 AM',4.04),(531,8,7,3.04,'2016-08-29','7:22 AM',4.30),(532,7,9,3.32,'2016-08-19','11:43 AM',3.87),(533,11,8,4.07,'2016-05-11','7:35 PM',4.09),(534,5,10,3.89,'2017-01-30','4:44 PM',4.29),(535,3,4,3.17,'2015-05-08','5:26 PM',4.48),(536,8,3,3.04,'2015-05-28','2:24 PM',2.93),(537,9,6,3.77,'2016-08-11','5:04 PM',3.39),(538,8,7,3.00,'2016-11-26','5:08 PM',4.50),(539,2,4,3.76,'2016-02-15','7:01 PM',3.91),(540,2,11,3.45,'2015-04-23','7:09 PM',3.33),(541,4,10,3.78,'2015-06-18','5:44 PM',3.68),(542,5,2,3.16,'2017-04-20','1:14 PM',3.20),(543,2,11,3.79,'2015-01-21','9:12 AM',3.43),(544,10,2,3.77,'2016-11-05','6:09 PM',2.60),(545,6,8,4.19,'2016-10-15','4:24 PM',3.11),(546,5,8,3.30,'2016-10-06','5:43 PM',4.31),(547,2,11,4.46,'2016-03-28','12:01 PM',2.51),(548,8,2,4.00,'2015-01-30','8:50 PM',3.35),(549,3,3,4.49,'2016-02-26','6:01 PM',3.40),(550,9,8,4.02,'2017-02-14','7:43 AM',3.12),(551,11,7,4.38,'2015-11-17','10:03 AM',2.54),(552,8,9,3.78,'2016-12-13','10:58 AM',3.87),(553,7,4,3.13,'2015-05-05','12:29 PM',3.81),(554,10,6,3.56,'2016-01-25','10:37 PM',2.62),(555,5,5,3.01,'2016-08-11','12:22 PM',3.91),(556,4,9,3.51,'2015-11-04','10:44 PM',3.98),(557,10,4,3.25,'2015-05-27','7:13 PM',3.11),(558,6,5,4.38,'2016-12-25','8:40 AM',3.17),(559,3,10,4.39,'2015-01-30','5:01 PM',4.42),(560,2,3,4.16,'2017-02-28','6:26 PM',3.00),(561,8,7,4.14,'2017-03-02','7:52 AM',2.61),(562,5,6,4.00,'2016-05-15','10:14 PM',2.71),(563,7,4,3.25,'2016-01-26','7:58 AM',2.77),(564,2,9,3.94,'2016-11-16','11:46 AM',3.34),(565,4,5,3.11,'2016-10-29','10:28 AM',2.58),(566,5,2,3.30,'2015-12-02','8:00 AM',2.53),(567,9,11,4.12,'2015-06-29','9:38 AM',3.89),(568,8,5,3.92,'2015-12-22','12:07 PM',2.63),(569,8,2,4.47,'2016-02-14','7:47 AM',2.80),(570,5,3,3.89,'2016-07-06','5:59 PM',4.03),(571,4,8,3.03,'2016-01-03','6:30 PM',3.87),(572,4,11,3.95,'2015-02-02','5:21 PM',2.65),(573,8,10,3.27,'2015-09-07','6:33 AM',3.06),(574,7,10,3.93,'2015-02-26','10:01 PM',2.61),(575,2,8,3.07,'2015-05-01','9:57 PM',4.34),(576,2,7,3.56,'2015-04-07','12:57 PM',3.43),(577,9,7,3.96,'2016-09-25','9:49 PM',2.74),(578,7,3,3.94,'2015-01-06','1:59 PM',3.18),(579,6,7,4.15,'2015-02-23','3:25 PM',4.06),(580,4,4,4.14,'2015-03-17','10:51 AM',4.00),(581,11,5,4.02,'2015-07-26','12:55 PM',4.33),(582,5,11,3.37,'2017-01-29','1:37 PM',2.59),(583,5,2,3.16,'2015-05-30','7:40 AM',3.90),(584,9,11,4.49,'2016-12-23','11:58 AM',4.10),(585,10,11,4.04,'2016-10-05','7:01 AM',3.89),(586,7,11,3.09,'2015-06-18','7:20 AM',4.46),(587,2,4,3.96,'2015-09-05','9:01 PM',3.43),(588,9,5,3.04,'2015-02-12','6:41 PM',3.96),(589,7,2,3.63,'2015-01-01','10:49 AM',2.79),(590,2,10,4.20,'2016-09-08','7:44 AM',2.57),(591,3,8,3.82,'2015-06-13','8:07 AM',3.61),(592,2,6,3.63,'2016-09-29','7:05 PM',3.07),(593,8,5,3.18,'2015-05-16','3:34 PM',2.74),(594,7,5,3.64,'2015-02-23','3:43 PM',3.45),(595,4,9,3.59,'2016-04-08','9:35 PM',3.40),(596,9,8,3.54,'2017-03-14','3:26 PM',2.64),(597,8,2,4.49,'2015-10-02','3:17 PM',2.54),(598,8,11,4.35,'2016-01-16','1:29 PM',3.60),(599,3,3,4.14,'2015-12-15','9:06 PM',2.83),(600,3,7,3.45,'2016-01-10','9:23 PM',3.38),(601,4,11,3.92,'2016-09-12','11:21 AM',2.72),(602,11,4,3.48,'2016-06-13','1:34 PM',2.52),(603,9,9,4.50,'2017-03-28','4:47 PM',3.49),(604,10,11,3.07,'2015-08-12','6:50 PM',3.96),(605,3,7,4.28,'2015-10-03','1:22 PM',4.08),(606,10,8,3.26,'2015-06-19','7:42 PM',3.67),(607,8,9,3.17,'2016-01-28','4:19 PM',4.11),(608,11,4,4.34,'2015-05-01','11:35 AM',4.44),(609,10,2,4.33,'2015-07-27','11:30 AM',3.16),(610,10,7,3.41,'2015-01-08','7:12 PM',3.61),(611,10,7,3.15,'2015-04-03','9:11 AM',3.50),(612,8,2,3.50,'2016-02-23','9:17 AM',4.31),(613,9,4,4.25,'2016-01-24','6:29 PM',4.09),(614,4,6,3.24,'2016-11-24','10:29 AM',4.29),(615,11,5,3.69,'2015-12-14','10:10 PM',3.31),(616,11,10,3.28,'2015-02-16','1:50 PM',4.27),(617,10,11,3.47,'2015-04-22','1:20 PM',4.49),(618,3,9,4.19,'2015-10-24','10:34 PM',3.57),(619,6,8,3.37,'2015-02-13','2:31 PM',3.82),(620,6,8,3.36,'2015-02-11','8:36 AM',4.14),(621,8,7,3.64,'2015-02-01','9:10 PM',2.97),(622,4,10,4.45,'2015-08-11','12:42 PM',3.39),(623,6,4,3.55,'2016-02-19','6:06 AM',4.33),(624,7,5,3.64,'2015-04-15','8:17 AM',2.68),(625,4,9,3.06,'2016-10-17','5:27 PM',3.08),(626,2,11,3.77,'2015-02-17','3:43 PM',3.06),(627,6,3,3.87,'2016-12-07','9:53 AM',3.94),(628,5,2,3.75,'2016-03-13','9:47 PM',3.90),(629,7,3,3.01,'2015-08-23','12:56 PM',4.26),(630,4,8,3.55,'2015-07-25','10:57 AM',4.17),(631,9,11,4.04,'2016-03-18','6:50 AM',3.96),(632,7,6,4.22,'2016-05-18','8:49 PM',3.90),(633,9,7,3.73,'2016-09-25','9:35 PM',3.39),(634,4,3,3.41,'2015-03-25','6:33 AM',2.66),(635,11,10,3.02,'2015-07-28','5:25 PM',2.96),(636,3,10,3.15,'2016-07-12','11:41 AM',4.07),(637,6,6,3.26,'2015-10-13','9:55 PM',3.82),(638,3,10,3.99,'2016-08-04','8:49 AM',4.39),(639,2,10,4.08,'2015-08-18','7:02 PM',4.37),(640,5,10,3.38,'2016-01-07','8:55 AM',3.27),(641,6,3,3.57,'2015-09-06','1:57 PM',2.56),(642,10,8,3.99,'2015-01-06','9:31 PM',3.44),(643,11,11,4.03,'2015-02-05','2:32 PM',3.13),(644,7,6,3.45,'2016-06-26','6:35 AM',2.63),(645,3,8,3.52,'2016-01-26','6:54 AM',4.10),(646,3,10,4.49,'2016-11-09','5:07 PM',2.89),(647,9,3,3.84,'2015-12-24','8:07 PM',3.56),(648,5,8,4.16,'2015-05-12','9:16 AM',3.23),(649,4,6,3.34,'2016-08-28','5:38 PM',3.54),(650,4,8,3.32,'2016-11-12','7:40 AM',4.09),(651,2,9,4.21,'2016-01-30','1:49 PM',3.17),(652,3,7,3.02,'2017-03-29','1:52 PM',3.60),(653,11,3,3.85,'2015-03-14','1:42 PM',3.93),(654,3,11,3.99,'2017-02-25','6:48 PM',2.86),(655,7,5,3.36,'2015-06-01','10:22 AM',3.30),(656,3,11,3.50,'2015-09-16','1:22 PM',3.99),(657,7,6,3.93,'2015-02-04','12:13 PM',3.04),(658,10,11,3.48,'2015-03-08','6:53 PM',4.47),(659,9,8,4.39,'2016-10-04','6:11 AM',2.84),(660,9,9,3.33,'2016-04-03','5:13 PM',3.39),(661,3,6,4.33,'2016-09-15','7:44 PM',3.11),(662,4,11,3.15,'2017-02-03','10:23 AM',3.74),(663,7,5,3.05,'2016-03-28','6:00 PM',3.02),(664,11,6,4.01,'2015-11-21','6:03 PM',2.94),(665,6,4,3.35,'2016-01-13','10:20 AM',4.41),(666,4,8,3.21,'2016-03-03','6:59 AM',2.53),(667,7,6,4.11,'2016-07-04','10:37 PM',3.68),(668,6,7,3.01,'2017-03-01','8:15 AM',2.89),(669,3,4,3.86,'2017-04-07','6:40 AM',3.47),(670,5,2,4.20,'2016-03-12','9:17 PM',4.25),(671,7,5,4.48,'2015-02-08','7:10 AM',3.49),(672,8,6,3.73,'2016-09-25','10:34 PM',3.07),(673,6,2,3.44,'2015-09-15','9:34 AM',4.29),(674,7,9,3.12,'2016-03-06','7:33 AM',3.24),(675,8,5,3.45,'2015-04-08','3:56 PM',2.90),(676,4,8,3.49,'2015-05-04','9:59 AM',4.37),(677,4,4,3.39,'2016-12-08','4:10 PM',3.83),(678,5,7,3.31,'2016-05-23','10:09 PM',3.72),(679,10,8,3.96,'2015-05-10','5:06 PM',2.74),(680,11,2,3.30,'2016-01-19','11:27 AM',3.49),(681,10,6,3.15,'2015-11-23','6:10 PM',4.39),(682,10,4,3.16,'2016-06-10','9:08 AM',3.04),(683,5,5,3.21,'2015-06-20','1:29 PM',3.45),(684,5,4,3.37,'2016-04-22','10:41 AM',3.09),(685,5,5,4.06,'2017-02-21','8:28 AM',4.46),(686,3,11,3.51,'2015-02-10','4:56 PM',3.04),(687,3,6,3.95,'2017-03-10','9:17 PM',4.11),(688,3,2,4.11,'2015-07-10','3:34 PM',2.92),(689,2,10,4.17,'2016-11-11','6:29 PM',2.88),(690,4,8,3.37,'2015-07-18','8:09 PM',3.97),(691,3,4,3.92,'2016-04-16','10:07 AM',3.62),(692,3,11,3.26,'2015-02-02','6:11 PM',2.53),(693,4,11,4.19,'2016-02-19','1:47 PM',4.03),(694,7,7,3.05,'2016-01-03','8:56 AM',3.92),(695,6,10,3.51,'2016-05-06','8:34 AM',3.69),(696,11,11,4.15,'2016-10-14','6:28 AM',2.53),(697,4,7,3.73,'2016-04-01','9:12 AM',2.72),(698,9,9,3.69,'2015-04-19','3:34 PM',2.54),(699,5,6,4.06,'2016-05-19','9:33 AM',3.63),(700,10,4,3.10,'2016-04-24','5:15 PM',2.80),(701,3,9,4.40,'2015-02-08','6:07 PM',4.33),(702,6,6,4.20,'2016-09-08','12:00 PM',4.27),(703,6,10,3.72,'2015-04-28','4:07 PM',3.85),(704,10,8,4.29,'2015-12-25','6:32 PM',2.54),(705,3,11,3.23,'2015-01-22','10:40 PM',2.58),(706,6,2,4.31,'2016-11-15','10:16 AM',4.13),(707,6,11,4.11,'2016-05-29','5:33 PM',3.64),(708,7,10,3.11,'2016-10-08','11:24 AM',3.84),(709,7,2,3.23,'2016-02-01','6:57 AM',2.83),(710,11,4,4.03,'2015-03-15','9:24 PM',3.17),(711,11,5,3.47,'2015-10-02','7:04 AM',3.72),(712,7,5,3.94,'2015-03-16','5:33 PM',3.80),(713,6,7,4.38,'2015-02-13','9:25 PM',3.00),(714,9,6,3.91,'2016-04-25','8:03 PM',3.11),(715,7,9,3.77,'2015-03-27','2:17 PM',2.99),(716,3,6,3.66,'2016-03-30','5:31 PM',2.85),(717,4,11,4.13,'2015-02-10','6:49 AM',3.32),(718,6,3,3.77,'2015-12-28','1:37 PM',4.05),(719,2,11,3.32,'2015-05-07','2:15 PM',2.52),(720,10,6,4.11,'2016-02-18','5:55 PM',3.30),(721,11,10,3.60,'2015-09-15','10:14 AM',3.74),(722,3,8,4.19,'2015-05-04','2:54 PM',2.59),(723,7,10,4.50,'2017-01-11','6:58 PM',4.26),(724,5,2,4.04,'2016-03-12','6:22 AM',2.61),(725,2,7,3.29,'2015-02-27','1:09 PM',2.71),(726,2,2,3.31,'2016-05-23','8:22 PM',3.11),(727,3,5,4.38,'2016-07-09','10:20 PM',4.10),(728,3,3,3.85,'2015-05-27','8:50 PM',4.12),(729,10,10,4.30,'2016-02-23','9:35 AM',3.28),(730,5,4,4.37,'2015-06-10','10:08 PM',4.39),(731,9,7,3.41,'2015-06-19','12:56 PM',2.83),(732,8,3,3.63,'2016-08-10','10:30 PM',4.12),(733,10,9,3.32,'2017-01-11','4:51 PM',4.02),(734,5,8,3.69,'2016-07-09','2:19 PM',4.26),(735,5,10,3.95,'2016-12-17','5:19 PM',3.88),(736,11,8,3.07,'2016-03-08','7:09 AM',3.74),(737,5,9,3.30,'2017-02-24','12:38 PM',3.22),(738,6,9,3.18,'2015-02-21','12:26 PM',3.23),(739,7,9,3.57,'2016-12-29','5:38 PM',3.12),(740,7,7,4.17,'2015-10-11','10:18 AM',2.63),(741,6,8,3.65,'2015-12-27','3:16 PM',4.15),(742,2,4,4.36,'2016-01-29','12:09 PM',4.16),(743,5,4,3.98,'2016-02-04','3:45 PM',3.58),(744,9,4,3.48,'2015-05-09','8:10 AM',4.12),(745,7,11,4.03,'2015-01-07','3:49 PM',4.43),(746,4,11,3.21,'2015-04-09','9:22 AM',3.46),(747,11,2,3.31,'2016-12-20','8:21 PM',3.74),(748,4,6,4.34,'2016-01-27','10:06 PM',3.33),(749,6,4,4.42,'2016-04-16','6:41 PM',3.07),(750,8,10,3.38,'2016-03-24','7:41 AM',3.71),(751,10,5,4.45,'2017-02-02','9:03 AM',3.63),(752,6,8,4.07,'2015-09-15','7:49 PM',4.24),(753,11,7,3.64,'2016-08-20','7:49 PM',4.42),(754,9,10,3.41,'2016-07-30','2:40 PM',2.71),(755,9,6,3.16,'2017-01-13','9:42 PM',4.28),(756,7,7,3.17,'2015-05-19','12:59 PM',4.08),(757,3,2,3.47,'2017-03-26','9:47 AM',2.87),(758,2,9,3.19,'2017-03-31','5:48 PM',2.80),(759,3,7,4.40,'2015-01-20','8:59 AM',3.53),(760,7,7,4.24,'2015-04-27','9:33 AM',3.88),(761,8,9,3.82,'2016-06-27','5:44 PM',4.45),(762,8,7,3.86,'2016-06-01','7:10 PM',4.20),(763,6,7,3.36,'2017-04-16','4:09 PM',3.41),(764,3,4,3.50,'2015-11-09','1:05 PM',2.96),(765,3,10,3.86,'2015-01-18','1:44 PM',2.89),(766,5,3,3.96,'2016-07-26','7:55 AM',2.70),(767,8,5,4.50,'2015-11-27','12:26 PM',4.47),(768,7,3,4.16,'2016-05-07','8:27 AM',2.98),(769,11,3,4.05,'2017-01-03','2:15 PM',3.53),(770,5,2,3.32,'2016-01-30','7:45 AM',3.98),(771,2,8,3.10,'2016-03-29','10:50 PM',2.67),(772,2,11,4.43,'2016-08-24','4:47 PM',4.14),(773,2,11,4.32,'2015-03-12','9:21 PM',3.11),(774,7,6,4.12,'2016-07-21','8:42 AM',2.89),(775,5,5,3.55,'2015-10-25','7:49 PM',4.34),(776,11,4,3.83,'2016-10-07','12:43 PM',3.55),(777,7,6,3.65,'2016-11-23','3:31 PM',3.12),(778,7,4,4.08,'2015-06-04','5:38 PM',3.16),(779,4,5,3.53,'2016-10-12','8:03 PM',3.94),(780,11,10,3.69,'2016-08-03','7:46 PM',4.36),(781,7,11,4.23,'2016-05-12','9:17 AM',4.37),(782,2,10,3.13,'2016-10-29','5:45 PM',3.79),(783,9,9,4.35,'2015-03-01','6:30 PM',3.67),(784,7,7,4.04,'2016-03-10','12:54 PM',3.15),(785,11,2,4.21,'2016-12-30','12:14 PM',2.53),(786,6,10,3.39,'2016-05-18','2:16 PM',2.63),(787,3,11,4.43,'2016-02-18','6:27 PM',2.82),(788,4,8,3.63,'2015-06-16','5:32 PM',4.10),(789,8,10,4.08,'2015-03-06','2:10 PM',3.39),(790,10,3,3.85,'2016-01-31','8:43 PM',3.89),(791,9,10,3.46,'2016-04-17','8:16 PM',3.44),(792,3,3,4.43,'2015-09-30','4:11 PM',4.34),(793,2,10,4.27,'2016-08-16','9:14 PM',3.60),(794,7,9,3.40,'2017-02-16','3:30 PM',3.38),(795,11,5,3.93,'2016-02-11','5:08 PM',3.87),(796,7,8,4.16,'2015-01-31','1:51 PM',3.69),(797,11,2,4.14,'2017-01-01','3:05 PM',3.93),(798,5,9,4.45,'2016-11-13','6:52 AM',4.33),(799,7,10,4.15,'2016-07-15','10:45 PM',4.11),(800,9,10,4.34,'2015-11-17','4:32 PM',3.90),(801,5,7,4.33,'2017-01-26','10:21 AM',4.33),(802,10,11,3.38,'2016-11-09','9:32 AM',3.10),(803,3,11,3.03,'2015-10-24','9:22 PM',2.94),(804,4,7,4.18,'2016-11-26','1:52 PM',3.64),(805,8,9,4.40,'2015-12-21','6:13 PM',2.98),(806,5,7,4.13,'2016-11-23','3:13 PM',2.86),(807,11,11,3.74,'2016-03-11','6:18 PM',2.62),(808,9,10,4.44,'2015-06-20','5:51 PM',3.38),(809,9,5,4.08,'2016-06-07','9:32 AM',3.35),(810,5,11,3.71,'2015-01-30','10:40 AM',3.13),(811,2,4,3.44,'2016-03-22','7:40 AM',2.58),(812,4,7,4.28,'2015-08-30','10:21 PM',2.89),(813,8,4,3.62,'2016-07-03','10:43 PM',2.58),(814,5,4,4.34,'2015-01-20','12:31 PM',4.16),(815,9,7,3.15,'2015-12-22','10:40 PM',2.77),(816,4,6,3.31,'2015-01-17','3:14 PM',3.36),(817,7,3,3.58,'2015-07-08','2:06 PM',2.71),(818,8,10,3.93,'2017-03-17','2:39 PM',3.24),(819,7,7,3.39,'2016-05-04','6:57 PM',4.27),(820,8,3,4.34,'2015-12-17','12:03 PM',3.34),(821,8,9,3.18,'2016-12-15','6:55 PM',4.24),(822,8,3,3.07,'2015-07-25','7:52 PM',3.41),(823,9,9,3.80,'2015-01-06','3:21 PM',2.56),(824,9,8,4.19,'2016-07-23','5:22 PM',3.56),(825,8,6,3.96,'2016-09-27','9:06 PM',4.08),(826,5,2,3.41,'2016-06-05','8:32 AM',3.69),(827,11,2,4.23,'2016-12-08','6:28 AM',4.24),(828,7,7,4.29,'2015-10-30','10:50 AM',3.23),(829,8,11,3.91,'2016-08-12','8:23 AM',2.75),(830,7,5,3.39,'2017-03-15','10:10 PM',2.53),(831,7,11,3.29,'2015-12-16','3:40 PM',3.68),(832,7,4,3.60,'2015-08-22','11:48 AM',3.52),(833,7,6,3.90,'2016-07-05','7:41 PM',3.69),(834,9,2,3.89,'2016-05-14','7:47 PM',4.18),(835,5,9,3.42,'2016-04-23','8:46 PM',3.77),(836,4,7,3.88,'2017-04-03','9:29 PM',3.67),(837,10,9,4.00,'2015-10-03','3:20 PM',3.79),(838,7,4,4.08,'2017-04-13','11:24 AM',2.65),(839,5,9,4.21,'2015-12-21','11:55 AM',4.07),(840,5,4,3.41,'2015-02-08','6:11 AM',3.60),(841,4,11,4.10,'2017-04-18','6:36 AM',4.18),(842,8,5,3.57,'2017-01-06','9:10 AM',4.44),(843,6,2,3.60,'2017-02-18','9:12 PM',3.50),(844,4,8,3.80,'2016-01-12','6:04 AM',4.39),(845,3,6,3.11,'2016-08-03','3:37 PM',3.62),(846,9,2,4.38,'2017-04-20','3:29 PM',3.58),(847,4,3,3.41,'2016-09-17','5:58 PM',2.78),(848,3,6,4.19,'2015-07-17','4:14 PM',4.28),(849,10,6,3.37,'2017-02-20','9:12 PM',2.77),(850,3,7,4.01,'2015-08-06','6:57 PM',3.95),(851,11,4,4.33,'2015-10-07','3:11 PM',4.19),(852,5,3,3.62,'2015-06-07','8:21 AM',3.45),(853,2,2,3.24,'2017-02-16','7:13 AM',3.47),(854,5,2,3.36,'2016-01-18','4:50 PM',2.69),(855,11,8,3.92,'2016-11-19','10:11 PM',2.61),(856,5,5,3.71,'2015-10-30','9:35 PM',3.33),(857,3,3,4.41,'2016-09-05','7:17 PM',3.27),(858,10,10,3.42,'2017-01-15','8:25 PM',3.94),(859,10,6,3.83,'2016-10-01','2:35 PM',4.21),(860,8,9,3.63,'2015-02-22','1:28 PM',3.74),(861,11,4,3.26,'2017-02-22','7:41 PM',3.87),(862,8,7,4.16,'2016-03-14','10:42 AM',3.90),(863,9,5,3.44,'2016-09-06','6:43 PM',4.28),(864,4,7,4.40,'2017-02-15','4:46 PM',4.20),(865,3,11,4.39,'2015-09-01','6:02 AM',4.00),(866,2,10,3.28,'2015-09-26','10:22 PM',3.98),(867,9,2,4.33,'2015-10-26','3:40 PM',4.38),(868,9,2,4.05,'2017-02-06','10:29 PM',3.01),(869,8,8,3.58,'2015-01-29','5:14 PM',4.40),(870,9,6,3.75,'2015-12-13','5:35 PM',4.25),(871,6,2,4.23,'2016-09-30','3:31 PM',4.12),(872,10,5,3.46,'2015-07-04','6:05 PM',4.04),(873,10,5,3.83,'2015-11-04','4:10 PM',4.18),(874,8,4,3.38,'2016-06-13','8:53 PM',3.19),(875,3,4,4.06,'2016-10-13','4:34 PM',3.04),(876,3,6,4.42,'2017-03-02','9:19 AM',3.43),(877,5,8,3.91,'2017-01-18','11:39 AM',3.64),(878,6,10,3.21,'2016-12-18','7:07 AM',3.31),(879,11,10,3.73,'2015-01-28','5:46 PM',4.45),(880,4,6,4.04,'2015-02-07','10:42 PM',3.54),(881,3,10,3.36,'2015-11-02','3:07 PM',3.68),(882,11,10,4.28,'2016-12-14','10:19 AM',3.22),(883,9,4,3.51,'2015-07-22','8:54 AM',4.41),(884,11,4,4.06,'2015-03-26','9:53 PM',3.94),(885,5,8,4.29,'2016-12-12','10:34 PM',4.17),(886,11,8,4.50,'2016-06-03','7:16 PM',4.24),(887,6,8,4.26,'2015-03-24','8:14 AM',2.91),(888,11,8,3.63,'2015-06-09','1:24 PM',2.63),(889,4,3,3.85,'2016-02-12','1:13 PM',3.08),(890,7,11,4.49,'2017-01-06','6:21 PM',3.99),(891,5,9,3.37,'2016-09-19','2:40 PM',2.57),(892,11,3,3.10,'2016-01-19','3:12 PM',3.16),(893,3,8,3.01,'2015-12-28','8:05 AM',4.20),(894,4,3,3.71,'2015-12-08','10:05 AM',3.08),(895,9,2,4.29,'2016-06-25','10:19 AM',3.02),(896,7,10,4.07,'2016-12-04','4:48 PM',4.36),(897,2,11,3.53,'2015-05-01','3:48 PM',4.48),(898,11,3,3.64,'2015-03-20','2:54 PM',2.96),(899,5,3,4.10,'2016-12-26','12:21 PM',3.63),(900,4,2,3.57,'2015-10-07','7:27 AM',4.00),(901,3,2,4.45,'2016-11-04','6:47 AM',3.96),(902,9,5,4.27,'2015-12-15','6:26 PM',4.06),(903,6,5,3.48,'2015-06-10','8:00 AM',4.04),(904,7,2,3.42,'2016-10-07','4:59 PM',3.11),(905,8,8,3.10,'2016-09-16','5:38 PM',3.58),(906,8,7,3.49,'2015-12-03','5:04 PM',3.41),(907,2,5,4.16,'2016-05-04','6:14 AM',2.71),(908,4,2,3.76,'2017-04-08','7:20 AM',3.32),(909,7,9,4.21,'2015-06-12','3:38 PM',2.55),(910,5,4,3.74,'2015-12-30','4:02 PM',3.07),(911,4,9,3.88,'2016-09-16','6:25 AM',3.24),(912,11,4,3.72,'2016-10-25','9:54 PM',3.78),(913,5,9,3.21,'2015-04-11','9:17 AM',3.37),(914,2,2,4.00,'2016-11-01','8:12 AM',3.78),(915,10,7,4.31,'2017-02-05','7:28 PM',4.23),(916,4,5,3.44,'2016-05-08','1:15 PM',4.37),(917,2,2,4.25,'2015-10-19','6:09 AM',4.45),(918,9,5,3.42,'2016-06-21','5:41 PM',2.71),(919,2,4,3.90,'2015-09-26','12:00 PM',4.36),(920,9,6,3.53,'2016-03-06','8:45 AM',3.36),(921,11,11,4.48,'2016-01-16','8:26 PM',3.98),(922,4,8,3.07,'2015-10-08','9:34 PM',4.04),(923,10,4,3.90,'2015-08-29','7:51 PM',2.96),(924,9,5,3.17,'2017-03-19','3:19 PM',2.99),(925,5,11,4.37,'2017-03-21','10:10 PM',3.07),(926,5,2,3.95,'2016-07-26','7:26 PM',4.36),(927,4,11,3.73,'2017-04-08','6:25 AM',3.91),(928,4,10,4.46,'2016-08-16','8:41 PM',2.81),(929,3,4,4.20,'2015-05-24','6:59 PM',2.79),(930,7,4,4.47,'2016-03-20','6:29 PM',3.14),(931,11,9,3.85,'2016-07-11','7:44 PM',3.39),(932,10,3,4.23,'2015-03-15','6:05 AM',4.37),(933,7,6,3.04,'2016-11-08','7:35 PM',3.75),(934,2,3,4.36,'2015-08-05','7:40 PM',3.26),(935,6,7,3.37,'2015-10-30','12:42 PM',2.66),(936,3,8,3.10,'2015-01-09','5:34 PM',2.80),(937,6,7,4.34,'2016-03-21','7:44 PM',3.98),(938,2,8,4.04,'2017-02-26','5:28 PM',3.78),(939,6,10,4.31,'2016-03-28','9:22 PM',3.66),(940,4,11,4.07,'2016-06-16','9:55 AM',2.88),(941,11,6,4.36,'2015-05-13','5:33 PM',3.66),(942,10,11,3.66,'2017-04-14','12:12 PM',4.28),(943,3,6,4.11,'2016-03-05','6:44 AM',3.38),(944,8,5,4.22,'2016-11-05','11:30 AM',3.40),(945,8,9,4.10,'2016-11-24','6:28 PM',2.91),(946,3,6,4.35,'2015-11-22','9:27 AM',3.03),(947,3,3,3.68,'2016-09-29','11:11 AM',2.78),(948,11,4,3.41,'2015-09-26','1:54 PM',3.62),(949,5,11,4.07,'2017-03-07','4:47 PM',4.46),(950,10,7,4.41,'2016-02-21','6:26 PM',3.34),(951,4,7,4.49,'2015-11-28','9:50 AM',2.70),(952,10,3,3.90,'2016-02-22','6:47 AM',3.73),(953,9,4,3.64,'2016-02-28','1:58 PM',3.95),(954,11,2,4.18,'2015-10-20','5:25 PM',3.10),(955,9,10,3.37,'2016-03-11','3:44 PM',3.42),(956,7,9,4.01,'2017-04-09','12:18 PM',3.40),(957,10,10,3.01,'2016-11-06','7:11 AM',3.21),(958,11,11,3.25,'2015-12-10','10:19 PM',2.56),(959,9,4,3.06,'2015-09-01','9:15 PM',3.54),(960,2,10,3.21,'2016-04-17','3:46 PM',4.14),(961,2,2,3.38,'2015-03-01','10:32 PM',2.51),(962,6,8,4.14,'2016-11-21','3:44 PM',4.21),(963,9,5,4.29,'2016-06-27','10:55 PM',3.54),(964,7,7,4.29,'2016-12-03','6:28 AM',3.17),(965,10,9,3.72,'2016-06-07','11:37 AM',2.82),(966,7,5,3.36,'2015-08-31','11:12 AM',3.56),(967,10,8,4.23,'2017-01-07','3:22 PM',4.42),(968,3,4,3.46,'2016-06-15','11:31 AM',3.15),(969,8,9,3.51,'2016-08-07','6:51 AM',3.94),(970,5,2,4.43,'2015-09-04','3:31 PM',3.69),(971,10,11,3.85,'2015-03-17','10:50 PM',4.29),(972,9,5,3.59,'2017-01-26','4:43 PM',3.52),(973,7,8,4.10,'2016-03-13','9:43 PM',3.81),(974,11,5,4.28,'2017-01-19','3:25 PM',2.51),(975,5,5,4.31,'2016-07-16','3:29 PM',4.48),(976,4,2,3.95,'2016-12-24','10:56 PM',3.67),(977,3,3,3.39,'2015-03-18','9:41 AM',4.44),(978,9,9,4.31,'2015-02-01','10:01 AM',3.13),(979,4,6,4.27,'2017-01-20','2:17 PM',2.64),(980,8,3,3.61,'2015-05-29','1:30 PM',3.08),(981,9,4,3.90,'2016-02-09','6:32 PM',3.69),(982,8,11,3.72,'2016-02-29','7:20 PM',3.09),(983,10,5,4.10,'2015-03-15','6:06 PM',3.35),(984,2,4,3.87,'2015-03-06','6:57 PM',3.91),(985,5,5,4.26,'2015-10-26','12:30 PM',2.79),(986,5,9,4.26,'2016-09-17','5:12 PM',2.87),(987,2,3,3.80,'2016-03-04','8:51 PM',3.94),(988,8,9,4.47,'2017-03-08','1:07 PM',4.03),(989,10,5,3.59,'2015-10-16','7:35 PM',3.25),(990,11,10,3.87,'2015-02-09','3:48 PM',4.49),(991,9,7,3.98,'2015-08-06','8:45 AM',3.05),(992,11,5,4.20,'2016-12-24','8:12 AM',3.12),(993,7,11,4.29,'2015-08-15','3:32 PM',2.92),(994,6,7,3.14,'2015-10-31','7:32 AM',4.45),(995,10,2,3.86,'2015-10-06','10:20 AM',3.99),(996,7,8,4.39,'2017-03-02','3:33 PM',3.52),(997,5,6,3.26,'2015-03-24','2:10 PM',3.46),(998,2,10,3.06,'2016-04-23','12:37 PM',4.50),(999,4,5,4.02,'2017-02-19','9:49 PM',3.68),(1000,6,7,3.40,'2015-05-22','7:34 PM',2.67);
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `repairs`
--

DROP TABLE IF EXISTS `repairs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `repairs` (
  `Repair_ID` int NOT NULL,
  `B_Status_ID` int NOT NULL,
  `Staff_ID` int NOT NULL,
  `Delivered` date NOT NULL,
  `Price` decimal(9,2) NOT NULL,
  `Parts` int NOT NULL,
  PRIMARY KEY (`Repair_ID`),
  KEY `B_Status_FK_repair` (`B_Status_ID`),
  KEY `Staff_FK_repair` (`Staff_ID`),
  CONSTRAINT `B_Status_FK_repair` FOREIGN KEY (`B_Status_ID`) REFERENCES `bike_status` (`B_Status_ID`),
  CONSTRAINT `Staff_FK_repair` FOREIGN KEY (`Staff_ID`) REFERENCES `staff` (`Staff_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `repairs`
--

LOCK TABLES `repairs` WRITE;
/*!40000 ALTER TABLE `repairs` DISABLE KEYS */;
INSERT INTO `repairs` VALUES (334,33,125,'2016-04-02',4.06,13),(335,21,131,'2015-03-08',3.01,9),(336,43,128,'2016-08-04',3.38,3),(337,37,134,'2015-07-15',3.16,10),(338,28,130,'2015-07-02',3.16,3),(339,26,131,'2017-04-12',3.61,2),(340,45,133,'2015-08-30',4.23,10),(341,15,133,'2015-07-17',4.50,10),(342,3,131,'2015-05-22',2.60,10),(343,33,129,'2015-12-22',2.71,4),(344,37,134,'2016-08-03',3.93,8),(345,31,129,'2017-04-07',3.66,5),(346,42,130,'2015-08-17',3.80,15),(347,20,130,'2015-02-24',4.45,1),(348,15,128,'2015-12-04',3.91,9),(349,41,129,'2015-06-02',2.78,15),(350,31,130,'2016-05-18',3.04,13),(351,7,129,'2015-02-23',2.84,15),(352,28,130,'2016-08-16',2.59,14),(353,23,130,'2015-11-28',4.36,8),(354,12,125,'2016-08-23',3.15,5),(355,31,132,'2015-11-16',3.03,9),(356,36,129,'2016-11-01',4.37,3),(357,17,127,'2015-02-05',3.83,9),(358,40,130,'2015-08-13',3.88,9),(359,16,132,'2017-01-17',3.17,14),(360,27,126,'2016-07-26',3.66,1),(361,9,127,'2016-03-30',3.01,6),(362,49,129,'2016-10-20',3.17,10),(363,22,127,'2016-11-25',3.00,14),(364,12,125,'2016-06-28',4.33,5),(365,15,128,'2015-01-16',2.63,15),(366,42,133,'2015-10-28',2.97,4),(367,2,126,'2016-09-03',2.66,10),(368,24,126,'2016-06-17',4.30,11),(369,27,129,'2016-02-03',4.00,1),(370,2,128,'2016-05-30',4.44,5),(371,26,126,'2016-12-07',3.93,15),(372,50,126,'2015-05-23',4.15,12),(373,13,130,'2016-11-08',3.81,8),(374,48,133,'2015-01-06',2.56,14),(375,21,131,'2015-10-19',2.65,12),(376,10,132,'2016-05-29',2.96,9),(377,21,125,'2016-12-25',4.09,9),(378,47,134,'2016-12-31',4.02,3),(379,41,129,'2015-09-14',2.66,3),(380,39,128,'2016-07-22',2.68,10),(381,38,128,'2017-03-27',3.48,5),(382,39,128,'2017-02-27',2.65,15),(383,33,131,'2015-03-09',3.50,9),(384,2,132,'2015-11-22',4.01,8),(385,15,133,'2015-06-18',3.91,11),(386,7,128,'2015-02-19',3.48,10),(387,50,127,'2016-06-14',4.09,8),(388,41,130,'2016-03-21',4.45,3),(389,22,127,'2015-08-31',3.74,6),(390,36,129,'2016-07-15',2.52,11),(391,18,129,'2017-03-02',4.21,7),(392,48,126,'2015-04-10',4.41,12),(393,39,127,'2015-01-09',4.10,10),(394,12,132,'2015-08-02',3.02,10),(395,27,132,'2016-02-26',3.39,1),(396,30,129,'2016-11-15',3.37,12),(397,35,126,'2016-11-16',3.65,15),(398,5,133,'2015-08-31',3.61,14),(399,4,130,'2015-10-09',3.62,8),(400,7,129,'2015-03-10',2.64,7),(401,35,128,'2016-11-22',3.10,12),(402,13,132,'2015-06-16',4.28,6),(403,4,132,'2017-03-22',3.53,12),(404,37,134,'2017-02-09',3.99,14),(405,9,133,'2015-02-23',3.65,15),(406,32,130,'2016-09-27',4.33,12),(407,25,125,'2017-03-19',2.63,6),(408,1,127,'2016-12-16',2.92,14),(409,15,129,'2015-10-21',4.25,10),(410,47,133,'2016-12-23',3.10,6),(411,16,129,'2015-02-01',4.29,15),(412,43,129,'2015-02-17',3.90,5),(413,40,128,'2016-09-02',3.82,15),(414,22,132,'2017-02-17',3.63,4),(415,3,127,'2015-04-14',3.63,4),(416,25,129,'2015-03-14',4.34,3),(417,16,130,'2016-02-13',4.21,1),(418,36,134,'2015-05-02',3.86,4),(419,1,134,'2015-12-08',4.27,5),(420,5,129,'2015-12-26',4.20,14),(421,19,133,'2015-06-17',4.29,13),(422,29,133,'2016-05-27',2.74,10),(423,3,134,'2015-05-06',3.40,9),(424,37,130,'2017-02-03',4.08,1),(425,12,132,'2015-06-03',3.02,4),(426,14,132,'2015-03-10',3.98,2),(427,7,128,'2017-01-06',4.44,11),(428,25,130,'2015-02-03',2.73,13),(429,21,129,'2016-08-08',2.68,13),(430,35,133,'2015-07-24',3.99,10),(431,21,126,'2016-06-09',3.14,11),(432,44,127,'2016-05-16',3.94,2),(433,29,129,'2015-03-02',2.88,8),(434,42,131,'2016-07-04',3.45,4),(435,23,133,'2015-10-30',4.23,3),(436,41,130,'2015-06-24',3.34,11),(437,17,133,'2016-12-25',4.26,3),(438,50,132,'2015-11-24',3.10,10),(439,22,127,'2016-09-17',4.29,9),(440,20,130,'2016-07-01',3.96,1),(441,50,130,'2016-07-06',3.55,10),(442,36,130,'2017-02-15',3.23,7),(443,46,134,'2016-01-09',3.48,12),(444,45,128,'2016-01-13',4.13,5),(445,32,127,'2016-12-08',4.16,9),(446,38,132,'2016-12-05',3.94,7),(447,15,129,'2015-12-29',3.66,1),(448,41,132,'2015-03-16',3.95,14),(449,35,133,'2016-01-01',2.66,7),(450,18,134,'2015-11-23',4.35,14),(451,19,133,'2015-08-08',2.54,15),(452,20,132,'2015-11-14',2.91,9),(453,17,125,'2016-09-28',2.86,7),(454,49,134,'2017-01-05',3.57,5),(455,33,131,'2015-04-01',3.24,14),(456,17,126,'2016-01-16',3.19,4),(457,45,126,'2015-09-07',2.97,14),(458,21,133,'2015-08-21',3.86,3),(459,10,125,'2016-01-16',4.26,14),(460,21,132,'2015-08-24',3.93,15),(461,22,125,'2017-03-24',3.37,5),(462,26,133,'2016-11-04',2.93,10),(463,24,129,'2017-01-20',2.70,11),(464,2,127,'2015-01-30',4.10,7),(465,21,129,'2016-07-17',3.44,2),(466,16,134,'2015-02-23',4.04,3),(467,8,130,'2016-06-29',3.63,10),(468,14,126,'2015-04-30',3.37,1),(469,42,133,'2016-05-29',2.60,12),(470,9,134,'2015-04-30',3.30,2),(471,19,133,'2016-10-30',3.10,3),(472,27,129,'2017-01-21',4.11,5),(473,25,131,'2016-01-18',4.35,11),(474,40,125,'2015-08-16',2.92,9),(475,10,127,'2016-07-02',2.90,13),(476,27,126,'2017-03-12',2.54,1),(477,43,134,'2015-10-02',3.55,10),(478,42,127,'2016-08-06',3.78,10),(479,30,133,'2017-03-17',2.52,6),(480,31,132,'2016-11-27',3.62,9),(481,51,126,'2015-03-09',3.53,14),(482,25,131,'2015-01-25',3.18,4),(483,42,129,'2015-04-28',3.36,11),(484,38,129,'2015-03-20',3.05,10),(485,37,128,'2016-09-06',3.31,10),(486,4,125,'2015-03-12',3.67,11),(487,21,132,'2015-03-24',2.87,10),(488,26,127,'2015-08-19',3.53,5),(489,26,130,'2017-03-12',3.61,5),(490,23,132,'2016-06-11',2.71,11),(491,47,127,'2015-10-16',3.98,1),(492,23,127,'2016-04-17',4.11,3),(493,29,131,'2016-02-16',3.52,14),(494,25,131,'2017-02-01',3.73,4),(495,6,132,'2016-01-29',4.37,9),(496,38,129,'2015-12-19',3.61,5),(497,44,134,'2016-05-02',4.41,3),(498,32,133,'2015-09-14',3.71,6),(499,9,128,'2016-12-09',2.82,1),(500,1,129,'2016-07-02',2.70,1),(501,28,133,'2015-08-22',3.06,13),(502,35,128,'2015-06-08',3.65,14),(503,1,127,'2017-01-30',3.30,15),(504,12,125,'2016-04-12',4.18,9),(505,17,127,'2016-03-08',2.78,13),(506,40,125,'2015-05-23',3.11,12),(507,25,134,'2015-03-12',4.01,15),(508,9,128,'2015-01-16',3.31,9),(509,11,125,'2016-04-05',2.65,12),(510,4,127,'2017-01-19',4.18,12),(511,16,134,'2017-04-10',2.81,13),(512,27,130,'2015-12-07',4.12,2),(513,21,125,'2015-11-01',3.29,15),(514,33,126,'2016-11-20',3.76,3),(515,23,133,'2015-10-14',3.48,4),(516,28,130,'2015-03-24',2.66,14),(517,36,126,'2016-05-10',3.68,3),(518,35,133,'2017-04-19',4.26,14),(519,42,125,'2016-04-05',4.01,8),(520,12,125,'2016-09-23',4.15,9),(521,8,127,'2016-10-14',2.64,10),(522,50,127,'2016-01-21',2.60,9),(523,17,130,'2016-04-16',2.71,13),(524,41,128,'2016-01-15',2.82,1),(525,22,128,'2015-06-02',2.87,8),(526,15,129,'2015-05-04',3.95,7),(527,43,129,'2015-03-03',4.37,1),(528,33,125,'2015-02-03',4.22,9),(529,32,126,'2015-10-19',3.99,13),(530,34,125,'2017-01-20',3.57,13),(531,45,133,'2016-07-16',3.17,9),(532,50,134,'2016-04-08',2.80,14),(533,46,129,'2016-09-15',3.55,14),(534,11,130,'2016-03-19',4.40,13),(535,15,134,'2017-01-17',3.64,13),(536,17,130,'2015-09-16',3.15,5),(537,46,133,'2016-01-26',4.33,2),(538,11,129,'2015-05-25',3.72,7),(539,27,128,'2015-04-17',4.33,2),(540,11,127,'2015-08-27',4.01,6),(541,51,133,'2015-07-24',2.91,5),(542,44,131,'2016-08-20',2.91,13),(543,40,129,'2016-09-29',3.31,2),(544,18,130,'2015-11-11',3.29,14),(545,30,133,'2015-08-22',3.10,6),(546,34,127,'2015-04-26',4.34,2),(547,21,127,'2016-11-20',3.98,12),(548,25,125,'2016-08-12',2.78,14),(549,1,133,'2017-01-09',4.16,7),(550,25,131,'2017-04-08',2.69,3),(551,18,134,'2017-01-14',2.97,5),(552,27,125,'2016-10-24',4.21,10),(553,49,133,'2015-10-18',3.27,3),(554,4,130,'2017-02-20',3.64,7),(555,4,126,'2016-11-26',3.31,3),(556,4,127,'2017-01-31',3.34,11),(557,14,131,'2017-03-19',2.75,6),(558,9,127,'2015-08-08',3.33,4),(559,23,133,'2015-05-21',3.12,10),(560,51,133,'2015-12-30',3.64,15),(561,9,130,'2015-09-16',2.86,11),(562,22,127,'2015-02-11',3.17,2),(563,37,128,'2015-09-19',3.93,10),(564,5,131,'2015-05-26',2.64,8),(565,11,129,'2016-06-05',3.26,12),(566,35,133,'2016-09-27',3.47,14),(567,36,127,'2016-12-11',4.11,12),(568,7,131,'2017-03-03',4.36,12),(569,42,128,'2015-02-01',3.77,1),(570,21,129,'2015-10-28',2.97,14),(571,51,125,'2017-04-14',3.73,15),(572,9,131,'2016-10-14',3.08,7),(573,5,126,'2015-04-23',3.44,4),(574,19,128,'2015-12-31',3.67,8),(575,33,133,'2016-07-06',4.11,10),(576,32,129,'2015-09-26',2.58,13),(577,48,129,'2016-04-12',3.46,5),(578,29,132,'2016-12-24',3.97,11),(579,31,129,'2016-06-10',3.60,12),(580,41,130,'2015-01-03',2.87,4),(581,45,132,'2015-03-26',3.95,4),(582,10,133,'2016-02-25',2.73,12),(583,44,126,'2015-07-23',2.52,7),(584,29,125,'2017-04-05',4.44,15),(585,14,128,'2016-03-12',4.49,14),(586,9,132,'2015-04-01',4.40,1),(587,38,133,'2016-08-20',2.78,11),(588,16,131,'2015-10-05',3.65,3),(589,8,130,'2015-03-05',4.46,14),(590,26,134,'2015-03-23',2.67,6),(591,40,127,'2015-03-27',4.09,10),(592,35,130,'2016-03-27',4.04,7),(593,12,130,'2015-12-27',3.39,3),(594,50,134,'2015-11-12',4.49,3),(595,32,129,'2016-09-30',2.67,3),(596,27,134,'2017-01-19',3.18,9),(597,15,133,'2016-12-01',3.28,1),(598,44,127,'2017-03-06',3.16,2),(599,45,125,'2016-12-11',3.02,1),(600,22,132,'2015-07-23',4.49,5),(601,30,126,'2015-11-01',3.64,9),(602,6,133,'2015-04-19',3.30,15),(603,26,131,'2015-09-19',3.50,14),(604,2,129,'2017-01-05',3.95,15),(605,10,133,'2015-11-29',3.59,15),(606,37,134,'2017-03-14',4.03,1),(607,2,125,'2015-12-12',3.61,9),(608,24,133,'2015-01-16',3.80,3),(609,15,126,'2015-01-21',2.54,2),(610,44,129,'2016-12-30',4.21,10),(611,32,125,'2016-04-20',3.30,3),(612,42,133,'2015-08-28',4.03,2),(613,40,130,'2016-03-29',4.08,13),(614,12,130,'2015-05-30',2.59,10),(615,11,131,'2015-01-03',3.89,12),(616,49,128,'2015-05-18',3.19,2),(617,8,133,'2017-04-05',4.30,10),(618,45,131,'2015-11-04',2.91,4),(619,35,130,'2017-01-01',4.47,4),(620,10,131,'2015-05-26',3.68,6),(621,45,132,'2016-02-11',4.15,13),(622,32,134,'2015-04-15',3.41,1),(623,25,133,'2015-12-02',2.77,1),(624,26,133,'2015-02-02',2.58,15),(625,49,131,'2016-10-12',3.43,4),(626,31,131,'2016-11-17',4.18,5),(627,48,131,'2015-06-13',4.43,3),(628,51,133,'2016-04-28',2.98,5),(629,31,128,'2015-04-24',4.08,1),(630,29,128,'2016-10-06',3.30,8),(631,26,126,'2016-06-14',3.10,13),(632,24,125,'2016-08-20',3.85,15),(633,40,127,'2015-03-20',4.02,7),(634,30,133,'2015-12-22',3.27,13),(635,29,134,'2015-01-30',4.10,2),(636,32,126,'2015-12-11',4.42,8),(637,1,130,'2016-09-09',2.96,3),(638,46,130,'2015-02-02',2.51,15),(639,35,130,'2016-12-03',3.99,10),(640,44,131,'2015-05-18',3.63,4),(641,39,130,'2015-07-22',3.01,1),(642,2,134,'2016-05-15',2.88,7),(643,11,130,'2016-02-23',4.16,15),(644,36,126,'2015-03-12',4.20,9),(645,3,134,'2016-01-12',2.98,12),(646,30,127,'2016-09-06',2.74,12),(647,4,129,'2016-03-21',4.10,13),(648,26,126,'2015-04-14',3.53,14),(649,2,126,'2016-09-03',4.15,2),(650,32,128,'2016-09-27',3.63,9),(651,19,127,'2016-05-06',3.73,4),(652,3,134,'2017-03-06',3.70,5),(653,24,131,'2016-09-29',4.43,12),(654,23,130,'2015-03-11',2.58,7),(655,18,126,'2015-02-06',2.52,10),(656,28,134,'2016-12-02',4.36,14),(657,9,131,'2015-02-18',3.68,11),(658,28,125,'2015-10-21',2.58,6),(659,23,125,'2015-06-04',2.78,9),(660,35,132,'2016-05-14',2.60,10),(661,32,132,'2017-01-18',3.23,3),(662,17,132,'2015-02-03',4.45,6),(663,48,126,'2016-02-26',2.79,11),(664,49,128,'2016-08-20',3.94,13),(665,12,132,'2016-11-25',3.29,3),(666,28,130,'2015-08-18',4.23,12),(667,50,130,'2016-03-15',2.97,13),(668,13,126,'2016-05-19',3.80,10),(669,25,130,'2015-02-09',3.68,14),(670,13,130,'2017-02-11',3.84,15),(671,11,134,'2016-09-22',3.77,1),(672,51,127,'2015-11-30',2.61,1),(673,1,125,'2016-01-07',2.85,13),(674,44,126,'2015-11-17',3.86,11),(675,7,126,'2015-06-21',3.19,6),(676,28,127,'2015-06-27',3.49,9),(677,7,131,'2015-07-05',3.05,8),(678,27,126,'2015-12-22',3.14,9),(679,40,132,'2017-01-27',3.13,1),(680,40,133,'2017-02-16',4.46,1),(681,28,132,'2016-06-11',3.75,7),(682,39,125,'2016-02-20',4.20,4),(683,22,133,'2015-05-13',4.06,3),(684,42,130,'2016-08-07',2.59,14),(685,50,129,'2015-09-02',2.57,6),(686,42,129,'2015-08-12',2.97,2),(687,25,133,'2016-08-27',3.48,1),(688,14,130,'2016-03-02',4.03,13),(689,24,125,'2017-02-15',3.02,8),(690,36,129,'2016-07-22',2.81,6),(691,9,127,'2016-05-29',3.77,7),(692,19,129,'2016-12-26',4.32,4),(693,18,127,'2016-06-28',2.63,14),(694,46,130,'2015-08-25',3.97,2),(695,11,125,'2016-03-08',4.34,9),(696,3,132,'2015-08-03',3.12,4),(697,47,130,'2015-11-21',3.94,7),(698,11,125,'2016-04-08',3.24,1),(699,20,127,'2017-02-19',4.46,15),(700,13,127,'2016-01-12',3.42,13),(701,6,125,'2016-12-07',3.27,10),(702,2,125,'2015-06-21',4.25,11),(703,13,133,'2016-04-12',3.93,7),(704,35,131,'2016-05-05',2.64,12),(705,40,126,'2016-07-06',4.42,9),(706,13,132,'2015-02-02',3.69,10),(707,38,133,'2015-09-13',4.44,6),(708,12,125,'2015-07-10',2.72,15),(709,34,134,'2017-01-22',2.71,15),(710,22,125,'2017-02-13',3.80,13),(711,50,134,'2016-02-14',3.62,5),(712,15,126,'2017-03-05',2.82,13),(713,44,125,'2016-07-25',3.44,5),(714,22,132,'2017-02-09',2.75,1),(715,38,125,'2016-04-24',3.67,5),(716,31,126,'2015-07-24',3.61,11),(717,24,129,'2016-04-12',3.96,1),(718,44,125,'2016-12-06',4.05,13),(719,26,132,'2016-08-02',2.96,12),(720,43,128,'2016-01-29',3.67,6),(721,32,129,'2016-01-29',2.52,4),(722,15,133,'2016-01-10',4.05,11),(723,19,133,'2016-10-04',3.32,3),(724,18,128,'2016-09-30',3.90,6),(725,29,128,'2017-01-13',3.35,9),(726,10,131,'2017-01-31',4.27,5),(727,7,128,'2017-01-22',3.96,6),(728,6,132,'2016-11-04',3.62,11),(729,19,130,'2015-01-17',3.72,1),(730,9,130,'2016-11-29',3.44,5),(731,29,126,'2016-08-24',3.17,1),(732,22,129,'2015-12-01',3.21,1),(733,42,127,'2016-04-12',3.70,6),(734,21,134,'2015-09-20',3.98,10),(735,28,127,'2016-04-15',3.00,15),(736,46,125,'2016-11-15',4.45,3),(737,43,132,'2016-09-28',2.72,11),(738,48,128,'2015-12-26',3.79,7),(739,7,126,'2016-12-21',3.13,12),(740,12,132,'2015-11-05',3.71,9),(741,23,125,'2015-09-03',3.83,11),(742,23,133,'2016-03-30',3.81,2),(743,36,132,'2016-10-23',3.95,15),(744,2,126,'2016-10-05',3.01,5),(745,23,126,'2016-05-24',3.15,1),(746,2,128,'2015-05-29',3.36,15),(747,28,133,'2015-01-16',3.63,3),(748,5,134,'2016-02-29',2.57,5),(749,22,130,'2016-08-29',3.97,12),(750,46,129,'2015-03-14',4.04,10),(751,37,134,'2017-04-05',4.33,7),(752,25,128,'2016-12-06',2.99,13),(753,30,134,'2016-07-10',2.83,5),(754,31,134,'2016-12-22',2.81,3),(755,44,130,'2016-06-18',4.14,2),(756,33,126,'2016-01-28',4.40,13),(757,13,129,'2016-05-04',3.37,5),(758,12,129,'2016-07-24',2.72,7),(759,35,134,'2015-06-05',3.33,3),(760,15,132,'2016-12-18',4.48,11),(761,7,134,'2015-04-02',4.38,3),(762,49,131,'2015-07-28',3.67,5),(763,47,127,'2015-06-30',3.88,6),(764,2,127,'2015-09-07',3.76,6),(765,38,127,'2015-06-09',4.41,4),(766,26,131,'2015-07-21',3.89,9),(767,40,130,'2017-01-23',2.91,12),(768,42,133,'2017-03-12',4.26,5),(769,20,126,'2015-12-04',2.99,6),(770,22,130,'2017-02-15',2.53,10),(771,9,132,'2016-06-05',2.57,8),(772,32,131,'2016-08-27',4.19,4),(773,40,126,'2016-12-08',2.50,7),(774,26,130,'2016-08-07',3.50,15),(775,13,128,'2016-06-13',3.95,6),(776,17,131,'2016-11-04',2.59,9),(777,4,130,'2015-08-03',3.93,9),(778,26,126,'2015-08-07',2.80,1),(779,24,125,'2016-11-23',2.80,8),(780,10,127,'2015-07-26',2.80,2),(781,34,134,'2015-01-28',4.05,12),(782,48,134,'2016-10-20',3.96,3),(783,24,127,'2015-06-02',4.29,12),(784,32,128,'2016-08-08',3.57,9),(785,30,130,'2016-04-02',2.52,14),(786,29,125,'2016-04-11',3.44,5),(787,3,133,'2015-03-12',4.14,11),(788,39,129,'2015-10-04',3.86,6),(789,21,132,'2015-06-05',2.51,1),(790,12,130,'2015-03-07',3.90,5),(791,40,126,'2016-09-23',3.08,11),(792,48,130,'2016-09-14',3.46,3),(793,38,129,'2015-08-16',4.49,1),(794,31,134,'2016-02-23',2.78,4),(795,7,130,'2015-08-01',4.34,13),(796,4,131,'2016-01-03',4.41,3),(797,10,127,'2015-08-14',3.18,4),(798,14,132,'2015-05-15',3.80,2),(799,4,133,'2015-05-15',2.89,14),(800,39,128,'2015-08-22',2.76,12),(801,46,130,'2016-03-29',3.88,5),(802,11,128,'2016-10-24',2.70,12),(803,5,131,'2017-02-21',3.79,15),(804,34,132,'2016-11-26',4.43,9),(805,18,127,'2015-06-11',3.41,2),(806,13,126,'2016-08-27',2.61,15),(807,37,125,'2015-01-04',3.91,6),(808,47,133,'2015-07-15',3.38,9),(809,1,128,'2016-04-12',3.00,3),(810,20,130,'2015-05-15',2.67,7),(811,30,132,'2016-09-25',2.71,7),(812,6,129,'2015-11-03',2.91,10),(813,18,131,'2016-06-10',3.11,8),(814,17,134,'2016-11-22',3.81,9),(815,23,125,'2015-12-05',4.45,8),(816,51,128,'2017-04-02',4.31,4),(817,6,132,'2015-08-17',3.25,7),(818,18,127,'2016-08-03',2.82,7),(819,2,131,'2015-11-01',3.03,14),(820,32,133,'2016-11-02',4.05,12),(821,22,132,'2015-12-06',3.27,2),(822,45,134,'2017-01-16',3.00,9),(823,20,132,'2017-04-10',2.53,10),(824,22,129,'2015-02-10',3.42,5),(825,51,134,'2015-12-29',4.42,5),(826,4,127,'2015-09-07',3.19,4),(827,23,126,'2015-12-06',3.63,7),(828,42,130,'2016-01-18',3.57,1),(829,14,129,'2016-10-19',4.38,11),(830,12,130,'2016-11-20',3.08,15),(831,1,127,'2015-07-02',3.72,14),(832,39,131,'2017-03-03',3.51,10),(833,39,130,'2015-12-23',3.24,13),(834,48,132,'2015-12-06',3.35,3),(835,46,125,'2016-06-08',4.45,3),(836,30,128,'2017-01-17',4.04,15),(837,33,132,'2017-02-12',4.35,13),(838,23,131,'2017-02-02',3.65,10),(839,24,130,'2015-04-08',3.18,6),(840,20,132,'2015-12-24',4.38,5),(841,9,131,'2015-09-09',3.85,4),(842,7,125,'2015-04-11',3.49,11),(843,35,131,'2017-01-21',3.01,15),(844,46,130,'2016-08-27',3.89,7),(845,27,132,'2015-03-12',4.29,15),(846,19,126,'2017-01-08',3.51,3),(847,8,132,'2016-10-12',3.17,8),(848,23,129,'2017-01-12',2.81,11),(849,34,128,'2016-09-04',4.05,2),(850,51,125,'2017-02-28',2.58,13),(851,27,125,'2017-01-20',3.04,2),(852,49,134,'2016-03-14',3.05,3),(853,20,130,'2015-03-17',4.27,13),(854,17,127,'2016-03-17',4.08,8),(855,41,130,'2016-03-31',2.97,8),(856,36,134,'2015-05-20',4.18,15),(857,46,126,'2016-08-16',3.91,10),(858,21,134,'2016-03-15',3.57,11),(859,18,133,'2015-11-27',3.03,15),(860,2,127,'2016-10-28',4.12,3),(861,27,130,'2015-05-20',3.88,10),(862,6,125,'2015-02-05',3.53,4),(863,36,129,'2016-10-21',3.17,7),(864,12,126,'2016-04-13',3.82,14),(865,46,127,'2015-07-15',3.36,6),(866,39,130,'2016-01-16',3.76,4),(867,22,130,'2016-09-27',3.92,1),(868,49,125,'2016-06-18',3.02,6),(869,25,125,'2016-07-28',4.39,15),(870,1,134,'2016-08-04',4.18,14),(871,31,132,'2016-08-14',2.79,2),(872,51,127,'2015-09-22',3.06,6),(873,31,126,'2015-01-30',3.31,2),(874,28,126,'2016-03-23',2.95,10),(875,23,133,'2015-06-06',3.94,9),(876,50,126,'2016-08-12',3.05,6),(877,6,133,'2016-02-23',4.30,11),(878,28,126,'2015-08-22',2.87,2),(879,28,126,'2016-03-06',4.14,11),(880,27,125,'2015-09-22',2.93,2),(881,16,128,'2016-04-25',3.41,10),(882,45,133,'2015-02-07',3.94,15),(883,8,134,'2016-04-21',4.17,14),(884,12,127,'2016-01-13',4.12,1),(885,28,126,'2016-02-09',4.45,11),(886,19,126,'2017-02-20',2.62,10),(887,14,132,'2016-04-07',3.36,1),(888,3,132,'2016-10-18',3.14,1),(889,1,134,'2015-07-15',3.48,7),(890,39,125,'2016-03-04',4.28,4),(891,27,131,'2015-11-14',2.99,1),(892,33,132,'2017-02-06',4.06,11),(893,8,132,'2015-02-15',3.52,15),(894,16,130,'2015-09-23',3.04,8),(895,17,133,'2015-10-02',4.26,12),(896,27,126,'2015-03-09',4.12,1),(897,44,128,'2015-05-30',3.29,1),(898,12,126,'2016-08-16',3.93,9),(899,47,125,'2015-03-04',2.84,14),(900,39,131,'2017-02-21',2.75,12),(901,47,129,'2016-07-29',3.04,2),(902,10,130,'2016-12-05',3.79,9),(903,25,132,'2016-01-10',4.45,7),(904,30,125,'2015-01-15',3.20,13),(905,9,134,'2016-11-05',3.47,13),(906,21,133,'2016-02-04',4.07,9),(907,50,126,'2015-03-25',3.30,13),(908,12,129,'2016-05-04',4.33,1),(909,20,125,'2016-08-27',4.11,6),(910,33,130,'2015-02-19',3.02,7),(911,40,132,'2015-04-20',2.82,9),(912,34,134,'2015-06-06',2.95,3),(913,14,131,'2015-05-19',3.78,9),(914,17,126,'2016-10-01',4.13,12),(915,3,126,'2017-04-01',2.61,5),(916,7,128,'2017-01-17',3.61,1),(917,6,134,'2015-06-01',3.79,11),(918,16,133,'2016-12-16',2.95,6),(919,1,125,'2016-01-11',4.40,3),(920,3,130,'2017-04-10',3.63,11),(921,16,131,'2016-10-05',3.94,4),(922,2,133,'2015-06-03',2.79,5),(923,12,130,'2015-01-24',3.37,14),(924,7,127,'2015-09-21',3.51,12),(925,13,132,'2016-07-25',4.06,9),(926,44,132,'2016-01-07',2.59,3),(927,7,125,'2015-07-19',3.31,14),(928,44,133,'2015-10-06',2.96,15),(929,25,130,'2016-06-06',3.34,3),(930,50,125,'2017-04-21',4.02,6),(931,22,131,'2016-06-03',2.81,15),(932,19,129,'2017-02-13',2.70,1),(933,22,125,'2016-12-03',4.36,6),(934,41,134,'2015-10-22',2.72,5),(935,44,125,'2015-03-06',3.25,12),(936,18,130,'2016-08-27',3.08,11),(937,32,131,'2016-04-14',4.35,13),(938,35,128,'2015-06-10',4.40,12),(939,21,127,'2016-01-18',3.53,10),(940,51,131,'2015-07-14',2.73,6),(941,2,131,'2016-08-28',2.78,7),(942,18,126,'2016-10-08',4.06,1),(943,23,130,'2016-10-24',4.38,8),(944,49,125,'2015-07-12',3.22,7),(945,32,134,'2015-05-04',3.80,9),(946,19,126,'2015-02-08',2.70,8),(947,35,132,'2015-04-21',4.45,7),(948,42,131,'2015-05-09',4.46,7),(949,28,132,'2015-05-27',2.98,1),(950,46,134,'2016-08-07',3.94,15),(951,32,125,'2016-08-12',4.16,14),(952,12,127,'2017-04-02',4.43,3),(953,3,126,'2016-07-14',3.63,1),(954,8,130,'2015-07-25',4.33,1),(955,14,127,'2015-01-04',2.90,9),(956,11,125,'2015-03-21',2.99,8),(957,26,126,'2015-04-13',3.65,4),(958,15,130,'2016-12-26',3.27,1),(959,28,130,'2016-12-15',3.82,8),(960,17,127,'2016-10-06',4.02,4),(961,12,125,'2015-12-23',3.24,12),(962,6,125,'2016-02-13',4.27,1),(963,21,125,'2016-12-18',3.26,15),(964,14,133,'2016-09-12',3.89,8),(965,49,128,'2016-12-15',3.15,7),(966,46,131,'2017-03-21',3.12,15),(967,9,127,'2016-12-17',4.49,7),(968,26,134,'2016-01-13',3.37,8),(969,3,128,'2015-04-06',4.42,4),(970,2,125,'2017-03-14',3.60,13),(971,32,134,'2015-02-26',4.07,5),(972,1,131,'2015-08-17',3.42,12),(973,50,131,'2016-03-24',3.77,1),(974,34,131,'2016-11-24',2.81,2),(975,22,125,'2015-12-08',2.92,10),(976,42,131,'2017-03-22',3.23,2),(977,14,127,'2017-01-15',4.36,5),(978,47,126,'2015-08-28',2.74,15),(979,2,128,'2015-09-21',3.64,14),(980,27,133,'2015-01-15',3.11,3),(981,23,131,'2016-12-30',2.83,14),(982,30,128,'2015-02-25',2.55,4),(983,46,126,'2016-12-29',3.44,2),(984,44,125,'2016-07-08',3.81,14),(985,25,134,'2016-05-30',2.78,11),(986,1,131,'2016-09-11',4.20,14),(987,3,125,'2015-12-12',3.96,11),(988,29,132,'2016-10-10',4.32,7),(989,4,133,'2016-07-05',2.64,9),(990,36,129,'2015-04-06',3.94,7),(991,5,125,'2015-04-08',4.02,3),(992,44,126,'2015-05-24',3.96,14),(993,43,128,'2016-04-30',3.45,2),(994,22,134,'2015-09-14',3.02,10),(995,25,133,'2016-11-05',2.90,1),(996,49,129,'2016-12-23',4.04,1),(997,7,134,'2015-10-27',4.43,13),(998,49,129,'2016-01-17',4.31,11),(999,21,129,'2016-10-22',3.36,8),(1000,13,131,'2015-12-29',3.81,14);
/*!40000 ALTER TABLE `repairs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `Staff_ID` int NOT NULL,
  `Lname` varchar(40) NOT NULL,
  `Fname` varchar(40) NOT NULL,
  `Address` varchar(40) NOT NULL,
  `County` varchar(40) NOT NULL,
  `Phone` varchar(40) NOT NULL,
  `DOB` date NOT NULL,
  `Joined` date NOT NULL,
  PRIMARY KEY (`Staff_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (125,'Gibson','Pamela','946 Little Fleur Circle','Texíguat','504-(594)339-7184','1952-10-29','2004-10-21'),(126,'Rose','Larry','6532 Bluejay Court','Vinh Tu?ng','84-(788)551-9913','1982-10-22','1999-08-28'),(127,'Torres','Jessica','150 Norway Maple Pass','Trondheim','47-(455)311-5431','1968-04-05','2008-01-29'),(128,'Ross','Joshua','5 Buena Vista Street','Salitrillos','506-(338)339-4992','1977-01-03','2005-11-26'),(129,'Carroll','Judy','3 Magdeline Place','Miaoli','886-(436)515-5672','1970-07-29','2000-03-27'),(130,'Gray','Kenneth','7 Fulton Circle','Ylämaa','358-(193)287-2678','1961-07-28','2000-07-31'),(131,'Bradley','Ronald','62 Transport Avenue','Awat','86-(493)294-3499','1962-03-01','2002-02-11'),(132,'Kim','Virginia','96676 Porter Way','Jinqiao','86-(258)625-5250','2002-01-05','2005-08-05'),(133,'Marshall','Robert','23 Pankratz Center','Roissy Charles-de-Gaulle','33-(420)635-0396','1956-09-28','2006-05-08'),(134,'Burns','Patricia','0812 Nelson Parkway','Tala','598-(469)410-2271','1968-09-28','1999-03-22');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `station_status`
--

DROP TABLE IF EXISTS `station_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `station_status` (
  `S_Status_ID` int NOT NULL,
  `Station_ID` int NOT NULL,
  `S_Status` varchar(40) NOT NULL,
  `Capacity` int NOT NULL,
  `Parking` int NOT NULL,
  `Bikes` int NOT NULL,
  `Updated` datetime(6) NOT NULL,
  PRIMARY KEY (`S_Status_ID`),
  KEY `Station_FK` (`Station_ID`),
  CONSTRAINT `Station_FK` FOREIGN KEY (`Station_ID`) REFERENCES `stations` (`Station_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `station_status`
--

LOCK TABLES `station_status` WRITE;
/*!40000 ALTER TABLE `station_status` DISABLE KEYS */;
/*!40000 ALTER TABLE `station_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stations`
--

DROP TABLE IF EXISTS `stations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stations` (
  `Station_ID` int NOT NULL,
  `Location` varchar(40) NOT NULL,
  `Address` varchar(40) NOT NULL,
  `Latitude` decimal(9,6) NOT NULL,
  `Longitude` decimal(9,6) NOT NULL,
  `Banking` tinyint(1) NOT NULL,
  PRIMARY KEY (`Station_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stations`
--

LOCK TABLES `stations` WRITE;
/*!40000 ALTER TABLE `stations` DISABLE KEYS */;
INSERT INTO `stations` VALUES (1,'Parker','William',22.650000,93.616670,1),(2,'Mitchell','Clarence',-24.885000,28.294170,1),(3,'Sanders','Lisa',23.575540,116.147330,0),(4,'Morrison','Jacqueline',52.006700,4.355600,0),(5,'Meyer','Timothy',-3.409700,119.307700,1),(6,'Burke','Carl',7.928060,126.067220,1),(7,'Wagner','Arthur',30.247120,108.483360,0),(8,'Garza','Ruth',-22.821940,-47.266940,0),(9,'Perez','Susan',48.000000,-4.100000,0),(10,'Warren','Steven',55.833330,24.966670,0),(11,'Fuller','Sharon',28.563770,117.522320,1),(12,'Brown','Barbara',35.613580,111.356600,0),(13,'Wilson','Steven',54.654550,19.909290,0),(14,'Fowler','Elizabeth',22.619350,112.467820,1),(15,'Reynolds','Annie',47.902900,1.903900,1),(16,'Parker','Juan',-18.764100,-64.619780,1),(17,'Hunt','Joyce',50.085780,106.185780,1),(18,'Campbell','Amy',-25.450000,-55.000000,0),(19,'Bryant','Nicholas',-29.791710,-58.054600,0),(20,'Shaw','Victor',27.776200,-97.427100,1),(21,'Ross','Alice',24.794960,116.815000,1),(22,'Richards','Gloria',29.283390,120.027560,0),(23,'Hill','Alice',23.258380,116.175420,0),(24,'Knight','Joshua',26.336940,127.871940,0),(25,'Reid','Kimberly',36.750000,138.366670,1),(26,'Bishop','Harry',59.402200,18.353200,1),(27,'Torres','Margaret',49.938900,19.889720,0),(28,'Patterson','Victor',-9.583330,33.850000,0),(29,'Payne','Lawrence',5.976500,116.115800,1),(30,'Palmer','Christina',-8.096500,111.632800,1);
/*!40000 ALTER TABLE `stations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vans`
--

DROP TABLE IF EXISTS `vans`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vans` (
  `Licence_ID` varchar(10) NOT NULL,
  `Station_ID` int NOT NULL,
  `Staff_ID` int NOT NULL,
  `Date_stamp` date NOT NULL,
  `Bikes` int NOT NULL,
  `Station_end` varchar(50) NOT NULL,
  PRIMARY KEY (`Licence_ID`),
  KEY `Staff_FK` (`Staff_ID`),
  KEY `Station_FK_van` (`Station_ID`),
  CONSTRAINT `Staff_FK` FOREIGN KEY (`Staff_ID`) REFERENCES `staff` (`Staff_ID`),
  CONSTRAINT `Station_FK_van` FOREIGN KEY (`Station_ID`) REFERENCES `stations` (`Station_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vans`
--

LOCK TABLES `vans` WRITE;
/*!40000 ALTER TABLE `vans` DISABLE KEYS */;
INSERT INTO `vans` VALUES ('AR-690-m',27,130,'2015-04-25',15,'12'),('AY-377-y',28,128,'2016-01-01',15,'14'),('BM-427-i',30,129,'2016-03-04',18,'5'),('BT-920-v',1,127,'2015-10-10',27,'17'),('CA-945-z',30,127,'2015-09-14',12,'8'),('CM-623-x',28,129,'2016-02-21',18,'18'),('DM-264-c',13,133,'2016-01-04',21,'19'),('DP-700-k',7,126,'2015-08-16',12,'21'),('EB-134-z',6,132,'2015-09-26',21,'25'),('EN-751-y',16,132,'2015-12-23',28,'29'),('EQ-804-g',12,128,'2015-03-25',28,'19'),('FG-369-i',13,131,'2015-10-12',16,'26'),('FH-146-z',16,128,'2015-11-13',17,'23'),('FM-703-a',9,130,'2015-05-30',25,'28'),('FU-430-a',19,133,'2015-12-08',14,'17'),('FZ-355-a',17,128,'2015-04-17',22,'12'),('GZ-139-d',11,131,'2015-09-24',22,'5'),('HK-119-z',27,129,'2015-08-28',30,'21'),('HO-624-t',30,127,'2015-08-15',13,'16'),('IC-235-g',18,128,'2015-04-18',25,'4'),('IH-684-z',9,131,'2015-08-01',22,'27'),('IL-257-w',20,130,'2015-04-14',18,'16'),('JO-404-s',20,129,'2015-07-06',28,'13'),('KF-908-y',10,125,'2016-01-08',15,'14'),('KR-199-a',11,130,'2016-02-10',18,'10'),('LE-766-m',21,134,'2016-01-13',24,'22'),('MS-241-w',4,129,'2015-11-14',15,'10'),('MY-737-o',9,125,'2015-08-06',16,'23'),('NO-951-m',25,133,'2015-11-18',24,'15'),('NP-805-q',21,133,'2016-02-07',17,'15'),('OD-745-s',2,133,'2015-07-11',26,'24'),('OL-511-t',7,125,'2016-03-08',27,'27'),('ON-443-b',27,131,'2015-09-05',23,'11'),('PQ-003-k',13,125,'2015-06-22',19,'23'),('QP-535-n',13,131,'2015-04-06',19,'25'),('QY-518-f',11,127,'2015-04-30',14,'15'),('RH-672-f',29,125,'2015-07-25',15,'18'),('TF-763-s',6,133,'2015-04-12',26,'19'),('TM-182-e',21,127,'2015-09-18',28,'26'),('US-041-f',10,134,'2015-10-29',25,'12'),('VO-236-t',2,127,'2015-05-23',22,'13'),('WI-853-n',24,130,'2015-11-30',30,'17'),('WJ-778-k',14,130,'2015-11-26',16,'17'),('XG-197-i',8,126,'2015-12-18',23,'26'),('XP-587-v',2,128,'2015-10-16',28,'21'),('XQ-344-l',5,134,'2015-10-23',12,'11'),('YF-758-h',13,130,'2015-08-07',26,'4'),('ZB-895-i',20,128,'2015-05-23',23,'3'),('ZL-663-y',17,126,'2015-10-18',27,'28'),('ZM-157-f',3,129,'2015-12-21',16,'17');
/*!40000 ALTER TABLE `vans` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-13  0:04:15
