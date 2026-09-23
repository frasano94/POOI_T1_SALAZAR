using System;
using System.ComponentModel.DataAnnotations;

namespace POOI_T1_SALAZAR.Models{
    //Administrativo hereda de Empleado
    public class Administrativo : Empleado{
        [Display(Name = "Año de Ingreso")]
        public int AnioIngreso{get; set;}

        [Display(Name = "¿Tiene PostGrado?")]
        public bool PostGrado{get; set;}

        //Incentivo por PostGrado
        public double Incentivo(){
            return PostGrado ? 500.0 : 0.0;
        }

        // Polimorfismo / Sobrescritura de la bonificación según años de servicio
        public new double Bonificacion()
        {
            int aniosServicio = DateTime.Now.Year - AnioIngreso;

            if (aniosServicio < 5)
                return 200.0;
            else if (aniosServicio >= 5 && aniosServicio <= 10)
                return 450.0;
            else
                return 300.0;
        }

        // Nuevo cálculo total sumando el incentivo
        public new double MontoAPagar()
        {
            return SueldoBasico() + Escolaridad() + Bonificacion() + Incentivo();
        }
    }
}