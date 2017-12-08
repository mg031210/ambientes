-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 08-12-2017 a las 00:28:55
-- Versión del servidor: 5.7.19
-- Versión de PHP: 7.0.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `mydb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

DROP TABLE IF EXISTS `compra`;
CREATE TABLE IF NOT EXISTS `compra` (
  `idcompra` int(11) NOT NULL AUTO_INCREMENT,
  `monto` varchar(7) NOT NULL,
  `fechaadquisicion` date NOT NULL,
  `idusuario` int(11) NOT NULL,
  `idpelicula` int(11) NOT NULL,
  `idproveedor` int(11) DEFAULT NULL,
  PRIMARY KEY (`idcompra`),
  KEY `fk_Devoluciones_Usuario1` (`idusuario`),
  KEY `fk_Devoluciones_Pelicula1` (`idpelicula`),
  KEY `fk_Devoluciones_Proveedor1` (`idproveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=108 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `compra`
--

INSERT INTO `compra` (`idcompra`, `monto`, `fechaadquisicion`, `idusuario`, `idpelicula`, `idproveedor`) VALUES
(1, '10', '2017-11-21', 2, 5, NULL),
(2, '10', '2017-11-21', 2, 5, NULL),
(3, '100', '2017-11-28', 3, 95, NULL),
(4, '100', '2017-11-28', 3, 95, NULL),
(5, '100', '2017-11-28', 3, 95, NULL),
(6, '100', '2017-11-28', 3, 95, NULL),
(7, '100', '2017-11-28', 3, 95, NULL),
(8, '100', '2017-11-28', 1, 98, NULL),
(9, '100', '2017-11-28', 1, 98, NULL),
(10, '100', '2017-11-28', 1, 98, NULL),
(11, '100', '2017-11-28', 1, 98, NULL),
(12, '100', '2017-11-28', 1, 98, NULL),
(13, '100', '2017-11-28', 1, 98, NULL),
(14, '100', '2017-11-28', 1, 98, NULL),
(15, '100', '2017-11-28', 1, 98, NULL),
(16, '100', '2017-11-28', 1, 98, NULL),
(17, '100', '2017-11-28', 1, 98, NULL),
(18, '100', '2017-11-28', 1, 98, NULL),
(19, '100', '2017-11-28', 1, 98, NULL),
(20, '100', '2017-11-28', 1, 98, NULL),
(21, '100', '2017-11-28', 1, 98, NULL),
(22, '100', '2017-11-28', 1, 98, NULL),
(23, '100', '2017-11-28', 1, 98, NULL),
(24, '100', '2017-11-28', 1, 98, NULL),
(25, '100', '2017-11-28', 1, 98, NULL),
(26, '100', '2017-11-28', 1, 98, NULL),
(27, '100', '2017-11-28', 1, 98, NULL),
(28, '100', '2017-11-28', 1, 98, NULL),
(29, '100', '2017-11-28', 1, 98, NULL),
(30, '100', '2017-11-28', 1, 98, NULL),
(31, '100', '2017-11-28', 1, 98, NULL),
(32, '100', '2017-11-28', 1, 98, NULL),
(33, '100', '2017-11-28', 1, 98, NULL),
(34, '100', '2017-11-28', 1, 98, NULL),
(35, '100', '2017-11-28', 1, 98, NULL),
(36, '100', '2017-11-28', 1, 98, NULL),
(37, '100', '2017-11-28', 1, 98, NULL),
(38, '100', '2017-11-28', 1, 98, NULL),
(39, '100', '2017-11-28', 1, 98, NULL),
(40, '100', '2017-11-28', 1, 98, NULL),
(41, '100', '2017-11-28', 1, 98, NULL),
(42, '100', '2017-11-28', 1, 98, NULL),
(43, '100', '2017-11-28', 1, 98, NULL),
(44, '100', '2017-11-28', 1, 98, NULL),
(45, '100', '2017-11-28', 1, 98, NULL),
(46, '100', '2017-11-28', 1, 98, NULL),
(47, '100', '2017-11-28', 1, 98, NULL),
(48, '100', '2017-11-28', 1, 98, NULL),
(49, '100', '2017-11-28', 1, 98, NULL),
(50, '100', '2017-11-28', 1, 98, NULL),
(51, '100', '2017-11-28', 1, 98, NULL),
(52, '100', '2017-11-28', 1, 98, NULL),
(53, '100', '2017-11-28', 1, 98, NULL),
(54, '100', '2017-11-28', 1, 98, NULL),
(55, '100', '2017-11-28', 1, 98, NULL),
(56, '100', '2017-11-28', 1, 98, NULL),
(57, '100', '2017-11-28', 1, 98, NULL),
(58, '100', '2017-11-28', 1, 98, NULL),
(59, '100', '2017-11-28', 1, 98, NULL),
(60, '100', '2017-11-28', 1, 98, NULL),
(61, '100', '2017-11-28', 1, 98, NULL),
(62, '100', '2017-11-28', 1, 98, NULL),
(63, '100', '2017-11-28', 1, 98, NULL),
(64, '100', '2017-11-28', 1, 98, NULL),
(65, '100', '2017-11-28', 1, 98, NULL),
(66, '100', '2017-11-28', 1, 98, NULL),
(67, '100', '2017-11-28', 1, 98, NULL),
(68, '100', '2017-11-28', 1, 98, NULL),
(69, '100', '2017-11-28', 1, 98, NULL),
(70, '100', '2017-11-28', 1, 98, NULL),
(71, '100', '2017-11-28', 1, 98, NULL),
(72, '100', '2017-11-28', 1, 98, NULL),
(73, '100', '2017-11-28', 1, 98, NULL),
(74, '100', '2017-11-28', 1, 98, NULL),
(75, '100', '2017-11-28', 1, 98, NULL),
(76, '100', '2017-11-28', 1, 98, NULL),
(77, '100', '2017-11-28', 1, 98, NULL),
(78, '100', '2017-11-28', 1, 98, NULL),
(79, '100', '2017-11-28', 1, 98, NULL),
(80, '100', '2017-11-28', 1, 98, NULL),
(81, '100', '2017-11-28', 1, 98, NULL),
(82, '100', '2017-11-28', 1, 98, NULL),
(83, '100', '2017-11-28', 1, 98, NULL),
(84, '100', '2017-11-28', 1, 98, NULL),
(85, '100', '2017-11-28', 1, 98, NULL),
(86, '100', '2017-11-28', 1, 98, NULL),
(87, '100', '2017-11-28', 1, 98, NULL),
(88, '100', '2017-11-28', 1, 98, NULL),
(89, '100', '2017-11-28', 1, 98, NULL),
(90, '100', '2017-11-28', 1, 98, NULL),
(91, '100', '2017-11-28', 1, 98, NULL),
(92, '100', '2017-11-28', 1, 98, NULL),
(93, '100', '2017-11-28', 1, 98, NULL),
(94, '100', '2017-11-28', 1, 98, NULL),
(95, '100', '2017-11-28', 1, 98, NULL),
(96, '100', '2017-11-28', 1, 98, NULL),
(97, '100', '2017-11-28', 1, 98, NULL),
(98, '100', '2017-11-28', 1, 98, NULL),
(99, '100', '2017-11-28', 1, 98, NULL),
(100, '100', '2017-11-28', 1, 98, NULL),
(101, '100', '2017-11-28', 1, 98, NULL),
(102, '100', '2017-11-28', 1, 98, NULL),
(103, '100', '2017-11-28', 1, 98, NULL),
(104, '100', '2017-11-28', 1, 98, NULL),
(105, '100', '2017-11-28', 1, 98, NULL),
(106, '100', '2017-11-28', 1, 98, NULL),
(107, '100', '2017-11-28', 1, 98, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `menbresia`
--

DROP TABLE IF EXISTS `menbresia`;
CREATE TABLE IF NOT EXISTS `menbresia` (
  `idmenbresia` int(11) NOT NULL AUTO_INCREMENT,
  `estado` varchar(1) NOT NULL DEFAULT 'A',
  `vigencia` date NOT NULL,
  `fechaingreso` date NOT NULL,
  `numsocio` int(11) NOT NULL,
  `idusuario` int(11) NOT NULL,
  PRIMARY KEY (`idmenbresia`),
  KEY `fk_Menbresia_Usuario1` (`idusuario`),
  KEY `fk_Menbresia_Socio1` (`numsocio`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `menbresia`
--

INSERT INTO `menbresia` (`idmenbresia`, `estado`, `vigencia`, `fechaingreso`, `numsocio`, `idusuario`) VALUES
(8, 'A', '2018-11-28', '2017-11-28', 18, 3),
(9, 'A', '2018-11-28', '2017-11-28', 19, 3),
(10, 'A', '2018-11-28', '2017-11-28', 20, 3),
(11, 'A', '2018-11-28', '2017-11-28', 21, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pelicula`
--

DROP TABLE IF EXISTS `pelicula`;
CREATE TABLE IF NOT EXISTS `pelicula` (
  `idpelicula` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `tipopelicula` char(1) NOT NULL,
  `duracion` varchar(3) DEFAULT NULL,
  `clasificacion` varchar(3) DEFAULT NULL,
  `categoria` varchar(20) DEFAULT NULL,
  `cantidad` int(11) NOT NULL DEFAULT '0',
  `estado` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`idpelicula`)
) ENGINE=InnoDB AUTO_INCREMENT=99 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `pelicula`
--

INSERT INTO `pelicula` (`idpelicula`, `nombre`, `tipopelicula`, `duracion`, `clasificacion`, `categoria`, `cantidad`, `estado`) VALUES
(1, 'El nucleo2', 'E', '122', 'D', 'Miedo', 1, 'I'),
(2, 'Alicia pais de maravillas', 'E', '120', 'B15', 'Ficcion', 3, 'I'),
(4, 'star wars 6', 'C', '128', 'C', 'Accion', 1, 'A'),
(5, 'star wars 3', 'C', '121', 'B', 'Accion', 3, 'I'),
(95, 'Liga de la justicia mod', 'C', '125', 'C', 'Accion', 2, 'A'),
(96, 'Esuna pruebas', 'E', '123', 'A', 'Miedo', 0, 'I'),
(97, 'prueba', 'C', '120', 'B15', 'Accion', 0, 'I'),
(98, 'Nueva Peli', 'E', '123', 'B', 'Aventura', 95, 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE IF NOT EXISTS `proveedor` (
  `idproveedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `rfc` varchar(13) NOT NULL,
  `telefono1` varchar(13) NOT NULL,
  `telefono2` varchar(13) DEFAULT NULL,
  `fax` varchar(13) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `codigopostal` varchar(5) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `personacontacto` varchar(45) DEFAULT NULL,
  `estado` varchar(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`idproveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`idproveedor`, `nombre`, `rfc`, `telefono1`, `telefono2`, `fax`, `direccion`, `codigopostal`, `email`, `personacontacto`, `estado`) VALUES
(1, 'aasdMod', 'asdnew', '123222', '123333', '1234444', 'asd', '12311', 'asd@asd.com', 'sd alguin', 'I'),
(2, 'mod', 'EULC', '3333333333', '4444444444', '1111111111', 'algun lado', '22222', 'asd@asd.com', 'alguien', 'A'),
(3, 'es mod', 'asddddddddddd', '4444444444', '5555555555', '2222222222', 'es una prueba', '33333', 'asdas@asdasd.com mod', 'algun mod', 'I'),
(4, 'asdasd', 'qweqweqwe', '3333333333', '4444444444', '1111111111', 'qeqweqwe', '22222', 'qweqwe@qweqwe', '', 'I');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `renta`
--

DROP TABLE IF EXISTS `renta`;
CREATE TABLE IF NOT EXISTS `renta` (
  `idrenta` int(11) NOT NULL AUTO_INCREMENT,
  `FechaRenta` date NOT NULL,
  `fechaentrega` date NOT NULL,
  `fechaentregado` date DEFAULT NULL,
  `idusuario` int(11) NOT NULL,
  `idsocio` int(11) NOT NULL,
  `idpelicula` int(11) NOT NULL,
  `monto` varchar(5) NOT NULL,
  `montodevolucion` varchar(5) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idrenta`),
  KEY `fk_Renta_Usuario1` (`idusuario`),
  KEY `fk_Renta_Socio1` (`idsocio`),
  KEY `fk_Renta_Pelicula1` (`idpelicula`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `renta`
--

INSERT INTO `renta` (`idrenta`, `FechaRenta`, `fechaentrega`, `fechaentregado`, `idusuario`, `idsocio`, `idpelicula`, `monto`, `montodevolucion`) VALUES
(37, '2017-11-28', '2017-12-03', '2017-11-28', 1, 19, 95, '10', '10'),
(38, '2017-11-28', '2017-12-01', '2017-11-28', 1, 19, 98, '50', '50'),
(39, '2017-11-28', '2017-12-01', '2017-11-28', 1, 19, 98, '50', '50'),
(40, '2017-11-28', '2017-12-01', '2017-11-28', 1, 19, 98, '50', '50'),
(41, '2017-11-28', '2017-12-01', '2017-11-28', 1, 19, 98, '50', '50'),
(42, '2017-11-28', '2017-12-01', '2017-11-28', 1, 19, 98, '50', '50'),
(43, '2017-11-28', '2017-12-01', '2017-11-28', 1, 19, 98, '50', '50'),
(44, '2017-11-28', '2017-12-01', '2017-11-28', 1, 19, 98, '50', '50'),
(45, '2017-11-28', '2017-12-01', '2017-11-28', 1, 19, 98, '50', '50'),
(46, '2017-11-28', '2017-12-01', '2017-12-07', 1, 19, 98, '50', '300'),
(47, '2017-11-28', '2017-12-01', '2017-12-07', 1, 19, 98, '50', '300');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `socio`
--

DROP TABLE IF EXISTS `socio`;
CREATE TABLE IF NOT EXISTS `socio` (
  `idsocio` int(11) NOT NULL AUTO_INCREMENT,
  `numsocio` varchar(10) DEFAULT NULL,
  `estado` varchar(45) NOT NULL DEFAULT 'A',
  `nombre` varchar(30) NOT NULL,
  `apellidop` varchar(20) NOT NULL,
  `apellidom` varchar(20) DEFAULT NULL,
  `telefono` varchar(13) DEFAULT NULL,
  `celular` varchar(13) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idsocio`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `socio`
--

INSERT INTO `socio` (`idsocio`, `numsocio`, `estado`, `nombre`, `apellidop`, `apellidom`, `telefono`, `celular`, `direccion`) VALUES
(18, NULL, 'I', 'FErnando', 'Esquivel ', 'Lvaot', '1121212', '727263721', 'algo asdsd'),
(19, NULL, 'A', 'Fernando', 'aefvsf', 'sdfasdf', '123123', '123213214', 'sadasda'),
(20, NULL, 'I', 'esto', 'es un ', 'prueba', '1231231', '124567', 'nasjkcnadlmalmcl'),
(21, NULL, 'I', 'prueba mod', '2 mod', 'cambios mod', '1111111', '222222', 'ajkvcsdnnocxz mod');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trabajador`
--

DROP TABLE IF EXISTS `trabajador`;
CREATE TABLE IF NOT EXISTS `trabajador` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT,
  `numtrabajador` varchar(8) DEFAULT NULL,
  `usuario` varchar(20) DEFAULT NULL,
  `contrasena` varchar(45) DEFAULT NULL,
  `estado` char(1) NOT NULL DEFAULT 'A',
  `nombre` varchar(30) NOT NULL,
  `apellidop` varchar(20) NOT NULL,
  `apellidom` varchar(20) DEFAULT NULL,
  `telefono` varchar(13) DEFAULT NULL,
  `celular` varchar(13) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `rol` int(1) NOT NULL DEFAULT '2',
  PRIMARY KEY (`idusuario`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `trabajador`
--

INSERT INTO `trabajador` (`idusuario`, `numtrabajador`, `usuario`, `contrasena`, `estado`, `nombre`, `apellidop`, `apellidom`, `telefono`, `celular`, `direccion`, `rol`) VALUES
(1, '1', 'admin', 'eBVpbsvxyW5olLd5RW0zDg==', 'A', 'Fernandoasd', 'Esquivelasd', 'Lovatoasa', '1111111222', '844111111122', 'asdalgun', 1),
(2, 'asd', 'dueño', 'eBVpbsvxyW5olLd5RW0zDg==', 'A', 'asd', 'asda', 'asd', '123', '123', 'asd', 1),
(3, '123', 'usuario', 'eBVpbsvxyW5olLd5RW0zDg==', 'A', 'asd', 'asd', 'asd', '123', '123', 'asd', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

DROP TABLE IF EXISTS `venta`;
CREATE TABLE IF NOT EXISTS `venta` (
  `idventa` int(11) NOT NULL AUTO_INCREMENT,
  `monto` varchar(7) NOT NULL,
  `fechaventa` date NOT NULL,
  `idusuario` int(11) NOT NULL,
  `idpelicula` int(11) NOT NULL,
  PRIMARY KEY (`idventa`),
  KEY `fk_Venta_Usuario1` (`idusuario`),
  KEY `fk_Venta_Pelicula1` (`idpelicula`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`idventa`, `monto`, `fechaventa`, `idusuario`, `idpelicula`) VALUES
(3, '50', '2017-11-17', 2, 2),
(4, '50', '2017-11-17', 2, 2),
(5, '50', '2017-11-17', 2, 2),
(6, '50', '2017-11-17', 2, 4),
(7, '50', '2017-11-17', 2, 4),
(8, '50', '2017-11-17', 2, 5),
(9, '50', '2017-11-19', 2, 1),
(10, '50', '2017-11-19', 2, 1),
(11, '50', '2017-11-19', 2, 2),
(12, '50', '2017-11-19', 2, 1),
(13, '50', '2017-11-19', 2, 2),
(14, '50', '2017-11-19', 2, 2),
(15, '50', '2017-11-19', 2, 2),
(16, '50', '2017-11-19', 2, 4),
(17, '50', '2017-11-19', 2, 4),
(18, '50', '2017-11-19', 2, 4),
(19, '50', '2017-11-19', 2, 4),
(20, '50', '2017-11-19', 2, 4),
(21, '50', '2017-11-19', 2, 5),
(22, '50', '2017-11-19', 2, 5),
(23, '50', '2017-11-19', 3, 1),
(24, '50', '2017-11-19', 3, 2),
(25, '50', '2017-11-19', 3, 4),
(26, '50', '2017-11-19', 3, 5),
(27, '50', '2017-11-21', 2, 1),
(28, '50', '2017-11-21', 2, 1),
(29, '50', '2017-11-28', 3, 4),
(30, '50', '2017-11-28', 3, 5),
(31, '50', '2017-11-28', 3, 5),
(32, '50', '2017-11-28', 1, 98),
(33, '50', '2017-11-28', 1, 98),
(34, '50', '2017-11-28', 1, 98),
(35, '50', '2017-11-28', 1, 98),
(36, '10', '2017-11-28', 1, 95),
(37, '50', '2017-11-28', 1, 98);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `compra`
--
ALTER TABLE `compra`
  ADD CONSTRAINT `fk_Devoluciones_Pelicula1` FOREIGN KEY (`idpelicula`) REFERENCES `pelicula` (`idpelicula`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Devoluciones_Proveedor1` FOREIGN KEY (`idproveedor`) REFERENCES `proveedor` (`idproveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Devoluciones_Usuario1` FOREIGN KEY (`idusuario`) REFERENCES `trabajador` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `menbresia`
--
ALTER TABLE `menbresia`
  ADD CONSTRAINT `fk_Menbresia_Socio1` FOREIGN KEY (`numsocio`) REFERENCES `socio` (`idsocio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Menbresia_Usuario1` FOREIGN KEY (`idusuario`) REFERENCES `trabajador` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `renta`
--
ALTER TABLE `renta`
  ADD CONSTRAINT `fk_Renta_Pelicula1` FOREIGN KEY (`idpelicula`) REFERENCES `pelicula` (`idpelicula`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Renta_Socio1` FOREIGN KEY (`idsocio`) REFERENCES `socio` (`idsocio`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Renta_Usuario1` FOREIGN KEY (`idusuario`) REFERENCES `trabajador` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `venta`
--
ALTER TABLE `venta`
  ADD CONSTRAINT `fk_Venta_Pelicula1` FOREIGN KEY (`idpelicula`) REFERENCES `pelicula` (`idpelicula`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Venta_Usuario1` FOREIGN KEY (`idusuario`) REFERENCES `trabajador` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
