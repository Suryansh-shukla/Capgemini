
using System;

class Eval
{
    public string Calc(string e)
    {
        var p=e.Split(' ');
        if(p.Length!=3) return "Error:InvalidExpression";
        if(!int.TryParse(p[0],out int a)||!int.TryParse(p[2],out int b))
            return "Error:InvalidNumber";
        return p[1] switch
        {
            "+"=>(a+b).ToString(),
            "-"=>(a-b).ToString(),
            "*"=>(a*b).ToString(),
            "/"=>b==0?"Error:DivideByZero":(a/b).ToString(),
            _=>"Error:UnknownOperator"
        };
    }
}
class Program
{
    static void Main()
    {
        Eval e=new Eval();
        Console.WriteLine(e.Calc("10 / 2"));
    }
}
