
public class Journal
{
    public List<List<string>> _entryList = new List<List<string>>();

    public void addEntry(List<string> entry)
    {
        _entryList.Add(entry);
    }
    public void display()
    {
        foreach (List<string> entry in _entryList)
        {
            Console.WriteLine($"Date: {entry[0]} - Time: {entry[1]} - Prompt: {entry[2]}");
            Console.WriteLine(entry[3]);
            Console.WriteLine();
        }
    }
}