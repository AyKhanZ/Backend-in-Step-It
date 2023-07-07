using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lesson_5
{
    abstract class DeviceClass {
        protected string name;
        protected string describes;
        internal DeviceClass()
        {
            name = "NoName";
            describes = "NoDescribes";
        }
        internal virtual void Sound() {
            Console.WriteLine("NoSound");
        }
        internal virtual void Show() { 
            Console.WriteLine(name);
        }
        internal virtual void Desc() { 
            Console.WriteLine(describes);
        }
    }
    class KettleClass : DeviceClass {
        internal KettleClass() {
            name = "Kettle";
            describes = "Can make water hot for tea";
        }
        internal virtual void Sound() {
            Console.WriteLine("VUUUU");
        }
        internal virtual void Show() {
            Console.WriteLine(name);
        }
        internal virtual void Desc() {
            Console.WriteLine(describes);
        }
    }
    class MicrowaveClass : DeviceClass
    {
        internal MicrowaveClass()
        {
            name = "Microwave";
            describes = "Can make meal hot";
        }
        internal virtual void Sound()
        {
            Console.WriteLine("Wuuwuu");
        }
        internal virtual void Show()
        {
            Console.WriteLine(name);
        }
        internal virtual void Desc()
        {
            Console.WriteLine(describes);
        }
    }
    class CarClass : DeviceClass
    {
        internal CarClass()
        {
            name = "Car";
            describes = "It can drive you anywhere";
        }
        internal virtual void Sound()
        {
            Console.WriteLine("Bibib");
        }
        internal virtual void Show()
        {
            Console.WriteLine(name);
        }
        internal virtual void Desc()
        {
            Console.WriteLine(describes);
        }
    } 
    class SteamboatClass : DeviceClass
    {
        internal SteamboatClass()
        {
            name = "Steamboat"; 
            describes = "Can make meal hot";
        }
        internal virtual void Sound()
        {
            Console.WriteLine("Duuuu");
        }
        internal virtual void Show()
        {
            Console.WriteLine(name);
        }
        internal virtual void Desc()
        {
            Console.WriteLine(describes);
        }
    }
}
