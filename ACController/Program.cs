using System;
using System.Reflection;
using System.Resources;

namespace ACController
{
    class Program
    {
        static void Main(string[] args)
        {
            var resMan = new ResourceManager(
                "ACController.strings",
                typeof(Program).GetTypeInfo().Assembly);
            Console.WriteLine(
                resMan.GetString("ExhaustAirTemp") +
                TempControl.ExhaustAirTemp);
        }
    }
}
