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

INSERT INTO `products` (`Id`, `Name`, `Price`, `Unit`, `Description`, `SupplierId`) VALUES
(1, 'Lélegeztetőgép', 1000000, 'db', 'szipiszupi lélegeztetőgép', 1),
(2, 'Maszk', 300, 'csomag', 'cicabajszos szájmaszk', 6),
(3, 'Gumikesztyű', 500, 'doboz', 'latex kesztyű púderezett', 3),
(4, 'Maszk', 400, '100', 'kétrétegű maszk', 8),
(5, 'Gumikesztyű', 400, 'doboz', 'latex kesztyű púder nélkül', 7),
(6, 'Liszt', 159, 'kg', 'búzafinomliszt', 9),
(7, 'Liszt', 229, '0,5kg', 'teljes kiőrlésű liszt', 10),
(8, 'élesztő', 49, 'db', 'élesztő', 11);

INSERT INTO `stocks` (`Id`, `ProductId`, `Quantity`, `DateRecorded`) VALUES
(1, 5, 100, '2020-11-30 16:32:43');
