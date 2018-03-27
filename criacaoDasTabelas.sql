create table Time(
 codTime int primary key identity,
 corTime varchar(15) not null
 )

 create table Usuario(
 codUsuario int primary key identity,
 nomeUsuario varchar(30) not null,
 senha varchar(30) not null,
 maiorPontuacao int null,
 codTime int not null,
 constraint fkCodTime foreign key(codTIme) References Time(codTime)
 )


create table Materia(
codMateria int primary key identity,
nomeMateria varchar(20) not null
)

create table Pergunta(
codPergunta int primary key identity,
pergunta varchar(200) not null,
dificultade int not null,
codMateria int not null,
constraint fkCodMateria foreign key(codMateria) References Materia(codMateria)
) 


create table Resposta(
codResposta int primary key identity,
resposta varchar(40) not null,
status bit not null,
codPergunta int not null,
constraint fkCodPErgunta foreign key(codPergunta) References Pergunta(codPergunta)
) 



