namespace _12.Generic
{
    internal class Program 
    {
        /********************************************************************************************
         * 일반화 (Generic)
         * 
         * 클래스 또는 함수가 코드에 의해 선언되고 인스턴스화될 때까지 형식의 사양을 연기하는 디자인
         * 기능을 구현한 뒤 자료형을 사용 당시에 지정해서 사용
         ********************************************************************************************/

        // <일반화 함수>
        // 일반화를 이용하면 다른 자료형의 함수 또한 호환하도록 구현할 수 있음
        public static void ArrayCopy<T>(T[] source, T[] output)  // <T>로 보통 표현을 하고
        {                                                        // 풀어쓰면 Type 이다
            for (int i = 0; i < source.Length; i++)
            {
                output[i] = source[i];
            }
        }

        void Main1()
        {
            int[] iSrc = { 1, 2, 3, 4, 5 };
            int[] iOut = new int[5];

            ArrayCopy(iSrc, iOut);  // <자료형> T가 들어가는 자리에 사용할 자료형을 넣자
            // 뒤에 넣은 배열이 둘 다 int배열이기 때문에 <int>를 생략해도 사용이 가능하다
            float[] fSrc = { 1.2f, 2.3f, 3.4f };
            float[] fOut = new float[3];

            ArrayCopy<float>(fSrc, fOut);  

            // char 자료형도 물론 사용 가능하다
        }



        // <일반화 클래스>
        // 클래스에 필요한 자료형을 일반화하여 구현
        // 이후 클래스 인스턴스를 생성할 때 자료형을 지정하여 사용
        public class SafeArray<T>
        {
            T[] array;

            public SafeArray(int size)
            {
                array = new T[size];
            }

            public void Set(int index, T value)
            {
                if (index < 0 || index >= array.Length)
                    return;

                array[index] = value;
            }

            public T Get(int index)
            {
                if (index < 0 || index >= array.Length)
                    return default(T);      // default : T 자료형의 기본값

                return array[index];
            }
        }

        // <일반화 자료형 제약>
        // 일반화 자료형을 선언할 때 제약조건을 선언하여, 사용 당시 쓸 수 있는 자료형을 제한
        public static Type Bigger<Type>(Type left, Type right) where Type : IComparable
        {
            if(left.CompareTo(right) < 0)  // 비교가 가능한 자료형으로 제한을 하니까 비교가 가능
            {
                return right;
            }
            else
            {
                return left;
            }
        }
        // 아래는 사용 예시
        class StructT<T> where T : struct { }           // T는 구조체만 사용 가능
        class ClassT<T> where T : class { }             // T는 클래스만 사용 가능
        class NewT<T> where T : new() { }               // T는 매개변수 없는 생성자가 있는 자료형만 사용 가능

        class ParentT<T> where T : Parent { }           // T는 Parent 파생클래스만 사용 가능
        class InterfaceT<T> where T : IComparable { }   // T는 인터페이스를 포함한 자료형만 사용 가능

        class Parent { }
        class Child : Parent { }


        static void Main(string[] args)
        {
           
        }
    }
}
