using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_1_pvz
{
    class VideoEncoder
    {
        //1 Apsirašyti delegatą
        //2-susikurti įvykį pagal delegatą
        //3 Sugeneruoti įvykį


        public delegate void VideoEncodedEventHandler(object sender, EventArgs eventArgs); /*Kontraktas*/
        public event VideoEncodedEventHandler VideoEncoded;


        public void Encode()

        {

            Console.WriteLine("Koduojam video");
            System.Threading.Thread.Sleep(3000);
            OnVideoEncoded();

        }

        protected virtual void OnVideoEncoded()
        {

            if (VideoEncoded != null)
            {

                VideoEncoded(this, EventArgs.Empty);

            }

        }


    }
}
