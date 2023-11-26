using System.Text;

namespace StoresNetwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            AppController controller = new AppController();
        }
    }
}