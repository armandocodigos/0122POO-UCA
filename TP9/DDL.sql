CREATE DATABASE conia;

USE conia;

CREATE TABLE USUARIO(
    id          INT IDENTITY(1,1)   PRIMARY KEY,
    usuario         VARCHAR(32)     NOT NULL,
    contra          VARCHAR(32)     NOT NULL,
    f_nacimiento    DATETIME        NOT NULL
);