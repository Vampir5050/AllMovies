--create database Filmography;

use Filmography;


--create table Genres
--(	
--	[id] int not null identity(1,1) primary key,
--	[Genre] nvarchar(50)
--);

--insert into Genres
--values
--('������'),
--('�����'),
--('�����'),
--('��������'),
--('�������'),
--('��������');

--create table Country
--(
--	[id] int not null identity(1,1) primary key,
--	[CountryManufacture] nvarchar(100)
--);

--insert into Country
--values
--('������'),
--('���'),
--('��������������'),
--('��������'),
--('�������'),
--('�����');

--create table FilmStudios
--(
--	[id] int not null identity(1,1) primary key,
--	[Name] nvarchar(150)
--);

--insert into FilmStudios
--values
--('Sony Pictures'),
--('Paramount Pictures'),
--('Columbia Pictures'),
--('Lionsgate'),
--('Universal Pictures'),
--('Warner Bros');

--create table Films
--(
--	[id] int not null identity(1,1) primary key,
--	[Name] nvarchar(150),
--	[YearRelease] int,
--	[Genres_FK] int foreign key([Genres_FK]) references Genres(id),
--	[Country_FK] int foreign key([Country_FK]) references Country(id),
--	[FilmStudios_FK] int foreign key([FilmStudios_FK]) references FilmStudios(id),
--	[Viewers] int,
--	[Rating] float,
--	[Cost] decimal
--);

--insert into Films
--values
--('������ � ������',2009,1,2,1,450000,7.5,150000000),
--('����� �����',1998,1,2,1,833333,7.5,95000000),
--('���������',2018,2,1,4,147000,5.8,44200000),
--('�������� ����',2011,3,2,4,70000,6.8,5000000),
--('8 ����',2002,3,4,5,860000,3.0,41000000),
--('�������',1998,6,1,6,50000,10.0,1000000),
--('���������',2001,5,6,2,1000000,9.0,5000000),
--('���',2013,4,5,3,500000,7.0,40000000),
--('����',2000,2,4,3,800000,4.0,100000000),
--('����',2020,4,1,1,300000,2.0,1000000);

--create table Translations
--(
--	[id] int not null identity(1,1),
--	[Transleyt] nvarchar(300),
--	[Films_FK] int foreign key([Films_FK]) references Films(id)
--);

select F.Name, F.YearRelease, Genre, CountryManufacture, FilmStudios.Name 
from Films F
inner join Genres on F.Genres_FK = Genres.id
inner join Country on F.Country_FK = Country.id
inner join FilmStudios on F.FilmStudios_FK = FilmStudios.id


--insert into Translations
--values
--('����������, �������, �����������',1),
--('���������, �������, ���������, ��������',2),
--('�������, ����������',3),
--('����������, ��������, ���������',4),
--('�������, ����������, ���������',5),
--('�������, ���������, �����������',6),
--('���������, �������, ����������',7),
--('�����������, ���������',8),
--('��������, ���������, �������',9),
--('�������, ��������, ����������',10);

--create table Display
--(
--	[id] int not null identity(1,1),
--	[Showing] nvarchar(300),
--	[Films_FK] int foreign key([Films_FK]) references Films(id)
--);

--select *
--from Translations;

--insert into Display
--values
--('��������������, �������, ������, �������',1),
--('���������������, ������, �����, ��������',2),
--('������, �������, �����(��������)',3),
--('�������, ��������������, ��������, �����',4),
--('��������, ��������������, �����',5),
--('������, �����, �������, �������(��������)',6),
--('�����, ������, ��������������, �������',7),
--('�������, �����',8),
--('��������, �����, ������',9),
--('������, ��������, �������, ��������������',10);

--create table Humans
--(
--	[id] int not null identity(1,1) primary key,
--	[FirstName] nvarchar(50),
--	[LastName] nvarchar(50),
--	[Gender] nvarchar(4),
--	[PlaceResidence] nvarchar(50),
--	[Address] nvarchar(300),
--	[Income] decimal
--);

--insert into Humans
--values
--('����','��������','���.','���','�. ���-���� ��. �������� ����� 23',2000000),
--('���������','��������','���.','���','�. ���-�������� ��. ����� ����� 44',1000000),
--('�������','�����','���.','��������������','�. ������ ��. ����-��� 45',500000),
--('������','��������','���.','������','�. ������ ��. ������ 44',50000),
--('�����','�������','���.','������','�. ������ ��. ������� ����� 32',300000),
--('�����','���������','���.','������','�. �����-��������� ��. ���������� 23 ',80000),
--('���������','������','���.','������','�. ������� ��. ���������� 42',10000),
--('�������','��������','���.','������','�. ������ ��. ��������� 22',240000),
--('������','������','���.','��������','�. ������ ��. ������ 12',403000),
--('���','���','���.','�����','�.������� ��. ������ 556',380000),
--('���','�����','���.','���','�. ���-������ ��. ����� ����� 54 ',1000000),
--('�����','�����','���.','�������','�. ����� ��. ����� 55',345000),
--('����','������','���.','�������','�. ����� �� ������� 901',45000);

--create table Workers
--(
--	[id] int not null identity(1,1),
--	[FilmStidios_FK] int foreign key([FilmStidios_FK]) references FilmStudios(id),
--	[Post] nvarchar(50),
--	[Humans_FK] int foreign key([Humans_FK]) references Humans(id)
--);

--select * from Humans;
--select * from FilmStudios;

--insert into Workers
--values
--(1,'���������',1),
--(1, '�����',1),
--(1,'�����',2),
--(1, '�����',3),
--(1, '��������',3),
--(2,'���������',2),
--(2, '��������',8),
--(2, '�����',3),
--(2, '�����',4),
--(2, '�����',5),
--(3, '���������',6),
--(3, '��������',3),
--(3, '�����',1),
--(3, '�����',12),
--(3, '�����',13),
--(3, '�����',12),
--(4, '���������',13),
--(4, '��������',12),
--(4, '�����',9),
--(4, '�����',1),
--(4, '�����',11),
--(4, '�����',7),
--(4, '�����',5),
--(5, '���������',5),
--(5, '��������',3),
--(5, '�����',2),
--(5, '�����',11),
--(5, '�����',8),
--(5, '�����',9),
--(6, '���������',11),
--(6, '��������',12),
--(6, '�����',8),
--(6, '�����',6),
--(6, '�����',11),
--(6, '�����', 7),
--(6, '�����',5);

--create table Users
--(
--	[Id] int not null identity(1,1) primary key,
--	[Login] nvarchar(100),
--	[Password] nvarchar(8),
--	[Salt] nvarchar(max),
--	[Role] nvarchar(50)

--);

