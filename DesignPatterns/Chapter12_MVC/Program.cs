using System;

namespace Chapter12_MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeatModel model = new BeatModel();
            IController controller = new BeatController(model);
            var view = controller.GetView();

            view.ActionPerformed("setBPM");
            view.ActionPerformed("setBPM");
            view.ActionPerformed("setBPM");
            view.ActionPerformed("setBPM");
            view.ActionPerformed("setBPM");
            view.ActionPerformed("setBPM");

            Console.ReadKey();
        }
    }
}
