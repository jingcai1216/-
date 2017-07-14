using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace StudentManagement
{

    /*
        添加用户操作类。至少包含2个方法：一个用于显示登录菜单；一个用于显示学生信息管理主操作菜单。
     */
    class UserOperate
    {
        //登录判断
        public static int ShowLogin()
        {
            Console.WriteLine("╭⌒╮┅~ ¤　 ╭⌒╮ ╭⌒╮ ");
            Console.WriteLine("╭⌒╭⌒╮╭⌒╮～╭⌒╮︶︶,　︶︶ ");
            Console.WriteLine(",︶︶︶︶,''︶~~ ,''~︶︶　 ,'' ");
            Console.WriteLine("╬　╱◥███◣╬╬╬╬╬╬╬╬╬╬╬");
            Console.WriteLine("╬ ︱田︱田 田 ︱　　　　　　　　　 ╬ ");
            Console.WriteLine("╬　　　　　　　　　　　　　　　　　╬");
            Console.WriteLine("╬　╭○╮● 　　        　　　　　 ╬");
            Console.WriteLine(@"╬　 /■\/■\                       ╬");
            Console.WriteLine("╬　　<|　||　　　　　              ╬");



            int flag = 0;  // 登陆成功标志位
            for (int i = 0; i < 3; i++)
            {
                Console.Write("请输入登录名：");
                string userName = Console.ReadLine();

                Console.Write("请输入密码：");
                string password = Console.ReadLine();

                if (userName == "pzw" && password == "1234")
                {
                    Console.WriteLine("现在是{0}，恭喜你登陆成功！", DateTime.Now);
                    flag = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry，用户名或密码错误，你还有{0}次机会", 2 - i);
                }
            }

            return flag;
        }

        //程序操作主菜单
        public static int MainMenu()
        {
            string flag = "y"; //结束标志位
            int select = 0; //选择菜单项
            StudentManger sm = new StudentManger();//创建一个学生管理类

            while (flag == "y" || flag == "Y")
            {
                Console.WriteLine("\t1.添加学生信息\n\t2.删除学生信息\n\t3.查询所有学生信息\n\t4.按学号查询学生信息\n\t5.按姓名查询学生信息\n\t6.退出系统");
                Console.Write("请选择：");
                try
                {
                    select = int.Parse(Console.ReadLine());
                    if (select < 1 || select > 6)
                        throw new Exception();
                }
                catch
                {
                    Console.WriteLine("请输入1~6的整数");
                    continue;
                }

                switch (select)
                {
                    case 1:
                        sm.AddStudent();//添加学生信息
                        break;
                    case 2:
                        Console.Write("请输入要删除学生的学号：");
                        int num;
                        while (true)
                        {
                            try
                            {
                                num = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.Write("学号为整数请重新输入：");
                            }
                        }
                        sm.DeleteNum(num);
                        break;
                    //删除学生信息
                    case 3:
                        sm.ReadAllStu();
                        break;
                    //查询所有学生信息
                    case 4:
                        Console.Write("请输入要查询学生的学号：");
                        int num1;
                        while (true)
                        {
                            try
                            {
                                num1 = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.Write("学号为整数请重新输入：");
                            }
                        }
                        sm.QueryStu(num1);
                        break;
                    //按学号查询学生信息
                    case 5:
                        Console.Write("请输入要查询学生的姓名：");
                        string name = string.Format(Console.ReadLine());
                        sm.QueryStu(name);
                        //按姓名查询学生信息
                        break;
                    
                    case 6:
                        return 0;
                    //退出系统
                    default:
                        Console.WriteLine("你的输入有误");
                        break;
                }

            }
            return 1;
        }
    }
}