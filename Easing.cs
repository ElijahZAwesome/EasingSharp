using EasingLIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasingLIB
{
    public static class EasingAction
    {
        public static double easeInSine(float x)
        {
            return 1 - Math.Cos((x * Math.PI) / 2);
        }
        public static double easeOutSine(float x)
        {
            return Math.Sin((x * Math.PI) / 2);
        }
        public static double easeInOutSine(float x)
        {
            return -(Math.Cos(Math.PI * x) - 1) / 2;
        }
        public static double easeInQuad(float x)
        {
            return x * x;
        }
        public static double easeOutQuad(float x)
        {
            return 1 - (1 - x) * (1 - x);
        }
        public static double easeInOutQuad(float x)
        {
            return x < 0.5 ? 2 * x * x : 1 - Math.Pow(-2 * x + 2, 2) / 2;
        }
        public static double easeInCubic(float x)
        {
            return x * x * x;
        }
        public static double easeOutCubic(float x)
        {
            return 1 - Math.Pow(1 - x, 3);
        }
        public static double easeInOutCubic(float x)
        {
            return x < 0.5 ? 4 * x * x * x : 1 - Math.Pow(-2 * x + 2, 3) / 2;
        }
        public static double easeInQuart(float x)
        {
            return x * x * x * x;
        }
        public static double easeOutQuart(float x)
        {
            return 1 - Math.Pow(1 - x, 4);
        }
        public static double easeInOutQuart(float x)
        {
            return x < 0.5 ? 8 * x * x * x * x : 1 - Math.Pow(-2 * x + 2, 4) / 2;
        }
        public static double easeInQuint(float x)
        {
            return x * x * x * x * x;
        }
        public static double easeOutQuint(float x)
        {
            return 1 - Math.Pow(1 - x, 5);
        }
        public static double easeInOutQuint(float x)
        {
            return x < 0.5 ? 16 * x * x * x * x * x : 1 - Math.Pow(-2 * x + 2, 5) / 2;
        }
        public static double easeInExpo(float x)
        {
            return x == 0 ? 0 : Math.Pow(2, 10 * x - 10);
        }
        public static double easeOutExpo(float x)
        {
            return x == 1 ? 1 : 1 - Math.Pow(2, -10 * x);
        }
        public static double easeInOutExpo(float x)
        {
            return x == 0
              ? 0
              : x == 1
              ? 1
              : x < 0.5 ? Math.Pow(2, 20 * x - 10) / 2
              : (2 - Math.Pow(2, -20 * x + 10)) / 2;
        }
        public static double easeInCirc(float x)
        {
            return 1 - Math.Sqrt(1 - Math.Pow(x, 2));
        }
        public static double easeOutCirc(float x)
        {
            return Math.Sqrt(1 - Math.Pow(x - 1, 2));
        }
        public static double easeInOutCirc(float x)
        {
            return x < 0.5
              ? (1 - Math.Sqrt(1 - Math.Pow(2 * x, 2))) / 2
              : (Math.Sqrt(1 - Math.Pow(-2 * x + 2, 2)) + 1) / 2;
        }
        public static double easeInBack(float x)
        {
            var c1 = 1.70158;
            var c3 = c1 + 1;

            return c3 * x * x * x - c1 * x * x;
        }
        public static double easeOutBack(float x)
        {
            var c1 = 1.70158;
            var c3 = c1 + 1;

            return 1 + c3 * Math.Pow(x - 1, 3) + c1 * Math.Pow(x - 1, 2);
        }
        public static double easeInOutBack(float x)
        {
            var c1 = 1.70158;
            var c2 = c1 * 1.525;

            return x < 0.5
              ? (Math.Pow(2 * x, 2) * ((c2 + 1) * 2 * x - c2)) / 2
              : (Math.Pow(2 * x - 2, 2) * ((c2 + 1) * (x * 2 - 2) + c2) + 2) / 2;
        }
        public static double easeInElastic(float x)
        {
            var c4 = (2 * Math.PI) / 3;

            return x == 0
              ? 0
              : x == 1
              ? 1
              : -Math.Pow(2, 10 * x - 10) * Math.Sin((x * 10 - 10.75) * c4);
        }
        public static double easeOutElastic(float x)
        {
            var c4 = (2 * Math.PI) / 3;

            return x == 0
              ? 0
              : x == 1
              ? 1
              : Math.Pow(2, -10 * x) * Math.Sin((x * 10 - 0.75) * c4) + 1;
        }
        public static double easeInOutElastic(float x)
        {
            var c5 = (2 * Math.PI) / 4.5;

            return x == 0
              ? 0
              : x == 1
              ? 1
              : x < 0.5
              ? -(Math.Pow(2, 20 * x - 10) * Math.Sin((20 * x - 11.125) * c5)) / 2
              : (Math.Pow(2, -20 * x + 10) * Math.Sin((20 * x - 11.125) * c5)) / 2 + 1;
        }
        public static double easeInBounce(float x)
        {
            return 1 - easeOutBounce(1 - x);
        }
        public static double easeOutBounce(float x)
        {
            var n1 = 7.5625;
            var d1 = 2.75;

            if (x < 1 / d1)
            {
                return n1 * x * x;
            }
            else if (x < 2 / d1)
            {
                return n1 * (x -= ((float)1.5) / (float)d1) * x + 0.75;
            }
            else if (x < 2.5 / d1)
            {
                return n1 * (x -= (float)2.25 / (float)d1) * x + 0.9375;
            }
            else
            {
                return n1 * (x -= (float)2.625 / (float)d1) * x + 0.984375;
            }
        }
        public static double easeInOutBounce(float x)
        {
            return x < 0.5
              ? (1 - easeOutBounce(1 - 2 * x)) / 2
              : (1 + easeOutBounce(2 * x - 1)) / 2;
        }
        public static double Liner(float x)
        {
            return x;
        }
    }
}

public static class Easing
{
    public enum Easings
    {
        Liner,
        easeInSine,//
        easeOutSine,//
        easeInOutSine,//
        easeInQuad,//
        easeOutQuad,//
        easeInOutQuad,//
        easeInCubic,//
        easeOutCubic,
        easeInOutCubic,
        easeInQuart,
        easeOutQuart,
        easeInOutQuart,
        easeInQuint,
        easeOutQuint,
        easeInOutQuint,
        easeInExpo,
        easeOutExpo,
        easeInOutExpo,
        easeInCirc,
        easeOutCirc,
        easeInOutCirc,
        easeInBack,
        easeOutBack,
        easeInOutBack,
        easeInElastic,
        easeOutElastic,
        easeInOutElastic,
        easeInBounce,
        easeOutBounce,
        easeInOutBounce
    }
    public static void easeInSine(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInSine, start, end, time);
    }
    public static void easeOutSine(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeOutSine, start, end, time);
    }
    public static void easeInOutSine(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInOutSine, start, end, time);
    }
    public static void easeInQuad(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInQuad, start, end, time);
    }
    public static void easeOutQuad(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeOutQuad, start, end, time);
    }
    public static void easeInOutQuad(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInOutQuad, start, end, time);
    }
    public static void easeInCubic(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInCubic, start, end, time);
    }
    public static void easeOutCubic(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeOutCubic, start, end, time);
    }
    public static void easeInOutCubic(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInOutCubic, start, end, time);
    }
    public static void easeInQuart(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInQuart, start, end, time);
    }
    public static void easeOutQuart(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeOutQuart, start, end, time);
    }
    public static void easeInOutQuart(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInOutQuart, start, end, time);
    }
    public static void easeInQuint(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInQuint, start, end, time);
    }
    public static void easeOutQuint(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeOutQuint, start, end, time);
    }
    public static void easeInOutQuint(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInOutQuint, start, end, time);
    }
    public static void easeInExpo(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInExpo, start, end, time);
    }
    public static void easeOutExpo(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeOutExpo, start, end, time);
    }
    public static void easeInOutExpo(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInOutExpo, start, end, time);
    }
    public static void easeInCirc(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInCirc, start, end, time);
    }
    public static void easeOutCirc(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeOutCirc, start, end, time);
    }
    public static void easeInOutCirc(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInOutCirc, start, end, time);
    }
    public static void easeInBack(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInBack, start, end, time);
    }
    public static void easeOutBack(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeOutBack, start, end, time);
    }
    public static void easeInOutBack(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInOutBack, start, end, time);
    }
    public static void easeInElastic(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInElastic, start, end, time);
    }
    public static void easeOutElastic(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeOutElastic, start, end, time);
    }
    public static void easeInOutElastic(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInOutElastic, start, end, time);
    }
    public static void easeInBounce(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInBounce, start, end, time);
    }
    public static void easeOutBounce(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeOutBounce, start, end, time);
    }
    public static void easeInOutBounce(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.easeInOutBounce, start, end, time);
    }
    public static void Liner(Action<double> callback, double start, double end, int time)
    {
        Run(callback, Easings.Liner, start, end, time);
    }
    static bool TryParse<TEnum>(string s, out TEnum wd) where TEnum : struct
    {
        return Enum.TryParse(s, out wd) && Enum.IsDefined(typeof(TEnum), wd);
    }
    public class EasingNotFoundException : Exception
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public EasingNotFoundException()
            : base("イージングが存在しません。")
        {
        
        }
        /// <summary>
        /// メッセージ文字列を渡すコンストラクタ
        /// </summary>
        /// <param name="message">メッセージ文字列</param>
        public EasingNotFoundException(string message)
            : base(message)
        {
           
        }
        /// <summary>
        /// メッセージ文字列と発生済み例外オブジェクトを渡すコンストラクタ
        /// </summary>
        /// <param name="message">メッセージ文字列</param>
        /// <param name="innerException">発生済み例外オブジェクト</param>
        public EasingNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
          
        }
    }
    public static void Run(Action<double> callback,string easing, double start, double end, int time)
    {
        Easings eas;
        if(TryParse(easing, out eas))
        {
            Run(callback, eas, start, end, time);
        }
        else
        {
            throw new EasingNotFoundException("イージング '"+easing+"'が見つかりません。");
        }
    }
    public static void Run(Action<double> callback, Easings easing, double start, double end, int time)
    {
        Control threadcontrol = new Control();
        var hand = threadcontrol.Handle;
        var task = Task.Run(() =>
        {

            double nextframe = (double)System.Environment.TickCount;
            double wait = 1000 / 60;
            int starttick = System.Environment.TickCount;
            while (System.Environment.TickCount - starttick <= time)
            {
                if ((double)System.Environment.TickCount >= nextframe)
                {

                    float x = ((float)System.Environment.TickCount - starttick) / time;
                    if (x > 1)
                    {
                        x = 1;
                    }
                    double eas = 0;
                    if (easing == Easings.Liner)
                    {
                        eas = EasingAction.Liner(x);
                    }
                    else if (easing == Easings.easeInSine)
                    {
                        eas = EasingAction.easeInSine(x);
                    }
                    else if (easing == Easings.easeOutSine)
                    {
                        eas = EasingAction.easeOutSine(x);
                    }
                    else if (easing == Easings.easeInOutSine)
                    {
                        eas = EasingAction.easeInOutSine(x);
                    }
                    else if (easing == Easings.easeInQuad)
                    {
                        eas = EasingAction.easeInQuad(x);
                    }
                    else if (easing == Easings.easeOutQuad)
                    {
                        eas = EasingAction.easeOutQuad(x);
                    }
                    else if (easing == Easings.easeInOutQuad)
                    {
                        eas = EasingAction.easeInOutQuad(x);
                    }
                    else if (easing == Easings.easeInCubic)
                    {
                        eas = EasingAction.easeInCubic(x);
                    }
                    else if (easing == Easings.easeOutCubic)
                    {
                        eas = EasingAction.easeOutCubic(x);
                    }
                    else if (easing == Easings.easeInOutCubic)
                    {
                        eas = EasingAction.easeInOutCubic(x);
                    }
                    else if (easing == Easings.easeInQuart)
                    {
                        eas = EasingAction.easeInQuart(x);
                    }
                    else if (easing == Easings.easeOutQuart)
                    {
                        eas = EasingAction.easeOutQuart(x);
                    }
                    else if (easing == Easings.easeInOutQuart)
                    {
                        eas = EasingAction.easeInOutQuart(x);
                    }
                    else if (easing == Easings.easeInQuint)
                    {
                        eas = EasingAction.easeInQuint(x);
                    }
                    else if (easing == Easings.easeOutQuint)
                    {
                        eas = EasingAction.easeOutQuint(x);
                    }
                    else if (easing == Easings.easeInOutQuint)
                    {
                        eas = EasingAction.easeInOutQuint(x);
                    }
                    else if (easing == Easings.easeInExpo)
                    {
                        eas = EasingAction.easeInExpo(x);
                    }
                    else if (easing == Easings.easeOutExpo)
                    {
                        eas = EasingAction.easeOutExpo(x);
                    }
                    else if (easing == Easings.easeInOutExpo)
                    {
                        eas = EasingAction.easeInOutExpo(x);
                    }
                    else if (easing == Easings.easeInCirc)
                    {
                        eas = EasingAction.easeInCirc(x);
                    }
                    else if (easing == Easings.easeOutCirc)
                    {
                        eas = EasingAction.easeOutCirc(x);
                    }
                    else if (easing == Easings.easeInOutCirc)
                    {
                        eas = EasingAction.easeInOutCirc(x);
                    }
                    else if (easing == Easings.easeInBack)
                    {
                        eas = EasingAction.easeInBack(x);
                    }
                    else if (easing == Easings.easeOutBack)
                    {
                        eas = EasingAction.easeOutBack(x);
                    }
                    else if (easing == Easings.easeInOutBack)
                    {
                        eas = EasingAction.easeInOutBack(x);
                    }
                    else if (easing == Easings.easeInElastic)
                    {
                        eas = EasingAction.easeInElastic(x);
                    }
                    else if (easing == Easings.easeOutElastic)
                    {
                        eas = EasingAction.easeOutElastic(x);
                    }
                    else if (easing == Easings.easeInOutElastic)
                    {
                        eas = EasingAction.easeInOutElastic(x);
                    }
                    else if (easing == Easings.easeInBounce)
                    {
                        eas = EasingAction.easeInBounce(x);
                    }
                    else if (easing == Easings.easeOutBounce)
                    {
                        eas = EasingAction.easeOutBounce(x);
                    }
                    else if (easing == Easings.easeInOutBounce)
                    {
                        eas = EasingAction.easeInOutBounce(x);
                    }

                    threadcontrol.Invoke((Action)(() => { callback(start + (eas * (end - start))); }));
                    nextframe += wait;




                }


            }
        });



    }
}

