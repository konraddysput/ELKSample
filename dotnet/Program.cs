using System;
using System.Threading;

namespace dotnet
{
    class Program
    {
        private static string[] _users = {"Administrator", "SuperUser", "Technical User", "John", "Bob"};

        private static string[] _actions = {"create new user", "change application configuration", "setup new view", "logout", "login", "send a new message", "prepare template"};
        static void Main(string[] args)
        {
            PeriodLog();
        }

        private static void PeriodLog()
        {
            Random urandom = new Random();
            while(true){
                Console.WriteLine($"{_users[urandom.Next(0,_users.Length)]} {_actions[urandom.Next(0, _actions.Length)]}");
                Thread.Sleep(500);
            }
        }
    }
}
