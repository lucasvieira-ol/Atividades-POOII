CREATE TABLE [dbo].[CLIENTE](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](25) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[email] [varchar](70) NOT NULL,
	[senha] [varchar](30) NOT NULL,
	[dataCadastro] [datetime] NOT NULL,
	[dataAcesso] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO CLIENTE VALUES ('admin','Usuário Admin','lucas.admin@admin.com','admin',GETDATE(),NULL)
INSERT INTO CLIENTE VALUES ('rodrigo.maia',	'Rodrigo S. Maia',	'rodrigo.santana@admin.com','Rodrigo-00',GETDATE(),	NULL)
INSERT INTO CLIENTE VALUES ('vinicius.fernandes','Vinicius S. E. Fernandes','vinicius.fernandes@admin.com','@Vini2308',	GETDATE(),NULL)
INSERT INTO CLIENTE VALUES ('lucas.oliveira','Lucas V. Oliveira','lucas.oliveira@admin.com','Lucas-00',	GETDATE(),NULL)
INSERT INTO CLIENTE VALUES ('professor','Professor','professor.unip@admin.com','Unip-00',GETDATE(),	NULL)