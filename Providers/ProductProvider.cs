using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;
using YStore;
using YStore.Models;
using YStore.Providers;

public interface IProductProvider
{
    IEnumerable<Product> GetProducts();
    Product GetProductById(int productId);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(int productId);
}

public class ProductProvider : IProductProvider
{
    private readonly string _connectionString;

    public ProductProvider(IOptions<AppSettings> settings)
    {
        _connectionString = settings.Value.ConnectionString;
    }

    public IEnumerable<Product> GetProducts()
    {
        var products = new List<Product>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand("GetAllProducts", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            ProductId = Convert.ToInt32(reader["ProductId"]),
                            ProductName = reader["ProductName"].ToString(),
                            Description = reader["Description"] as string,
                            Price = Convert.ToInt32(reader["Price"]),
                            StockQuantity = Convert.ToInt32(reader["StockQuantity"])
                        });
                    }
                }
            }
        }

        return products;
    }

    public Product GetProductById(int productId)
    {
        Product product = null;

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand("GetProductById", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new Product
                        {
                            ProductId = Convert.ToInt32(reader["ProductId"]),
                            ProductName = reader["ProductName"].ToString(),
                            Description = reader["Description"] as string,
                            Price = Convert.ToInt32(reader["Price"]),
                            StockQuantity = Convert.ToInt32(reader["StockQuantity"])
                        };
                    }
                }
            }
        }

        return product;
    }

    public void AddProduct(Product product)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand("AddProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                var parameters = new SqlParameterBuilder()
                    .Add("@ProductName", SqlDbType.NVarChar, product.ProductName, 100)
                    .Add("@Description", SqlDbType.NVarChar, product.Description, 500)
                    .Add("@Price", SqlDbType.Decimal, product.Price)
                    .Add("@StockQuantity", SqlDbType.Int, product.StockQuantity)
                    .Build();

                command.Parameters.AddRange(parameters);

                SqlParameter outParam = new SqlParameter("@NewProductId", SqlDbType.Int);
                outParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(outParam);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public void UpdateProduct(Product product)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand("UpdateProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                var parameters = new SqlParameterBuilder()
                    .Add("@ProductId", SqlDbType.Int, product.ProductId)
                    .Add("@ProductName", SqlDbType.NVarChar, product.ProductName, 100)
                    .Add("@Description", SqlDbType.NVarChar, product.Description, 500)
                    .Add("@Price", SqlDbType.Decimal, product.Price)
                    .Add("@StockQuantity", SqlDbType.Int, product.StockQuantity)
                    .Build();

                command.Parameters.AddRange(parameters);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteProduct(int productId)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            using (SqlCommand command = new SqlCommand("DeleteProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;

                var parameters = new SqlParameterBuilder()
                    .Add("@ProductId", SqlDbType.Int, productId)
                    .Build();

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
