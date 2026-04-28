using System.Collections.Generic;
using UnityEngine;

namespace PokerGame.Systems.DecisionLogging
{
    public class DecisionLogger
    {
        private List<DecisionLog> _logs = new List<DecisionLog>();

        public void LogDecision(DecisionLog log)
        {
            _logs.Add(log);
            Debug.Log(log.ToString());
        }

        public List<DecisionLog> GetLogs()
        {
            return _logs;
        }

        public List<DecisionLog> GetAllLogs()
        {
            return _logs;
        }
    }
}