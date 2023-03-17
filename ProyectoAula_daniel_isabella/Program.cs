using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAula_daniel_isabella
{
    class Paciente
    {
        private int Identificación;
        private string Nombre;
        private string Apellido;
        private DateTime Nacimiento;
        private int Tipo_regimen;
        private int semanas_cotizadas;
        private DateTime Ingreso_sistema_salud;
        private DateTime Ingreso_Eps;
        private int Eps;
        private string Historia_clinica;
        private int Cantidad_enfermedades;
        private string Enfermedad_mas_relevante;
        private int Tipo_afiliacion;
        private int costos_tratamientos;

        public Paciente(int identificación, string nombre, string apellido, DateTime nacimiento, int tipo_regimen, int semanas_cotizadas, DateTime ingreso_sistema_salud, DateTime ingreso_Eps, int eps, string historia_clinica, int cantidad_enfermedades, string enfermedad_mas_relevante, int tipo_afiliacion, int costos_tratamientos)
        {
            Identificación1 = identificación;
            Nombre1 = nombre;
            Apellido1 = apellido;
            Nacimiento1 = nacimiento;
            Tipo_regimen1 = tipo_regimen;
            this.Semanas_cotizadas = semanas_cotizadas;
            Ingreso_sistema_salud1 = ingreso_sistema_salud;
            Ingreso_Eps1 = ingreso_Eps;
            Eps1 = eps;
            Historia_clinica1 = historia_clinica;
            Cantidad_enfermedades1 = cantidad_enfermedades;
            Enfermedad_mas_relevante1 = enfermedad_mas_relevante;
            Tipo_afiliacion1 = tipo_afiliacion;
            this.Costos_tratamientos = costos_tratamientos;
        }

        public int Identificación1 
        {
            get { 
                return Identificación; 
            }
            set { 
                Identificación = value; 
            }
        }
        public string Nombre1 
        {
            get {
                return Nombre;
            }
            set { 
                Nombre = value; 
            } 
        }
        public string Apellido1 
        {
            get 
            { 
                return Apellido; 
            }
            set 
            { 
                Apellido = value; 
            } 
        }
        public DateTime Nacimiento1 
        {
            get 
            { 
                return Nacimiento; 
            }
            set 
            { 
                Nacimiento = value; 
            }
        }
        public int Tipo_regimen1 
        {
            get 
            {
                return Tipo_regimen; 
            }
            set 
            { 
                Tipo_regimen = value; 
            }
        }
        public int Semanas_cotizadas 
        { 
            get
            {
                return semanas_cotizadas;
            }
            set
            {
                semanas_cotizadas = value;
            } 
        }
        public DateTime Ingreso_sistema_salud1 
        { 
            get
            {
                return Ingreso_sistema_salud;
            }
            set
            {
                Ingreso_sistema_salud = value;
            } 
        }
        public DateTime Ingreso_Eps1 
        { 
            get
            {
                return Ingreso_Eps;
            }
            set
            {
                Ingreso_Eps = value;
            } 
        }
        public int Eps1 
        { 
            get
            {
                return Eps;
            }
            set
            {
                Eps = value;
            } 
        }
        public string Historia_clinica1
        { 
            get
            {
                return Historia_clinica;
            }
            set
            {
                Historia_clinica = value;
            } 
        }
        public int Cantidad_enfermedades1 { get
            {
                return Cantidad_enfermedades;
            }
            set
            {
                Cantidad_enfermedades = value;
            } }
        public string Enfermedad_mas_relevante1 { get
            {
                return Enfermedad_mas_relevante;
            }
            set
            {
                Enfermedad_mas_relevante = value;
            } }
        public int Tipo_afiliacion1 { get
            {
                return Tipo_afiliacion;
            }
            set
            {
                Tipo_afiliacion = value;
            } }
        public int Costos_tratamientos { get
            {
                return costos_tratamientos;
            }
            set
            {
                costos_tratamientos = value;
            } }
    }
}


        
        