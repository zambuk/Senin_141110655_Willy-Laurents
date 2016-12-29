-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 29, 2016 at 02:29 PM
-- Server version: 5.6.26
-- PHP Version: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pos`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE IF NOT EXISTS `barang` (
  `ID` int(10) NOT NULL,
  `Kode` varchar(20) DEFAULT NULL,
  `Nama` varchar(100) DEFAULT NULL,
  `JumlahAwal` int(10) DEFAULT NULL,
  `HargaHPP` decimal(16,2) DEFAULT NULL,
  `HargaJual` decimal(16,2) DEFAULT NULL,
  `Created_at` datetime DEFAULT NULL,
  `Updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`ID`, `Kode`, `Nama`, `JumlahAwal`, `HargaHPP`, `HargaJual`, `Created_at`, `Updated_at`) VALUES
(2, 'LMP123', 'Lampu123', 63, '123.00', '123.00', '2016-12-18 09:45:10', '2016-12-27 19:46:25');

-- --------------------------------------------------------

--
-- Table structure for table `costumer`
--

CREATE TABLE IF NOT EXISTS `costumer` (
  `id` int(255) NOT NULL,
  `kode` varchar(255) DEFAULT NULL,
  `nama` varchar(255) DEFAULT NULL,
  `alamat` varchar(255) DEFAULT NULL,
  `telepon` varchar(255) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `costumer`
--

INSERT INTO `costumer` (`id`, `kode`, `nama`, `alamat`, `telepon`) VALUES
(1, 'MDN1', 'Medan123', 'medan', '087769007715'),
(2, 'TEST', 'test', 'test', 'test'),
(3, 'ASD', 'adsf', 'adsf', 'asdf');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian`
--

CREATE TABLE IF NOT EXISTS `pembelian` (
  `id` int(255) NOT NULL,
  `id_barang` int(255) NOT NULL,
  `id_supplier` int(255) NOT NULL,
  `banyak_barang` int(255) NOT NULL,
  `tanggal_beli` datetime NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian`
--

INSERT INTO `pembelian` (`id`, `id_barang`, `id_supplier`, `banyak_barang`, `tanggal_beli`) VALUES
(1, 2, 1, 0, '2016-12-29 19:33:46'),
(2, 2, 1, 10, '2016-12-29 19:35:40'),
(3, 2, 1, 10, '2016-12-29 20:14:23'),
(4, 2, 1, 1, '2016-12-29 20:19:09'),
(5, 2, 1, 1, '2016-12-29 20:19:14'),
(6, 2, 1, 2, '2016-12-29 20:23:11'),
(7, 2, 1, 3, '2016-12-29 20:23:16'),
(8, 2, 1, 3, '2016-12-29 20:23:52'),
(9, 2, 1, 3, '2016-12-29 20:24:26');

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE IF NOT EXISTS `penjualan` (
  `id` int(255) NOT NULL,
  `id_barang` int(255) NOT NULL,
  `id_costumer` int(255) NOT NULL,
  `banyak_barang` int(255) NOT NULL,
  `tanggal_jual` datetime NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penjualan`
--

INSERT INTO `penjualan` (`id`, `id_barang`, `id_costumer`, `banyak_barang`, `tanggal_jual`) VALUES
(1, 2, 1, 10, '2016-12-29 20:13:38'),
(2, 2, 1, 20, '2016-12-29 20:14:37'),
(3, 2, 1, 10, '2016-12-29 20:25:02'),
(4, 2, 1, 10, '2016-12-29 20:25:05'),
(5, 2, 1, 20, '2016-12-29 20:25:16');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
  `id` int(255) NOT NULL,
  `kode` varchar(255) DEFAULT NULL,
  `nama` varchar(255) DEFAULT NULL,
  `alamat` varchar(255) DEFAULT NULL,
  `telepon` varchar(255) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`id`, `kode`, `nama`, `alamat`, `telepon`) VALUES
(1, 'MDN1', 'Medan123', 'medan', '087769007715'),
(2, 'SUP', 'su', 'sup', 'sup'),
(3, 'TESTSA', 'asdf', 'adsf', 'asdf');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `costumer`
--
ALTER TABLE `costumer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `costumer`
--
ALTER TABLE `costumer`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `pembelian`
--
ALTER TABLE `pembelian`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `penjualan`
--
ALTER TABLE `penjualan`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
