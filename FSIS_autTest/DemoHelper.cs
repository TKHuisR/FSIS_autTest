using System.Threading;

namespace FSIS_autTest
{
    internal static class DemoHelper
    {
        public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}
