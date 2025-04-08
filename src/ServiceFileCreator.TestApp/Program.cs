﻿using Microsoft.Extensions.Hosting;
using ServiceFileCreator.Extensions;
using System;
using System.IO;

namespace ServiceFileCreator.TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var currentDirrectory = Directory.GetCurrentDirectory();
            var savePath = currentDirrectory;

            IHost host = Host.CreateDefaultBuilder(args)

                  .ConfigureServices((context, services) =>
                  {
                      services.AddAdamServiceFileCreator();
                  })
                  .Build();

            Console.WriteLine(savePath);

            host.UseAdamServiceFileCreator(repositoryRootPath:savePath);
            host.RunAsync();
        }
    }
}
