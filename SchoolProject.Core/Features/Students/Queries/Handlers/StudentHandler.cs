using AutoMapper;
using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
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
    public class StudentHandler : IRequestHandler<GetStudentListQuery, List<GetStudentListResponse>>
    {
        private readonly IStudentServices _studentServices;
        private readonly IMapper _mapper;
        public StudentHandler(IStudentServices studentServices, IMapper mapper)
        {
            _studentServices = studentServices;
            _mapper = mapper;
        }
        public async Task<List<GetStudentListResponse>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _studentServices.GetStudentsListAscnc();
            var studentListMapper = _mapper.Map<List<GetStudentListResponse>>(studentList);
            return studentListMapper;
        }
    }
}
