-- =============================================  
-- Author:      Italo Gomes 
-- Create date: 31/08/2023 
-- Description: Procedure para salvar um registro na tabela produtos.  
-- =============================================  
  
/*  
  
 Id int,  
    nome varchar(150),  
    price numeric(10,2),  
    brand varchar(150),  
    updatedAt DateTime,  
 createdAt DateTime  
  
*/  
  
  
  
Alter PROCEDURE [dbo].[SaveProdutos]  
(  
@Id INT,  
@Name NVARCHAR(MAX),  
@Price Numeric(10,2),  
@brand NVARCHAR(200),  
@updatedAt DateTime,  
@createdAt DateTime  
)  
AS  
BEGIN   
  
   IF (EXISTS(SELECT ID FROM Produtos WHERE (id = @Id))) 
	Begin

	 SELECT * FROM Produtos  where Id = @Id
	End
  ELSE
	Begin
		INSERT INTO Produtos(Id,nome,price,brand,updatedAt,createdAt)  
        VALUES (@Id,@Name,@Price,@brand,@updatedAt,@createdAt)

		SELECT * FROM Produtos  where Id = @Id
	End
	

    
END