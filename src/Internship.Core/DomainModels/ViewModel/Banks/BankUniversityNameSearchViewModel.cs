using System;
using System.Collections.Generic;
using System.Text;

namespace Internship.Core.DomainModels.ViewModel.Banks
{
    public class BankUniversityNameSearchViewModel
    {
        public string Term { get; set; }
        public int SortOrder { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
