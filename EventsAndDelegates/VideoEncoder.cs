using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Frustration.EventsAndDelegates
{
    public class VideoEncoder
    {
        public Action<object, EventArgs> VideoEncodedEventHandler;

        public event Action<object, EventArgs> VideoEncoded; // publisher

        public void Encode(Video video)
        {
            Console.WriteLine($"Processing Video");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}
