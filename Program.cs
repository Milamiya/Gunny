using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void GameKeoBuaBao()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int UserChon, Botchon;
            Console.Write(" Mời bạn chọn: ");
            /*
            while (int.TryParse(Console.ReadLine(), out UserChon) == false)
            {
                Console.Write("Nhập lại !!!!");
            }
            while (UserChon < 1 || UserChon > 3)
            {
                Console.Write("Nhập lại !!!!");
                while (int.TryParse(Console.ReadLine(), out UserChon) == false)
                {
                    Console.Write("Nhập lại !!!!");
                }
            }
            */
            string str = Console.ReadLine();
            while(str != "Kéo" && str != "Búa" && str != "Bao")
            {
                Console.WriteLine("Nhập lại !!!!");
                str = Console.ReadLine();
            }
            if (str == "Kéo") UserChon = 1;
            else if (str == "Búa") UserChon = 2;
            else UserChon = 3;
            
            switch (UserChon == 1)
            {
                case true:
                    Console.WriteLine(" Bạn đã chọn Kéo");
                    break;
                case false:
                    switch (UserChon == 2)
                    {
                        case true:
                            Console.WriteLine(" Bạn đã chọn Búa");
                            break;
                        case false:
                            Console.WriteLine(" Bạn đã chọn Bao");
                            break;
                    }
                    break;
            }
            Random rd = new Random();
            Botchon = rd.Next(1, 3);         
            switch (Botchon == 1)
            {
                case true:
                    Console.WriteLine(" Máy đã chọn Kéo");
                    break;
                case false:
                    switch (Botchon == 2)
                    {
                        case true:
                            Console.WriteLine(" Máy đã chọn Búa");
                            break;
                        case false:
                            Console.WriteLine(" Máy đã chọn Bao");
                            break;
                    }
                    break;
            }
            if (UserChon == Botchon)
            {
                Console.WriteLine(" ---Kết quả--- ");
                Console.WriteLine(" -----HÒA----- ");
            }
            else
            {
                if (UserChon == 1)
                {
                    if (Botchon == 2)
                    {
                        Console.WriteLine(" ---Kết quả--- ");
                        Console.WriteLine("   --THUA--    ");
                    }
                    else
                    {
                        Console.WriteLine(" ---Kết quả--- ");
                        Console.WriteLine("   --THẮNG--   ");
                    }
                }
                else if (UserChon == 2)
                {
                    if (Botchon == 3)
                    {
                        Console.WriteLine(" ---Kết quả--- ");
                        Console.WriteLine("   --THUA--    ");
                    }
                    else
                    {
                        Console.WriteLine(" ---Kết quả--- ");
                        Console.WriteLine("   --THẮNG--   ");
                    }
                }
                else
                {
                    if (Botchon == 1)
                    {
                        Console.WriteLine(" ---Kết quả--- ");
                        Console.WriteLine("   --THUA--    ");
                    }
                    else
                    {
                        Console.WriteLine(" ---Kết quả--- ");
                        Console.WriteLine("   --THẮNG--   ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("     ************************************");
            Console.WriteLine("     *      TRÒ CHƠI KÉO, BÚA, BAO      *");
            Console.WriteLine("     *             Gõ Kéo               *");
            Console.WriteLine("     *             Hoặc Búa             *");
            Console.WriteLine("     *             Hoặc Bao             *");
            Console.WriteLine("     *             Để chơi              *");
            Console.WriteLine("     ************************************");
            int res;
            do
            {
                GameKeoBuaBao();
                Console.Write(" Bạn có muốn chơi tiếp không? < 1 - Có | 2 - Không >: ");
                while (int.TryParse(Console.ReadLine(), out res) == false)
                {
                    Console.Write(" Bạn có muốn chơi tiếp không ? < 1 - Có | 2 - Không >: ");
                }
                while (res < 1 || res > 2)
                {
                    Console.Write(" Bạn có muốn chơi tiếp không ? < 1 - Có | 2 - Không >: ");
                    while (int.TryParse(Console.ReadLine(), out res) == false)
                    {
                        Console.Write(" Bạn có muốn chơi tiếp không ? < 1 - Có | 2 - Không >: ");
                    }
                }
            }
            while (res == 1);

        }
    }
}
