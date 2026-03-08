-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.42 - MySQL Community Server - GPL
-- Server OS:                    Linux
-- HeidiSQL Version:             12.10.0.7000
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
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.categories: ~5 rows (approximately)
INSERT INTO `categories` (`Id`, `Name`) VALUES
	(41, 'category 1'),
	(42, 'category 2'),
	(43, 'category 3'),
	(44, 'category 4'),
	(45, 'category 5');

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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.inventories: ~0 rows (approximately)
INSERT INTO `inventories` (`Id`, `Code`, `ProductId`, `CurrentStock`, `StockIn`, `StockOut`, `OriginalPrice`, `SellingPrice`, `Remarks`) VALUES
	(12, 'code1', 35, 57, 10, 0, 50.00, 100.00, 'sample remarks');

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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.products: ~0 rows (approximately)
INSERT INTO `products` (`Id`, `CreatedAt`, `ProductName`, `ProductDescription`, `CategoryId`) VALUES
	(35, '2026-03-07 08:36:22', 'product 1', 'product 1 description', 41);

-- Dumping structure for view salesinventory.productsview
-- Creating temporary table to overcome VIEW dependency errors
CREATE TABLE `productsview` (
	`Id` INT NOT NULL,
	`CreatedAt` TIMESTAMP NOT NULL,
	`Code` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`ProductName` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`ProductDescription` LONGTEXT NULL COLLATE 'utf8mb4_0900_ai_ci',
	`CategoryId` INT NULL,
	`Category` VARCHAR(1) NULL COLLATE 'utf8mb4_0900_ai_ci',
	`OriginalPrice` DECIMAL(18,2) NULL,
	`SellingPrice` DECIMAL(18,2) NULL
) ENGINE=MyISAM;

-- Dumping structure for table salesinventory.roles
CREATE TABLE IF NOT EXISTS `roles` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.roles: ~0 rows (approximately)

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
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.saleitem: ~2 rows (approximately)
INSERT INTO `saleitem` (`Id`, `SalesId`, `InventoryId`, `Quantity`, `Price`, `OriginalPrice`, `SellingPrice`, `Profit`) VALUES
	(35, 34, 12, 1, 100.00, 50.00, 100.00, 50.00),
	(36, 34, 12, 1, 100.00, 50.00, 100.00, 50.00),
	(37, 34, 12, 1, 100.00, 50.00, 100.00, 50.00);

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
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.sales: ~0 rows (approximately)
INSERT INTO `sales` (`Id`, `ReferenceNumber`, `TotalSales`, `CashGiven`, `LastName`, `FirstName`, `MiddleName`, `CreatedAt`, `OriginalPrice`, `SellingPrice`, `Profit`) VALUES
	(34, 'A2626BA7-0972-49EC-989B-C2D5F068BBD5', 300.00, 300.00, 'name', 'name', 'name', '2026-03-07 08:46:07', 150.00, 300.00, 150.00);

-- Dumping structure for table salesinventory.SecurityQuestions
CREATE TABLE IF NOT EXISTS `SecurityQuestions` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` int NOT NULL DEFAULT '0',
  `SecurityQuestion` varchar(100) NOT NULL DEFAULT '0',
  `SecurityAnswer` varchar(255) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`),
  KEY `FK__users` (`UserId`),
  CONSTRAINT `FK__users` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.SecurityQuestions: ~3 rows (approximately)
INSERT INTO `SecurityQuestions` (`Id`, `UserId`, `SecurityQuestion`, `SecurityAnswer`) VALUES
	(3, 16, 'What is the name of your first school?', 'answer1'),
	(4, 16, 'What is the name of the city where you were born?', 'answer2'),
	(5, 16, 'What is the name of the street you grew up on?', 'answer3'),
	(6, 17, 'What is the name of your first school?', 'answer1'),
	(7, 17, 'What is the name of the city where you were born?', 'asnwer2');

-- Dumping structure for table salesinventory.users
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LastName` varchar(100) NOT NULL DEFAULT '0',
  `FirstName` varchar(100) NOT NULL DEFAULT '0',
  `username` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `Role` varchar(50) NOT NULL DEFAULT 'User',
  `IsEnabled` tinyint NOT NULL,
  `FailedAttempt` int NOT NULL,
  `IsLockedOut` tinyint NOT NULL,
  `LastLockedOut` timestamp NULL DEFAULT NULL,
  `SecurityQuestion` varchar(255) DEFAULT NULL,
  `SecurityAnswer` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.users: ~0 rows (approximately)
INSERT INTO `users` (`Id`, `LastName`, `FirstName`, `username`, `password`, `Role`, `IsEnabled`, `FailedAttempt`, `IsLockedOut`, `LastLockedOut`, `SecurityQuestion`, `SecurityAnswer`) VALUES
	(15, 'Admin', 'Admin', 'admin', 'password', 'Admin', 1, 3, 0, NULL, NULL, NULL),
	(16, 'user', 'user', 'user', 'password', 'User', 1, 0, 0, NULL, NULL, NULL),
	(17, 'user2', 'user2', 'user2', 'password', 'User', 1, 0, 0, NULL, NULL, NULL);

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
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `inventoriesview` AS select `i`.`Id` AS `Id`,`i`.`Code` AS `Code`,`p`.`Id` AS `ProductId`,`p`.`ProductName` AS `ProductName`,`p`.`ProductDescription` AS `ProductDescription`,`c`.`Name` AS `CategoryName`,`i`.`CurrentStock` AS `CurrentStock`,`i`.`StockIn` AS `StockIn`,`i`.`StockOut` AS `StockOut`,`i`.`OriginalPrice` AS `OriginalPrice`,`i`.`SellingPrice` AS `SellingPrice`,`i`.`Remarks` AS `Remarks` from ((`inventories` `i` left join `products` `p` on((`i`.`ProductId` = `p`.`Id`))) left join `categories` `c` on((`p`.`CategoryId` = `c`.`Id`)))
;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `productsview`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `productsview` AS select `p`.`Id` AS `Id`,`p`.`CreatedAt` AS `CreatedAt`,`i`.`Code` AS `Code`,`p`.`ProductName` AS `ProductName`,`p`.`ProductDescription` AS `ProductDescription`,`c`.`Id` AS `CategoryId`,`c`.`Name` AS `Category`,`i`.`OriginalPrice` AS `OriginalPrice`,`i`.`SellingPrice` AS `SellingPrice` from ((`products` `p` left join `inventories` `i` on((`p`.`Id` = `i`.`ProductId`))) left join `categories` `c` on((`p`.`CategoryId` = `c`.`Id`)))
;

-- Removing temporary table and create final VIEW structure
DROP TABLE IF EXISTS `saleitemview`;
CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `saleitemview` AS select `si`.`Id` AS `Id`,`si`.`SalesId` AS `SaleId`,`s`.`CreatedAt` AS `CreatedAt`,`s`.`ReferenceNumber` AS `ReferenceNo`,`p`.`ProductName` AS `ProductName`,`c`.`Name` AS `Category`,`si`.`Quantity` AS `Quantity`,`si`.`Price` AS `Price`,`si`.`OriginalPrice` AS `OriginalPrice`,`si`.`SellingPrice` AS `SellingPrice`,`si`.`Profit` AS `Profit` from ((((`saleitem` `si` left join `sales` `s` on((`s`.`Id` = `si`.`SalesId`))) left join `inventories` `i` on((`i`.`Id` = `si`.`InventoryId`))) left join `products` `p` on((`p`.`Id` = `i`.`ProductId`))) left join `categories` `c` on((`c`.`Id` = `p`.`CategoryId`)))
;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
