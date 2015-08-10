-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 06-08-2015 a las 00:37:42
-- Versión del servidor: 5.6.12-log
-- Versión de PHP: 5.4.12

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `taquilla`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `horario`
--

CREATE TABLE IF NOT EXISTS `horario` (
  `iidhorario` int(10) NOT NULL AUTO_INCREMENT,
  `iidsucursal` int(10) NOT NULL,
  `iidpelicula` int(10) NOT NULL,
  `dfecha` date NOT NULL,
  `vestado` varchar(20) NOT NULL,
  `fprecio` float NOT NULL,
  `vhora` varchar(15) NOT NULL,
  PRIMARY KEY (`iidhorario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pelicula`
--

CREATE TABLE IF NOT EXISTS `pelicula` (
  `iidpelicula` int(10) NOT NULL AUTO_INCREMENT,
  `vtitulo` varchar(30) DEFAULT NULL,
  `dcosto` decimal(10,2) DEFAULT NULL,
  `ddescuento` decimal(10,2) DEFAULT NULL,
  `vduracion` varchar(10) DEFAULT NULL,
  `vclasificacion` varchar(60) DEFAULT NULL,
  `vcategoria` varchar(10) DEFAULT NULL,
  `velenco` varchar(80) DEFAULT NULL,
  `vdepartamento` varchar(30) DEFAULT NULL,
  `vestablecimiento` varchar(30) DEFAULT NULL,
  `vidioma` varchar(15) DEFAULT NULL,
  `vsubtitulo` varchar(20) DEFAULT NULL,
  `vformato` varchar(15) DEFAULT NULL,
  `ipuntos` int(10) DEFAULT NULL,
  `vrutaImagen` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`iidpelicula`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Volcado de datos para la tabla `pelicula`
--

INSERT INTO `pelicula` (`iidpelicula`, `vtitulo`, `dcosto`, `ddescuento`, `vduracion`, `vclasificacion`, `vcategoria`, `velenco`, `vdepartamento`, `vestablecimiento`, `vidioma`, `vsubtitulo`, `vformato`, `ipuntos`, `vrutaImagen`) VALUES
(13, '', '0.00', '0.00', '', 'AA(Apto para todo público, en especial para niños)', 'Animación', '', 'Guatemala', 'Cinepolis, Portales', 'Español', 'Subtitulos en Españo', '3D', 0, ''),
(14, '', '0.00', '0.00', '', 'AA(Apto para todo público, en especial para niños)', 'Animación', '', 'Guatemala', 'Cinepolis, Portales', 'Español', 'Subtitulos en Españo', '3D', 0, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sala`
--

CREATE TABLE IF NOT EXISTS `sala` (
  `iidSala` int(10) NOT NULL AUTO_INCREMENT,
  `vcapacidad` varchar(20) NOT NULL,
  `vtipo` varchar(20) NOT NULL,
  PRIMARY KEY (`iidSala`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucursal`
--

CREATE TABLE IF NOT EXISTS `sucursal` (
  `iidSucursal` int(10) NOT NULL AUTO_INCREMENT,
  `vnombre` varchar(20) NOT NULL,
  `iestado` int(10) NOT NULL,
  `vdireccion` varchar(30) NOT NULL,
  PRIMARY KEY (`iidSucursal`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
