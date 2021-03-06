﻿using System;
using System.Threading;

namespace CSharpExtLibrary
{
    public static class JumpChar
    {
        public static void jumpPrint(string s, int span = 50, bool withEnter = true)
        {
            int l = s.Length;
            for (int i = 0; i < l; i++)
            {
                Console.Write("{0}", s[i]);
                Thread.Sleep(span);
            }
            if (withEnter == true)
                Console.Write("\n");
        }
        public static void jumpRemove(string s, int span = 100)
        {
            int l = s.Length;
            Console.Write("{0}", s);
            for (int i = 0; i < l + 2; i++)
            {
                Thread.Sleep(span);
                for (int j = 0; j <= i + 1; j++)
                {
                    Console.Write("\b");
                }
                for (int j = 0; j <= i + 1; j++)
                {
                    Console.Write(" ");
                }
            }
            Console.Write("\n");
        }
    }
}
