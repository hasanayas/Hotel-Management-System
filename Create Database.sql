CREATE DATABASE Hotel;

create table M�steriTablosu(
tc varchar(11) primary key ,
Ad varchar(50) ,
Soyad varchar(50) ,
�lke varchar(50),
Telefon varchar(50) ,
Email varchar(50) ,
Do�umTarihi varchar(30) ,
Giri�Tarihi varchar(30) ,
��k��Tarihi varchar(30) ,
)

create table OdaTablosu(
odaID varchar(20) primary key,
odaTipi varchar(50) ,
odaFiyati int 
)

create table OdemeTablosu(
�demeID int identity(1000,1) primary key, 
tc varchar(11) foreign key references M�steriTablosu(tc) ,
odaID varchar(20) foreign key references OdaTablosu(odaID) ,
�demeT�r� varchar(50) ,
�demeTarihi varchar(50) ,
�demeTutari varchar(50) ,
)


create proc spM�steriSil
@tc varchar(11)
as
Delete From M�steriTablosu Where tc=@tc



CREATE proc spM�steriG�ncelle    
@tc varchar(11),    
@Ad varchar(50) ,    
@Soyad varchar(50) ,    
@�lke varchar(50),    
@Telefon varchar(50) ,    
@Email varchar(50) ,      
@Do�umTarihi varchar(30) ,    
@Giri�Tarihi varchar(30) ,    
@��k��Tarihi varchar(30)     
as    
Update M�steriTablosu Set tc=@tc,Ad=@Ad,Soyad=@Soyad,�lke=@�lke,Telefon=@Telefon,    
Email=@Email,Do�umTarihi=@Do�umTarihi,Giri�Tarihi=@Giri�Tarihi,    
��k��Tarihi=@��k��Tarihi Where tc = @tc 

