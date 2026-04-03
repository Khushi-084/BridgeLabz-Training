public class BullAndCows {
    public string GetHint(string secret, string guess) {
        int countBulls = 0, countCows = 0;
        for(int i=0;i<secret.Length;i++)
        {
            if(secret[i] == guess[i])
            {
                countBulls++;
                secret = secret.Remove(i, 1);
                guess = guess.Remove(i, 1);
                i--;
            }
        }

        for(int i=0;i<secret.Length;i++)
        {
            if(guess.Contains(secret[i]))
            {
                countCows++;
                guess = guess.Remove(guess.IndexOf(secret[i]), 1);
                secret = secret.Remove(i, 1);
                i--;
            }
        }

        return countBulls + "A" + countCows + "B";
    }
}