﻿using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
namespace espjs
{
    class Program
    {

        static void Main(string[] args)
        {

            bool runOnce = args.Length >= 1;
            App app = new App(runOnce);
            app.Run(args);
        }

    }

}
