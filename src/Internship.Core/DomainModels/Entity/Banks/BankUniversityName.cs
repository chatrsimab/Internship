using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Internship.Core.DomainModels.Entity.Banks
{
    //نام دانشگاه
    public class BankUniversityName
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int BankUniversityTypeId { get; set; }

        [ForeignKey("BankUniversityTypeId")]
        public BankUniversityType BankUniversityType { get; set; }

    }
}
