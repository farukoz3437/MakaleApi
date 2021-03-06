USE [ArticleDb]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 10/11/2020 3:42:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[ArticleId] [int] IDENTITY(1,1) NOT NULL,
	[ArticleName] [nvarchar](250) NULL,
	[ArticleContent] [nvarchar](max) NULL,
	[ArticleReleaseDate] [date] NULL,
	[ArticleCreateDate] [date] NULL,
	[AuthorId] [int] NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[ArticleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 10/11/2020 3:42:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorId] [int] IDENTITY(1,1) NOT NULL,
	[AuthorName] [nvarchar](100) NULL,
	[AuthorSurname] [nvarchar](100) NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Articles] ON 

INSERT [dbo].[Articles] ([ArticleId], [ArticleName], [ArticleContent], [ArticleReleaseDate], [ArticleCreateDate], [AuthorId]) VALUES (1, N'Deneme', N'Deneme makale', CAST(N'0001-01-01' AS Date), CAST(N'0001-01-01' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Articles] OFF
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [AuthorSurname]) VALUES (1, N'Omer Faruk', N'ÖZ')
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [AuthorSurname]) VALUES (2, N'Volkan', N'TAVADOĞLU')
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [AuthorSurname]) VALUES (3, N'Fatih', N'DURMUŞ')
INSERT [dbo].[Authors] ([AuthorId], [AuthorName], [AuthorSurname]) VALUES (4, N'Emre', N'TEKE')
SET IDENTITY_INSERT [dbo].[Authors] OFF
