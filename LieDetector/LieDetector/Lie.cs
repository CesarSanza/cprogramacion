namespace LieDetector;

public class Lie
{
    private string suspectName;
    private string question;
    private int suspicionLevel;
    private int minSuspicion;
    private int maxSuspicion;

    public Lie(string suspectName)
        {
        this.suspectName = suspectName;
        this.question = "";
        this.suspicionLevel =0;
        this.minSuspicion = 1;
        this.maxSuspicion = 5;
        }

    public void AnalyzeAnswer(string answer)
    {
        Console.WriteLine($"Analying... {suspectName}...");
        this.question = answer;

        Random random = new Random();
        this.suspicionLevel = random.Next(minSuspicion, maxSuspicion + 1);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Suspect: {suspectName}");
        Console.WriteLine($"Answer: \"{question}\"");
        Console.WriteLine($"Level of suspicion: {suspicionLevel} / {maxSuspicion}");
    }
    public bool IsLier()
    {
        return suspicionLevel == maxSuspicion;
    }
}

