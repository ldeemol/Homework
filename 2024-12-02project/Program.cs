using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_02project
{
    internal class Program
    {
        #region 과제1 enum문
        //enum SelectMap
        //{
        //    디폴트, 마을, 시냥터, 상점
        //}
        #endregion

        #region 과제 2 enum문
        enum state
        {
           idle=1, run, walk, die=9
        }
        #endregion


        static void Main(string[] args)
        {
            #region 과제 1
            //Console.WriteLine("이동 할 장소를 설정해주세요");
            //Console.WriteLine("1. 마을");
            //Console.WriteLine("2. 사냥터");
            //Console.WriteLine("3. 상점");
            //SelectMap selectedMap = SelectMap.디폴트;

            //Enum.TryParse(Console.ReadLine(), out selectedMap);

            //Console.Clear();

            //switch (selectedMap)
            //{
            //    case SelectMap.마을:
            //        Console.WriteLine("마을로 이동합니다");
            //        break;
            //    case SelectMap.시냥터:
            //        Console.WriteLine("사냥터로 이동합니다");
            //        break;
            //    case SelectMap.상점:
            //        Console.WriteLine("상점으로 이동합니다");
            //        break;
            //}
            #endregion

            #region 과제 2
            
            Console.WriteLine("1. idle");
            Console.WriteLine("2. run");
            Console.WriteLine("3. walk");
            state action;
            state check = 0;


            while (true)
            {

                Enum.TryParse(Console.ReadLine(), out action);
                switch (action)
                {
                    case state.idle:
                        if (check == action)
                        {
                            Console.WriteLine("이미 idle상태입니다.");
                        }
                        else 
                        { 
                            Console.WriteLine("idle로 변경되었습니다"); 
                        }
                        break;
                    case state.run:
                        if (check == action)
                        {
                            Console.WriteLine("이미 run상태입니다.");
                        }
                        else
                        {
                            Console.WriteLine("run로 변경되었습니다");
                        }
                        break;
                    case state.walk:
                        if (check == action)
                        {
                            Console.WriteLine("이미 walk상태입니다.");
                        }
                        else
                        {
                            Console.WriteLine("walk로 변경되었습니다");
                        }
                        break;
                    case state.die:

                        Console.WriteLine("die상태입니다");
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        continue;
                        
                }
                if (action == state.die)
                {
                Console.WriteLine("죽었습니다");
                break;
                }
                check = action;
            }

            #endregion


        }
    }
}
