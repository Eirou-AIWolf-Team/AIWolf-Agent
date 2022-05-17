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
            Console.WriteLine(GameInfo.AgentList[1]);
            return GameInfo.AgentList[1];
        }

        public Agent Divine()
        {
            return GameInfo.AgentList[1];
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