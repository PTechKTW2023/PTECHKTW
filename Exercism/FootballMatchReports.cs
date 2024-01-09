using System;
using System.Linq.Expressions;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3 or 4:
                return "center back";
            case 5:
                return "right back";
            case 6 or 7 or 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                throw new ArgumentOutOfRangeException();

        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int support:
                return $"There are {support} supporters at the match.";
            case string shout:
                return shout;
            case Foul _:
                return "The referee deemed a foul.";
            case Injury injury:
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
            case Incident _:
                return "An incident happened.";
            case Manager manager when manager.Club is null:
                return manager.Name;
            case Manager manager:
                return $"{manager.Name} ({manager.Club})";
            default:
                throw new ArgumentException();

        }
    }
}
