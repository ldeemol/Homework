using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_28과제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 과제 0
            /*
             4개의 정수를 담을 수 있는 배열을 하나 생성 후,
             사용자에게 순서대로 값 입력 받아 순서대로 배열에 담기.
             해당 문을 포이치로 출력하기
             
             1. int 4개를 담을 배열을 선언
             2. "1번 요소를 입력하여주십시오" 출력 후 입력받기
             3. 나머지 번호도 마찬가지로 입력
             4. "입력된 요소는 다음과 같습니다" 다음 줄에 입력된 값들 4개 출력
             */

            //정수만 입력받는것을 기준으로 잡는다


            //int[] four = new int[4];
            //Console.WriteLine("1번 요소를 입력하여주십시오");
            //four[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("2번 요소를 입력하여주십시오");
            //four[1] = int.Parse(Console.ReadLine());
            //Console.WriteLine("3번 요소를 입력하여주십시오");
            //four[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("4번 요소를 입력하여주십시오");
            //four[3] = int.Parse(Console.ReadLine());

            //foreach (int num in four)
            //{
            //    Console.WriteLine("입력된 요소는 다음과 같습니다: " + num);
            //}


            #endregion

            #region 과제 1
            /*
             플레이어에게 4개의 스킬이 있고, 각각 쿨타임이 존재. 매 턴마다 쿨타임이 줄어드는 기능 제작
             1. 길이가 4인 int 배열 skillCooldowns를 만들기
             2. 초기값은 [5, 3, 10, 7]
             3. 매 턴마다 배열의 모든 값을 1씩 줄임
             4. 쿨타임이 0 이하가 되면 "스킬 X 사용 가능!"을 출력하고, 값을 그대로 0으로 유지
             5. 매 턴마다 배열의 상태를 출력
             힌트: 
             반복문을 사용해서 배열 값을 수정하고 출력
             조건문으로 값이 0 이하인지 확인
             */
            //int[] skillCooldowns = new int[4];
            //int NumClick;

            //skillCooldowns[0] = 5;
            //skillCooldowns[1] = 3;
            //skillCooldowns[2] = 10;
            //skillCooldowns[3] = 7;

            //while (true)
            //{
            //    NumClick = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //    skillCooldowns[0] = skillCooldowns[0] - 1;
            //    if (skillCooldowns[0] <= 0)
            //    {
            //        skillCooldowns[0] = 0;
            //        Console.WriteLine("스킬 1 사용 가능!");
            //        Console.WriteLine();
            //    }
            //    skillCooldowns[1] = skillCooldowns[1] - 1;
            //    if (skillCooldowns[1] <= 0)
            //    {
            //        skillCooldowns[1] = 0;
            //        Console.WriteLine("스킬 2 사용 가능!");
            //        Console.WriteLine();
            //    }
            //    skillCooldowns[2] = skillCooldowns[2] - 1;
            //    if (skillCooldowns[2] <= 0)
            //    {
            //        skillCooldowns[2] = 0;
            //        Console.WriteLine("스킬 3 사용 가능!");
            //        Console.WriteLine();
            //    }
            //    skillCooldowns[3] = skillCooldowns[3] - 1;
            //    if (skillCooldowns[3] <= 0)
            //    {
            //        skillCooldowns[3] = 0;
            //        Console.WriteLine("스킬 4 사용 가능!");
            //        Console.WriteLine();
            //    }

            //        Console.WriteLine($"1번칸 쿨타임 {skillCooldowns[0]}\t 2번칸 쿨타임 {skillCooldowns[1]}");
            //        Console.WriteLine($"3번칸 쿨타임 {skillCooldowns[2]}\t 4번칸 쿨타임 {skillCooldowns[3]}");
            //        Console.WriteLine();

            //}
            #endregion

            #region 과제 2
            /*
             4x4 16개의  정수를 담을 수 있는 2차원 배열을 만든 후,
             반복문을 이용하여 3의 배수들로 채워 넣는다.
             그 후 2행3열 요소와 3행 2열 요소를 바꾼 후 출력하여보자
             
             1. int형 2차원 배열을 선언
             2. 반복문을 통하여 순서대로 3의 배수들로 채워넣음
             3. 2행3열 요소와 3행 2열 요소를 바꾼다
             4. 4x4의 형태로 들어있는 숫자들을 출력
             */

            int change = 0;
            int ThreeMultiples = 0;
            int[,] ThreeMultiplesAll = new int[4, 4];
            {
                for (int i = 0; i < ThreeMultiplesAll.GetLength(0); i++)
                {
                    for (int j = 0; j < ThreeMultiplesAll.GetLength(1); j++)
                    {

                        ThreeMultiples = ThreeMultiples + 3;
                        ThreeMultiplesAll[i, j] = ThreeMultiplesAll[i, j] + ThreeMultiples;
                    }
                }

                change = ThreeMultiplesAll[1, 2];
                ThreeMultiplesAll[1, 2] = ThreeMultiplesAll[2, 1];
                ThreeMultiplesAll[2, 1] = change;

                for (int i = 0; i < ThreeMultiplesAll.GetLength(0); i++)
                {
                    for (int j = 0; j < ThreeMultiplesAll.GetLength(1); j++)
                    {
                        Console.Write($"{ThreeMultiplesAll[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                #endregion

                #region 심화과제 1
                /*
                 1차원 스트링 배열을 하나 만들고, 유저에게 원하는 크기를 입력받아 생성함.
                 숫자가 아니거나, 음수거나, 10이 넘어가는 숫자를 입력시, 무한으로 재요구 하기.
                 생성 후, n칸의 인벤토리가 생성되었다고 출력하기. 

                 ※생성과 동시에 이런식으로 “” 으로 초기화 (예시)

                 유저에게 무한 반복으로 몇번째 칸을 열람하겠냐고 숫자를 입력 받은 후,
                 해당 칸이 "", 즉 비어있었다면 , "비어있습니다. 넣고자 하는 값을 입력하세요" 출력,
                 해당 칸이 ""가 아닌 값이 들어있었다면 해당 값을 출력하기.
                 종료를 원하면 0을 입력하라고 하기.

                 1. "원하는 인벤토리의 크기를 입력하세요" 출력 후 숫자 입력받기. 1~10 아니면 무한반복
                 2. "n개 만큼의 인벤토리가 생성되었습니다" 출력
                 3. "열람을 원하는 번호를 입력해주시기 바랍니다" 출력 후 유저의 입력 받기
                 4. 칸이 비어있다면("" 이 들어있다면) "칸이 비었습니다. 값을 입력하세요" 출력
                 5. 번호에 해당하는 칸에 내용물이 있었다면 해당 내용을 출력
                 6. 출력 후 다시 입력 받을 수 있게 무한 반복
                 7. 0을 입력받으면 무한반복 종료
                 */

                //string UserwantBag;
                //int UserBagSize;
                //bool check;
                //int Userpick;
                //string[] UserMaxbagSize = null;
                //string UserEnter;


                //Console.Write("원하는 인벤토리의 크기를 입력하세요: ");
                //UserwantBag = Console.ReadLine();
                //Console.WriteLine();
                //check = int.TryParse(UserwantBag, out UserBagSize);
                //if (check == true && UserBagSize > 0 && UserBagSize <= 10)
                //{
                //    UserMaxbagSize = new string[UserBagSize];
                //    for (int i = 0; i < UserMaxbagSize.Length; i++)
                //    {
                //        UserMaxbagSize[i] = "";

                //    }
                //}
                //else if (check == false || UserBagSize <= 0 || UserBagSize > 10)
                //{
                //    while (check == false || UserBagSize <= 0 || UserBagSize > 10)
                //    {
                //        Console.Write("원하는 인벤토리의 크기를 다시 입력하세요: ");
                //        UserwantBag = Console.ReadLine();
                //        check = int.TryParse(UserwantBag, out UserBagSize);
                //    }
                //    UserMaxbagSize = new string[UserBagSize];
                //    for (int i = 0; i < UserMaxbagSize.Length; i++)
                //    {
                //        UserMaxbagSize[i] = "";

                //    }
                //}
                //else
                //{
                //    Console.WriteLine("첫 if문에서 조건이 잘못된것 같네요");
                //}

                //while (true)
                //{
                //    Console.WriteLine();
                //    Console.Write("몇번째 칸을 열람하겠습니까?: ");

                //    UserwantBag = Console.ReadLine();
                //    Console.WriteLine();
                //    check = int.TryParse(UserwantBag, out Userpick);
                //    if (Userpick == 0)
                //    {
                //        Console.WriteLine("프로그램을 종료합니다");
                //        break;
                //    }
                //    if (check == true && Userpick > 0 && Userpick <= UserBagSize)
                //    {
                //        if (UserMaxbagSize[Userpick-1] == "")
                //        {
                //            Console.Write($"{Userpick}번째 칸이 비었습니다. 값을 입력하세요: ");
                //            UserEnter = Console.ReadLine();
                //            Console.WriteLine();
                //            UserMaxbagSize[Userpick-1] = UserEnter;
                //            UserEnter = null;

                //        }
                //        else if (UserMaxbagSize[Userpick-1] != "")
                //        {
                //            Console.WriteLine($"{Userpick}번째 안에 있는내용입니다.[ {UserMaxbagSize[Userpick-1]} 내용이 있습니다. ]");
                //            continue;
                //        }

                //    }
                //    else if (check == false || Userpick <= 0 || Userpick > UserBagSize)
                //    {
                //        Console.WriteLine("잘못입력하셨습니다 다시 입력해주세요.");
                //        continue;
                //    }
                //    else
                //    {
                //        Console.WriteLine("두번째 if문에서 조건이 잘못된것 같네요");
                //    }
                //}
                #endregion

                #region
                //int[] skillCooldowns = new int[4];
                //int NumClick;

                //skillCooldowns[0] = 5;
                //skillCooldowns[1] = 3;
                //skillCooldowns[2] = 10;
                //skillCooldowns[3] = 7;

                //while (true)
                //{
                //    NumClick = int.Parse(Console.ReadLine());
                //    Console.WriteLine();
                //    skillCooldowns[0] = skillCooldowns[0] - 1;
                //    if (skillCooldowns[0] <= 0)
                //    {
                //        skillCooldowns[0] = 0;
                //        Console.WriteLine("스킬 1 사용 가능!");
                //        Console.WriteLine();
                //    }
                //    skillCooldowns[1] = skillCooldowns[1] - 1;
                //    if (skillCooldowns[1] <= 0)
                //    {
                //        skillCooldowns[1] = 0;
                //        Console.WriteLine("스킬 2 사용 가능!");
                //        Console.WriteLine();
                //    }
                //    skillCooldowns[2] = skillCooldowns[2] - 1;
                //    if (skillCooldowns[2] <= 0)
                //    {
                //        skillCooldowns[2] = 0;
                //        Console.WriteLine("스킬 3 사용 가능!");
                //        Console.WriteLine();
                //    }
                //    skillCooldowns[3] = skillCooldowns[3] - 1;
                //    if (skillCooldowns[3] <= 0)
                //    {
                //        skillCooldowns[3] = 0;
                //        Console.WriteLine("스킬 4 사용 가능!");
                //        Console.WriteLine();
                //    }

                //    Console.WriteLine($"1번칸 쿨타임 {skillCooldowns[0]}\t 2번칸 쿨타임 {skillCooldowns[1]}");
                //    Console.WriteLine($"3번칸 쿨타임 {skillCooldowns[2]}\t 4번칸 쿨타임 {skillCooldowns[3]}");
                //    Console.WriteLine();

                //}

                #endregion
            }
        }
    }
}

