using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.Data.DatabaseFirstEF.DTOs;

public class BasicProductViewDTO
{
    public string Name { get; set; }
    public string Type { get; set; }
    public decimal Price { get; set; }
}