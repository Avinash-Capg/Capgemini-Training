using System;

namespace InterfaceDemoProject
{
    public interface IAdd
    {
        int AddMe(int num1, int num2);
    }

    public interface ISub
    {
        int SubMe(int num1, int num2);
    }

    public interface IPro
    {
        int ProMe(int num1, int num2);
    }

    public interface IDiv
    {
        float DivMe(int num1, int num2);
    }

    public interface IAddSub : IAdd, ISub
    {
    }

    public interface IAddProDiv : IAdd, ISub, IDiv
    {
    }

    public interface IAll : IAdd, ISub, IPro, IDiv
    {
    }
}