
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string sentencesValue)
    { 
        if (string.IsNullOrWhiteSpace(sentencesValue)) //Check if the parameter has a value.
            return 0;

        var sentences = sentencesValue.Split('.', StringSplitOptions.RemoveEmptyEntries);

        int maxWordCount = 0;

        foreach (var sentence in sentences)
        {
            var words = sentence
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            maxWordCount = Math.Max(maxWordCount, words.Length);
        }

        return maxWordCount; //maxWordCount returns dynamic word count: Int maxWordCount = 4 based on the test case. (Removed the hard coded value 4)
    }
}
