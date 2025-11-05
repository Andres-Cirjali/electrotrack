using System;
using System.Collections.Generic;

namespace ElectroTrack
{
    class Program
    {
        static List<List<string>> consultasRealizadas = new List<List<string>>();

        static void Main(string[] args)
        {
            EjecutarPrograma();
        }

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
                        Console.WriteLine("¡Gracias por usar ElectroTrack!");
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

        static void LeyDHont()
        {
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

            RegistrarConsulta("Ley D'Hondt");
        }

        static void PartidosPoliticos()
        {
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

        static void EleccionesPasadas()
        {
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

        static void CasosCorrupcion()
        {
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

            if (opcion >= 1 && opcion <= casos.Length)
            {
                RegistrarConsulta($"Corrupción: {casos[opcion - 1]}");
            }
            else if (opcion != 0)
            {
                mostrarerror("Opción no válida.");
            }
        }

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

        // Menu principal 

        static void menuprincipal()
        {
            Console.WriteLine("╔════════════════════════════════════════════════════╗");
            Console.WriteLine("║  Bienvenido a ElectroTrack version 67.trojano.exe║");
            Console.WriteLine("╚════════════════════════════════════════════════════╝");
            Console.WriteLine(" si presiona algun numero de los disponibles, podra acceder a la información deseada.");
            Console.WriteLine("1. ¿Cómo funciona la Ley D'Hondt? y como funciona el sistema electoral");
            Console.WriteLine("2. Partidos políticos principales");
            Console.WriteLine("3. Elecciones pasadas y resultados");
            Console.WriteLine("4. Casos de corrupción destacados");
            Console.WriteLine("5. Ver historial de consultas");
            Console.WriteLine("6. Salir");
        }

        static void continuallalala()
        {
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        // formato de registros

        static void RegistrarConsulta(string tema)
        {
            List<string> consulta = new List<string>
            {
                tema,
                DateTime.Now.ToString("yyyy-dd-MM")
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
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                try
                {
                    numero = Convert.ToInt32(entrada);
                    valido = true;
                }
                catch
                {
                    mostrarerror("entrada invalida, SELECCIONA UN NUMERO DE LOS QUE PONE NO EL QUE TU QUIERAS o si no te borro el system 32 :).");
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
