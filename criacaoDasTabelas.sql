create table Time(
 codTime int primary key identity,
 corTime varchar(15) not null
 )

 create table Usuario(
 codUsuario int primary key identity,
 nomeUsuario varchar(20) not null,
 senha varchar(30) not null,
 maiorPontuacao int null,
 codTime int not null,
 constraint fkCodTime foreign key(codTIme) References Time(codTime)
 )

