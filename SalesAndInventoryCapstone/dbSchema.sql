-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.42 - MySQL Community Server - GPL
-- Server OS:                    Linux
-- HeidiSQL Version:             12.8.0.6908
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping structure for table salesinventory.categories
CREATE TABLE IF NOT EXISTS `categories` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.categories: ~8 rows (approximately)
INSERT INTO `categories` (`Id`, `Name`) VALUES
	(23, 'Brake System'),
	(24, 'Cooling System'),
	(31, 'Edit Testing'),
	(22, 'Engine Components'),
	(19, 'Hydraulic System'),
	(27, 'Sample category'),
	(21, 'Suspension System');

-- Dumping structure for table salesinventory.inventories
CREATE TABLE IF NOT EXISTS `inventories` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Code` varchar(50) DEFAULT NULL,
  `ProductId` int DEFAULT NULL,
  `CurrentStock` int NOT NULL DEFAULT '0',
  `StockIn` int NOT NULL DEFAULT '0',
  `StockOut` int NOT NULL DEFAULT '0',
  `OriginalPrice` decimal(18,2) DEFAULT NULL,
  `SellingPrice` decimal(18,2) DEFAULT NULL,
  `Remarks` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Code` (`Code`),
  KEY `ProductId` (`ProductId`),
  CONSTRAINT `FK_inventories_products` FOREIGN KEY (`ProductId`) REFERENCES `products` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.inventories: ~2 rows (approximately)
INSERT INTO `inventories` (`Id`, `Code`, `ProductId`, `CurrentStock`, `StockIn`, `StockOut`, `OriginalPrice`, `SellingPrice`, `Remarks`) VALUES
	(7, 'P2', 25, 0, 10, 0, 250.00, 300.00, ''),
	(9, 'HPUMP', 22, 50, 10, 0, 899.00, 1000.00, '');

-- Dumping structure for view salesinventory.inventoriesview
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `inventoriesview` (
	`Id` INT NOT NULL,
	`Code` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`ProductId` INT NULL,
	`ProductName` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`ProductDescription` LONGTEXT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`CategoryName` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`CurrentStock` INT NOT NULL,
	`StockIn` INT NOT NULL,
	`StockOut` INT NOT NULL,
	`OriginalPrice` DECIMAL(18,2) NULL,
	`SellingPrice` DECIMAL(18,2) NULL,
	`Remarks` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci'
) ENGINE=MyISAM;

-- Dumping structure for table salesinventory.notifications
CREATE TABLE IF NOT EXISTS `notifications` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `InventoryId` int NOT NULL,
  `Message` text NOT NULL,
  `IsRead` tinyint(1) DEFAULT '0',
  `CreatedAt` timestamp NOT NULL DEFAULT (now()),
  PRIMARY KEY (`Id`),
  KEY `InventoryId` (`InventoryId`),
  CONSTRAINT `notifications_ibfk_1` FOREIGN KEY (`InventoryId`) REFERENCES `inventories` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.notifications: ~0 rows (approximately)

-- Dumping structure for table salesinventory.products
CREATE TABLE IF NOT EXISTS `products` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CreatedAt` timestamp NOT NULL,
  `ProductName` varchar(100) DEFAULT NULL,
  `ProductDescription` longtext,
  `CategoryId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `ProductName` (`ProductName`),
  KEY `FK__categories` (`CategoryId`),
  CONSTRAINT `FK__categories` FOREIGN KEY (`CategoryId`) REFERENCES `categories` (`Id`) ON DELETE CASCADE ON UPDATE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.products: ~6 rows (approximately)
INSERT INTO `products` (`Id`, `CreatedAt`, `ProductName`, `ProductDescription`, `CategoryId`) VALUES
	(22, '2025-08-04 02:32:16', 'Hydraulic Pumps', 'High-pressure pump for hydraulic fluid transfer', 19),
	(24, '2025-08-04 02:35:16', 'Front Axle Assembly', 'Complete front axle for 4WD tractor models', 21),
	(25, '2025-08-04 02:36:40', 'Fuel Injector', 'Precision injector for diesel engine combustion', 22),
	(26, '2025-08-04 02:37:09', 'Air Filter Element', 'Filters air intake to prevent engine contamination', 22),
	(28, '2025-08-04 02:39:23', 'Brake Disc', 'Heavy-duty brake disc for rear wheels', 23),
	(29, '2025-08-04 02:39:45', 'Radiator Hose', 'Flexible hose for engine cooling system', 24);

-- Dumping structure for view salesinventory.productsview
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `productsview` (
	`Id` INT NOT NULL,
	`ProductName` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`ProductDescription` LONGTEXT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`Category` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`CategoryId` INT NULL
) ENGINE=MyISAM;

-- Dumping structure for table salesinventory.roles
CREATE TABLE IF NOT EXISTS `roles` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.roles: ~3 rows (approximately)
INSERT INTO `roles` (`Id`, `Name`) VALUES
	(5, 'Admin'),
	(6, 'Sales'),
	(7, 'Inventory');

-- Dumping structure for table salesinventory.saleitem
CREATE TABLE IF NOT EXISTS `saleitem` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `SalesId` int NOT NULL DEFAULT '0',
  `InventoryId` int DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  `Price` decimal(18,2) NOT NULL,
  `OriginalPrice` decimal(18,2) DEFAULT NULL,
  `SellingPrice` decimal(18,2) DEFAULT NULL,
  `Profit` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `SalesId` (`SalesId`) USING BTREE,
  KEY `InventoryId` (`InventoryId`),
  CONSTRAINT `FK_saleitem_inventories` FOREIGN KEY (`InventoryId`) REFERENCES `inventories` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_saleitem_sales` FOREIGN KEY (`SalesId`) REFERENCES `sales` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.saleitem: ~17 rows (approximately)
INSERT INTO `saleitem` (`Id`, `SalesId`, `InventoryId`, `Quantity`, `Price`, `OriginalPrice`, `SellingPrice`, `Profit`) VALUES
	(9, 12, 7, 5, 1500.00, 1250.00, 1500.00, 250.00),
	(11, 13, 9, 5, 5000.00, 4495.00, 5000.00, 505.00),
	(13, 15, 7, 1, 300.00, 250.00, 300.00, 50.00),
	(15, 16, 9, 1, 1000.00, 899.00, 1000.00, 101.00),
	(17, 18, 9, 1, 1000.00, 899.00, 1000.00, 101.00),
	(18, 19, 9, 1, 1000.00, 899.00, 1000.00, 101.00),
	(19, 20, 7, 1, 300.00, 250.00, 300.00, 50.00),
	(20, 21, 7, 1, 300.00, 250.00, 300.00, 50.00),
	(21, 22, 7, 1, 300.00, 250.00, 300.00, 50.00),
	(22, 23, 7, 1, 300.00, 250.00, 300.00, 50.00),
	(23, 24, 9, 1, 1000.00, 899.00, 1000.00, 101.00),
	(25, 26, 9, 1, 1000.00, 899.00, 1000.00, 101.00),
	(26, 27, 7, 1, 300.00, 250.00, 300.00, 50.00);

-- Dumping structure for view salesinventory.saleitemview
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `saleitemview` (
	`Id` INT NOT NULL,
	`SaleId` INT NOT NULL,
	`CreatedAt` TIMESTAMP NULL,
	`ReferenceNo` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`ProductName` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`Category` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`Quantity` INT NULL,
	`Price` DECIMAL(18,2) NOT NULL,
	`OriginalPrice` DECIMAL(18,2) NULL,
	`SellingPrice` DECIMAL(18,2) NULL,
	`Profit` DECIMAL(18,2) NULL
) ENGINE=MyISAM;

-- Dumping structure for table salesinventory.sales
CREATE TABLE IF NOT EXISTS `sales` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ReferenceNumber` varchar(50) DEFAULT NULL,
  `TotalSales` decimal(18,2) unsigned NOT NULL,
  `CashGiven` decimal(18,2) unsigned NOT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `CreatedAt` timestamp NOT NULL DEFAULT (now()),
  `OriginalPrice` decimal(18,2) DEFAULT NULL,
  `SellingPrice` decimal(18,2) DEFAULT NULL,
  `Profit` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `ReferenceNumber` (`ReferenceNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.sales: ~15 rows (approximately)
INSERT INTO `sales` (`Id`, `ReferenceNumber`, `TotalSales`, `CashGiven`, `LastName`, `FirstName`, `MiddleName`, `CreatedAt`, `OriginalPrice`, `SellingPrice`, `Profit`) VALUES
	(12, '5DE08E01-6186-4636-9703-56413E135B80', 4500.00, 5000.00, 'Dela Cruz', 'Juan', 'Tamad', '2025-09-06 05:26:30', 3250.00, 4500.00, 1250.00),
	(13, '81DA52DD-A7C0-4609-AE62-EA8AC7CF79FB', 5000.00, 5000.00, 'James', 'Lebron', 'James', '2025-09-07 12:50:23', 4495.00, 5000.00, 505.00),
	(14, 'D9489661-A7D6-40CC-BDCA-36CB6EBDA96D', 1000.00, 1000.00, 'Perez', 'Sergio', 'Ballad', '2025-09-09 11:18:53', 950.00, 1000.00, 50.00),
	(15, '9148A41A-9901-4D8E-A31E-CC053C16FB3D', 300.00, 300.00, 'Sample', 'Name', 'One', '2025-09-25 03:04:13', 250.00, 300.00, 50.00),
	(16, '0D1C4C75-69F6-483E-804B-E4CBD05E558B', 2500.00, 3000.00, 'testing', 'two', 'customer', '2025-09-25 03:55:41', 1899.00, 2500.00, 601.00),
	(17, 'CE804D28-4472-4A5D-8799-8C657D6273EB', 1000.00, 1000.00, 'askdjhaskdjh', 'kjashdkjashdkjh', 'aksjdhaksjdh', '2025-09-25 03:58:28', 950.00, 1000.00, 50.00),
	(18, '259CB41D-48B6-4853-864C-597B6D809947', 1000.00, 1000.00, 'askdjhaksjh', 'kjhaskdjhk', 'jhakjsdhkjh', '2025-09-25 05:04:57', 899.00, 1000.00, 101.00),
	(19, '39D48024-341A-4593-A6E0-2ACABEDBD51A', 1000.00, 1000.00, 'asdasd', 'asdasd', 'asdasd', '2025-09-25 05:30:13', 899.00, 1000.00, 101.00),
	(20, '19C10173-D9A3-43A4-BCF9-40494E6454D6', 300.00, 300.00, 'asdasd', 'asdasdasd', 'sdasd', '2025-09-25 05:31:47', 250.00, 300.00, 50.00),
	(21, '4A733205-B7E5-4648-BE08-555EF268BC5C', 300.00, 300.00, 'asdasd', 'asdasd', 'asdasd', '2025-09-25 05:32:55', 250.00, 300.00, 50.00),
	(22, '87131665-CEBE-4FBB-81DF-0CCF48382189', 300.00, 300.00, 'asdasda', 'asdasdasd', 'asdasd', '2025-09-25 05:33:51', 250.00, 300.00, 50.00),
	(23, '4CD7541C-49F0-4433-94BF-C24C518D4CC6', 300.00, 300.00, 'asdasd', 'sdasdasd', 'sdasdasd', '2025-09-25 05:34:58', 250.00, 300.00, 50.00),
	(24, '1906F3FB-4F38-4AEE-BE2A-A038D2D9509B', 1000.00, 1000.00, 'askdjhaskdjh', 'aksjdhaskjdh', 'kjahskdjhaks', '2025-09-25 06:08:15', 899.00, 1000.00, 101.00),
	(25, '9270C478-CD31-417A-A707-5F3917A8448D', 1500.00, 2000.00, 'asdasd', 'sdasd', 'sdasd', '2025-09-25 06:11:35', 1000.00, 1500.00, 500.00),
	(26, '7AC47947-31D4-4399-8100-AB5AA77CE948', 1000.00, 1000.00, 'asdasdasd', 'asdasdasd', 'asdasdasd', '2025-09-25 06:13:52', 899.00, 1000.00, 101.00),
	(27, '4C4DC6E9-C7DE-4696-9659-830B70D9973F', 300.00, 300.00, 'askdjashd', 'kajsdhakjsdh', 'kajshdkajsdh', '2025-09-25 06:19:19', 250.00, 300.00, 50.00);

-- Dumping structure for table salesinventory.users
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LastName` varchar(100) NOT NULL DEFAULT '0',
  `FirstName` varchar(100) NOT NULL DEFAULT '0',
  `Username` varchar(100) NOT NULL DEFAULT '0',
  `Password` varchar(100) NOT NULL DEFAULT '0',
  `Role` varchar(50) NOT NULL DEFAULT 'User',
  `IsEnabled` tinyint NOT NULL,
  `FailedAttempt` int NOT NULL,
  `IsLockedOut` tinyint NOT NULL,
  `LastLockedOut` timestamp NULL DEFAULT NULL,
  `SecurityQuestion` varchar(255) DEFAULT NULL,
  `SecurityAnswer` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.users: ~4 rows (approximately)
INSERT INTO `users` (`Id`, `LastName`, `FirstName`, `Username`, `Password`, `Role`, `IsEnabled`, `FailedAttempt`, `IsLockedOut`, `LastLockedOut`, `SecurityQuestion`, `SecurityAnswer`) VALUES
	(10, 'Admin', 'Admin', 'admin', '$2a$11$tJ0sMzj4mDrf1Rn6Q364/evf5jGU4h9l/RJdmFWoRpQ2wfSzli0h2', 'Admin', 1, 0, 1, '2025-10-19 10:39:07', 'Security Question Number 1', 'Answer 1'),
	(11, 'Sales', 'Sales', 'sales', '$2a$11$zHozTJEy8EMWgCZKU3np6OtY4eoMUpDQMj9zjHrNtCPsacor8x5Lq', 'User', 1, 0, 0, NULL, NULL, NULL),
	(12, 'Inventory', 'Inventory', 'inventory', '$2a$11$WtgTSYlpKiuAo804CXU20uDTcX9xd.z4jRQNksmDpCxoHQxT19eP6', 'User', 0, 0, 0, NULL, NULL, NULL),
	(13, 'Dela Cruz', 'Juan', 'juan', '$2a$11$Xm8SLhSSFXE5oFPNKGRDX.89RJYkrZ4xgpN1yqh0M1yEsN8i1AOwm', 'User', 0, 0, 0, NULL, NULL, NULL);

-- Dumping structure for table salesinventory.user_role
CREATE TABLE IF NOT EXISTS `user_role` (
  `UserId` int NOT NULL,
  `RoleId` int NOT NULL,
  KEY `UserId` (`UserId`),
  KEY `RoleId` (`RoleId`),
  CONSTRAINT `RoleFK` FOREIGN KEY (`RoleId`) REFERENCES `roles` (`Id`),
  CONSTRAINT `UserFk` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.user_role: ~0 rows (approximately)

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `inventoriesview`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `inventoriesview` AS select `i`.`Id` AS `Id`,`i`.`Code` AS `Code`,`p`.`Id` AS `ProductId`,`p`.`ProductName` AS `ProductName`,`p`.`ProductDescription` AS `ProductDescription`,`c`.`Name` AS `CategoryName`,`i`.`CurrentStock` AS `CurrentStock`,`i`.`StockIn` AS `StockIn`,`i`.`StockOut` AS `StockOut`,`i`.`OriginalPrice` AS `OriginalPrice`,`i`.`SellingPrice` AS `SellingPrice`,`i`.`Remarks` AS `Remarks` from ((`inventories` `i` left join `products` `p` on((`i`.`ProductId` = `p`.`Id`))) left join `categories` `c` on((`p`.`CategoryId` = `c`.`Id`)));

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `productsview`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `productsview` AS select `p`.`Id` AS `Id`,`p`.`ProductName` AS `ProductName`,`p`.`ProductDescription` AS `ProductDescription`,`c`.`Name` AS `Category`,`c`.`Id` AS `CategoryId` from (`products` `p` left join `categories` `c` on((`p`.`CategoryId` = `c`.`Id`)));

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `saleitemview`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `saleitemview` AS select `si`.`Id` AS `Id`,`si`.`SalesId` AS `SaleId`,`s`.`CreatedAt` AS `CreatedAt`,`s`.`ReferenceNumber` AS `ReferenceNo`,`p`.`ProductName` AS `ProductName`,`c`.`Name` AS `Category`,`si`.`Quantity` AS `Quantity`,`si`.`Price` AS `Price`,`si`.`OriginalPrice` AS `OriginalPrice`,`si`.`SellingPrice` AS `SellingPrice`,`si`.`Profit` AS `Profit` from ((((`saleitem` `si` left join `sales` `s` on((`s`.`Id` = `si`.`SalesId`))) left join `inventories` `i` on((`i`.`Id` = `si`.`InventoryId`))) left join `products` `p` on((`p`.`Id` = `i`.`ProductId`))) left join `categories` `c` on((`c`.`Id` = `p`.`CategoryId`)));

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
