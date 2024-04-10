﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment1
{
    public class Program
    {
        //this runs the entire program
        private static void Main()
        {
            Game game = new Game(); // this created the a new game for running 
            Testing gametest = new Testing();


            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░██████╗░██╗░█████╗░███████╗░░░░██████╗░░█████╗░███╗░░░███╗███████╗░██████╗░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░██╔══██╗██║██╔══██╗██╔════╝░░░██╔════╝░██╔══██╗████╗░████║██╔════╝██╔════╝░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░██║░░██║██║██║░░╚═╝█████╗░░░░░██║░░██╗░███████║██╔████╔██║█████╗░░╚█████╗░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░██║░░██║██║██║░░██╗██╔══╝░░░░░██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░░╚═══██╗░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░██████╔╝██║╚█████╔╝███████╗░░░╚██████╔╝██║░░██║██║░╚═╝░██║███████╗██████╔╝░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░╚═════╝░╚═╝░╚════╝░╚══════╝░░░░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═════╝░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░███╗░░██╗░██████╗███████╗██╗░░░██╗███████╗███╗░░██╗░██████╗░░░░█████╗░██╗░░░██╗████████╗░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░████║░░╚═╝██╔════╝██╔════╝██║░░░██║██╔════╝████╗░██║██╔════╝░░░██╔══██╗██║░░░██║╚══██╔══╝░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░██╔██║░░░░░╚█████╗░█████╗░░╚██╗░██╔╝█████╗░░██╔██╗██║╚█████╗░░░░██║░░██║██║░░░██║░░░██║░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░╚═╝██║░░░░░░╚═══██╗██╔══╝░░░╚████╔╝░██╔══╝░░██║╚████║░╚═══██╗░░░██║░░██║██║░░░██║░░░██║░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░███████╗██╗██████╔╝███████╗░░╚██╔╝░░███████╗██║░╚███║██████╔╝░░░╚█████╔╝╚██████╔╝░░░██║░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░╚══════╝╚═╝╚═════╝░╚══════╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝╚═════╝░░░░░╚════╝░░╚═════╝░░░░╚═╝░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("██████╗░██╗████████╗██╗░░██╗██████╗░███████╗███████╗░░░░█████╗░██████╗░░░░███╗░░░███╗░█████╗░██████╗░███████╗");
            Console.WriteLine("╚════██╗╚═╝╚══██╔══╝██║░░██║██╔══██╗██╔════╝██╔════╝░░░██╔══██╗██╔══██╗░░░████╗░████║██╔══██╗██╔══██╗██╔════╝");
            Console.WriteLine("░░███╔═╝░░░░░░██║░░░███████║██████╔╝█████╗░░█████╗░░░░░██║░░██║██████╔╝░░░██╔████╔██║██║░░██║██████╔╝█████╗░░");
            Console.WriteLine("██╔══╝░░░░░░░░██║░░░██╔══██║██╔══██╗██╔══╝░░██╔══╝░░░░░██║░░██║██╔══██╗░░░██║╚██╔╝██║██║░░██║██╔══██╗██╔══╝░░");
            Console.WriteLine("███████╗██╗░░░██║░░░██║░░██║██║░░██║███████╗███████╗░░░╚█████╔╝██║░░██║░░░██║░╚═╝░██║╚█████╔╝██║░░██║███████╗");
            Console.WriteLine("╚══════╝╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚══════╝░░░░╚════╝░╚═╝░░╚═╝░░░╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚═╝╚══════╝");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            var User = Console.ReadLine();
            int user = Convert.ToInt32(User);
            if(user == 1)
              {
               game.SevensOut();
              }
            if (user == 2) 
              {
               game.ThreeOrMore();
              }
                  gametest.Testsum();//this calls the method within the testing to test the dice 
                  gametest.Test(); // this calls the method within testing to test the dice rolls 
              }
        }
    }

