-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.7.23-log - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             9.5.0.5295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for cyber_db
CREATE DATABASE IF NOT EXISTS `cyber_db` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `cyber_db`;

-- Dumping structure for table cyber_db.tbl_cyber_crime_user
CREATE TABLE IF NOT EXISTS `tbl_cyber_crime_user` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Firstname` varchar(255) DEFAULT NULL,
  `Middlename` varchar(255) DEFAULT NULL,
  `Lastname` varchar(255) DEFAULT NULL,
  `Nationality` varchar(255) DEFAULT NULL,
  `Group_name` varchar(255) DEFAULT NULL,
  `Group_country` varchar(255) DEFAULT NULL,
  `Case_name` varchar(255) DEFAULT NULL,
  `Case_text` varchar(255) DEFAULT NULL,
  `ID_type` varchar(255) DEFAULT NULL,
  `B_Account_number` varchar(255) DEFAULT NULL,
  `B_Account_country` varchar(255) DEFAULT NULL,
  `B_Account_type` varchar(255) DEFAULT NULL,
  `E_Account_name` varchar(255) DEFAULT NULL,
  `E_Account_typename` varchar(255) DEFAULT NULL,
  `IPs_ip` varchar(255) DEFAULT NULL,
  `IPs_country` varchar(255) DEFAULT NULL,
  `Skill_name` varchar(255) DEFAULT NULL,
  `Skill_text` varchar(255) DEFAULT NULL,
  `Skill_type` varchar(255) DEFAULT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `ModifyTime` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;

-- Dumping data for table cyber_db.tbl_cyber_crime_user: ~5 rows (approximately)
DELETE FROM `tbl_cyber_crime_user`;
/*!40000 ALTER TABLE `tbl_cyber_crime_user` DISABLE KEYS */;
INSERT INTO `tbl_cyber_crime_user` (`ID`, `Firstname`, `Middlename`, `Lastname`, `Nationality`, `Group_name`, `Group_country`, `Case_name`, `Case_text`, `ID_type`, `B_Account_number`, `B_Account_country`, `B_Account_type`, `E_Account_name`, `E_Account_typename`, `IPs_ip`, `IPs_country`, `Skill_name`, `Skill_text`, `Skill_type`, `Username`, `ModifyTime`) VALUES
	(14, 'asdf', 'a', 'Crime', 'Unknown', 'hacking group', 'unknown', 'asdf', 'asdfs adffffff ffff fffffffffffffff ffffffffff ffffffffffffff', '', 'asdf', 'asdf', 'asdf', 'asdf', 'asdf', '192.168.123.122', 'asdf', 'asdf', '', '', 'Naif', '2018-11-30'),
	(16, 'asdf', 'a', 'Crime', 'Unknown', 'hacking group', 'unknown', 'asdf', 'unknown', '', 'asdf', 'asdf', 'asdf', 'asdf', 'asdf', '192.168.123.122', 'asdf', 'asdf', '', '', 'Naif', '2018-11-29'),
	(17, 'asdf', 'a', 'Crime', 'Unknown', 'hacking group', 'unknown', 'asdf', 'aaaa', '', 'asdf', 'asdf', 'asdf', 'asdf', 'asdf', '192.168.123.122', 'asdf', 'asdf', '', '', 'Naif', '2018-11-29'),
	(18, 'mmmm', 'aaaa', 'aaaaa', 'usa', 'aaaa', 'aaaa', 'aaaa', 'aaaa', '', '', '', '', '', '', '', '', '', '', '', 'Naif', '2018-11-29'),
	(30, 'aa', 'df', 'sdf', 'asdf', 'a', 'a', 'wwww', 'sdf', 'asdfasdf', 'ss', 'ss', 'ss', 'ss', 'dfsdfs', 'asdf', 'wer', 'asdf', 'asdfwer', 'wasdf', '', '2018-12-3');
/*!40000 ALTER TABLE `tbl_cyber_crime_user` ENABLE KEYS */;

-- Dumping structure for table cyber_db.tbl_log_history
CREATE TABLE IF NOT EXISTS `tbl_log_history` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) DEFAULT NULL,
  `Action` varchar(255) DEFAULT NULL,
  `ModifiedTime` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- Dumping data for table cyber_db.tbl_log_history: ~9 rows (approximately)
DELETE FROM `tbl_log_history`;
/*!40000 ALTER TABLE `tbl_log_history` DISABLE KEYS */;
INSERT INTO `tbl_log_history` (`ID`, `Username`, `Action`, `ModifiedTime`) VALUES
	(1, 'asdf', 'asdf', 'asdf'),
	(2, 'Naif', 'Login', 'asdf'),
	(3, 'Naif', 'Login', '22:33:29 PM'),
	(4, 'Naif', 'Login', '23:53:51 PM'),
	(5, 'Naif', 'Login', '23:56:04 PM'),
	(6, 'Naif', 'Login', '00:39:22 AM'),
	(7, 'Naif', 'Login', '00:47:58 AM'),
	(8, 'Naif', 'Login', '00:48:40 AM'),
	(9, 'Naif', 'Login', '01:08:32 AM');
/*!40000 ALTER TABLE `tbl_log_history` ENABLE KEYS */;

-- Dumping structure for table cyber_db.tbl_report
CREATE TABLE IF NOT EXISTS `tbl_report` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Username` varchar(255) DEFAULT NULL,
  `Text` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Dumping data for table cyber_db.tbl_report: ~1 rows (approximately)
DELETE FROM `tbl_report`;
/*!40000 ALTER TABLE `tbl_report` DISABLE KEYS */;
INSERT INTO `tbl_report` (`ID`, `Username`, `Text`) VALUES
	(1, 'Naif', 'asdfksdanf nkxnckvk kljsdfkljsdklf jklsjdflkjsa dlf');
/*!40000 ALTER TABLE `tbl_report` ENABLE KEYS */;

-- Dumping structure for table cyber_db.tbl_user
CREATE TABLE IF NOT EXISTS `tbl_user` (
  `ID` int(25) unsigned NOT NULL AUTO_INCREMENT,
  `Firstname` varchar(255) DEFAULT NULL,
  `Middlename` varchar(255) DEFAULT NULL,
  `Lastname` varchar(255) DEFAULT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `Permission` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Dumping data for table cyber_db.tbl_user: ~3 rows (approximately)
DELETE FROM `tbl_user`;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` (`ID`, `Firstname`, `Middlename`, `Lastname`, `Username`, `Password`, `Permission`) VALUES
	(1, 'Naif', '', 'Mohammed', 'Naif', 'password', 'admin'),
	(2, 'Donald', 'de', 'Martinez', 'Donald', 'password', 'user'),
	(3, 'PPP', 'PPP', 'PPP', 'PPP', 'PPP', 'user');
/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
