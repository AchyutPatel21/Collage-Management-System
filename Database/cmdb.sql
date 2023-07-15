-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 07, 2023 at 07:36 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cmdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `fees`
--

CREATE TABLE `fees` (
  `fid` int(11) NOT NULL,
  `sid` int(11) NOT NULL,
  `ssem` varchar(150) NOT NULL,
  `fees` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `fees`
--

INSERT INTO `fees` (`fid`, `sid`, `ssem`, `fees`) VALUES
(4, 1, '5 sem', 44500);

-- --------------------------------------------------------

--
-- Table structure for table `newadmission`
--

CREATE TABLE `newadmission` (
  `id` int(11) NOT NULL,
  `fname` varchar(150) NOT NULL,
  `fname2` varchar(150) NOT NULL,
  `gender` varchar(150) NOT NULL,
  `dob` varchar(150) NOT NULL,
  `mobile` bigint(20) NOT NULL,
  `email` varchar(150) DEFAULT NULL,
  `semester` varchar(150) NOT NULL,
  `sname` varchar(150) NOT NULL,
  `duration` varchar(150) NOT NULL,
  `address` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `newadmission`
--

INSERT INTO `newadmission` (`id`, `fname`, `fname2`, `gender`, `dob`, `mobile`, `email`, `semester`, `sname`, `duration`, `address`) VALUES
(1, 'Achyut', 'Nileshbhai', 'Male', '30/10/2002', 1234556789, 'achyut@gmail.com', '6 Sem', 'SoS', '2020-2024', 'ABC');

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `tid` int(11) NOT NULL,
  `fname` varchar(250) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `dob` varchar(50) NOT NULL,
  `mobile` bigint(20) NOT NULL,
  `email` varchar(250) DEFAULT NULL,
  `semester` varchar(250) NOT NULL,
  `programming` varchar(100) NOT NULL,
  `duration` varchar(250) NOT NULL,
  `address` varchar(300) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `teacher`
--

INSERT INTO `teacher` (`tid`, `fname`, `gender`, `dob`, `mobile`, `email`, `semester`, `programming`, `duration`, `address`) VALUES
(1, 'Monika', 'Female', '27 March 2023', 1234567890, 'monika@gmail.com', '6 Sem', 'C#', '2020 - 2024', 'Rajkot');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `fees`
--
ALTER TABLE `fees`
  ADD PRIMARY KEY (`fid`);

--
-- Indexes for table `newadmission`
--
ALTER TABLE `newadmission`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`tid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `fees`
--
ALTER TABLE `fees`
  MODIFY `fid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `newadmission`
--
ALTER TABLE `newadmission`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `teacher`
--
ALTER TABLE `teacher`
  MODIFY `tid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
