using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    internal class ToDo
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public bool IsImportant { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"Name  {Name}";
        }
        public string ShowFull()
        {
            return $"Name  {Name}" +
                $"\nDesc  {Desc}" +
                $"\nImportant  {IsImportant}" +
                $"\nDate  {Date.ToShortDateString()}";
        }
    }

}
