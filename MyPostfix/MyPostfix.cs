using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStack;

namespace MyPostfix;

internal class MyPostfix
{
    public string[] array;
    private string _operation;
    public int index = 0;
    MyStack<string> myStack = new MyStack.MyStack<string>();
    public MyPostfix (string operation)
    {
        _operation = operation;
    }
    public string[] ReturnString(string operation)
    {
       
      for(int i =0; i< array.Length; i++)
        {
            if (_operation[i] == ' ')
            {
                index++;
                continue;
            }
            else
            {
                array[index] += operation[i];
            }

        }
      return array;
    }
    public int Algorithms()
    {
        for (int i = 0; i <= index; i++)
        {
            if (array[i] != "*" || array[i] != "/" || array[i] != "+"|| array[i] != "-");
            
        }
        return 0;
    }
}
