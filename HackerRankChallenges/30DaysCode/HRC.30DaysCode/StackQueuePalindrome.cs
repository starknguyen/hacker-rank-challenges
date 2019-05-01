using System;
using System.Collections.Generic;
using System.IO;

namespace HRC.Code30Days
{
    public class StackQueuePalindrome
    {
        List<char> stack = new List<char>();
        List<char> queue = new List<char>();

        public void pushCharacter(char c)
        {
            stack.Insert(0, c);
        }

        public char popCharacter()
        {
            return stack[0];
        }

        public void enqueueCharacter(char c)
        {
            queue.Add(c);
        }

        public char dequeueCharacter()
        {
            return queue[0];
        }
    }
}
