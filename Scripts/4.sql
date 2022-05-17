USE [Employees]
GO

/****** Object:  Table [dbo].[Supervisor]    Script Date: 5/17/2022 1:32:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Supervisor](
	[Id] [int] NOT NULL,
	[AnnualSalary] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Supervisor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Supervisor]  WITH CHECK ADD  CONSTRAINT [FK_Supervisor_Employee] FOREIGN KEY([Id])
REFERENCES [dbo].[Employee] ([Id])
GO

ALTER TABLE [dbo].[Supervisor] CHECK CONSTRAINT [FK_Supervisor_Employee]
GO


