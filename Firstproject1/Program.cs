//꿀팁
//컨트롤 + k + u  (주석 풀기) 
//컨트롤 + k + c  (주석 걸기)
//알트 + 쉬프트 + 방향키 (선택한줄 똑같이 변경)

using System;
using System.ComponentModel;



namespace Firstproject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 선언문
            //int a;
            //a = 18;

            //char b;
            //b = 'x';

            //string c;
            //c = "Hello World";

            //Console.WriteLine(c);

            //float d;
            //d = 18.18f;

            //double e;
            //e = 18.182838;

            //bool f;
            //f = true;
            //f = false;

            //short g;
            //g = 1818;


            //long h;
            //h = 18181818;
            #endregion
            #region 사칙연산
            //Console.WriteLine(5 + 2);
            //Console.WriteLine(5 - 2);
            //Console.WriteLine(5 * 2);

            //Console.WriteLine(11 / 3);
            //Console.WriteLine(11 % 3);

            //int firstNum = 3;
            //int secoundnum = 9;

            //Console.WriteLine(firstNum + secoundnum);

            //int result;
            //result = firstNum * 3 + secoundnum;//연산자 우선순위

            //int firstNum = 2;
            //Console.WriteLine(firstNum);

            //firstNum = firstNum + 1;

            //firstNum++;
            //Console.WriteLine(firstNum);
            #endregion
            #region 입력
            //string input;//문자열을 기억할 수 있는 변수선언
            //input = Console.ReadLine();
            //Console.WriteLine(input);

            //string age;
            //age = Console.ReadLine();
            //Console.WriteLine("당신의 나이는 {0}세 입니다", age);
            //Console.WriteLine($"당신의 나이는 {age}세 입니다");
            //age = age + 1;

            //Console.WriteLine($"당신의 나이는 {age}세 입니다");

            //Console.WriteLine("준비되면 " + 11);


            #endregion
            #region 문자열을 숫자로
            //string input;
            //int intage; //정수형 변수 선언

            //input = Console.ReadLine();

            //intage = int.Parse(input);

            //Console.WriteLine(intage);

            //intage = intage + 1;

            //Console.WriteLine(intage);
            #endregion
            #region 숫자인지 문자가 들어갔는지 검사

            //int intage;
            //string toChange;
            //bool isCorrect;


            //toChange = Console.ReadLine();

            ////여기서 toChange는 바꾸고자하는 문자열 intage는 담을려고 하는 정수변수를 넣는다
            //isCorrect = int.TryParse(toChange, out intage);


            //Console.WriteLine("값이 제대로 들어갔나요? " + isCorrect);
            //Console.WriteLine(intage);
            #endregion
            #region 숫자인지 문자가 들어갔는지 검사 예시
            //int reward = 9; //퀘스트 보상
            //int partyMember = 4;//파티맴버수

            //double dividedMoney = (double)reward / partyMember;

            //Console.WriteLine(dividedMoney);

            #endregion
            #region 실습과제 1
            /*
            - 이름을 입력받아, 반갑다고 출력하는 프로그램을 작성해주세요
            - "당신의 이름을 입력해주세요" 출력
            - 다음줄에서 이름을 입력 받기
            - "(방금입력받은이름)님 반갑습니다" 출력하는 프로그램
             */

            //string name;
            //Console.Write("당신의 이름을 입력해주세요 : ");
            //name = Console.ReadLine();
            //Console.WriteLine("{0}님 반갑습니다", name);
            #endregion
            #region 실습과제 2
            /*
             - 두 실수를 유저로부터 한줄씩 입력받아, 마지막 줄엔 둘의 합을 출력해보아요
             - "첫 번째 실수를 입력하여 주세요"
             - 다음 줄에서 입력 받기
             - "두 번째 실수를 입력하여 주세요"
             - 다음 줄에서 두번째 수 입력 받기
             - "두 수의 합은 ??? 입니다" 형식으로 출력
             */
            //double Num1;
            //double Num2;
            //double result;

            //Console.Write("첫 번째 실수를 입력하여 주세요 : ");
            //Num1 = double.Parse(Console.ReadLine());
            //Console.Write("두 번째 실수를 입력하여 주세요 : ");
            //Num2 = double.Parse(Console.ReadLine());

            //result = Num1 + Num2;

            //Console.WriteLine("두 수의 합은 {0} 입니다", result);

            #endregion
            #region 실습과제 3
            /*
             - 두 정수를 유저로부터 입력 받고, 몫과 나머지를 출력해보자
             - "나눗셈을 진행할 첫 번째 수를 입력하여 주세요: " 출력
             - 같은 줄에서 입력 받기
             - 그 다음줄로 와서 "두번째 나눌 수를 입력해주세요: " 출력
             - 위 출력과 같은 줄에서 입력을 받기
             - 그 다음 줄에서 "(첫째수)와 (둘째수)의 나눗셈 결과, 몫은 (몫) 나머지는 (나머지)" 출력
             */
            //int Num1;
            //int Num2;
            //int result;
            //int result2;

            //Console.Write("나눗셈을 진행할 첫 번째 수를 입력하여 주세요 : ");
            //Num1 = int.Parse(Console.ReadLine());

            //Console.Write("두번째 나눌 수를 입력해주세요 : ");
            //Num2 = int.Parse(Console.ReadLine());

            //result = Num1 / Num2;
            //result2 = Num1 % Num2;

            //Console.WriteLine("{0}와 {1}의 나눗셈 결과, 몫은 {2} 나머지는 {3}",Num1, Num2, result, result2);

            #endregion
            #region 실습과제 4
            /*
             - 세 정수를 유저로부터 입력 받고, 앞 두개 숫자를 더하고 세번째 수는 곱하는 프로그램을
               작성하되, **“첫째수 더하기 둘째수에 셋째수를 곱한 값은 X 입니다”** 라고 나오는 프로그램 제작.
             - "첫째 정수 입력" 출력
             - 같은 줄 혹은 다음 줄에 입력 받기
             - "둘째 정수 입력" 출력
             - 같은 줄 혹은 다음 줄에 입력 받기
             - "셋째 정수 입력" 출력
             - 같은 줄 혹은 다음 줄에 입력 받기
             - “첫째수 더하기 둘째수에 셋째수를 곱한 값은 (결과값) 입니다” 출력
             */
            int Num1;
            int Num2;
            int Num3;
            int result;


            Console.Write("첫 번째 수를 입력하여 주세요 : ");
            Num1 = int.Parse(Console.ReadLine());

            Console.Write("첫 번째 수를 입력하여 주세요 : ");
            Num2 = int.Parse(Console.ReadLine());

            Console.Write("첫 번째 수를 입력하여 주세요 : ");
            Num3 = int.Parse(Console.ReadLine());

            result = (Num1 + Num2) * Num3;

            Console.WriteLine("{0} 더하기 {1}에 {2}를 곱한 값은 {3} 입니다", Num1, Num2, Num3, result);

            #endregion
        }
    }
}
