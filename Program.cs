// See https://aka.ms/new-console-template for more information
using AIWolf.Client;
using AIWolf.Lib;

namespace Eirou
{
    class MyAgentApp
    {
        static void Main(string[] args)
        {
            new ClientStarter(new Seer(), args).Start();
        }
    }
}
