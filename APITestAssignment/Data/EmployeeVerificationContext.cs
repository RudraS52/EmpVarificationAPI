using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using APITestAssignment.Controllers;
using static APITestAssignment.Controllers.VerifyEmploymentController;

namespace APITestAssignment.Models
{
    
        public class EmployeeVerificationContext : DbContext
        {
            public EmployeeVerificationContext(DbContextOptions<EmployeeVerificationContext> options)
        : base(options)
        {
        }

            public DbSet<VerifyEmploymentRequests> VerifyEmploymentRequests { get; set; }
        }

       


        }


