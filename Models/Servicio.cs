using System;
using System.Collections.Generic;

namespace prueba.Models;

public partial class Servicio
{
    public uint Id { get; set; }

    public string Nombre { get; set; } = null!;

    public uint Precio { get; set; }

    public string Sku { get; set; } = null!;

    public int Estado { get; set; }

    public uint UsuarioId { get; set; }

    public virtual ICollection<Descripcionservicio> Descripcionservicios { get; set; } = new List<Descripcionservicio>();

    public virtual ICollection<Recepcionequipo> Recepcionequipos { get; set; } = new List<Recepcionequipo>();

    public virtual Usuario Usuario { get; set; } = null!;
}
