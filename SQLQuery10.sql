use ESocietyDB

Create table guard
(
SN int primary key identity(10,1) NOT NULL,
Name varchar(100) NOT NULL,
blockno varchar(100) NOT NULL,
Contact Bigint NOT NULL,
Checkin varchar(100) NOT NULL,
Checkout varchar(100) NOT NULL,
)