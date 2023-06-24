-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: MYSQL8001.site4now.net
-- Generation Time: Jun 22, 2023 at 04:15 AM
-- Server version: 8.0.28
-- PHP Version: 7.4.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_a99450_root`
--
CREATE DATABASE IF NOT EXISTS `db_a99450_root` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `db_a99450_root`;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int NOT NULL,
  `RoleId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ClaimValue` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `NormalizedName` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int NOT NULL,
  `UserId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ClaimValue` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProviderKey` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProviderDisplayName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `UserId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `RoleId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Status` int NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `UserName` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Email` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `SecurityStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `PhoneNumber` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `Name`, `Status`, `CreatedAt`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('512c10c1-4020-4d5d-aeb9-97e6d928886b', '', 1, '2023-06-16 11:07:29.295804', 'tarekfouda0@gmail.com', 'TAREKFOUDA0@GMAIL.COM', 'tarekfouda0@gmail.com', 'TAREKFOUDA0@GMAIL.COM', 1, 'AQAAAAIAAYagAAAAEFnAFTOdoBsAqYreCdsdiWgq/17CY4lpT1yTX7NYNYXK0JVaTfRPmUHKUbaXC4iVsw==', 'WG2KHWVRGYTCDMYRQN5GPCTWOWQBEXLD', '6ffc6299-9922-4bfb-8706-a5f7c9d5f21d', NULL, 0, 0, NULL, 1, 0),
('5c138875-beb6-4e00-992f-26fc405f8e02', 'Taher Fouda', 1, '2023-06-16 15:42:18.313243', 'TaherFouda', 'TAHERFOUDA', 'taherfouda@gmail.com', 'TAHERFOUDA@GMAIL.COM', 0, 'AQAAAAIAAYagAAAAEB6zXX5f6yqRrzln6Y8SQ27vZm0pUXIWjJ1sATEiXU6xDWzK6ahYWwX22+D4KZwOwg==', 'JQZO5YNG35Y6YA7U5UPS75JANXYZCTWD', '3b0395cc-2cd6-4694-818a-c62d4bb438ce', '01551575335', 0, 0, NULL, 1, 0),
('f09557e7-fc62-4538-b8c4-61a3a7b9c67f', 'Tarek Fouda', 1, '2023-06-16 12:31:22.253440', 'TarekFouda', 'TAREKFOUDA', 'tarekfouda@gmail.com', 'TAREKFOUDA@GMAIL.COM', 0, 'AQAAAAIAAYagAAAAEN7uT09ZxpNscw0FvGNOb4z2Hig/WZKZOOXZUgsrSvReZeIiiCnFxTNHpuhCZrptSA==', 'TSXKOMI4ZWXQ2F5OPF343VCXKA4GZPGP', '6b1f93e5-873b-4ceb-ad8a-42e696fb1a9c', '01551575332', 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LoginProvider` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cheques`
--

CREATE TABLE `cheques` (
  `Id` int NOT NULL,
  `DateTime` datetime(6) NOT NULL,
  `Price` double NOT NULL,
  `ContractId` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `Id` int NOT NULL,
  `NameEn` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `NameAr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Phone` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Addresss` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Password` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProfileImage` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Building` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Apartment` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Floor` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ContractId` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `contacts`
--

CREATE TABLE `contacts` (
  `Id` int NOT NULL,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Message` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `contacts`
--

INSERT INTO `contacts` (`Id`, `Name`, `Email`, `Message`, `CreatedAt`) VALUES
(1, 'tarek fouda', 'tarekfouda@gmail.com', 'help me', '2023-06-17 15:05:44.000000'),
(3, 'tarek hussein', 'tarekfouda2020@gmail.com', 'good service', '2023-06-18 10:29:01.186062'),
(4, 'jkwedbncas', 'ajkcns@sjdnc.ewfsdcv', 'wefkjca feewdsjk', '2023-06-18 10:59:18.235158'),
(5, 'lkascd', 'jncas@edjkf.sdv', 'wkevdns fwevds', '2023-06-18 11:00:38.909107'),
(6, 'evsd', 'sdv@srf.sv', 'sefvdcs evdserfvd vd', '2023-06-18 11:02:06.549135'),
(7, 'ldvz', 'sdvkm@edfs.sdv', 'wjefncsd wvkds', '2023-06-18 11:03:14.137734'),
(8, 'kwefdsc', 'wefkcsd@sfdc.sfcdc', 'wdqeakck fewcsdnwefc', '2023-06-18 11:29:03.611867'),
(9, 'jkwedbncas', 'fewcsd@fsed.esfv', 'wefsc', '2023-06-18 11:30:56.499371'),
(10, 'jdwenasc', 'wdenacs@wsefkj.wefac', 'wedicas', '2023-06-18 11:46:44.403032'),
(11, 'jkwedbncas', 'tarekfouda0@gmail.com', 'wefsd', '2023-06-18 11:47:31.862442');

-- --------------------------------------------------------

--
-- Table structure for table `contractattacments`
--

CREATE TABLE `contractattacments` (
  `Id` int NOT NULL,
  `Url` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ContrctId` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `contracts`
--

CREATE TABLE `contracts` (
  `Id` int NOT NULL,
  `ContractNumber` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DesEn` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DesAr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `NameEn` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `NameAr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Address` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `MaxSparePrice` double NOT NULL,
  `ContractPrice` double NOT NULL,
  `FromDate` datetime(6) NOT NULL,
  `ToDate` datetime(6) NOT NULL,
  `ContrctPassword` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `OwnerId` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `contractservices`
--

CREATE TABLE `contractservices` (
  `Id` int NOT NULL,
  `ContractId` int NOT NULL,
  `ServiceId` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `morals`
--

CREATE TABLE `morals` (
  `Id` int NOT NULL,
  `NameAr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `NameEn` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DesAr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DesEn` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime(6) NOT NULL,
  `Image` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `morals`
--

INSERT INTO `morals` (`Id`, `NameAr`, `NameEn`, `DesAr`, `DesEn`, `CreatedAt`, `Image`) VALUES
(1, 'السرعة', 'Speed', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', '2023-06-18 00:27:44.582924', 'Images/Morals/cd4e4370-8732-41e3-b1a1-3539f4c0df41.png'),
(3, 'sdmc', 'skdcm', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', '2023-06-18 00:27:36.566603', 'Images/Morals/27927c85-f88d-44b9-be2f-c7892a9ea8f3.png'),
(4, 'aksdzc', 'lskdvmc ', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', '2023-06-18 00:27:56.097394', 'Images/Morals/ee64750d-7651-424a-bc9f-23f1e4afea0d.png');

-- --------------------------------------------------------

--
-- Table structure for table `munafasadb`
--

CREATE TABLE `munafasadb` (
  `COL 1` varchar(36) DEFAULT NULL,
  `COL 2` varchar(57) DEFAULT NULL,
  `COL 3` varchar(1072) DEFAULT NULL,
  `COL 4` varchar(1175) DEFAULT NULL,
  `COL 5` varchar(878) DEFAULT NULL,
  `COL 6` varchar(26) DEFAULT NULL,
  `COL 7` varchar(84) DEFAULT NULL,
  `COL 8` varchar(32) DEFAULT NULL,
  `COL 9` varchar(36) DEFAULT NULL,
  `COL 10` varchar(11) DEFAULT NULL,
  `COL 11` varchar(20) DEFAULT NULL,
  `COL 12` varchar(16) DEFAULT NULL,
  `COL 13` varchar(10) DEFAULT NULL,
  `COL 14` varchar(14) DEFAULT NULL,
  `COL 15` varchar(17) DEFAULT NULL,
  `COL 16` varchar(11) DEFAULT NULL,
  `COL 17` varchar(6) DEFAULT NULL,
  `COL 18` varchar(26) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `munafasadb`
--

INSERT INTO `munafasadb` (`COL 1`, `COL 2`, `COL 3`, `COL 4`, `COL 5`, `COL 6`, `COL 7`, `COL 8`, `COL 9`, `COL 10`, `COL 11`, `COL 12`, `COL 13`, `COL 14`, `COL 15`, `COL 16`, `COL 17`, `COL 18`) VALUES
('Id', 'RoleId', 'ClaimType', 'ClaimValue', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'Name', 'NormalizedName', 'ConcurrencyStamp', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'UserId', 'ClaimType', 'ClaimValue', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('LoginProvider', 'ProviderKey', 'ProviderDisplayName', 'UserId', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('UserId', 'RoleId', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'UserName', 'NormalizedUserName', 'Email', 'NormalizedEmail', 'EmailConfirmed', 'PasswordHash', 'SecurityStamp', 'ConcurrencyStamp', 'PhoneNumber', 'PhoneNumberConfirmed', 'TwoFactorEnabled', 'LockoutEnd', 'LockoutEnabled', 'AccessFailedCount', 'Name', 'Status', 'CreatedAt'),
('512c10c1-4020-4d5d-aeb9-97e6d928886b', 'tarekfouda0@gmail.com', 'TAREKFOUDA0@GMAIL.COM', 'tarekfouda0@gmail.com', 'TAREKFOUDA0@GMAIL.COM', '1', 'AQAAAAIAAYagAAAAEFnAFTOdoBsAqYreCdsdiWgq/17CY4lpT1yTX7NYNYXK0JVaTfRPmUHKUbaXC4iVsw==', 'WG2KHWVRGYTCDMYRQN5GPCTWOWQBEXLD', '6ffc6299-9922-4bfb-8706-a5f7c9d5f21d', '', '0', '0', '', '1', '0', '', '1', '2023-06-16 11:07:29.295804'),
('5c138875-beb6-4e00-992f-26fc405f8e02', 'TaherFouda', 'TAHERFOUDA', 'taherfouda@gmail.com', 'TAHERFOUDA@GMAIL.COM', '0', 'AQAAAAIAAYagAAAAEB6zXX5f6yqRrzln6Y8SQ27vZm0pUXIWjJ1sATEiXU6xDWzK6ahYWwX22+D4KZwOwg==', 'JQZO5YNG35Y6YA7U5UPS75JANXYZCTWD', '3b0395cc-2cd6-4694-818a-c62d4bb438ce', '01551575335', '0', '0', '', '1', '0', 'Taher Fouda', '1', '2023-06-16 15:42:18.313243'),
('f09557e7-fc62-4538-b8c4-61a3a7b9c67f', 'TarekFouda', 'TAREKFOUDA', 'tarekfouda@gmail.com', 'TAREKFOUDA@GMAIL.COM', '0', 'AQAAAAIAAYagAAAAEN7uT09ZxpNscw0FvGNOb4z2Hig/WZKZOOXZUgsrSvReZeIiiCnFxTNHpuhCZrptSA==', 'TSXKOMI4ZWXQ2F5OPF343VCXKA4GZPGP', '6b1f93e5-873b-4ceb-ad8a-42e696fb1a9c', '01551575332', '0', '0', '', '1', '0', 'Tarek Fouda', '1', '2023-06-16 12:31:22.253440'),
('UserId', 'LoginProvider', 'Name', 'Value', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'DateTime', 'Price', 'ContractId', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'NameEn', 'NameAr', 'Email', 'Phone', 'Addresss', 'Password', 'ProfileImage', 'Building', 'Apartment', 'Floor', 'ContractId', NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'Name', 'Email', 'Message', 'CreatedAt', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('1', 'tarek fouda', 'tarekfouda@gmail.com', 'help me', '2023-06-17 15:05:44.000000', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('3', 'tarek hussein', 'tarekfouda2020@gmail.com', 'good service', '2023-06-18 10:29:01.186062', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('4', 'jkwedbncas', 'ajkcns@sjdnc.ewfsdcv', 'wefkjca feewdsjk', '2023-06-18 10:59:18.235158', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('5', 'lkascd', 'jncas@edjkf.sdv', 'wkevdns fwevds', '2023-06-18 11:00:38.909107', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('6', 'evsd', 'sdv@srf.sv', 'sefvdcs evdserfvd vd', '2023-06-18 11:02:06.549135', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('7', 'ldvz', 'sdvkm@edfs.sdv', 'wjefncsd wvkds', '2023-06-18 11:03:14.137734', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('8', 'kwefdsc', 'wefkcsd@sfdc.sfcdc', 'wdqeakck fewcsdnwefc', '2023-06-18 11:29:03.611867', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('9', 'jkwedbncas', 'fewcsd@fsed.esfv', 'wefsc', '2023-06-18 11:30:56.499371', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('10', 'jdwenasc', 'wdenacs@wsefkj.wefac', 'wedicas', '2023-06-18 11:46:44.403032', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('11', 'jkwedbncas', 'tarekfouda0@gmail.com', 'wefsd', '2023-06-18 11:47:31.862442', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'Url', 'ContrctId', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'ContractNumber', 'DesEn', 'DesAr', 'NameEn', 'NameAr', 'Address', 'MaxSparePrice', 'ContractPrice', 'FromDate', 'ToDate', 'ContrctPassword', 'OwnerId', NULL, NULL, NULL, NULL, NULL),
('Id', 'ContractId', 'ServiceId', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'NameAr', 'NameEn', 'DesAr', 'DesEn', 'CreatedAt', 'Image', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('1', 'السرعة', 'Speed', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', '2023-06-18 00:27:44.582924', 'Images/Morals/cd4e4370-8732-41e3-b1a1-3539f4c0df41.png', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('3', 'sdmc', 'skdcm', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', '2023-06-18 00:27:36.566603', 'Images/Morals/27927c85-f88d-44b9-be2f-c7892a9ea8f3.png', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('4', 'aksdzc', 'lskdvmc ', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', 'When your test database is filled with realistic looking data, you\'ll be more engaged as a tester. When you demonstrate new features to others, they\'ll un', '2023-06-18 00:27:56.097394', 'Images/Morals/ee64750d-7651-424a-bc9f-23f1e4afea0d.png', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'NameEn', 'NameAr', 'Email', 'Phone', 'ProfileImage', 'Password', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'Url', 'RequestId', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'ContractId', 'ServiceId', 'ClientId', 'VisitDate', 'Desc', 'OwnerNote', 'TecnicianNote', 'AdditionalPrice', 'Status', 'Rate', 'TechnicianId', NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'ImageUrl', 'DesEn', 'DesAr', 'NameEn', 'NameAr', 'CreatedAt', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('2', 'Images/Services/f3a7be80-b465-45a4-8bd6-bbde96a100de.png', '<div>We in <b>(Munafasa)</b> have highly skilled carpenters for carpentry services that can fulfill any of your requirements. From fixing wooden furniture to door handles, we believe in providing expert carpentry solutions at reasonable and competitive prices that allow excellent results.</div><div><br></div><div>Maintaining one’s furniture is important, it could be to save any potential expenses by replacing old furniture with a new one or even to preserve a precious heirloom. We provide skilled carpenters for repairing and/or maintaining your home and/or office furniture.</div><div><br></div><div>Trained carpentry service providers can give your residential or commercial areas a simple or fancy look. Our highly trained staffs are capable of handling the furniture\'s beauty and design.</div>', 'يعمل لدى شركة <b>(شركة منافسة)</b> نجارون من ذوي المهارات العالية لتقديم خدمات النجارة  وتلبية جميع متطلبات العملاء. بداية من أعمال تركيب الأثاث الخشبي إلى مقبض الباب، نؤمن بتوفير حلول النجارة المتخصصة التي تسمح بتقديم نتائج ممتازة وبأسعار معقولة ومنافسة.\r\n\r\nصيانة الأثاث من الأمور الهامة لأن ذلك يساهم في توفير أي نفقات محتملة من خلال استبدال الأثاث القديم بآثاث جديد أو الحفاظ على هذا الإرث الثمين. نقدم نحن في الشركة النجارين من ذوي المهارات والخبرة الضرورية لإصلاح و صيانة أثاث منزلك و مكتبك.\r\n\r\nيجوز لمقدمي خدمات النجارة المدربين إجراء معاينة بسيطة الى المناطق السكنية أو التجارية الخاصة بك. يملك موظفينا المدربين تدريباً عالياً القدرة على التعامل مع جمالية وتصميم الأثاث.', 'CARPENTRY SERVICES', 'خدمات أعمال النجارة', '2023-06-18 09:47:13.487128', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('3', 'Images/Services/492b5d51-e73c-4908-b6ce-5b4ba6037275.webp', 'Epoxy ­flooring is a type of fl­ooring that is made from a two-part epoxy resin system. Epoxy resin is a type of thermosetting polymer that is formed by mixing two components – a resin and a hardener. When these two components are mixed together, they undergo a chemical reaction that results in a hard, durable, and resistant surface. Epoxy ­flooring is popular in commercial and industrial settings because it is highly durable and resistant to damage from heavy foot traffic, chemicals, and abrasion. It is also easy to clean and maintain, making it a good choice for facilities that require a high level of cleanliness.&nbsp;', '<div>عد أرضيات الإيبوكسي من أفضل اختيارات الأرضيات بين الأشخاص. ويرجع ذلك بصفة أساسية لتنوعها ومتانتها. يختار العملاء&nbsp; خدمات أرضيات الإيبوكسي بسبب قوتها ومقاومتها وسهولة تنظيفها وصيانتها وقيمتها المالية.</div><div><br></div><div>يرجع نجاحنا إلى اهتمامنا بالتفاصيل في كل خطوة من عملية التنفيذ ونضع اهتماما خاصا في مرحلة تجهيز الأرضية وإعداد التركيبة وكذلك خلال عملية التطبيق.</div><div><br></div><div>&nbsp;هناك العديد من العوامل التي يتعين أن تضعها شركتنا في الاعتبار&nbsp; لتحقيق أفضل نتائج أرضيات الإيبوكسي لعملائها.</div><div><br></div><div>في مرحلة التجهيز، يتعين أن تتأكد شركتنا من أن تكون الأرضية ملساء ومسامية بما يتيح للإيبوكسي الالتصاق بها. وذلك يعني عدم وجود أي شقوق أو دهون أو سوائل أخرى على الأرضية ويعني أيضا أنه يتعين فحص وجود أي مانع تسريب موضوع مسبقاً بالأرضية حيث أن الأرضية التي بها مانع تسريب تكون غير مناسبة لوضع أرضيات الإيبوكسي.</div><div><br></div><div>بمجرد الانتهاء من مرحلة تجهيز الأرضية ننتقل لمرحلة التطبيق، حيث تنفذ عملية التطبيق بواسطة&nbsp; أفرادنا المتخصصين بسرعة وفي درجات الحرارة المتحكم بها ومن ثم لا تتكون أي فقاعات.</div>', 'EPOXY FLOORING', 'خدمات الأيبوكسي', '2023-06-18 10:01:22.477645', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('4', 'Images/Services/5ca76f85-df7f-4be8-ab39-c55d19ac399e.png', '<div>Plumbing issues can arise from any system that carries water and is not working as intended. It can range from hot and cold water issues to overflowing water tanks. General issues of plumbing may come from the pipes, faucets, valves, fixtures and fittings, showers, taps, tanks, water pumps, and other systems that carry water.</div><div><br></div><div>We provide high-quality best plumbing services. Our teams of trained technicians are well versed in the field of plumbing and can handle any plumbing issues either from residential or commercial properties.</div>', '<div>يمكن لمشاكل السباكة أن تنشأ من أي نظام ينقل الماء ولا يعمل على النحو المطلوب. وتشمل هذه المشاكل المياه الساخنة والباردة وخزانات المياه الفائضة. ويمكن للمشاكل العامة المتعلقة بالسباكة أن تنشأ من الأنابيب والحنفيات والصمامات والتركيبات والتجهيزات وحوض الاستحمام والصنابير والخزانات ومضخات المياه والأنظمة الأخرى التي تنقل المياه.</div><div><br></div><div>تقدم شركتنا أفضل خدمات السباكة عالية الجودة. نملك فرق من الفنيين المدربين في مجال أعمال السباكة والقادرين على التعامل مع أي مشاكل في السباكة سواء في الوحدات السكنية أو التجارية.&nbsp;</div>', 'PLUMBING SERVICES', 'خدمات السباكة', '2023-06-18 09:51:30.973416', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('5', 'Images/Services/6bdd5944-c311-4ae0-a1b6-cd6c8795b729.png', 'Electrical issues can come up at any time or anywhere. There can be a range of issues such as a light bulb needing replacement also needing to fix a burnt-out circuit board. No matter what the issue, they need to be handled with care and by trained professionals. We provide the best electrical service in Dubai at the most affordable rates. we have skilled technicians specially trained to handle any electrical-related issue. This can be in residential or commercial properties. Our technicians are also well versed in the installation and testing of electrical-related work, all of which are handled with care and high-quality work.', 'يمكن للمشاكل الكهربائية أن تحدث في أي وقت أو في أي مكان. ويمكن حدوث مجموعة من المشاكل مثل المصباح الكهربائي الذي يجب استبداله عند الحاجة وإصلاح لوحة دائرة كهربائية محترقة. فبغض النظر عن نوع المشكلة، يجب التعامل معها بعناية ومن قبل موظفين محترفين ومدربين. تقدم شركة (شركة منافسة) أفضل الخدمات الكهربائية وبأسعار معقولة تناسب الجميع. كما أننا نملك الفنيين ذوي الخبرة والمدربين بشكل خاص للتعامل مع أي مشكلة متعلقة بالكهرباء. يمكن أن يتم ذلك في العقارات السكنية أو التجارية. كما يملك الفنيين في الشركة خبرة كبيرة في تركيب واختبار الأعمال المتعلقة بالكهرباء والتي يتم التعامل معها بعناية وجودة عالية.', 'Electricity services', 'الخدمات الكهربائية', '2023-06-18 09:52:23.056378', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('6', 'Images/Services/994d4351-5aa9-4ca8-bcee-d12eea276b5c.png', '<div>Residential buildings need to be repaired when they are exposed to what affects them, such as cracks and cracks, and other signs that can lead to the collapse of the building. The most common building defects are:</div><div><br></div><div>Disadvantages related to consumption:</div><div>Many people make some mistakes that violate the standard specifications of the building, such as widening the opening for windows, making a hole in one of the walls of the building to install air conditioners, or renewing the sewage pipes installed inside the walls.</div><div><br></div><div>Security defects:</div><div>These defects appear as a result of neglecting surface cracks and cracks, or water leaks in the building\'s sewage pipes, which increases the humidity level. It can also appear when building a number of floors in violation, and this leads to exceeding the load ratio allocated to the building.</div>', '<div>تحتاج المبانى السكنية إلى الترميم عند تعرضها لما يؤثر عليها كالشروخ والتشققات، وغيرها من العلامات التي يمكن أن تؤدي إلى سقوط المبنى، وتتمثل أكثر عيوب المباني الشائعة في:</div><div><br></div><div>عيوب متعلقة بالإستهلاك:&nbsp;</div><div>يرتكب العديد من الأشخاص بعض الأخطاء التي تخالف المواصفات القياسية للمبنى، مثل توسعة الفتحة المخصصة للنوافذ، أو إحداث فتحة في أحد حوائط المبنى لتركيب التكييفات، أو تجديد أنابيب الصرف الصحي المركبة داخل الجدران.</div><div><br></div><div>عيوب متعلقة بعوامل الأمان:&nbsp;</div><div>تَظهر هذه العيوب نتيجة إهمال الشروخ والتشققات السطحية، أو تسريبات المياه في أنابيب الصرف الصحي للمبنى مما يزيد من نسبة الرطوبة؛ كما يمكن أن تظهر أيضاً عند بناء عدد من الطوابق بشكل مخالف، وهذا يؤدِي إلى تتخطى نسبة التحميل المخصصة للمبنى.</div>', 'Building restorations', 'تريميمات المباني', '2023-06-18 09:53:35.686143', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('7', 'Images/Services/7b83aded-7b47-489f-bf4e-4f43c1f6030e.png', '<p>Any residential or commercial building or property requires constant maintenance to maintain quality living standards. Any residential or commercial building or property requires constant maintenance to maintain quality living standards. If these maintenance and renovation needs are not managed well they might lead to much worse incidents like fire hazards, pest effects, bad air conditions and even building collapses.</p><p>We have a highly experienced team for annual maintenance contract services in Dubai. We are a premium maintenance company offering a wide range of services for your commercial and residential property. We provide the most responsive service. We maintain your home 24×7 in our annual maintenance package.</p><p>We provide essential services like regular AC Servicing, Plumbing, Electrical services, masonry work, Handyman services, AC Duct Cleaning, Carpentry, Water tank cleaning, Furniture cleaning, Deep cleaning service, Exterior cleaning, etc. As per customer requirements, we provide the most suitable Customized AMC packages.&nbsp;</p>', '<p>يوفر عقد الصيانة السنوي هدوء النفس وراحة البال للمالك. حيث يلبي عقد الصيانة السنوي متطلبات الصيانة اليومية الخاصة بك. كما يمكن لعقد الصيانة السنوي أن يضم حتى الأعمال اليدوية الصغيرة لأعمال التجديد الكبيرة. ويمكنك الاطمئان بأن عقد الصيانة السنوي يهتم بجميع أنواع العمل نيابة عنك.</p><p>نحن في شركة (شركة منافسة) نملك فريق من ذوي الخبرة العالية لتقديم خدمات عقود الصيانة السنوية في دبي. كما أننا شركة صيانة متميزة في تقديم مجموعة واسعة من الخدمات للعقارات التجارية والسكنية. ونقدم الخدمة الأكثر استجابة. نعمل على صيانة منزلك على مدار الساعة وطوال أيام الأسبوع ضمن مجموعة من خدمات الصيانة السنوية.</p><p>ينص عقد الصيانة السنوي على إجراء فحوصات صيانة بانتظام للأعمال الصحية والكهرباء وخدمات المكيف والنجارة. وبالتالي تحديد الأعطال الصغيرة لمنع القيام بالإصلاحات أو الأضرار الكبيرة. نعمل بصفة مستشار لعملاء عقود الصيانة السنوية الخاصة بنا، ونخطرهم بالمشاكل التي يواجهوها في منازلهم أو مكاتبهم، ونساعدهم على حلها بكفاءة عالية وفعالية من حيث التكلفة.</p><p>نقدم الخدمات الأساسية مثل خدمة المكيف العادية، والخدمات الصحية، والكهرباء، والخدمات الحرفية، وتنظيف قنوات الهواء، وأعمال النجارة، وتنظيف خزان المياه، وتنظيف الأثاث والمفروشات، وخدمة التنظيف العميق والتنظيف الخارجي إلخ.</p>', 'ANNUAL MAINTENANCE CONTRACT', 'عقد الصيانة السنوي', '2023-06-18 10:10:01.618735', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('8', 'Images/Services/4ae3927e-89e6-4b88-8981-184520848ff2.png', '<p>We <b>(Munafasa)</b> are one of the best cleaning services providers with a 100% guarantee. As a professional cleaning company in Dubai, Primo has centered its entire operations on delivering high-quality cleaning services for both residential and commercial purposes. Except for general cleaning services we provide deep cleaning services, sofa cleaning services, carpet cleaning services, sanitization services, and marble polishing services.&nbsp;</p><p><br></p><p>Due to the evolving nature of the cleaning industry, we pride ourselves on being at the forefront of the cleaning industry by continuously training our staff and using the most up-to-date machinery and technology.&nbsp;</p>', '<p>تعتبر شركة <b>(شركة منافسة)</b> من أفضل مزودي خدمات التنظيف مع ضمان 100٪. نحن متخصصون بتنظيف جميع الأماكن السكنية والتجارية وإزالة جميع الأتربة لكي تبدو وكأنها جديدة.</p><p><br></p><p>بصفتنا أفضل شركة تقدم خدمات تنظيف احترافية، فقد ركزت شركة (شركة منافسة) كامل أعمالها على تقديم خدمات تنظيف عالية الجودة للأغراض السكنية والتجارية. لا يوجد بالنسبة لنا مشروع كبير جداً أو صغير جداً أو سهل جداً أو صعب جداً لنقوم بتنفيذه. يضمن الفريق المتخصص من الموظفين المدربين على مستوى عال في شركة بريمو الحفاظ على المناطق الداخلية والخارجية لأي منطقة تجارية أو صناعية ضمن مستوى عالي من النظافة المثالية.</p><p><br></p><p>بناء على الطبيعة المتطورة في صناعة التنظيف، نفخر بأنفسنا بأننا في طليعة صناعة التنظيف من خلال التدريب المستمر لموظفينا واستخدام أحدث الآلات والتكنولوجيا.</p>', 'BEST CLEANING COMPANY', 'خدمات التنظيف', '2023-06-18 09:55:59.691758', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('9', 'Images/Services/8cf10085-41a6-4182-9cf5-d4a1805aa6f3.jpg', '<p>We<b> (Munafasa)</b> provide the best AC services in Dubai at the most affordable rates. Your AC duct is a source of fresh air and ventilation for your home and office. At Primo, we understand the importance of living and working in a healthy and safe environment. We service your AC and remove the dust, dirt, and insects from it, clean filters and grills, and do performance inspections of your AC.<br></p>', '<p>تقدم شركة <b>(شركة منافسة)</b> أفضل خدمات التكييف وبأسعار معقولة تناسب جميع العملاء. قنوات تكييف الهواء مصدراً للهواء النقي والتهوية لمنزلك ومكتبك. نحن في شركة بريمو ندرك أهمية العيش والعمل في بيئة صحية وآمنة. لذلك نعمل على صيانة مكيف الهواء ونزيل الغبار والأوساخ والحشرات من مكيف الهواء الى جانب تنظيف المرشح والشبكات الى جانب فحص عمل مكيفك.<br></p>', 'AC SERVICES', 'صيانة التكييف', '2023-06-18 09:58:10.588415', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('10', 'Images/Services/25cdfead-d3ce-4642-bb34-f59123e742a8.png', '<p>A major part of your house’s aesthetics depends on the quality of painting work done on the walls and ceiling. Dull, withered walls can ruin the look of your home. Moreover, the colors of the walls tend to change fast due to extreme sunlight exposure in Dubai. Home painting and interior painting by yourself may seem fun but is a tedious job. We provide expert painting services in which we give a makeover to your house.</p><p><br></p><p>Other than residential painting services We also provide expert commercial painting services.&nbsp;</p>', '<p>الجزء الأكبر من جمالية منزلك يعتمد على جودة طلاء الجدران والسقف. لأنه يمكن للجدران الباهتة أن تشوه مظهر منزلك. بالاضافة لذلك، تميل ألوان الجدران إلى التغير السريع بسبب التعرض الشديد لأشعة الشمس في دبي. قد يبدو ممتعاً طلاء منزلك بنفسك إلا أنه عمل شاق. تقدم شركة<b> (شركة منافسة)</b> خدمات طلاء متخصصة لتغيير جمالية منزلك.</p><p><br></p><p>نقدم أيضاً خدمات طلاء تجارية متخصصة. يؤدي الطلاء الجيد للمكتب أو السكن الى خلق انطباع أولي إيجابي عند العميل، ويجعل المكان يبدو نظيفاً.</p>', 'PAINTING SERVICES', 'خدمات الطلاء', '2023-06-18 09:59:10.188752', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'Type', 'ValueType', 'valueAr', 'valueEn', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('18', '0', 'CompanyImage', 'Images/Setting/6714430f-7e67-4b73-b03a-64d976e4ca08.png', 'Images/Setting/6714430f-7e67-4b73-b03a-64d976e4ca08.png', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('38', '2', 'AboutUs', '<p>نحن في شركة <b>(شركة منافسة)</b> نقدم جميع الخدمات القياسية والدعم اللازم لتلبية متطلباتك من خلال تزويدك بالحلول الفعالة من حيث التكلفة والاستدامة. ويدعم ذلك عشر سنوات من الخبرة الواسعة الى جانب دعم الفريق الداخلي المكون من الفنيين والمهندسين المؤهلين الذين يركزون على العملاء من خلفيات وثقافات متنوعة. نحن في وضع جيد يسمح لنا بالتوافق بين الخبرة ومتطلبات العميل والحفاظ على التحكم الكامل بجودة الخدمة التي نقدمه.<br></p>', '<p>We are in <b>(Munafasa)</b>, offering both standard and bespoke services and support to match your requirements by providing cost-effective and sustainable solutions. Backed by 10 years of extensive experience and supported by an in-house team of qualified, proactive, customer-focused technicians and engineers from diverse backgrounds and cultures, we are well-positioned to match expertise with client requirements of any complexity and also maintain control of the quality of service we provide.<br></p>', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('39', '2', 'Mission', '<p>تقديم أفضل خدمات التنظيف والصيانة في الدولة من خلال المشاركة العالية للعملاء وتقديم الجهد المطلوب لتنفيذ مهمتنا.<br></p>', '<p>Providing the best cleaning and maintenance services in the country through high customer participation.<br></p>', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('40', '2', 'Vision', '<p>بأن نكون الشريك المفضل في تقديم خدمات التنظيف والصيانة المبتكرة لبناء مدن ومجتمعات مستدامة واعية بيئياً وتركز على النظافة والحياة الصحية.<br></p>', '<p>We want to be the premium choice solution provider for all cleaning and maintenance needs.&nbsp;<br></p>', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('45', '3', 'CompanyPhone', '971502670618', '971502670618', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('46', '3', 'CompanyWhatsApp', '971502670618', '971502670618', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('47', '1', 'CompanyEmail', 'tarekfouda0@gmail.com', 'tarekfouda0@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('48', '2', 'CompanyInfo', '<p>نقدم نحن شركة <b><u>(شركة منافسة)</u> </b>جميع الخدمات الأساسية الى جانب خدمات الدعم لتنفيذ طلباتكم من خلال تزويدكم بالحلول الفعالة من حيث التكلفة والاستدامة. استناداً لخبرتنا الواسعة مع الدعم الكبير من الفريق الداخلي المكون من الفنيين والمهندسين المؤهلين الذين يركزون على العملاء من خلفيات وثقافات متنوعة. نحن في وضع جيد يسمح لنا بممارسة خبرتنا وتنفيذ متطلبات العملاء وكذلك الحفاظ على جودة الخدمة التي نقدمها. بصفتكم أحد عملائنا المميزين، يمكنكم الاستفادة من النهج الاستشاري، والتحكم الكبير، وخفض التكاليف، وتحسين الجودة ومهارات تعدد المهام. شهدت شركة <b><u>(شركة منافسة)</u></b> نمواً كبيراً، حيث أصبحت الشركة اليوم واحدة من الشركات المفضلة للشركات وأصحاب العقارات الأفراد الذين يرغبون بالاستعانة بمصادر خارجية لأعمال تنظيف وصيانة المباني إلى الشركاء الموثوقين.<br></p>', '<p>We are in <b><u>(MUNAFASA)</u></b> offering both standard and bespoke services and support to match your requirements by providing you with cost-effective and sustainable solutions. We have extensive experience and are supported by an in-house team of qualified, proactive, customer-focused technicians and engineers from diverse backgrounds and cultures, we are well-positioned to match expertise with client requirements of any complexity and also maintain control of the quality of service we provide. As our client, you can benefit from a consultative approach, greater control, reduced costs, improved quality, and multi-tasking skills. Primo has witnessed exponential growth and is today the company of choice for businesses and individual property owners who wish to outsource their building cleaning and maintenance work to a reliable and responsible partner.<br></p>', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'NameEn', 'NameAr', 'Email', 'Phone', 'ProfileImage', 'JoinDate', 'Salary', 'PassportImage', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('Id', 'ServiceId', 'TechnicianId', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('MigrationId', 'ProductVersion', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230615080510_init', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230615121604_servContracts', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230615125348_requests', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230616073043_appUser', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230616073716_appUserCreatedAt', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230616080223_appUserDb', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230616080551_appUserName', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230616091541_ReduiredName', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230616152452_ServiceDate', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230616190657_ServiceDateValidate', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230617112501_Morals', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230617113619_MoralsEdit', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230617120318_Contact', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
('20230617192036_Settings', '7.0.7', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `owners`
--

CREATE TABLE `owners` (
  `Id` int NOT NULL,
  `NameEn` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `NameAr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Phone` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProfileImage` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Password` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `requestimages`
--

CREATE TABLE `requestimages` (
  `Id` int NOT NULL,
  `Url` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `RequestId` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `requests`
--

CREATE TABLE `requests` (
  `Id` int NOT NULL,
  `ContractId` int NOT NULL,
  `ServiceId` int NOT NULL,
  `ClientId` int NOT NULL,
  `VisitDate` datetime(6) NOT NULL,
  `Desc` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `OwnerNote` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `TecnicianNote` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `AdditionalPrice` double NOT NULL,
  `Status` int NOT NULL,
  `Rate` int NOT NULL,
  `TechnicianId` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `Id` int NOT NULL,
  `ImageUrl` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DesEn` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DesAr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `NameEn` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `NameAr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedAt` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`Id`, `ImageUrl`, `DesEn`, `DesAr`, `NameEn`, `NameAr`, `CreatedAt`) VALUES
(2, 'Images/Services/f3a7be80-b465-45a4-8bd6-bbde96a100de.png', '<div>We in <b>(Munafasa)</b> have highly skilled carpenters for carpentry services that can fulfill any of your requirements. From fixing wooden furniture to door handles, we believe in providing expert carpentry solutions at reasonable and competitive prices that allow excellent results.</div><div>Maintaining one’s furniture is important, it could be to save any potential expenses by replacing old furniture with a new one or even to preserve a precious heirloom. We provide skilled carpenters for repairing and/or maintaining your home and/or office furniture.</div>', 'يعمل لدى شركة <b>(شركة منافسة)</b> نجارون من ذوي المهارات العالية لتقديم خدمات النجارة  وتلبية جميع متطلبات العملاء. بداية من أعمال تركيب الأثاث الخشبي إلى مقبض الباب، نؤمن بتوفير حلول النجارة المتخصصة التي تسمح بتقديم نتائج ممتازة وبأسعار معقولة ومنافسة.\r\n\r\nصيانة الأثاث من الأمور الهامة لأن ذلك يساهم في توفير أي نفقات محتملة من خلال استبدال الأثاث القديم بآثاث جديد أو الحفاظ على هذا الإرث الثمين. نقدم نحن في الشركة النجارين من ذوي المهارات والخبرة الضرورية لإصلاح و صيانة أثاث منزلك و مكتبك.\r\n\r\nيجوز لمقدمي خدمات النجارة المدربين إجراء معاينة بسيطة الى المناطق السكنية أو التجارية الخاصة بك. يملك موظفينا المدربين تدريباً عالياً القدرة على التعامل مع جمالية وتصميم الأثاث.', 'CARPENTRY SERVICES', 'خدمات أعمال النجارة', '2023-06-18 03:32:19.578492'),
(3, 'Images/Services/492b5d51-e73c-4908-b6ce-5b4ba6037275.webp', 'Epoxy ­flooring is a type of fl­ooring that is made from a two-part epoxy resin system. Epoxy resin is a type of thermosetting polymer that is formed by mixing two components – a resin and a hardener. When these two components are mixed together, they undergo a chemical reaction that results in a hard, durable, and resistant surface. Epoxy ­flooring is popular in commercial and industrial settings because it is highly durable and resistant to damage from heavy foot traffic, chemicals, and abrasion. It is also easy to clean and maintain, making it a good choice for facilities that require a high level of cleanliness.&nbsp;', '<div>عد أرضيات الإيبوكسي من أفضل اختيارات الأرضيات بين الأشخاص. ويرجع ذلك بصفة أساسية لتنوعها ومتانتها. يختار العملاء&nbsp; خدمات أرضيات الإيبوكسي بسبب قوتها ومقاومتها وسهولة تنظيفها وصيانتها وقيمتها المالية.</div><div><br></div><div>يرجع نجاحنا إلى اهتمامنا بالتفاصيل في كل خطوة من عملية التنفيذ ونضع اهتماما خاصا في مرحلة تجهيز الأرضية وإعداد التركيبة وكذلك خلال عملية التطبيق.</div><div><br></div><div>&nbsp;هناك العديد من العوامل التي يتعين أن تضعها شركتنا في الاعتبار&nbsp; لتحقيق أفضل نتائج أرضيات الإيبوكسي لعملائها.</div><div><br></div><div>في مرحلة التجهيز، يتعين أن تتأكد شركتنا من أن تكون الأرضية ملساء ومسامية بما يتيح للإيبوكسي الالتصاق بها. وذلك يعني عدم وجود أي شقوق أو دهون أو سوائل أخرى على الأرضية ويعني أيضا أنه يتعين فحص وجود أي مانع تسريب موضوع مسبقاً بالأرضية حيث أن الأرضية التي بها مانع تسريب تكون غير مناسبة لوضع أرضيات الإيبوكسي.</div><div><br></div><div>بمجرد الانتهاء من مرحلة تجهيز الأرضية ننتقل لمرحلة التطبيق، حيث تنفذ عملية التطبيق بواسطة&nbsp; أفرادنا المتخصصين بسرعة وفي درجات الحرارة المتحكم بها ومن ثم لا تتكون أي فقاعات.</div>', 'EPOXY FLOORING', 'خدمات الأيبوكسي', '2023-06-18 10:01:22.477645'),
(4, 'Images/Services/5ca76f85-df7f-4be8-ab39-c55d19ac399e.png', '<div>Plumbing issues can arise from any system that carries water and is not working as intended. It can range from hot and cold water issues to overflowing water tanks. General issues of plumbing may come from the pipes, faucets, valves, fixtures and fittings, showers, taps, tanks, water pumps, and other systems that carry water.</div><div><br></div><div>We provide high-quality best plumbing services. Our teams of trained technicians are well versed in the field of plumbing and can handle any plumbing issues either from residential or commercial properties.</div>', '<div>يمكن لمشاكل السباكة أن تنشأ من أي نظام ينقل الماء ولا يعمل على النحو المطلوب. وتشمل هذه المشاكل المياه الساخنة والباردة وخزانات المياه الفائضة. ويمكن للمشاكل العامة المتعلقة بالسباكة أن تنشأ من الأنابيب والحنفيات والصمامات والتركيبات والتجهيزات وحوض الاستحمام والصنابير والخزانات ومضخات المياه والأنظمة الأخرى التي تنقل المياه.</div><div><br></div><div>تقدم شركتنا أفضل خدمات السباكة عالية الجودة. نملك فرق من الفنيين المدربين في مجال أعمال السباكة والقادرين على التعامل مع أي مشاكل في السباكة سواء في الوحدات السكنية أو التجارية.&nbsp;</div>', 'PLUMBING SERVICES', 'خدمات السباكة', '2023-06-18 09:51:30.973416'),
(5, 'Images/Services/6bdd5944-c311-4ae0-a1b6-cd6c8795b729.png', 'Electrical issues can come up at any time or anywhere. There can be a range of issues such as a light bulb needing replacement also needing to fix a burnt-out circuit board. No matter what the issue, they need to be handled with care and by trained professionals. We provide the best electrical service in Dubai at the most affordable rates. we have skilled technicians specially trained to handle any electrical-related issue. This can be in residential or commercial properties. Our technicians are also well versed in the installation and testing of electrical-related work, all of which are handled with care and high-quality work.', 'يمكن للمشاكل الكهربائية أن تحدث في أي وقت أو في أي مكان. ويمكن حدوث مجموعة من المشاكل مثل المصباح الكهربائي الذي يجب استبداله عند الحاجة وإصلاح لوحة دائرة كهربائية محترقة. فبغض النظر عن نوع المشكلة، يجب التعامل معها بعناية ومن قبل موظفين محترفين ومدربين. تقدم شركة (شركة منافسة) أفضل الخدمات الكهربائية وبأسعار معقولة تناسب الجميع. كما أننا نملك الفنيين ذوي الخبرة والمدربين بشكل خاص للتعامل مع أي مشكلة متعلقة بالكهرباء. يمكن أن يتم ذلك في العقارات السكنية أو التجارية. كما يملك الفنيين في الشركة خبرة كبيرة في تركيب واختبار الأعمال المتعلقة بالكهرباء والتي يتم التعامل معها بعناية وجودة عالية.', 'Electricity services', 'الخدمات الكهربائية', '2023-06-18 09:52:23.056378'),
(6, 'Images/Services/994d4351-5aa9-4ca8-bcee-d12eea276b5c.png', '<div>Residential buildings need to be repaired when they are exposed to what affects them, such as cracks and cracks, and other signs that can lead to the collapse of the building. The most common building defects are:</div><div><br></div><div>Disadvantages related to consumption:</div><div>Many people make some mistakes that violate the standard specifications of the building, such as widening the opening for windows, making a hole in one of the walls of the building to install air conditioners, or renewing the sewage pipes installed inside the walls.</div><div><br></div><div>Security defects:</div><div>These defects appear as a result of neglecting surface cracks and cracks, or water leaks in the building\'s sewage pipes, which increases the humidity level. It can also appear when building a number of floors in violation, and this leads to exceeding the load ratio allocated to the building.</div>', '<div>تحتاج المبانى السكنية إلى الترميم عند تعرضها لما يؤثر عليها كالشروخ والتشققات، وغيرها من العلامات التي يمكن أن تؤدي إلى سقوط المبنى، وتتمثل أكثر عيوب المباني الشائعة في:</div><div><br></div><div>عيوب متعلقة بالإستهلاك:&nbsp;</div><div>يرتكب العديد من الأشخاص بعض الأخطاء التي تخالف المواصفات القياسية للمبنى، مثل توسعة الفتحة المخصصة للنوافذ، أو إحداث فتحة في أحد حوائط المبنى لتركيب التكييفات، أو تجديد أنابيب الصرف الصحي المركبة داخل الجدران.</div><div><br></div><div>عيوب متعلقة بعوامل الأمان:&nbsp;</div><div>تَظهر هذه العيوب نتيجة إهمال الشروخ والتشققات السطحية، أو تسريبات المياه في أنابيب الصرف الصحي للمبنى مما يزيد من نسبة الرطوبة؛ كما يمكن أن تظهر أيضاً عند بناء عدد من الطوابق بشكل مخالف، وهذا يؤدِي إلى تتخطى نسبة التحميل المخصصة للمبنى.</div>', 'Building restorations', 'تريميمات المباني', '2023-06-18 09:53:35.686143'),
(7, 'Images/Services/7b83aded-7b47-489f-bf4e-4f43c1f6030e.png', '<p>Any residential or commercial building or property requires constant maintenance to maintain quality living standards. Any residential or commercial building or property requires constant maintenance to maintain quality living standards. If these maintenance and renovation needs are not managed well they might lead to much worse incidents like fire hazards, pest effects, bad air conditions and even building collapses.</p><p>We have a highly experienced team for annual maintenance contract services in Dubai. We are a premium maintenance company offering a wide range of services for your commercial and residential property. We provide the most responsive service. We maintain your home 24×7 in our annual maintenance package.</p><p>We provide essential services like regular AC Servicing, Plumbing, Electrical services, masonry work, Handyman services, AC Duct Cleaning, Carpentry, Water tank cleaning, Furniture cleaning, Deep cleaning service, Exterior cleaning, etc. As per customer requirements, we provide the most suitable Customized AMC packages.&nbsp;</p>', '<p>يوفر عقد الصيانة السنوي هدوء النفس وراحة البال للمالك. حيث يلبي عقد الصيانة السنوي متطلبات الصيانة اليومية الخاصة بك. كما يمكن لعقد الصيانة السنوي أن يضم حتى الأعمال اليدوية الصغيرة لأعمال التجديد الكبيرة. ويمكنك الاطمئان بأن عقد الصيانة السنوي يهتم بجميع أنواع العمل نيابة عنك.</p><p>نحن في شركة (شركة منافسة) نملك فريق من ذوي الخبرة العالية لتقديم خدمات عقود الصيانة السنوية في دبي. كما أننا شركة صيانة متميزة في تقديم مجموعة واسعة من الخدمات للعقارات التجارية والسكنية. ونقدم الخدمة الأكثر استجابة. نعمل على صيانة منزلك على مدار الساعة وطوال أيام الأسبوع ضمن مجموعة من خدمات الصيانة السنوية.</p><p>ينص عقد الصيانة السنوي على إجراء فحوصات صيانة بانتظام للأعمال الصحية والكهرباء وخدمات المكيف والنجارة. وبالتالي تحديد الأعطال الصغيرة لمنع القيام بالإصلاحات أو الأضرار الكبيرة. نعمل بصفة مستشار لعملاء عقود الصيانة السنوية الخاصة بنا، ونخطرهم بالمشاكل التي يواجهوها في منازلهم أو مكاتبهم، ونساعدهم على حلها بكفاءة عالية وفعالية من حيث التكلفة.</p><p>نقدم الخدمات الأساسية مثل خدمة المكيف العادية، والخدمات الصحية، والكهرباء، والخدمات الحرفية، وتنظيف قنوات الهواء، وأعمال النجارة، وتنظيف خزان المياه، وتنظيف الأثاث والمفروشات، وخدمة التنظيف العميق والتنظيف الخارجي إلخ.</p>', 'ANNUAL MAINTENANCE CONTRACT', 'عقد الصيانة السنوي', '2023-06-18 10:10:01.618735'),
(8, 'Images/Services/4ae3927e-89e6-4b88-8981-184520848ff2.png', '<p>We <b style=\"color: rgb(189, 148, 0);\">(Munafasa)</b> are one of the best cleaning services providers with a 100% guarantee. As a professional cleaning company in Dubai, Primo has centered its entire operations on delivering high-quality cleaning services for both residential and commercial purposes. Except for general cleaning services we provide deep cleaning services, sofa cleaning services, carpet cleaning services, sanitization services, and marble polishing services.&nbsp;</p><p><br></p><p>Due to the evolving nature of the cleaning industry, we pride ourselves on being at the forefront of the cleaning industry by continuously training our staff and using the most up-to-date machinery and technology.&nbsp;</p>', '<p>تعتبر شركة <b>(شركة منافسة)</b> من أفضل مزودي خدمات التنظيف مع ضمان 100٪. نحن متخصصون بتنظيف جميع الأماكن السكنية والتجارية وإزالة جميع الأتربة لكي تبدو وكأنها جديدة.</p><p><br></p><p>بصفتنا أفضل شركة تقدم خدمات تنظيف احترافية، فقد ركزت شركة (شركة منافسة) كامل أعمالها على تقديم خدمات تنظيف عالية الجودة للأغراض السكنية والتجارية. لا يوجد بالنسبة لنا مشروع كبير جداً أو صغير جداً أو سهل جداً أو صعب جداً لنقوم بتنفيذه. يضمن الفريق المتخصص من الموظفين المدربين على مستوى عال في شركة بريمو الحفاظ على المناطق الداخلية والخارجية لأي منطقة تجارية أو صناعية ضمن مستوى عالي من النظافة المثالية.</p><p><br></p><p>بناء على الطبيعة المتطورة في صناعة التنظيف، نفخر بأنفسنا بأننا في طليعة صناعة التنظيف من خلال التدريب المستمر لموظفينا واستخدام أحدث الآلات والتكنولوجيا.</p>', 'BEST CLEANING COMPANY', 'خدمات التنظيف', '2023-06-18 04:03:58.196485'),
(9, 'Images/Services/8cf10085-41a6-4182-9cf5-d4a1805aa6f3.jpg', '<p>We<b> <span style=\"color: rgb(189, 148, 0);\">(Munafasa)</span></b> provide the best AC services in Dubai at the most affordable rates. Your AC duct is a source of fresh air and ventilation for your home and office. At Primo, we understand the importance of living and working in a healthy and safe environment. We service your AC and remove the dust, dirt, and insects from it, clean filters and grills, and do performance inspections of your AC.<br></p>', '<p>تقدم شركة <b>(شركة منافسة)</b> أفضل خدمات التكييف وبأسعار معقولة تناسب جميع العملاء. قنوات تكييف الهواء مصدراً للهواء النقي والتهوية لمنزلك ومكتبك. نحن في شركة بريمو ندرك أهمية العيش والعمل في بيئة صحية وآمنة. لذلك نعمل على صيانة مكيف الهواء ونزيل الغبار والأوساخ والحشرات من مكيف الهواء الى جانب تنظيف المرشح والشبكات الى جانب فحص عمل مكيفك.<br></p>', 'AC SERVICES', 'صيانة التكييف', '2023-06-18 04:03:45.850112'),
(10, 'Images/Services/25cdfead-d3ce-4642-bb34-f59123e742a8.png', '<p>A major part of your house’s aesthetics depends on the quality of painting work done on the walls and ceiling. Dull, withered walls can ruin the look of your home. Moreover, the colors of the walls tend to change fast due to extreme sunlight exposure in Dubai. Home painting and interior painting by yourself may seem fun but is a tedious job. We provide expert painting services in which we give a makeover to your house.</p><p><br></p><p>Other than residential painting services We also provide expert commercial painting services.&nbsp;</p>', '<p>الجزء الأكبر من جمالية منزلك يعتمد على جودة طلاء الجدران والسقف. لأنه يمكن للجدران الباهتة أن تشوه مظهر منزلك. بالاضافة لذلك، تميل ألوان الجدران إلى التغير السريع بسبب التعرض الشديد لأشعة الشمس في دبي. قد يبدو ممتعاً طلاء منزلك بنفسك إلا أنه عمل شاق. تقدم شركة<b style=\"color: rgb(189, 148, 0);\"> (شركة منافسة)</b> خدمات طلاء متخصصة لتغيير جمالية منزلك.</p><p><br></p><p>نقدم أيضاً خدمات طلاء تجارية متخصصة. يؤدي الطلاء الجيد للمكتب أو السكن الى خلق انطباع أولي إيجابي عند العميل، ويجعل المكان يبدو نظيفاً.</p>', 'PAINTING SERVICES', 'خدمات الطلاء', '2023-06-18 04:03:33.668468');

-- --------------------------------------------------------

--
-- Table structure for table `settings`
--

CREATE TABLE `settings` (
  `Id` int NOT NULL,
  `Type` int NOT NULL,
  `ValueType` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `valueAr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `valueEn` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `settings`
--

INSERT INTO `settings` (`Id`, `Type`, `ValueType`, `valueAr`, `valueEn`) VALUES
(18, 0, 'CompanyImage', 'Images/Setting/6714430f-7e67-4b73-b03a-64d976e4ca08.png', 'Images/Setting/6714430f-7e67-4b73-b03a-64d976e4ca08.png'),
(39, 2, 'Mission', '<p>تقديم أفضل خدمات التنظيف والصيانة في الدولة من خلال المشاركة العالية للعملاء وتقديم الجهد المطلوب لتنفيذ مهمتنا.<br></p>', '<p>Providing the best cleaning and maintenance services in the country through high customer participation.<br></p>'),
(40, 2, 'Vision', '<p>بأن نكون الشريك المفضل في تقديم خدمات التنظيف والصيانة المبتكرة لبناء مدن ومجتمعات مستدامة واعية بيئياً وتركز على النظافة والحياة الصحية.<br></p>', '<p>We want to be the premium choice solution provider for all cleaning and maintenance needs.&nbsp;<br></p>'),
(61, 3, 'CompanyPhone', '971502670618', '971502670618'),
(62, 3, 'CompanyWhatsApp', '971502670618', '971502670618'),
(63, 1, 'CompanyEmail', 'tarekfouda0@gmail.com', 'tarekfouda0@gmail.com'),
(64, 2, 'CompanyInfo', '<p>نقدم نحن شركة<span style=\"color: rgb(0, 0, 0);\"> </span><b style=\"color: rgb(189, 148, 0);\"><u style=\"\">(شركة منافسة)</u> </b>جميع الخدمات الأساسية الى جانب خدمات الدعم لتنفيذ طلباتكم من خلال تزويدكم بالحلول الفعالة من حيث التكلفة والاستدامة. استناداً لخبرتنا الواسعة مع الدعم الكبير من الفريق الداخلي المكون من الفنيين والمهندسين المؤهلين الذين يركزون على العملاء من خلفيات وثقافات متنوعة. نحن في وضع جيد يسمح لنا بممارسة خبرتنا وتنفيذ متطلبات العملاء وكذلك الحفاظ على جودة الخدمة التي نقدمها. بصفتكم أحد عملائنا المميزين، يمكنكم الاستفادة من النهج الاستشاري، والتحكم الكبير، وخفض التكاليف، وتحسين الجودة ومهارات تعدد المهام. شهدت شركة <b><u style=\"color: rgb(189, 148, 0);\">(شركة منافسة)</u></b> نمواً كبيراً، حيث أصبحت الشركة اليوم واحدة من الشركات المفضلة للشركات وأصحاب العقارات الأفراد الذين يرغبون بالاستعانة بمصادر خارجية لأعمال تنظيف وصيانة المباني إلى الشركاء الموثوقين.<br></p>', '<p>We are in <b><u style=\"color: rgb(189, 148, 0);\">(MUNAFASA)</u></b> offering both standard and bespoke services and support to match your requirements by providing you with cost-effective and sustainable solutions. We have extensive experience and are supported by an in-house team of qualified, proactive, customer-focused technicians and engineers from diverse backgrounds and cultures, we are well-positioned to match expertise with client requirements of any complexity and also maintain control of the quality of service we provide. As our client, you can benefit from a consultative approach, greater control, reduced costs, improved quality, and multi-tasking skills. Primo has witnessed exponential growth and is today the company of choice for businesses and individual property owners who wish to outsource their building cleaning and maintenance work to a reliable and responsible partner.<br></p>'),
(65, 2, 'AboutUs', '<p>نحن في شركة <b style=\"color: rgb(189, 148, 0);\">(شركة منافسة)</b> نقدم جميع الخدمات القياسية والدعم اللازم لتلبية متطلباتك من خلال تزويدك بالحلول الفعالة من حيث التكلفة والاستدامة. ويدعم ذلك عشر سنوات من الخبرة الواسعة الى جانب دعم الفريق الداخلي المكون من الفنيين والمهندسين المؤهلين الذين يركزون على العملاء من خلفيات وثقافات متنوعة. نحن في وضع جيد يسمح لنا بالتوافق بين الخبرة ومتطلبات العميل والحفاظ على التحكم الكامل بجودة الخدمة التي نقدمه.<br></p>', '<p>We are in <b style=\"color: rgb(189, 148, 0);\">(Munafasa)</b>, offering both standard and bespoke services and support to match your requirements by providing cost-effective and sustainable solutions. Backed by 10 years of extensive experience and supported by an in-house team of qualified, proactive, customer-focused technicians and engineers from diverse backgrounds and cultures, we are well-positioned to match expertise with client requirements of any complexity and also maintain control of the quality of service we provide.<br></p>');

-- --------------------------------------------------------

--
-- Table structure for table `technicians`
--

CREATE TABLE `technicians` (
  `Id` int NOT NULL,
  `NameEn` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `NameAr` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Phone` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProfileImage` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `JoinDate` datetime(6) NOT NULL,
  `Salary` double NOT NULL,
  `PassportImage` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `technicianservice`
--

CREATE TABLE `technicianservice` (
  `Id` int NOT NULL,
  `ServiceId` int NOT NULL,
  `TechnicianId` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20230615080510_init', '7.0.7'),
('20230615121604_servContracts', '7.0.7'),
('20230615125348_requests', '7.0.7'),
('20230616073043_appUser', '7.0.7'),
('20230616073716_appUserCreatedAt', '7.0.7'),
('20230616080223_appUserDb', '7.0.7'),
('20230616080551_appUserName', '7.0.7'),
('20230616091541_ReduiredName', '7.0.7'),
('20230616152452_ServiceDate', '7.0.7'),
('20230616190657_ServiceDateValidate', '7.0.7'),
('20230617112501_Morals', '7.0.7'),
('20230617113619_MoralsEdit', '7.0.7'),
('20230617120318_Contact', '7.0.7'),
('20230617192036_Settings', '7.0.7'),
('20230618092417_init', '7.0.7');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indexes for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indexes for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indexes for table `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indexes for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indexes for table `cheques`
--
ALTER TABLE `cheques`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Cheques_ContractId` (`ContractId`);

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Clients_ContractId` (`ContractId`);

--
-- Indexes for table `contacts`
--
ALTER TABLE `contacts`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `contractattacments`
--
ALTER TABLE `contractattacments`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_ContractAttacments_ContrctId` (`ContrctId`);

--
-- Indexes for table `contracts`
--
ALTER TABLE `contracts`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Contracts_OwnerId` (`OwnerId`);

--
-- Indexes for table `contractservices`
--
ALTER TABLE `contractservices`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_ContractServices_ContractId` (`ContractId`),
  ADD KEY `IX_ContractServices_ServiceId` (`ServiceId`);

--
-- Indexes for table `morals`
--
ALTER TABLE `morals`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `owners`
--
ALTER TABLE `owners`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `requestimages`
--
ALTER TABLE `requestimages`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RequestImages_RequestId` (`RequestId`);

--
-- Indexes for table `requests`
--
ALTER TABLE `requests`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Requests_ClientId` (`ClientId`),
  ADD KEY `IX_Requests_ContractId` (`ContractId`),
  ADD KEY `IX_Requests_ServiceId` (`ServiceId`),
  ADD KEY `IX_Requests_TechnicianId` (`TechnicianId`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `settings`
--
ALTER TABLE `settings`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `technicians`
--
ALTER TABLE `technicians`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `technicianservice`
--
ALTER TABLE `technicianservice`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_TechnicianService_ServiceId` (`ServiceId`),
  ADD KEY `IX_TechnicianService_TechnicianId` (`TechnicianId`);

--
-- Indexes for table `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cheques`
--
ALTER TABLE `cheques`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `clients`
--
ALTER TABLE `clients`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `contacts`
--
ALTER TABLE `contacts`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `contractattacments`
--
ALTER TABLE `contractattacments`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `contracts`
--
ALTER TABLE `contracts`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `contractservices`
--
ALTER TABLE `contractservices`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `morals`
--
ALTER TABLE `morals`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `owners`
--
ALTER TABLE `owners`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `requestimages`
--
ALTER TABLE `requestimages`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `requests`
--
ALTER TABLE `requests`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `settings`
--
ALTER TABLE `settings`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT for table `technicians`
--
ALTER TABLE `technicians`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `technicianservice`
--
ALTER TABLE `technicianservice`
  MODIFY `Id` int NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `cheques`
--
ALTER TABLE `cheques`
  ADD CONSTRAINT `FK_Cheques_Contracts_ContractId` FOREIGN KEY (`ContractId`) REFERENCES `contracts` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `clients`
--
ALTER TABLE `clients`
  ADD CONSTRAINT `FK_Clients_Contracts_ContractId` FOREIGN KEY (`ContractId`) REFERENCES `contracts` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `contractattacments`
--
ALTER TABLE `contractattacments`
  ADD CONSTRAINT `FK_ContractAttacments_Contracts_ContrctId` FOREIGN KEY (`ContrctId`) REFERENCES `contracts` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `contracts`
--
ALTER TABLE `contracts`
  ADD CONSTRAINT `FK_Contracts_Owners_OwnerId` FOREIGN KEY (`OwnerId`) REFERENCES `owners` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `contractservices`
--
ALTER TABLE `contractservices`
  ADD CONSTRAINT `FK_ContractServices_Contracts_ContractId` FOREIGN KEY (`ContractId`) REFERENCES `contracts` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_ContractServices_Services_ServiceId` FOREIGN KEY (`ServiceId`) REFERENCES `services` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `requestimages`
--
ALTER TABLE `requestimages`
  ADD CONSTRAINT `FK_RequestImages_Requests_RequestId` FOREIGN KEY (`RequestId`) REFERENCES `requests` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `requests`
--
ALTER TABLE `requests`
  ADD CONSTRAINT `FK_Requests_Clients_ClientId` FOREIGN KEY (`ClientId`) REFERENCES `clients` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Requests_Contracts_ContractId` FOREIGN KEY (`ContractId`) REFERENCES `contracts` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Requests_Services_ServiceId` FOREIGN KEY (`ServiceId`) REFERENCES `services` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Requests_Technicians_TechnicianId` FOREIGN KEY (`TechnicianId`) REFERENCES `technicians` (`Id`) ON DELETE CASCADE;

--
-- Constraints for table `technicianservice`
--
ALTER TABLE `technicianservice`
  ADD CONSTRAINT `FK_TechnicianService_Services_ServiceId` FOREIGN KEY (`ServiceId`) REFERENCES `services` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_TechnicianService_Technicians_TechnicianId` FOREIGN KEY (`TechnicianId`) REFERENCES `technicians` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
