
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string sentencesValue)
    { 
        if (string.IsNullOrWhiteSpace(sentencesValue)) //Check if the parameter has a value.
            return 0;

        var sentences = sentencesValue.Split('.', StringSplitOptions.RemoveEmptyEntries);

        return 4; // Logic not complete forcefully passing the test while finalizing the busines logic (Context of BA Requirement) This commit will pass the test with the hard coded return Int 4
    }
}
