﻿using EmployeeManagement.Common.ConstantsModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Common.VModels
{
    public class EmployeeLeaveRequestVM :BaseVM
    {
        // TODO: Talepte bulunan kullancı bilgileri
        public string RequestingEmployeeId { get; set; }
        public string RequestEmployeeName { get; set; }
        public EmployeeVM RequestingEmployee { get; set; } // employee sınıfından yeni bir nesne oluşturdum. 
        // TODO: Onaylayan kullanıcı bilgileri
        public string ApprovedEmployeeId { get; set; } 
        public EmployeeVM ApprovedEmployee { get; set; }
        [Required]
        public int EmployeeLeaveTypeId { get; set; }
        public string  LeaveTypeText { get; set; }
        public EmployeeLeaveTypeVM EmployeeLeaveType { get; set; }
        //----------------------------------------------------------------------------------------------------//
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Display(Name ="Talep açıklama")]
        public DateTime DateRequested { get; set; }
        [Display(Name = "Talep Açıklama")]
        [MaxLength(300, ErrorMessage = "300 Karakterden Fazla Değer Girilemez")]
        public string RequestComments { get; set; }
        public EnumEmployeeLeaveRequestStatus ApprovedStatus { get; set; }
        public string ApprovedText { get; set; }
        public bool Cancelled { get; set; }
 
    }
}
