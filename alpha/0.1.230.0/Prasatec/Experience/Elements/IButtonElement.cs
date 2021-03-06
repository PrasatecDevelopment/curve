﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prasatec.Experience.Elements
{
    public interface IButtonElement : IElement
    {
        event EventHandler Click;
        IWindow Controller { get; }
        String Text { get; set; }
    }
}
