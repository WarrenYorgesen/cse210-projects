
public class FileManage
{

    public void save(string file, List<List<string>> nestedList)
    {
        foreach (List<string> list in nestedList)
        {
            string convertedList = string.Join("~@%", list) + Environment.NewLine;
            File.AppendAllText(file, convertedList); 
        }

    }
    public List<List<string>> load(string file)
    {
        if (File.Exists(file))
        {
            List<List<string>> nestedList = new List<List<string>>();
            foreach (string line in File.ReadLines(file))
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                List<string> list = line.Split("~@%").ToList();
                nestedList.Add(list);
            }
            return nestedList;
        }
        else
        {
            Console.WriteLine($"The file {file} does not exist!");
            return null;
        }
    }
}