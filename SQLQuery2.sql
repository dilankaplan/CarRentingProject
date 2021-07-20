CREATE DATABASE RentACarProject
CREATE TABLE CarsRent(
   Id int,
   colorId int,
   brandId int,
   CarName varchar(10),
   modelYear varchar(5),
   dailyPrice int,
   description varchar(250),
);

CREATE TABLE CarColors(
    Id int,
    colorId int,
    colorName varchar(50),
);

CREATE TABLE CarBrands(
   Id int,
   brandId int,
   brandName varchar(10),

);