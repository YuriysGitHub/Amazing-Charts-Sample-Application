using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Amazing_Charts_Sample_Application
{
    public class dataFunctions
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader rdr;
        string sqlcon = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\yurad\\source\\repos\\Amazing Charts Sample Application\\Amazing Charts Sample Application\\Database1.mdf; Integrated Security = True";


        public void Edit(ContactClass contactInfo)
        {
            try
            {
                using (cn = new SqlConnection(sqlcon))
                {
                    cn.Open();
                    cmd = new SqlCommand(@"update tblContact set Name= @name, LastName= @lastName, DateOfBirth= @dateOfBirth, PhoneNumber= @phoneNumber where Id=@id ", cn);
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = contactInfo.firstName;
                    cmd.Parameters.Add("@lastName", System.Data.SqlDbType.NVarChar).Value = contactInfo.lastName;
                    cmd.Parameters.Add("@dateOfBirth", System.Data.SqlDbType.Date).Value = contactInfo.dateOfBirth.ToString("d");
                    cmd.Parameters.Add("@phoneNumber", System.Data.SqlDbType.NVarChar).Value = contactInfo.phoneNumber;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = contactInfo.id;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int Add(ContactClass contactInfo)
        {
            try
            {
                using (cn = new SqlConnection(sqlcon))
                {
                    cn.Open();
                    cmd = new SqlCommand("insert into tblContact values(@Name, @LastName, @DateOfBirth, @PhoneNumber); SELECT SCOPE_IDENTITY();", cn);
                    cmd.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = contactInfo.firstName;
                    cmd.Parameters.Add("@LastName", System.Data.SqlDbType.NVarChar).Value = contactInfo.lastName;
                    cmd.Parameters.Add("@DateOfBirth", System.Data.SqlDbType.Date).Value = contactInfo.dateOfBirth.ToString("d");
                    cmd.Parameters.Add("@PhoneNumber", System.Data.SqlDbType.NVarChar).Value = contactInfo.phoneNumber;
                    int createdId = Convert.ToInt32(cmd.ExecuteScalar());
                    return createdId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public void Delete(int id)
        {
            try
            {
                using (cn = new SqlConnection(sqlcon))
                {
                    cn.Open();
                    cmd = new SqlCommand("Delete from tblContact where Id=@id ", cn);
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;      
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<ContactClass> GetContacts()
        {   List<ContactClass> contactList = new List<ContactClass>();
            try
            {
                using (cn = new SqlConnection(sqlcon))
                {

                    cn.Open();

                    cmd = new SqlCommand("Select * from tblContact order by ID asc", cn);
                    using (rdr = cmd.ExecuteReader()){
                        while (rdr.Read())
                        {
                            var contact = new ContactClass();
                            contact.id = (int)rdr[0];
                            contact.firstName = (string)rdr[1];
                            contact.lastName = (string)rdr[2];
                            contact.dateOfBirth = (DateTime)rdr[3];
                            contact.phoneNumber = (string)rdr[4];
                            contactList.Add(contact);
                            

                        }
                        return contactList;
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
       
    }
}

