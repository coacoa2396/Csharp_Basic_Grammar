namespace _14.Delegate
{
    internal class Program
    {
        /****************************************************************
        * 대리자 (Delegate)
        * 
        * 특정 매개 변수 목록 및 반환 형식이 있는 함수에 대한 참조
        * 대리자 인스턴스를 통해 함수를 호출 할 수 있음
        ****************************************************************/

        // <델리게이트 정의>
        // delegate 반환형 델리게이트이름(매개변수들);
        public delegate float Delegate1(float left, float right);
        public delegate void Delegate2(string str);

        public static float Add(float left, float right) {  return left + right; }
        public static float Minus(float left, float right) { return left - right; }
        public void Message(string message) { Console.WriteLine(message); }

        void Main1()
        {
            int value = 2;                          // 자료형에 값을 담아서 사용하듯

            Delegate1 delegate1 = Add;              // 델리게이트에 함수를 담아서 사용
            float result = delegate1(1.2f, 3.4f);   // Add(1.2f, 3.4f) == 4.6f

            delegate1 = Minus;
            result = delegate1(3.4f, 1.2f);         // Minus(3.4f, 1.2f)  == 2.2f

            // delegate1 = Message;                 // delegate1 의 형태가 int이기 때문에
                                                    // Message 함수를 담을 수 없다
                                                    // 형태가 일치하는 함수만 담을 수 있다
            Delegate2 delegate2 = Message;          // delegate2 의 형태가 Message와 일치
                                                    // 그래서 사용 가능
        }

        // 프로그램 -> 일반화 -> 콜백 -> 지정자 -> 람다식


        static void Main(string[] args)
        {
          
        }
    }
}
