using System;
using System.Collections.Generic;
using Microsoft.Identity.Client;
using Microsoft.Graph;
using Microsoft.Extensions.Configuration;
using Helpers;

namespace graphconsoleapp
{
    public class Program
    {
        private static GraphServiceClient? _graphClient;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}