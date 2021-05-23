-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 23, 2021 at 05:40 AM
-- Server version: 10.4.13-MariaDB
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
CREATE TABLE IF NOT EXISTS `categories` (
  `category_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`category_id`, `name`) VALUES
(1, 'womans'),
(2, 'men'),
(5, 'kids');

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
CREATE TABLE IF NOT EXISTS `invoice` (
  `bill_id` int(11) NOT NULL AUTO_INCREMENT,
  `product_id` int(11) NOT NULL,
  `unit_price` float NOT NULL,
  `quantity` int(11) NOT NULL,
  `total_price` float NOT NULL,
  `date` varchar(30) NOT NULL,
  `provider` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`bill_id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `invoice`
--

INSERT INTO `invoice` (`bill_id`, `product_id`, `unit_price`, `quantity`, `total_price`, `date`, `provider`) VALUES
(2, 1, 12, 2, 144, 'Friday, May 21, 2021', 'basma'),
(3, 4, 2, 3, 6, 'Sunday, May 23, 2021', 'me');

-- --------------------------------------------------------

--
-- Table structure for table `outvoice`
--

DROP TABLE IF EXISTS `outvoice`;
CREATE TABLE IF NOT EXISTS `outvoice` (
  `bill_id` int(11) NOT NULL AUTO_INCREMENT,
  `product_id` int(11) NOT NULL,
  `unit_price` float NOT NULL,
  `quantity` int(11) NOT NULL,
  `total_price` float NOT NULL,
  `date` varchar(30) NOT NULL,
  `reciever` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`bill_id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outvoice`
--

INSERT INTO `outvoice` (`bill_id`, `product_id`, `unit_price`, `quantity`, `total_price`, `date`, `reciever`) VALUES
(4, 1, 2, 10, 20, 'Sunday, May 23, 2021', 'c'),
(2, 13, 2, 3, 6, 'Friday, May 14, 2021', 'ahmed'),
(3, 5, 2, 2, 4, 'Friday, May 14, 2021', 'basma khaled'),
(5, 1, 2, 22, 44, 'Sunday, May 23, 2021', 'c');

-- --------------------------------------------------------

--
-- Table structure for table `rolls`
--

DROP TABLE IF EXISTS `rolls`;
CREATE TABLE IF NOT EXISTS `rolls` (
  `roll_id` varchar(32) NOT NULL,
  `name` varchar(32) NOT NULL,
  PRIMARY KEY (`roll_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rolls`
--

INSERT INTO `rolls` (`roll_id`, `name`) VALUES
('stock_viewonly', 'viewonly'),
('stock_insert', 'insert'),
('stock_update', 'update'),
('stock_delete', 'delete'),
('bills_viewonly', 'viewonly'),
('bills_insert', 'insert'),
('bills_delete', 'delete'),
('bills_update', 'update'),
('users_viewonly', 'viewonly'),
('users_insert', 'insert'),
('users_update', 'update'),
('users_delete', 'delete');

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

DROP TABLE IF EXISTS `stock`;
CREATE TABLE IF NOT EXISTS `stock` (
  `product_id` int(11) NOT NULL AUTO_INCREMENT,
  `product_name` varchar(50) NOT NULL,
  `unit_price` float NOT NULL,
  `description` varchar(100) NOT NULL,
  `quantity` int(11) NOT NULL,
  `category_id` int(11) NOT NULL,
  PRIMARY KEY (`product_id`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`product_id`, `product_name`, `unit_price`, `description`, `quantity`, `category_id`) VALUES
(1, 'soape', 1.5, 'This soap is the best soap ever!', 0, 2),
(2, 'shampo', 1, 'Best shampoo ever', 10, 0),
(4, 'Barbie', 204, 'Barbie Barbie lets go party!', 13, 1),
(5, 'potato', 1, 'Potato is lazy', 90, 2),
(6, 'banana', 6, 'banana in bigama', 10, 2),
(7, 'panadol', 10, 'For headache', 2, 2),
(8, 'chocolate', 2, 'chocolate is very good!', 30, 2),
(13, 'botato', 12, 'men are botato', 12, 1),
(14, 'nano', 12, 'dvdvdv', 12, 1);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `email`, `password`) VALUES
(35, 'admin', 'admin', '1234'),
(1, 'basma', 'b', '1234'),
(33, 'hello', 'hello', '1234'),
(32, 'aya kamal hshad', 'aya kamalh', '1234'),
(31, 'aya kamal', 'aya kamal', '1234'),
(30, 'aya', 'aya', '1234'),
(29, 'tasneem alhares', 'test2', '1234'),
(28, 'basma khaled', 'test1', '1234'),
(27, 'ahmed buker', 'test', '1234');

-- --------------------------------------------------------

--
-- Table structure for table `users_rolls`
--

DROP TABLE IF EXISTS `users_rolls`;
CREATE TABLE IF NOT EXISTS `users_rolls` (
  `user_id` int(32) NOT NULL,
  `roll_id` varchar(32) NOT NULL,
  `type` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users_rolls`
--

INSERT INTO `users_rolls` (`user_id`, `roll_id`, `type`) VALUES
(1, 'users_insert', 'users'),
(1, 'users_update', ''),
(29, 'stock_insert', 'stock'),
(29, 'stock_update', 'stock'),
(29, 'users_insert', 'users'),
(29, 'bills_insert', 'bills'),
(35, 'stock_insert', 'stock'),
(35, 'stock_update', 'stock'),
(35, 'stock_delete', 'stock'),
(35, 'bills_insert', 'bills'),
(35, 'bills_update', 'bills'),
(35, 'bills_delete', 'bills'),
(35, 'users_insert', 'users'),
(35, 'users_update', 'users'),
(35, 'users_delete', 'users');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
