CREATE TABLE [dbo].[ESTUDIANTES] (
    [Nombres]        VARCHAR (100) NOT NULL,
    [Apellidos]      VARCHAR (100) NOT NULL,
    [Tipo_Documento] VARCHAR (50)  NOT NULL,
    [Documento]      VARCHAR (50)  NOT NULL,
    [Género]         VARCHAR (50)  NOT NULL,
    [Programa]       VARCHAR (100) NOT NULL,
    [Ficha]          VARCHAR (50)  NOT NULL,
    [Correo]         VARCHAR (500) NULL,
    [Retrasos]       INT           NULL,
    [Inasistencias]  INT           NULL,
    [Foto]           IMAGE         NULL, 
    CONSTRAINT [PK_ESTUDIANTES] PRIMARY KEY ([Documento])
);

