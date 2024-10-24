-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 24, 2024 at 02:29 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database_study101`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_calender`
--

CREATE TABLE `tbl_calender` (
  `calender_date` varchar(20) NOT NULL,
  `calender_event` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_calender`
--

INSERT INTO `tbl_calender` (`calender_date`, `calender_event`) VALUES
('2024-10-21', 'halooo, hola22, haloooo, holakdkhwehdoiewh, tesadd, ghdhw, dkshs, dihhw, jhfhufg');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_diary`
--

CREATE TABLE `tbl_diary` (
  `diary_name` varchar(20) NOT NULL,
  `diary_content` multilinestring NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tracker`
--

CREATE TABLE `tbl_tracker` (
  `tracker_subject` varchar(20) NOT NULL,
  `tracker_type` varchar(20) NOT NULL,
  `tracker_name` varchar(20) NOT NULL,
  `tracker_value` int(11) NOT NULL,
  `tracker_score` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_tracker`
--

INSERT INTO `tbl_tracker` (`tracker_subject`, `tracker_type`, `tracker_name`, `tracker_value`, `tracker_score`) VALUES
('', 'quiz', 'Quiz1', 50, 50),
('', 'mid', 'math mid sem 2', 100, 76),
('', 'final', 'final', 300, 298),
('', 'bonus', 'bonus', 20, 20),
('math', 'mid', 'mid', 90, 90),
('biology', 'final', 'final', 1, 1),
('biology', 'chapter test', 'mendel law', 100, 89);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `user_username` varchar(20) NOT NULL,
  `user_email` varchar(30) NOT NULL,
  `user_password` varchar(15) NOT NULL,
  `user_publicname` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`user_username`, `user_email`, `user_password`, `user_publicname`) VALUES
('lanalondah', 'lana@gmail.com', '123456', 'lana'),
('elsheradahlan', 'elshera@gmail.com', '12345', 'elshera');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
