using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests.ForTests
{
    public class VerifierForContains : IValidator
    {
        public bool VerifyPassword(string password)
        {
            // check if password contains at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return false;

            // check if password contains at least one digit character 
            if (!password.Any(char.IsNumber))
                return false;

            return true;
        }
    }
}
