namespace CommandLineIssue;

using CommandLine;

public class Program
{
    public static void Main()
    {
        var optionTypes = from type in Assembly.GetExecutingAssembly().GetTypes()
                          where type.GetCustomAttributes<OptionAttribute>().Cast<OptionAttribute>().Any()
                          select type;
    }
}
