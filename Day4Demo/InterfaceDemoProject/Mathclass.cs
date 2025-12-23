using System;

namespace InterfaceDemoProject
{
    public class MathClass : IAll
    {
        public int AddMe(int num1, int num2)
        {
            return num1 + num2;
        }

        public int SubMe(int num1, int num2)
        {
            return num1 - num2;
        }

        public int ProMe(int num1, int num2)
        {
            return num1 * num2;
        }

        public float DivMe(int num1, int num2)
        {
            return (float)num1 / num2;
        }
    }
}