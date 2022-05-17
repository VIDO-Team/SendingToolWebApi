using SendingTool.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace SendingTool.Data
{
    public class SinhvienTTDbContext : DbContext
    {
        public SinhvienTTDbContext(DbContextOptions<SinhvienTTDbContext> opt ) :base(opt)
        {

        }
        public DbSet<SinhvienTT> DataTuyenSinh2022 {get;set;}
    }
}