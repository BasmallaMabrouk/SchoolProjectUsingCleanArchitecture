using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Services.Apstract
{
    public interface IStudentServices
    {
        public Task<List<Student>> GetStudentsListAscnc();
    }
}
