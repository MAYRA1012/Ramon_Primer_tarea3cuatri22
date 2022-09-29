using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramon_Tarea13cuatri
{
    class Class1
    {
        static float[] placa = new float[10];
        static string[] tipo_veh = new string[10];
        static float dato ;
        static float[] Hora_Ing = new float[10];
        static float[] Hora_fin = new float[10];
        static float[] Precio = new float[10];
        static int indice = 0;






        public void menu2()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1 - Ingresar Paso Vehicular");
                Console.WriteLine("2 - Consulta de vehículos x Número de Placa");
                Console.WriteLine("6 - Modificar Datos Vehículos x número de Placa");
                Console.WriteLine("4 - Reporte Todos los Datos de los vectores");
                Console.WriteLine("5 - Salir");
                Console.Write("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Agregar(); break;
                    //  case 2: Calculo(); break;
                    case 2: Consultar3(); break;
                    case 3: modificar(); break;
                    case 4: Reporte(); break;


                    default:
                        break;
                }
            } while (opcion != 5);

        }

        public static void Agregar()
        {
            int opcion = 0;
            int dato;
            try
            {
                do
                {




                    Console.WriteLine("Digite la placa del Vehiculo");
                    placa[indice] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tipo de Vehiculo (1= Moto(500) ,2= Vehículo Liviano(1000), 3 =Camión o Pesado(2000) 4=Autobús(2000))");
                    dato= Convert.ToInt32(Console.ReadLine());


                    if (dato ==1) 
                    {

                        tipo_veh[indice] ="Moto";
                        Precio[indice] = 500;
                    }

                    if (dato == 2)
                    {

                        tipo_veh[indice] = "Liviano";
                        Precio[indice] = 1000;

                    }
                    if (dato == 3)
                    {

                        tipo_veh[indice] = "Pesado";
                        Precio[indice] = 2000;

                    }
                    if (dato == 4)
                    {

                        tipo_veh[indice] = "Bus";
                        Precio[indice] = 2000;

                    }



                   // tipo_veh[indice] = Console.ReadLine();
                    Console.WriteLine("Digite la Hora de ingreso ");
                    Hora_Ing[indice] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite La Hora de salida");
                    Hora_fin[indice] = Convert.ToInt32(Console.ReadLine());
                   /* Console.WriteLine("Digite el Precio unitario Automovil");
                    Precio[indice] = Convert.ToInt32(Console.ReadLine());*/
                    indice++;
                    Console.WriteLine("Desea continuar 1-Si o 2-No");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } while (opcion >= 1 && opcion != 2);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ya no puede ingresar mas Articulos");

                indice = 4;
            }
            finally
            {
                Console.WriteLine("Mensaje de finally");

            }

        }


        public int Consultar()
        {
            //int posicion;
            // posicion = 0;
            int i = 0;   // indice para recorrer el arreglo
            Console.WriteLine("Digite la calve del Automovil:");
           // string placa = Console.ReadLine();
            float Placa = Convert.ToInt32(Console.ReadLine());

            while ((i <= indice) && (!Placa.Equals(placa[i])))
            {
                i++;
            }

            if (i > indice - 1)
            {
                i = -1;   // 
            }
            return i;
        }



        public int Consultar2()
        {
            int posicion;
            posicion = 0;
            int i = 0;   // 
            Console.WriteLine("Digite la tipo_veh del Articulo:");
            string nombre = Console.ReadLine();

            while ((i < indice) && (!nombre.Equals(tipo_veh[i])))
            {
                i++;
            }

            if (i > indice - 1)
            {
                i = -1;   //
            }
            return i;
        }

        public void Consultar3()
        {
            int pos2 = Consultar();
            //porciento = 0;
            float PORC = 0;



            if (pos2 < 0)
            {
                Console.WriteLine("El Automovil no existe");
            }
            else
            {
                Console.WriteLine("placa  tipo_veh Hora_Ing Hora_fin Precio");
                
                   
                        Console.WriteLine($"{placa[pos2]}  {tipo_veh[pos2]}  {Hora_Ing[pos2]}  { Hora_fin[pos2]}  { Precio[pos2]} ");

                        //Console.WriteLine($"{placa[i]}  {tipo_veh[i]}");
                    

               
            }
               



            
        }














        public void Reporte()
        {
            Console.WriteLine("placa  tipo_veh Hora_Ing Hora_fin Precio");
            for (int i = 0; i < indice; i++)
            {
                if (!placa[i].Equals(""))
                {
                    Console.WriteLine($"{placa[i]}  {tipo_veh[i]}  {Hora_Ing[i]}  { Hora_fin[i]}  { Precio[i]} ");

                    //Console.WriteLine($"{placa[i]}  {tipo_veh[i]}");
                }

            }
            Console.WriteLine("-------------------------------");
        }


        public void modificar()
        {
            int pos = Consultar();
            //porciento = 0;
            float PORC = 0;



            if (pos < 0)
            {
                Console.WriteLine("El Automovil no existe");
            }
            else
            {
                Console.WriteLine("Ingrese El Procentaje del Precio");
                float porciento = Convert.ToInt32(Console.ReadLine());
                PORC = porciento / 100;
                Precio[pos] = Precio[pos] + (Precio[pos] * PORC);


                Console.WriteLine("Registro ha sido actualizado");
            }
        }


        public void Reabastecer()
        {
            int pos = Consultar();
            float compra = 0;
            float nuevo = 0;


            if (pos < 0)
            {
                Console.WriteLine("El Automovil no existe");
            }
            else
            {
                Console.WriteLine("Ingrese la cantida Comprada");
                compra = int.Parse(Console.ReadLine());

                nuevo = compra + Hora_Ing[pos];

                Hora_Ing[pos] = nuevo;


                Console.WriteLine("Registro ha sido actualizado");
            }
        }


















    }
}
