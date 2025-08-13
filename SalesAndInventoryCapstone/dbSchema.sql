-- --------------------------------------------------------
-- Host:                         localhost
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
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.categories: ~9 rows (approximately)
REPLACE INTO `categories` (`Id`, `Name`) VALUES
	(23, 'Brake System'),
	(25, 'Cabin Accessories'),
	(16, 'category 1'),
	(24, 'Cooling System'),
	(22, 'Engine Components'),
	(19, 'Hydraulic System'),
	(21, 'Suspension System'),
	(20, 'Transmission Parts'),
	(26, 'Wheel Assembly');

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
  CONSTRAINT `FK_inventories_products` FOREIGN KEY (`ProductId`) REFERENCES `products` (`Id`) ON DELETE SET NULL ON UPDATE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.inventories: ~5 rows (approximately)
REPLACE INTO `inventories` (`Id`, `Code`, `ProductId`, `CurrentStock`, `StockIn`, `StockOut`, `OriginalPrice`, `SellingPrice`, `Remarks`) VALUES
	(7, 'P2', 25, 67, 10, 0, 250.00, 300.00, ''),
	(8, 'PTOSHAFT', 23, 30, 10, 0, 1000.00, 1500.00, ''),
	(9, 'HPUMP', 22, 60, 10, 0, 899.00, 1000.00, ''),
	(10, 'CLUTCH_PLATE', 27, 20, 0, 0, 950.00, 1000.00, '');

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

-- Dumping data for table salesinventory.notifications: ~4 rows (approximately)

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
  CONSTRAINT `FK__categories` FOREIGN KEY (`CategoryId`) REFERENCES `categories` (`Id`) ON DELETE SET NULL ON UPDATE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.products: ~8 rows (approximately)
REPLACE INTO `products` (`Id`, `CreatedAt`, `ProductName`, `ProductDescription`, `CategoryId`) VALUES
	(22, '2025-08-04 02:32:16', 'Hydraulic Pump', 'High-pressure pump for hydraulic fluid transfer', 19),
	(23, '2025-08-04 02:32:54', 'PTO Shaft', 'Power Take-Off shaft for transmitting engine power', 20),
	(24, '2025-08-04 02:35:16', 'Front Axle Assembly', 'Complete front axle for 4WD tractor models', 21),
	(25, '2025-08-04 02:36:40', 'Fuel Injector', 'Precision injector for diesel engine combustion', 22),
	(26, '2025-08-04 02:37:09', 'Air Filter Element', 'Filters air intake to prevent engine contamination', 22),
	(27, '2025-08-04 02:39:07', 'Clutch Plate', 'Friction plate for transmission engagement', 20),
	(28, '2025-08-04 02:39:23', 'Brake Disc', 'Heavy-duty brake disc for rear wheels', 23),
	(29, '2025-08-04 02:39:45', 'Radiator Hose', 'Flexible hose for engine cooling system', 24),
	(30, '2025-08-04 02:40:16', 'Tractor Seat Cushion', 'Padded seat cushion with ergonomic support', 25),
	(31, '2025-08-04 02:40:37', 'Rear Wheel Rim', 'Steel rim compatible with 18-inch tractor tires', 26);

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
REPLACE INTO `roles` (`Id`, `Name`) VALUES
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
  PRIMARY KEY (`Id`),
  KEY `SalesId` (`SalesId`) USING BTREE,
  KEY `InventoryId` (`InventoryId`),
  CONSTRAINT `FK_saleitem_inventories` FOREIGN KEY (`InventoryId`) REFERENCES `inventories` (`Id`),
  CONSTRAINT `FK_saleitem_sales` FOREIGN KEY (`SalesId`) REFERENCES `sales` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.saleitem: ~3 rows (approximately)
REPLACE INTO `saleitem` (`Id`, `SalesId`, `InventoryId`, `Quantity`, `Price`) VALUES
	(6, 10, 7, 1, 300.00);

-- Dumping structure for table salesinventory.sales
CREATE TABLE IF NOT EXISTS `sales` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ReferenceNumber` varchar(50) DEFAULT NULL,
  `TotalSales` decimal(18,2) unsigned NOT NULL,
  `CashGiven` decimal(18,2) unsigned NOT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `FirstName` varchar(50) DEFAULT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `ReferenceNumber` (`ReferenceNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.sales: ~2 rows (approximately)
REPLACE INTO `sales` (`Id`, `ReferenceNumber`, `TotalSales`, `CashGiven`, `LastName`, `FirstName`, `MiddleName`) VALUES
	(10, 'C2FF5F9E-98AD-410B-8157-66E5AC5CBD6E', 300.00, 500.00, 'Dela Cruz', 'Juan', 'Tamad');

-- Dumping structure for table salesinventory.users
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LastName` varchar(100) NOT NULL DEFAULT '0',
  `FirstName` varchar(100) NOT NULL DEFAULT '0',
  `Username` varchar(100) NOT NULL DEFAULT '0',
  `Password` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.users: ~2 rows (approximately)
REPLACE INTO `users` (`Id`, `LastName`, `FirstName`, `Username`, `Password`) VALUES
	(10, 'Admin', 'Admin', 'admin', '$2a$11$aZmSS9lvkgKGvzbMh02YwuMnzmtZBFmclOMt87dPTf9coFcwe85LO'),
	(11, 'Sales', 'Sales', 'sales', '$2a$11$zHozTJEy8EMWgCZKU3np6OtY4eoMUpDQMj9zjHrNtCPsacor8x5Lq'),
	(12, 'Inventory', 'Inventory', 'inventory', '$2a$11$WtgTSYlpKiuAo804CXU20uDTcX9xd.z4jRQNksmDpCxoHQxT19eP6');

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

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
