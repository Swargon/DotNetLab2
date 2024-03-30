using System;
using ClassLibrary1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ExtendedDictionary<int, string, string> dict = new ExtendedDictionary<int, string, string>();
            Console.WriteLine("Do you want to enter custom data for dict? (Yes/No)");
            string userInput = Console.ReadLine()?.ToLower() ?? "";

            if (userInput == "yes")
            {
                Console.WriteLine("Enter the number of entries for dict:");
                string input = Console.ReadLine() ?? "";
                int numEntries;
                if (int.TryParse(input, out numEntries))
                {
                    for (int i = 0; i < numEntries; i++)
                    {
                        Console.WriteLine($"Entry {i + 1} for dict:");
                        Console.Write("Enter key: ");
                        string keyInput = Console.ReadLine() ?? "";
                        int key;
                        if (int.TryParse(keyInput, out key))
                        {
                            Console.Write("Enter name: ");
                            string name = Console.ReadLine() ?? "";

                            Console.Write("Enter last name: ");
                            string lastName = Console.ReadLine() ?? "";

                            dict.AddOrUpdate(key, name, lastName);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for key. Please enter an integer.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for number of entries. Please enter an integer.");
                }
            }
            else if (userInput == "no")
            {
                dict.AddOrUpdate(1, "John", "Johnson");
                dict.AddOrUpdate(2, "Alice", "Jones");
                dict.AddOrUpdate(3, "Michael", "Garcia");
                dict.AddOrUpdate(1, "Sophia", "Miller");
                dict.AddOrUpdate(4, "Emma", "Martinez");
                dict.AddOrUpdate(5, "Ivan", "Smith");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
            }

            Console.WriteLine("Printing dictionary:");
            dict.Print();

            Console.WriteLine("\nEnter the key to remove from dict:");
            string keyToRemoveInput = Console.ReadLine() ?? "";
            int keyToRemove;
            if (int.TryParse(keyToRemoveInput, out keyToRemove))
            {
                dict.Remove(keyToRemove);
                Console.WriteLine($"Key {keyToRemove} removed from dict.");
            }
            else
            {
                Console.WriteLine("Invalid input for key. Please enter an integer.");
            }

            Console.WriteLine("\nChecking if key exists in dict:");
            Console.Write("Enter key to check: ");
            string keyToCheckInput = Console.ReadLine() ?? "";
            int keyToCheck;
            if (int.TryParse(keyToCheckInput, out keyToCheck))
            {
                bool keyExists = dict.ExistKey(keyToCheck);
                Console.WriteLine($"Key {keyToCheck} exists in dict: {keyExists}");
            }
            else
            {
                Console.WriteLine("Invalid input for key. Please enter an integer.");
            }

            Console.WriteLine($"\nDictionary count of elements in dict: {dict.Count()}");

            if (userInput == "yes")
            {
                Console.WriteLine("Enter the values to check:");
                Console.Write("Enter name: ");
                string name = Console.ReadLine() ?? "";

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";

                bool valuesExist = dict.ExistValues(name, lastName);
                Console.WriteLine($"Values '{name}' and '{lastName}' exist: {valuesExist}");
            }
            else
            {
                Console.WriteLine("\nChecking if values 'Michael' and 'Garcia' exist in dict:");
                bool valuesExist = dict.ExistValues("Michael", "Garcia");
                Console.WriteLine($"Values 'Michael' and 'Garcia' exist in dict: {valuesExist}");
            }

            Console.WriteLine("\nEnter the key you want to check in dict:");
            string keyToCheckValueInput = Console.ReadLine() ?? "";
            int keyToCheckValue;
            if (int.TryParse(keyToCheckValueInput, out keyToCheckValue))
            {
                if (dict.ContainsKey(keyToCheckValue))
                {
                    Console.WriteLine($"Value of dict[{keyToCheckValue}] = {dict[keyToCheckValue]?.Value1} ~ {dict[keyToCheckValue]?.Value2}");
                }
                else
                {
                    Console.WriteLine($"Key {keyToCheckValue} does not exist in dict.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for key. Please enter an integer.");
            }

            Console.WriteLine("\nIterating through dict:");
            foreach (var item in dict)
            {
                Console.WriteLine($"Key: {item.Key} ~/~ {item.Value1} ~/~ {item.Value2}");
            }

            ExtendedDictionary<int, string, double> dict2 = new ExtendedDictionary<int, string, double>();

            Console.WriteLine("\n\n\nDo you want to enter custom data for dict2? (Yes/No)");
            string userInputDict2 = Console.ReadLine()?.ToLower() ?? "";

            if (userInputDict2 == "yes")
            {
                Console.WriteLine("Enter the number of entries for dict2:");
                string inputDict2 = Console.ReadLine() ?? "";
                int numEntriesDict2;
                if (int.TryParse(inputDict2, out numEntriesDict2))
                {
                    for (int i = 0; i < numEntriesDict2; i++)
                    {
                        Console.WriteLine($"Entry {i + 1} for dict2:");
                        Console.Write("Enter key: ");
                        string keyDict2Input = Console.ReadLine() ?? "";
                        int keyDict2;
                        if (int.TryParse(keyDict2Input, out keyDict2))
                        {
                            Console.Write("Enter name: ");
                            string nameDict2 = Console.ReadLine() ?? "";

                            Console.Write("Enter value: ");
                            string valueDict2Input = Console.ReadLine() ?? "";
                            double valueDict2;
                            if (double.TryParse(valueDict2Input, out valueDict2))
                            {
                                dict2.AddOrUpdate(keyDict2, nameDict2, valueDict2);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for value. Please enter a double.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for key. Please enter an integer.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for number of entries. Please enter an integer.");
                }
            }
            else if (userInputDict2 == "no")
            {
                dict2.AddOrUpdate(1, "John", 1);
                dict2.AddOrUpdate(2, "Alice", 1);
                dict2.AddOrUpdate(3, "Michael", 1);
                dict2.AddOrUpdate(1, "Sophia", 1);
                dict2.AddOrUpdate(4, "Emma", 1);
                dict2.AddOrUpdate(5, "Ivan", 1);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
            }

            Console.WriteLine("Printing dictionary2:");
            dict2.Print();

            Console.WriteLine("\nEnter the key to remove from dict2:");
            string keyToRemoveDict2Input = Console.ReadLine() ?? "";
            int keyToRemoveDict2;
            if (int.TryParse(keyToRemoveDict2Input, out keyToRemoveDict2))
            {
                dict2.Remove(keyToRemoveDict2);
                Console.WriteLine($"Key {keyToRemoveDict2} removed from dict2.");
            }
            else
            {
                Console.WriteLine("Invalid input for key. Please enter an integer.");
            }

            Console.WriteLine("\nChecking if key exists in dict2:");
            Console.Write("Enter key to check: ");
            string keyToCheckDict2Input = Console.ReadLine() ?? "";
            int keyToCheckDict2;
            if (int.TryParse(keyToCheckDict2Input, out keyToCheckDict2))
            {
                bool keyExistsDict2 = dict2.ExistKey(keyToCheckDict2);
                Console.WriteLine($"Key {keyToCheckDict2} exists in dict2: {keyExistsDict2}");
            }
            else
            {
                Console.WriteLine("Invalid input for key. Please enter an integer.");
            }

            Console.WriteLine($"\nDictionary2 count of elements in dict2: {dict2.Count()}\n\n");

            if (userInputDict2 == "yes")
            {
                Console.Write("Enter name to check: ");
                string nameToCheckDict2 = Console.ReadLine() ?? "";

                Console.Write("Enter value to check: ");
                string valueToCheckDict2Input = Console.ReadLine() ?? "";
                double valueToCheckDict2;
                if (double.TryParse(valueToCheckDict2Input, out valueToCheckDict2))
                {
                    bool valuesExistDict2 = dict2.ExistValues(nameToCheckDict2, valueToCheckDict2);
                    Console.WriteLine($"Values '{nameToCheckDict2}' and '{valueToCheckDict2}' exist in dict2: {valuesExistDict2}");
                }
                else
                {
                    Console.WriteLine("Invalid input for value. Please enter a double.");
                }
            }
            else
            {
                Console.WriteLine("\nChecking if values 'Anton' and '1' exist in dict2:");
                bool valuesExistDict2 = dict2.ExistValues("Anton", 1);
                Console.WriteLine($"Values 'Anton' and '1' exist in dict2: {valuesExistDict2}");
            }

            Console.WriteLine("\nEnter the key you want to check in dict2:");
            string keyToCheckDict2ValueInput = Console.ReadLine() ?? "";
            int keyToCheckDict2Value;
            if (int.TryParse(keyToCheckDict2ValueInput, out keyToCheckDict2Value))
            {
                if (dict2.ContainsKey(keyToCheckDict2Value))
                {
                    Console.WriteLine($"Value of dict2[{keyToCheckDict2Value}] = {dict2[keyToCheckDict2Value]?.Value1} ~ {dict2[keyToCheckDict2Value]?.Value2}");
                }
                else
                {
                    Console.WriteLine($"Key {keyToCheckDict2Value} does not exist in dict2.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for key. Please enter an integer.");
            }

            Console.WriteLine("\nIterating through dict2:");
            foreach (var item in dict2)
            {
                Console.WriteLine($"Key: {item.Key} ~/~ {item.Value1} ~/~ {item.Value2}");
            }
        }
    }
}
