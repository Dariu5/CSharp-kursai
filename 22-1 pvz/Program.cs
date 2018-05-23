using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_1_pvz
{
    class Program
    {
        static void Main(string[] args)
        {

            VideoEncoder videoencoderis = new VideoEncoder();
            MessageService messageService = new MessageService();

            videoencoderis.VideoEncoded += messageService.OnVideoEncoded;

            videoencoderis.Encode();


        }
    }

    class MessageService
    {

        public void OnVideoEncoded(object sender, EventArgs eventArgs)

        {

            Console.WriteLine("Message Sevice: Siunciame sms...");


        }




    }
}
