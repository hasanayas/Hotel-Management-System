CREATE DATABASE Hotel;

create table MüsteriTablosu(
tc varchar(11) primary key ,
Ad varchar(50) ,
Soyad varchar(50) ,
Ülke varchar(50),
Telefon varchar(50) ,
Email varchar(50) ,
DoðumTarihi varchar(30) ,
GiriþTarihi varchar(30) ,
ÇýkýþTarihi varchar(30) ,
)

create table OdaTablosu(
odaID varchar(20) primary key,
odaTipi varchar(50) ,
odaFiyati int 
)

create table OdemeTablosu(
ödemeID int identity(1000,1) primary key, 
tc varchar(11) foreign key references MüsteriTablosu(tc) ,
odaID varchar(20) foreign key references OdaTablosu(odaID) ,
ödemeTürü varchar(50) ,
ödemeTarihi varchar(50) ,
ödemeTutari varchar(50) ,
)


create proc spMüsteriSil
@tc varchar(11)
as
Delete From MüsteriTablosu Where tc=@tc



CREATE proc spMüsteriGüncelle    
@tc varchar(11),    
@Ad varchar(50) ,    
@Soyad varchar(50) ,    
@Ülke varchar(50),    
@Telefon varchar(50) ,    
@Email varchar(50) ,      
@DoðumTarihi varchar(30) ,    
@GiriþTarihi varchar(30) ,    
@ÇýkýþTarihi varchar(30)     
as    
Update MüsteriTablosu Set tc=@tc,Ad=@Ad,Soyad=@Soyad,Ülke=@Ülke,Telefon=@Telefon,    
Email=@Email,DoðumTarihi=@DoðumTarihi,GiriþTarihi=@GiriþTarihi,    
ÇýkýþTarihi=@ÇýkýþTarihi Where tc = @tc 

