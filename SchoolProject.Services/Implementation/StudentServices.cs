using SchoolProject.Data.Entities;
using SchoolProject.infrastructure.Data;
using SchoolProject.infrastructure.IRepositories;
using SchoolProject.Services.Apstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Services.Implementation
{
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _studentRepository;
        public StudentServices(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<Student>> GetStudentsListAscnc()
        {
            return await _studentRepository.GetStudentListAsync();
        }
    }
}
