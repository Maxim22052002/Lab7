using System;

namespace Number1_7_
{
    class Program
    {
        
        
            enum EnumType : int
        {
            K,
            O
        }
        struct PriceList
        {
            public string nameofprod;
            public EnumType type;
            public double price;
            public int quantity;
        }
        static void Main(string[] args)
        {

            PriceList[] pricelist = new PriceList[50];
            DateTime[] dateTimes = new DateTime[50];
            string[] explainer = new string[50];
            int pos = 3;
            pricelist[0].nameofprod = "Папка"; pricelist[0].type = EnumType.K; pricelist[0].price = 4.75; pricelist[0].quantity = 400;
            pricelist[1].nameofprod = "Бумага A4 (пачка)"; pricelist[1].type = EnumType.K; pricelist[1].price = 45.90; pricelist[1].quantity = 100;
            pricelist[2].nameofprod = "Калькулятор"; pricelist[2].type = EnumType.O; pricelist[2].price = 411.00; pricelist[2].quantity = 10;
            bool mark = true;
            int datepos = 0;
            while (mark)
            {
                Console.WriteLine("1 - Просмотр таблицы\n2 - Добавить запись\n3 - Удалить запись\n4 - Обновить запись\n5 - Поиск записей\n6 - Просмотреть лог\n7 - Сортировка данных \n8 - Выход");
                string inpusolution = Console.ReadLine();
                switch (inpusolution)
                {
                    case "1":
                        Console.Clear();
                        for (int i = 0; i < pos; i++)
                        {
                            Console.WriteLine($"{pricelist[i].nameofprod,-20}|{pricelist[i].type,-15}|{pricelist[i].price,-10}|{pricelist[i].quantity,-10}");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Введите наименование товара: ");
                        pricelist[pos].nameofprod = Console.ReadLine();
                        Console.WriteLine("Введите тип товара: ");
                        pricelist[pos].type = (EnumType)Enum.Parse(typeof(EnumType), Console.ReadLine());
                        bool IsCorrect = Enum.IsDefined(typeof(EnumType), pricelist[pos].type);
                        if (IsCorrect)
                        {
                            Console.WriteLine("Value is correct.");
                        }
                        else
                        {
                            Console.WriteLine("Value is not correct.");
                        }
                        Console.WriteLine("Введите Цена за 1 шт (грн): ");
                        pricelist[pos].price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите количество товара: ");
                        pricelist[pos].quantity = Convert.ToInt32(Console.ReadLine());
                        dateTimes[datepos] = DateTime.Now;
                        string addnote = pricelist[3].nameofprod;
                        if (IsCorrect == true)
                        {

                            explainer[datepos] = $"запись добавлена \"{addnote}\"";
                            datepos++;
                            pos++;
                        }
                        //else
                        //{

                        //}
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Введите номер удаляемой записи: ");
                        int numdel = Convert.ToInt32(Console.ReadLine());
                        string numrec = pricelist[numdel].nameofprod;
                        explainer[datepos] = $"запись удалена \"{numrec}\"";
                        for (int i = numdel; i < pos; i++)
                        {
                            pricelist[i].nameofprod = pricelist[i + 1].nameofprod;
                            pricelist[i].type = pricelist[i + 1].type;
                            pricelist[i].price = pricelist[i + 1].price;
                            pricelist[i].quantity = pricelist[i + 1].quantity;
                        }
                        pos--;
                        dateTimes[datepos] = DateTime.Now;
                        datepos++;

                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Введите номер редактируемой записи: ");
                        int numberred = Convert.ToInt32(Console.ReadLine());
                        string postupdated = pricelist[numberred].nameofprod;
                        Console.WriteLine("Введите новое наименование товара: ");
                        pricelist[numberred].nameofprod = Console.ReadLine();
                        Console.WriteLine("Введите новый тип товара: ");
                        pricelist[numberred].type = (EnumType)Enum.Parse(typeof(EnumType), Console.ReadLine());
                        bool IsCorrect1 = Enum.IsDefined(typeof(EnumType), pricelist[pos].type);
                        if (IsCorrect1)
                        {
                            Console.WriteLine("Value is correct.");
                        }
                        else
                        {
                            Console.WriteLine("Value is not correct.");
                        }
                        Console.WriteLine("Введите новую Цену за 1 шт (грн):");
                        pricelist[numberred].price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите новое количество товара: ");
                        pricelist[numberred].quantity = Convert.ToInt32(Console.ReadLine());


                        dateTimes[datepos] = DateTime.Now;
                        if (IsCorrect1 == false)
                        {
                            explainer[datepos] = $"запись обновлена \"{postupdated}\"";
                            datepos++;
                        }
                        Console.Clear();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Введите минимальную цену: ");
                        double minprice = Convert.ToDouble(Console.ReadLine());
                        for (int i = 0; i < pos; i++)
                        {
                            if (pricelist[i].price > minprice)
                            {
                                Console.WriteLine($"{pricelist[i].nameofprod,-20}|{pricelist[i].type,-15}|{pricelist[i].price,-10}|{pricelist[i].quantity,-10}");
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "6":
                        Console.Clear();
                        TimeSpan longperiodinactivity = dateTimes[1].Subtract(dateTimes[0]);
                        for (int i = 0; i < datepos; i++)
                        {
                            Console.WriteLine($"{dateTimes[i].Hour}:{dateTimes[i].Minute}:{dateTimes[i].Second} - {explainer[i]}");
                            if ((dateTimes[i + 1].Subtract(dateTimes[i])) > longperiodinactivity)
                            {
                                longperiodinactivity = dateTimes[i + 1].Subtract(dateTimes[i]);
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine($"{longperiodinactivity.Hours}:{longperiodinactivity.Minutes}:{longperiodinactivity.Seconds} - Наибольший период бездействия пользователя.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "7":
                        SortData(pricelist, pos);
                        Console.Clear();
                        Console.WriteLine("Сортировка успешно произведена!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "8":
                        mark = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                   
                        static void SortData(PriceList[]array,int pos)
                        {
                            for(int i = 0; i < pos-1; i++)
                            {
                                int min = i;
                                for(int j = i + 1; j < pos; j++)
                                {
                                    if (array[j].price < array[min].price)
                                    {
                                        min = j;
                                    }
                                }
                                PriceList mark = array[min];
                                array[min] = array[i];
                                array[i] = mark;
                            }
                        }






                }
            }
        }
    }
    
}
