using System;
using System.Collections.Generic;

namespace yigit2324.Models;

public partial class Urunler
{
    public int Id { get; set; }

    public string Urunadi { get; set; } = null!;

    public string Urunfiyati { get; set; } = null!;

    public string Urundetayi { get; set; } = null!;

    public string Stokdurumu { get; set; } = null!;

    public string Resim { get; set; } = null!;
}
