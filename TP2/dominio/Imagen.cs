﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Imagen
    {
        public string ImagenUrl { get; set; }
        public int idArticulo { get; set; }

        public int idImagen { get; set; }

        public override string ToString()
        {
            return ImagenUrl;
        }
    }
}
