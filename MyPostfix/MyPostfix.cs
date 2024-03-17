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
    public bool x;
    public int index = 0;
    MyStack<string> myStack = new MyStack.MyStack<string>();
   public void Run()
    {
        string text = Input();
        bool isValid = Validate(text);
        array= new string[text.Length];    
        if(isValid)
        {
            ReturnString(text);
            Algorithms();
            foreach(var i in array)
            Console.WriteLine(i);
        }
        else { Console.WriteLine("sax vata"); }
    }
    public string Input()
    {
        string text = Console.ReadLine();
        return text;
    }
    public string[] ReturnString(string operation)
    {
        for (int i = 0; i < operation.Length; i++)
        {
            if (operation[i] == ' ')
            {
                index++;
                continue;
            }
            else
            {
                array[index] = operation[i].ToString();
                
            }
        }
        //array = operation.Split(' ');
        return array;
    }
    public void Algorithms()
    {
        for (int i = 0; i <= index; i++)
        {
            if (array[i] != "*" && array[i] != "/" && array[i] != "+" && array[i] != "-" && array[i] != " ")
            {
                myStack.Push(array[i]);
            }
            else
            {
                break;
            }
        }
        
    }
    
    public bool Validate(string text)
    {
        foreach (var t in text)
        {
            if (char.IsDigit(t) || t == '+' || t == '-' || t == '*' || t == '/' || t == ' ')
            {
                x = true;
            }
            else
            {
                x = false;
            }
        }
        return x;
    }
}
