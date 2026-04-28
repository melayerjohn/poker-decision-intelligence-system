using UnityEngine;
using PokerGame.Models;
using PokerGame.Core.Engine;
using System.Collections.Generic;
using PokerGame.Systems.DecisionLogging;
using PokerGame.Systems.Profiling;
using PokerGame.Systems.Fairness;
using PokerGame.Systems.Matchmaking;

public class PokerGameRunner : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        var players = new List<Player>
        {
            new Player("P1"),
            new Player("P2")
        };

        var roundManager = new RoundManager(players);
        roundManager.StartRound();

        foreach(var player in players)
        {
            Debug.Log($"{player.Id}: {string.Join(", ", player.Hand)}");
        }

        var community = roundManager.GetCommunityCards();
        Debug.Log($"Community: {string.Join(", ", community)}");

        DecisionLogger logger = new DecisionLogger();
        HandStrengthEvaluator evaluator = new HandStrengthEvaluator();
        DecisionEngine decisionEngine = new DecisionEngine();

        foreach (var player in players)
        {
            float handStrength = evaluator.Evaluate(player.Hand);
            var action = decisionEngine.DecideAction(handStrength);

            logger.LogDecision(new DecisionLog
            {
                PlayerId = player.Id,
                Action = action,
                Stage = "Flop",
                HandStrength = handStrength,
                PotSize = 100
            }); ;
        }

        for (int i = 0; i < 5; i++)
        {
            roundManager.StartRound();

            foreach (var player in players)
            {
                float handStrength = evaluator.Evaluate(player.Hand);
                var action = decisionEngine.DecideAction(handStrength);

                logger.LogDecision(new DecisionLog
                {
                    PlayerId = player.Id,
                    Action = action,
                    Stage = "Flop",
                    HandStrength = handStrength,
                    PotSize = 100
                });

                player.Hand.Clear();
            }
        }

        PlayerProfiler profiler = new PlayerProfiler();

        foreach (var player in players)
        {
            var profile = profiler.GenerateProfile(player.Id, logger.GetAllLogs());
            Debug.Log(profile.ToString());
        }
    }
    */

    void Start()
    {
        var players = new List<Player>
    {
        new Player("P1"),
        new Player("P2")
    };

        DecisionLogger logger = new DecisionLogger();
        HandStrengthEvaluator evaluator = new HandStrengthEvaluator();
        DecisionEngine decisionEngine = new DecisionEngine();

        // Store generated profiles for reuse
        Dictionary<string, PlayerProfile> playerProfiles =
            new Dictionary<string, PlayerProfile>();

        //------------------------------------------------
        // PLAY MULTIPLE ROUNDS
        //------------------------------------------------
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"------------- ROUND {i + 1} -------------");

            // Reset player state
            foreach (var player in players)
            {
                player.Hand.Clear();
                player.IsFolded = false;
            }

            var roundManager = new RoundManager(players);
            roundManager.StartRound();

            //-----------------------------------------
            // Print player hands
            //-----------------------------------------
            foreach (var player in players)
            {
                Debug.Log($"{player.Id}: {string.Join(", ", player.Hand)}");
            }

            //-----------------------------------------
            // Print community cards
            //-----------------------------------------
            var community = roundManager.GetCommunityCards();
            Debug.Log($"Community: {string.Join(", ", community)}");

            //-----------------------------------------
            // Decision logging
            //-----------------------------------------
            foreach (var player in players)
            {
                float handStrength = evaluator.Evaluate(player.Hand);
                var action = decisionEngine.DecideAction(handStrength);

                logger.LogDecision(new DecisionLog
                {
                    PlayerId = player.Id,
                    Action = action,
                    Stage = "Flop",
                    HandStrength = handStrength,
                    PotSize = 100
                });
            }
        }

        //------------------------------------------------
        // PLAYER PROFILING
        //------------------------------------------------
        PlayerProfiler profiler = new PlayerProfiler();

        Debug.Log("========= PLAYER PROFILES =========");

        foreach (var player in players)
        {
            var profile = profiler.GenerateProfile(
                player.Id,
                logger.GetAllLogs()
            );

            playerProfiles[player.Id] = profile;

            Debug.Log(profile.ToString());
        }

        //------------------------------------------------
        // FAIRNESS REPORT
        //------------------------------------------------
        FairnessEngine fairnessEngine = new FairnessEngine();

        Debug.Log("========= FAIRNESS REPORT =========");

        foreach (var player in players)
        {
            var report = fairnessEngine.AnalyzePlayer(
                player.Id,
                logger.GetAllLogs()
            );

            Debug.Log(report.ToString());
        }

        //------------------------------------------------
        // MATCHMAKING REPORT
        //------------------------------------------------
        Debug.Log("========= MATCHMAKING REPORT =========");

        MatchmakingEngine matchmakingEngine =
            new MatchmakingEngine();

        var matchResult = matchmakingEngine.EvaluateMatch(
            playerProfiles["P1"],
            playerProfiles["P2"]
        );

        Debug.Log(matchResult.ToString());
    }
}
