using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Internship.Core.DomainModels.Entity.Banks
{
    //نوع دانشگاه
    public class BankUniversityType
    {
        public int Id { get; set; }

        public string Title { get; set; }

    }
}
