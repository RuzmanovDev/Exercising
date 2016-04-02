namespace CheckCorrectBrackets
{
    using System;
    using System.Collections.Generic;
 
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string expression = "1+(3+2-(2+3)*4-((3+1)*(4-2)))";
            Stack<int> stack = new Stack<int>();
            bool correctBrackets = true;

            for (int i = 0; i < expression.Length; i++)
            {
                char symbol = expression[i];
                if (symbol=='(')
                {
                    stack.Push(i);
                }
                else if(symbol==')')
                {
                    if (stack.Count==0)
                    {
                        correctBrackets = false;
                        break;
                    }
                    stack.Pop();
                }
            }
            if (stack.Count!=0)
            {
                correctBrackets = false;
            }

            Console.WriteLine("Are the brackets placed correctly? "+correctBrackets);
        }
    }
}
