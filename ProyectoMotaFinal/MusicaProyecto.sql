CREATE DATABASE AtaydeMusic;
GO

use AtaydeMusic;
GO

CREATE TABLE Instrumentos (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100),
    tipo VARCHAR(50),
    marca VARCHAR(50),
    precio DECIMAL(10,2),
    stock INT
);
GO

INSERT INTO Instrumentos (nombre, tipo, marca, precio, stock) VALUES
('Guitarra Ac�stica', 'Cuerda', 'Yamaha', 3500.00, 10),
('Piano Digital', 'Teclado', 'Casio', 8000.00, 5),
('Bater�a Electr�nica', 'Percusi�n', 'Roland', 12500.00, 2),
('Viol�n 4/4', 'Cuerda', 'Cecilio', 2900.00, 8),
('Flauta Dulce', 'Viento', 'Yamaha', 300.00, 20),
('Saxof�n Alto', 'Viento', 'Selmer', 12000.00, 3),
('Teclado Port�til', 'Teclado', 'Korg', 4500.00, 4),
('Caj�n Peruano', 'Percusi�n', 'Meinl', 1800.00, 6),
('Guitarra El�ctrica', 'Cuerda', 'Fender', 9500.00, 5),
('Bajo El�ctrico', 'Cuerda', 'Ibanez', 8700.00, 4),
('Tromb�n', 'Viento', 'Bach', 7600.00, 2),
('Bongoes', 'Percusi�n', 'LP', 1600.00, 7),
('Acorde�n', 'Teclado', 'Hohner', 5400.00, 3),
('Tambor Marcha', 'Percusi�n', 'Pearl', 3200.00, 2),
('Clarinete', 'Viento', 'Buffet', 6800.00, 3);
GO
