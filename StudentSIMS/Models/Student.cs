using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSIMS.Models
{
    public class Constants
    {
        public const int StrEntryMedSize = 64;
        public const int StrEntryLrgSize = 128;
    }

    [Table("Student")]
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studentId { get; set; }

        [Required, MaxLength(Constants.StrEntryMedSize)]
        public string firstName { get; set; }

        [MaxLength(Constants.StrEntryMedSize)]
        public string middleName { get; set; }

        [Required, MaxLength(Constants.StrEntryMedSize)]
        public string lastName { get; set; }

        [MaxLength(Constants.StrEntryLrgSize)]
        public string emailAddress { get; set; }

        public int addressId { get; set; }

        public int phoneNumber { get; set; }

        [Timestamp]
        public DateTime timeCreated { get; set; } = DateTime.UtcNow;
    }

    [Table("Address")]
    public class Address
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int addressId { get; set; }
        public string streetNumber { get; set; }
        public string street { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public int postcode { get; set; }
        public string country { get; set; }
    }
}
