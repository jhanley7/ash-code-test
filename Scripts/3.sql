USE [Employees]
GO

/****** Object:  Table [dbo].[Manager]    Script Date: 5/17/2022 1:32:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Manager](
	[Id] [int] NOT NULL,
	[MaxExpenseAmount] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Manager]  WITH CHECK ADD  CONSTRAINT [FK_Manager_Supervisor] FOREIGN KEY([Id])
REFERENCES [dbo].[Supervisor] ([Id])
GO

ALTER TABLE [dbo].[Manager] CHECK CONSTRAINT [FK_Manager_Supervisor]
GO


