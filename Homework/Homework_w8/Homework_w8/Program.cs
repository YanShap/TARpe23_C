namespace Homework_w8

class Program
{
    static void Main(string[] args)
    {
        Football normalBall = new Football("Nike");
        Football youthBall = new Football("Adidas", true);

        double averageSpeed = normalBall.CalculateAverageSpeed(30, 70, 20);
        Console.WriteLine($"Keskmine kiirus: {averageSpeed} m/s");

        bool goal = normalBall.IsGoal(1);
        Console.WriteLine($"Sai väravasse: {goal}");

        double[] ballCoordinates = { 0, 2, 4, 6, 8 };
        int countedGoals = normalBall.CountGoalAttempts(ballCoordinates);
        Console.WriteLine($"Loetud väravad: {countedGoals}");

        normalBall.CalculateKineticEnergy(10);

        string uniqueCode = normalBall.GenerateUniqueCode(false);
        Console.WriteLine($"Unikaalne kood: {uniqueCode}");
    }
}

public class Football
{
    private string sponsorName;
    private double ballDiameter;
    private double goalDepth;
    private double ballWeight;

    public Football(string sponsorName, bool isYouthBall = false)
    {
        this.sponsorName = sponsorName;
        if (isYouthBall)
        {
            ballDiameter = 56;
            goalDepth = 1.4;
            ballWeight = 380;
        }
        else
        {
            ballDiameter = 70;
            goalDepth = 1.7;
            ballWeight = 450;
        }
    }

    public double CalculateAverageSpeed(double initialPos, double finalPos, double time)
    {
        double distance = Math.Abs(finalPos - initialPos);
        return distance / time;
    }

    public bool IsGoal(double ballCoordinate)
    {
        double goalCoordinates = 0;
        double ballRadius = ballDiameter / 2;
        return ballCoordinate - ballRadius >= goalCoordinates - goalDepth;
    }

    public int CountGoalAttempts(double[] ballCoordinates)
    {
        int countedGoals = 0;
        foreach (var coordinate in ballCoordinates)
        {
            if (IsGoal(coordinate))
            {
                countedGoals++;
            }
        }
        return countedGoals;
    }

    public void CalculateKineticEnergy(double velocity)
    {
        double kineticEnergy = (ballWeight * velocity * velocity) / 2;
        Console.WriteLine($"Kineetiline energia: {kineticEnergy} J");
    }

    public string GenerateUniqueCode(bool isYouthBall)
    {
        Random rand = new Random();
        string code = sponsorName.Substring(0, isYouthBall ? 3 : 4);
        for (int i = 0; i < (isYouthBall ? 3 : 5); i++)
        {
            code += rand.Next(0, 10);
        }
        return code;
    }
}