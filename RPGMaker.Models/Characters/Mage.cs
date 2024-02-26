﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMaker.Models.Characters
{
    public class Mage : Personnage
    {
        public override int Intelligence { get => base.Intelligence + 4; set => base.Intelligence = value; }
        public override int Sagesse { get => base.Sagesse + 2; set => base.Sagesse = value; }
    }
}
