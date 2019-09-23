using AutoMapper;
using Internship.Core.DomainModels.DTO.Test;
using Internship.Core.DomainModels.ViewModel.Routine2;
using Internship.Core.Entity.Internship;
using System;
using System.Collections.Generic;
using System.Text;

namespace IocConfig.Test
{
    public class TestMapping:Profile
    {
        public TestMapping()
        { 
            CreateMap<Internship.Core.Entity.Internship.Test, TestSummeryDTO>(); 
            CreateMap<EditRoutine2ViewModel, Internship.Core.Entity.Internship.Test>().ReverseMap(); 
        }
    }
}
