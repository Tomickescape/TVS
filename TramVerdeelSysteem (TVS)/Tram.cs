﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramVerdeelSysteem__TVS_
{
    class Tram
    {
        private int tramnummer;
        private int spoornummer;
        private int segmentnummer;
        private Status status;
        //lijnID?
        //RemisID?

         public int Tramnummer
         {
             get { return tramnummer; }
             set { tramnummer = value; }
         }
         public int Spoornummer
         {
             get { return spoornummer; }
             set { spoornummer = value; }
         }
         public int Segmentnummer
         {
             get { return segmentnummer; }
             set { segmentnummer = value; }
         }
         public Status Status
         {
             get { return status; }
             set { status = value; }
         }
        

        public override string ToString()
        {
            return "Tramnummer: " + tramnummer + "|| Spoornummer: " + segmentnummer + "|| Status: " + status; //+ "|| Tramlengte: " + tramlengte;
        }
    }
}