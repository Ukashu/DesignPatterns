using DesignPatternsExercises.Creational.Builder;
using System;

namespace DesignPatternsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Builder
            var cb = new CodeBuilder("Person").AddField("Name", "string", "private").AddField("Age", "int");
            Console.WriteLine(cb);
        }
    }
}
