using System.Collections.Generic;

class Evaluator {

    public int CalculateScore(Dictionary<int, string> studentAnswers){
        int score = 0;

        Dictionary<int, string> correctAnswers = new Dictionary<int, string>(){
            {1, "A"},
            {2, "B"},
            {3, "C"},
            {4, "D"}
        };

        foreach(var q in correctAnswers){
            if(studentAnswers.ContainsKey(q.Key) &&
               studentAnswers[q.Key] == q.Value){
                score++;
            }
        }
        return score;
    }
}
