use ESocietyDB

create table appointment
(
Owner varchar(30) not Null,
Houseno Varchar(500) not Null,
Date datetime not Null,
Hours bigint not Null,
)