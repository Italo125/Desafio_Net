-- =============================================  
-- Author:      Italo gomes  
-- Create date: 31/08/2023
-- Description: Procedure para fazar alteração de registro na tabela Produtos  
-- =============================================  
  
/*  
  
 Id int,  
    nome varchar(150),  
    price numeric(10,2),  
    brand varchar(150),  
    updatedAt DateTime,  
 createdAt DateTime  
  
*/  
  
  
 Alter PROCEDURE [dbo].[UpdatProdutos]  
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

	 UPDATE Produtos
	 SET nome = @Name,
	 price = @Price,
	 brand = @brand,
	 updatedAt = Getdate(),
	 createdAt = @createdAt
	WHERE Id = @Id;


	Select * from Produtos where id = @Id

	End
 

    
END