using System;
using System.Collections.Generic;

// ResultsList Class for string list with methods to add and display //

namespace NCRM
{
    public class ResultsList
    {
        //REVIST LISTS AGAIN -----------------------------//
        private readonly List<string> _reqStrList = new List<string>();


        //VOID ADD TO LIST -----------------------------------------------//
        public void AddToList(string s)
        {
            _reqStrList.Add(s);
        }


        //VOID DISPLAY LIST -----------------------------------------------//
        public void DisplayList()
        {
            foreach (var str in _reqStrList)
                Console.WriteLine(@"List Class: " + str);
        }


        //ENDOFLINE
    }
}