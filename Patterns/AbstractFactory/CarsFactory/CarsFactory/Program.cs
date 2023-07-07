namespace MyNamespace
{
    public class Program
    {

        public static void Main()
        {
            // «Мне нужен автомобиль!» «Отлично!» — говорим мы ему, — «вы обратились по адресу! 
            // Фабрика фабрик – это то, что вам нужно!»
            CarsFactory factory;
            // «Автомобили какой фирмы предпочитаете в данное время суток?», — спрашиваем мы. 
            // Допустим, покупатель хочет приобрести тойоту. Нет проблем!
            factory = new ToyotaFactory();
            ///«А какой тип кузова вы бы хотели?» Допустим – седан. «Прекрасный выбор!»
            factory.CreateSedan();
      
            
        }
    }
    //Фабрика фабрик
    public interface CarsFactory
    {
        Sedan CreateSedan();
        Coupe CreateCoupe();
    }
    //Фабрика тайота
    public class ToyotaFactory : CarsFactory
    {
        public Coupe CreateCoupe()
        {
            return new ToyotaCoupe();
        }

        public Sedan CreateSedan()
        {
            return new ToyotaSedan();
        }
    }
    //Фабрика форд
    public class FordFactory : CarsFactory
    {
        public Coupe CreateCoupe()
        {
            return new FordCoupe();
        }

        public Sedan CreateSedan()
        {
            return new FordSedan();
        }
    }


    //Продукты двух фабрик
    public interface Coupe { }
    public interface Sedan { };
    public class ToyotaCoupe : Coupe
    {
        public ToyotaCoupe()
        {
            Console.WriteLine("Toyota Coupe");
        }
    }
    public class ToyotaSedan : Sedan
    {
        public ToyotaSedan()
        {
            Console.WriteLine("Toyota Sedan");
        }
    }
    public class FordCoupe : Coupe
    {
        public FordCoupe()
        {
            Console.WriteLine("Ford Coupe");
        }
    }
    public class FordSedan : Sedan
    {
        public FordSedan()
        {
            Console.WriteLine("Ford Sedan");
        }
    }

}