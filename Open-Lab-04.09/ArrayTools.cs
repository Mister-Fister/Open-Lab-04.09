using System;
using System.Collections.Generic;
namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            List<string> a = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (!a.Contains(strings[i]))
                {
                    a.Add(strings[i]);
                }
            }
            return a.ToArray();
        }
    }
}
