﻿/*주석(Comment)
 *소스 코드에 영향을 주지않는 텍스트
 *소스 코드에 대한 의도를 설명하기 위한 용도로 사용 */


// <주석 종류>
//  //      : 한줄 주석 : // 이후 텍스트를 주석으로 취급
//  /* */   : 범위 주석 : 시작(/*)에서 끝(*/)까지 텍스트를 주석으로 취급
//  ///     : 문서 주석 : 함수 또는 클래스 앞에서 /// 입력으로 자동완성 및 Visual Studio에서 정보표시기능



/******************************************************
 * Using 지시문
 * 
 * 소스코드의 상단부에 위치하며 네임스페이스를 선언함
 * 선언 이후 소스코드에서 네임스페이스 안의 기능을 사용
 ******************************************************/

using System;// 이후 소스코드부터 System 네임스페이스 안의 기능을 사용

/************************************************************* 
 * 네임스페이스 (Namespace)
 * 
 * 기능이나 구분이 비슷한 기능들을 하나의 이름 아래 묶는 기능
 * 수많은 클래스 사용에 혼란이 적도록 용도/분야 별로 정리
 *************************************************************/

namespace _00._programming
{


    /************************************ 
     * 클래스 (Class)
     * 
     * C# 프로그램을 구성하는, 객체를 만드는 기본 단위
     * 데이터와 기능으로 구성
     ************************************/

    /// <summary>
    /// Program에 대한 설명
    /// </summary>
    class Program


    /******************************************************
     * Main 함수
     * 
     * 프로그램의 처음 시작지점이 되는 함수
     * C# 프로그램은 반드시 하나의 Main 함수를 포함해야 함
     * 똑같은 Main함수가 두개 있어도 불가능
     ******************************************************/

    {/// <summary>
     ///  Main 함수 기능 설명
     /// </summary>
     /// <param name="args"></param> 여기에는 매개변수 작성
        static void Main(string[] args)
        {
            // 프로그램은 Main 함수를 시작으로 순서대로 처리됨

            // <표준입출력>
            // 콘솔 : 컴퓨터와 사용자가 소통하기 위한 클래스
            // Console.WriteLine	: 콘솔에 출력하고 줄 바꿈
            // Console.Write		: 콘솔에 출력하고 줄을 바꾸지 않음
            // Console.ReadLine		: 콘솔을 통해 한줄 입력받음
            // Console.ReadKey		: 콘솔을 통해 키 입력받음

            Console.WriteLine("로그인\n\n");

            Console.Write("캐릭터의 이름은 : ");

            Console.ReadLine();

            Console.WriteLine("캐릭터 선택");
                        
            Console.WriteLine("마을 진입");
            
            Console.WriteLine("포션을 구매하나요?");
           
            Console.ReadLine();//엔터 칠 때까지 입력을 받는 방식
            
            Console.WriteLine("던전에 들어가나요?");

            Console.ReadKey();//아무 키나 누르는 순간 넘어감(하나의 키 입력 받기)

            Console.WriteLine("\n사냥");
            
            Console.WriteLine("접속종료");
            
            Console.WriteLine("Hello, World!"); //콘솔출력

        }
    }
}