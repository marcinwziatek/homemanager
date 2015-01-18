using System;
using Core.Data.MySql;
using Core.Models.Multithreading;

namespace Infrastructure.Data.Repositories
{
    public class SaveResultsRepository
    {
        public void CreateTest()
        {
            using (var ctx = new MySqlContext())
            {
                var testResult = new Result
                {
                    ComputerName = "Nowy",
                    CoreNo = 8,
                    ProcessingTime = 10,
                    StarTime = DateTime.Now
                };

                ctx.Results.Add(testResult);
                ctx.SaveChanges();
            }
        }
    }
}