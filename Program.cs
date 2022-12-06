using System.Collections.Generic;
using System;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Reflection;
using System.Collections;
using System.Dynamic;

namespace MYPROGRAMM
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Myarlist arlist = new Myarlist();
            Console.WriteLine("Array Craeted");
            arlist.Add(2);
            arlist.Add(4);
            arlist.Add(6);
            arlist.Add(8);
            arlist.Show();
            arlist.AddIndex(5, 2);
            arlist.SortDescend();

            Console.WriteLine("Array sorted in descending order");

            //arlist.SortAscend();
            //Console.WriteLine("Array sorted in ascending order");
            //arlist.Show();
            //arlist.Length();
            //Console.WriteLine("Show the length of array");
            //arlist.Show();



        }
    }
    public class Myarlist
    {
        private int[] mylist;

        public Myarlist()
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
        //1. add element at the end of a list
        public void Add(int a)
        {
            Array.Resize(ref mylist, mylist.Length + 1);
            mylist[mylist.Length - 1] = a;
        }
        //2.add element at the beggining of a list
        public void AddtoBegin(int a)
        {
            Array.Resize(ref mylist, mylist.Length + 1);
            int newleng = mylist.Length;
            for (int b = newleng - 1; b > 0; b--)
            {
                mylist[b] = mylist[b - 1];
            }
            mylist[0] = a;
        }
        //3.Add element by index
        public void AddIndex(int j, int index)
        {
            Array.Resize(ref mylist, mylist.Length + 1);
            for (int c = mylist.Length - 1; c > 0; c--)
            {
                if (c > index)
                {
                    mylist[c] = mylist[c - 1];

                }
                else if (c == index)
                {
                    mylist[c] = j;
                }
                else
                {
                    mylist[c] = mylist[c];
                }
            }
        }
        //4.Sort by Descending order
        public void SortDescend()
        {
            int temp;

            // traverse 0 to array length
            for (int n = 0; n < mylist.Length - 1; n++)

                // traverse i+1 to array length
                for (int j = n + 1; j < mylist.Length; j++)

                    // compare array element with all next element

                    if (mylist[n] < mylist[j])
                    {

                        temp = mylist[n];
                        mylist[n] = mylist[j];
                        mylist[j] = temp;
                    }


        }
        //5.Sort by Ascending order
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
        //6.Find max of array
        public void MaxofArray()
        {
            int max = mylist[0];
            for (int a = 0; a <= mylist.Length - 1; a++)
            {
                if (mylist[a] > max)
                {
                    max = mylist[a];

                }

            }
        }
        //7.Find the Min of array
        public void MinofArray()
        {
            int min = mylist[0];
            for (int k = 0; k <= mylist.Length - 1; k++)
                if (mylist[k] < min)
                {
                    min = mylist[k];
                }
        }
        //8. Deleting the last element
        public void DeleteLastEl()
        {
            int[] AnewList = new int[mylist.Length - 1];
            for (int k = 0; k < AnewList.Length; k++)
            {
                AnewList[k] = mylist[k];
            }
            mylist = AnewList;
        }
        //9.Deleting the first element
        public void DeleteFirstEl()
        {
            int[] AnewList = new int[mylist.Length - 1];
            for (int i = 1; i < mylist.Length; i++)
            {
                AnewList[i - 1] = mylist[i];
            }
            mylist = AnewList;
        }

        //{
        //    for (int i = 0; i < mylist.Length; i++)

        //    {
        //        Console.WriteLine(mylist[i]);
        //    }
        //}
        //10.Delete element by index
        public void DelElbyIndex(int index)
        {
            int[] newList = new int[mylist.Length - 1];
            for (int b = 0; b < newList.Length; b++)
            {
                if (b < index)
                    newList[b] = mylist[b];
                else
                    newList[b] = mylist[b + 1];
            }
            mylist = newList;
        }
        //11.Delete the N last elements
        public void DelNLastEl(int a)
        {
            int[] newlist = new int[mylist.Length - a];
            for (int i = 0; i < mylist.Length - a; i++)
            {
                newlist[i] = mylist[i];
            }
            mylist = newlist;
        }
        //12.Deleting the first N elements
        public void DelNFirstEl(int e)
        {
            int[] newlist = new int[mylist.Length - e];
            for (int i = e; i < mylist.Length; i++)
            {
                newlist[i - e] = mylist[i];
            }
            mylist = newlist;
        }
        //13.Reverse the list
        public void Reverse()
        {
            int[] array = new int[mylist.Length];
            for (int i = 0; i < mylist.Length; i++)
            {
                array[i] = mylist[mylist.Length - i - 1];
            }
            mylist = array;
        }
        //14.Get element by Index
        public int GetElementbyIndx(int c)
        {
            return mylist[c];
        }
        //15.Get index by element
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
        //16.Find the index of  Maximum value
        public int FindIndexofMaxEL()
        {
            int indx = 0;
            int max = mylist[0];
            for (int l = 0; l <= mylist.Length - 1; l++)
            {
                if (mylist[l] > max)
                {
                    max = mylist[l];
                    indx = l;

                }

            }
            return indx;
        }
        //17.Find the index of  Minimum value
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