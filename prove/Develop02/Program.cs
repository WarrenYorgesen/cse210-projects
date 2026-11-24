using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        Journal journal = new Journal();
        FileManage fileManage = new FileManage();
        bool quit = false;

        while (quit == false)
        {
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Unload");
            Console.WriteLine("6. Quit");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                List<string> newEntry = entry.newEntry();
                journal.addEntry(newEntry);
            }
            else if (choice == 2)
            {
                journal.display();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename you want to save to? (ex:journal.txt) : ");
                string file = Console.ReadLine();
                fileManage.save(file, journal._entryList);
            }
            else if (choice == 4)
            {
                Console.WriteLine("(Warning: will delete unsaved entries)");
                int confirmChoice = 0;
                Console.Write("Type 0 to cancel, or 1 to confirm: ");
                confirmChoice = int.Parse(Console.ReadLine());
                if (confirmChoice == 1)
                {
                    Console.Write("What is the filename you want to load from? (ex:journal.txt) : ");
                    string file = Console.ReadLine();
                    if (fileManage.load(file) != null)
                    {
                        journal._entryList = fileManage.load(file);
                    }
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("(Warning: unsaved entries will be lost.)");
                int confirmChoice = 0;
                Console.Write("Type 0 to cancel, or 1 to confirm: ");
                confirmChoice = int.Parse(Console.ReadLine());
                if (confirmChoice == 1)
                {
                    journal._entryList.Clear();
                }
            }
            else if (choice == 6)
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Option is not supported");
            }
        }
    }
}