CREATE DATABASE examenFinal;
USE examenFinal;
-- -----------------------------------------------------
-- Table banco
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS banco (
  `pkIdBanco` VARCHAR(15) NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `direccion` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  PRIMARY KEY (`pkIdBanco`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table cuentaBancaria
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS cuentaBancaria (
  `pkIdcuenta` VARCHAR(15) NOT NULL,
  `cuenta` VARCHAR(45) NULL,
  `usuario` VARCHAR(45) NULL,
  `fechaApertura` DATETIME NULL,
  `estado` VARCHAR(45) NULL,
  PRIMARY KEY (`pkIdcuenta`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table cuentaContable
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS cuentaContable (
  `pkIdCuentaContable` VARCHAR(15) NOT NULL,
  `tipoCuenta` VARCHAR(45) NULL,
  `naturaleza` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  `cuentaContablecol` VARCHAR(45) NULL,
  PRIMARY KEY (`pkIdCuentaContable`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table tipoMovimiento
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS tipoMovimiento (
  `pkIdtipoMovimiento` VARCHAR(15) NOT NULL,
  `fkIdCuentaContable` VARCHAR(15) NULL,
  `nombre` VARCHAR(45) NULL,
  `descripcion` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  PRIMARY KEY (`pkIdtipoMovimiento`),
  INDEX `fk_tipoMovimiento_cuentaContable1_idx` (`fkIdCuentaContable` ASC),
  CONSTRAINT `fk_tipoMovimiento_cuentaContable1`
    FOREIGN KEY (`fkIdCuentaContable`)
    REFERENCES cuentaContable (`pkIdCuentaContable`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table movimientosBancarios
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS movimientosBancarios (
  `pkIdMovimientosBancarios` VARCHAR(15) NOT NULL,
  `fkIdBanco` VARCHAR(15) NOT NULL,
  `fkIdcuenta` VARCHAR(15) NOT NULL,
  `tipoMovimiento_pkIdtipoMovimiento` VARCHAR(15) NOT NULL,
  `fechaEmision` DATETIME NULL,
  `fechaVencimiento` DATETIME NULL,
  `concepto` VARCHAR(45) NULL,
  `valor` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  PRIMARY KEY (`pkIdMovimientosBancarios`),
  INDEX `fk_movimientosBancarios_banco1_idx` (`fkIdBanco` ASC) ,
  INDEX `fk_movimientosBancarios_cuentaBancaria1_idx` (`fkIdcuenta` ASC) ,
  INDEX `fk_movimientosBancarios_tipoMovimiento1_idx` (`tipoMovimiento_pkIdtipoMovimiento` ASC) ,
  CONSTRAINT `fk_movimientosBancarios_banco1`
    FOREIGN KEY (`fkIdBanco`)
    REFERENCES banco (`pkIdBanco`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimientosBancarios_cuentaBancaria1`
    FOREIGN KEY (`fkIdcuenta`)
    REFERENCES cuentaBancaria (`pkIdcuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_movimientosBancarios_tipoMovimiento1`
    FOREIGN KEY (`tipoMovimiento_pkIdtipoMovimiento`)
    REFERENCES tipoMovimiento (`pkIdtipoMovimiento`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
