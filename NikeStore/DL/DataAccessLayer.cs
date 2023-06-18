using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NikeStore.DL
{
    internal class DataAccessLayer
    {
        private readonly static string connectionString = "Server = ASUS-20XX\\SQLEXPRESS;Database=NikeStore;Trusted_Connection=True;";
        private static SqlConnection _connection;

        #region Customer
        public static bool AddCustomer(Customer customer)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_AddCustomer", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", customer.Id);
                cmd.Parameters.AddWithValue("name", customer.Name);
                cmd.Parameters.AddWithValue("surname", customer.Surname);
                cmd.Parameters.AddWithValue("phone", customer.Phone);
                cmd.Parameters.AddWithValue("mail", customer.Mail);
                cmd.Parameters.AddWithValue("address", customer.Address);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }
        public static bool DeleteCustomer(Guid customerId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_DeleteCustomer", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", customerId);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }
        public static bool UpdateCustomer(Customer customer)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_UpdateCustomer", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", customer.Id);
                cmd.Parameters.AddWithValue("name", customer.Name);
                cmd.Parameters.AddWithValue("surname", customer.Surname);
                cmd.Parameters.AddWithValue("phone", customer.Phone);
                cmd.Parameters.AddWithValue("mail", customer.Mail);
                cmd.Parameters.AddWithValue("address", customer.Address);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }
        public static DataSet GetCustomers(string search = default)
        {
            try
            {
                SqlCommand cmd;
                if (!string.IsNullOrWhiteSpace(search))
                {
                    cmd = new SqlCommand("Nike_SearchCustomers", GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("search", search);
                }
                else
                {
                    cmd = new SqlCommand("Nike_GetCustomers", GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }
        #endregion

        #region Product
        public static bool AddProduct(Product product)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_AddProduct", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", product.Id);
                cmd.Parameters.AddWithValue("name", product.Name);
                cmd.Parameters.AddWithValue("price", product.Price);
                cmd.Parameters.AddWithValue("unitprice", product.UnitPrice);
                cmd.Parameters.AddWithValue("stockAmount", product.StockAmount);
                cmd.Parameters.AddWithValue("category", product.Category);
                cmd.Parameters.AddWithValue("detail", product.Detail);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }
        public static bool DeleteProduct(Guid productId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_DeleteProduct", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", productId);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }
        public static bool UpdateProduct(Product product)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_UpdateProduct", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", product.Id);
                cmd.Parameters.AddWithValue("name", product.Name);
                cmd.Parameters.AddWithValue("price", product.Price);
                cmd.Parameters.AddWithValue("unitprice", product.UnitPrice);
                cmd.Parameters.AddWithValue("stockAmount", product.StockAmount);
                cmd.Parameters.AddWithValue("category", product.Category);
                cmd.Parameters.AddWithValue("detail", product.Detail);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }
        public static DataSet GetProducts(string search = default)
        {
            try
            {
                SqlCommand cmd;
                if (!string.IsNullOrWhiteSpace(search))
                {
                    cmd = new SqlCommand("Nike_SearchProducts", GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("search", search);
                }
                else
                {
                    cmd = new SqlCommand("Nike_GetProducts", GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }
        #endregion

        #region Satış Tablosu İşlemleri
        public static bool AddSale(Sale sale)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_AddSale", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sid", sale.Id);
                cmd.Parameters.AddWithValue("mid", sale.Customer.Id);
                cmd.Parameters.AddWithValue("uid", sale.Product.Id);
                cmd.Parameters.AddWithValue("tarih", sale.SaleDate);
                cmd.Parameters.AddWithValue("fiyat", sale.SalePrice);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }

        public static DataSet GetSales(string search = default)
        {
            try
            {
                SqlCommand cmd;
                if (!string.IsNullOrWhiteSpace(search))
                {
                    cmd = new SqlCommand("Nike_SearchSales", GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("search", search);
                }
                else
                {
                    cmd = new SqlCommand("Nike_GetSales", GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }

        public static DataSet GetSaleById(Guid id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_GetSaleById", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", id);

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }

        public static bool UpdateSale(Sale sale)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_UpdateSale", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("sid", sale.Id);
                cmd.Parameters.AddWithValue("mid", sale.Customer.Id);
                cmd.Parameters.AddWithValue("uid", sale.Product.Id);
                cmd.Parameters.AddWithValue("tarih", sale.SaleDate);
                cmd.Parameters.AddWithValue("fiyat", sale.SalePrice);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }

        public static bool DeleteSale(Guid saleId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_DeleteSale", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", saleId);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }
        #endregion

        #region Ödeme Tablosu İşlemleri
        public static bool AddPayment(Payment payment)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_AddPayment", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("oid", payment.Id);
                cmd.Parameters.AddWithValue("mid", payment.Customer.Id);
                cmd.Parameters.AddWithValue("tarih", payment.TransactionDate);
                cmd.Parameters.AddWithValue("tutar", payment.Amount);
                cmd.Parameters.AddWithValue("tur", payment.PaymentType);
                cmd.Parameters.AddWithValue("aciklama", payment.Description);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }

        public static DataSet GetPayments(string search = default)
        {
            try
            {
                SqlCommand cmd;
                if (!string.IsNullOrWhiteSpace(search))
                {
                    cmd = new SqlCommand("Nike_SearchPayments", GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("search", search);
                }
                else
                {
                    cmd = new SqlCommand("Nike_GetPayments", GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                }

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }

        public static DataSet GetPaymentById(Guid id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_GetPaymentById", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", id);

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }

        public static bool UpdatePayment(Payment payment)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_UpdatePayment", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("oid", payment.Id);
                cmd.Parameters.AddWithValue("mid", payment.Customer.Id);
                cmd.Parameters.AddWithValue("tarih", payment.TransactionDate);
                cmd.Parameters.AddWithValue("tutar", payment.Amount);
                cmd.Parameters.AddWithValue("tur", payment.PaymentType);
                cmd.Parameters.AddWithValue("aciklama", payment.Description);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }

        public static bool DeletePayment(Guid paymentId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Nike_DeletePayment", GetConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", paymentId);

                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }
        #endregion

        #region Çalışan İşlemleri
        public static User GetUserByUsername(string username)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Users WHERE Username = @username", GetConnection());
                command.Parameters.AddWithValue("username", username);

                using SqlDataReader reader = command.ExecuteReader();
                if (!reader.Read()) return null;

                var user = new User
                {
                    Id = reader.GetGuid("Id"),
                    Username = reader.GetString("Username"),
                    PasswordHash = reader.GetString("PasswordHash"),
                    PasswordSalt = (byte[])reader.GetValue("PasswordSalt")
                };

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }

        public static bool AddUser(User user)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    @"INSERT Users 
                      VALUES (@id, @name, @surname, @username, @email, @passwordHash, @passwordSalt)", GetConnection());
                command.Parameters.AddWithValue("id", user.Id);
                command.Parameters.AddWithValue("name", user.Name);
                command.Parameters.AddWithValue("surname", user.Surname);
                command.Parameters.AddWithValue("username", user.Username);
                command.Parameters.AddWithValue("email", user.Email);
                command.Parameters.AddWithValue("passwordHash", user.PasswordHash);
                command.Parameters.AddWithValue("passwordSalt", user.PasswordSalt);

                command.CommandType = CommandType.Text;
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open) { _connection.Close(); }
            }
        }       
        #endregion

        private static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(connectionString);
            }

            if (_connection.State != ConnectionState.Open) { _connection.Open(); }

            return _connection;
        }
    }
}
