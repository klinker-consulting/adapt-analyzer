﻿using System;
using log4net.Config;
using Microsoft.Owin.Hosting;

namespace Adapt.Analyzer.Api.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            var port = args.Length > 0 ? args[0] : "5000";
            using (WebApp.Start<Startup>($"http://localhost:{port}"))
            {
                Console.WriteLine($"Now Listening on {port}...");
                Console.Read();
            }
        }
    }
}
