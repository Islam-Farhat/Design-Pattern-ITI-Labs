﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class Player : IObserver
    {
        public Player()
        {
            
        }
        Football football;

        public Player(Football football)
        {
            this.football = football;
        }
        public void Update()
        {
            football.GetBallPosition();
        }
    }
}