using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace EasingSharp
{
    public static class Easing
    {
        public static void Ease(Action<double> callback, EasingTypes easing, double start, double end, int time)
        {
            Task.Run(() =>
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var nextFrame = (double) stopwatch.ElapsedMilliseconds;
                var wait = 1000 / 60;
                var startTick = (int) stopwatch.ElapsedMilliseconds;
                while (stopwatch.ElapsedMilliseconds - startTick <= time)
                    if (stopwatch.ElapsedMilliseconds >= nextFrame)
                    {
                        var x = ((float) stopwatch.ElapsedMilliseconds - startTick) / time;
                        if (x > 1) x = 1;
                        var eas = easing switch
                        {
                            EasingTypes.Linear => EasingActions.Linear(x),
                            EasingTypes.EaseInSine => EasingActions.EaseInSine(x),
                            EasingTypes.EaseOutSine => EasingActions.EaseOutSine(x),
                            EasingTypes.EaseInOutSine => EasingActions.EaseInOutSine(x),
                            EasingTypes.EaseInQuad => EasingActions.EaseInQuad(x),
                            EasingTypes.EaseOutQuad => EasingActions.EaseOutQuad(x),
                            EasingTypes.EaseInOutQuad => EasingActions.EaseInOutQuad(x),
                            EasingTypes.EaseInCubic => EasingActions.EaseInCubic(x),
                            EasingTypes.EaseOutCubic => EasingActions.EaseOutCubic(x),
                            EasingTypes.EaseInOutCubic => EasingActions.EaseInOutCubic(x),
                            EasingTypes.EaseInQuart => EasingActions.EaseInQuart(x),
                            EasingTypes.EaseOutQuart => EasingActions.EaseOutQuart(x),
                            EasingTypes.EaseInOutQuart => EasingActions.EaseInOutQuart(x),
                            EasingTypes.EaseInQuint => EasingActions.EaseInQuint(x),
                            EasingTypes.EaseOutQuint => EasingActions.EaseOutQuint(x),
                            EasingTypes.EaseInOutQuint => EasingActions.EaseInOutQuint(x),
                            EasingTypes.EaseInExpo => EasingActions.EaseInExpo(x),
                            EasingTypes.EaseOutExpo => EasingActions.EaseOutExpo(x),
                            EasingTypes.EaseInOutExpo => EasingActions.EaseInOutExpo(x),
                            EasingTypes.EaseInCirc => EasingActions.EaseInCirc(x),
                            EasingTypes.EaseOutCirc => EasingActions.EaseOutCirc(x),
                            EasingTypes.EaseInOutCirc => EasingActions.EaseInOutCirc(x),
                            EasingTypes.EaseInBack => EasingActions.EaseInBack(x),
                            EasingTypes.EaseOutBack => EasingActions.EaseOutBack(x),
                            EasingTypes.EaseInOutBack => EasingActions.EaseInOutBack(x),
                            EasingTypes.EaseInElastic => EasingActions.EaseInElastic(x),
                            EasingTypes.EaseOutElastic => EasingActions.EaseOutElastic(x),
                            EasingTypes.EaseInOutElastic => EasingActions.EaseInOutElastic(x),
                            EasingTypes.EaseInBounce => EasingActions.EaseInBounce(x),
                            EasingTypes.EaseOutBounce => EasingActions.EaseOutBounce(x),
                            EasingTypes.EaseInOutBounce => EasingActions.EaseInOutBounce(x),
                            _ => 0
                        };

                        callback(start + eas * (end - start));
                        nextFrame += wait;
                    }

                callback(end);
            });
        }
    }
}