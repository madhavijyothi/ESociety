use ESocietyDB
 
 Create table ServiceAppoint
(
SID  int primary key identity(10,1) NOT NULL,
name  varchar(500) NOT NULL,
contactno  varchar(100) NOT NULL,
Address  varchar(100) NOT NULL,

)