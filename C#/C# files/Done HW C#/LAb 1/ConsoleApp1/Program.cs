int[] nums1 = new int[6] { -1, 0, 1, 2, 3, 5 };

int count_2 = 0;
int count_3 = 0;
int count_0 = 0;

for (int i = 0; i < 6; i++)
{
    if (nums1[i] <= 0) count_0++;
    else if (nums1[i] % 2 == 0) count_2++;
    else if (nums1[i] % 2 > 0) count_3++;
}
Console.WriteLine($"TASK 1" +
                  $"\nUnusual -> {count_0}" +
                  $"\neven nums -> {count_2}" +
                  $"\nodd nums -> {count_3}");
//---------------------------------------------------------------
Console.WriteLine("TASK 2" +
                  "\nEnter num -> ");
string line = Console.ReadLine();
int a = int.Parse(line);
int count_low = 0;
for (int i = 0; i < 6; i++)
{
    if (nums1[i] < a) count_low++;
}
Console.WriteLine($"\nCount of nums < {a} => {count_low}");
//---------------------------------------------------------------
int[] nums2 = new int[12] { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
Console.WriteLine("TASK 3" +
                  "\nEnter num1 -> ");
string line_1 = Console.ReadLine();
int a_1 = int.Parse(line_1);

Console.WriteLine("\nEnter num2 -> ");
string line_2 = Console.ReadLine();
int a_2 = int.Parse(line_2);

Console.WriteLine("\nEnter num3 -> ");
string line_3 = Console.ReadLine();
int a_3 = int.Parse(line_3);

int count_33 = 0;
for (int i = 0; i < 12; i++)
{
    if (nums2[i] == a_1 && nums2[i + 1] == a_2 && nums2[i + 2] == a_3) count_33++;
}
Console.WriteLine($"\nCount of repeat < {count_33}");
//---------------------------------------------------------------
Console.WriteLine("TASK 4");

int n, m;

Console.WriteLine("Length of M array ->");
string s_1 = Console.ReadLine();
m = Convert.ToInt32(s_1);

Console.WriteLine("Length of N array ->");
string s_2 = Console.ReadLine();
n = Convert.ToInt32(s_2);

int temp4 = 0;
if (m < n)
{
    temp4 = m;
    m = n;
    n = temp4;
}

int[] M = new int[m];
int[] N = new int[n];

//Создание объекта для генерации чисел
Random rnd = new Random();

Console.WriteLine($"M: ");
for (int i = 0; i < M.Length; i++)
{
    M[i] = rnd.Next() % 10;  //Получить очередное случайное число
    Console.WriteLine($"M[{i}] -> {M[i]}");
}

Console.WriteLine($"N: ");
for (int i = 0; i < N.Length; i++)
{
    N[i] = rnd.Next() % 10;  //Получить очередное случайное число
    Console.WriteLine($"M[{i}] -> {N[i]}");
}

int[] total_array = new int[1];

int index_t = 0, count_t = 0;
int size_t = 1;


for (int i = 0; i < m; i++)
{
    count_t = 0;
    for (int j = 0; j < n; j++) {
        if (M[i] == N[j]) {
            if (total_array.Length == 1) {
                total_array[index_t] = M[i];
                size_t++;
                index_t++;
                Array.Resize(ref total_array, size_t);
            }
            else {
                for (int k = 0; k < total_array.Length - 1; k++) {
                    if (total_array[k] == M[i]) {
                        count_t++;
                    }
                }
                if (count_t == 0) {
                    total_array[index_t] = M[i];
                    size_t++;
                    index_t++;
                    Array.Resize(ref total_array, size_t);
                }
            }
        }
    }
}

Console.WriteLine($"total array: ");
for (int i = 0; i < total_array.Length; i++)
{
    Console.WriteLine($"total[{i}] -> {total_array[i]}");
}