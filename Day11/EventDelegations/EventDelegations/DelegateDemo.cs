using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegations
{
    public delegate void GreetMsg(string msg);  // delegate declaration
    public delegate int calculation(int num1, int num2); // delegate declaration
    class Hindi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhat " + userName);
        }
    }
    class Telegu
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskaram " + userName);
        }
    }
    class Tamil
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Vanakkam " + userName);
        }
    }
    class Urdu
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Aslam waulikum " + userName);
        }
    }
    class Marathi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskara " + userName);
        }
    }

    public class DelegateDemo
    {
        public static void DelegateDemoMain()
        {
            Hindi h = new Hindi();
            Telegu t = new Telegu();
            Tamil ta = new Tamil();
            Urdu u = new Urdu();
            Marathi m = new Marathi();
            GreetMsg GreetInTamil = new GreetMsg(t.WelcomeMsg);
            GreetMsg gm; // delegate object creation
            gm = new GreetMsg(h.WelcomeMsg);
            gm("Ravi");
            gm = new GreetMsg(t.WelcomeMsg);
            gm("Suresh");
            gm = new GreetMsg(ta.WelcomeMsg);
            gm("Karthik");
            gm = new GreetMsg(u.WelcomeMsg);
            gm("Ahmed");
            gm = new GreetMsg(m.WelcomeMsg);
            gm("Ajay");
        }

    }
}
