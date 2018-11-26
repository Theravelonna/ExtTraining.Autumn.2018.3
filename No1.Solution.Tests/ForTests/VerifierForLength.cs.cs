using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests.ForTests
{
    public class VerifierForLength : IValidator
    {
        public bool VerifyPassword(string password)
        {
            if (password.Length <= 7)
                return false;

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return false;

            return true;
        }
    }
}
