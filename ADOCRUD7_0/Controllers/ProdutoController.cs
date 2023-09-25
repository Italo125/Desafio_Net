
using Desafio_Net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;


namespace Desafio_Net.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ProdutoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [Route("GetProdutos")]
        [HttpGet]
        public async Task<IActionResult> GetProdutos()
        {

            try
            {


                List<ProdutoModel> productModels = new List<ProdutoModel>();
                DataTable dt = new DataTable();
                SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                SqlCommand cmd = new SqlCommand("GetProdutos", con);
                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProdutoModel productModel = new ProdutoModel();
                    productModel.ID = Convert.ToInt32(dt.Rows[i]["Id"]);
                    productModel.Name = dt.Rows[i]["nome"].ToString();
                    productModel.Price = Convert.ToDecimal(dt.Rows[i]["price"]);
                    productModel.brand = dt.Rows[i]["brand"].ToString();
                    productModel.createdAt = Convert.ToDateTime(dt.Rows[i]["createdAt"]);

                    if (dt.Rows[i]["updatedAt"] == " ")
                    {


                        productModel.updatedAt = Convert.ToDateTime(dt.Rows[i]["updatedAt"]);
                    }
                    else
                    {
                        productModel.updatedAt = System.DateTime.Now;

                    }



                    productModels.Add(productModel);
                }
                return Ok(productModels);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [Route("GetIdProdutos")]
        [HttpGet]
        public async Task<IActionResult> GetIdProdutos(int Id)
        {
            try
            {



                List<ProdutoModel> productModels = new List<ProdutoModel>();
                DataTable dt = new DataTable();
                SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                SqlCommand cmd = new SqlCommand("GetIDProdutos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", Id));


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProdutoModel productModel = new ProdutoModel();
                    productModel.ID = Convert.ToInt32(dt.Rows[i]["Id"]);
                    productModel.Name = dt.Rows[i]["nome"].ToString();
                    productModel.Price = Convert.ToDecimal(dt.Rows[i]["price"]);
                    productModel.brand = dt.Rows[i]["brand"].ToString();
                    productModel.createdAt = Convert.ToDateTime(dt.Rows[i]["createdAt"]);

                    if (dt.Rows[i]["updatedAt"] == " ")
                    {


                        productModel.updatedAt = Convert.ToDateTime(dt.Rows[i]["updatedAt"]);
                    }
                    else
                    {
                        productModel.updatedAt = System.DateTime.Now;

                    }



                    productModels.Add(productModel);
                }
                return Ok(productModels);
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

        [Route("SaveProduto")]
        [HttpPost]
        public async Task<IActionResult> SaveProduto(int Id, string nome, decimal price, string brand, DateTime updatedAt, DateTime createdAt)
        {
            try
            {

                List<ProdutoModel> productModels = new List<ProdutoModel>();
                DataTable dt = new DataTable();
                SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                SqlCommand cmd = new SqlCommand("SaveProdutos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", Id));
                cmd.Parameters.Add(new SqlParameter("@Name", nome));
                cmd.Parameters.Add(new SqlParameter("@Price", price));
                cmd.Parameters.Add(new SqlParameter("@brand", brand));
                cmd.Parameters.Add(new SqlParameter("@updatedAt", updatedAt));
                cmd.Parameters.Add(new SqlParameter("@createdAt", createdAt));
                con.Open();
                cmd.ExecuteNonQuery();
               
                


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProdutoModel productModel = new ProdutoModel();
                    productModel.ID = Convert.ToInt32(dt.Rows[i]["Id"]);
                    productModel.Name = dt.Rows[i]["nome"].ToString();
                    productModel.Price = Convert.ToDecimal(dt.Rows[i]["price"]);
                    productModel.brand = dt.Rows[i]["brand"].ToString();
                    productModel.createdAt = Convert.ToDateTime(dt.Rows[i]["createdAt"]);
                    productModel.updatedAt = Convert.ToDateTime(dt.Rows[i]["updatedAt"]);




                    productModels.Add(productModel);
                }

                
                con.Close();
                return Ok(productModels);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [Route("UpdateProduto")]
        [HttpPut]
        public async Task<IActionResult> UpdateProduto(int Id , string nome, decimal price, string brand, DateTime updatedAt, DateTime createdAt)
        {
            try
            {

                List<ProdutoModel> productModels = new List<ProdutoModel>();
                DataTable dt = new DataTable();
                SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                SqlCommand cmd = new SqlCommand("UpdatProdutos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", Id));
                cmd.Parameters.Add(new SqlParameter("@Name", nome));
                cmd.Parameters.Add(new SqlParameter("@Price", price));
                cmd.Parameters.Add(new SqlParameter("@brand", brand));
                cmd.Parameters.Add(new SqlParameter("@updatedAt", updatedAt));
                cmd.Parameters.Add(new SqlParameter("@createdAt", createdAt));
                con.Open();
                cmd.ExecuteNonQuery();




                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProdutoModel productModel = new ProdutoModel();
                    productModel.ID = Convert.ToInt32(dt.Rows[i]["Id"]);
                    productModel.Name = dt.Rows[i]["nome"].ToString();
                    productModel.Price = Convert.ToDecimal(dt.Rows[i]["price"]);
                    productModel.brand = dt.Rows[i]["brand"].ToString();
                    productModel.createdAt = Convert.ToDateTime(dt.Rows[i]["createdAt"]);
                    productModel.updatedAt = Convert.ToDateTime(dt.Rows[i]["updatedAt"]);




                    productModels.Add(productModel);
                }

                
                con.Close();
                return Ok(productModels);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [Route("DeleteProduto")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProduto(int Id)
        {
            try
            {

                List<ProdutoModel> productModels = new List<ProdutoModel>();
                DataTable dt = new DataTable();
                SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
                SqlCommand cmd = new SqlCommand("DeleteProdutos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", Id));               
                con.Open();
                cmd.ExecuteNonQuery();




                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ProdutoModel productModel = new ProdutoModel();
                    productModel.ID = Convert.ToInt32(dt.Rows[i]["Id"]);
                    productModel.Name = dt.Rows[i]["nome"].ToString();
                    productModel.Price = Convert.ToDecimal(dt.Rows[i]["price"]);
                    productModel.Name = dt.Rows[i]["brand"].ToString();
                    productModel.createdAt = Convert.ToDateTime(dt.Rows[i]["createdAt"]);
                    productModel.updatedAt = Convert.ToDateTime(dt.Rows[i]["updatedAt"]);




                    productModels.Add(productModel);
                }

               
                con.Close();
                return Ok(productModels);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





    }
}
