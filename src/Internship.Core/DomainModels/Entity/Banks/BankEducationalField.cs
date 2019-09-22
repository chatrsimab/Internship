using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Internship.Core.DomainModels.Entity.Banks
{
    //رشته تحصیلی
    public class BankEducationalField
    {
        public int Id { get; set; }

        public int BankEducationalGradeId { get; set; }

        public string Title { get; set; }

        [ForeignKey("BankEducationalGradeId")]
        public virtual BankEducationalGrade BankEducationalGrade { get; set; }
    }
}
