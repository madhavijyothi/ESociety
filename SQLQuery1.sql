use ESocietyDB
create table ServiceProvider
(
Service varchar(500) not null,
Availablity varchar(50) null,
Charges bigint not null,
Description varchar(699) null,
OpeningTime varchar(50) null,
ClosingTime varchar(50) null,
SMID int References SocietyMemberInfo (SMID)
)