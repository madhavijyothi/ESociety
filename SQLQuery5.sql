use ESocietyDB

create table DoctorsAppointment
(
Appid int primary key identity NOT NULL,
Name varchar(100) NOT NULL,
time varchar(200) NOT NULL,
Dat date NOT NULL,
category varchar(100) NOT NULL,
mobileno  varchar(100) NOT NULL,

)