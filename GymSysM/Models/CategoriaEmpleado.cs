﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GymSysM.Models
{
    public partial class CategoriaEmpleado
    {
        public CategoriaEmpleado()
        {
            Empleado = new HashSet<Empleado>();
        }

        public int IdCategoriaEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal SalarioHora { get; set; }
        public decimal? SalarioBase { get; set; }

        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
