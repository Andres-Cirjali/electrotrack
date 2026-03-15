using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ElectroTrack
{

    // CLASE LOGGER

    /// <summary>
    ///  Simplemente creamos un archivo.log para poder ver todo lo que occurre en nuestro programa dependiendo de lo que hagamos, como debugging
    /// </summary>
    static class LOGGER
    {
        private static readonly string _rutaLog = "electrotrack.log";

        /// <summary>
        /// registramos un mensaje info en el log
        /// </summary>
        /// <param name="mensaje">evento q se registra </param>
        public static void info(string mensaje)
        {
            string linea = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [INFO]  {mensaje}";
            try
            {
                File.AppendAllText(_rutaLog, linea + Environment.NewLine);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"[Advertencia] No se pudo escribir en el log: {ex.Message}");
            }
        }

        ///<summary>
        ///registramos un mensaje de error en el log y lo dejamos ahi medio bonico en color rojo oscuro
        ///</summary>
        /// <param name="mensaje">Descripción del error producido.</param>
        public static void Error(string mensaje)
        {
            string linea = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [ERROR] {mensaje}";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(linea);
            Console.ResetColor();
            try
            {
                File.AppendAllText(_rutaLog, linea + Environment.NewLine);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"[Advertencia] No se pudo escribir el error en el log: {ex.Message}");
            }
        }
    }

    // clase principal
   /// <summary>
   /// donde sucede toda la magia es decir el menu y navegacion
   /// </summary>
    class Program
    {
        /// <summary>
        /// almacena historial de consultas
        /// </summary>
        static List<List<string>> consultasRealizadas = new List<List<string>>();
        // entrada del programa y logeamos eso
        static void Main(string[] args)
        {
            LOGGER.info(" -- sesion inciada ");
            EjecutarPrograma();
            LOGGER.info(" -- sesion cerrada ");
        }
        /// <summary>
        /// bucle del programa y menu
        /// </summary>
        static void EjecutarPrograma()
        {
            bool salir = false;

            while (!salir)
            {
                menuprincipal();
                int opcion = entradausuarionum("Selecciona una opción: ");

                switch (opcion)
                {
                    case 1:
                        LeyDHont();
                        break;
                    case 2:
                        PartidosPoliticos();
                        break;
                    case 3:
                        EleccionesPasadas();
                        break;
                    case 4:
                        CasosCorrupcion();
                        break;
                    case 5:
                        ConsultasRealizadas();
                        break;
                    case 6:
                       CalculadoraDHont();
                        break;
                    case 7:
                      Console.WriteLine("¡Gracias por usar ElectroTrack!");
                        LOGGER.info("El usuario eligió salir del programa.");
                        salir = true;
                        break;
                    default:
                        mostrarerror("Opción no válida, por favor selecciona un numero valido que si no dejo de funcionar y te quedas sin programa gracias.");
                        break;
                }

                if (!salir)
                {
                    continuallalala();
                }
            }
        }

        // CONTENIDO

        /// <summary>
        /// simplemente muestra muchisima informacón del sistema electoral y ley d'hont
        /// </summary>

        static void LeyDHont()
        {
            LOGGER.info("el usuario accedio a la seccion ley dhont");

            Console.WriteLine("\n╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║              LA LEY D'HONDT                       ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");

            Console.WriteLine("Para determinar quienes seran los 350 diputados del congreso se establece");
            Console.WriteLine("una division territorial en 52 circunscripciones:");
            Console.WriteLine("las 50 provincias españolas más las dos ciudades autónomas, Ceuta y Melilla..");

            Console.WriteLine("\n--- Funcionamiento del sistema ---");
            Console.WriteLine("Tras las elecciones generales, se asignan los escaños a las listas electorales en cada circunscripción.");
            Console.WriteLine("Para ese reparto se usa el sistema D'Hondt en cada circunscripción por separado.");
            Console.WriteLine("Ademas de eso, cada partido politica necesitara un 3% de votos para optar a escaño. (un 3% en la comunidad autonoma/ciudad)");

            Console.WriteLine("\n--- Ejemplo práctico y explicación ---");
            Console.WriteLine("para calcular el numero de escaños se tiene que dividir el numero de votos de cada partido por 1,2,3,4,5 por ejemplo:");

            // Variables para operaciones
            int votosRalph = 5000;
            int votosDior = 4000;
            int votosHugo = 3500;
            int votosDolce = 1000;

            Console.WriteLine($"  • Partido de ralph lauren: {votosRalph} votos ");
            Console.WriteLine($"  • Partido dior: {votosDior} votos ");
            Console.WriteLine($"  • Partido hugo boss: {votosHugo} votos ");
            Console.WriteLine($"  • Partido de dolce gabbana: {votosDolce} votos ");

            Console.WriteLine("\n Distribución los escaños:");
            Console.WriteLine($"primero para el 1er escaño mirariamos quien es el que tiene mas votos que es ralph, con {votosRalph}, pues le asignariamos el escaño y su numero lo dividiariamos entre 2.");

            int ralphDividido = votosRalph / 2; // operacion 
            Console.WriteLine($"a si que tendria {ralphDividido}, para el segundo escaño mirariamos el siguiente que mas votos tiene la lista seria algo asi: 1ero con {ralphDividido}, segundo {votosDior}, 3ero {votosHugo} y 4to {votosDolce}.");
            Console.WriteLine("como el partido de dior es el siguiente con mas votos seleccionariamos ese, y asi sucesivamente, cada vez que un partido tenga el escaño se tendria que dividir el numero total de votos que tenia entre 1,2,3,4,5");

            Console.WriteLine("\n  (Prueba la opcion 6 para calcular un reparto real con tus propios datos)");

            RegistrarConsulta("Ley D'Hondt");
        }

        /// <summary>
        /// mas informacion pero esta vez sobre partidos politicos
        /// </summary>
        static void PartidosPoliticos()
        {

            LOGGER.info("el usuario esta en la seccion de partidos politicos");

            Console.WriteLine("\n╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║         PARTIDOS POLÍTICOS PRINCIPALES            ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");

            Console.WriteLine("\n -- TOP PARTIDOS POLITICOS EN ESPAÑA");
            Console.WriteLine("Aqui se mostraran los partidos politicos mas importantes de España y sus Programas Electorales (independientemente de que los cumplan o no) ");

            Console.WriteLine("\n1. Partido Popular (PP)");
            Console.WriteLine(" El PP es una formacion politica Española de Centroderecha que defiende la unidad de España, la economia de mercado");
            Console.WriteLine("y políticas conservadoras en lo social. Promueve la reducción de impuestos, la iniciativa privada y una gestion pública orientada a la eficiencia");

            Console.WriteLine("\n2. Partido Socialista Obrero Español (PSOE)");
            Console.WriteLine(" El PSOE es una formación politica de Centroizquierda que defiende la justicia social e igualdad");
            Console.WriteLine(" Promueve políticas progresistas en derechos sociales, laborales y medioambientales junto con una economia social de mercado.");

            Console.WriteLine("\n3. VOX");
            Console.WriteLine("   VOX es una formación politica de Derechas que defiende el nacionalismo, la unidad de Estado y politicas conservadoras en lo social.");
            Console.WriteLine("  Aboga por la reduccíon del Estado autonómico, el control migratorio y la promoción de valores tradicionales y de libre mercado.");

            Console.WriteLine("\n4. Sumar");
            Console.WriteLine("   Sumar busca una transformación social y ecológica, con empleo verde, vivienda asequible y justicia fiscal");
            Console.WriteLine("   Su objetivo es impulsar un modelo económico sostenible y más igualitario en España.");

            RegistrarConsulta("Partidos Políticos");
        }

        /// <summary>
        /// simplemente los resultados de las elecciones de 20234 y 2019
        /// </summary>
        static void EleccionesPasadas()
        {
            LOGGER.info("el usuareio llego a la seccion de elecciones pasadas");

            Console.WriteLine("\n╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║        ELECCIONES GENERALES - RESULTADOS          ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");

            // Lista de resultados 2023
            string[] resultados2023 = {
                "PP - 137 Escaños, 8160837 votos, 33,06%",
                "PSOE - 121 Escaños, 7821718 Votos, 31,68%",
                "Vox - 3057000 votos, 33 Escaños, 12,38%",
                "SUMAR - 3044996 VOTOS, 31 Escaños, 12,33%",
                "ERC - 7 Escaños, 466020 votos, 1,89%",
                "JxC - 7 Escaños, 395429 votos, 1,60%",
                "EH Bildu 6 Escaños, 335129 votos, 1,36%",
                "PNV 5 Escaños, 277289 votos, 1,12%",
                "BNG 1 Escaño, 154000 votos, 0,62%",
                "CCa 1 eSCAÑO, 116363 votos, 0,47%",
                "UPN 1 Escaño, 52188 votos, 0,21%"
            };

            Console.WriteLine("\nELECCIÓNES GENERALES 2023:");
            for (int i = 0; i < resultados2023.Length; i++)
            {
                Console.WriteLine($"  • {resultados2023[i]}");
            }

            // Lista de resultados 2019
            string[] resultados2019 = {
                "PSOE 120 6.792.199 28,25%",
                "PP 89 5.047.040 20,99%",
                "VOX 52 3.656.979 15,21%",
                "PODEMOS-IU 35 3.119.364 12,97%",
                "ERC-SOBIRANISTES 13 874.859 3,64%",
                "Cs 10 1.650.318 6,86%",
                "JxCAT-JUNTS 8 530.225 2,21%",
                "PNV 6 379.002 1,58%",
                "EH Bildu 5 277.621 1,15%",
                "MÁS PAÍS 3 559.110 2,33%",
                "CUP-PR 2 246.971 1,03%",
                "CCa-PNC-NC 2 124.289 0,52%",
                "NA+ 2 99.078 0,41%",
                "BNG 1 120.456 0,5%",
                "PRC 1 68.830 0,29%",
                "¡TERUEL EXISTE! 1 19.761 0,08%"
            };

            Console.WriteLine("\nELECCIONES GENERALES 2019:");
            for (int i = 0; i < resultados2019.Length; i++)
            {
                Console.WriteLine($"  • {resultados2019[i]}");
            }


            RegistrarConsulta("Elecciones Generales");
        }

        /// <summary>
        /// informacion de los casos de corrupcion 
        /// </summary>
        static void CasosCorrupcion()
        {
            // correcion logica: esta vez se registrar al entrar no al final como antes
            RegistrarConsulta("Casos de corrupción");
            LOGGER.info("El usuario accedio a maravillosa corrupcion que acecha a este pais :)");
            Console.WriteLine("\n╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║         CASOS DE CORRUPCIÓN + extra            ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");

            Console.WriteLine("\nNota: Esta seccion simplemente mostrara los mas destacados que partido los hizo y numero de casos de corrupcion de el top 5 de partidos politicos con mas casos de corrupción aunque no se salva absolutamente nadie...\n");

            string[] casos = {
                "---- N1 DE CASOS POR PARTIDO ----",
                "n1: PP 261 Casos de corrupción",
                "n2: PSOE 135 Casos de corrupción",
                "n3: UM 18 Casos de corrupción",
                "n4: PNV 15 Casos de corrupcion",
                "n5: CC 12 Casos de corrupción",
                "\n ---- TOP DINERO ROBADO POR CASO ----",
                "N1: ERE + EDU 3600 MILLONES DE EUROS - PSOE",
                "N2: CASO Malaya 2400 MILLONES DE EUROS - Independientes / GIL",
                "N3: CASO ACUAMED 1000 MILLONES DE EUROS - PSOE",
                "N4: CASO PUNICA Y GUARTEL 370 MILLONES DE EUROS - PP",
                "N5: CASO TAULA 175 MILLONES - PP",
                "\n ---- CASOS DE CORRUPCIÓN MAS RECIENTES ----",
                "Caso Santos Cerdan, Caso Begoña Gomez, Caso Koldo, Caso Montoro... en fin un monton. ",
            };
            // -- FIN DEL CONTENIDO -- 

            // añade un 1 a cada string q hay y funciona mediante sueños y esperanzas NO CAMBIAR
            for (int i = 0; i < casos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {casos[i]}");
            }
            Console.WriteLine("0. Volver al menú principal");
 
            int opcion = entradausuarionum("\npresione la tecla 0 para salir: ");

      // CORRECCIÓN + TRY-CATCH: protegemos el acceso al array por índice
            try
            {
                if (opcion >= 1 && opcion <= casos.Length)
                {
                    LOGGER.info($"El usuario seleccionó el caso: {casos[opcion - 1]}");
                }
                else if (opcion != 0)
                {
                    mostrarerror("Opción no válida.");
                    LOGGER.Error($"Opción fuera de rango en CasosCorrupcion: {opcion}");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                LOGGER.Error($"Índice fuera de rango en CasosCorrupcion: opcion={opcion} — {ex.Message}");
                mostrarerror("Error inesperado al acceder al dato seleccionado.");
            }
        }
        /// <summary>
        /// ultimo summary que voy a hacer porque ha este paso pongo 500 lo demas lo pongo con un comentario a secas por que terrible lo del xml documentation comments
        /// </summary>
        static void ConsultasRealizadas()
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║          HISTORIAL DE CONSULTAS                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");

            if (consultasRealizadas.Count == 0)
            {
                Console.WriteLine("\nNo tienes consultas aun.");
                return;
            }

            Console.WriteLine();
            foreach (var consulta in consultasRealizadas)
            {
                string tema = consulta[0];
                string fecha = consulta[1];
                Console.WriteLine($"• {tema} - Consultado el {fecha}");
            }
        }



        //MANTENIMIENTO EVOLUTIVOO: calculadora de escaños!! (opcion 6? creo)

        static void CalculadoraDHont()
        {
            LOGGER.info("el usuario accedio a la calculadora d'hondt");
            RegistrarConsulta("Calculadora D'hondt");

            Console.WriteLine("\n----------------------------calculadora d'hondt interactiva----------------------------");

            Console.WriteLine("\nCuantos partidos quieres incluir? -- Min 2 Maximo 10");
            int numPartidos = entradausuarionum("Numero de partidos: ");

            if (numPartidos < 2 || numPartidos > 10)
            {
                mostrarerror("numero de partidos fuera del rango minimo 2 maximo 10.  -- SE USARA 2");
                LOGGER.Error($"NUMERO DE PARTIDOS FUERA DE RANGO EN LA CALCULADORA: {numPartidos}");
                numPartidos = 2;

            }

            string[] nombres = new string[numPartidos];
            int[] votos = new int[numPartidos];

            for (int i = 0; i < numPartidos; i++)
            {
                Console.WriteLine($"\n Partido {i + 1}:");
                Console.Write("     Nombre: ");
                // por si acaso: null-safety ya q el console.readline puede dar null
                string nombreLeido = Console.ReadLine() ?? $"Partido {i + 1}";
                nombres[i] = string.IsNullOrWhiteSpace(nombreLeido) ? $"Partido {i + 1}" : nombreLeido;

                try
                {
                    votos[i] = entradausuarionum("  Votos obtenidos");

                    if (votos[i] < 0)
                    {
                        mostrarerror("numero de votos no puede ser negativo.  -- SE USARA 0");
                        LOGGER.Error($"votos negativos para '{nombres[i]}' : {votos[i]}. Se establece a 0");
                        votos[i] = 0;
                    }
                }
                catch (Exception ex)
                {
                    LOGGER.Error($"error al leer votos del partido '{nombres[i]}' : {ex.Message}");
                    votos[i] = 0;
                }
            }

            int totala = entradausuarionum("\n cuantos escaños se reparten?");
            if (totala < 1)
            {
                LOGGER.Error($"Numero de escanos invalido: {totala}. Se establece a 1.");
                mostrarerror("El numero de escanos debe ser al menos 1. Se establece a 1.");
                totala = 1;
            }

            Console.Write("¿Umbral minimo de votos para optar a escano? (en %, normalmente 3): ");
            double umbral = 3.0;
            try
            {
                // por si acasoo porque readline puede dar nukll
                string umbralStr = Console.ReadLine() ?? "3";
                if (!double.TryParse(umbralStr.Replace(',', '.'),
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture,
                        out umbral))
                {
                    LOGGER.Error($"Umbral no valido introducido: '{umbralStr}'. Se usara 3%.");
                    mostrarerror("Valor de umbral no valido. Se usara el 3% por defecto.");
                    umbral = 3.0;
                }
            }
            catch (Exception ex)
            {
                LOGGER.Error($"ERROR al leer el umbral: {ex.Message}");
                umbral = 3.0;
            }

            // CALC total votos
            int totalVotos = 0;
            for (int i = 0; i < numPartidos; i++)
                totalVotos += votos[i];

            if (totalVotos == 0)
            {
                LOGGER.Error("Total de votos es 0. No se puede calcular el reparto.");
                mostrarerror("El total de votos es 0. No es posible calcular el reparto.");
                return;
            }
            // calcular cocientes D'Hondt filtrando por umbral
            double[] cocientes = new double[numPartidos * totala];
            int[] partidoZZ = new int[numPartidos * totala];
            int pos = 0;

            for (int i = 0; i < numPartidos; i++)
            {
                double porcentaje = (double)votos[i] / totalVotos * 100.0;
                if (porcentaje < umbral)
                    continue; // excluido por no superar el umbral

                for (int d = 1; d <= totala; d++)
                {
                    cocientes[pos] = (double)votos[i] / d;
                    partidoZZ[pos] = i;
                    pos++;
                }
            }

            if (pos == 0)
            {
                LOGGER.Error("ningun partido supera el umbral minimo");
                mostrarerror("ningun partido supera el umbral minimo // no se puede repartir ningun escaño");
                return;
            }

            //ordenar de menor a mayor 
            for (int i = 0; i < pos - 1; i++)
            {
                for (int j = i + 1; j < pos; j++)
                {
                    if (cocientes[j] > cocientes[i])
                    {
                        double tmpC = cocientes[i]; cocientes[i] = cocientes[j]; cocientes[j] = tmpC;
                        int tmpP = partidoZZ[i]; partidoZZ[i] = partidoZZ[j]; partidoZZ[j] = tmpP;
                    }
                }
            }

            // ASIGNAR escañoss
            int[] escañosPartido = new int[numPartidos];
            int escañosasignados = Math.Min(totala, pos);

            for (int i = 0; i < escañosasignados; i++)
            {
                escañosPartido[partidoZZ[i]]++;
                //porfavor dioses del c# q funcione
            }
            //resulktados
            Console.WriteLine(" ----------- resultado----------- ");
            Console.WriteLine($"\n total votos: {totalVotos}");
            Console.WriteLine($"escaños q se juegan: {totala}");
            Console.WriteLine($"  Umbral aplicado: {umbral}%\n");

                     for (int i = 0; i < numPartidos; i++)
            {
                double calculiño = (double)votos[i] / totalVotos * 100.0;
                bool excluido = calculiño < umbral;
 
                if (excluido)
                    Console.WriteLine($"  x {nombres[i]} - {votos[i]} votos ({calculiño:F2}%) -> EXCLUIDO (no supera el {umbral}%)");
                else
                    Console.WriteLine($"  * {nombres[i]} - {votos[i]} votos ({calculiño:F2}%) -> {escañosPartido[i]} escaño/escaños");
            }
 
            LOGGER.info($"Calculadora: {numPartidos} partidos, {totala} escaños, umbral {umbral}%.");
        }
 
        

        // Menu principal

        static void menuprincipal()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║  Bienvenido a ElectroTrack version nomepagan.trojano.exe║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");
            Console.WriteLine(" si presiona algun numero de los disponibles, podra acceder a la información deseada.");
            Console.WriteLine("1. ¿Cómo funciona la Ley D'Hondt? y como funciona el sistema electoral");
            Console.WriteLine("2. Partidos políticos principales");
            Console.WriteLine("3. Elecciones pasadas y resultados");
            Console.WriteLine("4. Casos de corrupción destacados");
            Console.WriteLine("5. Ver historial de consultas");
            Console.WriteLine("6. Calculadora D'Hondt interactiva  [NUEVO]");
            Console.WriteLine("7. Salir");
        }

        static void continuallalala()
        {
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        // formato de registros como su nombre indica registra la consulta

        static void RegistrarConsulta(string tema)
        {
            List<string> consulta = new List<string>
            {
                tema,
                // CORRECCIÓN LÓGICA: formato de fecha corregido (era "yyyy-dd-MM", día y mes estaban invertidos)
                DateTime.Now.ToString("yyyy-MM-dd")
            };
            consultasRealizadas.Add(consulta);
        }
        // 
        static int entradausuarionum(string mensaje)
        {
            int numero = 0;
            bool valido = false;

            while (!valido)
            {

                // recordatiorio hacer algo para q no devuelva null
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                try
                {
                    numero = Convert.ToInt32(entrada);
                    valido = true;
                }
                catch (FormatException ex)
                {
                    LOGGER.Error($" entrada no numerica recuibida: '{entrada}' - {ex.Message}");
                    mostrarerror("entrada invalida, SELECCIONA UN NUMERO DE LOS QUE PONE NO EL QUE TU QUIERAS o si no te borro el system 32 :).");
                }
                  catch (OverflowException ex)
                {
                    LOGGER.Error($"Numero demasiado grande: '{entrada}' — {ex.Message}");
                    mostrarerror("El numero introducido es demasiado grande.");
                }
            }

            return numero;
        }

        static void mostrarerror(string mensaje)
        {
            Console.WriteLine($"\n[Error] {mensaje}");
        }
    }
}
