using System;

namespace ProyectoCL
{
    public class Persona
    {
        public Persona(string nombres, string apellidos, DateTime fechaNacimiento, int identificacion)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Id = identificacion;

        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Nombres
        {
            get
            {
                return _nombres;
            }
            set
            {
                _nombres = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                _apellidos = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }

        private int _id;
        private string _nombres;
        private string _apellidos;
        private DateTime _fechaNacimiento;
    }

    public class Afiliacion
    {
        public Afiliacion(int tipoRegimen, int semanasCotizadas, int tipoAfiliacion)
        {
            TipoRegimen = tipoRegimen;
            SemanasCotizadas = semanasCotizadas;
            TipoAfiliacion = tipoAfiliacion;
        }
        public int TipoRegimen
        {
            get
            {
                return _tipoRegimen;
            }
            set
            {
                _tipoRegimen = value;
            }
        }
        public int SemanasCotizadas
        {
            get
            {
                return _semanasCotizadas;
            }
            set
            {
                _semanasCotizadas = value;
            }
        }
        public int TipoAfiliacion
        {
            get
            {
                return _tipoAfiliacion;
            }
            set
            {
                _tipoAfiliacion = value;
            }
        }

        private int _tipoRegimen;
        private int _semanasCotizadas;
        private int _tipoAfiliacion;
    }

    public class EPS
    {
        public EPS(DateTime fechaIngresoSistemaSalud, DateTime fechaIngresoEPS, int nombreEPS)
        {
            FechaIngresoSistemaSalud = fechaIngresoSistemaSalud;
            FechaIngresoEPS = fechaIngresoEPS;
            NombreEPS = nombreEPS;
        }
        public DateTime FechaIngresoSistemaSalud
        {
            get
            {
                return _fechaIngresoSistemaSalud;
            }
            set
            {
                _fechaIngresoSistemaSalud = value;
            }
        }
        public DateTime FechaIngresoEPS
        {
            get
            {
                return _fechaIngresoEPS;
            }

            set
            {
                _fechaIngresoEPS = value;
            }
        }
        public int NombreEPS
        {
            get
            {
                return _nombreEPS;
            }
            set
            {
                _nombreEPS = value;
            }
        }

        private int _nombreEPS;
        private DateTime _fechaIngresoEPS;
        private DateTime _fechaIngresoSistemaSalud;

    }

    public class HistoriaClinica
    {
        public HistoriaClinica(int cantidadEnfermedades, string enfermedadMasRelevante, string historiaclinica)
        {
            CantidadEnfermedades = cantidadEnfermedades;
            EnfermedadMasRelevante = enfermedadMasRelevante;
            Historiaclinica = historiaclinica;
        }
        public string Historiaclinica
        {
            get
            {
                return _historiaclinica;
            }
            set
            {
                _historiaclinica = value;
            }
        }
        public int CantidadEnfermedades
        {
            get
            {
                return _cantidadEnfermedades;
            }
            set
            {
                _cantidadEnfermedades = value;
            }
        }
        public string EnfermedadMasRelevante
        {
            get
            {
                return _enfermedadMasRelevante;
            }
            set
            {
                _enfermedadMasRelevante = value;
            }
        }
        private string _historiaclinica;
        private int _cantidadEnfermedades;
        private string _enfermedadMasRelevante;

    }

    public class CostosTratamientos
    {
        public CostosTratamientos(double costosAsociados)
        {
            CostosAsociados = costosAsociados;
        }

        public double CostosAsociados
        {
            get
            {
                return _CostosAsociados;
            }
            set
            {
                _CostosAsociados = value;
            }

        }
        private double _CostosAsociados;
    }



    public class CambioRegimen
    {
        public void CambiarTipoRegimen(Afiliacion _tipoRegimen, int nuevoTipoRegimen)
        {
            _tipoRegimen.TipoRegimen = nuevoTipoRegimen;
        }
    }



    public class ActualizacionHistoriaClinica
    {
        public void ActualizarHistoriaClinica(HistoriaClinica persona, int nuevaCantidadEnfermedades, string nuevaEnfermedadMasRelevante)
        {
            persona.CantidadEnfermedades = nuevaCantidadEnfermedades;
            persona.EnfermedadMasRelevante = nuevaEnfermedadMasRelevante;
        }
    }

    public class ActualizacionCostosTratamientos
    {
        public void ActualizarCostosTratamientos(CostosTratamientos _costos, double nuevosCostosAsociados)
        {
            _costos.CostosAsociados = nuevosCostosAsociados;
        }
    }

    public class ActualizacionEnfermedadMasRelevante
    {
        public void ActualizarEnfermedadMasRelevante( HistoriaClinica _relevante, string nuevaEnfermedadMasRelevante)
        {
            _relevante.EnfermedadMasRelevante = nuevaEnfermedadMasRelevante;
        }
    }

}



