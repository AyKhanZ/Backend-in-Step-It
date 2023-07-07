using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lesson_5
{
    abstract class MusicalInstrumentClass
    {
        protected string sound;
        protected string name;
        protected string describes;
        protected string history;
        internal MusicalInstrumentClass() {
            sound = "NoSound";
            name = "NoName";
            describes = "NoDescribes";
            history = "NoHistory";
        }
        internal virtual void Sound() {
            Console.WriteLine($"sound: {sound}");
        }
        internal virtual void Show() {
            Console.WriteLine($"name: {name}");
        }
        internal virtual void Desc() {
            Console.WriteLine($"describe: {describes}");
        }
        internal virtual void History() {
            Console.WriteLine($"history: {history}");
        }
    }
    class violin: MusicalInstrumentClass  {
        internal violin() {
            sound = "triiin triiiin";
            name = "violin";
            describes = "like guitar but with stick";
            history = "A history of violent";
        }
        internal virtual void Sound() {
            Console.WriteLine($"sound: {sound}");
        }
        internal virtual void Show() {
            Console.WriteLine($"name: {name}");
        }
        internal virtual void Desc() {
            Console.WriteLine($"describe: {describes}");
        }
        internal virtual void History() {
            Console.WriteLine($"history: {history}");
        }
    }
    internal class Trombone: MusicalInstrumentClass
    {
        internal Trombone()
        {
            sound = "tuuu...tuuu...";
            name = "Trombone";
            describes = "The instrument which needs to blow";
            history = "A history of Trombone";
        }
        internal virtual void Sound()
        {
            Console.WriteLine($"sound: {sound}");
        }
        internal virtual void Show()
        {
            Console.WriteLine($"name: {name}");
        }
        internal virtual void Desc()
        {
            Console.WriteLine($"describe: {describes}");
        }
        internal virtual void History()
        {
            Console.WriteLine($"history: {history}");
        }
    }
    internal class Ukulele: MusicalInstrumentClass
    {
        internal Ukulele()
        {
            sound = "trinn-trinn";
            name = "Ukulele";
            describes = "like guitar but smaller";
            history = "A history of ukulele";
        }
        internal virtual void Sound() {
            Console.WriteLine($"sound: {sound}");
        }
        internal virtual void Show() {
            Console.WriteLine($"name: {name}");
        }
        internal virtual void Desc() {
            Console.WriteLine($"describe: {describes}");
        }
        internal virtual void History() {
            Console.WriteLine($"history: {history}");
        }
    }
}
     
