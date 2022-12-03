namespace Day2RockPaperScissors.Console
{
    public class SituationOutcomeType
    {
        public enum RockPaperScissor
        {
            Rock = 1,
            Paper = 2,
            Scissor = 3,
        }
        public enum SituationScoreType
        {
            Loss = 0,
            Draw = 3,
            Won = 6
        }
        public RockPaperScissor Player1 { get; set; }
        public RockPaperScissor Player2 { get; set; }
        public SituationScoreType SituationPlayer2Score { get; set; }
        public SituationScoreType SituationPlayer1Score
        {
            get
            {
                switch (SituationPlayer2Score)
                {
                    case SituationScoreType.Loss:
                        return SituationScoreType.Won;
                    case SituationScoreType.Won:
                        return SituationScoreType.Loss;
                    case SituationScoreType.Draw:
                        return SituationScoreType.Draw;
                    default:
                        return SituationScoreType.Loss;
                }
            }
        }

        public class Round
        {
            public RockPaperScissor Player1 { get; set; }
            public RockPaperScissor Player2 { get; set; }
            public int ScorePlayer1 { get; set; }
        }

        public class RockPaperScissorsScoreCalculator
        {
            private List<SituationOutcomeType> _possibleOutcomes = new List<SituationOutcomeType>();
            private List<Round> _roundList { get; set; }

            public RockPaperScissorsScoreCalculator()
            {
                _roundList = new List<Round>();
                InitOutcome();
            }
            private void InitOutcome()
            {
                _possibleOutcomes = new List<SituationOutcomeType>();
                _possibleOutcomes.Add(new SituationOutcomeType()
                {
                    Player1 = RockPaperScissor.Rock,
                    Player2 = RockPaperScissor.Rock,
                    SituationPlayer2Score = SituationScoreType.Draw
                });
                _possibleOutcomes.Add(new SituationOutcomeType()
                {
                    Player1 = RockPaperScissor.Rock,
                    Player2 = RockPaperScissor.Paper,
                    SituationPlayer2Score = SituationScoreType.Won
                });
                _possibleOutcomes.Add(new SituationOutcomeType()
                {
                    Player1 = RockPaperScissor.Rock,
                    Player2 = RockPaperScissor.Scissor,
                    SituationPlayer2Score = SituationScoreType.Loss
                });


                _possibleOutcomes.Add(new SituationOutcomeType()
                {
                    Player1 = RockPaperScissor.Paper,
                    Player2 = RockPaperScissor.Rock,
                    SituationPlayer2Score = SituationScoreType.Loss
                });
                _possibleOutcomes.Add(new SituationOutcomeType()
                {
                    Player1 = RockPaperScissor.Paper,
                    Player2 = RockPaperScissor.Paper,
                    SituationPlayer2Score = SituationScoreType.Draw
                });
                _possibleOutcomes.Add(new SituationOutcomeType()
                {
                    Player1 = RockPaperScissor.Paper,
                    Player2 = RockPaperScissor.Scissor,
                    SituationPlayer2Score = SituationScoreType.Won
                });


                _possibleOutcomes.Add(new SituationOutcomeType()
                {
                    Player1 = RockPaperScissor.Scissor,
                    Player2 = RockPaperScissor.Rock,
                    SituationPlayer2Score = SituationScoreType.Won
                });
                _possibleOutcomes.Add(new SituationOutcomeType()
                {
                    Player1 = RockPaperScissor.Scissor,
                    Player2 = RockPaperScissor.Paper,
                    SituationPlayer2Score = SituationScoreType.Loss
                });
                _possibleOutcomes.Add(new SituationOutcomeType()
                {
                    Player1 = RockPaperScissor.Scissor,
                    Player2 = RockPaperScissor.Scissor,
                    SituationPlayer2Score = SituationScoreType.Draw
                });
            }

            public int CalculateRounds()
            {
                foreach (Round roundItem in _roundList)
                {
                    var outcome = _possibleOutcomes
                        .First(s => s.Player1 == roundItem.Player1 && s.Player2 == roundItem.Player2);

                    roundItem.ScorePlayer1 = (int)(outcome.SituationPlayer2Score + (int)roundItem.Player2);
                }

                return _roundList.Sum(r => r.ScorePlayer1);
            }
            public void AddRound(string player1Input, string player2Input)
            {
                RockPaperScissor player1Type = RockPaperScissor.Rock;
                RockPaperScissor player2Type = RockPaperScissor.Rock;

                switch (player1Input)
                {
                    case "A":
                        {
                            player1Type = RockPaperScissor.Rock;
                            break;
                        }
                    case "B":
                        {
                            player1Type = RockPaperScissor.Paper;
                            break;
                        }
                    case "C":
                        {
                            player1Type = RockPaperScissor.Scissor;
                            break;
                        }
                }

                switch (player2Input)
                {
                    case "X":
                        {
                            player2Type = RockPaperScissor.Rock;
                            break;
                        }
                    case "Y":
                        {
                            player2Type = RockPaperScissor.Paper;
                            break;
                        }
                    case "Z":
                        {
                            player2Type = RockPaperScissor.Scissor;
                            break;
                        }
                }
                _roundList.Add(new Round() { Player1 = player1Type, Player2 = player2Type });
            }
        }
    }
}
