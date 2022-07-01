using System;

namespace memrise_net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VocaRepo repo = new VocaRepo();
            VocaIO vocaIO = new VocaIO(repo);
            vocaIO.InputVoca();
            VocaLearning vocaLearn = new VocaLearning(repo);
            vocaLearn.ProcessVoca();
        }
    }
}
