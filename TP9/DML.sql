INSERT INTO USUARIO (usuario, contra, f_nacimiento) VALUES
('claudia', 'chavez', '2000-01-01');

INSERT INTO USUARIO (usuario, contra, f_nacimiento) VALUES
('carlos', 'gomez', '2000-01-01');

SELECT id, usuario, contra, f_nacimiento FROM USUARIO;

UPDATE USUARIO SET contra = 'grande' WHERE id = 1;

DELETE FROM USUARIO WHERE id = 2;

SELECT id, usuario, f_nacimiento FROM USUARIO
WHERE usuario = 'claudi' AND f_nacimiento = '2000-01-01'