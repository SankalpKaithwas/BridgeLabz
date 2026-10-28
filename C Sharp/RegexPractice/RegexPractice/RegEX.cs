using System.Text.RegularExpressions;

namespace RegexPractice
{
    public class RegEX
    {
        public Regex FirstName = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
        public Regex LastName = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
        public Regex Address = new Regex(@"^[A-Z]{1}[A-Za-z]{1,}(\s[A-Za-z 0-9])*$");// Sankalp kaithwas lives in india
        public Regex Email = new Regex(@"^([A-Za-z 0-9]{1,})*[-+.]?[A-Za-z0-9]{1,}(@[A-Za-z]{1,}[.]{1}[A-Za-z]{2,3})$");
        //sankalp.qwe@asd.com

        public bool CheckFirst(string firstname)
        {

            bool Check(string name) => FirstName.IsMatch(name);
            bool result = Check(firstname);
            if (result)
            {
                return true;
            }
            else return false;
        }

        public bool CheckLast(string lastname)
        {
            bool Check(string name) => LastName.IsMatch(name);
            bool result = Check(lastname);
            if (result)
            {
                return true;
            }
            return false;
        }

        public bool CheckEmail(string email)
        {
            bool Check(string email) => Email.IsMatch(email);
            bool result = Check(email);
            if (result)
            {
                return true;
            }
            return false;


        }

        public bool CheckAddress(string address)
        {
            bool Check(string address) => Address.IsMatch(address);
            bool result = Check(address);
            if (result)
            {
                return true;
            }
            return false;
        }


    }
}
