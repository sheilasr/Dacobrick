-- MySQL dump 10.13  Distrib 8.0.24, for Win64 (x86_64)
--
-- Host: localhost    Database: dacobrick
-- ------------------------------------------------------
-- Server version	8.0.24

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
-- Table structure for table `doc_durante`
--

DROP TABLE IF EXISTS `doc_durante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doc_durante` (
  `ID` int NOT NULL,
  `DC` varchar(45) DEFAULT NULL,
  `DE` varchar(45) DEFAULT NULL,
  `DF` varchar(45) DEFAULT NULL,
  `DP` varchar(45) DEFAULT NULL,
  `DCARP` varchar(45) DEFAULT NULL,
  `DA` varchar(45) DEFAULT NULL,
  `DI` varchar(45) DEFAULT NULL,
  `DINS` varchar(45) DEFAULT NULL,
  `DR` varchar(45) DEFAULT NULL,
  `DEQ` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doc_durante`
--

LOCK TABLES `doc_durante` WRITE;
/*!40000 ALTER TABLE `doc_durante` DISABLE KEYS */;
INSERT INTO `doc_durante` VALUES (4,'False','False','False','False','False','False','False','False','False','False'),(5,'True','False','False','False','False','True','True','True','False','False'),(8,'True','True','True','False','False','True','True','True','True','True');
/*!40000 ALTER TABLE `doc_durante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doc_fin`
--

DROP TABLE IF EXISTS `doc_fin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doc_fin` (
  `ID` int NOT NULL,
  `LF` varchar(45) DEFAULT NULL,
  `CF` varchar(45) DEFAULT NULL,
  `AREC` varchar(45) DEFAULT NULL,
  `CEE` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doc_fin`
--

LOCK TABLES `doc_fin` WRITE;
/*!40000 ALTER TABLE `doc_fin` DISABLE KEYS */;
INSERT INTO `doc_fin` VALUES (4,'False','False','False','False'),(5,'False','False','False','False'),(8,'True','True','True','False');
/*!40000 ALTER TABLE `doc_fin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doc_inicio`
--

DROP TABLE IF EXISTS `doc_inicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doc_inicio` (
  `ID` int NOT NULL,
  `CF` varchar(45) DEFAULT NULL,
  `PC` varchar(45) DEFAULT NULL,
  `EG` varchar(45) DEFAULT NULL,
  `LO` varchar(45) DEFAULT NULL,
  `AP` varchar(45) DEFAULT NULL,
  `NP` varchar(45) DEFAULT NULL,
  `LD` varchar(45) DEFAULT NULL,
  `PSS` varchar(45) DEFAULT NULL,
  `LC` varchar(45) DEFAULT NULL,
  `AC` varchar(45) DEFAULT NULL,
  `LI` varchar(45) DEFAULT NULL,
  `PGR` varchar(45) DEFAULT NULL,
  `LS` varchar(45) DEFAULT NULL,
  `PG` varchar(45) DEFAULT NULL,
  `AR` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doc_inicio`
--

LOCK TABLES `doc_inicio` WRITE;
/*!40000 ALTER TABLE `doc_inicio` DISABLE KEYS */;
INSERT INTO `doc_inicio` VALUES (4,'True','True','True','True','True','True','False','True','False','True','False','True','True','False','True'),(5,'True','True','True','True','True','True','False','True','True','True','True','True','True','True','True'),(8,'True','True','True','True','True','True','False','True','True','True','True','True','True','False','True');
/*!40000 ALTER TABLE `doc_inicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturas`
--

DROP TABLE IF EXISTS `facturas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facturas` (
  `CODIGO` int NOT NULL,
  `ID_Obra` varchar(45) NOT NULL,
  `N_factura` varchar(45) NOT NULL,
  `Fecha` varchar(45) DEFAULT NULL,
  `Empresa` varchar(45) DEFAULT NULL,
  `Producto` varchar(45) DEFAULT NULL,
  `Importe` varchar(45) NOT NULL,
  PRIMARY KEY (`CODIGO`),
  UNIQUE KEY `N_factura_UNIQUE` (`N_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturas`
--

LOCK TABLES `facturas` WRITE;
/*!40000 ALTER TABLE `facturas` DISABLE KEYS */;
INSERT INTO `facturas` VALUES (1,'8','2021/01','2021-03-29','Materiales Aparicio','Guantes y cascos','32,00'),(2,'8','2021/02','2021-04-14','Hermi Materiales','Clavos y tacos','8,50'),(3,'5','2021/03','2021-05-28','Monovas Herramientas','Radial x 2','189,00'),(4,'5','2021/04','2021-06-09','Monovas Herramientas','Capazos x 5','18,99'),(5,'4','2021/5','2021-05-24','Eldeco','Gafas anti-impacto x 2','5,75'),(6,'8','2021/06','2021-06-09','El Torres ','Cable de interior','28,50');
/*!40000 ALTER TABLE `facturas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gastos`
--

DROP TABLE IF EXISTS `gastos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gastos` (
  `COD_GASTOS` int NOT NULL,
  `N_factura` varchar(45) NOT NULL,
  `Fecha` datetime DEFAULT NULL,
  `Tipo` varchar(45) DEFAULT NULL,
  `Obra` varchar(45) NOT NULL,
  `Importe` varchar(45) NOT NULL,
  `Expediente` varchar(45) NOT NULL,
  `Titulo` varchar(85) NOT NULL,
  PRIMARY KEY (`COD_GASTOS`),
  UNIQUE KEY `N_factura_UNIQUE` (`N_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gastos`
--

LOCK TABLES `gastos` WRITE;
/*!40000 ALTER TABLE `gastos` DISABLE KEYS */;
INSERT INTO `gastos` VALUES (1,'1001','2021-06-09 00:00:00','Transporte','2','15,00',' 172/2021/49',' Polígono Industrial El Testar'),(2,'1002','2021-05-27 00:00:00','Otro','3','3,00',' 16/21-C',' Renovación de la Plaza Aljub'),(3,'1003','2021-05-28 00:00:00','Dietas','4','16,50',' 581/2021',' Estación de bombeo de aguas residuales y colectores 2ª Fase'),(4,'1004','2021-05-31 00:00:00','Dietas','4','16,50',' 581/2021',' Estación de bombeo de aguas residuales y colectores 2ª Fase'),(5,'1005','2021-06-01 00:00:00','Dietas','4','13,50',' 581/2021',' Estación de bombeo de aguas residuales y colectores 2ª Fase'),(6,'1006','2021-06-24 00:00:00','Transporte','5','30,00',' D211/2021/4',' Instalación de hidrantes de incendios en polígonos industriales'),(7,'1007','2021-05-31 00:00:00','Transporte','5','10,00',' D211/2021/4',' Instalación de hidrantes de incendios en polígonos industriales'),(8,'1008','2021-06-10 00:00:00','Dietas','5','14,50',' D211/2021/4',' Instalación de hidrantes de incendios en polígonos industriales'),(9,'1009','2021-05-24 00:00:00','Dietas','8','9,50',' 2924/2021',' Nichos y urbanización interior en el Cementerio Municipal'),(10,'1010','2021-05-28 00:00:00','Alojamiento','8','45,50',' 2924/2021',' Nichos y urbanización interior en el Cementerio Municipal'),(11,'1011','2021-06-10 00:00:00','Otro','8','5,00',' 2924/2021',' Nichos y urbanización interior en el Cementerio Municipal');
/*!40000 ALTER TABLE `gastos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horas`
--

DROP TABLE IF EXISTS `horas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horas` (
  `COD_Horas` int NOT NULL,
  `Fecha` varchar(45) NOT NULL,
  `Obra` varchar(45) NOT NULL,
  `Expediente` varchar(45) DEFAULT NULL,
  `Titulo` varchar(65) DEFAULT NULL,
  `H_entrada` varchar(45) DEFAULT NULL,
  `H_salida` varchar(45) DEFAULT NULL,
  `Total` varchar(45) NOT NULL,
  PRIMARY KEY (`COD_Horas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horas`
--

LOCK TABLES `horas` WRITE;
/*!40000 ALTER TABLE `horas` DISABLE KEYS */;
INSERT INTO `horas` VALUES (1,'2021-05-17','2',' 172/2021/49',' Polígono Industrial El Testar','07:00','15:00','08:00:00'),(2,'2021-05-18','2',' 172/2021/49',' Polígono Industrial El Testar','07:00','09:00','02:00:00'),(3,'2021-05-18','5',' D211/2021/4',' Instalación de hidrantes de incendios en polígonos industriales','09:00','15:00','06:00:00'),(4,'2021-05-19','8',' 2924/2021',' Nichos y urbanización interior en el Cementerio Municipal','07:00','15:00','08:00:00'),(5,'2021-05-20','3',' 16/21-C',' Renovación de la Plaza Aljub','07:00','10:30','03:30:00'),(6,'2021-05-20','8',' 2924/2021',' Nichos y urbanización interior en el Cementerio Municipal','10:30','15:00','04:30:00'),(7,'2021-05-21','4',' 581/2021',' Estación de bombeo de aguas residuales y colectores 2ª Fase','07:00','15:00','08:00:00');
/*!40000 ALTER TABLE `horas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `obras`
--

DROP TABLE IF EXISTS `obras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `obras` (
  `ID` int NOT NULL,
  `Expediente` varchar(45) NOT NULL,
  `Titulo` varchar(65) NOT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Poblacion` varchar(45) DEFAULT NULL,
  `CP` int DEFAULT NULL,
  `Estado` varchar(45) DEFAULT NULL,
  `Importe` varchar(45) DEFAULT NULL,
  `IVA` varchar(45) DEFAULT NULL,
  `Total` varchar(45) DEFAULT NULL,
  `Promotor` varchar(45) DEFAULT NULL,
  `Fecha_inicio` varchar(45) DEFAULT NULL,
  `Fecha_fin` varchar(45) DEFAULT NULL,
  `Duracion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Expediente_UNIQUE` (`Expediente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `obras`
--

LOCK TABLES `obras` WRITE;
/*!40000 ALTER TABLE `obras` DISABLE KEYS */;
INSERT INTO `obras` VALUES (1,'05/2021','Obras e instalaciones en el C.E.I.P Antonio Sequeros','Plaza de España, 1','Benejúzar',3390,'PUBLICADA','299.852,17','21','362.821,13','Ayuntamiento de Benejúzar','lunes, 17 de mayo de 2021','martes, 17 de agosto de 2021','12'),(2,'172/2021/49','Polígono Industrial El Testar','Plaza Enginyer Castells, s/n','Paterna',46980,'PRESENTADA','49.528,30','21','59.929,24','Ayuntamiento de Paterna','miércoles, 9 de junio de 2021','jueves, 9 de diciembre de 2021','24'),(3,'16/21-C','Renovación de la Plaza Aljub','Autonomía, 2','Sagunto',46500,'EN EVALUACIÓN','64.875,24','21','78.499,04','Ayuntamiento de Sagunto','jueves, 17 de junio de 2021','sábado, 31 de julio de 2021','6'),(4,'581/2021','Estación de bombeo de aguas residuales y colectores 2ª Fase','Plaza del Ayuntamiento, s/n','Sant Joan de Moró',12130,'ADJUDICADA','121.112,09','21','202.724,33','Ayuntamiento de Sant Joan de Moró','jueves, 20 de mayo de 2021','viernes, 20 de agosto de 2021','12'),(5,'D211/2021/4','Instalación de hidrantes de incendios en polígonos industriales','Plaza El Pla, 1','Onda',12200,'EN EJECUCIÓN','125.024','21','151.279,04','Ayuntamiento de Onda','viernes, 21 de mayo de 2021','domingo, 21 de noviembre de 2021','24'),(6,'776160A','Adecuación del Patio de Recreo del CEIP Vil·la Romana','Avda. Camí Real, 22 bajo izq.','Catarroja',46470,'ADJUDICADA A OTROS','80.617,46','21','97.547,13 ','Ayuntamiento de Catarroja','lunes, 24 de mayo de 2021','martes, 24 de agosto de 2021','12'),(7,'4880/2021','Polígono Industrial El Pla - Fase III','Plaza Mayor, 1','Ontinyent',46870,'ANULADA','157.024,79 ','21','190.000','Ayuntamiento de Ontinyent','martes, 25 de mayo de 2021','miércoles, 25 de agosto de 2021','12'),(8,'2924/2021','Nichos y urbanización interior en el Cementerio Municipal','Plaza Mayor, 3','Algemesí',46680,'FINALIZADA','239.362,63','21','289.628,78','Ayuntamiento de Algemesí','viernes, 26 de marzo de 2021','lunes, 26 de julio de 2021','16'),(9,'210/2021','Revestimientos interiores y urbanización entorno La Granaina','Plaza Mayor, 6','Montaverner',46892,'OTROS','45.454,55','21','55.000','Ayuntamiento de Montaverner','jueves, 27 de mayo de 2021','viernes, 27 de agosto de 2021','12');
/*!40000 ALTER TABLE `obras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `planificacion`
--

DROP TABLE IF EXISTS `planificacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `planificacion` (
  `ID` int NOT NULL,
  `ID_obra` varchar(45) NOT NULL,
  `Fecha` varchar(45) NOT NULL,
  `Tipo` varchar(45) NOT NULL,
  `Descripcion` varchar(85) DEFAULT NULL,
  PRIMARY KEY (`ID`,`ID_obra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `planificacion`
--

LOCK TABLES `planificacion` WRITE;
/*!40000 ALTER TABLE `planificacion` DISABLE KEYS */;
INSERT INTO `planificacion` VALUES (1,'1','18-05-2021','OTROS','Preparación de licitación. '),(2,'1','21-05-2021','OTROS','Enviar a Ayto.'),(3,'2','10-06-2021','OTROS','Preparar y enviar documentación al Ayto. '),(4,'3','19-05-2021','OTROS','Envio de documentación al Ayto. '),(5,'3','24-05-2021','OTROS','Revisión sede electrónica Ayto.'),(6,'3','26-05-2021','OTROS','Preparación documentación baja temeraria.'),(7,'4','21-05-2021','OTROS','Envío de licitación por la Plataforma.'),(8,'4','25-05-2021','OTROS','Preparación y envío del PSS y PGR.'),(9,'4','28-05-2021','OTROS','Apertura del centro de trabajo.'),(10,'4','28-05-2021','Actuaciones previas','Limpieza del solar.'),(11,'6','27-05-2021','OTROS','Envío de licitación.'),(12,'6','01-06-2021','OTROS','Apertura acta, adjudicada a otros.'),(13,'9','28-05-2021','OTROS','Revisión de bases.'),(14,'9','02-06-2021','OTROS','Reunión para planificar la presentación de la licitación.'),(15,'9','04-06-2021','OTROS','Se decide no presentar los documentos. '),(16,'7','26-05-2021','OTROS','Revisar las bases de la licitación.'),(17,'7','28-05-2021','OTROS','Se informa al Ayto. que existen errores en el presupuesto.'),(18,'7','31-05-2021','OTROS','Paralización de la licitación por parte del Ayto, errores en el proyecto. '),(19,'5','24-05-2021','OTROS','Firma del contrato en el Ayto. a las 10.00h.'),(20,'5','26-05-2021','Actuaciones previas','Vallado zona de actuación, colocación de señales.'),(21,'5','27-05-2021','Demoliciones','Apertura de zanjas, demolición de las hidratantes existentes.'),(22,'5','31-05-2021','Instalaciones','Reunión materiales, llevar muestras. A las 11.00h en el Ayto. '),(23,'8','24-05-2021','Carpintería, cerrajería y vidrios','Llevar muestras de carpintería al Ayto. Reunión a las 12.00h.'),(24,'8','28-05-2021','Instalaciones','Revisión cubiertas, prueba de estanqueidad. '),(25,'8','01-06-2021','Revestimientos y trasdosados','Reunion materiales, decisión aplacado exterior. '),(26,'8','10-06-2021','Señalización y equipamiento','Colocación de mobiliario urbano (farolas y bancos).');
/*!40000 ALTER TABLE `planificacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trabajadores_obra`
--

DROP TABLE IF EXISTS `trabajadores_obra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trabajadores_obra` (
  `CODI` int NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellidos` varchar(45) DEFAULT NULL,
  `DNI` varchar(45) NOT NULL,
  `Telefono` varchar(45) NOT NULL,
  `Nivel` varchar(45) DEFAULT NULL,
  `Contrato` varchar(45) DEFAULT NULL,
  `Apto` varchar(45) DEFAULT NULL,
  `EPIs` varchar(45) DEFAULT NULL,
  `Maquinaria` varchar(45) DEFAULT NULL,
  `PRL` varchar(45) DEFAULT NULL,
  `Albañileria` varchar(45) DEFAULT NULL,
  `Hormigon` varchar(45) DEFAULT NULL,
  `Grua` varchar(45) DEFAULT NULL,
  `Plataformas` varchar(45) DEFAULT NULL,
  `Libre` varchar(45) NOT NULL,
  `Obra_asignada` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`CODI`),
  UNIQUE KEY `DNI_UNIQUE` (`DNI`),
  UNIQUE KEY `Telefono_UNIQUE` (`Telefono`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trabajadores_obra`
--

LOCK TABLES `trabajadores_obra` WRITE;
/*!40000 ALTER TABLE `trabajadores_obra` DISABLE KEYS */;
INSERT INTO `trabajadores_obra` VALUES (1,'Manuel','García López','00000000A','600000000','Encargado Gral. Obra','True','True','True','True','True','True','True','False','False','NO','5'),(2,'Jose','Moreno Navarro','11111111B','611111111','Peón especialista','True','True','True','True','True','False','False','True','False','SI','00'),(3,'Carmen','Gil Ramos','22222222C','622222222','Peón ordinadio','True','True','True','True','True','True','False','False','False','SI','00'),(4,'Sonia','Ureña Martínez','33333333D','633333333','Peón ordinadio','True','True','True','True','True','True','False','False','False','NO','4'),(5,'Antonio','Martínez García','44444444E','644444444','Oficial 1ª','True','True','True','True','True','True','False','False','True','NO','5'),(6,'Francisco','López Pérez','55555555F','655555555','Oficial 2ª','True','True','True','True','True','True','False','True','False','SI','00'),(7,'Ana','Rubio Sanz','66666666G','666666666','Aprendiz','True','True','True','True','True','False','False','False','False','NO','8'),(8,'Inmaculada','Esteve Rodríguez','77777777H','677777777','Peón ordinadio','True','True','True','True','True','True','False','False','False','NO','5'),(9,'Pepe','Soler Montagud','88888888I','688888888','Encargado Gral. Obra','True','True','True','True','True','True','True','False','False','NO','4'),(10,'Rafael','Martín Martín','99999999J','699999999','Oficial 2ª','True','False','True','True','True','True','True','False','False','SI','00');
/*!40000 ALTER TABLE `trabajadores_obra` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-10 14:04:12
