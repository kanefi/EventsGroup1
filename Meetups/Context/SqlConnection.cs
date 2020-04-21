using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Meetups.Context
{
    public class SqlConnection
    {
        public string _cnnstring = "server=db-workshop.public-dev.zuto.cloud;user=bootcamp6;database=bootcamp6;port=3306;password=SimpleKettle";

        public async Task OpenConnection()
        {
            try
            {
                using (MySqlConnection cnn = new MySqlConnection(_cnnstring))
                {
                    await cnn.OpenAsync();

                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
