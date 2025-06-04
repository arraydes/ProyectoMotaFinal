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
('Guitarra Acústica', 'Cuerda', 'Yamaha', 3500.00, 10),
('Piano Digital', 'Teclado', 'Casio', 8000.00, 5),
('Batería Electrónica', 'Percusión', 'Roland', 12500.00, 2),
('Violín 4/4', 'Cuerda', 'Cecilio', 2900.00, 8),
('Flauta Dulce', 'Viento', 'Yamaha', 300.00, 20),
('Saxofón Alto', 'Viento', 'Selmer', 12000.00, 3),
('Teclado Portátil', 'Teclado', 'Korg', 4500.00, 4),
('Cajón Peruano', 'Percusión', 'Meinl', 1800.00, 6),
('Guitarra Eléctrica', 'Cuerda', 'Fender', 9500.00, 5),
('Bajo Eléctrico', 'Cuerda', 'Ibanez', 8700.00, 4),
('Trombón', 'Viento', 'Bach', 7600.00, 2),
('Bongoes', 'Percusión', 'LP', 1600.00, 7),
('Acordeón', 'Teclado', 'Hohner', 5400.00, 3),
('Tambor Marcha', 'Percusión', 'Pearl', 3200.00, 2),
('Clarinete', 'Viento', 'Buffet', 6800.00, 3);
GO
