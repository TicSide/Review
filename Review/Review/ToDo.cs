using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Review
{
    internal class ToDo
    {
        public string path = "example.txt";
        public string content = "Hello, World!\nThis is a new line of text.";
        public void menuToDo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("====================================");
            Console.WriteLine("        TO-DO LIST POR CONSOLA");
            Console.WriteLine("====================================");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("1. Ver tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Marcar tarea como completada");
            Console.WriteLine("4. Eliminar tarea");
            Console.WriteLine("5. Guardar y salir");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Seleccione una opción: ");
        }

        public void menuWatchTasks()
        {
            Console.WriteLine("=========== LISTA DE TAREAS ===========");
            Console.WriteLine("");
            Console.WriteLine("ID   DESCRIPCIÓN              ESTADO        FECHA");
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Presione ENTER para volver al menú...");
            Console.Clear();
        }
        public void getInfoTasks()
        {
        }


        public void menuAddTasks()
        {
            Console.WriteLine("=========== AGREGAR TAREA ===========");
            Console.WriteLine("");
            Console.WriteLine("Ingrese la descripción de la tarea:");
            Console.Write("> ");
            Console.WriteLine("");
            Console.WriteLine("Tarea agregada correctamente.");
            Console.WriteLine("");
            Console.Write("ID: ");
            Console.ReadLine();
            Console.Write("Descripción: ");
            Console.ReadLine();
            Console.Write("Estado: ");
            Console.ReadLine();
            Console.Write("Fecha: ");
            Console.ReadLine();
        }

        public void menuCompleteTasks()
        {
            Console.WriteLine("====== MARCAR TAREA COMO COMPLETADA ======");
            Console.WriteLine();
            Console.WriteLine("Ingrese el ID de la tarea: ");
            Console.Write("> ");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(" La tarea {0} fue marcada como completada.");
        }

        public void menuRemoveTasks()
        {
            Console.WriteLine("=========== ELIMINAR TAREA ===========");
            Console.WriteLine();
            Console.WriteLine("Ingrese el ID de la tarea que desea eliminar: ");
            Console.Write("> ");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(" La tarea {0} fue eliminada correctamente.");
        }
    }
}
