using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class User
    {
        
        private List<int> score = new List<int>();
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Result
        {
            get
            {
                return score.Sum();
            }
        }
        public void AddScore(int number)
        {
            //score += number;
            score.Add(number);
        }
    }
}
