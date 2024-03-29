﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Common.VModels
{
    public  class EmployeeLeaveTypeVM : BaseVM
    {  
        [Required]
        public string Name { get;  set; }
        public int DefaultDays { get;  set; }
        public DateTime DateCreated { get;  set; }

        public bool IsActive { get; set; }

        /// <summary>
        /// MVVM create employeetype
        /// </summary>
        /// <param name="name"></param>
        public void SetEmployeeType(string name)
        {
            this.Name = name;
        }
    }
}
