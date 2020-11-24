using ADOLibrary;
using MovieRental.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Linq;


namespace MovieRental.DAL.Services
{
   public class CustomerService : ServiceBase<int, Customer>
    {


        public Customer CheckCustomer(Customer customer)
        {
            Command cmd = new Command("MVSP_CheckUser", true);
            cmd.AddParameter("Email", customer.Email);
            cmd.AddParameter("Passwd", customer.Passwd);
            return connection.ExecuteReader<Customer>(cmd, Converter).SingleOrDefault();
        }

        private Customer Converter(SqlDataReader reader)
        {
            return new Customer(
                (int)reader["CustomerId"],
                reader["LastName"].ToString(),
                reader["FirstName"].ToString(),
                reader["Email"].ToString()
                );

        }

        public override bool Delete(int key)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Customer GetById(int key)
        {
            throw new NotImplementedException();
        }

        public override int Insert(Customer entity)
        {
            Command cmd = new Command("MVSP_RegisterUser", true);
            cmd.AddParameter("LastName", entity.LastName);
            cmd.AddParameter("FirstName", entity.FirstName);
            cmd.AddParameter("Email", entity.Email);
            cmd.AddParameter("Passwd", entity.Passwd);
            return connection.ExecuteNonQuery(cmd);
        }

        public override bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
