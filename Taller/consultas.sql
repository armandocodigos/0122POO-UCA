SELECT PELICULA.code, titulo, estreno, precio, duracion, stock, 
        descripcion, GENERO.nombre AS 'genero', DIRECTOR.nombre AS 'director'
FROM PELICULA
INNER JOIN GENERO ON GENERO.code = PELICULA.id_genero
INNER JOIN DIRECTOR ON DIRECTOR.code = PELICULA.id_director
WHERE titulo LIKE '%SQL%';

SELECT PELICULA.code, titulo, estreno, precio, duracion, stock, 
        descripcion, GENERO.nombre AS 'genero', DIRECTOR.nombre AS 'director'
FROM PELICULA
INNER JOIN GENERO ON GENERO.code = PELICULA.id_genero
INNER JOIN DIRECTOR ON DIRECTOR.code = PELICULA.id_director
WHERE GENERO.nombre LIKE 'Horror';

SELECT code, nombre
FROM GENERO;

insert into PELICULA (code, titulo, estreno, precio, duracion, stock, descripcion, id_genero, id_director, id_usuario) values 
('288218942-7', 'Telstar: The Joe Meek Story', '1961-12-25 01:32:19', 38, 105, 9, 'Vestibulum', 'GEN_09', 'DIR_14', '22577777-5');

SELECT USUARIO.nombre, apellido, ROL.nombre as 'rol'
FROM USUARIO
INNER JOIN ROL ON ROL.code = USUARIO.id_rol
WHERE USUARIO.nombre like 'Douglas' AND
apellido like 'Hernández';

INSERT INTO USUARIO VALUES(
    '22577776-5',
    'Ronaldo',
    'Canizales',
    'UCA',
    '1997-12-12',
    'dohernandez@uca.edu.sv',
    '22577777',
    'ROL_02'
);

SELECT * FROM USUARIO;