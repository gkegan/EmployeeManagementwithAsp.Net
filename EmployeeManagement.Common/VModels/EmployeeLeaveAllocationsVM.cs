﻿using System;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveAllocationsVM :BaseVM
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }


        public string EmployeeId { get; set; }
   
        public EmployeeVM EmployeeVM { get; set; } // employee tablosuyla iletişime geçiyor

        public int EmployeeLeaveTypeId { get; set; }
       
        public EmployeeLeaveTypeVM EmployeeLeaveTypeVM { get; set; }

    }


}
