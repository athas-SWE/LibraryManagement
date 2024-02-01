﻿using BackendEmployee.Core.Enums;

namespace BackendEmployee.Core.Dtos.Job
{
    public class JobUpdateDto
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long DepartmentId { get; set; }
       
    }
}
