using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Audit.Data
{
    public class AuditContext : DbContext
    {
        public AuditContext(string cs) : base() { }

        public AuditContext(DbContextOptions<AuditContext> options)
            : base(options)
        { }

        public DbSet<AuditLog> AuditLogs { get; set; }
    }

    public class AuditLog
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string LogMessage { get; set; }
    }
}
