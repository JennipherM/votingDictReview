using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Voting_Review
{
    internal class Program
    {
        static Dictionary<string,int> votes = new Dictionary<string,int>();

        static void Main(string[] args)
        {
            string can1 = "";
            string can2 = "";
            string can3 = "";
            int userVote = 0;
            bool pass = false;

            Console.WriteLine("Enter canidate 1:");
            can1 = Console.ReadLine();
            Console.WriteLine("Enter canidate 2:");
            can2 = Console.ReadLine();
            Console.WriteLine("Enter canidate 3:");
            can3 = Console.ReadLine();

            votes.Add(can1,0);
            votes.Add(can2, 0);
            votes.Add(can3, 0);

            while (userVote != 6)
            {               
                Console.WriteLine($"Choose your vote or exit\n" +
                    $"1. {can1}\n" +
                    $"2. {can2}\n" +
                    $"3. {can3}\n" +
                    $"4. Reset Votes\n" +
                    $"5. Display Votes\n" +
                    $"6. Exit");


                userVote = Convert.ToInt32(Console.ReadLine());
                switch (userVote)
                {
                    case 1:
                        AddVote(can1);
                        break;
                    case 2:
                        AddVote(can2);
                        break;
                    case 3:
                        AddVote(can3);
                        break;
                    case 4:
                        ResetVotes();
                        break;
                    case 5:
                        DisplayVotes();
                        break;
                }              
            }
            
        }
        static void AddVote(string name)
        {
            votes[name]++;
        }

        static void DisplayVotes()
        {
            foreach(var kvp in votes)
            {
                Console.WriteLine($"{kvp.Key} -- {kvp.Value}");
            }
        }
        static void ResetVotes()
        {
            Dictionary<string, int> votesReset = new Dictionary<string, int>();
            foreach (var kvp in votes)
            {
                votesReset.Add(kvp.Key, 0);
            }
        }
    }
}
