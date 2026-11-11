using System;
using System.Collections.Generic;
using System.Text;

namespace Console_to_do_list
{
    public class ToDoItem
    {
        // Variables
        public string Description { get; set; }
        private bool IsComplete { get; set; } // stays private - nobody outside needs to poke it

        // Constructor
        public ToDoItem( string description)
        {
            Description = description;
            IsComplete = false;
        }


        // Methods
        public void Add(string description)
        {
            Description = description;
        }

       public string GetDisplayText() // The item describes itself
        {
            // [ X ] is true, [  ] if false
            string marker = IsComplete ? "[ X ]" : "[  ]";
            return $"{marker} {Description}";

        }

        public void MarkComplete() // The item changes its own state
        {
            IsComplete = true;
        }

        

    }

}
