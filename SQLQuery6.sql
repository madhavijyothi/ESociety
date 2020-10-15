use ESocietyDB

create table GasAgency
(
Gno int primary key identity(10,1) NOT NULL,
Gname  varchar(500) NOT NULL,
Email  varchar(100) NOT NULL,
Phnno Bigint NOT NULL,
gasagency varchar(100) NOT NULL,
address  varchar(100) NOT NULL,
applydate datetime NOT NULL
)