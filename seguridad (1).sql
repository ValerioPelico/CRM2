-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-11-2020 a las 04:13:00
-- Versión del servidor: 10.4.14-MariaDB
-- Versión de PHP: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `seguridad`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion`
--

CREATE TABLE `aplicacion` (
  `pk_id_aplicacion` int(10) NOT NULL,
  `fk_id_modulo` int(10) NOT NULL,
  `nombre_aplicacion` varchar(40) NOT NULL,
  `descripcion_aplicacion` varchar(45) NOT NULL,
  `estado_aplicacion` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion`
--

INSERT INTO `aplicacion` (`pk_id_aplicacion`, `fk_id_modulo`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1, 1, 'mantenimiento usuario', 'mantenimiento', 1),
(2, 1, 'mantenimiento usuario', 'mantenimiento', 1),
(3, 1, 'mantenimiento modulo', 'modulo', 1),
(4, 2, 'mantenimiento usuario', 'objeto', 1),
(5, 1, 'mantenimiento usuario', 'modulo', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion_perfil`
--

CREATE TABLE `aplicacion_perfil` (
  `pk_id_aplicacion_perfil` int(10) NOT NULL,
  `fk_idaplicacion_aplicacion_perfil` int(10) DEFAULT NULL,
  `fk_idperfil_aplicacion_perfil` int(10) DEFAULT NULL,
  `fk_idpermiso_aplicacion_perfil` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion_perfil`
--

INSERT INTO `aplicacion_perfil` (`pk_id_aplicacion_perfil`, `fk_idaplicacion_aplicacion_perfil`, `fk_idperfil_aplicacion_perfil`, `fk_idpermiso_aplicacion_perfil`) VALUES
(1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion_usuario`
--

CREATE TABLE `aplicacion_usuario` (
  `pk_id_aplicacion_usuario` int(10) NOT NULL,
  `fk_idlogin_aplicacion_usuario` int(10) DEFAULT NULL,
  `fk_idaplicacion_aplicacion_usuario` int(10) DEFAULT NULL,
  `fk_idpermiso_aplicacion_usuario` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `aplicacion_usuario`
--

INSERT INTO `aplicacion_usuario` (`pk_id_aplicacion_usuario`, `fk_idlogin_aplicacion_usuario`, `fk_idaplicacion_aplicacion_usuario`, `fk_idpermiso_aplicacion_usuario`) VALUES
(1, 1, 1, 1),
(2, 1, 1, 1),
(3, 1, 3, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `banco`
--

CREATE TABLE `banco` (
  `pk_idbanco` int(11) NOT NULL,
  `nombre_banco` varchar(50) NOT NULL,
  `estado_banco` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacora`
--

CREATE TABLE `bitacora` (
  `pk_id_bitacora` int(10) NOT NULL,
  `fk_idusuario_bitacora` int(10) DEFAULT NULL,
  `fk_idaplicacion_bitacora` int(10) DEFAULT NULL,
  `fechahora_bitacora` varchar(50) DEFAULT NULL,
  `direccionhost_bitacora` varchar(20) DEFAULT NULL,
  `nombrehost_bitacora` varchar(20) DEFAULT NULL,
  `accion_bitacora` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `bitacora`
--

INSERT INTO `bitacora` (`pk_id_bitacora`, `fk_idusuario_bitacora`, `fk_idaplicacion_bitacora`, `fechahora_bitacora`, `direccionhost_bitacora`, `nombrehost_bitacora`, `accion_bitacora`) VALUES
(1, 1, 1, '21-10-2020 15:49:33', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(2, 1, 1, '21-10-2020 15:53:48', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(3, 1, 1, '21-10-2020 15:55:16', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(4, 1, 1, '21-10-2020 16:00:59', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(6, 1, 1, '21-10-2020 16:02:57', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(7, 1, 1, '21-10-2020 16:06:43', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(8, 1, 1, '21-10-2020 16:10:25', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(9, 1, 1, '21-10-2020 16:18:07', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(10, 1, 1, '21-10-2020 16:21:16', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(11, 1, 1, '21-10-2020 16:36:41', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(12, 1, 3, '21-10-2020 16:36:41', '192.168.1.52', 'LAPTOP-OHKC0OF1', ' INSERT INTO modulo VALUES ( 2,  CRM,  mantenimiento,  1) '),
(13, 1, 1, '21-10-2020 16:38:28', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(14, 1, 2, '21-10-2020 16:38:28', '192.168.1.52', 'LAPTOP-OHKC0OF1', ' INSERT INTO login VALUES ( 2,  Bryan,  6789,  Bryan Mazariegos,  1) '),
(15, 1, 2, '21-10-2020 16:38:28', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'UPDATE login SET   usuario_login =  Bryan,  contraseña_login =  6789,  nombreCompleto_login =  Bryan Mazariegos,  estado_login =  0  WHERE pk_id_login = 2; '),
(16, 1, 1, '21-10-2020 16:52:37', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(17, 1, 2, '21-10-2020 16:52:37', '192.168.1.52', 'LAPTOP-OHKC0OF1', ' INSERT INTO login VALUES ( 3,  Valerio,  2255,  Valerio Pelico,  1) '),
(18, 1, 1, '21-10-2020 21:12:37', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(19, 1, 3, '21-10-2020 21:12:37', '192.168.1.52', 'LAPTOP-OHKC0OF1', ' INSERT INTO modulo VALUES ( 3,  SCM,  ahahshsah,  1) '),
(20, 1, 3, '21-10-2020 21:12:37', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'UPDATE modulo SET   nombre_modulo =  seguridad,  descripcion_modulo =  dasdasd,  estado_modulo =  0  WHERE pk_id_modulo = 1; '),
(21, 1, 3, '21-10-2020 21:12:37', '192.168.1.52', 'LAPTOP-OHKC0OF1', ' INSERT INTO modulo VALUES ( 4,  asdasd,  fdsfdsfsd,  1) '),
(22, 1, 3, '21-10-2020 21:12:37', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(23, 1, 1, '21-10-2020 21:16:52', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(24, 1, 2, '21-10-2020 21:16:52', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Refrescar Datos'),
(25, 1, 2, '21-10-2020 21:16:52', '192.168.1.52', 'LAPTOP-OHKC0OF1', ' INSERT INTO login VALUES ( 4,  Adolfo,  4567,  Adolfo Mota,  1) '),
(26, 1, 2, '21-10-2020 21:16:52', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(27, 1, 2, '21-10-2020 21:16:52', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(28, 1, 2, '21-10-2020 21:16:52', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(29, 1, 2, '21-10-2020 21:16:52', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(30, 1, 1, '22-10-2020 17:33:12', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(31, 1, 2, '22-10-2020 17:33:12', '192.168.1.52', 'LAPTOP-OHKC0OF1', ' INSERT INTO login VALUES ( 5,  Ester,  456,  Ester Guamuch,  1) '),
(32, 1, 2, '22-10-2020 17:33:12', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'UPDATE login SET   usuario_login =  Veronica,  contraseña_login =  456,  nombreCompleto_login =  Ester Guamuch,  estado_login =  1  WHERE pk_id_login = 5; '),
(33, 1, 2, '22-10-2020 17:33:12', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(34, 1, 1, '22-10-2020 17:38:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(35, 1, 2, '22-10-2020 17:38:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'UPDATE login SET   usuario_login =  Veronica,  contraseña_login =  456,  nombreCompleto_login =  Ester Guamuch,  estado_login =  0  WHERE pk_id_login = 5; '),
(36, 1, 2, '22-10-2020 17:38:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(37, 1, 1, '24-10-2020 21:18:49', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(38, 1, 2, '24-10-2020 21:18:49', '192.168.1.52', 'LAPTOP-OHKC0OF1', ' INSERT INTO login VALUES ( 6,  Esbegner,  789,  Esbegner Cuque,  1) '),
(39, 1, 2, '24-10-2020 21:18:49', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'UPDATE login SET   usuario_login =  Esbegner,  contraseña_login =  789,  nombreCompleto_login =  Esbegner López,  estado_login =  1  WHERE pk_id_login = 6; '),
(40, 1, 2, '24-10-2020 21:18:49', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Eliminacion de Datos'),
(41, 1, 2, '24-10-2020 21:18:49', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'UPDATE login SET estado_login=0 WHERE pk_id_login= 6 '),
(42, 1, 2, '24-10-2020 21:18:49', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(43, 1, 1, '24-10-2020 21:23:20', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(44, 1, 3, '24-10-2020 21:23:20', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(45, 1, 1, '27-10-2020 15:25:36', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(46, 1, 1, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(47, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(48, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(49, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(50, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(51, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(52, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(53, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(54, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(55, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(56, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(57, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(58, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(59, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(60, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(61, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(62, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(63, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(64, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(65, 1, 4, '27-10-2020 15:28:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(66, 1, 1, '27-10-2020 15:31:45', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(67, 1, 2, '27-10-2020 15:31:45', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(68, 1, 1, '27-10-2020 15:44:04', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(69, 1, 2, '27-10-2020 15:44:04', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(70, 1, 1, '27-10-2020 16:03:30', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(72, 1, 1, '27-10-2020 16:04:55', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(74, 1, 1, '27-10-2020 18:26:44', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(75, 1, 2, '27-10-2020 18:26:44', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(76, 1, 2, '27-10-2020 18:26:44', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(77, 1, 2, '27-10-2020 18:26:44', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(78, 1, 2, '27-10-2020 18:26:44', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(79, 1, 2, '27-10-2020 18:26:44', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(80, 1, 2, '27-10-2020 18:26:44', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(81, 1, 2, '27-10-2020 18:26:44', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(82, 1, 2, '27-10-2020 18:26:44', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Formulario de ayuda'),
(83, 1, 1, '29-10-2020 19:12:21', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(84, 1, 1, '29-10-2020 20:35:05', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(85, 1, 1, '31-10-2020 18:18:32', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(86, 1, 1, '31-10-2020 18:22:19', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(87, 1, 1, '31-10-2020 19:23:33', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo erroneo'),
(88, 1, 1, '31-10-2020 19:23:33', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo erroneo'),
(89, 1, 1, '31-10-2020 19:25:34', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo erroneo'),
(90, 1, 1, '31-10-2020 19:25:34', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo erroneo'),
(91, 1, 1, '31-10-2020 19:25:34', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo erroneo'),
(92, 1, 1, '31-10-2020 19:25:34', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo erroneo'),
(93, 1, 1, '31-10-2020 19:25:34', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo erroneo bloqueo de Usuario'),
(94, 1, 1, '31-10-2020 19:41:51', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo erroneo'),
(95, 1, 1, '31-10-2020 19:42:26', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo erroneo'),
(96, 1, 1, '31-10-2020 19:42:26', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo erroneo'),
(97, 1, 1, '31-10-2020 19:45:21', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(98, 1, 1, '31-10-2020 19:48:17', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(99, 1, 1, '31-10-2020 19:49:49', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(100, 1, 1, '31-10-2020 19:49:49', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(101, 1, 1, '31-10-2020 19:50:42', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(102, 1, 1, '31-10-2020 19:50:42', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Salir de la aplicacion'),
(103, 1, 1, '31-10-2020 20:45:39', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(104, 1, 1, '31-10-2020 20:50:29', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(105, 1, 1, '31-10-2020 20:51:37', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(106, 1, 1, '31-10-2020 20:54:08', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(107, 1, 1, '31-10-2020 20:55:58', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(108, 1, 1, '31-10-2020 20:58:41', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso'),
(109, 1, 1, '31-10-2020 20:59:52', '192.168.1.52', 'LAPTOP-OHKC0OF1', 'Logeo Exitoso');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `fecha` varchar(25) NOT NULL,
  `estado` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_bitacora`
--

CREATE TABLE `detalle_bitacora` (
  `pk_id_detalle_bitacora` int(10) NOT NULL,
  `fk_idbitacora_detalle_bitacora` int(10) DEFAULT NULL,
  `querryantigua_detalle_bitacora` varchar(50) DEFAULT NULL,
  `querrynueva_detalle_bitacora` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `login`
--

CREATE TABLE `login` (
  `pk_id_login` int(10) NOT NULL,
  `usuario_login` varchar(45) DEFAULT NULL,
  `contraseña_login` varchar(45) DEFAULT NULL,
  `nombreCompleto_login` varchar(100) DEFAULT NULL,
  `estado_login` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `login`
--

INSERT INTO `login` (`pk_id_login`, `usuario_login`, `contraseña_login`, `nombreCompleto_login`, `estado_login`) VALUES
(1, 'Dairyn', '12345', 'Dairyn López', 1),
(2, 'Bryan', '6789', 'Bryan Mazariegos', 0),
(3, 'Valerio', '2255', 'Valerio Pelico', 1),
(4, 'Adolfo', '4567', 'Adolfo Mota', 1),
(5, 'Veronica', '456', 'Ester Guamuch', 0),
(6, 'Esbegner', '789', 'Esbegner López', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulo`
--

CREATE TABLE `modulo` (
  `pk_id_modulo` int(10) NOT NULL,
  `nombre_modulo` varchar(30) NOT NULL,
  `descripcion_modulo` varchar(50) NOT NULL,
  `estado_modulo` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `modulo`
--

INSERT INTO `modulo` (`pk_id_modulo`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1, 'seguridad', 'mantenimiento', 1),
(2, 'CRM', 'mantenimiento', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedidos`
--

CREATE TABLE `pedidos` (
  `pk_idpedidos` int(10) NOT NULL,
  `fecha_pedido` date DEFAULT NULL,
  `nombre_pedido` varchar(45) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `idproducto` int(11) DEFAULT NULL,
  `estado_pedido` int(11) DEFAULT NULL,
  `idempleado` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE `perfil` (
  `pk_id_perfil` int(10) NOT NULL,
  `nombre_perfil` varchar(50) DEFAULT NULL,
  `descripcion_perfil` varchar(100) DEFAULT NULL,
  `estado_perfil` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'adsa', 'asdsad', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil_usuario`
--

CREATE TABLE `perfil_usuario` (
  `pk_id_perfil_usuario` int(10) NOT NULL,
  `fk_idusuario_perfil_usuario` int(10) DEFAULT NULL,
  `fk_idperfil_perfil_usuario` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `perfil_usuario`
--

INSERT INTO `perfil_usuario` (`pk_id_perfil_usuario`, `fk_idusuario_perfil_usuario`, `fk_idperfil_perfil_usuario`) VALUES
(1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `permiso`
--

CREATE TABLE `permiso` (
  `pk_id_permiso` int(10) NOT NULL,
  `insertar_permiso` tinyint(1) DEFAULT NULL,
  `modificar_permiso` tinyint(1) DEFAULT NULL,
  `eliminar_permiso` tinyint(1) DEFAULT NULL,
  `consultar_permiso` tinyint(1) DEFAULT NULL,
  `imprimir_permiso` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `permiso`
--

INSERT INTO `permiso` (`pk_id_permiso`, `insertar_permiso`, `modificar_permiso`, `eliminar_permiso`, `consultar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1, 1, 1, 1),
(2, 1, 1, 1, 1, 1),
(3, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vendedor`
--

CREATE TABLE `vendedor` (
  `pk_idvendedor` int(10) NOT NULL,
  `horas_extras` int(11) DEFAULT NULL,
  `comisiones` double DEFAULT NULL,
  `venta` double DEFAULT NULL,
  `estado` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD PRIMARY KEY (`pk_id_aplicacion`),
  ADD KEY `pk_id_aplicacion` (`pk_id_aplicacion`),
  ADD KEY `fk_aplicativo_modulo` (`fk_id_modulo`);

--
-- Indices de la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  ADD PRIMARY KEY (`pk_id_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_aplicacion` (`fk_idaplicacion_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_perfil` (`fk_idperfil_aplicacion_perfil`),
  ADD KEY `fk_aplicacionperfil_permiso` (`fk_idpermiso_aplicacion_perfil`);

--
-- Indices de la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  ADD PRIMARY KEY (`pk_id_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_login` (`fk_idlogin_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_aplicacion` (`fk_idaplicacion_aplicacion_usuario`),
  ADD KEY `fk_aplicacionusuario_permiso` (`fk_idpermiso_aplicacion_usuario`);

--
-- Indices de la tabla `banco`
--
ALTER TABLE `banco`
  ADD PRIMARY KEY (`pk_idbanco`);

--
-- Indices de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD PRIMARY KEY (`pk_id_bitacora`),
  ADD KEY `fk_login_bitacora` (`fk_idusuario_bitacora`),
  ADD KEY `fk_aplicacion_bitacora` (`fk_idaplicacion_bitacora`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `detalle_bitacora`
--
ALTER TABLE `detalle_bitacora`
  ADD PRIMARY KEY (`pk_id_detalle_bitacora`),
  ADD KEY `fk_bitacora_detallebitacora` (`fk_idbitacora_detalle_bitacora`);

--
-- Indices de la tabla `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`pk_id_login`);

--
-- Indices de la tabla `modulo`
--
ALTER TABLE `modulo`
  ADD PRIMARY KEY (`pk_id_modulo`),
  ADD KEY `pk_id_modulo` (`pk_id_modulo`);

--
-- Indices de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  ADD PRIMARY KEY (`pk_idpedidos`),
  ADD KEY `pk_idpedidos` (`pk_idpedidos`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`pk_id_perfil`);

--
-- Indices de la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  ADD PRIMARY KEY (`pk_id_perfil_usuario`),
  ADD KEY `fk_perfil_usuario_login` (`fk_idusuario_perfil_usuario`),
  ADD KEY `fk_perfil_usuario_perfil` (`fk_idperfil_perfil_usuario`);

--
-- Indices de la tabla `permiso`
--
ALTER TABLE `permiso`
  ADD PRIMARY KEY (`pk_id_permiso`);

--
-- Indices de la tabla `vendedor`
--
ALTER TABLE `vendedor`
  ADD PRIMARY KEY (`pk_idvendedor`),
  ADD KEY `pk_idvendedor` (`pk_idvendedor`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  MODIFY `pk_id_aplicacion` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  MODIFY `pk_id_aplicacion_perfil` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  MODIFY `pk_id_aplicacion_usuario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `banco`
--
ALTER TABLE `banco`
  MODIFY `pk_idbanco` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `bitacora`
--
ALTER TABLE `bitacora`
  MODIFY `pk_id_bitacora` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=110;

--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `detalle_bitacora`
--
ALTER TABLE `detalle_bitacora`
  MODIFY `pk_id_detalle_bitacora` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `login`
--
ALTER TABLE `login`
  MODIFY `pk_id_login` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `modulo`
--
ALTER TABLE `modulo`
  MODIFY `pk_id_modulo` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `pedidos`
--
ALTER TABLE `pedidos`
  MODIFY `pk_idpedidos` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `perfil`
--
ALTER TABLE `perfil`
  MODIFY `pk_id_perfil` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  MODIFY `pk_id_perfil_usuario` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `permiso`
--
ALTER TABLE `permiso`
  MODIFY `pk_id_permiso` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `vendedor`
--
ALTER TABLE `vendedor`
  MODIFY `pk_idvendedor` int(10) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD CONSTRAINT `fk_aplicativo_modulo` FOREIGN KEY (`fk_id_modulo`) REFERENCES `modulo` (`pk_id_modulo`);

--
-- Filtros para la tabla `aplicacion_perfil`
--
ALTER TABLE `aplicacion_perfil`
  ADD CONSTRAINT `fk_aplicacionperfil_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_perfil`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionperfil_perfil` FOREIGN KEY (`fk_idperfil_aplicacion_perfil`) REFERENCES `perfil` (`pk_id_perfil`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionperfil_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_perfil`) REFERENCES `permiso` (`pk_id_permiso`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `aplicacion_usuario`
--
ALTER TABLE `aplicacion_usuario`
  ADD CONSTRAINT `fk_aplicacionusuario_aplicacion` FOREIGN KEY (`fk_idaplicacion_aplicacion_usuario`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionusuario_login` FOREIGN KEY (`fk_idlogin_aplicacion_usuario`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_aplicacionusuario_permiso` FOREIGN KEY (`fk_idpermiso_aplicacion_usuario`) REFERENCES `permiso` (`pk_id_permiso`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `bitacora`
--
ALTER TABLE `bitacora`
  ADD CONSTRAINT `fk_aplicacion_bitacora` FOREIGN KEY (`fk_idaplicacion_bitacora`) REFERENCES `aplicacion` (`pk_id_aplicacion`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_login_bitacora` FOREIGN KEY (`fk_idusuario_bitacora`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `detalle_bitacora`
--
ALTER TABLE `detalle_bitacora`
  ADD CONSTRAINT `fk_bitacora_detallebitacora` FOREIGN KEY (`fk_idbitacora_detalle_bitacora`) REFERENCES `bitacora` (`pk_id_bitacora`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `perfil_usuario`
--
ALTER TABLE `perfil_usuario`
  ADD CONSTRAINT `fk_perfil_usuario_login` FOREIGN KEY (`fk_idusuario_perfil_usuario`) REFERENCES `login` (`pk_id_login`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_perfil_usuario_perfil` FOREIGN KEY (`fk_idperfil_perfil_usuario`) REFERENCES `perfil` (`pk_id_perfil`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
