USE [Employees]
GO

/****** Object:  Table [dbo].[HourlyEmployee]    Script Date: 5/17/2022 1:34:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HourlyEmployee](
	[Id] [int] NOT NULL,
	[PayPerHour] [decimal](5, 2) NOT NULL,
 CONSTRAINT [PK_HourlyEmployee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HourlyEmployee]  WITH CHECK ADD  CONSTRAINT [FK_HourlyEmployee_Employee] FOREIGN KEY([Id])
REFERENCES [dbo].[Employee] ([Id])
GO

ALTER TABLE [dbo].[HourlyEmployee] CHECK CONSTRAINT [FK_HourlyEmployee_Employee]
GO


