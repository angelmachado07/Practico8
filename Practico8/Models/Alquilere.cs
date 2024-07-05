using System;
using System.Collections.Generic;

namespace Practico8.Models;

public partial class Alquilere
{
    public long Id { get; set; }

    public int? IdCopia { get; set; }

    public int? IdCliente { get; set; }

    public DateTime FechaAlquiler { get; set; }

    public DateTime FechaTope { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Copia? IdCopiaNavigation { get; set; }
}
