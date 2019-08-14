using System;

namespace 事件
{
    //运动会上短跑项目，发令员扣动扳机响后运动员开始跑
    class Judgment
    {
        //定义一个委托
        public delegate void delegateRun();
        //定义一个事件
        public event delegateRun eventRun;
        //引发事件的方法
        public void Begin()
        {
            //被引发的事件
            eventRun();
        }
    }

    class RunSports
    {
        //定义事件的处理方法
        public void Run()
        {
            Console.WriteLine("运动员开始比赛");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //开始实现
        }
    }
}
