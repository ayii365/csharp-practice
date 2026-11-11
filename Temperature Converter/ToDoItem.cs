using System;
using System.Collections.Generic;
using System.Text;

namespace Temperature_Converter
{
    public class ToDoItem
    {
        // Variables
        public string Description { get; set; }
        bool IsComplete { get; set; }

        // Constructor
        ToDoItem()
        {
            IsComplete = false;
        }


        // Methods
        public void Add(string description)
        {
            Description = description;
        }

        public void View( List<ToDoItem> toDoList)
        {
            if (toDoList.Count > 0) {
                for (int i = 0; i < toDoList.Count; i++)
                {
                    if (toDoList[i].IsComplete)
                    {
                        Console.WriteLine($"{i + 1}. [ X ] {toDoList[i].Description}");
                    } else
                    {
                        Console.WriteLine($"{i + 1}. [ ] {toDoList[i].Description}");
                    }
                }
            } else
            {
                Console.WriteLine("No tasks yet");
            }
            
        }

        

    }

}
