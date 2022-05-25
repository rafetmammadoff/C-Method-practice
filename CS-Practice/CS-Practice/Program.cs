using System;

namespace CS_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "rafet", "nurlan", "eli", "mehemmed", "rubabe" };
            NameCounter(names);  // 1-ci tapsiriq metodu

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 91, 12, 14, 12, 13, 32 };

            int[] arr =EvenDigits(numbers);  // 2-ci tapsiriq metodu
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }


            //******************************************************* 3-cu Elave tapsiriq*******************************
            Console.WriteLine("Array-in uzunlugunu daxil edin : ");
            int count = Convert.ToInt32(Console.ReadLine());
            string[] names1 = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i}-ci adi daxil edin");
                names1[i] = Console.ReadLine();
            }
            Console.WriteLine("Axtardiginiz adi daxil edin : ");
            string name=Console.ReadLine();

            Check(names1, name);  // 3-cu Elave tapsiriq metodu *****************************************************


            //******************************************************** 4-cu Elave tapsiriq*******************************


            string[] names2 = new string[0];
            string test;
            do
            {
                Console.WriteLine("Ad daxil edin");
                string name2 = Console.ReadLine();
                names2 = AddToArr(name2, names2);
                Console.WriteLine("Yeniden daxil edirsinizmi?");
                test = Console.ReadLine();

            } while (test == "beli");

            Console.WriteLine("Axtardiginiz adi daxil edin : ");

            string searchName=Console.ReadLine();

            SearchName(names2,searchName);

        }


        #region 1-ci Tapsiriq******************************************************************************************
                    // Verilmis adlar siyahisinda (string array) nece adin uzunlugunun 5-den boyuk oldugunu tapan proqram

        static int NameCounter(string[] names)
        {
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > 5)
                {
                    count++;

                }
            }
            Console.WriteLine(count);
            return count;
        }
        #endregion

        #region 2-ci Tapsiriq******************************************************************************************
                // Verilmis ededler siyahisindaki cut ededlerden ibraret yeni bir array qaytaran method.

        static int[] EvenDigits(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] evens = new int[count];
            int evenIndex = 0;

            for (int a = 0; a < numbers.Length; a++)
            {
                if (numbers[a] % 2 == 0)
                {
                    evens[evenIndex] = numbers[a];
                    evenIndex++;

                }
            }
            
            return evens;
        }
        #endregion

        #region 3-cu Elave tapsiriq ******************************************************************************************
        // Layihe ise dusdukde sizden adlarin sayini istesin. Daha sonra o say qeder adlari daxil edin.
        // Daha sonra axtardiginiz adi istesin, onu da daxil etdikden sonra siyahida olub olmadigini qaytarsin

        static bool Check(string[] names,string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i]==name)
                {
                    Console.WriteLine("True");
                    return true;
                }
                
            }
            Console.WriteLine("False");
            return false;
        }
        #endregion

        #region 4-cu Elave tapsiriq Dersde mene Elave verdiyiniz ******************************************************************************************
        // Layihe ise dusdukde sizden ad yazmaginizi istesin. Sonra yene daxil etmek istiyirsinizmi sorussun.
        // Eger beli yazsaniz tekrar ad yazin taki yox yazana qeder.Ve adlar bir arrayda toplansin
        // Daha sonra axtardiginiz adi istesin, onu da daxil etdikden sonra siyahida olub olmadigini qaytarsin


        static string[] AddToArr(string name, string[] arr)
        {
            string[] newArr = new string[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = name;

            return newArr;
        }


        static bool SearchName(string[] names ,string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i]==name)
                {
                    Console.WriteLine("True");
                    return true;
                }
            }
            Console.WriteLine("False");
            return false;
        }
        #endregion
    }
}
