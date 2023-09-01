
-- =============================================
-- Author:      Italo Gomes
-- Create date: 31/08/2023
-- Description: Procedure para trazaer dados da tabela Produtos pelo ID
-- EXEC GetProdutos
-- =============================================
create PROCEDURE [dbo].[GetIdProdutos]
(
@Id INT
)
AS
BEGIN
 
    SELECT * FROM Produtos  where Id = @Id
END

delete from Produtos where Id = 3