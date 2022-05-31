using AIWolf.Client;
using AIWolf.Lib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAgent
{
    class Werewolf2 : IPlayer
    {
        public string Name {get;} = "My Agent";
        protected Agent Me { get; private set; } = Agent.NONE;
        protected Role MyRole { get; private set; }
        protected Random Random { get; } = new Random();
        protected int Date { get; private set; }
        protected int Turn { get; private set; }
        protected void NextTurn() => Turn++;
        int talkListHead;
        HashSet<Agent> executedAgents = new HashSet<Agent>();
        Dictionary<Agent, Species> speciesMap = new Dictionary<Agent, Species>();
        protected bool IsRevote { get; set; }
        protected Agent DeclaredVoteCandidate { get; set; } = Agent.NONE;
        protected Agent DeclaredWolf { get; set; } = Agent.NONE;
        protected Agent VoteCandidate { get; set; } = Agent.NONE;

        protected IGameInfo GameInfo { get; private set; } = default!;

        public virtual void Initialize(IGameInfo gameInfo, IGameSetting gameSetting)
        {
            MyRole = Role.WEREWOLF;
            GameInfo = gameInfo;
        }

        public virtual void Update(IGameInfo gameInfo)
        {
            if (gameInfo.LatestExecutedAgent != null)
            {
                executedAgents.Add(gameInfo.LatestExecutedAgent);
            }

            talkListHead = gameInfo.TalkList.Count;
            GameInfo = gameInfo;
        }

        public virtual string Talk()
        {
            return Content.OVER.Text;
        }

        public void DayStart()
        {
            if (GameInfo != null){
            if (GameInfo.ExecutedAgent != null)
            {
                executedAgents.Add(GameInfo.ExecutedAgent);
            }

            var ident = GameInfo.MediumResult;
            }

            IsRevote = false;
            DeclaredVoteCandidate = Agent.NONE;
            DeclaredWolf = Agent.NONE;
            VoteCandidate = Agent.NONE;
            talkListHead = 0;
            Turn = 0;
            
        }

        public Agent Vote()
        {
            var Random = new Random();
            var Num = 0;
            return GameInfo.AliveAgentList[Num];
        }


        public virtual string Whisper() => Content.SKIP.Text;

        public virtual Agent Attack(){
            var Random = new Random();
            var Num = 0;
            while (Random.Next(1, 6) == GameInfo.Agent.AgentIdx){ 
                Num = Random.Next(1, 6);
            }
            return Agent.GetAgent(Num);
        }

        public virtual Agent Divine(){
            var Random2 = new Random();
            var Num = 0;
            while (Random2.Next(1, 6) == GameInfo.Agent.AgentIdx){ 
                Num = Random2.Next(1, 6);
            }
            return Agent.GetAgent(Num);
    }

        public virtual Agent Guard(){
            var Random3 = new Random();
            var Num = 0;
            while (Random3.Next(1, 6) == GameInfo.Agent.AgentIdx){ 
                Num = Random3.Next(1, 6);
            }
            return Agent.GetAgent(Num);
        }

        public virtual void Finish(){}
        
        
        }
}