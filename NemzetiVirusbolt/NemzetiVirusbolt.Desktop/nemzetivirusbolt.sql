DROP DATABASE IF EXISTS `nemzetivirusbolt`;
CREATE DATABASE IF NOT EXISTS `nemzetivirusbolt` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;

DROP TABLE IF EXISTS `products`;
CREATE TABLE IF NOT EXISTS `products` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `Price` int(11) NOT NULL,
  `Unit` varchar(50) NOT NULL,
  `Description` varchar(500) NOT NULL,
  `SupplierId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `SupplierId` (`SupplierId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

INSERT INTO `products` (`Id`, `Name`, `Price`, `Unit`, `Description`, `SupplierId`) VALUES
(1, 'Lélegeztetőgép', 1000000, 'db', 'szipiszupi lélegeztetőgép', 1),
(2, 'Maszk', 300, 'csomag', 'cicabajszos szájmaszk', 6),
(3, 'Gumikesztyű', 500, 'doboz', 'latex kesztyű púderezett', 3),
(4, 'Maszk', 400, '100', 'kétrétegű maszk', 8),
(5, 'Gumikesztyű', 400, 'doboz', 'latex kesztyű púder nélkül', 7),
(6, 'Liszt', 159, 'kg', 'búzafinomliszt', 9),
(7, 'Liszt', 229, '0,5kg', 'teljes kiőrlésű liszt', 10),
(8, 'élesztő', 49, 'db', 'élesztő', 11);

DROP TABLE IF EXISTS `stocks`;
CREATE TABLE IF NOT EXISTS `stocks` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ProductId` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL,
  `DateRecorded` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`),
  KEY `ProductId` (`ProductId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

INSERT INTO `stocks` (`Id`, `ProductId`, `Quantity`, `DateRecorded`) VALUES
(1, 5, 100, '2020-11-30 16:32:43');

DROP TABLE IF EXISTS `suppliers`;
CREATE TABLE IF NOT EXISTS `suppliers` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4;

INSERT INTO `suppliers` (`Id`, `Name`) VALUES
(1, 'Siemens'),
(2, 'Maszk Rt.'),
(3, 'Aurelia Gloves'),
(4, 'Profissimo'),
(5, 'Ansell'),
(6, 'Air Safety'),
(7, 'CERVA'),
(8, 'Clean Space'),
(9, 'Szabó Malom'),
(10, 'Naturworld'),
(11, 'Dr.Oetker'),
(12, 'BradoLine'),
(13, 'Aura_Antibacterial'),
(14, 'Clearsept'),
(15, 'Zewa '),
(16, 'Perfex'),
(17, 'Ooops!'),
(18, 'Medirex'),
(19, 'Celitron Medical'),
(20, 'Haas'),
(21, 'FlóraVita');

ALTER TABLE `products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`SupplierId`) REFERENCES `suppliers` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;

ALTER TABLE `stocks`
  ADD CONSTRAINT `stocks_ibfk_1` FOREIGN KEY (`ProductId`) REFERENCES `products` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE;
