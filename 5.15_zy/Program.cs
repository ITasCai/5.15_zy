using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._15_zy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.	用 if…else 判断是否为闰年。提示: 能被4整除但不能被100整除 或者能被400整除

            //Console.WriteLine("请输入一个年份：");
            //int nian = Convert.ToInt32(Console.ReadLine());
            //if ((nian%4==0&&nian%100!=0)||(nian%400==0))
            //{
            //    Console.WriteLine("{0}是闰年",nian);
            //}
            //else
            //{
            //    Console.WriteLine("{0}不是闰年",nian);
            //}

            //Console.ReadLine();

            #endregion

            #region 2.	由键盘输入三个整数分别存入变量num1、num2、num3分别使用if else 和三元运算符来输出最大值。

            //Console.WriteLine("请输入第一个数：");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数：");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数：");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int max =num3>((num1 > num2) ? num1 : num2)?num3: (num1 > num2) ? num1 : num2;
            //Console.WriteLine("最大值为：{0}",max);
            //Console.ReadLine();


            //Console.WriteLine("请输入第一个数：");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数：");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数：");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int max;
            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //    {
            //        max = num1;
            //    }
            //    else
            //    {
            //        max = num3;
            //    }
            //}
            //else
            //{
            //    if (num2 > num3)
            //    {
            //        max = num2;
            //    }
            //    else
            //    {
            //        max = num3;
            //    }
            //}
            //Console.WriteLine("最大数为：{0}",max);

            //Console.ReadLine();

            #endregion

            #region 3.	由键盘输入三个整数，a,b,c，按大小顺序输出。

            //Console.WriteLine("请输入第一个数：");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数：");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数：");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int temp;

            //if (num1<num2)
            //{
            //    temp = num1;
            //    num1 = num2;
            //    num3 = temp;
            //}
            //else if (num1<num3)
            //{
            //    temp = num1;
            //    num1 = num2;
            //    num3 = temp;
            //}
            //else if (num2 < num3)
            //{
            //    temp = num1;
            //    num1 = num2;
            //    num3 = temp;
            //}

            //Console.WriteLine("三个数的大小排序为：{0},{1},{2}",num1,num2,num3);
            //Console.ReadLine();

            #endregion

            #region 4.	编一个程序，输入0—100之间的一个学生成绩分数,用switch语句输出成绩（成绩优秀（90-100），成绩良好（80-89），成绩及格（60-79）和成绩不及格（59以下））

            //Console.WriteLine("请输入一个成绩：");
            //int cj = Convert.ToInt32(Console.ReadLine());
            //int score = cj / 10;

            //switch (score)
            //{
            //    case 10:

            //    case 9:
            //        Console.WriteLine("成绩优秀！");
            //        break;
            //    case 8:
            //        Console.WriteLine("成绩良好！");
            //        break;
            //    case 7:

            //    case 6:
            //        Console.WriteLine("成绩及格！");
            //        break;
            //    case 5:

            //    case 4:

            //    case 3:

            //    case 2:

            //    case 1:

            //    case 0:
            //        Console.WriteLine("成绩不合格！");
            //        break;
            //    default:
            //        Console.WriteLine("你输入的成绩有误！");
            //        break;
            //}
            //Console.ReadLine();

            #endregion

            #region 5.	使用while/do-while/for循环三种方式打印100以内3的倍数

            //int i = 1;
            //while (i <= 100)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine("{0}", i);

            //    }
            //    i++;
            //}

            //for (int i = 1; i <=100; i++)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine("{0}", i);
            //    }
            //}

            //int j = 1;
            //do
            //{
            //    if (j % 3 == 0)
            //    {
            //       Console.WriteLine("{0}", j);

            //    }

            //    j++;
            //} while (j<=100);

            //Console.ReadLine();

            #endregion


            #region 6.	编一个程序，利用do-while循环语句,从键盘上输入5个整数，求出它们的和。

            //int i = 1;
            //int sum = 0;
            //do
            //{
            //    Console.WriteLine("请输入第{0}个整数：",i);
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum += num;
            //    i++;
            //} while (i<=5);
            //Console.WriteLine("五个整数的和为：{0}",sum);

            //Console.ReadLine();

            #endregion

            #region 7.	编写一个程序，用while语句，求出1+(1+2)+(1+2+3)+...+(1+2+3+...+10)之和。


            //int sum = 0;
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        sum += j;
            //    }
            //}
            //Console.WriteLine("相加的和为{0}", sum);




            //Console.ReadLine();

            #endregion

            #region 8.	编一个程序，要求使用while语句，输入用户名和密码，实现用户登录程序的功能，至多允许输入三次，超过三次不允许登录。

            //const string userName = "admin";
            //const string passWord = "123456";

            //int i = 1;
            //while (i <= 3)
            //{
            //    Console.WriteLine("请输入用户名：");
            //    string usernam = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    string password = Console.ReadLine();

            //    if (userName.Equals(usernam) && passWord.Equals(password))
            //    {
            //        Console.WriteLine("登录成功");
            //        break;
            //    }
            //    else
            //    {

            //        Console.WriteLine("用户名或密码不正确，请重新输入！");
            //        i++;
            //    } 
            //}
            //if (i >= 3)
            //{
            //    Console.WriteLine("用户名或密码输入错误超过三次，不允许登录！");

            //}


            //Console.ReadLine();

            #endregion

            #region 9.	使用for循环100内的偶数和、奇数和分别是多少？

            //int osum = 0;
            //int qsum = 0;
            //for (int i = 1; i <=100; i++)
            //{
            //    if (i%2==0)
            //    {
            //        osum += i;
            //    }
            //    else if (i%2!=0)
            //    {
            //        qsum += i;
            //    }
            //}
            //Console.WriteLine("偶数和为：{0}，奇数和为:{1}",osum,qsum);
            //Console.ReadLine();

            #endregion

            #region 10.	打印出所有的 "水仙花数 "，所谓 "水仙花数 "是指一个三位数(101-1000)，其各位数字立方和等于该数本身。  例如：153是一个 "水仙花数 "，因为153 = 1的三次方＋5的三次方＋3的三次方。



            //int b1, b2, b3;
            //for (int m = 101; m < 1000; m++)
            //{
            //    b3 = m / 100;
            //    b2 = m % 100 / 10;
            //    b1 = m % 10;
            //    if ((b3 * b3 * b3 + b2 * b2 * b2 + b1 * b1 * b1) == m)
            //    {
            //        Console.WriteLine(m+" ");
            //    }
            //}

            // Console.ReadLine();

            #endregion

            #region 11.	使用for循环计算：一球从100米高度自由落下，每次落地后反跳回原高度的一半；再落下，求它在第10次落地时，共经过多少米？第10次反弹多高？


            //double h = 100, s = 100;
            //for (int i = 1; i < 10; i++)
            //{
            //    s = s + h;
            //    h = h / 2;
            //}
            //Console.WriteLine("经过路程：" + s);
            //Console.WriteLine("反弹高度：" + h / 2);

            //Console.ReadLine();

            #endregion

            #region 12.	有一只猴子摘了一堆桃子，每天吃掉一半桃子还不过瘾再多吃一个，吃到第十天的时候发现还剩下一个桃子，问猴子第一天一共摘了多少个桃子？第5天的时候还剩多少个桃子？

            //int x = 1;

            //for (int i = 2; i <= 10; i++)
            //{
            //    x = (x + 1) * 2;

            //}

            //int y = 1;
            //for (int j = 2; j <= 10; j++)
            //{
            //    y = (y + 1) * 2;

            //    if (j == 5)
            //    {
            //        break;
            //    }

            //}


            //Console.WriteLine("猴子第一天摘了{0} 个桃子,第5天的时候还剩{1}个桃子",x,y);;

            //Console.ReadLine();
            #endregion


            #region 13.	使用循环打印以下圣诞树。

            Console.WriteLine("请输入三角形的长度：");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }
                for (int m = 1; m <= i; m++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


            #endregion
        }
    }
}
