using AIWolf.Client;
using AIWolf.Lib;

namespace Eirou
{
    public class Seer : IPlayer{
        IGameInfo GameInfo;
        public string Name { get; }

        public string Talk()
        {
            return Content.SKIP.Text;
        }
    
        public Agent Vote()
        {
            Random num = new Random();
            int index = num.Next(0,GameInfo.AliveAgentList.Count);
            while(index == GameInfo.Agent.AgentIdx){
                index = num.Next(0,GameInfo.AliveAgentList.Count);
            }
            return GameInfo.AgentList[index];
        }

        public Agent Divine()
        {
            Random num = new Random();
            int index = num.Next(0,GameInfo.AliveAgentList.Count);
            while(index == GameInfo.Agent.AgentIdx){
                index = num.Next(0,GameInfo.AliveAgentList.Count);
            }
            return GameInfo.AgentList[index];
        }

        public void Initialize(IGameInfo gameInfo, IGameSetting gameSetting)
        {
            GameInfo = gameInfo;
        }

        public void Update(IGameInfo gameInfo)
        {
            GameInfo = gameInfo;
        }

        public void DayStart()
        {

        }
        public string Whisper(){
            return Content.OVER.Text;
        }

        public Agent Guard(){
            return GameInfo.AgentList[0];
        }

        public Agent Attack(){
            return GameInfo.AgentList[0];
        }

        public void Finish(){

        }

    }
}