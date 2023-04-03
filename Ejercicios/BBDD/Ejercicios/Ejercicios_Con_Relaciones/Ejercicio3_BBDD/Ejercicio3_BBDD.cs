using Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD
{
    public class Ejercicio3_BBDD
    {
        BankMethod bank;
        ClientMethod client;
        public Ejercicio3_BBDD(dbContextEjerciciosRelaciones db)
        {
            bank = new BankMethod(db);
            client = new ClientMethod(db);
        }

        public async Task BucleAsync()
        {
            do
            {
                Console.WriteLine("\n1-Crear un cliente \n2-Inciar Sesión");
                int acciones = Convert.ToInt32(Console.ReadLine());

                switch (acciones)
                {
                    #region Crear Cuenta Cliente
                    case 1:
                        #region New Client
                        Cliente newClient = new Cliente();
                        Console.WriteLine("\nDime tu nombre");
                        newClient.Nombre = Console.ReadLine();

                        Console.WriteLine("\nEscribe una contraseña");
                        newClient.ContraseñaHash = Console.ReadLine();

                        client.AddAsync(newClient);
                        var cliente = client.GetClientByNameAndPassword(newClient.Nombre, ComputeHash(newClient.ContraseñaHash));
                        #endregion

                        #region New Bank Account
                        BankAccount newBank = new BankAccount();
                        Console.WriteLine("\nPrimer ingreso");
                        var ingreso = Convert.ToInt32(Console.ReadLine());

                        newBank.Ingreso = ingreso;
                        newBank.Saldo = ingreso;
                        newBank.ClientId = cliente.Id;

                        bank.CreateAccountAsync(newBank);
                        #endregion
                        break;
                    #endregion

                    #region Inciar Sesión
                    case 2:

                        #region Comprobar Usuario
                        Console.WriteLine("\nDime tu nombre");
                        var name = Console.ReadLine();

                        Console.WriteLine("\nDime tu contraseña");
                        var contraseña = Console.ReadLine();

                        var clienteLogin = client.GetClientByNameAndPassword(name, ComputeHash(contraseña));
                        if (clienteLogin == null)
                        {
                            Console.Clear();
                            Console.WriteLine("\nUsuario o Contraseña Incorrectos");
                            break;
                        } 
                        #endregion

                        do
                        {
                            Console.WriteLine("\n1-Añadir fondos \n2-Retirar fondos \n3-Listar ingresos \n4-Listar retiradas \n5-Listar movimientos \n6-Eliminar Cuenta \n7-Salir");
                            acciones = Convert.ToInt32(Console.ReadLine());

                            switch (acciones)
                            {
                                #region Crear nuevo Ingreso
                                case 1:
                                    BankAccount newIngreso = new BankAccount();
                                    Console.WriteLine("\nCuanto quieres ingresar?");
                                    var ingresar = Convert.ToInt32(Console.ReadLine());

                                    newIngreso.Ingreso = ingresar;
                                    newIngreso.Saldo = 0;
                                    newIngreso.ClientId = clienteLogin.Id;

                                    await bank.IngresoAsync(newIngreso);
                                    break;
                                #endregion

                                #region Crear nueva Retirada
                                case 2:
                                    BankAccount newRetirada = new BankAccount();
                                    Console.WriteLine("\nCuanto quieres retirar?");
                                    var retirada = Convert.ToInt32(Console.ReadLine());

                                    newRetirada.Retirada = retirada;
                                    newRetirada.Saldo = 0;
                                    newRetirada.ClientId = clienteLogin.Id;

                                    await bank.RetiradaAsync(newRetirada);
                                    break;
                                #endregion

                                #region Listar ingresos
                                case 3:
                                    bank.GetListIngresosClient(clienteLogin.Id);
                                    break;
                                #endregion

                                #region Listar retiradas
                                case 4:
                                    bank.GetListRetiradasClient(clienteLogin.Id);
                                    break;
                                #endregion

                                #region Listar movimientos
                                case 5:
                                    bank.GetListMovimentClient(clienteLogin.Id);
                                    break;
                                #endregion

                                #region Eliminar Cuenta
                                case 6:
                                    bank.DeleteAccountBank(clienteLogin.Id);
                                    client.DeleteClient(clienteLogin.Id);
                                    break; 
                                    #endregion
                            }
                        } while (acciones != 7 && acciones < 7);

                        break;
                    #endregion
                }

            } while (true);
        }

        private string ComputeHash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                //convierte la cadena de entrada en una matriz de bytes utilizando la codificación UTF-8.
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                //calcula el hash de la matriz de bytes de entrada utilizando el algoritmo MD5 y devuelve el resultado como una matriz de bytes.
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder stringB = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    //Agrega el byte actual a la cadena de salida en formato hexadecimal.
                    stringB.Append(hashBytes[i].ToString("X2"));
                }

                return stringB.ToString();
            }
        }
    }
}
