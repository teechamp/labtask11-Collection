using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            
            dictionary.Add("Tom Lee", "Training");
            dictionary.Add("James Anderson", "HR");
            dictionary.Add("Micheal Chan", "Content Development");
            dictionary.Add("Jackie Jackson", "Training");
            dictionary.Add("Bruce Douglas", "Graphics");
            dictionary.Add("Kim Date", "HR");
            dictionary.Add("Joseph Mathews", "Content Development");
            dictionary.Add("Rose Dorson", "Marketing");
            dictionary.Add("Andrews Stephan", "Graphics");

            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key}\nValue: {item.Value}\n");
            }

                Console.WriteLine("\nThis is the New list after Andrew Stephan has been removed and been sorted\n");

             SortedList<string, string> dictionary1= new SortedList<string, string>();

            
            dictionary1.Add("Tom Lee", "Training");
            dictionary1.Add("James Anderson", "HR");
            dictionary1.Add("Micheal Chan", "Content Development");
            dictionary1.Add("Jackie Jackson", "Training");
            dictionary1.Add("Bruce Douglas", "Graphics");
            dictionary1.Add("Kim Date", "HR");
            dictionary1.Add("Joseph Mathews", "Content Development");
            dictionary1.Add("Rose Dorson", "Marketing");
            dictionary1.Add("Andrews Stephan", "Graphics");

            if (dictionary1.ContainsKey("Andrews Stephan"))
            {
                dictionary1.Remove("Andrews Stephan");
            }

            foreach (var item in dictionary1)
            {
                Console.WriteLine($"Key: {item.Key}\nValue: {item.Value}\n");
            }

            

        }
    }
}
