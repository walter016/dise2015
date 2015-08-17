-- phpMyAdmin SQL Dump
-- version 4.4.12
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-08-2015 a las 18:56:47
-- Versión del servidor: 5.6.25
-- Versión de PHP: 5.6.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `taquilla`
--
CREATE DATABASE IF NOT EXISTS `taquilla` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `taquilla`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maciudad`
--

CREATE TABLE IF NOT EXISTS `maciudad` (
  `iidCiudad` int(11) NOT NULL,
  `vnombreCiudad` varchar(20) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maciudad`
--

INSERT INTO `maciudad` (`iidCiudad`, `vnombreCiudad`) VALUES
(1, 'Guatemala'),
(2, 'Xela'),
(3, 'New York'),
(4, '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `macliente`
--

CREATE TABLE IF NOT EXISTS `macliente` (
  `iidCliente` int(11) NOT NULL,
  `init` int(11) DEFAULT NULL,
  `vnombre` varchar(50) DEFAULT NULL,
  `vapellido` varchar(50) DEFAULT NULL,
  `vemail` varchar(50) DEFAULT NULL,
  `vtipoPago` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mafactura`
--

CREATE TABLE IF NOT EXISTS `mafactura` (
  `iidFactura` int(11) NOT NULL,
  `iidregistro` int(11) NOT NULL,
  `iidReservacion` int(11) DEFAULT NULL,
  `vfechaFactura` varchar(40) DEFAULT NULL,
  `vnombreCliente` varchar(30) DEFAULT NULL,
  `init` int(11) DEFAULT NULL,
  `dtotalPago` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mapelicula`
--

CREATE TABLE IF NOT EXISTS `mapelicula` (
  `iidpelicula` int(10) NOT NULL,
  `vtitulo` varchar(40) DEFAULT NULL,
  `dcosto` decimal(10,2) DEFAULT NULL,
  `ddescuento` decimal(10,2) DEFAULT NULL,
  `vduracion` varchar(10) DEFAULT NULL,
  `vtipoSala` varchar(15) DEFAULT NULL,
  `vclasificacion` varchar(50) DEFAULT NULL,
  `vcategoria` varchar(30) DEFAULT NULL,
  `velenco` varchar(80) DEFAULT NULL,
  `vdepartamento` varchar(30) DEFAULT NULL,
  `vestablecimiento` varchar(30) DEFAULT NULL,
  `vidioma` varchar(15) DEFAULT NULL,
  `vsubtitulo` varchar(20) DEFAULT NULL,
  `ipuntos` int(10) DEFAULT NULL,
  `bimagen` mediumblob
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `mapelicula`
--

INSERT INTO `mapelicula` (`iidpelicula`, `vtitulo`, `dcosto`, `ddescuento`, `vduracion`, `vtipoSala`, `vclasificacion`, `vcategoria`, `velenco`, `vdepartamento`, `vestablecimiento`, `vidioma`, `vsubtitulo`, `ipuntos`, `bimagen`) VALUES
(1, 'prueba', '3.00', '3.00', '3', '4D', 'AA(Apto para todo público, en especial para niños)', 'Animación', 'sfdfsd', 'System.Data.DataRowView', 'Cinepolis Santa Clara', 'Portugues', 'Español', 33, 0x53797374656d2e427974655b5d),
(2, 'prueba 2', '2.00', '2.00', '3', '4D', 'A (Apto para todo público)', 'Terror', 'dsfdfs', 'Guatemala', 'Cinepolis Santa Clara', 'Ingles', 'Español', 3, 0x53797374656d2e427974655b5d),
(3, 'ant man', '300.00', '10.00', '1', '4D', 'A (Apta para todos público)', 'Animación', 'aaaa', 'Guatemala', 'Pradera', 'Español', 'Sin Subtitulos', 5, 0x53797374656d2e427974655b5d);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `maregistropersonal`
--

CREATE TABLE IF NOT EXISTS `maregistropersonal` (
  `iidregistro` int(11) NOT NULL,
  `vnombre` varchar(30) DEFAULT NULL,
  `vapellido` varchar(30) DEFAULT NULL,
  `vtipo` varchar(20) DEFAULT NULL,
  `vusuario` varchar(30) DEFAULT NULL,
  `vcontrasenia` varchar(30) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `maregistropersonal`
--

INSERT INTO `maregistropersonal` (`iidregistro`, `vnombre`, `vapellido`, `vtipo`, `vusuario`, `vcontrasenia`) VALUES
(1, 'hector', 'cardona', 'administrador', 'hcardona', '1234'),
(2, 'jose', 'carlos', 'Taquillero', 'jcarlos1', '1234'),
(3, 'gilf', 'cardona', 'Administrador', 'revision', '1234');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `masucursal`
--

CREATE TABLE IF NOT EXISTS `masucursal` (
  `iidSucursal` int(10) NOT NULL,
  `iidCiudad` int(11) NOT NULL,
  `iestado` int(10) NOT NULL,
  `vnombre` varchar(30) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `masucursal`
--

INSERT INTO `masucursal` (`iidSucursal`, `iidCiudad`, `iestado`, `vnombre`) VALUES
(1, 2, 1, 'Pradera'),
(2, 1, 0, 'Portales Z.18'),
(3, 1, 1, 'Portales'),
(4, 3, 1, 'pradera'),
(5, 2, 1, 'Santa Clara');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matiposala`
--

CREATE TABLE IF NOT EXISTS `matiposala` (
  `iidTipo` int(11) NOT NULL,
  `icantidadSala` int(11) NOT NULL,
  `vtipoSala` varchar(10) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `matiposala`
--

INSERT INTO `matiposala` (`iidTipo`, `icantidadSala`, `vtipoSala`) VALUES
(1, 40, '4D'),
(2, 35, '3D'),
(3, 20, 'IMAX');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trasientos`
--

CREATE TABLE IF NOT EXISTS `trasientos` (
  `iidAsiento` int(11) NOT NULL,
  `iidSala` int(11) NOT NULL,
  `vfila` varchar(20) DEFAULT NULL,
  `icolumna` int(11) DEFAULT NULL,
  `iestado` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trasientos`
--

INSERT INTO `trasientos` (`iidAsiento`, `iidSala`, `vfila`, `icolumna`, `iestado`) VALUES
(1, 3, 'A', 1, 0),
(2, 3, 'A', 2, 0),
(3, 3, 'A', 3, 0),
(4, 3, 'A', 4, 0),
(5, 3, 'B', 4, 0),
(6, 3, 'C', 4, 0),
(7, 3, 'C', 7, 0),
(8, 3, 'C', 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trbitacora`
--

CREATE TABLE IF NOT EXISTS `trbitacora` (
  `iidBitacora` int(11) NOT NULL,
  `iidregistro` int(11) NOT NULL,
  `vusuario` varchar(30) DEFAULT NULL,
  `thora` time DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `vnombreEquipo` varchar(30) DEFAULT NULL,
  `vaccion` varchar(40) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trbitacora`
--

INSERT INTO `trbitacora` (`iidBitacora`, `iidregistro`, `vusuario`, `thora`, `dfecha`, `vnombreEquipo`, `vaccion`) VALUES
(1, 0, 'hector', '10:57:20', '2015-08-09', 'HECTORCARDONA', NULL),
(2, 0, 'hcardona', '11:15:35', '2015-08-09', 'HECTORCARDONA', NULL),
(3, 0, 'hcardona', '11:18:52', '2015-08-09', 'HECTORCARDONA', NULL),
(4, 0, 'hcardona', '11:20:15', '2015-08-09', 'HECTORCARDONA', NULL),
(5, 0, 'hcardona', '11:21:49', '2015-08-09', 'HECTORCARDONA', NULL),
(6, 0, 'hcardona', '11:22:45', '2015-08-09', 'HECTORCARDONA', NULL),
(7, 0, 'hcardona', '08:02:46', '2015-08-09', 'HECTORCARDONA', NULL),
(8, 0, 'hcardona', '08:07:48', '2015-08-09', 'HECTORCARDONA', NULL),
(9, 0, 'hcardona', '08:14:28', '2015-08-09', 'HECTORCARDONA', NULL),
(10, 0, 'hcardona', '08:32:31', '2015-08-09', 'HECTORCARDONA', NULL),
(11, 0, 'hcardona', '08:46:51', '2015-08-09', 'HECTORCARDONA', NULL),
(12, 0, 'hcardona', '10:22:52', '2015-08-09', 'HECTORCARDONA', NULL),
(13, 0, 'hcardona', '10:46:24', '2015-08-09', 'HECTORCARDONA', NULL),
(14, 0, 'hcardona', '10:49:14', '2015-08-09', 'HECTORCARDONA', NULL),
(15, 0, 'hcardona', '09:27:20', '2015-08-09', 'HECTORCARDONA', NULL),
(16, 0, 'hcardona', '09:47:37', '2015-08-09', 'HECTORCARDONA', NULL),
(17, 0, 'hcardona', '09:50:01', '2015-08-09', 'HECTORCARDONA', NULL),
(18, 0, 'hcardona', '09:50:56', '2015-08-09', 'HECTORCARDONA', NULL),
(19, 0, 'hcardona', '09:53:06', '2015-08-09', 'HECTORCARDONA', NULL),
(20, 0, 'hcardona', '09:59:16', '2015-08-09', 'HECTORCARDONA', NULL),
(21, 0, 'hcardona', '10:12:49', '2015-08-09', 'HECTORCARDONA', NULL),
(22, 0, 'llfldlsdf', '10:16:24', '2015-08-09', 'HECTORCARDONA', NULL),
(23, 0, 'Hcardona', '10:16:47', '2015-08-09', 'HECTORCARDONA', NULL),
(24, 0, 'hcardona', '10:22:15', '2015-08-09', 'HECTORCARDONA', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trhorario`
--

CREATE TABLE IF NOT EXISTS `trhorario` (
  `iidHorario` int(11) NOT NULL,
  `idSucursal` int(11) NOT NULL,
  `iidPelicula` int(11) NOT NULL,
  `inumerosala` int(5) DEFAULT NULL,
  `vtiposala` varchar(10) DEFAULT NULL,
  `dfecha` date DEFAULT NULL,
  `vestado` varchar(20) DEFAULT NULL,
  `thorainicio` time DEFAULT NULL,
  `thorafinal` time DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trhorario`
--

INSERT INTO `trhorario` (`iidHorario`, `idSucursal`, `iidPelicula`, `inumerosala`, `vtiposala`, `dfecha`, `vestado`, `thorainicio`, `thorafinal`) VALUES
(1, 1, 1, 3, '4D', '2015-08-15', 'Disponible', '06:00:00', '07:30:00'),
(3, 1, 3, 3, '4D', '2015-08-15', 'Disponible', '02:00:00', '03:30:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trreservacion`
--

CREATE TABLE IF NOT EXISTS `trreservacion` (
  `iidReservacion` int(11) NOT NULL,
  `iidHorario` int(11) DEFAULT NULL,
  `idSucursal` int(11) DEFAULT NULL,
  `iidPelicula` int(11) DEFAULT NULL,
  `iidCliente` int(11) DEFAULT NULL,
  `iestado` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trsala`
--

CREATE TABLE IF NOT EXISTS `trsala` (
  `iidSala` int(11) NOT NULL,
  `idSucursal` int(11) NOT NULL,
  `itipo` int(10) DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trsala`
--

INSERT INTO `trsala` (`iidSala`, `idSucursal`, `itipo`) VALUES
(3, 1, 1),
(4, 1, 1),
(5, 1, 1),
(8, 1, 1),
(9, 4, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trtarjeta`
--

CREATE TABLE IF NOT EXISTS `trtarjeta` (
  `iidTarjeta` int(11) NOT NULL,
  `iidCliente` int(11) NOT NULL,
  `vfechaCaducidad` varchar(30) DEFAULT NULL,
  `inumero` int(11) DEFAULT NULL,
  `vfechaEmision` varchar(10) DEFAULT NULL,
  `ipuntosAcumulados` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `maciudad`
--
ALTER TABLE `maciudad`
  ADD PRIMARY KEY (`iidCiudad`);

--
-- Indices de la tabla `macliente`
--
ALTER TABLE `macliente`
  ADD PRIMARY KEY (`iidCliente`);

--
-- Indices de la tabla `mafactura`
--
ALTER TABLE `mafactura`
  ADD PRIMARY KEY (`iidFactura`,`iidregistro`);

--
-- Indices de la tabla `mapelicula`
--
ALTER TABLE `mapelicula`
  ADD PRIMARY KEY (`iidpelicula`);

--
-- Indices de la tabla `maregistropersonal`
--
ALTER TABLE `maregistropersonal`
  ADD PRIMARY KEY (`iidregistro`);

--
-- Indices de la tabla `masucursal`
--
ALTER TABLE `masucursal`
  ADD PRIMARY KEY (`iidSucursal`);

--
-- Indices de la tabla `matiposala`
--
ALTER TABLE `matiposala`
  ADD PRIMARY KEY (`iidTipo`);

--
-- Indices de la tabla `trasientos`
--
ALTER TABLE `trasientos`
  ADD PRIMARY KEY (`iidAsiento`);

--
-- Indices de la tabla `trbitacora`
--
ALTER TABLE `trbitacora`
  ADD PRIMARY KEY (`iidBitacora`,`iidregistro`);

--
-- Indices de la tabla `trhorario`
--
ALTER TABLE `trhorario`
  ADD PRIMARY KEY (`iidHorario`,`idSucursal`,`iidPelicula`);

--
-- Indices de la tabla `trreservacion`
--
ALTER TABLE `trreservacion`
  ADD PRIMARY KEY (`iidReservacion`);

--
-- Indices de la tabla `trsala`
--
ALTER TABLE `trsala`
  ADD PRIMARY KEY (`iidSala`,`idSucursal`);

--
-- Indices de la tabla `trtarjeta`
--
ALTER TABLE `trtarjeta`
  ADD PRIMARY KEY (`iidTarjeta`,`iidCliente`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `maciudad`
--
ALTER TABLE `maciudad`
  MODIFY `iidCiudad` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `mapelicula`
--
ALTER TABLE `mapelicula`
  MODIFY `iidpelicula` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `maregistropersonal`
--
ALTER TABLE `maregistropersonal`
  MODIFY `iidregistro` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `masucursal`
--
ALTER TABLE `masucursal`
  MODIFY `iidSucursal` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT de la tabla `matiposala`
--
ALTER TABLE `matiposala`
  MODIFY `iidTipo` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `trasientos`
--
ALTER TABLE `trasientos`
  MODIFY `iidAsiento` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT de la tabla `trbitacora`
--
ALTER TABLE `trbitacora`
  MODIFY `iidBitacora` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT de la tabla `trhorario`
--
ALTER TABLE `trhorario`
  MODIFY `iidHorario` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT de la tabla `trsala`
--
ALTER TABLE `trsala`
  MODIFY `iidSala` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
