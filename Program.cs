/*3.1 Ejercicio par
Crear una Clase para llevar la información de los empleados del departamento de almacén de una hipertienda.  
Como este desarrollo se escalará al resto de la organización, la Clase a desarrollar debe extender a una Clase base Empleados que se usará posteriormente 
para los empleados de los otros departamentos de la empresa.  
Esta Clase debe permitir el ingreso de los datos básicos del empleado así como los datos particulares inherentes a las funciones de su departamento 
(recepción y envío de mercancías, control de calidad, inventario etc.).
Por temas de seguridad, el acceso a los atributos de la Clase debe ser privado, por lo que necesitará de implementar los mecanismos adecuados para el ingreso de datos. 
Además, es de suma importancia que considere el atributo 'salario' y evitar que un empleado le sea asignado '0' o un valor negativo.
La Clase solicitada debe ser instanciada desde el programa principal para verificar su ejecución */

using System;

namespace Program
{

class empleados {

    // Como es las clase base, sólo ponemos los atributos estándar de un empleado cualquiera y luego es que se crea la subclase para el dpto de almacén en privado.
    private string nombre;
    private int edad;
    private float salario;
    
    // Se aplican las funciones de cada atributo que sí será manipulado durante el uso del programa.
    public string Nombre 
    {
        get { return nombre; }
        set { nombre = value; }

    }
    public int Edad
    {
       get { return edad; }
       set { 
             if (value < 18) {
                 Console.WriteLine("Debe haber un número válido de edad. "); 
                 } else { edad = value; }
           }
    }
    public float Salario
    {
       get { return salario; }
       set {
             if (value <= 0) { 
                 Console.WriteLine("El número de salario del empleado no es válido. ");
                 } else { salario = value; }
           }
    }

 }

class EmpAlmacen : empleados {
      private int recepcion;
      private int envio;
      private string contcalidad;
      private int inventario; 
    
      public int Recepcion {
          get { return recepcion; }
          set { recepcion = value; }
      }

      public int Envio {
          get { return envio; }
          set { envio = value; }
      } 

      public string Contcalidad {
          get { return contcalidad; }
          set { contcalidad = value; }
      }
      
      public int Inventario {
          get { return inventario; }
          set { inventario = value; }
      }
 }
 class ProgrEmpAlmacen {
     static void Main(string [] args) {
         EmpAlmacen e = new EmpAlmacen();
         Console.WriteLine("Nombre del empleado: ");
         e.Nombre = Console.ReadLine();
         Console.WriteLine("Edad del empleado: ");
         e.Edad = System.Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ingrese su salario (Debe estar por encima de 0, no sea tacaño ;) ): ");
         e.Salario = System.Convert.ToSingle(Console.ReadLine());
         Console.WriteLine("Cuantos productos ha recibido?: ");
         e.Recepcion = System.Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Cuantos productos ha enviado?: ");
         e.Envio = System.Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Como ha sido su rendimiento en el trabajo? Opciones: Muy bueno, Bueno, Medio, Malo: ");
         e.Contcalidad = Console.ReadLine();
         Console.WriteLine("Cuantos objetos hay en el inventario?: ");
         e.Inventario = System.Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("\n Datos del empleado \n");
         Console.WriteLine("Nombre: {0}", e.Nombre);
         Console.WriteLine("Edad: {0}", e.Edad);
         Console.WriteLine("Salario {0}", e.Salario);
         Console.WriteLine("Productos Recibidos: {0}", e.Recepcion);
         Console.WriteLine("Productos Enviados: {0}", e.Envio);
         Console.WriteLine("Desempeño en el trabajo: {0}", e.Contcalidad);
         Console.WriteLine("Productos en el inventario: {0}", e.Inventario);
        }
    }
}
