﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivial.Tickets.Utility
{
    public record Unit;

    public static partial class Defaults
    {
        public static Unit Unit => new Unit();
    }
}
