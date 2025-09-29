using AutoMapper;
using Microsoft.Data.SqlClient;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile :Profile
    {
        public StudentProfile()
        {
         GetStudentListMapping();

        }
}
}
