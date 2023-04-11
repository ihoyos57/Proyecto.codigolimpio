using ProyectoCL;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAula_daniel_isabella
{
    using ProyectoCL;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ProyectoAula_isabella
    {
        class Program
        {
            static void Main()
            {
                List<Persona> listaPersonas = new List<Persona>();
                List<EPS> listaeps = new List<EPS>();
                List<Afiliacion> listafiliacion = new List<Afiliacion>();
                List<HistoriaClinica> listaHistoriaClinica = new List<HistoriaClinica>();
                List<CostosTratamientos> listaCostosTratamientos = new List<CostosTratamientos>();
                while (true)
                {
                    Console.WriteLine("Seleccione la opción que desea: ");
                    Console.WriteLine(" 0. Ingresar pacientes \n 1. mostrar estadisticas \n 2. cambiar eps \n 3. Salir");

                    int opcion = Convert.ToInt16(Console.ReadLine());

                    if (opcion == 0)
                    {
                        listaPersonas.Add(Crear_Persona());
                        listaeps.Add(Crear_Eps());
                        listafiliacion.Add(Crear_afiliacion());
                        listaHistoriaClinica.Add(Crear_Historiaclinica());
                        listaCostosTratamientos.Add(Crear_costos());

                        while (true)
                        {
                            // Preguntar si se desea agregar otro paciente
                            Console.WriteLine("¿Desea agregar otro paciente? (s/n)");
                            string respuesta = Console.ReadLine().ToLower();

                            if (respuesta == "s")
                            {
                                listaPersonas.Add(Crear_Persona());
                                listaeps.Add(Crear_Eps());
                                listafiliacion.Add(Crear_afiliacion());
                                listaHistoriaClinica.Add(Crear_Historiaclinica());
                                listaCostosTratamientos.Add(Crear_costos());
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                    else if (opcion == 1)
                    {/*
                        Console.WriteLine("El costo total por cada eps es {0} ", total_costos_por_eps(listaPersonas));
                        Console.WriteLine("El porcentaje de costos por la eps selecionada es {0}", porcentaje_costos_por_eps(listaPersonas));
                        List<double> lista_edades = CalcularEdades(listaPersonas);
                        Console.WriteLine("el porcentaje de los niños es {0}:", lista_edades[0]);
                        Console.WriteLine("el porcentaje de los adolecentes es {0}:", lista_edades[1]);
                        Console.WriteLine("el porcentaje de los jovenes es {0}:", lista_edades[2]);
                        Console.WriteLine("el porcentaje de los adultos es {0}:", lista_edades[3]);
                        Console.WriteLine("el porcentaje de los adultos mayores es {0}:", lista_edades[4]);
                        Console.WriteLine("el porcentaje de los ancianos es {0}:", lista_edades[5]);
                        Console.WriteLine("el porcentaje de las personas que poseen el cancer es", total_cancer(listaPersonas));
                        Console.WriteLine(lista_edades);
                        Console.WriteLine(PorcentajeRegimen(listaPersonas));
                        */


                    }
                    else if (opcion == 2)
                    {/*
                        cambiar_eps(listaPersonas);
                        */
                    }
                    else
                    {
                        Console.WriteLine("Gracias por utilizar nuestro programa! :D");
                        break;
                    }
                }

            }

            private static Persona Crear_Persona()
            {
                string nombres = "";
                string apellidos = "";
                DateTime FechaNacimiento = DateTime.MinValue;
                int identificacion = 0;

                while (identificacion == 0)
                {
                    try
                    {
                        Console.WriteLine("Ingrese la identificación:");
                        identificacion = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine("Error: " + a.Message);
                    }
                }

                while (nombres == "")
                {
                    try
                    {
                        Console.WriteLine("Ingrese el nombre:");
                        nombres = Console.ReadLine();
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine("Error: " + a.Message);
                    }
                }

                while (apellidos == "")
                {
                    try
                    {
                        Console.WriteLine("Ingrese el apellido:");
                        apellidos = Console.ReadLine();
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine("Error: " + a.Message);
                    }
                }

                while (FechaNacimiento == DateTime.MinValue)
                {
                    try
                    {
                        Console.WriteLine("Ingrese la fecha de nacimiento (dd/mm/aaaa):");
                        FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine("Error: " + a.Message);
                    }
                }
                Persona nuevaPersona = new Persona(nombres, apellidos,
                    FechaNacimiento, identificacion);

                return nuevaPersona;

            }

            private static EPS Crear_Eps()
            {
                DateTime ingreso_sistema_salud = DateTime.MinValue;
                DateTime ingreso_eps = DateTime.MinValue;
                int nombre_eps = 0;

                while (nombre_eps == 0)
                {
                    try
                    {
                        Console.WriteLine("Ingrese el tipo de eps (1: Sura, 2: Nueva eps, 3: salud total, 4: sanitas, 5: savia):");
                        nombre_eps = Convert.ToInt32(Console.ReadLine());
                        if (nombre_eps < 1 & nombre_eps > 5)
                        {
                            throw new Exception("El valor ingresado debe estar entre 1 y 5");
                        }
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine("Error: " + a.Message);
                    }
                }
                while (ingreso_sistema_salud == DateTime.MinValue)
                {
                    try
                    {
                        Console.WriteLine("Ingrese la fecha de ingreso al sistema de salud (dd/mm/aaaa):");
                        ingreso_sistema_salud = Convert.ToDateTime(Console.ReadLine());
                    }
                    catch (Exception a)
                    {

                        Console.WriteLine("Error: " + a.Message);
                    }
                }
                while (ingreso_eps == DateTime.MinValue)
                {
                    try
                    {
                        Console.WriteLine("Ingrese la fecha de ingreso a la eps (dd/mm/aaaa):");
                        ingreso_eps = Convert.ToDateTime(Console.ReadLine());
                    }
                    catch (Exception a)
                    {

                        Console.WriteLine("Error: " + a.Message);
                    }
                }

                EPS nuevoPacienteEps = new EPS(ingreso_sistema_salud,
                ingreso_eps, nombre_eps);

                return nuevoPacienteEps;

            }
            private static Afiliacion Crear_afiliacion()
            {
                int tipo_regimen = 0;
                int semanas_cotizadas = 0;
                int tipo_afiliacion = 0;

                while (tipo_regimen == 0)
                {
                    try
                    {
                        Console.WriteLine("Ingrese el tipo de afiliacion (1: Contributivo, 2: Subsidiado):");
                        tipo_regimen = Convert.ToInt32(Console.ReadLine());
                        if (tipo_regimen < 1 || tipo_regimen > 2)
                        {
                            throw new Exception("El valor ingresado debe ser 1 o 2");
                        }
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine("Error: " + a.Message);
                    }
                }
                while (tipo_afiliacion == 0)
                {
                    try
                    {
                        Console.WriteLine("Ingrese el tipo de afiliacion (1: Cotizante, 2: Beneficiario):");
                        tipo_afiliacion = Convert.ToInt32(Console.ReadLine());
                        if (tipo_afiliacion < 1 || tipo_afiliacion > 2)
                        {
                            throw new Exception("El valor ingresado debe ser 1 o 2");
                        }
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine("Error: " + a.Message);
                    }
                }
                while (semanas_cotizadas == 0)
                {
                    try
                    {
                        Console.WriteLine("Ingrese el número de semanas cotizadas:");
                        semanas_cotizadas = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine("Error: " + a.Message);
                    }
                }
                Afiliacion nuevoPacienteAfiliado = new Afiliacion(tipo_regimen, semanas_cotizadas, tipo_afiliacion);

                return nuevoPacienteAfiliado;
            }
            private static HistoriaClinica Crear_Historiaclinica()
            {
                string historia_clinica = "";
                int cantidad_enfermedades = 0;
                string enfermedad_mas_relevante = "";

                while (cantidad_enfermedades == 0)
                {
                    try
                    {
                        Console.WriteLine("Ingrese la cantidad de enfermedades:");
                        cantidad_enfermedades = Convert.ToInt32(Console.ReadLine());

                        if (cantidad_enfermedades <= 0)
                        {
                            throw new Exception("Debe ingresar un valor mayor a cero para la cantidad de enfermedades.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }

                while (enfermedad_mas_relevante == "")
                {
                    try
                    {
                        Console.WriteLine("Ingrese la enfermedad más relevante:");
                        enfermedad_mas_relevante = Console.ReadLine();
                        if (enfermedad_mas_relevante == "")
                        {
                            throw new Exception("La enfermedad no puede estar vacía");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                }

                while (historia_clinica == "")
                {
                    try
                    {
                        Console.WriteLine("Ingrese la historia clínica:");
                        historia_clinica = Console.ReadLine();
                        if (historia_clinica == "")
                        {
                            throw new Exception("Debe ingresar un valor");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                }
                HistoriaClinica nuevaHistoria = new HistoriaClinica(cantidad_enfermedades,
                    enfermedad_mas_relevante, historia_clinica);

                return nuevaHistoria;
            }

            private static CostosTratamientos Crear_costos()
            {
                int costosAsociados = 0;
                while (costosAsociados <= 0)
                {
                    try
                    {
                        Console.WriteLine("Ingrese los costos de tratamientos:");
                        costosAsociados = Convert.ToInt32(Console.ReadLine());
                        if (costosAsociados <= 0)
                        {
                            throw new Exception("El valor ingresado debe ser mayor que cero");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                }
                CostosTratamientos nuevoscostos = new CostosTratamientos(costosAsociados);

                return nuevoscostos;
            }
        }
    }
}
            /*
            private static int total_costos_por_eps(List<CostosTratamientos> listaCostosTratamientos)
            {
                int suma = 0;
                foreach (CostosTratamientos i in listaCostosTratamientos)
                {
                    suma += i.;
                }
                return suma;
            }
        
            private static int total_costos_por_eps(List<Paciente> listapersonas)
            {
                int suma = 0;
                foreach (Paciente paciente in listapersonas)
                {
                    suma += paciente.Costos_tratamientos;
                }
                return suma;
            }


            private static double porcentaje_costos_por_eps(List<Paciente> listapersonas)
            {
                int eps;
                int total_costos_eps = 0;
                int total_costos = 0;
                Console.WriteLine("Ingrese el tipo de eps (1: Sura, 2: Nueva eps, 3: salud total, 4: sanitas, 5: savia):");
                eps = Convert.ToInt32(Console.ReadLine());

                // Calcula el total de costos para la EPS especificada
                foreach (Paciente paciente in listapersonas)
                {


                    if (paciente.Eps1 == eps)
                    {
                        total_costos_eps += paciente.Costos_tratamientos;
                    }
                    total_costos += paciente.Costos_tratamientos;
                    
                }


                if (total_costos > 0)
                {
                    double porcentaje = (double)total_costos_eps / total_costos * 100;
                    return porcentaje;
                }
                else
                {
                    return 0;
                }


            }


            static List<double> CalcularEdades(List<Paciente> listaspersonas)
            {
                int edad = 0;
                int contador_ninnos = 0;
                int contador_adolecente = 0;
                int contador_jovenes = 0;
                int contador_adulto = 0;
                int contador_adulto_mayor = 0;
                int contador_anciano = 0;




                foreach (Paciente paciente in listaspersonas)
                {
                    edad = DateTime.Today.Year - paciente.Nacimiento1.Year;

                    if (edad >= 0 && edad < 12)
                    {
                        contador_ninnos++;
                    }
                    else if (edad >= 12 && edad < 18)
                    {
                        contador_adolecente++;
                    }
                    else if (edad >= 19 && edad < 30)
                    {
                        contador_adulto++;
                    }
                    else if (edad >= 30 && edad < 55)
                    {
                        contador_adulto++;
                    }
                    else if (edad >= 55 && edad < 75)
                    {
                        contador_adulto_mayor++;
                    }
                    else
                    {
                        contador_anciano++;
                    }


                }



                double total_edades = contador_ninnos + contador_jovenes + contador_anciano + contador_adolecente + contador_adulto
                    + contador_adulto_mayor;

                double porcentaje_ninno = contador_ninnos / total_edades * 100;
                double porcentaje_adolecente = contador_adolecente / total_edades * 100;
                double porcentaje_jovenes = contador_jovenes / total_edades * 100;
                double porcentaje_adulto = contador_adulto / total_edades * 100;
                double porcentaje_adulto_mayor = contador_adulto_mayor / total_edades * 100;
                double porcentaje_anciano = contador_anciano / total_edades * 100;

                List<double> lista_porcentajes = new List<double> {porcentaje_ninno, porcentaje_adolecente, porcentaje_jovenes, porcentaje_adulto,
                porcentaje_adulto_mayor, porcentaje_anciano };
                return lista_porcentajes;


            }
            static int total_cancer(List<Paciente> listaspersonas)
            {
                int contador_cancer = 0;

                foreach (Paciente paciente in listaspersonas)
                {
                    if (paciente.Enfermedad_mas_relevante1.ToLower() == "cancer")
                    {
                        contador_cancer++;
                    }
                }
                return contador_cancer;
            }
            static void cambiar_eps(List<Paciente> listaPersonas)
            {

                if (listaPersonas.Count == 0)
                {
                    Console.WriteLine("Debes ingresar por lo menos un paciente");

                }
                else
                {
                    Console.WriteLine("Ingrese el numero de identifiacion:");
                    int identificacion = Convert.ToInt32(Console.ReadLine());
                    int mesesTranscurridos = 0;
                    Paciente pacienteSeleccionado = listaPersonas[0];
                    bool validar = false;

                    DateTime fechaActual = DateTime.Now;

                    foreach (Paciente paciente in listaPersonas)
                    {
                        if (identificacion == paciente.Identificación1)
                        {
                            pacienteSeleccionado = paciente;
                            mesesTranscurridos = ((fechaActual.Year - paciente.Ingreso_sistema_salud1.Year) * 12) + fechaActual.Month - paciente.Ingreso_sistema_salud1.Month;
                            validar = true;
                            break;
                        }
                    }
                    if (validar == true)
                    {
                        if (mesesTranscurridos > 3)
                        {
                            Console.WriteLine("Ingrese el tipo de eps al que desea cambiar (1: Sura, 2: Nueva eps, 3: salud total, 4: sanitas, 5: savia):");
                            int eps = Convert.ToInt32(Console.ReadLine());
                            if (eps == pacienteSeleccionado.Eps1)
                            {
                                Console.WriteLine("Estas seleccionando la misma EPS");
                            }
                            else
                            {
                                pacienteSeleccionado.Eps1 = eps;
                            }

                        }
                        else
                        {
                            Console.WriteLine("El paciente seleccionado lleva menos de 3 meses en la EPS");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado el paciente");
                    }
                }

            }

            static List<double> PorcentajeRegimen(List<Paciente> listaspersonas)
            {
                double porcentaje_contributivo = 0;
                double porcentaje_subsidiado = 0;
                int total_contributivo = 0;
                int total_subsidiado = 0;
                int total_personas = 0;

                total_personas = listaspersonas.Count;

                foreach (Paciente paciente in listaspersonas)
                {
                    if (paciente.Tipo_regimen1 == 1)
                    {
                        total_contributivo += 1;
                    }
                    else if (paciente.Tipo_regimen1 == 2)
                    {
                        total_subsidiado += 1;
                    }
                }



                List<double> list_regimen = new List<double>() { porcentaje_contributivo, porcentaje_subsidiado, };
                return list_regimen;
            }

        }

    }
}
        */



























































          