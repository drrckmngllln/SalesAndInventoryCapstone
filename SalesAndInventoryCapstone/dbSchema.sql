-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.4.5 - MySQL Community Server - GPL
-- Server OS:                    Win64
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
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.categories: ~7 rows (approximately)
REPLACE INTO `categories` (`Id`, `Name`) VALUES
	(16, 'category 1'),
	(10, 'jump over'),
	(12, 'near the riverbanks'),
	(8, 'some text'),
	(15, 'the categories'),
	(11, 'the lazy dog'),
	(9, 'the quick brown fox');

-- Dumping structure for table salesinventory.inventories
CREATE TABLE IF NOT EXISTS `inventories` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CategoryId` int NOT NULL DEFAULT '0',
  `Code` varchar(50) DEFAULT NULL,
  `Description` varchar(100) DEFAULT NULL,
  `CurrentStock` int NOT NULL DEFAULT '0',
  `StockIn` int NOT NULL DEFAULT '0',
  `StockOut` int NOT NULL DEFAULT '0',
  `OriginalPrice` decimal(18,2) DEFAULT NULL,
  `SellingPrice` decimal(18,2) DEFAULT NULL,
  `Remarks` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Code` (`Code`),
  KEY `CategoryId` (`CategoryId`),
  CONSTRAINT `FK___categories` FOREIGN KEY (`CategoryId`) REFERENCES `categories` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.inventories: ~4 rows (approximately)
REPLACE INTO `inventories` (`Id`, `CategoryId`, `Code`, `Description`, `CurrentStock`, `StockIn`, `StockOut`, `OriginalPrice`, `SellingPrice`, `Remarks`) VALUES
	(1, 16, 'I1', 'InventoryOne', 50, 12, 10, 950.00, 1000.00, 'Good Condition'),
	(2, 10, 'I2', 'InventoryTwo', 50, 24, 13, 850.00, 950.00, 'Good Condition'),
	(3, 8, 'I3', 'InventoryThree', 10, 32, 12, 450.00, 500.00, 'Good Condition'),
	(5, 15, 'I4', 'Inventory Four', 9, 15, 15, 300.00, 350.00, 'Good Condition');

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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.notifications: ~2 rows (approximately)
REPLACE INTO `notifications` (`Id`, `InventoryId`, `Message`, `IsRead`, `CreatedAt`) VALUES
	(1, 1, 'The Inventory is low on stock', 0, '2025-07-19 04:20:12'),
	(2, 2, 'The Inventory is low on stock', 0, '2025-07-19 04:20:12'),
	(3, 3, 'Low stock alert for I3. Current stock is 10.', 0, '2025-07-19 07:54:50'),
	(4, 5, 'Low stock alert for I4. Current stock is 9.', 0, '2025-07-19 07:54:50');

-- Dumping structure for table salesinventory.products
CREATE TABLE IF NOT EXISTS `products` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CreatedAt` timestamp NOT NULL,
  `ProductName` varchar(100) DEFAULT NULL,
  `CategoryId` int DEFAULT NULL,
  `InStock` int DEFAULT NULL,
  `BuyingPrice` decimal(18,2) DEFAULT NULL,
  `SellingPrice` decimal(18,2) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `ProductName` (`ProductName`),
  KEY `FK__categories` (`CategoryId`),
  CONSTRAINT `FK__categories` FOREIGN KEY (`CategoryId`) REFERENCES `categories` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.products: ~2 rows (approximately)
REPLACE INTO `products` (`Id`, `CreatedAt`, `ProductName`, `CategoryId`, `InStock`, `BuyingPrice`, `SellingPrice`) VALUES
	(18, '2025-06-08 03:25:18', 'Product 1', 16, 50, 1231.00, 12315.00),
	(19, '2025-07-18 15:30:50', 'Product 2', 16, 60, 100000.00, 100000.00);

-- Dumping structure for table salesinventory.roles
CREATE TABLE IF NOT EXISTS `roles` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.roles: ~2 rows (approximately)
REPLACE INTO `roles` (`Id`, `Name`) VALUES
	(5, 'Admin'),
	(6, 'Sales'),
	(7, 'Inventory');

-- Dumping structure for table salesinventory.saleitem
CREATE TABLE IF NOT EXISTS `saleitem` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `SalesId` int NOT NULL DEFAULT '0',
  `ProductId` int DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  `Price` decimal(18,2) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `SalesId` (`SalesId`),
  KEY `ProductId` (`ProductId`),
  CONSTRAINT `FK__sales` FOREIGN KEY (`SalesId`) REFERENCES `sales` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_saleitem_products` FOREIGN KEY (`ProductId`) REFERENCES `products` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.saleitem: ~0 rows (approximately)
REPLACE INTO `saleitem` (`Id`, `SalesId`, `ProductId`, `Quantity`, `Price`) VALUES
	(1, 1, 18, 2, 20000.00),
	(2, 1, 19, 1, 10000.00),
	(3, 2, 19, 4, 40000.00);

-- Dumping structure for table salesinventory.sales
CREATE TABLE IF NOT EXISTS `sales` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ReferenceNumber` varchar(50) DEFAULT NULL,
  `TotalSales` decimal(18,2) unsigned NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `ReferenceNumber` (`ReferenceNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.sales: ~0 rows (approximately)
REPLACE INTO `sales` (`Id`, `ReferenceNumber`, `TotalSales`) VALUES
	(1, '000001', 30000.00),
	(2, '000002', 40000.00);

-- Dumping structure for table salesinventory.users
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LastName` varchar(100) NOT NULL DEFAULT '0',
  `FirstName` varchar(100) NOT NULL DEFAULT '0',
  `Username` varchar(100) NOT NULL DEFAULT '0',
  `Password` varchar(100) NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table salesinventory.users: ~6 rows (approximately)

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

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
