CREATE DATABASE blockbuster;

USE blockbuster;

CREATE TABLE ROL(
    code CHAR(6) PRIMARY KEY, -- ROL_##
    nombre VARCHAR(15) NOT NULL
);

CREATE TABLE GENERO(
    code CHAR(6) PRIMARY KEY, -- GEN_##
    nombre VARCHAR(20) NOT NULL
);

CREATE TABLE DIRECTOR(
    code CHAR(6) PRIMARY KEY, -- DIR_##
    nombre VARCHAR(32) NOT NULL,
    apellido VARCHAR(32) NOT NULL
)

CREATE TABLE USUARIO(
    dui CHAR(10) PRIMARY KEY -- ########-#
        CHECK(dui LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]'),
    nombre          VARCHAR(32)     NOT NULL,
    apellido        VARCHAR(32)     NOT NULL,
    direccion       VARCHAR(140)    NOT NULL,
    f_nacimiento    DATETIME        NOT NULL,
    email           VARCHAR(32)     NOT NULL,
    telefono        CHAR(8)         NOT NULL
        CHECK(telefono LIKE '[6|7|2][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
    id_rol          CHAR(6)         NOT NULL
        DEFAULT 'ROL_00'
);

CREATE TABLE PELICULA(
    code            CHAR(11) PRIMARY KEY,
    titulo          VARCHAR(32)     NOT NULL,
    estreno         DATETIME        NOT NULL,
    precio          MONEY           NOT NULL,
    duracion        INT             NOT NULL, --Minutos
    stock           INT             NOT NULL,
    descripcion     VARCHAR(280)    NOT NULL,
    id_genero       CHAR(6) NOT NULL
        DEFAULT 'GEN_00',
    id_director     CHAR(6) NOT NULL
        DEFAULT 'DIR_00',
    id_usuario      CHAR(10) NULL
);

CREATE TABLE RENTA(
    id INT IDENTITY(1,1) PRIMARY KEY,
    id_usuario CHAR(10) NULL,
    id_pelicula CHAR(11) NULL,
    f_prestamo DATETIME NOT NULL,
    f_esperada DATETIME NOT NULL,
    f_devolucion DATETIME NULL,
);

-- FK's

-- Usuario
ALTER TABLE USUARIO 
    ADD CONSTRAINT fk_user_rol
    FOREIGN KEY(id_rol)
    REFERENCES ROL(code)
    ON DELETE SET DEFAULT
    ON UPDATE CASCADE;

-- Pelicula

ALTER TABLE PELICULA 
    ADD CONSTRAINT fk_pelicula_genero
    FOREIGN KEY(id_genero)
    REFERENCES GENERO(code)
    ON DELETE SET DEFAULT
    ON UPDATE CASCADE;

ALTER TABLE PELICULA 
    ADD CONSTRAINT fk_pelicula_director
    FOREIGN KEY(id_director)
    REFERENCES DIRECTOR(code)
    ON DELETE SET DEFAULT
    ON UPDATE CASCADE;

ALTER TABLE PELICULA 
    ADD CONSTRAINT fk_pelicula_usuario
    FOREIGN KEY(id_usuario)
    REFERENCES USUARIO(dui)
    ON DELETE SET NULL
    ON UPDATE CASCADE;

-- Renta

ALTER TABLE RENTA
    ADD CONSTRAINT fk_renta_usuario
    FOREIGN KEY(id_usuario)
    REFERENCES USUARIO(dui)
    ON DELETE SET NULL
    ON UPDATE CASCADE;

ALTER TABLE RENTA
    ADD CONSTRAINT fk_renta_pelicula
    FOREIGN KEY(id_pelicula)
    REFERENCES PELICULA(code)
    ON DELETE SET NULL
    ON UPDATE NO ACTION;