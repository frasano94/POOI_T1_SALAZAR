using System.ComponentModel.DataAnnotations;

namespace POOI_T1_SALAZAR.Models{
    public class Empleado{
        [Display(Name = "ID de Empleado")] 
        public string idEmpleado{get; set;}
        [Display(Name = "Nombres y Apellidos")]
        public string nomapeEmpleado{get; set;}
        [Display(Name = "Categoría del Empleado")]
        public string categoriaEmpleado{get; set;}
        [Display(Name = "Número de Hijos")]
        public int nHijos{get; set;}
        [Display(Name = "Tipo de Contrato")]
        public string tipoContrato{get; set;}
        
        public double SueldoBasico(){
            switch (categoriaEmpleado){
                case "E1": return 5500;
                case "E2": return 2500;
                case "E3": return 2200;
                default: return 1700;
            }
        }

        public double Escolaridad(){
            return nHijos * 108.0;
        }

        public double Bonificacion(){
            double basico=SueldoBasico();
            if (tipoContrato == "Indefinido") return basico*0.15;
            if (tipoContrato == "Contratado") return basico*0.10;
            return 0;
        }

        public double MontoAPagar(){
            return SueldoBasico() + Escolaridad() + Bonificacion();
        }
    }
}