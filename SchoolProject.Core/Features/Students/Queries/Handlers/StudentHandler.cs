using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.Entities;
using SchoolProject.infrastructure.IRepositories;
using SchoolProject.Services.Apstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler : IRequestHandler<GetStudendListQuery, List<Student>>
    {
        private readonly IStudentServices _studentServices;
        public StudentHandler(IStudentServices studentServices)
        {
            _studentServices = studentServices; 
        }
        public async Task<List<Student>> Handle(GetStudendListQuery request, CancellationToken cancellationToken)
        {
            return await _studentServices.GetStudentsListAscnc();
        }
    }
}
