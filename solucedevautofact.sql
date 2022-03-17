-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 17 mars 2022 à 10:50
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `solucedevautofact`
--

-- --------------------------------------------------------

--
-- Structure de la table `clients`
--

DROP TABLE IF EXISTS `clients`;
CREATE TABLE IF NOT EXISTS `clients` (
  `IDCLIENT` int(2) NOT NULL AUTO_INCREMENT,
  `NOM` char(32) NOT NULL,
  `PRENOM` char(32) NOT NULL,
  `ADRESSE` char(32) NOT NULL,
  PRIMARY KEY (`IDCLIENT`)
) ENGINE=MyISAM AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `clients`
--

INSERT INTO `clients` (`IDCLIENT`, `NOM`, `PRENOM`, `ADRESSE`) VALUES
(11, 'harfouche', 'gabriel', 'Chartres'),
(24, 'rgtb', 'rggb', 'frgb'),
(23, 'zegbbgbgr', 'ezrbgf', 'efdgb'),
(28, 'aze', 'azer', 'zer'),
(21, 'Azer', 'Ty', 'aouhezbuc'),
(20, 'test', 'test', 'test');

-- --------------------------------------------------------

--
-- Structure de la table `conserve`
--

DROP TABLE IF EXISTS `conserve`;
CREATE TABLE IF NOT EXISTS `conserve` (
  `IDDOCUMENT` int(2) NOT NULL,
  `IDPRESTATION` int(2) NOT NULL,
  `QUANTITÉ` int(2) NOT NULL,
  PRIMARY KEY (`IDDOCUMENT`,`IDPRESTATION`),
  KEY `I_FK_CONSERVE_DOCUMENT` (`IDDOCUMENT`),
  KEY `I_FK_CONSERVE_PRESTATION` (`IDPRESTATION`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `conserve`
--

INSERT INTO `conserve` (`IDDOCUMENT`, `IDPRESTATION`, `QUANTITÉ`) VALUES
(1, 1, 4),
(4, 1, 11),
(4, 2, 11),
(22, 1, 20),
(22, 2, 20),
(23, 1, 20),
(23, 2, 20),
(24, 1, 20),
(24, 2, 20),
(25, 1, 20),
(25, 2, 20),
(26, 1, 20),
(26, 2, 20),
(27, 1, 20),
(27, 2, 20),
(28, 1, 20),
(29, 2, 20),
(30, 1, 20),
(30, 2, 20),
(31, 1, 1),
(31, 2, 2),
(32, 1, 3),
(32, 2, 6),
(33, 1, 2),
(33, 2, 2),
(34, 1, 2),
(34, 2, 2),
(35, 1, 2),
(35, 2, 2),
(36, 1, 1),
(36, 2, 1),
(37, 1, 1),
(37, 2, 2),
(38, 1, 2),
(38, 2, 2),
(39, 1, 1),
(39, 2, 0),
(41, 1, 1),
(41, 2, 1),
(42, 1, 1),
(42, 2, 1),
(43, 1, 1),
(43, 2, 1),
(44, 1, 1),
(44, 2, 1),
(45, 1, 1),
(45, 2, 1),
(46, 1, 1),
(46, 2, 2),
(47, 1, 1),
(47, 2, 0),
(50, 1, 1),
(50, 2, 1),
(51, 1, 3),
(51, 2, 3),
(52, 1, 1),
(52, 2, 2),
(53, 1, 1),
(53, 2, 1),
(54, 1, 1),
(54, 2, 1),
(55, 1, 2),
(55, 2, 1),
(56, 1, 1),
(56, 2, 1),
(57, 1, 1),
(57, 2, 1),
(58, 1, 1),
(58, 2, 2),
(60, 1, 2),
(60, 2, 1),
(61, 1, 2),
(61, 2, 1),
(63, 1, 1),
(63, 2, 1),
(64, 1, 1),
(64, 2, 2),
(65, 1, 1),
(66, 1, 1),
(67, 1, 1),
(67, 2, 0),
(68, 1, 1),
(69, 1, 0),
(69, 2, 1),
(70, 1, 1),
(70, 2, 1),
(71, 1, 1),
(71, 2, 2),
(72, 1, 1),
(73, 1, 1),
(74, 1, 1),
(75, 1, 2),
(75, 2, 2),
(76, 1, 1),
(77, 1, 1),
(78, 1, 1),
(79, 1, 1),
(80, 1, 1),
(94, 1, 1),
(95, 1, 1),
(95, 2, 1),
(96, 1, 1),
(96, 2, 1),
(97, 1, 7),
(97, 2, 3),
(98, 1, 1),
(98, 2, 1),
(99, 1, 1),
(99, 2, 1),
(100, 1, 1),
(100, 2, 2),
(101, 1, 1),
(101, 2, 1),
(102, 1, 1),
(102, 2, 1),
(103, 1, 1),
(103, 2, 1),
(104, 1, 1),
(104, 2, 1),
(105, 1, 1),
(105, 2, 1),
(106, 1, 1),
(106, 2, 1),
(107, 1, 1),
(107, 2, 1),
(108, 1, 1),
(108, 2, 1),
(109, 1, 1),
(109, 2, 1),
(110, 1, 1),
(110, 2, 1),
(111, 1, 1),
(111, 2, 4),
(112, 1, 1),
(112, 2, 2),
(113, 1, 1),
(113, 2, 1),
(114, 1, 1),
(115, 1, 2),
(116, 1, 1),
(117, 1, 1),
(118, 1, 2);

-- --------------------------------------------------------

--
-- Structure de la table `devenir`
--

DROP TABLE IF EXISTS `devenir`;
CREATE TABLE IF NOT EXISTS `devenir` (
  `IDDOCUMENT` int(2) NOT NULL,
  `IDTYPE` int(2) NOT NULL,
  `DATEDOC` date NOT NULL,
  PRIMARY KEY (`IDDOCUMENT`,`IDTYPE`),
  KEY `I_FK_DEVENIR_DOCUMENT` (`IDDOCUMENT`),
  KEY `I_FK_DEVENIR_TYPE` (`IDTYPE`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `devenir`
--

INSERT INTO `devenir` (`IDDOCUMENT`, `IDTYPE`, `DATEDOC`) VALUES
(1, 1, '2021-12-09'),
(21, 1, '2022-01-17'),
(22, 1, '2022-01-17'),
(23, 1, '2022-01-17'),
(24, 1, '2022-01-17'),
(25, 1, '2022-01-17'),
(26, 1, '2022-02-09'),
(27, 1, '2022-02-09'),
(28, 1, '2022-02-09'),
(29, 1, '2022-02-09'),
(30, 1, '2022-02-09'),
(31, 1, '2022-02-09'),
(32, 1, '2022-02-09'),
(33, 1, '2022-02-09'),
(34, 1, '2022-02-09'),
(35, 1, '2022-02-09'),
(36, 3, '2022-02-09'),
(37, 1, '2022-03-07'),
(38, 1, '2022-03-07'),
(39, 1, '2022-03-10'),
(40, 1, '2022-03-10'),
(41, 1, '2022-03-10'),
(42, 1, '2022-03-10'),
(43, 1, '2022-03-10'),
(44, 1, '2022-03-10'),
(45, 1, '2022-03-10'),
(46, 1, '2022-03-10'),
(47, 1, '2022-03-10'),
(48, 1, '2022-03-10'),
(49, 1, '2022-03-10'),
(50, 1, '2022-03-10'),
(51, 1, '2022-03-10'),
(52, 1, '2022-03-10'),
(53, 1, '2022-03-10'),
(54, 2, '2022-03-10'),
(55, 1, '2022-03-10'),
(56, 1, '2022-03-10'),
(57, 2, '2022-03-10'),
(58, 2, '2022-03-10'),
(59, 2, '2022-03-10'),
(60, 2, '2022-03-10'),
(61, 2, '2022-03-10'),
(62, 1, '2022-03-10'),
(63, 1, '2022-03-10'),
(64, 1, '2022-03-13'),
(65, 2, '2022-03-14'),
(66, 1, '2022-03-14'),
(67, 1, '2022-03-14'),
(68, 1, '2022-03-14'),
(69, 1, '2022-03-14'),
(70, 1, '2022-03-14'),
(71, 1, '2022-03-14'),
(72, 1, '2022-03-14'),
(73, 1, '2022-03-14'),
(74, 1, '2022-03-14'),
(75, 1, '2022-03-14'),
(76, 1, '2022-03-14'),
(77, 1, '2022-03-14'),
(78, 1, '2022-03-14'),
(79, 1, '2022-03-14'),
(80, 1, '2022-03-14'),
(81, 2, '2022-03-14'),
(82, 2, '2022-03-14'),
(83, 2, '2022-03-14'),
(84, 2, '2022-03-14'),
(85, 2, '2022-03-14'),
(86, 2, '2022-03-14'),
(87, 2, '2022-03-14'),
(88, 2, '2022-03-14'),
(89, 2, '2022-03-14'),
(90, 2, '2022-03-14'),
(91, 2, '2022-03-14'),
(92, 2, '2022-03-14'),
(93, 2, '2022-03-14'),
(94, 2, '2022-03-14'),
(95, 1, '2022-03-14'),
(96, 1, '2022-03-14'),
(97, 1, '2022-03-14'),
(98, 1, '2022-03-17'),
(99, 1, '2022-03-17'),
(100, 1, '2022-03-17'),
(101, 1, '2022-03-17'),
(102, 1, '2022-03-17'),
(103, 1, '2022-03-17'),
(104, 1, '2022-03-17'),
(105, 1, '2022-03-17'),
(106, 2, '2022-03-17'),
(107, 1, '2022-03-17'),
(108, 1, '2022-03-17'),
(109, 1, '2022-03-17'),
(110, 1, '2022-03-17'),
(111, 1, '2022-03-17'),
(112, 1, '2022-03-17'),
(113, 1, '2022-03-17'),
(114, 1, '2022-03-17'),
(115, 1, '2022-03-17'),
(116, 1, '2022-03-17'),
(117, 1, '2022-03-17'),
(118, 1, '2022-03-17');

-- --------------------------------------------------------

--
-- Structure de la table `document`
--

DROP TABLE IF EXISTS `document`;
CREATE TABLE IF NOT EXISTS `document` (
  `IDDOCUMENT` int(2) NOT NULL AUTO_INCREMENT,
  `IDUTILISATEUR` int(2) NOT NULL,
  `IDCLIENT` int(2) NOT NULL,
  `NUMERO` int(2) NOT NULL,
  PRIMARY KEY (`IDDOCUMENT`),
  KEY `I_FK_DOCUMENT_UTILISATEUR` (`IDUTILISATEUR`),
  KEY `I_FK_DOCUMENT_CLIENTS` (`IDCLIENT`)
) ENGINE=MyISAM AUTO_INCREMENT=119 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `document`
--

INSERT INTO `document` (`IDDOCUMENT`, `IDUTILISATEUR`, `IDCLIENT`, `NUMERO`) VALUES
(1, 1, 20, 1),
(2, 1, 20, 1),
(3, 1, 20, 1),
(4, 1, 20, 1),
(5, 1, 20, 1),
(6, 1, 20, 1),
(7, 1, 20, 1),
(8, 1, 20, 1),
(9, 1, 20, 1),
(10, 1, 20, 1),
(11, 45, 11, 1),
(12, 45, 11, 1),
(13, 45, 11, 1),
(14, 45, 11, 1),
(15, 45, 11, 1),
(16, 45, 11, 1),
(17, 45, 20, 1),
(18, 45, 20, 2),
(19, 45, 20, 1),
(20, 45, 20, 1),
(21, 45, 20, 1),
(22, 45, 20, 1),
(23, 45, 20, 1),
(24, 45, 11, 1),
(25, 45, 20, 1),
(26, 45, 20, 1),
(27, 45, 11, 1),
(28, 45, 20, 1),
(29, 45, 20, 1),
(30, 45, 20, 1),
(31, 45, 20, 1),
(32, 45, 20, 1),
(33, 45, 20, 1),
(34, 45, 20, 1),
(35, 45, 20, 1),
(36, 45, 20, 1),
(37, 45, 24, 1),
(38, 45, 24, 1),
(39, 45, 21, 1),
(40, 45, 11, 1),
(41, 45, 24, 1),
(42, 45, 24, 1),
(43, 45, 24, 1),
(44, 45, 24, 1),
(45, 45, 11, 1),
(46, 45, 20, 1),
(47, 45, 24, 1),
(48, 45, 24, 1),
(49, 45, 24, 1),
(50, 45, 21, 1),
(51, 45, 21, 1),
(52, 45, 24, 1),
(53, 45, 21, 1),
(54, 45, 21, 1),
(55, 45, 11, 1),
(56, 45, 24, 1),
(57, 45, 11, 1),
(58, 45, 24, 1),
(59, 45, 11, 1),
(60, 45, 11, 1),
(61, 45, 21, 1),
(62, 45, 24, 1),
(63, 45, 24, 1),
(64, 45, 24, 1),
(65, 45, 11, 1),
(66, 45, 24, 1),
(67, 47, 11, 1),
(68, 47, 24, 1),
(69, 47, 24, 1),
(70, 47, 20, 1),
(71, 47, 24, 1),
(72, 47, 24, 1),
(73, 47, 11, 1),
(74, 47, 24, 1),
(75, 47, 24, 1),
(76, 47, 24, 1),
(77, 47, 24, 1),
(78, 47, 24, 1),
(79, 47, 24, 1),
(80, 47, 24, 1),
(81, 47, 24, 1),
(82, 47, 11, 1),
(83, 47, 11, 1),
(84, 47, 11, 1),
(85, 47, 11, 1),
(86, 47, 11, 1),
(87, 47, 11, 1),
(88, 47, 11, 1),
(89, 47, 11, 1),
(90, 47, 11, 1),
(91, 47, 11, 1),
(92, 47, 11, 1),
(93, 47, 11, 1),
(94, 47, 24, 1),
(95, 47, 11, 1),
(96, 47, 11, 1),
(97, 47, 11, 1),
(98, 47, 11, 1),
(99, 47, 24, 1),
(100, 47, 24, 1),
(101, 47, 24, 1),
(102, 47, 24, 1),
(103, 47, 24, 1),
(104, 47, 24, 1),
(105, 47, 24, 1),
(106, 47, 24, 1),
(107, 47, 24, 1),
(108, 47, 24, 1),
(109, 47, 21, 1),
(110, 47, 11, 1),
(111, 47, 24, 1),
(112, 47, 11, 1),
(113, 47, 24, 1),
(114, 47, 24, 1),
(115, 47, 23, 1),
(116, 47, 24, 1),
(117, 47, 23, 1),
(118, 47, 24, 1);

-- --------------------------------------------------------

--
-- Structure de la table `prestation`
--

DROP TABLE IF EXISTS `prestation`;
CREATE TABLE IF NOT EXISTS `prestation` (
  `IDPRESTATION` int(2) NOT NULL AUTO_INCREMENT,
  `LIBELLE` char(32) NOT NULL,
  `PRIX` decimal(10,2) NOT NULL,
  `TVA` decimal(10,2) NOT NULL,
  PRIMARY KEY (`IDPRESTATION`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `prestation`
--

INSERT INTO `prestation` (`IDPRESTATION`, `LIBELLE`, `PRIX`, `TVA`) VALUES
(1, 'Maintenance Informatique', '100.00', '20.00'),
(2, 'Developpement logiciel', '150.00', '20.00');

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

DROP TABLE IF EXISTS `type`;
CREATE TABLE IF NOT EXISTS `type` (
  `IDTYPE` int(2) NOT NULL,
  `LIBELLE` char(32) NOT NULL,
  PRIMARY KEY (`IDTYPE`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `type`
--

INSERT INTO `type` (`IDTYPE`, `LIBELLE`) VALUES
(1, 'Facture'),
(2, 'Devis'),
(3, 'Avoir');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

DROP TABLE IF EXISTS `utilisateur`;
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `IDUTILISATEUR` int(2) UNSIGNED NOT NULL AUTO_INCREMENT,
  `NOM` char(32) NOT NULL,
  `PRENOM` char(32) NOT NULL,
  `MAIL` char(32) NOT NULL,
  `MDP` char(255) NOT NULL,
  `salt` varchar(255) NOT NULL,
  PRIMARY KEY (`IDUTILISATEUR`)
) ENGINE=MyISAM AUTO_INCREMENT=49 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`IDUTILISATEUR`, `NOM`, `PRENOM`, `MAIL`, `MDP`, `salt`) VALUES
(1, 'Harfouche', 'gab', 'gab', 'azerty', ''),
(5, 'gab', 'gab', 'gab@live.fr', 'gab', ''),
(4, 'gab', 'gab', 'gab', 'gab', ''),
(43, 'zaerfgefrezaezr', 'erfgfeazefd', 'zaerzaerf', '$2a$11$yeqw3/sgzIAoWv/2vRWvKufki7vRpQX0M3H0y38rjTW4SqG9gx7X6', ''),
(42, 'zae', 'ze', 'azer', '$2a$11$JGBRXWWB4SbcvY7WyVHcGOgIE3l3zS8XznNDAYPn0m.59UKo3XYL2', ''),
(41, 'az', 'az', 'azerty', '$2a$11$sz8AajWj/aXXmg/fNKbqHez.9y7kvaqAmgudUZyz5kLP2k4QNch6O', ''),
(40, 'z', 'az', 'azzerfgr', '$2a$11$/I/WAWhUJYAVkmGUhYIKKuIx4aR68GKuJx7DAv9oD8bnXmJ6ddAoq', ''),
(39, 'Barreau', 'Barre', 'brault@gmail.com', '$2a$11$bxMKzDDm0ylSvPG5/v.IpOUQb1VkpNYy.QcE/H4rMdQ8j3yRweY/.', ''),
(38, 'az', 'az', 'az', '$2a$11$klHovzS5gL0THHiX66I3.e5w621SlCt6WC8TSH3HP56/QClcyRXm.', ''),
(44, 'azerfg', 'zerfg', 'azertyuiop', '$2a$11$X9CH63YuDfr0C66cbA.mcu21nZb.pPCUOv9ER6OERd5RngB4ctPgy', '$2a$11$X9CH63YuDfr0C66cbA.mcu'),
(45, 'Harfouche', 'Gabriel', 'gabrielh@live.fr', '$2a$11$umKQhC.8t4kBrWsAmApAruJ.guvkHHcNO80.C8rmnJe6/1LvjHOBG', '$2a$11$umKQhC.8t4kBrWsAmApAru'),
(47, 'a', 'a', 'a', '$2a$11$bDggCf3j7Z5cdauZBYA4IO3Rjh5vUpK.VrDiEOoD6PV.eWhRS8KoG', '$2a$11$bDggCf3j7Z5cdauZBYA4IO'),
(48, 'az', 'aze', 'aze@aze.fr', '$2a$11$sX98NhkMu06hzPVqrA.pG.MIbo98VWQUbf2cL002IXBStggvkcuke', '$2a$11$sX98NhkMu06hzPVqrA.pG.');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
