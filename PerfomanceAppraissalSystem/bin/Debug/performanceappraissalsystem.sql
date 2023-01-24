-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 03, 2019 at 07:33 AM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `performanceappraissalsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `boardmembers`
--

CREATE TABLE IF NOT EXISTS `boardmembers` (
  `BoardID` varchar(10) NOT NULL,
  `BoardFname` varchar(100) NOT NULL,
  `BoardLname` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `bosses`
--

CREATE TABLE IF NOT EXISTS `bosses` (
  `BossID` varchar(10) NOT NULL,
  `Firstname` varchar(255) NOT NULL,
  `Lastname` varchar(255) NOT NULL,
  `Department` varchar(255) NOT NULL,
  PRIMARY KEY (`BossID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `comment`
--

CREATE TABLE IF NOT EXISTS `comment` (
  `CommentID` int(7) NOT NULL,
  `Commenter` varchar(100) NOT NULL,
  `CommentContent` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE IF NOT EXISTS `employees` (
  `EmployeeID` int(10) NOT NULL,
  `Firstname` varchar(255) NOT NULL,
  `Lastname` varchar(255) NOT NULL,
  `Department` varchar(255) NOT NULL,
  `JobTitle` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `DateofBirth` date NOT NULL,
  `Password` varchar(255) NOT NULL,
  PRIMARY KEY (`EmployeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`EmployeeID`, `Firstname`, `Lastname`, `Department`, `JobTitle`, `Email`, `Gender`, `DateofBirth`, `Password`) VALUES
(123, 'Peter', 'Mkandawire', 'Cooperate Affairs', 'Clerk', 'pmkan@mra.mw', 'Male', '1996-09-09', '1234'),
(1176, 'Paulatu', 'Nkwend', 'Audit', 'technician', 'neigyg@thht.mw', 'Male', '1983-08-12', '12345'),
(15444, 'Ronald', 'Juma', 'Supply Chain Management', 'Manager', 'rjuma@gmail.com', 'Male', '1994-07-13', '12345678');

-- --------------------------------------------------------

--
-- Table structure for table `evaluations`
--

CREATE TABLE IF NOT EXISTS `evaluations` (
  `EvaluationID` varchar(15) NOT NULL,
  `EvaluationType` varchar(30) DEFAULT NULL,
  `ratingsID` int(15) DEFAULT NULL,
  PRIMARY KEY (`EvaluationID`),
  KEY `ratingsID` (`ratingsID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ratings`
--

CREATE TABLE IF NOT EXISTS `ratings` (
  `ratingsID` int(11) NOT NULL,
  `Rating` varchar(30) NOT NULL,
  `Period` varchar(255) NOT NULL,
  `Year` varchar(4) NOT NULL,
  `Commenter` varchar(255) NOT NULL,
  `CommentContent` varchar(255) NOT NULL,
  `EmployeeID` int(11) DEFAULT NULL,
  PRIMARY KEY (`ratingsID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ratings`
--

INSERT INTO `ratings` (`ratingsID`, `Rating`, `Period`, `Year`, `Commenter`, `CommentContent`, `EmployeeID`) VALUES
(1, '4/10', 'January-June', '2019', '', '', 1176),
(2, '10/10', 'January-June', '2019', 'Mr Chambakura', 'you have to keep the good work', 1176);

-- --------------------------------------------------------

--
-- Table structure for table `tasks`
--

CREATE TABLE IF NOT EXISTS `tasks` (
  `taskID` int(11) NOT NULL,
  `taskname` varchar(255) DEFAULT NULL,
  `taskstatus` varchar(100) DEFAULT NULL,
  `EmployeeID` int(11) DEFAULT NULL,
  PRIMARY KEY (`taskID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `evaluations`
--
ALTER TABLE `evaluations`
  ADD CONSTRAINT `evaluations_ibfk_1` FOREIGN KEY (`ratingsID`) REFERENCES `ratings` (`ratingsID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
