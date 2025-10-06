using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.infrastructure.Data;
using SchoolProject.infrastructure.InfrastructureBases;
using SchoolProject.infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.infrastructure.Reposotories
{
    public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
    {
     //   private readonly ApplicationDbContext _db;
        private readonly DbSet<Student> _students;
        //private readonly object _student;

        public StudentRepository(ApplicationDbContext db):base(db)
        {
            _students =db.Set<Student>();
        }
        public async Task<List<Student>> GetStudentListAsync()
        {
            return await _students.Include(x=>x.Department).ToListAsync();
        }
    }
}
