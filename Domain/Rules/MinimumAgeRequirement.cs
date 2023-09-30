using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Rules {
    internal class MinimumAgeRequirement : IAuthorizationRequirement {
        protected int MinimumAge { get; set; }
        
        public MinimumAgeRequirement(int age) {
            MinimumAge = age;           
        }
    }
}
