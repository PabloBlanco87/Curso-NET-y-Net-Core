using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseSealed
{
    //Este tipo de clases no permiten que se herede de ellas
    public sealed class ClaseSealed
    {
        public int Edad { get; set; }
    }
}
