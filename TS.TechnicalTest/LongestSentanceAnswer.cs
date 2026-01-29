
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string sentencesValue)
    {
        //I have returned to the first question to add exception handling before completing: DeepestPitAnswer.cs
        try
        {
            if (string.IsNullOrWhiteSpace(sentencesValue))
                return 0;

            var sentences = sentencesValue.Split('.', StringSplitOptions.RemoveEmptyEntries);

            int maxWordCount = 0;

            foreach (var sentence in sentences)
            {
                var words = sentence
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                maxWordCount = Math.Max(maxWordCount, words.Length);
            }

            return maxWordCount;
        }
        catch (Exception e)
        {
            //===========Bellow in sequence==========
            //Stack holder requirements: real rime reports if required
            //Logger to be added in my case as Denis Banda, i would normally register Serilog via DI in Program.cs, mostly implemented in Micro Service API hosted under IIS Either as a parent web app or a child web app in IIS with associated Service user aand App pool for each instance. | DB or File log (Preferablly file into a different net drive to avoid future performace issues) 
        }
        return 0;
    }
}
