using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session1Demo
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;

        public PhoneBook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }



        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return numbers[i];
                }
                return -1;
            }
            set 
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        numbers[i] = value;
                }
            }

        }

        public string this[long number]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                        return names[i];
                }
                return "";
            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                        names[i] = value;
                }
            }

        }


        public void AddPerson(string name, long number, int index)
        {
            names[index] = name;
            numbers[index] = number;
        }

        public long getNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return numbers[i];
            }
            return -1;
        }

        public void UpdateNumber(string name, long newNumber) 
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    numbers[i] = newNumber;
            }
        }


        public string getName(long number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                    return names[i];
            }
            return "";
        }

        public void UpdateName(long number, string newName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                    names[i]=newName;
            }
        }
    }
}
