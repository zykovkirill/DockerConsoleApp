// See https://aka.ms/new-console-template for more information
using DockerConsoleApp1.Configurations;
using Microsoft.Extensions.Configuration;

Console.WriteLine("------------");
Console.WriteLine(Environment.GetEnvironmentVariable("dockerconsoleapp"));
Console.WriteLine(Environment.GetEnvironmentVariable("dockerconsoleapp1"));
Console.WriteLine("------------");

var builder = new ConfigurationBuilder();

builder.AddJsonFile(Path.Combine(Environment.CurrentDirectory, "docker.json")).AddEnvironmentVariables();

var config = builder.Build();

var testConfig = new TestConfig();

config.Bind(testConfig);
Console.WriteLine("------------");
Console.WriteLine(testConfig.InnerTests[0].TestString);
Console.WriteLine(testConfig.InnerTests[0].TestInt);
Console.WriteLine(testConfig.InnerTests[1].TestString);
Console.WriteLine(testConfig.InnerTests[1].TestInt);
Console.WriteLine("------------");
Console.WriteLine(config.GetSection("Secret").Value);
Console.WriteLine(config.GetSection("BigSecret").Value);
Console.WriteLine(config.GetSection("VeryBigSecret").Value);
Console.WriteLine(config.GetSection("InnerTest:TestString").Value);
Console.WriteLine("------------");

Console.ReadLine();