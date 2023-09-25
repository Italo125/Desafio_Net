-- =============================================  
-- Author:      Italo Gomes
-- Create date: 31/08/2023 
-- Description: procedure para deletear um redgistro da Tabela Produto pelo Id  
-- =============================================  
  
/*  
  
 Id int,  
    nome varchar(150),  
    price numeric(10,2),  
    brand varchar(150),  
    updatedAt DateTime,  
 createdAt DateTime  
  
*/  
  
  
 Alter PROCEDURE [dbo].[DeleteProdutos]  
(  
@Id INT 
 
)  
AS  
BEGIN   
  
   IF (EXISTS(SELECT ID FROM Produtos WHERE (id = @Id))) 
	Begin

	 Delete from Produtos
	WHERE Id = @Id;


	Select * from Produtos 

	End
 

    
END