using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseVM.Mediator
{
    public static class EventRaiser
    {
        public static void Raise(this EventHandler hander, object sender)
        {
            hander?.Invoke(sender, EventArgs.Empty);
        }
        public static void Raise<T>(this EventHandler<EventArgs<T>> hander, object sender, T Value)
        {
            hander?.Invoke(sender, new EventArgs<T>(Value));
        }
        public static void Raise<T>(this EventHandler<T> hander, object sender, T value) where T : EventArgs
        {
            hander?.Invoke(sender, value);
        }
        public static void Raise<T>(this EventHandler<EventArgs<T>> hander, object sender, EventArgs<T> value) where T : EventArgs
        {
            hander?.Invoke(sender, value);
        }
    }
}
