-- Create database UniMenes;
use UniMenes

create table Fajta(
Id int primary key,
Nev varchar(10),
Szin varchar(10));

Create table tenyésztő(
Id int primary key,
Nev Varchar(20),
Varos varchar(20));

Create table Unikornis(
Id int primary key identity,
Tulajdonosid int foreign key references Tenyezto(Id),
Fajtaid int foreign key references Fajta(Id),
Suly int,
nem Bit);

Insert into Fajta Values
(1, 'ninja',   'szürke'),
(2, 'robot',   'kék'),
(3, 'dapper',  'fehér'),
(4, 'nyan',    'magenta'),
(5, 'zombie',  'zöld'),
(6, 'hipster', 'narancs');
Insert into Tenyszto Values
(1, 'Terrell',  'Tukbert'),
(2, 'Tiomoid',  'Xora'),
(3, 'Jones',    'Tukbert'),
(4, 'Alastair', 'Xora'),
(5, 'Benson',   'Xora');
Insert into Unikornis Values
(2, 4, 411, 0),
(2, 4, 430, 1),
(2, 5, 413, 1),
(3, 1, 401, 0),
(1, 5, 449, 0),
(4, 4, 441, 1),
(4, 6, 448, 0),
(3, 6, 497, 1),
(3, 4, 524, 1),
(5, 3, 430, 0),
(5, 2, 493, 1),
(5, 1, 524, 0),
(1, 1, 412, 1),
(1, 2, 456, 1),
(1, 2, 513, 0),
(2, 4, 444, 0),
(3, 4, 544, 1),
(4, 3, 428, 1),
(4, 3, 478, 0),
(5, 5, 469, 0),
(3, 5, 437, 1),
(3, 6, 481, 0),
(1, 6, 420, 1);
