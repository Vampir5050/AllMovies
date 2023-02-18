--create database Filmography;

use Filmography;


--create table Genres
--(	
--	[id] int not null identity(1,1) primary key,
--	[Genre] nvarchar(50)
--);

--insert into Genres
--values
--('Боевик'),
--('Ужасы'),
--('Драма'),
--('Детектив'),
--('Триллер'),
--('Коммедия');

--create table Country
--(
--	[id] int not null identity(1,1) primary key,
--	[CountryManufacture] nvarchar(100)
--);

--insert into Country
--values
--('Россия'),
--('США'),
--('Великобритания'),
--('Германия'),
--('Франция'),
--('Китай');

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
--('Ангелы и демоны',2009,1,2,1,450000,7.5,150000000),
--('Маска Зерро',1998,1,2,1,833333,7.5,95000000),
--('Винчестер',2018,2,1,4,147000,5.8,44200000),
--('Кроличья нора',2011,3,2,4,70000,6.8,5000000),
--('8 миля',2002,3,4,5,860000,3.0,41000000),
--('Дракула',1998,6,1,6,50000,10.0,1000000),
--('Небоскреб',2001,5,6,2,1000000,9.0,5000000),
--('Пол',2013,4,5,3,500000,7.0,40000000),
--('Халк',2000,2,4,3,800000,4.0,100000000),
--('Мама',2020,4,1,1,300000,2.0,1000000);

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
--('Английский, русский, французский',1),
--('Английски, русский, китайский, немецкий',2),
--('Русский, английский',3),
--('Английский, немецкий, китайский',4),
--('Немцкий, английский, китайский',5),
--('Русский, китайский, французский',6),
--('Китайский, русский, английский',7),
--('Французский, китайский',8),
--('Немецкий, китайский, русский',9),
--('Русский, немецкий, английский',10);

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
--('Великобритания, Америка, Россия, Франция',1),
--('Великобринтания, Россия, Китай, Германия',2),
--('Россия, Америка, Китай(субтитры)',3),
--('Америка, Великобритания, Германия, Китай',4),
--('Германия, Великобритания, Китай',5),
--('Россия, Китай, Франция, Америка(субтитры)',6),
--('Китай, Россия, Великобритания, Америка',7),
--('Франция, Китай',8),
--('Германия, Китай, Россия',9),
--('Россия, Германия, Америка, Великобритания',10);

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
--('Джон','Траволте','муж.','США','г. Нью-Йорк ул. Манхетон драйв 23',2000000),
--('Сильвестр','Сталлоне','муж.','США','г. Лос-Анджелес ул. Драйв авеню 44',1000000),
--('Джесика','Альба','жен.','Великобритания','г. Лондон ул. Вест-энд 45',500000),
--('Руслан','Безгодов','муж.','Россия','г. Москва ул. Видова 44',50000),
--('Милла','Йолович','жен.','Россия','г. Москва ул. Золотая рыбка 32',300000),
--('Ирина','Волочкова','жен.','Россия','г. Санкт-Питербург ул. Молодежная 23 ',80000),
--('Александр','Волков','муж.','Россия','г. Воронеж ул. Грибоедова 42',10000),
--('Татьяна','Макарова','жен.','Россия','г. Москва ул. Воробьева 22',240000),
--('Алтман','Мюллер','муж.','Германия','г. Берлин ул. Роквуд 12',403000),
--('Ван','Сюй','жен.','Китай','г.Гонконг ул. Вансел 556',380000),
--('Пол','Уокер','муж.','США','г. Нью-Джерси ул. Авеню драйв 54 ',1000000),
--('Жоэль','Шассе','муж.','Франция','г. Париж ул. Журен 55',345000),
--('Софи','Лабель','жен.','Франция','г. Париж ул Женклау 901',45000);

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
--(1,'Президент',1),
--(1, 'Актер',1),
--(1,'Актер',2),
--(1, 'Актер',3),
--(1, 'Продюсер',3),
--(2,'Президент',2),
--(2, 'Продюсер',8),
--(2, 'Актер',3),
--(2, 'Актер',4),
--(2, 'Актер',5),
--(3, 'Президент',6),
--(3, 'Продюсер',3),
--(3, 'Актер',1),
--(3, 'Актер',12),
--(3, 'Актер',13),
--(3, 'Актер',12),
--(4, 'Президент',13),
--(4, 'Продюсер',12),
--(4, 'Актер',9),
--(4, 'Актер',1),
--(4, 'Актер',11),
--(4, 'Актер',7),
--(4, 'Актер',5),
--(5, 'Президент',5),
--(5, 'Продюсер',3),
--(5, 'Актер',2),
--(5, 'Актер',11),
--(5, 'Актер',8),
--(5, 'Актер',9),
--(6, 'Президент',11),
--(6, 'Продюсер',12),
--(6, 'Актер',8),
--(6, 'Актер',6),
--(6, 'Актер',11),
--(6, 'Актер', 7),
--(6, 'Актер',5);

--create table Users
--(
--	[Id] int not null identity(1,1) primary key,
--	[Login] nvarchar(100),
--	[Password] nvarchar(8),
--	[Salt] nvarchar(max),
--	[Role] nvarchar(50)

--);

