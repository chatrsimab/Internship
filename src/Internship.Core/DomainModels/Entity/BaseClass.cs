using System;
using System.Collections.Generic;
using System.Text;

namespace Internship.Core.DomainModels.Entity
{
    public static class BaseClass<T> where T:new() 
    {
        public static T CreateT()
        {
            return new T();
        }
    }
}
