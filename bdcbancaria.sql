-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-10-2025 a las 22:40:54
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdcbancaria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cheque`
--

CREATE TABLE `cheque` (
  `id_cheque` int(11) NOT NULL,
  `numero_cheque` varchar(50) NOT NULL,
  `fecha_cheque` date NOT NULL,
  `codigo_proveedor` varchar(5) DEFAULT NULL,
  `monto_numerico` decimal(12,2) NOT NULL,
  `monto_letras` varchar(255) DEFAULT NULL,
  `detalle` text DEFAULT NULL,
  `codigo_objeto_gasto` varchar(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `conciliacion`
--

CREATE TABLE `conciliacion` (
  `id_conciliacion` int(11) NOT NULL,
  `saldo_libros` decimal(12,2) NOT NULL,
  `depositos_transito` decimal(12,2) DEFAULT 0.00,
  `cheques_pendientes` decimal(12,2) DEFAULT 0.00,
  `saldo_bancario` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `depositos`
--

CREATE TABLE `depositos` (
  `id_deposito` int(11) NOT NULL,
  `tipo_deposito` enum('Transferencia','Depósito directo') NOT NULL,
  `fecha_deposito` date NOT NULL,
  `monto` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `objeto_gasto`
--

CREATE TABLE `objeto_gasto` (
  `codigo` varchar(3) NOT NULL,
  `detalle` varchar(150) NOT NULL,
  `objeto` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `objeto_gasto`
--

INSERT INTO `objeto_gasto` (`codigo`, `detalle`, `objeto`) VALUES
('120', 'Impresión, Encuadernación y otros', '1'),
('130', 'Información y Publicidad', '1'),
('141', 'Viáticos dentro del país', '1'),
('151', 'Transporte dentro del país', '1'),
('169', 'Otros Servicios', '1'),
('180', 'Mantenimiento y Reparación', '1'),
('181', 'Mantenimiento y Reparación de Edificios', '1'),
('182', 'Mantenimiento de Maquinarias y Otros Equipos', '1'),
('183', 'Mantenimiento de Mobiliario y Equipo de Oficina', '1'),
('185', 'Mantenimiento de Equipos de Computación', '1'),
('189', 'Otros Mantenimientos y Reparaciones', '1'),
('200', 'Alimentos y Bebidas', '2'),
('210', 'Textiles y Vestuarios', '2'),
('220', 'Combustibles y Lubricantes', '2'),
('230', 'Productos de Papel y Cartón ', '2'),
('240', 'Productos Químicos y Conexos', '2'),
('250', 'Otros Materiales de Construcción', '2'),
('260', 'Productos Varios', '2'),
('262', 'Herramientas', '2'),
('265', 'Materiales, Accesorios y Suministros de Computación', '2'),
('270', 'Útiles y Materiales Diversos', '2'),
('280', 'Repuestos', '2'),
('320', 'Equipo Educacional y Recreativo', '3'),
('340', 'Equipo de Oficina', '3'),
('350', 'Mobiliario de Oficina', '3'),
('370', 'Maquinarias y Equipos Varios', '3'),
('380', 'Equipo de Computación', '3');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `codigo` varchar(5) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `ruc` varchar(100) DEFAULT NULL,
  `direccion` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`codigo`, `nombre`, `ruc`, `direccion`) VALUES
('00001', 'ÓPTICA SOSA Y ARANGO, S.A.', '', ''),
('00003', 'CARILO, S.A.', '', ''),
('00006', 'AGENCIA SKY', '', ''),
('00007', 'SENTOSA CORPORACIÓN, S.A.', '', ''),
('00008', 'GILMIR BUSINESS, S.A.', '', ''),
('00009', 'OFIHOGAR, S.A.', '', ''),
('00010', 'GRUPO BARSASH, S.A.', '', ''),
('00011', 'CORPORACIÓN LAS ANTILLAS', '', ''),
('00012', 'INVERSIONES TEALIS, S.A.', '', ''),
('00013', 'SUPER-PLAS', '', ''),
('00014', 'SERVICIOS COMERCIALES Y TÉCNICOS', '', ''),
('00015', 'PANDATA SERVICE INC.', '', ''),
('00017', 'DIGITEC', '', ''),
('00018', 'IPHE', '', ''),
('00019', 'DISTRIBUIDORA MUSICAL, S.A.', '', ''),
('00020', 'IMPORTADORA MC', '', ''),
('00021', 'INVERSIONES RAMA', '', ''),
('00022', 'JELLINI', '', ''),
('00023', 'OLIMPUS COMMERCIAL CORPORATION', '', ''),
('00024', 'ASOCIADOS TENNOVA', '', ''),
('00026', 'BARYAN, S.A.', '', ''),
('00027', 'MASTER DIRECT PANAMÁ, S.A.', '', ''),
('00028', 'OMICRON PANAMÁ CORPORATION', '', ''),
('00029', 'Sistemas y Soluciones Mag', '', 'La Chorrera'),
('00030', 'MULTIFRIO PANAMÁ GROUP S.A.', '', ''),
('00031', 'INDUSTRIA PANAMEÑA DE PLASTICO S.A.', '', ''),
('00032', 'B.H. CORP, S.A.', '', ''),
('00033', 'COMERCIALIZADORA SELECTA, S.A.', '', ''),
('00034', 'ASOCIADOS TERRANOVA, S.A.', '', ''),
('00035', 'MODERNA COMERCIAL, S.A.', '', ''),
('00036', 'PROLAT', '', ''),
('00037', 'MUEBLERIA Y JOYERIA CENTROAMERICANA, S.A.', '', ''),
('00038', 'CRISTOBAL JOVILLA RIOS', '', ''),
('00039', 'ROMERO VENDING', '', ''),
('00040', 'ALEXANDER AROSEMENA', '', ''),
('00041', 'YANIS MORAN', '', ''),
('00042', 'MANEKI-NEKO', '', ''),
('00043', 'NEXCO                                   ', '', ''),
('00044', 'PRUEBA', '854-PF', 'Panamá Oeste'),
('00045', 'INVERSIONES EDSEDA COMPANY, S.A.', '', ''),
('00046', 'DISTINTIVOS Y ACCESORIOS, S.A.', '', ''),
('00047', 'ROLANDO BARRIA', '', ''),
('00048', 'SUPERMERCADO FEUILLET', '', ''),
('00049', 'VISIONARTE PROMOCIÓN Y PUBLICIDAD', '', ''),
('00050', 'FRIO EXPRESS PANAMA', '', ''),
('00051', 'GLOBAL BUSINESS SOLUTION - GLOBUS', '', ''),
('00052', 'SUPER STARS COMPUTERS ', '', ''),
('00053', 'INGENIEROS, DESARROLLADORES, ESTRATEGICOS, GLOBALES, S.A.', '', ''),
('00054', 'Selma Yussara Barakat', '', ''),
('00055', 'Ingeniería Electromecánica Especializada, S.A.', '', ''),
('00056', 'Deportes Jimmy, S.A.', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `id_usuario` int(11) NOT NULL,
  `email` varchar(100) NOT NULL,
  `contraseña` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cheque`
--
ALTER TABLE `cheque`
  ADD PRIMARY KEY (`id_cheque`),
  ADD UNIQUE KEY `numero_cheque` (`numero_cheque`),
  ADD KEY `codigo_proveedor` (`codigo_proveedor`),
  ADD KEY `codigo_objeto_gasto` (`codigo_objeto_gasto`);

--
-- Indices de la tabla `conciliacion`
--
ALTER TABLE `conciliacion`
  ADD PRIMARY KEY (`id_conciliacion`);

--
-- Indices de la tabla `depositos`
--
ALTER TABLE `depositos`
  ADD PRIMARY KEY (`id_deposito`);

--
-- Indices de la tabla `objeto_gasto`
--
ALTER TABLE `objeto_gasto`
  ADD UNIQUE KEY `codigo` (`codigo`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD UNIQUE KEY `codigo` (`codigo`) USING BTREE;

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cheque`
--
ALTER TABLE `cheque`
  MODIFY `id_cheque` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `conciliacion`
--
ALTER TABLE `conciliacion`
  MODIFY `id_conciliacion` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `depositos`
--
ALTER TABLE `depositos`
  MODIFY `id_deposito` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cheque`
--
ALTER TABLE `cheque`
  ADD CONSTRAINT `cheque_ibfk_1` FOREIGN KEY (`codigo_proveedor`) REFERENCES `proveedores` (`codigo`),
  ADD CONSTRAINT `cheque_ibfk_2` FOREIGN KEY (`codigo_objeto_gasto`) REFERENCES `objeto_gasto` (`codigo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
