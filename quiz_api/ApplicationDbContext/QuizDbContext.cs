using Microsoft.EntityFrameworkCore;
using quiz_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_api.ApplicationDbContext
{
    public class QuizDbContext : DbContext
    {

        public QuizDbContext(DbContextOptions<QuizDbContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Participant> Participants { get; set; }
    }
}
