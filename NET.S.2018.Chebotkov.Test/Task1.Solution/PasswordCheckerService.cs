using System;
using System.Linq;

namespace Task1.Solution
{
    public delegate Tuple<bool, string> Verification (string password);
    public class PasswordCheckerService
    {
        private IRepository repository;
        private IVerifier [] verifiers;

        public PasswordCheckerService() : this(new SqlRepository(), new Verifier())
        {
        }

        public PasswordCheckerService(IRepository repository) : this(repository, new Verifier())
        {

        }

        public PasswordCheckerService(IVerifier verifier) : this(new SqlRepository(), verifier)
        {

        }

        public PasswordCheckerService(IRepository repository, params IVerifier[] verifiers)
        {
            if (repository == null)
                throw new ArgumentException($"{repository} is null arg");
            foreach(IVerifier verifier in verifiers)
            {
                if (verifier == null)
                    throw new ArgumentException($"{verifier} is null arg");
            }

            this.verifiers = verifiers; 
            this.repository = repository;
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            foreach (IVerifier verifier in verifiers)
            {
                Tuple<bool, string> result = verifier.VerifyPassword(password);
                if (!result.Item1)
                {
                    return Tuple.Create(false, result.Item2);
                }
            }

            repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
