﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_11_08_JantarFilosofos
{
    class Garfo
    {
        int posicao;
        bool ocupado;

        public Garfo(int pos)
        {
            this.posicao = pos;
            this.ocupado = false;
        }

        public int Posicao { get => posicao; set => posicao = value; }
        public bool Ocupado { get => ocupado; set => ocupado = value; }


        //public void SortearGarfoDir()
        //{
        //    Random r = new Random();

        //    this.garfoDir = r.Next(1, 5);
        //}

        //public void SortearGarfoEsq()
        //{
        //    Random r = new Random();

        //    this.garfoEsq = r.Next(1, 5);
        //}

        //public void SortearGarfos()
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            SortearGarfoDir();
        //            SortearGarfoEsq();
        //            Thread.Sleep(1000);
        //        } 
        //        catch (ThreadInterruptedException ex)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine(ex.Message);
        //            Console.ResetColor();
        //        }
        //    }
        //}
    }
}
