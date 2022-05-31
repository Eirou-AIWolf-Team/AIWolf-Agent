// See https://aka.ms/new-console-template for more information
using AIWolf.Client;
using AIWolf.Lib;

namespace MyAgent
{
    class MyAgentApp
    {
        static void Main(string[] args)
        {
            new ClientStarter(new Werewolf2(), args).Start();
        }
    }
}
