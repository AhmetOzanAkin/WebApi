﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response;

public class CreatedBrandResponse
{
    // Kullanıcıya döndüğümüz cevap
    public int  Id{ get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
}
