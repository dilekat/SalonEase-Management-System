-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 13, 2026 at 02:42 PM
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
-- Database: `salonease`
--

-- --------------------------------------------------------

--
-- Table structure for table `appointments`
--

CREATE TABLE `appointments` (
  `appointment_id` int(11) NOT NULL,
  `customer_id` int(10) NOT NULL,
  `service_id` int(10) NOT NULL,
  `staff_name` varchar(100) NOT NULL,
  `app_date` date NOT NULL,
  `app_time` time(6) NOT NULL,
  `note` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `appointments`
--

INSERT INTO `appointments` (`appointment_id`, `customer_id`, `service_id`, `staff_name`, `app_date`, `app_time`, `note`) VALUES
(27, 19, 9, '', '2026-05-18', '08:30:00.000000', ''),
(29, 24, 9, '', '2026-06-15', '11:00:00.000000', '10:30:00'),
(30, 22, 10, '', '2026-06-11', '11:30:00.000000', ''),
(32, 23, 14, '', '2026-06-24', '12:00:00.000000', 'dry skin'),
(33, 25, 16, '', '2026-06-23', '11:30:00.000000', ''),
(34, 30, 17, '', '2026-06-13', '09:30:00.000000', ''),
(35, 23, 16, '', '2026-06-24', '11:00:00.000000', '');

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `full_name` varchar(50) NOT NULL,
  `phone` varchar(11) NOT NULL,
  `address` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `full_name`, `phone`, `address`) VALUES
(20, 'Asanga', '4569874123', 'panadura'),
(21, 'Kavisha', '0113654789', 'j ela'),
(22, 'Selani', '0706236092', 'aluthgama'),
(23, 'Madushani', '0761280107', 'pahalagama'),
(24, 'Pooja', '0772796535', 'kiribathgoda'),
(25, 'Dasuni', '0759284629', 'enderamulla'),
(29, 'Paboda', '0701028031', 'ragama'),
(30, 'Ravisha', '0760443181', 'hekittha');

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

CREATE TABLE `invoice` (
  `invoice_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `customer_name` varchar(20) NOT NULL,
  `date` date NOT NULL,
  `total` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `invoice`
--

INSERT INTO `invoice` (`invoice_id`, `customer_id`, `customer_name`, `date`, `total`) VALUES
(2, 22, 'Selani', '2026-06-11', 5700),
(3, 0, '', '2026-06-13', 0);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `user_id` int(10) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(50) NOT NULL,
  `security_answer` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`user_id`, `username`, `password`, `security_answer`) VALUES
(1, 'Owner', 'owner123', 'kumari'),
(2, 'Admin', '1234', 'hair coloring');

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `service_id` int(11) NOT NULL,
  `service_name` varchar(100) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `note` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`service_id`, `service_name`, `price`, `note`) VALUES
(8, 'hair coloring', 1500.00, 'base on hair type'),
(9, 'facial', 2500.00, 'skin treatment'),
(10, 'pedicure', 1500.00, 'foot care'),
(12, 'makeup', 3500.00, 'party, bridal,engagement makeup services'),
(13, 'hair cut', 1000.00, 'hair style preference'),
(15, 'clean up', 25000.00, 'dry skin'),
(16, 'bridal dressing', 6000.00, ''),
(17, 'waxing', 1500.00, 'professional beauty therapist');

-- --------------------------------------------------------

--
-- Table structure for table `service_staff`
--

CREATE TABLE `service_staff` (
  `id` int(11) NOT NULL,
  `service_id` int(11) NOT NULL,
  `staff_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `service_staff`
--

INSERT INTO `service_staff` (`id`, `service_id`, `staff_id`) VALUES
(24, 10, 48),
(26, 12, 50),
(27, 13, 51),
(28, 9, 52),
(31, 8, 55),
(32, 9, 56);

-- --------------------------------------------------------

--
-- Table structure for table `stafftable`
--

CREATE TABLE `stafftable` (
  `staff_id` int(10) NOT NULL,
  `staff_name` varchar(100) NOT NULL,
  `phone` varchar(15) NOT NULL,
  `Role` varchar(50) NOT NULL,
  `note` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `stafftable`
--

INSERT INTO `stafftable` (`staff_id`, `staff_name`, `phone`, `Role`, `note`) VALUES
(47, 'Nimali', '0115896472', 'hair cut', 'senior'),
(48, 'Anushka', '2556987412', 'pedicure', ''),
(49, 'Dinuka', '455698723', 'hair cut', 'beautician'),
(50, 'Saduni', '0112433335', 'makeup', 'specialized in bridal makeup and special events'),
(51, 'Dilki', '0762589478', 'hair cut', ''),
(52, 'Irosha', '0187545623', 'facial', ''),
(54, 'Dilshara', '0112547896', 'clean up', 'good practice'),
(55, 'Amali', '0712345678', 'hair coloring', 'experienced hair stylist with excellent customer s'),
(56, 'Irosha', '0187545623', 'facial', 'experienced in skincare and facial treatments');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `appointments`
--
ALTER TABLE `appointments`
  ADD PRIMARY KEY (`appointment_id`);

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`invoice_id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`service_id`);

--
-- Indexes for table `service_staff`
--
ALTER TABLE `service_staff`
  ADD PRIMARY KEY (`id`),
  ADD KEY `service_id` (`service_id`),
  ADD KEY `staff_id` (`staff_id`);

--
-- Indexes for table `stafftable`
--
ALTER TABLE `stafftable`
  ADD PRIMARY KEY (`staff_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `appointments`
--
ALTER TABLE `appointments`
  MODIFY `appointment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;

--
-- AUTO_INCREMENT for table `invoice`
--
ALTER TABLE `invoice`
  MODIFY `invoice_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `user_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `service_staff`
--
ALTER TABLE `service_staff`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `stafftable`
--
ALTER TABLE `stafftable`
  MODIFY `staff_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `service_staff`
--
ALTER TABLE `service_staff`
  ADD CONSTRAINT `service_staff_ibfk_1` FOREIGN KEY (`service_id`) REFERENCES `services` (`service_id`),
  ADD CONSTRAINT `service_staff_ibfk_2` FOREIGN KEY (`staff_id`) REFERENCES `stafftable` (`staff_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
