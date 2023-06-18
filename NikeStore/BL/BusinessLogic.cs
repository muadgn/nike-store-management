using NikeStore.DL;
using System.Data;

namespace NikeStore.BL
{
    public class BusinessLogic
    {
        #region Müşteri İşlemleri
        public static bool DeleteCustomer(Guid customerId)
        {
            try
            {
                return DataAccessLayer.DeleteCustomer(customerId);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool UpdateCustomer(Customer customer)
        {
            try
            {
                return DataAccessLayer.UpdateCustomer(customer);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool AddCustomer(Customer customer)
        {
            try
            {
                return DataAccessLayer.AddCustomer(customer);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Tüm müşterileri getirir. Search parametresi bulunuyorsa filtreleme yaparak listeler.
        /// </summary>
        /// <returns></returns>
        public static DataSet GetCustomers(string search)
        {
            try
            {
                DataSet ds = DataAccessLayer.GetCustomers(search);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteriler getirilirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new DataSet();
        }
        #endregion

        #region Ürün İşlemleri
        public static bool AddProduct(Product product)
        {
            try
            {
                return DataAccessLayer.AddProduct(product);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool UpdateProduct(Product product)
        {
            try
            {
                return DataAccessLayer.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DeleteProduct(Guid productId)
        {
            try
            {
                return DataAccessLayer.DeleteProduct(productId);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Tüm ürünleri getirir. Search parametresi bulunuyorsa filtreleme yaparak listeler.
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public static DataSet GetProducts(string search)
        {
            try
            {
                DataSet ds = DataAccessLayer.GetProducts(search);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ürünler getirilirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new DataSet();
        }

        internal static object DeleteProduct(object productId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Satış İşlemleri
        public static bool AddSale(Sale sale)
        {
            try
            {
                return DataAccessLayer.AddSale(sale);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataSet GetSales(string search)
        {
            try
            {
                DataSet ds = DataAccessLayer.GetSales(search);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Satışlar getirilirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new DataSet();
        }

        public static Sale GetSaleById(Guid id)
        {
            try
            {
                var dataSet = DataAccessLayer.GetSaleById(id);
                var row = dataSet.Tables[0].Rows[0];

                return new Sale
                {
                    Id = id,
                    SaleDate = DateTime.Parse(row["SaleDate"]?.ToString()),
                    SalePrice = Convert.ToDouble(row["SalePrice"]?.ToString()),
                    Customer = new Customer
                    {
                        Id = Guid.Parse(row["CustomerId"]?.ToString()),
                        Name = row["CustomerName"]?.ToString(),
                        Surname = row["CustomerSurname"]?.ToString(),
                    },
                    Product = new Product
                    {
                        Id = Guid.Parse(row["ProductId"]?.ToString()),
                        Name = row["ProductName"]?.ToString(),
                    }
                };
            }
            catch (Exception)
            {
                MessageBox.Show("Satış bilgisi getirilirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Sale
                {
                    Id = id,
                };
            }
        }
        public static bool UpdateSale(Sale sale)
        {
            try
            {
                return DataAccessLayer.UpdateSale(sale);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DeleteSale(Guid saleId)
        {
            try
            {
                return DataAccessLayer.DeleteSale(saleId);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Ödeme İşlemleri
        public static bool AddPayment(Payment payment)
        {
            try
            {
                return DataAccessLayer.AddPayment(payment);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataSet GetPayments(string search)
        {
            try
            {
                DataSet ds = DataAccessLayer.GetPayments(search);
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Ödemeler getirilirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new DataSet();
        }

        public static Payment GetPaymentById(Guid id)
        {
            try
            {
                var dataSet = DataAccessLayer.GetPaymentById(id);
                var row = dataSet.Tables[0].Rows[0];

                return new Payment
                {
                    Id = id,
                    Amount = (double)row["Amount"],
                    Description = row["Description"]?.ToString(),
                    PaymentType = row["PaymentType"]?.ToString(),
                    TransactionDate = DateTime.Parse(row["TransactionDate"]?.ToString()),
                    Customer = new Customer
                    {
                        Id = Guid.Parse(row["CustomerId"]?.ToString()),
                        Name = row["CustomerName"]?.ToString(),
                        Surname = row["CustomerSurname"]?.ToString(),
                    }
                };
            }
            catch (Exception)
            {
                MessageBox.Show("Satış bilgisi getirilirken bir sorun oluştu.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Payment
                {
                    Id = id,
                };
            }
        }

        public static bool UpdatePayment(Payment payment)
        {
            try
            {
                return DataAccessLayer.UpdatePayment(payment);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DeletePayment(Guid paymentId)
        {
            try
            {
                return DataAccessLayer.DeletePayment(paymentId);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion


        #region Kullanıcı İşlemleri
        public static User UserLogin(string username, string password)
        {
            try
            {
                var user = DataAccessLayer.GetUserByUsername(username);
                if (user is null) return null;

                if(!Security.VerifyPassword(password, user.PasswordHash, user.PasswordSalt))
                    return null;

                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool UserRegister(User user)
        {
            try
            {
                var userExist = DataAccessLayer.GetUserByUsername(user.Username);
                if(userExist is not null) 
                    return false;

                var passwordHash = Security.HashPasword(user.PasswordClear, out byte[] passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;

                var result = DataAccessLayer.AddUser(user);

                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}

