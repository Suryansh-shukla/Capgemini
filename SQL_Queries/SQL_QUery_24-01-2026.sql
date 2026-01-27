
create database LPU_Db;

use LPU_Db;

create Schema PankajBatch;

create table PankajBatch.Person(
Id int primary key identity(1,1),
Name varchar(20) not null,
Age int,
Address varchar(50),
PhoneNo varchar(10)
);		