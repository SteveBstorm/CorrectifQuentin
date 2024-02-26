﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Characters
{
    public class Pretre : Personnage
    {
        public override int Intelligence { get => base.Intelligence + 2; set => base.Intelligence = value; }
        public override int Sagesse { get => base.Sagesse + 4; set => base.Sagesse = value; }
    }
}
