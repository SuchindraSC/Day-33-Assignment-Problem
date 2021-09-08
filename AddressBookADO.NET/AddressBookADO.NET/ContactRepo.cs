using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace AddressBookADO.NET
{
    public class ContactRepo
    {
        public static string connectionString = @"Data Source=(LocalDb)\localdb;Initial Catalog=addressbook;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public bool AddEmployee(ContactModel model)
        {
            try
            {
                using (this.connection)
                {

                    SqlCommand command = new SqlCommand("SpAddPersonDetails", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", model.firstName);
                    command.Parameters.AddWithValue("@LastName", model.lastName);
                    command.Parameters.AddWithValue("@Address", model.address);
                    command.Parameters.AddWithValue("@PhoneNumber", model.phoneNumber);
                    command.Parameters.AddWithValue("@zip", model.zip);
                    command.Parameters.AddWithValue("@City", model.city);
                    command.Parameters.AddWithValue("@State", model.state);
                    command.Parameters.AddWithValue("@Email", model.emailId);
                    command.Parameters.AddWithValue("@AddressBookName", model.addressBookName);
                    command.Parameters.AddWithValue("@Type", model.type);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }
    }
}
