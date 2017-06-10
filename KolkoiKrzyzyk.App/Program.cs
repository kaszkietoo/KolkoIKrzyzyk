using KolkoIKrzyzyk.Engine;
using Ninject;

namespace KolkoiKrzyzyk.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<IPlayer>().To<CirclePlayer>().Named("circle");
            kernel.Bind<IPlayer>().To<CrossPlayer>().Named("cross");
            kernel.Bind<IBoard>().To<Board>();

            var game = kernel.Get<Game>();
        }
    }
}
