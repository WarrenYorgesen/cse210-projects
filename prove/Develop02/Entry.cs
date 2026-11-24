
using System.Diagnostics;

public class Entry
{
    public string _EntryString;
    public string _Date;
    public string _Time;
    public string _Prompt;


    public List<string> promptList = ["What was your favorite thing you did today?",
    "If you could go back and do one thing differently today, what would it be?",
    "What was the most interesting conversation you had today?",
    "What was the most beautiful thing you saw today?",
    "What was the best thing you tasted today?",
    "What do you wish you could experience again from today?",
    "Who did you help or wished you had helped today?"];
    
    public List<string> newEntry()
    {
        _Prompt = generatePrompt();
        Console.WriteLine(_Prompt);
        _EntryString = Console.ReadLine();
        _Date = getDate();
        _Time = getTime();

        //List<string> entryList = convertToList(Date, Time, Prompt, EntryString);
        List<string> entryList = [_Date, _Time, _Prompt, _EntryString];
        return entryList;
    }

    // public List<string> convertToList(string date, string time, string prompt, string entrystring)
    // {
    //     List<string> entrylist = [date, time, prompt, entrystring];
    //     return entrylist;
    // }

    public string getDate()
    {
        DateTime now = DateTime.Now;
        string date = now.ToShortDateString();
        return date;
    }

    public string getTime()
    {
        DateTime now = DateTime.Now;
        string time = now.ToShortTimeString();
        return time;
    }

    public string generatePrompt()
    {
        string prompt = promptList[Random.Shared.Next(promptList.Count)];
        return prompt;
    }
}