SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Table `finanzas`.`TBL_tipo_activo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_tipo_activo` (
  `id_tipoactivo` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Nombre_tipoactivo` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `estatus` INT NULL COMMENT '',
  PRIMARY KEY (`id_tipoactivo`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_activos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_activos` (
  `id_activo` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FechaIngreso_Activos` DATE NOT NULL COMMENT '',
  `Cantidad_Activos` INT(11) NOT NULL COMMENT '',
  `Descripcion_Activos` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FechaActual_Activos` DATE NOT NULL COMMENT '',
  `ValorInicial_Activos` FLOAT NOT NULL COMMENT '',
  `fk_id_tipoactivo` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `VidaUtil_Activo` INT(3) NULL COMMENT '',
  PRIMARY KEY (`id_activo`)  COMMENT '',
  INDEX `id_tipoactivo` (`fk_id_tipoactivo` ASC)  COMMENT '',
  CONSTRAINT `ACTIVOS_ibfk_1`
    FOREIGN KEY (`fk_id_tipoactivo`)
    REFERENCES `finanzas`.`TBL_tipo_activo` (`id_tipoactivo`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_tipo_cuenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_tipo_cuenta` (
  `id_tipo` INT(11) NOT NULL COMMENT '',
  `Nombre_tipo` VARCHAR(20) NOT NULL COMMENT '',
  PRIMARY KEY (`id_tipo`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_catalogo_cuentas_Contables`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_catalogo_cuentas_Contables` (
  `id_cuenta` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Nombre_cuenta` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Tipo_cuenta` INT(100) NOT NULL COMMENT '',
  `Cargo` FLOAT NOT NULL COMMENT '',
  `Cargo_acumulado` FLOAT NOT NULL COMMENT '',
  `Abono` FLOAT NULL COMMENT '',
  `Abono_acumulado` FLOAT NULL COMMENT '',
  `Saldo_Anterior` FLOAT NULL COMMENT '',
  `Saldo_Actual` FLOAT NULL COMMENT '',
  `Fecha` DATETIME NULL COMMENT '',
  `estatus` VARCHAR(45) NULL COMMENT '',
  PRIMARY KEY (`id_cuenta`)  COMMENT '',
  INDEX `Tipo_cuenta` (`Tipo_cuenta` ASC)  COMMENT '',
  CONSTRAINT `catalogo_cuentas_ibfk_1`
    FOREIGN KEY (`Tipo_cuenta`)
    REFERENCES `finanzas`.`TBL_tipo_cuenta` (`id_tipo`))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `finanzas`.`back_up_cierre_cuenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`back_up_cierre_cuenta` (
  `id_back_up` INT(11) NOT NULL COMMENT '',
  `id_cuenta` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `cargo` FLOAT NOT NULL COMMENT '',
  `cargo_acumulado` FLOAT NOT NULL COMMENT '',
  `abono` FLOAT NOT NULL COMMENT '',
  `abono_acumulado` FLOAT NOT NULL COMMENT '',
  `saldo_anterior` FLOAT NOT NULL COMMENT '',
  `saldo_actual` FLOAT NOT NULL COMMENT '',
  `fecha` DATETIME NOT NULL COMMENT '',
  PRIMARY KEY (`id_back_up`, `fecha`)  COMMENT '',
  INDEX `id_cuenta` (`id_cuenta` ASC)  COMMENT '',
  CONSTRAINT `back_up_cierre_cuenta_ibfk_1`
    FOREIGN KEY (`id_cuenta`)
    REFERENCES `finanzas`.`TBL_catalogo_cuentas_Contables` (`id_cuenta`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_moneda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_moneda` (
  `id_moneda` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Nombre_moneda` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Abreviatura_moneda` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `TipoCambio_moneda` FLOAT NOT NULL COMMENT '',
  `estatus` INT NOT NULL COMMENT '',
  PRIMARY KEY (`id_moneda`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_banco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_banco` (
  `idTBL_Banco` VARCHAR(10) NOT NULL COMMENT '',
  `nombreBanco` VARCHAR(45) NULL COMMENT '',
  `estatus` INT NULL COMMENT '',
  PRIMARY KEY (`idTBL_Banco`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_cuenta_bancaria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_cuenta_bancaria` (
  `no_cuentabancaria` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FK_id_banco` VARCHAR(10) NOT NULL COMMENT '',
  `Nombre_cuentabancaria` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Saldo_cuentabancaria` FLOAT NULL COMMENT '',
  `estatus` INT NULL COMMENT '',
  PRIMARY KEY (`no_cuentabancaria`)  COMMENT '',
  INDEX `fk_TBL_cuenta_bancaria_TBL_banco1_idx` (`FK_id_banco` ASC)  COMMENT '',
  CONSTRAINT `FK_id_banco`
    FOREIGN KEY (`FK_id_banco`)
    REFERENCES `finanzas`.`TBL_banco` (`idTBL_Banco`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_cheque`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_cheque` (
  `no_cheque` INT(10) NOT NULL COMMENT '',
  `FK_no_cuentabancaria` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Fecha_cheque` DATE NOT NULL COMMENT '',
  `FK_id_moneda` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Monto_cheque` FLOAT NOT NULL COMMENT '',
  `Concepto_cheque` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Beneficiario_cheque` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `estatus` INT NULL COMMENT '',
  PRIMARY KEY (`no_cheque`)  COMMENT '',
  INDEX `id_moneda` (`FK_id_moneda` ASC)  COMMENT '',
  INDEX `fk_cheque_cuenta_bancaria1_idx` (`FK_no_cuentabancaria` ASC)  COMMENT '',
  CONSTRAINT `CHEQUE_ibfk_1`
    FOREIGN KEY (`FK_id_moneda`)
    REFERENCES `finanzas`.`TBL_moneda` (`id_moneda`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_cheque_cuenta_bancaria1`
    FOREIGN KEY (`FK_no_cuentabancaria`)
    REFERENCES `finanzas`.`TBL_cuenta_bancaria` (`no_cuentabancaria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_concepto_bancario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_concepto_bancario` (
  `id_concepto` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Tipo_concepto` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Abono_Cargo` TINYINT(1) NULL COMMENT '',
  `estatus` INT NULL COMMENT '',
  PRIMARY KEY (`id_concepto`)  COMMENT '')
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `finanzas`.`TBL_detalle_activos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_detalle_activos` (
  `id_detalleactivo` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `fk_id_activo` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `fk_id_inventario` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `fk_id_empleado` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Depreciacion_detalleactivos` FLOAT NULL DEFAULT NULL COMMENT '',
  `Amortizacion_detalleactivos` FLOAT NULL COMMENT '',
  `estatus` INT NOT NULL COMMENT '',
  PRIMARY KEY (`id_detalleactivo`)  COMMENT '',
  INDEX `id_activo` (`fk_id_activo` ASC)  COMMENT '',
  INDEX `id_inventario` (`fk_id_inventario` ASC)  COMMENT '',
  CONSTRAINT `DETALLE_ACTIVO_ibfk_1`
    FOREIGN KEY (`fk_id_activo`)
    REFERENCES `finanzas`.`TBL_activos` (`id_activo`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_encabezado_balance`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_encabezado_balance` (
  `id_balance` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FechaActual_balance` DATE NOT NULL COMMENT '',
  `id_moneda` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `total_balance` FLOAT NOT NULL COMMENT '',
  `estatus` INT NULL COMMENT '',
  PRIMARY KEY (`id_balance`)  COMMENT '',
  INDEX `id_moneda` (`id_moneda` ASC)  COMMENT '',
  CONSTRAINT `ENCABEZADO_BALANCE_ibfk_1`
    FOREIGN KEY (`id_moneda`)
    REFERENCES `finanzas`.`TBL_moneda` (`id_moneda`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_detalle_balance`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_detalle_balance` (
  `id_balance` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FK_id_cuenta` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Monto_cuenta` FLOAT NOT NULL COMMENT '',
  `Debe_balance` FLOAT NULL DEFAULT NULL COMMENT '',
  `Haber_balance` FLOAT NULL DEFAULT NULL COMMENT '',
  PRIMARY KEY (`id_balance`)  COMMENT '',
  INDEX `id_balance` (`id_balance` ASC)  COMMENT '',
  INDEX `id_cuenta` (`FK_id_cuenta` ASC)  COMMENT '',
  CONSTRAINT `DETALLE_BALANCE_ibfk_1`
    FOREIGN KEY (`id_balance`)
    REFERENCES `finanzas`.`TBL_encabezado_balance` (`id_balance`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `DETALLE_BALANCE_ibfk_2`
    FOREIGN KEY (`FK_id_cuenta`)
    REFERENCES `finanzas`.`TBL_catalogo_cuentas_Contables` (`id_cuenta`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_encabezado_movimiento_bancario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_encabezado_movimiento_bancario` (
  `id_encmovimientobancario` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FK_no_cuentabancaria` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `SaldoDeCuenta` FLOAT NOT NULL COMMENT '',
  `Conciliado` TINYINT(1) NULL COMMENT '',
  `estatus` INT NULL COMMENT '',
  PRIMARY KEY (`id_encmovimientobancario`)  COMMENT '',
  INDEX `fk_TBL_encabezado_movimiento_bancario_TBL_cuenta_bancaria1_idx` (`FK_no_cuentabancaria` ASC)  COMMENT '',
  CONSTRAINT `fk_TBL_encabezado_movimiento_bancario_TBL_cuenta_bancaria1`
    FOREIGN KEY (`FK_no_cuentabancaria`)
    REFERENCES `finanzas`.`TBL_cuenta_bancaria` (`no_cuentabancaria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_detalle_movimiento_bancario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_detalle_movimiento_bancario` (
  `id_detallemovbancario` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FK_id_encabezadoMVBancario` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FK_id_concepto` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `nombre_Concepto` VARCHAR(45) NULL COMMENT '',
  `Descripcion_detallemovbancario` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FechaActual_detallemovbancario` DATE NOT NULL COMMENT '',
  PRIMARY KEY (`id_detallemovbancario`)  COMMENT '',
  INDEX `id_concepto` (`FK_id_concepto` ASC)  COMMENT '',
  INDEX `fk_detalle_mov_bancario_encabezado_movimiento_bancario1_idx` (`FK_id_encabezadoMVBancario` ASC)  COMMENT '',
  CONSTRAINT `DETALLE_MOV_BANCARIOS_ibfk_1`
    FOREIGN KEY (`FK_id_concepto`)
    REFERENCES `finanzas`.`TBL_concepto_bancario` (`id_concepto`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_detalle_mov_bancario_encabezado_movimiento_bancario1`
    FOREIGN KEY (`FK_id_encabezadoMVBancario`)
    REFERENCES `finanzas`.`TBL_encabezado_movimiento_bancario` (`id_encmovimientobancario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `finanzas`.`TBL_encabezado_poliza`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_encabezado_poliza` (
  `id_poliza` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FechaActual_poliza` DATE NOT NULL COMMENT '',
  `Total_poliza` FLOAT NOT NULL COMMENT '',
  `estatus` INT NULL COMMENT '',
  PRIMARY KEY (`id_poliza`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_detalle_poliza`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_detalle_poliza` (
  `id_detallepoliza` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FK_id_poliza` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `FK_id_cuenta` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `NombreCuenta_detapoliza` VARCHAR(100) NULL COMMENT '',
  `Cargo_detallepoliza` FLOAT NULL DEFAULT NULL COMMENT '',
  `Abono_detallepoliza` FLOAT NULL DEFAULT NULL COMMENT '',
  PRIMARY KEY (`id_detallepoliza`)  COMMENT '',
  INDEX `id_poliza` (`FK_id_poliza` ASC)  COMMENT '',
  INDEX `fk_TBL_detalle_poliza_TBL_catalogo_cuentas1_idx` (`FK_id_cuenta` ASC)  COMMENT '',
  CONSTRAINT `DETALLE_POLIZA_ibfk_1`
    FOREIGN KEY (`FK_id_poliza`)
    REFERENCES `finanzas`.`TBL_encabezado_poliza` (`id_poliza`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_TBL_detalle_poliza_TBL_catalogo_cuentas1`
    FOREIGN KEY (`FK_id_cuenta`)
    REFERENCES `finanzas`.`TBL_catalogo_cuentas_Contables` (`id_cuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_encabezado_presupuesto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_encabezado_presupuesto` (
  `id_encabezado_presupuesto` INT(11) NOT NULL COMMENT '',
  `id_departamento` INT(11) NOT NULL COMMENT '',
  `fecha` DATETIME NOT NULL COMMENT '',
  PRIMARY KEY (`id_encabezado_presupuesto`)  COMMENT '',
  INDEX `id_departamento` (`id_departamento` ASC)  COMMENT '')
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `finanzas`.`TBL_detalle_presupuesto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_detalle_presupuesto` (
  `id_detalle_presupuesto` INT(45) NOT NULL COMMENT '',
  `id_presupuesto_encabezado` INT(45) NOT NULL COMMENT '',
  `id_cuenta` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `monto_presupuestado` DOUBLE NOT NULL COMMENT '',
  `fecha` DATETIME NULL COMMENT '',
  PRIMARY KEY (`id_detalle_presupuesto`)  COMMENT '',
  INDEX `id_presupuesto_encabezado` (`id_presupuesto_encabezado` ASC, `id_cuenta` ASC)  COMMENT '',
  INDEX `id_cuenta` (`id_cuenta` ASC)  COMMENT '',
  CONSTRAINT `detalle_presupuesto_ibfk_1`
    FOREIGN KEY (`id_presupuesto_encabezado`)
    REFERENCES `finanzas`.`TBL_encabezado_presupuesto` (`id_encabezado_presupuesto`),
  CONSTRAINT `detalle_presupuesto_ibfk_2`
    FOREIGN KEY (`id_cuenta`)
    REFERENCES `finanzas`.`TBL_catalogo_cuentas_Contables` (`id_cuenta`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_disponibilidad_diaria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_disponibilidad_diaria` (
  `id_disponibilidaddiaria` INT(11) NOT NULL COMMENT '',
  `FK_no_cuentabancaria` VARCHAR(10) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Fecha_disponibilidad` INT(11) NOT NULL COMMENT '',
  `Saldo_cuentabancarias` FLOAT NOT NULL COMMENT '',
  `estatus` INT NULL COMMENT '',
  PRIMARY KEY (`id_disponibilidaddiaria`)  COMMENT '',
  INDEX `fk_TBL_disponibilidad_diaria_TBL_cuenta_bancaria1_idx` (`FK_no_cuentabancaria` ASC)  COMMENT '',
  CONSTRAINT `fk_TBL_disponibilidad_diaria_TBL_cuenta_bancaria1`
    FOREIGN KEY (`FK_no_cuentabancaria`)
    REFERENCES `finanzas`.`TBL_cuenta_bancaria` (`no_cuentabancaria`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `finanzas`.`TBL_autorizacion_compra`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_autorizacion_compra` (
  `id_procesoautorizacioncompra` INT(11) NOT NULL COMMENT '',
  `Encargado_procesoautorizacioncompra` VARCHAR(45) CHARACTER SET 'utf8mb4' NOT NULL COMMENT '',
  `Operacion_procesoautorizacioncompra` VARCHAR(45) CHARACTER SET 'utf8mb4' NOT NULL COMMENT '',
  `Fecha_procesoautorizacioncompra` DATE NOT NULL COMMENT '',
  `numeroorden_ordendecompraencabezado` INT(11) NOT NULL COMMENT '',
  `id_Empleados` INT(11) NOT NULL COMMENT '',
  `total_procesoautorizacioncompra` INT(11) NOT NULL COMMENT '',
  PRIMARY KEY (`id_procesoautorizacioncompra`)  COMMENT '',
  INDEX `idEmpleados` (`id_Empleados` ASC)  COMMENT '',
  INDEX `Numero_de_Orden` (`numeroorden_ordendecompraencabezado` ASC)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_encabezado_estado_resultados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_encabezado_estado_resultados` (
  `no_encEstadoResultados` VARCHAR(10) NOT NULL COMMENT '',
  `FechaActual_encEstadoResultados` DATETIME NULL COMMENT '',
  `Total_encEstadoResultados` INT(100) NULL COMMENT '',
  `estatus` INT NULL COMMENT '',
  PRIMARY KEY (`no_encEstadoResultados`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `finanzas`.`TBL_detalle_estado_resultados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `finanzas`.`TBL_detalle_estado_resultados` (
  `id_detaEstadoResultados` INT NOT NULL COMMENT '',
  `FK_noEncEstadoResultados` VARCHAR(10) NOT NULL COMMENT '',
  `FK_id_cuenta` VARCHAR(100) CHARACTER SET 'utf8' COLLATE 'utf8_spanish_ci' NOT NULL COMMENT '',
  `Cargo_detaEstadoResultados` VARCHAR(45) NULL COMMENT '',
  `Abono_detaEstadoResultados` VARCHAR(45) NULL COMMENT '',
  `NombreCuenta_detaER` VARCHAR(100) NULL COMMENT '',
  PRIMARY KEY (`id_detaEstadoResultados`)  COMMENT '',
  INDEX `fk_TBL_detalle_estado_resultados_TBL_encabezado_estado_resu_idx` (`FK_noEncEstadoResultados` ASC)  COMMENT '',
  INDEX `fk_TBL_detalle_estado_resultados_TBL_catalogo_cuentas1_idx` (`FK_id_cuenta` ASC)  COMMENT '',
  CONSTRAINT `fk_TBL_detalle_estado_resultados_TBL_encabezado_estado_result1`
    FOREIGN KEY (`FK_noEncEstadoResultados`)
    REFERENCES `finanzas`.`TBL_encabezado_estado_resultados` (`no_encEstadoResultados`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TBL_detalle_estado_resultados_TBL_catalogo_cuentas1`
    FOREIGN KEY (`FK_id_cuenta`)
    REFERENCES `finanzas`.`TBL_catalogo_cuentas_Contables` (`id_cuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
