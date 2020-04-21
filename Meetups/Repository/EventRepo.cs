using Meetups.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Meetups.Repository
{
    public class EventRepo : IEventRepo
    {
        public string _cnnstring = "server=db-workshop.public-dev.zuto.cloud;user=bootcamp6;database=bootcamp6;port=3306;password=SimpleKettle";

        public async Task<IEnumerable<Event>> GetEventsAsync()
        {
            var events = new List<Event>();

            try
            {
                using (MySqlConnection cnn = new MySqlConnection(_cnnstring))
                {
                    await cnn.OpenAsync();

                    using (var cmd = new MySqlCommand("SELECT * FROM Event", cnn))
                    {
                        using (var dr = await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection))
                        {
                            while (dr.Read())
                            {
                                events.Add(new Event
                                {
                                    Location = dr["Location"].ToString(),
                                    Description = dr["Description"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
            return events;
        }
    }
}