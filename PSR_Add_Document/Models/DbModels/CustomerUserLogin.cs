﻿using System.ComponentModel.DataAnnotations;
using System.Net;

namespace PSR_Add_Document.Models.Models
{
    public class CustomerUserLogin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string? UserID { get; set; }

        public string? UserName { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public string? BranchID { get; set; }

        [Required]
        public string? Department { get; set; }

        public string? ContactNo { get; set; }

        public int UserRole { get; set; }

        public string? UserStatus { get; set; }

        public int LoginID { get; set; }

        public string? LoginStatus { get; set; }

        public string? IPAddress { get; set; }

        public DateTime EntryDate { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        public int EmpID { get; set; }

        public DateTime LastLoginDate { get; set; }

        public string? Active { get; set; }
    }
}
