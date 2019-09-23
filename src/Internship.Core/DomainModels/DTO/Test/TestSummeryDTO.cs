using Internship.Core.Interface;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;

namespace Internship.Core.DomainModels.DTO.Test
{
    public class TestSummeryDTO: IRoutine2DTO
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
