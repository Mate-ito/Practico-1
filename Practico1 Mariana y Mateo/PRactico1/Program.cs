using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PRactico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulos[] Compras = new Articulos[99];
         
            bool Salida = true;
            string Item;
            int Contador = 0;
            int CostoTotal = 0;
            string Nombre;
            string Direccion;
            int Cedula;
            string CompraEmpresa;
            string NombreEmpresa = "";

            Console.WriteLine("Ingrese Nombre:");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Direccion:");
            Direccion = Console.ReadLine();

            Console.WriteLine("Ingrese su Cedula:");
            Cedula = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Compra Empresarial? 1) si 2) no");
            CompraEmpresa = Console.ReadLine();

            switch (CompraEmpresa)
            {
                case "1":
                    Console.WriteLine("Ingrese Nombre de la empresa: ");
                    NombreEmpresa = Console.ReadLine();
                    break;
                default:
                
                    break;
            }

            do
            {
                Console.WriteLine("Catalogo De Productos");
                Console.WriteLine("1) Computadora -- $1500");
                Console.WriteLine("2) Mouse -- $200");
                Console.WriteLine("3) Auriculares -- $500");
                Console.WriteLine("4) Pad -- $100");
                Console.WriteLine("5) Monitor -- $800");
                Console.WriteLine("6) Microfono -- $750");
                Console.WriteLine("7) Parlantes -- $975");
                Console.WriteLine("8) Control -- $490");
                Console.WriteLine("9) Pendrive -- $75");

                Console.WriteLine("Selecione articulos a comprar");
                Item = Console.ReadLine();

                switch (Item)
                {
                    case "1":
                        Compras[Contador] = new Articulos("Computadora", "Rojo", "HP", 1500);
                        break;
                    case "3":
                        Compras[Contador] = new Articulos("Auriculares", "Azul", "HP", 500);
                        break;
                    case "2":
                        Compras[Contador] = new Articulos("Mouse", "Rojo", "HP", 200);
                        break;
                    case "4":
                        Compras[Contador] = new Articulos("Pad", "Amerillo", "HP", 100);
                        break;
                    case "5":
                        Compras[Contador] = new Articulos("Monitor", "Negro", "HP", 800);
                        break;
                    case "6":
                        Compras[Contador] = new Articulos("Microfono", "Negro", "HP", 750);
                        break;
                    case "7":
                        Compras[Contador] = new Articulos("Parlantes", "Rojo", "HP", 975);
                        break;
                    case "8":
                        Compras[Contador] = new Articulos("Control", "Blanco", "HP", 490);
                        break;
                    case "9":
                        Compras[Contador] = new Articulos("Pendrive", "Verde", "HP", 75);
                        break;
                    default:
                        Console.WriteLine("Usted no seleciono ningun articulo");
                        break;
                }
                Contador = Contador + 1;
                Console.WriteLine("¿Desea hacer otra compra? 1)si 2)no");
                string NuevaCompra =  Console.ReadLine();

                switch (NuevaCompra)
                {
                    case "2":
                        Salida = false;
                        break;
                    default:
                        Salida = true;
                        break;
                }
        
            } while (Salida == true);
            for (int i = 0; i < Contador; i++)
            {
                Console.WriteLine(Compras[i].getInfo());
            }

            for (int i = 0; i < Contador; i++)
            {
                CostoTotal = Int32.Parse(Compras[i].getPrecio()) + CostoTotal; 
            }

            if (CompraEmpresa == "1")
            {
              
                Empresa CompradorEmpresa = new Empresa(Nombre, Direccion, Cedula, NombreEmpresa);
               CompradorEmpresa.OrdenDePago(CostoTotal);
                CompradorEmpresa.InfoEnvio();

            }
            else
            {
                Cliente Comprador = new Cliente(Nombre, Direccion, Cedula);
                Comprador.Factura(CostoTotal);
                Comprador.InfoEnvio();
            }


        }
        class Articulos
        {
            private string a;
            private string b;
            private string c;
            private int d;

            public Articulos(string a, string b, string c, int d)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
            }
            public string getInfo()
            {
                return $"{a} {b} {c} {d} ";
            }
            public string getPrecio()
            {
                return $" {d} ";
            }
            public string getNombre()
            {
                return $" {a} ";
            }
            public string getColor()
            {
                return $" {b} ";
            }
            public string getMarca()
            {
                return $" {c} ";
            }
            public void setInfo(string a,string b,string c, int d)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
            }
            public void setPrecio(int d)
            {
                this.d = d;
            }
            public void setNombre(string a)
            {
                this.a = a;
            }
            public void setColor(string b)
            {
                this.b = b;
            }
            public void setMarca(string c)
            {
                this.c = c;
            }
        }

        class Cliente 
        {
            Random rnd = new Random();
             private string Nombre;
             private string Direccion;
             private int Cedula;
             private int NumAleatorio;
             
             
            public Cliente(string Nombre, string Direccion, int Cedula) 
            {
                this.Nombre = Nombre;
                this.Direccion = Direccion;
                this.Cedula = Cedula;
                NumAleatorio = rnd.Next(10000,10000001);
            }

            public void Factura(int CostoTotal) 
            {
                 Console.WriteLine("El costo total de la factura es: " + CostoTotal);
            }

            public void InfoEnvio() 
            {
                Console.WriteLine("El envio se realizara a la direccion: " + Direccion + " y el codigo de envio es: " + NumAleatorio);
            }

            public void getCliente() 
            {
              Console.WriteLine( Nombre + " " +Direccion + " " + Cedula + " " + NumAleatorio);
            }
            public void getClienteNombre()
            {
                Console.WriteLine(Nombre);
            }
            public void getClienteDireccion()
            {
                Console.WriteLine( Direccion );
            }
            public void getClienteCedula()
            {
                Console.WriteLine( Cedula );
            }
            public void getClienteNumAleatorio()
            {
                Console.WriteLine(NumAleatorio);
            }
            public void setCliente(string Nombre , string Direccion,int Cedula,int NumAleatorio)
            {
                this.Nombre = Nombre;
                this.Direccion = Direccion;
                this.Cedula = Cedula;
                this.NumAleatorio = NumAleatorio;
            }
            public void setClienteNombre(string Nombre)
            {
                this.Nombre = Nombre;
            }
            public void setClienteDireccion(string Direccion)
            {
                this.Direccion = Direccion;
            }
            public void setClienteCedula(int Cedula)
            {
                this.Cedula = Cedula;
            }
            public void setClienteNumAleatorio(int NumAleatorio)
            {
                this.NumAleatorio = NumAleatorio;
            }


        }
        class Empresa : Cliente
        {
            private string NombreEmpresa;
            public Empresa(string Nombre, string Direccion, int Cedula, string NombreEmpresa) : base(Nombre, Direccion, Cedula)
            {
                 this.NombreEmpresa = NombreEmpresa;
        }

            public void OrdenDePago(int CostoTotal)
            {
                Console.WriteLine("Ingrese codigo de orden de pago de " + NombreEmpresa + " : ");
                Console.ReadLine();
                
            }
            public void setNombreEmpresa(string NombreEmpresa)
            {
                this.NombreEmpresa = NombreEmpresa;
            }
            public void getNombreEmpresa()
            {
                Console.WriteLine(NombreEmpresa);
            }
        }
    }
}
