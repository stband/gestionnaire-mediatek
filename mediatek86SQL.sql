-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 04 juin 2024 à 12:53
-- Version du serveur : 8.3.0
-- Version de PHP : 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(9, '2024-10-11 09:30:00', '2024-10-19 17:00:00', 2),
(6, '2024-09-03 08:10:00', '2024-09-10 16:30:00', 4),
(7, '2024-08-08 09:45:00', '2024-08-16 17:20:00', 1),
(4, '2024-07-22 10:25:00', '2024-07-30 17:15:00', 3),
(5, '2024-06-12 09:00:00', '2024-06-20 17:40:00', 2),
(7, '2024-05-10 09:35:00', '2024-05-18 16:30:00', 1),
(3, '2024-04-01 10:15:00', '2024-04-06 17:00:00', 4),
(2, '2024-02-15 08:45:00', '2024-02-20 17:00:00', 3),
(10, '2024-01-05 09:20:00', '2024-01-12 17:15:00', 2),
(6, '2024-03-10 10:00:00', '2024-03-18 16:50:00', 4),
(10, '2023-05-20 07:55:00', '2023-06-02 17:05:00', 1),
(3, '2023-07-02 08:30:00', '2023-07-09 17:00:00', 2),
(7, '2023-06-15 09:10:00', '2023-06-20 17:20:00', 1),
(5, '2023-11-18 08:40:00', '2023-12-01 16:35:00', 3),
(10, '2024-02-18 09:00:00', '2024-02-25 17:30:00', 1),
(9, '2023-05-10 07:50:00', '2023-05-24 16:45:00', 3),
(1, '2023-11-25 08:55:00', '2023-12-01 17:10:00', 3),
(4, '2024-03-05 09:40:00', '2024-03-30 17:30:00', 2),
(8, '2023-05-15 08:10:00', '2023-05-23 17:20:00', 1),
(2, '2023-10-25 09:15:00', '2023-11-14 17:05:00', 3),
(7, '2023-06-09 08:25:00', '2023-06-20 16:50:00', 4),
(5, '2023-08-15 09:30:00', '2023-08-28 17:00:00', 4),
(10, '2023-06-05 07:45:00', '2023-06-25 17:15:00', 3),
(9, '2024-02-25 10:00:00', '2024-03-10 16:20:00', 1),
(4, '2023-10-21 08:15:00', '2023-10-27 17:25:00', 3),
(1, '2023-11-11 09:20:00', '2023-11-20 17:30:00', 2),
(3, '2023-10-15 08:00:00', '2023-11-10 16:30:00', 4),
(7, '2024-01-22 09:50:00', '2024-02-11 18:10:00', 4),
(6, '2024-04-15 08:30:00', '2024-04-16 17:00:00', 2),
(4, '2024-02-26 09:05:00', '2024-03-25 16:45:00', 3),
(1, '2023-11-08 08:40:00', '2023-12-02 17:20:00', 3),
(3, '2023-10-24 09:25:00', '2023-11-16 17:35:00', 1),
(8, '2024-04-25 10:15:00', '2024-05-04 16:55:00', 4),
(7, '2023-12-20 08:45:00', '2023-12-30 17:05:00', 2),
(4, '2023-12-09 09:00:00', '2024-01-04 17:00:00', 4),
(6, '2024-02-28 10:05:00', '2024-03-29 18:15:00', 1),
(7, '2023-05-09 08:35:00', '2023-05-20 16:40:00', 2),
(6, '2023-11-25 09:10:00', '2023-12-16 16:50:00', 4),
(9, '2024-03-09 07:55:00', '2024-03-22 17:25:00', 1),
(4, '2024-02-09 08:20:00', '2024-03-10 16:30:00', 1),
(7, '2023-06-16 09:30:00', '2023-06-26 17:15:00', 1),
(5, '2023-10-03 07:50:00', '2023-10-05 16:00:00', 1),
(9, '2023-09-05 08:45:00', '2023-09-11 17:05:00', 4),
(8, '2024-01-26 10:00:00', '2024-02-20 18:20:00', 4),
(5, '2023-11-15 09:15:00', '2023-11-23 17:10:00', 2),
(7, '2023-06-10 08:30:00', '2023-06-25 16:45:00', 1),
(9, '2023-05-22 07:00:00', '2023-06-20 17:30:00', 4),
(8, '2024-04-17 10:00:00', '2024-05-07 16:00:00', 2),
(5, '2024-01-23 09:00:00', '2024-02-08 18:00:00', 1),
(8, '2023-05-13 08:00:00', '2023-05-15 17:00:00', 2),
(10, '2024-11-20 10:00:00', '2024-11-28 16:45:00', 3);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `tel` varchar(15) DEFAULT NULL,
  `mail` varchar(128) DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(12, 'Leroy', 'Julien', '07 23 56 89 01', 'julien.leroy@gmail.com', 1),
(10, 'Nicolas', 'Valérie', '06 36 08 63 58', 'paulluce@sfr.fr', 2),
(11, 'Durand', 'Sophie', '06 45 78 92 14', 'sophie.durand@hotmail.com', 2),
(9, 'Rolland', 'Noémi', '07 56 74 78 35', 'tguillot@noos.fr', 1),
(8, 'Martelo', 'François', '06 93 38 76 64', 'uguichard@pro.com', 2),
(7, 'Trae', 'Marcelle', '06 56 87 47 65', 'julie89@free.fr', 3),
(6, 'Dupré', 'Colette', '06 87 67 56 98', 'boulayemile@carpentier.com', 1),
(1, 'Faivro', 'Renée', '06 88 54 67 32', 'rene.dupre@hotmail.fr', 2),
(2, 'Gimenez', 'Juliette', '07 67 87 97 67', 'laurent10@yahoo.fr', 3),
(3, 'Poulain', 'Jeannine', '06 78 06 46 57', 'christelle72@lecoq.com', 1),
(4, 'Goger', 'Bernadette', '06 06 07 04 63', 'potiermichelle@yahoo.fr', 1),
(5, 'Poirier', 'Jeanne', '08 37 58 63 95', 'zdiaz@laposte.net', 1),
(13, 'Moreau', 'Isabelle', '06 98 76 54 32', 'isabelle.moreau@gmail.com', 3),
(14, 'Lefebvre', 'Maxime', '07 67 89 01 23', 'maxime.lefebvre@gmail.com', 2),
(15, 'Rousseau', 'Émilie', '06 34 56 78 90', 'emilie.rousseau@gmail.com', 1),
(16, 'Muller', 'Théo', '07 89 01 23 45', 'theo.muller@mail.com', 3),
(17, 'Gribon', 'Léa', '06 56 78 90 12', 'lea.girard@icloud.com', 2),
(18, 'Blanc', 'Nathan', '07 23 45 67 89', 'nathan.blanc@icloud.com', 1),
(19, 'Mercier', 'Chloé', '06 89 01 23 45', 'chloe.mercier@mail.com', 3),
(20, 'Garnier', 'Lucas', '07 45 67 89 01', 'lucas.garnier@hotmail.com', 2),
(21, 'Chevaler', 'Inès', '06 12 34 56 78', 'ines.chevalier@gmail.com', 1),
(22, 'Moion', 'Quentin', '07 78 90 12 34', 'quentin.morin@mediatek.com', 3),
(23, 'Fournier', 'Manon', '06 45 67 89 01', 'manon.fournier@mediatek.com', 2),
(24, 'Roux', 'Camille', '07 12 34 56 78', 'camille.roux@hotmail.com', 1),
(25, 'Gaillard', 'Tristan', '06 78 90 12 34', 'tristan.gaillard@gmail.com', 3);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) DEFAULT NULL,
  `pwd` varchar(64) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('responsable', '967520ae23e8ee14888bae72809031b98398ae4a636773e18fff917d77679334');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
