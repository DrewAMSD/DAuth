﻿namespace DAuth;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(Authenticator.GenerateRandomPassword());
        }
    }
}