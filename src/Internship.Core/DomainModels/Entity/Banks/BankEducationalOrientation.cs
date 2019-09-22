using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Internship.Core.DomainModels.Entity.Banks
{
    //گرایش تحصیلی
    public class BankEducationalOrientation
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int BankEducationalFieldId { get; set; }

        [ForeignKey("BankEducationalFieldId")]
        public virtual BankEducationalField BankEducationalField { get; set; }
    }
}
