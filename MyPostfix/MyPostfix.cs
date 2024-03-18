using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStack;

namespace MyPostfix;


internal class MyPostfix
{
    public char[] array;
    public int index = 0;
    MyStack<string> myStack = new MyStack<string>();

    public void Run()
    {
        string text = Input();
        bool isValid = Validate(text);
        if (isValid == false || text == null)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        else
        {
            array = new char[text.Length];
            ReturnString(text);

            string result = Algorithms();
            Console.WriteLine(result);
        }
    }

    public string Input()
    {
        string text = Console.ReadLine();
        return text;
    }
    public void ReturnString(string operation)
    {
        foreach (char c in operation)
        {
            if (c != ' ')
            {
                array[index] = c;
                index++;
            }
        }
    }
    public string Algorithms()
    {
        foreach (char c in array)
        {
            if (char.IsDigit(c))
            {
                myStack.Push(c.ToString());
            }
            else if (c == '+' || c == '-' || c == '*' || c == '/')
            {
                int num2 = int.Parse(myStack.Pop());
                int num1 = int.Parse(myStack.Pop());
                int result = 0;

                switch (c)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            throw new ArgumentException("You cant divide into 0");
                        }
                        break;
                }
                myStack.Push(result.ToString());
            }
        }
        return myStack.Pop();
    }


    public bool Validate(string text)
    {
        foreach (var t in text)
        {
            if (char.IsDigit(t) || t == '+' || t == '-' || t == '*' || t == '/' || t == ' ')
            {
                return true;
            }
        }
        return false;
    }
}
