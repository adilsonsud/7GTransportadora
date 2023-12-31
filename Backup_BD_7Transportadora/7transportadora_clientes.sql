CREATE DATABASE  IF NOT EXISTS `7transportadora` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `7transportadora`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: 7transportadora
-- ------------------------------------------------------
-- Server version	5.5.25

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `CPFCNPJ` varchar(20) NOT NULL,
  `Nome` varchar(200) DEFAULT NULL,
  `Endereco` varchar(200) DEFAULT NULL,
  `Complemento` varchar(200) DEFAULT NULL,
  `Bairro` varchar(45) DEFAULT NULL,
  `Cidade` varchar(45) DEFAULT NULL,
  `UF` varchar(2) DEFAULT NULL,
  `CEP` varchar(10) DEFAULT NULL,
  `Fone1` varchar(45) DEFAULT NULL,
  `Fone2` varchar(45) DEFAULT NULL,
  `Fone3` varchar(45) DEFAULT NULL,
  `Fone4` varchar(45) DEFAULT NULL,
  `Email` varchar(60) DEFAULT NULL,
  `Site` varchar(45) DEFAULT NULL,
  `PessoaFJ` char(1) DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'96490390582','ADILSON C.S FREIRE','RUA DO CONJUNTO ANANINDEUA, 180','BR 316 KM 08','CENTRO','SANTARÉM','PA','67030000','91 32559545','91 98873817','91 98198787','','AILSONSUD@YAHOO.COM.BR','WWW.ADILSONSUD.COM.BR','F'),(2,'65487545665465','FRUTAS EXPORTAÇÃO SA','RUA DAS PALMEIRAS, 890','PROXIMO A CEASA','ACAMPAMENTO','MARITUBA','PA','66030987','91 98765434','91 98797898','91 99800980','91 32456765','SUPORTE@FRUTAS.COM.BR','WWW.FRUTASECIA.COM.BR','J'),(4,'66356646546','MARIA JUREMA DE MENDINHO','RUA DA OLARIA CASCA GROSSA','ENTRE RUA A E B','CANJUARU','PORTO DE TROMBETAS','PA','69854822','64 64646465','56 46546546','65 46546546','65 46546546','MARIA@IG.COM.BR','WWW.TUDOBELO.COM.BR','F'),(5,'89654125505','RAUL GIL','RUA DO NARIGON','PROXIMO A MANGUEIRA','JURUNA','BELÉM','PA','64646464','91 54646665','67 89879879','46 46464654','64 64646546','EINARIGON@BOL.COM','NÃO TEM SITE','F'),(6,'78259852426','MARION DA SILVA CARDOSO','TRAV. QUINTINO BOCAIUVA','ENTRE GENTIL BITENCOURT','UMARIZAL','MARITUBA','PA','66895712','91 46464654','65 46464646','46 54646546','46 46465465','JUUJKSJ@GMAIL.COM','WWW.COM.BR','F'),(7,'99875465465','MARIA DE NAZARE APARECIDA','RUA MENDES FILHO, 53','PROXIMO A BIGBEN','CENTRO','SANTARÉM','PA','67030000','91955865465','91989879879','91932558987','91 92132131','EMAIL.COM.BR','SITE.COM.BR','F'),(8,'58565465464','JILDIELSON MELZIAR','QUADRA 21 RUA 3','ESQUINA COM PADARIA','CAPITÃO','CASTANHAL','PA','66985244','46464646546','64654654654','65465465465','65 46546546','EMAIL@GMAIL.COM','WWW.SITELEGAL.COM.BR','F'),(10,'52310450036','MARCIA DO ROSARIO NUNES SILVA','RUA DOS PARIQUIS, 659','ENTRE APINAGES E PADRE EUTIQUIO','CREMAÇÃO','PARAUAPEBAS','PA','66032548','91985457887','9132551840','','','ROSARIOM@GMAIL.COM','','F'),(11,'98754232125','JARLENE DE PITECO SOUZA','RUA BOA GRAÇA, 433','PROXIMO A UNIVERSAL','GIRASOL','MACAPÁ','AP','64654654','91654654654','91654654654','94246546546','91546546545','EMAIL@EMAIL.COM.BR','WWW.LOGO.COM.BR','F'),(12,'46465464646','JUDAS ESCARIOTES DA SILVA','RUA DO TRAIDOR SAFADO, 666','QUADRA 03','CENTRO','MARITUBA','PA','46546564','91464646456','','','','JUDAS@GMAIL.COM','WWW.SENOCAO.COM.BR','F');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-07-25  1:59:52
