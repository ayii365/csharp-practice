using Console_to_do_list;

namespace Console_to_do_list
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // List to store todo items
            List<ToDoItem> toDoList = new List<ToDoItem>();

            while (true)
            {
                PrintMenu();
                Console.Write("Select an option: ");
                string? optionNum = Console.ReadLine();

                switch( optionNum)
                {
                    case "1":
                        // Add a task
                        Console.Write("Describe task: ");
                        string? description = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(description))
                        {
                            Console.WriteLine("Task description can't be empty.");
                            continue;
                        }
                        toDoList.Add(new ToDoItem(description));
                        continue;

                    case "2":
                        // View all tasks
                        ViewTasks(toDoList);
                        continue;

                    case "3":
                        //Mark a task as complete
                        ViewTasks(toDoList); // Show current tasks first
                        Console.Write("Enter the task number you would like to complete: ");
                        string? completeOption = Console.ReadLine();

                        // int intCompleteOption = int.Parse(completeOption); // Update to try parse next

                        if (int.TryParse(completeOption, out int intCompleteOption) && intCompleteOption>= 1 && intCompleteOption <= toDoList.Count)
                        {
                            toDoList[intCompleteOption - 1].MarkComplete();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Cannot mark invalid option");
                            continue;
                        }

                    case "4":
                        // Delete a task:
                        ViewTasks(toDoList); // Show current tasks first
                        Console.Write("Enter the task number you would like to delete: ");
                        string? deleteOption = Console.ReadLine();
                        // int intDeleteOption = int.Parse(deleteOption); // Update to try parse next

                        if (int.TryParse(deleteOption, out int intDeleteOption) && intDeleteOption >= 1 && intDeleteOption <= toDoList.Count)
                        {
                            toDoList.RemoveAt(intDeleteOption - 1);
                            continue;
                        } else
                        {
                            Console.WriteLine("Cannot delete invalid option");
                            continue;
                        }


                    case "5":
                        //code;
                        Console.WriteLine("You have Quit the Program");
                        return;
                }

                Console.WriteLine("Incorrect option, try again.");
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("TO DO LIST APP:");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. View all tasks");
            Console.WriteLine("3. Mark a task complete");
            Console.WriteLine("4. Delete a task");
            Console.WriteLine("5. Quit");
            Console.WriteLine("\n");
        }

        static void ViewTasks(List<ToDoItem> toDoList)
        {
            Console.Clear();
            if ( toDoList.Count == 0)
            {
                Console.WriteLine("No tasks yet");
                return;
            }

            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {toDoList[i].GetDisplayText()}");
            }
            Console.WriteLine("\n");
        }
    }
}
