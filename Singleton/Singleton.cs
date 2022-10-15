using System;

namespace Singleton;
public class Logger
{
    private static Logger? _instance;

    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
        }
    }
    
    protected Logger()
    {}

    /// <summary>
    ///  Singleton Operation
    ///  Every instance of the logger has access to it and it is the same instance that is being returned
    /// </summary>
    ///
    public void Log(string message)
    {
        Console.WriteLine($"The logged message is: {message}");   
    }
}