using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KevinMauricioAlvarengaHenriquez.Models
{
    public class CajeroViewModel
    {
        public CajeroViewModel(int monto)
        {
            this.monto = monto;
        }

        public int monto { get; set; }
    }

}