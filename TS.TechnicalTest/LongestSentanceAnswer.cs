
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string sentencesValue)
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
}
