using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Internship.Core.DomainModels.Entity.Banks
{
    //نام کارآموزی
    public class BankTraineeMaster
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int BankUniversityNameId { get; set; }

        [ForeignKey("BankUniversityNameId")]
        public BankUniversityName BankUniversityName { get; set; }

    }
}
