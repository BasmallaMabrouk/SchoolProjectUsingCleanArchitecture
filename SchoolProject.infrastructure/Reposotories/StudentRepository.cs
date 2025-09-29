using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.infrastructure.Data;
using SchoolProject.infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.infrastructure.Reposotories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _db;
        public StudentRepository(ApplicationDbContext db)
        {
            _db =db;
        }
        public async Task<List<Student>> GetStudentListAsync()
        {
            return await _db.students.Include(x=>x.Department).ToListAsync();
        }
    }
}
