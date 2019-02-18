﻿using System;
using NewLife.Log;
using NewLife.MessageQueue;

namespace Test
{
    class Program
    {
        static void Main(String[] args)
        {
            XTrace.UseConsole();

            try
            {
                Test1();
            }
            catch (Exception ex)
            {
                XTrace.WriteException(ex);
            }

            Console.WriteLine("OK!");
            Console.ReadKey();
        }

        static async void Test1()
        {
            var client = new MQClient
            {
                Servers = new[] { "tcp://127.0.0.1:6789" },
                Log = XTrace.Log,

                Topic = "Test",
            };

            var msgid = await client.Public("发布测试");
            XTrace.WriteLine("msgid={0}", msgid);
        }

        static void Test2()
        {
        }

        static void Test3()
        {

        }
    }
}