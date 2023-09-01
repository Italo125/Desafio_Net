
-- =============================================
-- Author:      Italo Gomes
-- Create date: 31/08/2023
-- Description: Procedure para trazer todos os registros da tabela Produtos
-- EXEC GetProdutos
-- =============================================
Alter PROCEDURE [dbo].[GetProdutos]
AS
BEGIN
  
    SELECT * FROM Produtos  order BY Id ASC
END