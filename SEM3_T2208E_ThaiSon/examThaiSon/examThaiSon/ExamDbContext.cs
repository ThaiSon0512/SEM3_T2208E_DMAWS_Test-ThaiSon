using System;
using examthaison.Models;
using Microsoft.EntityFrameworkCore;

namespace examthaison
{
	public class ExamDbContext:DbContext
	{
		public ExamDbContext(DbContextOptions<ExamDbContext>options):base(options)
		{
		}
		public DbSet<Order> OrderTbl { get; set; }
	}
}
