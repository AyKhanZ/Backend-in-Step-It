using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lesson_5
{
    abstract class WorkerClass {
        protected string describe;
        internal WorkerClass() => describe = "NoDescribe";
        internal virtual void Print() {
            Console.WriteLine($"Worker: {describe}");
        }
    }
    internal class President: WorkerClass   
    {
        internal President() => describe = "Ruler of the country";
        internal virtual void Print() {
            Console.WriteLine($"President: {describe}");
        }
    }
    internal class Security: WorkerClass
    {
        internal Security() => describe = "provides security";
        internal virtual void Print() {
            Console.WriteLine($"Security: {describe}");
        }
    }
    internal class Manager: WorkerClass     
    {
        internal Manager() => describe = "the manager controls the employees";
        internal virtual void Print() {
            Console.WriteLine($"Manager: {describe}");
        }
    }
    internal class Engineer: WorkerClass    
    {
        internal Engineer() => describe = "An engineer builds buildings";
        internal virtual void Print() {
            Console.WriteLine($"Engineer: {describe}");
        }
    }
}
