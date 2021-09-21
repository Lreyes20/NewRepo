using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    class Program
    {
        #region Menu

        private const string MenuPrincipal = "" +
                       
                        "******************************** *\n" +
                        "*                                *\n" +
                        "*  E M P R E S A  E L  F A R O   *\n" +
                        "*                                *\n" +
                        "**********************************\n" +
                        "* 1) Registrar Articulo          *\n" +
                        "* 2) Registrar Vendedor          *\n" +
                        "* 3) Realizar Venta de Articulo *\n" +
                        "* 4) Cunsultar Inventario        *\n" +
                        "* 5) Actualizar Inventario       *\n" +
                        "* 6) Consultar Inventario        *\n" +
                        "* 7) Salir                       *\n" +
                        "*                                *\n" +
                        "**********************************\n ";

        #endregion

        #region Main

        static void Main(string[] args)
        {
            int op = 0;


            do
            {
                Console.Clear();
                Console.WriteLine(MenuPrincipal);
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Error, digite variables numericas");
                    Console.WriteLine("Por favor digite enter para continuar");
                    Console.ReadLine();
                }
                else
                {
                    switch (op)
                    {
                        case 1:
                        //RegistrarArticulo;
                        break;
                       
                        case 2:
                            //RegistrarVendedor;
                            break;

                        case 3:
                            //RealizarVentadeRticulo;
                            break;

                    case 4:
                            //ConsultarVentas;
                            break;
                    case 5:
                            //ActualizarInvetario;
                            break;
                    case 6:
                            //ConsultarInventario
                        break;
                    case 7:
                            //Salir;
                        break;

                    default:
                        Console.WriteLine("Digite una opción del 1 al 7");
                        Console.WriteLine("Por favor digite enter para continuar");
                        Console.ReadLine();
                        break;


                    }

                }
            } while (op != 7);


        }

        #endregion
    }
}
