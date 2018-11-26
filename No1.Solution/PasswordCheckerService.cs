using System;
using System.Linq;

/*Был использован паттерн Стратегия для того, чтобы была возможность заменить один репозиторий на другой и для того, чтобы была возможность изменять принцип валидации.
 *Также добавлены перегруженные функции с разным количеством валидаторов*/

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository;

        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository;
        }

        public (bool, string) CreateRepository(string password, IValidator validator)
        {
            ValidData(password, validator);
            
            if (validator.VerifyPassword(password) == true)
            {
                repository.Create(password);
                return (true, "Password is Ok. User was created");
            }
            else
            {
                return (false, "Password isn't valid");
            }
        }

        public (bool, string) CreateRepository(string password, IValidator firstValidator, IValidator secondValidator)
        {
            ValidData(password, firstValidator, secondValidator);

            if (firstValidator.VerifyPassword(password) == true && secondValidator.VerifyPassword(password) == true)
            {
                repository.Create(password);
                return (true, "Password is Ok. User was created");
            }
            else
            {
                return (false, "Password isn't valid");
            }
        }

        public (bool, string) CreateRepository(string password, IValidator firstValidator, IValidator secondValidator, IValidator thirdValidator)
        {
            ValidData(password, firstValidator, secondValidator, thirdValidator);

            if (firstValidator.VerifyPassword(password) == true && secondValidator.VerifyPassword(password) == true && thirdValidator.VerifyPassword(password) == true)
            {
                repository.Create(password);
                return (true, "Password is Ok. User was created");
            }
            else
            {
                return (false, "Password isn't valid");
            }
        }

        public (bool, string) CreateRepository(string password, params IValidator[] validators)
        {
            ValidData(password, validators);

            bool flag = true;

            foreach(var validator in validators)
            {
                if (validator.VerifyPassword(password) == false)
                {
                    flag = false;
                    break;
                }
            }

            if (flag == true)
            {
                repository.Create(password);
                return (true, "Password is Ok. User was created");
            }
            else
            {
                return (false, "Password isn't valid");
            }
        }

        private void ValidData(string password, params IValidator[] validator)
        {
            if (password == null)
                throw new ArgumentNullException($"{password} is null arg");

            if (password == string.Empty)
                throw new ArgumentException($"{password} is empty");
        }
    }
}
