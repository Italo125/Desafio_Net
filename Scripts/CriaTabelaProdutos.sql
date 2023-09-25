-- =============================================
-- Author:      Italo gomes
-- Create date: 31/08/2023
-- Description: Cria Tabela Produtos (Simples)
-- =============================================

CREATE TABLE [dbo].[Produtos](
	[Id] [int] NULL,
	[nome] [varchar](150) NULL,
	[price] [numeric](10, 2) NULL,
	[brand] [varchar](150) NULL,
	[updatedAt] [datetime] NULL,
	[createdAt] [datetime] NULL
) ON [PRIMARY]
GO


