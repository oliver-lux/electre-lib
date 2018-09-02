﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BuySoftware
{
    class Alternativa
    {
        public string nume;
        private BitmapImage imagine;

        public List<double> valori_criterii = new List<double>();

        public Alternativa(string nume)
        {
            this.nume = nume;
            this.imagine = new BitmapImage(new System.Uri("../../../res/unknown.png", UriKind.Relative));
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public BitmapImage Imagine
        {
            get { return this.imagine; }
            set { this.imagine = value; }
        }
    }
}