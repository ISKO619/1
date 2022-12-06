using System.Collections.Generic;
using System;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.Collections;
using System.Dynamic;

namespace ArrayList
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Arlist arlist = new Arlist();
            Console.WriteLine("Array Craeted");
            arlist.Add(2);
            arlist.Add(4);
            arlist.Add(6);
            arlist.Add(8);
            //arlist.AddIndex(5, 2);
            //arlist.SortDescend();
            //Console.WriteLine("Array sorted in descending order");
            arlist.Show();
            //arlist.SortAscend();
            //Console.WriteLine("Array sorted in ascending order");
            //arlist.Show();
            //arlist.Length();
            //Console.WriteLine("Show the length of array");
            //arlist.Show();
            arlist.MinofArray();



        }
    }
    public class Arlist
    {
        private int[] mylist;

        public Arlist()
        {

            mylist = new int[0];

        }


        //I have used indexer to access the elements of the array inside the class
        //public int this[int index]
        //{
        //    get => mylist[index];
        //    set => mylist[index] = value;
        //}
        // Length of List
        public int Length()
        {
            return mylist.Length;
        }
        // add element to the end of a list
        public void Add(int i)
        {
            Array.Resize(ref mylist, mylist.Length + 1);
            mylist[mylist.Length - 1] = i;
        }
        //add element to the beggining of a list
        public void AddtoBegin(int j)
        {
            Array.Resize(ref mylist, mylist.Length + 1);
            int newlen = mylist.Length;
            for (int i = newlen - 1; i > 0; i--)
            {
                mylist[i] = mylist[i - 1];
            }
            mylist[0] = j;
        }
        //Add element by index
        public void AddIndex(int j, int index)
        {
            Array.Resize(ref mylist, mylist.Length + 1);
            for (int i = mylist.Length - 1; i > 0; i--)
            {
                if (i > index)
                {
                    mylist[i] = mylist[i - 1];

                }
                else if (i == index)
                {
                    mylist[i] = j;
                }
                else
                {
                    mylist[i] = mylist[i];
                }
            }
        }
        //Sort by Descending order
        public void SortDescend()
        {
            int temp;

            // traverse 0 to array length
            for (int i = 0; i < mylist.Length - 1; i++)

                // traverse i+1 to array length
                for (int j = i + 1; j < mylist.Length; j++)

                    // compare array element with all next element

                    if (mylist[i] < mylist[j])
                    {

                        temp = mylist[i];
                        mylist[i] = mylist[j];
                        mylist[j] = temp;
                    }


        }
        //Sort by Ascending order
        public void SortAscend()
        {
            int temp;
            for (int j = 0; j <= mylist.Length - 2; j++)
            {
                for (int i = 0; i <= mylist.Length - 2; i++)
                {
                    if (mylist[i] > mylist[i + 1])
                    {
                        temp = mylist[i + 1];
                        mylist[i + 1] = mylist[i];
                        mylist[i] = temp;
                    }
                }
            }

        }
        //Find max of array
        public void MaxofArray()
        {
            int max = mylist[0];
            for (int i = 0; i <= mylist.Length - 1; i++)
            {
                if (mylist[i] > max)
                {
                    max = mylist[i];

                }

            }
        }
        //Find the Min of array
        public void MinofArray()
        {
            int min = mylist[0];
            for (int i = 0; i <= mylist.Length - 1; i++)
                if (mylist[i] < min)
                {
                    min = mylist[i];
                }
        }
        // Deleting the last element
        public void DeleteLastEl()
        {
            int[] newList = new int[mylist.Length - 1];
            for (int i = 0; i < newList.Length; i++)
            {
                newList[i] = mylist[i];
            }
            mylist = newList;
        }
        //Deleting the first element
        public void DeleteFirstEl()
        {
            int[] newList = new int[mylist.Length - 1];
            for (int i = 1; i < mylist.Length; i++)
            {
                newList[i - 1] = mylist[i];
            }
            mylist = newList;
        }
        //public void Show()
        //{
        //    for (int i = 0; i < mylist.Length; i++)

        //    {
        //        Console.WriteLine(mylist[i]);
        //    }
        //}
        //Delete element by index
        public void DelElbyIndex(int index)
        {
            int[] newList = new int[mylist.Length - 1];
            for (int i = 0; i < newList.Length; i++)
            {
                if (i < index)
                    newList[i] = mylist[i];
                else
                    newList[i] = mylist[i + 1];
            }
            mylist = newList;
        }
        //Delete the N last elements
        public void DelNLastEl(int n)
        {
            int[] newlist = new int[mylist.Length - n];
            for (int i = 0; i < mylist.Length - n; i++)
            {
                newlist[i] = mylist[i];
            }
            mylist = newlist;
        }
        //Deleting the first N elements
        public void DelNFirstEl(int n)
        {
            int[] newlist = new int[mylist.Length - n];
            for (int i = n; i < mylist.Length; i++)
            {
                newlist[i - n] = mylist[i];
            }
            mylist = newlist;
        }
        //Reverse the list
        public void Reverse()
        {
            int[] array = new int[mylist.Length];
            for (int i = 0; i < mylist.Length; i++)
            {
                array[i] = mylist[mylist.Length - i - 1];
            }
            mylist = array;
        }
        //Get element by Index
        public int GetElementbyIndx(int ind)
        {
            return mylist[ind];
        }
        //Get index by element
        public int GetIndxbyEl(int El)
        {
            for (int i = 0; i < mylist.Length; i++)
            {
                if (mylist[i] == El)
                {

                    return i;
                }

            }
            return -1;

        }
        //Find the index of  Maximum value
        public int FindIndexofMaxEL()
        {
            int indx = 0;
            int max = mylist[0];
            for (int i = 0; i <= mylist.Length - 1; i++)
            {
                if (mylist[i] > max)
                {
                    max = mylist[i];
                    indx = i;

                }

            }
            return indx;
        }
        //Find the index of  Minimum value
        public int FindIndexofMinEL()
        {
            int indx = 0;
            int min = mylist[0];
            for (int i = 0; i <= mylist.Length - 1; i++)
                if (mylist[i] < min)
                {
                    min = mylist[i];
                    indx = i;
                }
            return indx;

        }
        public void AddListtoEnd(int[] array)
        {
            int first_length = mylist.Length;
            Array.Resize(ref mylist, mylist.Length + array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                mylist[first_length + i] = array[i];
            }

        }




    }
}