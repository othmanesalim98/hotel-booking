CREATE database reserv

use reserv

create table Client
(
idClient int primary key,
nom varchar(20) check (nom not like '%[^a-z]%'),
prenom varchar(20) check (prenom not like '%[^a-z]%'),
CIN varchar(8) unique,
ville varchar(30) check (ville not like '%[^a-z]%'),
date_naisance date check (datediff(year,date_naisance,getdate())>=18),
telephone varchar(13), --check (telephone not like '%[^0-9]%'),
email varchar(30) --check (email LIKE '%_@__%.__%')
)

CREATE table TypeChambre
(
idTypeChambre int primary key,
description_ varchar(17) not null check(description_ in 
('CHAMBRE SINGLE','CHAMBRE DOUBLE','SUITE JUNIOR','SUITE SENIOR','APPARTEMENT'))
)


create table Mode_Payment
(
idMode_Payment int primary key,
typePayment varchar(10) not null check(typePayment in ('especes' , 'cheque' , 'Virement','TPE'))
) 

 -----------
go
CREATE table Chambre
(
idChambre int primary key identity,
nomChambre varchar(20) ,
etat varchar(10) default('dispo') check(etat in ('dispo','not dispo')),
typeChambre int references TypeChambre(idTypeChambre) not null,
prix_Ch money
)


create table Service
(
idService int primary key,
nomService varchar(40),-- check (nomService not like '%[^a-z]%'),
prix_Se money
) 

go
create table Reservation
(
idReservation int primary key,
dateReservation date not null,
dateArrive date not null,
dateDepart date not null,
client int references Client(idClient)not null,
chambre int references Chambre(idChambre),
typeReservation varchar(5) check (typeReservation in ('Open','Close')),
check(datediff(day,getdate(),dateReservation)>=0),
check(datediff(day,dateReservation,dateArrive)>=0),
check(datediff(day,dateArrive,dateDepart)>=1)
)----------

create table checkIN
(
idCheckIN int primary key,
reservation int references Reservation(idReservation),
dateCheckIn datetime
)


create table OccupChambre
(
idOccupChambre int primary key identity,
reservation int references reservation(idreservation),
chambre int references Chambre(idChambre),
dateOccup datetime,
dateDispo datetime,
typeO varchar(10)
)


create table Demande_service
(
idServiceDemander int primary key,
reservation int references Reservation(idReservation),
service int references Service(idService) not null,
dateDemande datetime not null,
)



create table Facture
(
idFacture int primary key identity,
reservation int references Reservation(idReservation),
montant money,
statusF varchar(10)
)



create table Detail_Paiment --CheckOUT
 (
idDetail int primary key,
Facture int references Facture(idFacture),
montantD money,
datePayement datetime,
modePayment int references Mode_Payment(idMode_Payment),
detailModePaiment varchar(40)
)



create table checkOut
(
idCheckOut int primary key,
reservation int references Reservation(idReservation),
dateCheckOut datetime
) 


go
create table Utilisateurs(
UtilisatID int identity(1,1) primary key,
Nom_utilisateur nvarchar (100) unique not null,
mot_passe nvarchar (100) not null,
nom nvarchar(100) not null,
prenom nvarchar(100) not null,
Position nvarchar (100) not null,
Email nvarchar(150)not null
) 

select * from Utilisateurs where Nom_utilisateur='admin' and mot_passe='admin'
declare @user nvarchar(100)='admin'
declare @passe nvarchar(100)='admin'
select * from Utilisateurs where Nom_utilisateur=@user and mot_passe=@passe






insert into Utilisateurs values 
('admin','admin','Ayoub','Taouil','Administrateur','admin.ayoub@gmail.com'),
('ahmade','abc123456','Ahmade','Imran','Reception','reception.ahmade@gmail.com.com'),
('samy','abc123456','Samy','Alami','comtabilité','comtabilité.samy@gmail.com')


select *from Utilisateurs 

insert into Client values
(1,'ali','ahmad','BA1111','casablanca','1999/01/11','0654789231','ali@gmail.com'),
(2,'alami','hassan','BA2222','casablanca','1998/01/11','0698741256','alami@gmail.com'),
(3,'manar','sara','BA3333','rabat','2000/01/20','0678451296','sara@gmail.com')



insert into TypeChambre values 
(1,'CHAMBRE SINGLE'),
(2,'CHAMBRE DOUBLE'),
(3,'SUITE JUNIOR'),
(4,'SUITE SENIOR'),
(5,'APPARTEMENT')


select * from Chambre
insert into Mode_Payment values 
(1,'especes'),
(2,'cheque'),
(3,'Virement'),
(4,'TPE')

select * from TypeChambre


insert into Service values
(1,'Petit-déjeuner',100),
(2,'Parking',30),
(3,'Bouteille de champagne',40),
(4,'Fleurs',50),
(5,'Restaurant',150),
(6,'Chambre avec vue particulière',200),
(7,'Spa / Hammam / Massage',130),
(8,'Shuttle / Navette /  Bus privé',120)
SELECT * FROM Service