using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    struct jc//结构
    {
        public string shangpin;
        public string xinghao;
        public int jiage;

    }



    class Program
    {

        string shangpin;
        string xinghao;
        int jiage;
        int no;

        public string Shangpin
        {
            set
            {
                shangpin = value;
            }
            get
            {
                return shangpin;
            }
        }
        public string Xinghao
        {
            set
            {
                xinghao = value;
            }
            get
            {
                return xinghao;
            }
        }
        public int Jiage
        {
            set
            {
                jiage = value;
            }
            get
            {
                return jiage;
            }
        }
        public int No
        {
            set
            {
                no = value;
            }
            get
            {
                return no;
            }
        }
        public virtual void speak()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", No, shangpin, xinghao, jiage);
        }
        public static void a()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" \n                                      服装销售");
            Console.WriteLine("                         %%%%%%%%%%%%%%");
            Console.WriteLine("\n                         | 请问你是？ |");
            Console.WriteLine("\n                         | 1.买家？   |");
            Console.WriteLine("\n                         | 2.卖家？   |");
            Console.WriteLine("                         %%%%%%%%%%%%%%");
            string x;
            x = Console.ReadLine();
            if (x == "1")
            {
                Buy();
            }
            else
                if (x == "2")
                {
                    Sale();
                }
        }A

        public static void Buy()
        {
            int num = 0;
            int i = 3;
            while (true)
            {
                Console.WriteLine("请输入用户名");
                string a = Console.ReadLine();
                Console.WriteLine("请输入密码");
                string b = Console.ReadLine();
                if (num < 2)
                {

                    if (a == "pzw" && b == "1234")
                    {
                    zhuyao:
                        Console.WriteLine("输入正确");
                        Console.Clear();
                        Console.WriteLine("                     -----------------请选择------------------");

                        Console.WriteLine("                                1：浏览商品        ");
                        Console.WriteLine("                                2：查找商品并加入购物车        ");
                        Console.WriteLine("                     -----------------------------------------");
                        int no;
                        no = Convert.ToInt16(Console.ReadLine());
                        if (no == 1)
                        {
                            Console.Clear();
                            xiaozu.男装();
                            xiaozu.女装();
                            xiaozu.童装();
                            Console.WriteLine("                     ----------------温馨提示------------------");
                            Console.WriteLine("                                  1.返回主页面                          ");

                            Console.WriteLine("                                   2.退出程序                       ");
                            Console.WriteLine("                     -----------------------------------------");
                            
                            int n1;
                            n1 = Convert.ToInt16(Console.ReadLine());
                            if (n1 == 1)
                            {
                                Console.Clear();
                                goto zhuyao;
                            }
                            else if (n1 == 2)
                            {
                                break;

                            }


                        }
                        else if (no == 2)
                        {
                            Console.Clear();
                            List<Program> jiesuan = new List<Program>();
                            Clothes1 c1 = new Clothes1();
                            c1.buyclothes1();
                            Clothes2 c2 = new Clothes2();
                            c2.buyclothes2();
                            Clothes3 c3 = new Clothes3();
                            c3.buyclothes3();
                            Clothes4 c4 = new Clothes4();
                            c4.buyclothes4();
                            Clothes5 c5 = new Clothes5();
                            c5.buyclothes5();
                            Clothes6 c6 = new Clothes6();
                            c6.buyclothes6();
                            Clothes7 c7 = new Clothes7();
                            c7.buyclothes7();
                            Clothes8 c8 = new Clothes8();
                            c8.buyclothes8();
                            Clothes9 c9 = new Clothes9();
                            c9.buyclothes9();
                            Clothes10 c10 = new Clothes10();
                            c10.buyclothes10();
                            Clothes11 c11 = new Clothes11();
                            c11.buyclothes11();
                            Clothes12 c12 = new Clothes12();
                            c12.buyclothes12();
                            Clothes13 c13 = new Clothes13();
                            c13.buyclothes13();
                            Console.Clear();

                            xiaozu.男装();
                            xiaozu.女装();
                            xiaozu.童装();

                            Console.WriteLine("              -----------------请选择------------------");

                            Console.WriteLine("                         选择你所找到喜欢的商品       ");
                            Console.WriteLine("                         填写时要写商品前的编号       ");
                            Console.WriteLine("                         输入   0    结束购买       ");
                            Console.WriteLine("                         输入   14    进行结算       ");
                            Console.WriteLine("              -----------------------------------------");
                            while (true)//while循环
                            {
                                int jg = int.Parse(Console.ReadLine());
                                if (jg == 0)
                                {
                                    Console.WriteLine("按任意键退出！！！");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                }
                                else if (jg == 1)
                                {
                                    jiesuan.Add(c1);
                                }
                                else if (jg == 2)
                                {
                                    jiesuan.Add(c2);
                                }
                                else if (jg == 3)
                                {
                                    jiesuan.Add(c3);
                                }
                                else if (jg == 4)
                                {
                                    jiesuan.Add(c4);
                                }
                                else if (jg == 5)
                                {
                                    jiesuan.Add(c5);
                                }
                                else if (jg == 6)
                                {
                                    jiesuan.Add(c6);
                                }
                                else if (jg == 7)
                                {
                                    jiesuan.Add(c7);
                                }
                                else if (jg == 8)
                                {
                                    jiesuan.Add(c8);
                                }
                                else if (jg == 9)
                                {
                                    jiesuan.Add(c9);
                                }

                                else if (jg == 10)
                                {
                                    jiesuan.Add(c10);
                                }

                                else if (jg == 11)
                                {
                                    jiesuan.Add(c11);
                                }

                                else if (jg == 12)
                                {
                                    jiesuan.Add(c12);
                                }

                                else if (jg == 13)
                                {
                                    jiesuan.Add(c13);
                                }

                                else if (jg == 14)
                                {
                                    Console.Clear();
                                    Console.WriteLine("您购买的清单如下：");
                                    foreach (Program item in jiesuan)
                                    {
                                        item.speak();
                                    }
                                    double sumMoney = 0;
                                    for (int s = 0; s < jiesuan.Count; s++)
                                    {
                                        sumMoney += jiesuan[s].jiage;
                                    }



                                    Console.WriteLine("您总共需支付RMB:￥{0}", sumMoney);
                                    Console.WriteLine("                     ----------------温馨提示------------------");
                                    Console.WriteLine("                                  1.返回主页面                          ");

                                    Console.WriteLine("                                   2.退出程序                       ");
                                    Console.WriteLine("                     -----------------------------------------");
                                    int n2;
                                    n2 = Convert.ToInt16(Console.ReadLine());
                                    if (n2 == 1)
                                    {
                                        Console.Clear();
                                        goto zhuyao;
                                    }
                                    else if (n2 == 2)
                                    {
                                        break;

                                    }
                               
                                }
                                

                            }







                        }
                        
                               


                        
                    }
                    else
                    {
                        Console.WriteLine("输入错误，请重新输入");
                        num = num + 1;
                        i = i - 1;
                    }
                }
                else
                {
                    Console.Write("您已经尝试三次登录，验证失败，系统将关闭");
                    break;
                }
            }
        }
        public static void Sale()
        {
            int num = 0;
            int i = 3;
            while (true)
            {
                Console.WriteLine("请输入用户名");
                string a = Console.ReadLine();
                Console.WriteLine("请输入密码");
                string b = Console.ReadLine();
                if (num < 2)
                {
                    if (a == "pzw" && b == "1234")
                    {
                        Console.WriteLine("输入正确");
                        Console.Clear();
                    ciyao:
                        Console.WriteLine("-----------------请选择------------------");

                        Console.WriteLine("              1：增加商品        ");
                        Console.WriteLine("              2：删除并修改商品        ");
                        Console.WriteLine("-----------------------------------------");
                        string y = Console.ReadLine().ToString();

                        if (y == "1")
                        {
                            Console.Clear();

                            Console.Write("请输入所需添加的商品：");
                            string shangpin = Console.ReadLine();
                            Console.Write("请输入所需添加的型号：");
                            string xinghao = Console.ReadLine();
                            Console.Write("请输入所需添加的价格：");
                            int jiage = int.Parse(Console.ReadLine());

                            new Program() { Shangpin = shangpin, Xinghao = xinghao, Jiage = jiage };


                            Console.WriteLine("-----------------请选择所添加到的地方------------------");

                            Console.WriteLine("              1：男装        ");
                            Console.WriteLine("              2：女装        ");
                            Console.WriteLine("              3：童装       ");
                            Console.WriteLine("-----------------------------------------");
                            string z = Console.ReadLine().ToString();
                            if (z == "1")
                            {
                                Console.WriteLine("                                   精品男装");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   商品类型\t商品型号\t商品价格");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   短裤\t        L XL XXL \t 200  ");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   风衣\t        L XL XXL \t 450");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   长裤\t        L XL XXL \t 210");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   衬衣\t        L XL XXL \t 140");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   西装外套\tL XL XXL \t 450");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   {0}           {1}             {2}", shangpin, xinghao, jiage);


                            }
                            if (z == "2")
                            {
                                Console.WriteLine("                                    时尚女装");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   商品类型\t商品型号\t商品价格");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   裙子\t         L XL XXL \t 300");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   短裤\t         L XL XXL \t 150");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   长裤\t         L XL XXL \t 200");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   外套\t         L XL XXL \t 450");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   {0}           {1}              {2}", shangpin, xinghao, jiage);


                            }
                            if (z == "3")
                            {
                                Console.WriteLine("                                    可爱童装");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   商品类型\t商品型号\t商品价格");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   卡通短袖\tL XL XXL \t 130");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   吊带裤\tL XL XXL \t 130");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   小外套\tL XL XXL \t 130");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   T-shirt\tL XL XXL \t 130");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   {0}           {1}               {2}", shangpin, xinghao, jiage);


                            }

                            Console.WriteLine("                     ----------------温馨提示------------------");
                            Console.WriteLine("                                  1.返回主页面                          ");

                            Console.WriteLine("                                   2.退出程序                       ");
                            Console.WriteLine("                     -----------------------------------------");
                            int n3;
                            n3 = Convert.ToInt16(Console.ReadLine());
                            if (n3 == 1)
                            {
                                Console.Clear();
                                goto ciyao;
                            }
                            else if (n3 == 2)
                            {
                                break;

                            }


                        }

                        else if (y == "2")
                        {
                            Console.Clear();
                            Console.WriteLine("---------请选择想要修改的服装类型-----------");
                            Console.WriteLine("    1男装");
                            Console.WriteLine("    2女装");
                            Console.WriteLine("    3童装");
                            Console.WriteLine("-----------------------------------------");
                            string x = Console.ReadLine().ToString();
                            if (x == "1")
                            {
                                jc[] m = new jc[2];
                                Console.WriteLine("                                   精品男装");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   商品类型\t商品型号\t商品价格");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   短裤\t        L XL XXL \t 200  ");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   风衣\t        L XL XXL \t 450");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   长裤\t        L XL XXL \t 210");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   衬衣\t        L XL XXL \t 140");
                                Console.WriteLine("             ---------------------------------------------------");
                                Console.WriteLine("                   西装外套\tL XL XXL \t 450");
                                Console.WriteLine("             ---------------------------------------------------");
                                for (int z = 0; z < m.Length; z++)
                                {

                                    Console.WriteLine("                       请修改第{0}个商品信息的信息", z + 1);
                                    Console.Write("                           商品类型：");
                                    m[z].shangpin = Console.ReadLine();
                                    Console.Write("                           商品型号：");
                                    m[z].xinghao = Console.ReadLine();
                                    Console.Write("                           商品价格：");
                                    m[z].jiage = Convert.ToInt32(Console.ReadLine());

                                    Console.Clear();
                                    Console.WriteLine("                      -------------已改的男装信息-----------");
                                    Console.WriteLine("         商品类型       \t商品型号         \t商品价格         ");
                                    foreach (jc pr in m)//循环用于列举出集合中所有的元素
                                    {
                                        Console.WriteLine
                                            ("         {0}         {1}                           {2}         ", pr.shangpin, pr.xinghao, pr.jiage);




                                    }





                                }
                            }
                            if (x == "2")
                            {
                                jc[] e = new jc[2];
                                for (int j = 0; j < e.Length; j++)
                                {
                                    Console.WriteLine("                                    时尚女装");
                                    Console.WriteLine("             ---------------------------------------------------");
                                    Console.WriteLine("                   商品类型\t商品型号\t商品价格");
                                    Console.WriteLine("             ---------------------------------------------------");
                                    Console.WriteLine("                   裙子\t         L XL XXL \t 300");
                                    Console.WriteLine("             ---------------------------------------------------");
                                    Console.WriteLine("                   短裤\t         L XL XXL \t 150");
                                    Console.WriteLine("             ---------------------------------------------------");
                                    Console.WriteLine("                   长裤\t         L XL XXL \t 200");
                                    Console.WriteLine("             ---------------------------------------------------");
                                    Console.WriteLine("                   外套\t         L XL XXL \t 450");
                                    Console.WriteLine("             ---------------------------------------------------");

                                    Console.WriteLine("                       请修改第{0}个商品信息的信息", j + 1);
                                    Console.Write("                           商品类型：");
                                    e[j].shangpin = Console.ReadLine();
                                    Console.Write("                           商品型号：");
                                    e[j].xinghao = Console.ReadLine();
                                    Console.Write("                           商品价格：");
                                    e[j].jiage = Convert.ToInt32(Console.ReadLine());

                                }
                                Console.Clear();
                                Console.WriteLine("                      -------------已改的女装信息-----------");
                                Console.WriteLine("         商品类型       \t商品型号         \t商品价格         ");
                                foreach (jc pr in e)
                                {
                                    Console.WriteLine
                                        ("         {0}         {1}                       {2}         ", pr.shangpin, pr.xinghao, pr.jiage);




                                }
                            }
                            if (x == "3")
                            {
                                jc[] r = new jc[2];
                                for (int n = 0; n < r.Length; n++)
                                {
                                    Console.WriteLine("                                    可爱童装");
                                    Console.WriteLine("             ---------------------------------------------------");
                                    Console.WriteLine("                   商品类型\t商品型号\t商品价格");
                                    Console.WriteLine("             ---------------------------------------------------");
                                    Console.WriteLine("                   卡通短袖\tL XL XXL \t 130");
                                    Console.WriteLine("             ---------------------------------------------------");
                                    Console.WriteLine("                   吊带裤\tL XL XXL \t 130");
                                    Console.WriteLine("             ---------------------------------------------------");
                                    Console.WriteLine("                   小外套\tL XL XXL \t 130");
                                    Console.WriteLine("             ---------------------------------------------------");
                                    Console.WriteLine("                   T-shirt\tL XL XXL \t 130");
                                    Console.WriteLine("             ---------------------------------------------------");

                                    Console.WriteLine("                       请修改第{0}个商品信息的信息", n + 1);
                                    Console.Write("                           商品类型：");
                                    r[n].shangpin = Console.ReadLine();
                                    Console.Write("                           商品型号：");
                                    r[n].xinghao = Console.ReadLine();
                                    Console.Write("                           商品价格：");
                                    r[n].jiage = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.Clear();
                                Console.WriteLine("                      -------------已改的童装信息-----------");
                                Console.WriteLine("         商品类型       \t商品型号         \t商品价格         ");
                                foreach (jc pr in r)
                                {
                                    Console.WriteLine
                                        ("         {0}         {1}                        {2}         ", pr.shangpin, pr.xinghao, pr.jiage);




                                }

                            }
                            Console.WriteLine("                     ----------------温馨提示------------------");
                            Console.WriteLine("                                  1.返回主页面                          ");

                            Console.WriteLine("                                   2.退出程序                       ");
                            Console.WriteLine("                     -----------------------------------------");
                            int n4;
                            n4 = Convert.ToInt16(Console.ReadLine());
                            if (n4 == 1)
                            {
                                Console.Clear();
                                goto ciyao;

                            }
                            else if (n4 == 2)
                            {
                                break;

                            }
                        }



                        break;
                    }
                    else
                    {

                        Console.WriteLine("输入错误，请重新输入");
                        num = num + 1;
                        i = i - 1;
                    }
                }
                else
                {
                    Console.Write("您已经尝试三次登录，验证失败，系统将关闭");
                    break;
                }
            }
        }

        public class Clothes1 : Program
        {
            public virtual void buyclothes1()
            {
                this.no = 1;
                this.shangpin = "短裤";
                this.xinghao = "L XL XXL";
                this.jiage = 200;
                Console.WriteLine("1\t短裤\tL XL XXL\t  200");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes2 : Program
        {
            public virtual void buyclothes2()
            {
                this.no = 2;
                this.shangpin = "风衣";
                this.xinghao = "L XL XXL";
                this.jiage = 450;
                Console.WriteLine("2\t风衣\tL XL XXL\t  450");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes3 : Program
        {
            public virtual void buyclothes3()
            {
                this.no = 3;
                this.shangpin = "长裤";
                this.xinghao = "L XL XXL";
                this.jiage = 210;
                Console.WriteLine("3\t长裤\tL XL XXL\t  210");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes4 : Program
        {
            public virtual void buyclothes4()
            {
                this.no = 4;
                this.shangpin = "衬衣";
                this.xinghao = "L XL XXL";
                this.jiage = 140;
                Console.WriteLine("4\t衬衣\tL XL XXL\t  140");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes5 : Program
        {
            public virtual void buyclothes5()
            {
                this.no = 5;
                this.shangpin = "西装外套";
                this.xinghao = "L XL XXL";
                this.jiage = 450;
                Console.WriteLine("5\t西装外套\tL XL XXL\t  450");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes6 : Program
        {
            public virtual void buyclothes6()
            {
                this.no = 6;
                this.shangpin = "裙子";
                this.xinghao = "L XL XXL";
                this.jiage = 300;
                Console.WriteLine("6\t裙子\tL XL XXL\t  300");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes7 : Program
        {
            public virtual void buyclothes7()
            {
                this.no = 7;
                this.shangpin = "短裤";
                this.xinghao = "L XL XXL";
                this.jiage = 150;
                Console.WriteLine("7\t短裤\tL XL XXL\t  150");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes8 : Program
        {
            public virtual void buyclothes8()
            {
                this.no = 8;
                this.shangpin = "长裤";
                this.xinghao = "L XL XXL";
                this.jiage = 200;
                Console.WriteLine("8\t长裤\tL XL XXL\t  200");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes9 : Program
        {
            public virtual void buyclothes9()
            {
                this.no = 9;
                this.shangpin = "外套";
                this.xinghao = "L XL XXL";
                this.jiage = 450;
                Console.WriteLine("9\t外套\tL XL XXL\t  450");
            }
            public override void speak()
            {
                base.speak();
            }



        }
        public class Clothes10 : Program
        {
            public virtual void buyclothes10()
            {
                this.no = 10;
                this.shangpin = "卡通短袖";
                this.xinghao = "L XL XXL";
                this.jiage = 130;
                Console.WriteLine("10\t卡通短袖\tL XL XXL\t  130");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes11 : Program
        {
            public virtual void buyclothes11()
            {
                this.no = 11;
                this.shangpin = "吊带裤";
                this.xinghao = "L XL XXL";
                this.jiage = 130;
                Console.WriteLine("11\t吊带裤\tL XL XXL\t  130");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes12 : Program
        {
            public virtual void buyclothes12()
            {
                this.no = 12;
                this.shangpin = "小外套";
                this.xinghao = "L XL XXL";
                this.jiage = 130;
                Console.WriteLine("12\t小外套\tL XL XXL\t  130");
            }
            public override void speak()
            {
                base.speak();
            }


        }
        public class Clothes13 : Program
        {
            public virtual void buyclothes13()
            {
                this.no = 13;
                this.shangpin = "T-shirt";
                this.xinghao = "L XL XXL";
                this.jiage = 130;
                Console.WriteLine("13\tT-shirt\tL XL XXL\t  130");
            }
            public override void speak()
            {
                base.speak();
            }


        }


        public class xiaozu
        {

            public static void 男装()//静态方法
            {

                Console.WriteLine("                                   精品男装");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("                   商品类型\t商品型号\t商品价格");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             1      短裤\t        L XL XXL \t 200  ");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             2      风衣\t        L XL XXL \t 450");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             3      长裤\t        L XL XXL \t 210");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             4      衬衣\t        L XL XXL \t 140");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             5      西装外套\tL XL XXL \t 450");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             ");
                Console.WriteLine("             ");
                Console.WriteLine("             ");

            }
            public static void 女装()//静态方法
            {
                Console.WriteLine("                                    时尚女装");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("                   商品类型\t商品型号\t商品价格");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             6      裙子\t         L XL XXL \t 300");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             7      短裤\t         L XL XXL \t 150");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             8      长裤\t         L XL XXL \t 200");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             9      外套\t         L XL XXL \t 450");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("                                                      ");
                Console.WriteLine("             ");
                Console.WriteLine("             ");
                Console.WriteLine("             ");

            }

            public static void 童装()//静态方法
            {
                Console.WriteLine("                                    可爱童装");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("                   商品类型\t商品型号\t商品价格");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             10      卡通短袖\tL XL XXL \t 130");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             11      吊带裤\tL XL XXL \t 130");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             12      小外套\tL XL XXL \t 130");
                Console.WriteLine("             ---------------------------------------------------");
                Console.WriteLine("             13      T-shirt\tL XL XXL \t 130");
                Console.WriteLine("             ---------------------------------------------------");
            }
        }
        static void Main(string[] args)
        {
            a();
            Console.ReadKey();

        }
    }
}


