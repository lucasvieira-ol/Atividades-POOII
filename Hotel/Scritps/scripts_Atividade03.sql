create table tbLogin
(
	 id_usuario INT IDENTITY(1,1) PRIMARY KEY,
	 login varchar(60) NOT NULL,
	 senha varchar(20) NOT NULL,
	 status Bit NOT NULL
)

create table tbFuncionario
(
	id_funcionario INT IDENTITY(1,1) PRIMARY KEY,
	CPF varchar(14) NOT NULL UNIQUE,
	Nome varchar(40) NOT NULL,
	DataNascimento DATETIME NOT NULL,
	DataContratacao DATETIME NOT NULL,
	Status varchar(1) NOT NULL
)

create table tbHospede
(
	id_reserva INT IDENTITY(1,1) PRIMARY KEY,
	CPF varchar(14) NOT NULL,
	Nome varchar(40) NOT NULL,
	DataCheckIn DATETIME NOT NULL,
	DataCheckOut DATETIME NOT NULL,
	Quarto varchar(4) NOT NULL
)

insert into tbLogin values ('admin', 'admin',1)