using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Entidades
{
    public class Algoritmo
    {
        public float Num1 { get; set; }
        public float Num2 { get; set; }
        public float ResultadoSuma { get; set; }
        public float ResultadoResta { get; set; }
        public float ResultadoMultiplicacion { get; set; }

        
        public Algoritmo()
        {
            Num1 = 0;
            Num2 = 0;
            ResultadoSuma = 0;
            ResultadoResta = 0;
            ResultadoMultiplicacion = 0;
        }
    }
}
