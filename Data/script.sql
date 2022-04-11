insert into main.Pacientes (Id, Nombre, Apellido, Direccion, Telefono, Edad, Sexo, EstadoCivil, NivelEducativo, Cedula, Ocupacion, AseguradoraId, CreadoEn, ActualizadoEn)
values  (1, 'Raul', 'Luis', 'C/ Alguna, #10', '8090000000', 21, 0, 0, 3, '40200000000', 'Programador Frontend', 1, '2022-04-10 17:42:36.916169', '2022-04-10 17:47:35.160759'),
        (2, 'Fulano', 'de Tal', '2486 Loomis Place', '8090000000', 22, 2, 2, 4, '3711658509', 'Médico', 2, '2022-04-10 17:45:05.668595', '2022-04-10 17:45:05.668912'),
        (3, 'Sky', 'Sky', '4174 Corben Trail', '8090000000', 32, 0, 1, 3, '4020000000', 'Enfermera', 3, '2022-04-10 18:36:09.83674', '2022-04-10 18:49:51.694301'),
        (4, 'Barclay', 'Levi', '9702 Stoughton Way', '8090000000', 50, 2, 0, 4, '58151274341', 'Profesor', 5, '2022-04-10 18:47:46.381157', '2022-04-10 18:50:02.713729'),
        (5, 'Shanan', 'Bernaldo', '934 Hanson Junction', '8090000000', 41, 1, 4, 4, '02238462441', 'Contador', 4, '2022-04-10 18:49:40.34627', '2022-04-10 18:50:14.344134');

insert into main.Aseguradoras (Id, Nombre, Telefono, Correo, CreadoEn, ActualizadoEn)
values  (1, 'SEMMA', '8090000000', 'contacto@semma.com', '2022-04-10 17:24:34.878646', '2022-04-10 17:24:34.87883'),
        (2, 'ARS Humano', '8090000000', 'contacto@humanoars.com', '2022-04-10 17:33:11.217952', '2022-04-10 17:33:11.218365'),
        (3, 'ARS Futuro', '80900000000', 'contacto@arsfuturo.com', '2022-04-10 17:33:56.710002', '2022-04-10 17:33:56.710141'),
        (4, 'ARS Monumental', '8090000000', 'info@monumental.com', '2022-04-10 17:35:03.685463', '2022-04-10 17:35:03.685809'),
        (5, 'SENASA', '8090000000', 'info@senasa.com.gob', '2022-04-10 17:38:46.52102', '2022-04-10 17:38:50.521639');

