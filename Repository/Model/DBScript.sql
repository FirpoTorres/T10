USE [Encuesta]
GO
/****** Object:  Table [dbo].[Accesos]    Script Date: 15/05/2015 23:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accesos](
	[IdAcceso] [int] IDENTITY(1,1) NOT NULL,
	[Login] [char](20) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
 CONSTRAINT [PK_Accesos] PRIMARY KEY CLUSTERED 
(
	[IdAcceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ElementoSeleccion]    Script Date: 15/05/2015 23:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ElementoSeleccion](
	[IdElementoSeleccion] [int] IDENTITY(1,1) NOT NULL,
	[IdSeleccion] [int] NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
 CONSTRAINT [PK_ElementoSeleccion] PRIMARY KEY CLUSTERED 
(
	[IdElementoSeleccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Encuesta]    Script Date: 15/05/2015 23:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Encuesta](
	[IdEncuesta] [int] IDENTITY(1,1) NOT NULL,
	[FechaHora] [datetime] NULL,
	[IdTipoEncuesta] [int] NOT NULL,
 CONSTRAINT [PK_Encuesta] PRIMARY KEY CLUSTERED 
(
	[IdEncuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Plantilla]    Script Date: 15/05/2015 23:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Plantilla](
	[IdPlantilla] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoEncuesta] [int] NOT NULL,
	[Pregunta] [varchar](512) NOT NULL,
	[IdSeleccion] [int] NULL,
 CONSTRAINT [PK_Plantilla] PRIMARY KEY CLUSTERED 
(
	[IdPlantilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Respuesta]    Script Date: 15/05/2015 23:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Respuesta](
	[IdRespuesta] [int] IDENTITY(1,1) NOT NULL,
	[IdEncuesta] [int] NOT NULL,
	[Pregunta] [varchar](512) NOT NULL,
	[Respuesta] [varchar](512) NULL,
 CONSTRAINT [PK_Pregunta] PRIMARY KEY CLUSTERED 
(
	[IdRespuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Seleccion]    Script Date: 15/05/2015 23:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Seleccion](
	[IdSeleccion] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Seleccion] PRIMARY KEY CLUSTERED 
(
	[IdSeleccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoEncuesta]    Script Date: 15/05/2015 23:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoEncuesta](
	[IdTipoEncuesta] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
 CONSTRAINT [PK_TipoEncuesta] PRIMARY KEY CLUSTERED 
(
	[IdTipoEncuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/05/2015 23:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Login] [char](20) NOT NULL,
	[Password] [char](20) NOT NULL,
	[Nombre] [varchar](128) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ElementoSeleccion] ON 

INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (1, 1, N'SI')
INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (2, 1, N'NO')
INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (3, 2, N'Costa Rica')
INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (4, 2, N'Colombia')
INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (5, 2, N'Suiza')
INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (6, 3, N'Normal')
INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (7, 3, N'Gordo')
INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (8, 3, N'Muy Gordo')
INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (9, 4, N'Fiat Punto')
INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (10, 4, N'Fiesta Kinetic')
INSERT [dbo].[ElementoSeleccion] ([IdElementoSeleccion], [IdSeleccion], [Descripcion]) VALUES (11, 4, N'VW Fox')
SET IDENTITY_INSERT [dbo].[ElementoSeleccion] OFF
SET IDENTITY_INSERT [dbo].[Plantilla] ON 

INSERT [dbo].[Plantilla] ([IdPlantilla], [IdTipoEncuesta], [Pregunta], [IdSeleccion]) VALUES (1, 1, N'Que equipo considera revelacion?', 2)
INSERT [dbo].[Plantilla] ([IdPlantilla], [IdTipoEncuesta], [Pregunta], [IdSeleccion]) VALUES (2, 1, N'Como considero el estado fisico de  Higuain', 3)
INSERT [dbo].[Plantilla] ([IdPlantilla], [IdTipoEncuesta], [Pregunta], [IdSeleccion]) VALUES (3, 1, N'Le gusto el mundial', 1)
INSERT [dbo].[Plantilla] ([IdPlantilla], [IdTipoEncuesta], [Pregunta], [IdSeleccion]) VALUES (4, 1, N'Si algo no le gusto indiquelo aqui', NULL)
INSERT [dbo].[Plantilla] ([IdPlantilla], [IdTipoEncuesta], [Pregunta], [IdSeleccion]) VALUES (6, 3, N'Que auto preferiria comprar?', 3)
SET IDENTITY_INSERT [dbo].[Plantilla] OFF
SET IDENTITY_INSERT [dbo].[Seleccion] ON 

INSERT [dbo].[Seleccion] ([IdSeleccion], [Descripcion]) VALUES (1, N'SI/NO')
INSERT [dbo].[Seleccion] ([IdSeleccion], [Descripcion]) VALUES (2, N'Equipo Revelacion')
INSERT [dbo].[Seleccion] ([IdSeleccion], [Descripcion]) VALUES (3, N'Estado Fisico')
INSERT [dbo].[Seleccion] ([IdSeleccion], [Descripcion]) VALUES (4, N'Auto Favorito')
SET IDENTITY_INSERT [dbo].[Seleccion] OFF
SET IDENTITY_INSERT [dbo].[TipoEncuesta] ON 

INSERT [dbo].[TipoEncuesta] ([IdTipoEncuesta], [Nombre]) VALUES (1, N'Brasil 2014')
INSERT [dbo].[TipoEncuesta] ([IdTipoEncuesta], [Nombre]) VALUES (3, N'Autos y Motos')
SET IDENTITY_INSERT [dbo].[TipoEncuesta] OFF
INSERT [dbo].[Usuario] ([Login], [Password], [Nombre], [Activo]) VALUES (N'dmaradona           ', N'maradona            ', N'Diego Maradona', 0)
INSERT [dbo].[Usuario] ([Login], [Password], [Nombre], [Activo]) VALUES (N'jperez              ', N'jperez              ', N'Juan Perez', 1)
INSERT [dbo].[Usuario] ([Login], [Password], [Nombre], [Activo]) VALUES (N'psoligo             ', N'psoligo             ', N'Pablo', 1)
ALTER TABLE [dbo].[Accesos] ADD  CONSTRAINT [DF_Accesos_FechaHora]  DEFAULT (getutcdate()) FOR [FechaHora]
GO
ALTER TABLE [dbo].[Respuesta] ADD  CONSTRAINT [DF_Pregunta_Pregunta]  DEFAULT ('No det') FOR [Pregunta]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_Activo]  DEFAULT ((0)) FOR [Activo]
GO
ALTER TABLE [dbo].[Accesos]  WITH CHECK ADD  CONSTRAINT [FK_Accesos_Usuario] FOREIGN KEY([Login])
REFERENCES [dbo].[Usuario] ([Login])
GO
ALTER TABLE [dbo].[Accesos] CHECK CONSTRAINT [FK_Accesos_Usuario]
GO
ALTER TABLE [dbo].[ElementoSeleccion]  WITH CHECK ADD  CONSTRAINT [FK_ElementoSeleccion_Seleccion] FOREIGN KEY([IdSeleccion])
REFERENCES [dbo].[Seleccion] ([IdSeleccion])
GO
ALTER TABLE [dbo].[ElementoSeleccion] CHECK CONSTRAINT [FK_ElementoSeleccion_Seleccion]
GO
ALTER TABLE [dbo].[Encuesta]  WITH CHECK ADD  CONSTRAINT [FK_Encuesta_TipoEncuesta] FOREIGN KEY([IdTipoEncuesta])
REFERENCES [dbo].[TipoEncuesta] ([IdTipoEncuesta])
GO
ALTER TABLE [dbo].[Encuesta] CHECK CONSTRAINT [FK_Encuesta_TipoEncuesta]
GO
ALTER TABLE [dbo].[Plantilla]  WITH CHECK ADD  CONSTRAINT [FK_Plantilla_Seleccion] FOREIGN KEY([IdSeleccion])
REFERENCES [dbo].[Seleccion] ([IdSeleccion])
GO
ALTER TABLE [dbo].[Plantilla] CHECK CONSTRAINT [FK_Plantilla_Seleccion]
GO
ALTER TABLE [dbo].[Plantilla]  WITH CHECK ADD  CONSTRAINT [FK_Plantilla_TipoEncuesta] FOREIGN KEY([IdTipoEncuesta])
REFERENCES [dbo].[TipoEncuesta] ([IdTipoEncuesta])
GO
ALTER TABLE [dbo].[Plantilla] CHECK CONSTRAINT [FK_Plantilla_TipoEncuesta]
GO
ALTER TABLE [dbo].[Respuesta]  WITH CHECK ADD  CONSTRAINT [FK_Pregunta_Encuesta] FOREIGN KEY([IdEncuesta])
REFERENCES [dbo].[Encuesta] ([IdEncuesta])
GO
ALTER TABLE [dbo].[Respuesta] CHECK CONSTRAINT [FK_Pregunta_Encuesta]
GO
