﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId
        {
            get;
            set;
        }
        [Required]
        [StringLength(50)]
        public string FirstName
        {
            get;
            set;
        }
        [Required]
        [StringLength(50)]
        public string LastName
        {
            get;
            set;
        }
        [StringLength(50)]
        public string MiddleName
        {
            get;
            set;
        }
        public EmployeeDetalle EmployeeDetalle
        {
            get; set;
        }
}
}
