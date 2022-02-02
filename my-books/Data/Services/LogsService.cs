using my_books.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace my_books.Data.Services
{
    public class LogsService
    {
        private AppDbContext _context;
        public LogsService(AppDbContext context)
        {
            this._context = context;
        }

        public List<Log> GetAllLogsFromDB()
        {
          return  _context.Logs.ToList();
        }
    }
}
