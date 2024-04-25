using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Net.WebRequestMethods;
using System.Security.Policy;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading;



// La información general sobre un ensamblado se controla mediante lo siguiente
// conjunto de atributos. Cambie los valores de estos atributos para modificar la información
// asociada a un ensamblado.
[assembly: AssemblyTitle("ProductStore")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ProductStore")]
[assembly: AssemblyCopyright("Copyright ©  2024")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Si configura ComVisible como falso, los tipos de este ensamblado no se hacen visibles
// para componentes COM.  Si necesita acceder a un tipo de este ensamblado desde
// COM, establezca el atributo ComVisible en true en este tipo.
[assembly: ComVisible(false)]

// El siguiente GUID es para el ID. typelib cuando este proyecto esté expuesto a COM
[assembly: Guid("fed0f2e4-5831-4232-b7c4-447b0ce0a4ac")]

// La información de versión de un ensamblado consta de los siguientes cuatro valores:
//
//      Versión principal
//      Versión secundaria
//      Número de compilación
//      Revisión
//
// Puede especificar todos los valores o puede predeterminar los números de compilación y de revisión
// mediante el carácter '*', como se muestra a continuación:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

//class Program
//{
//    static async Task Main()
//    {
//        using (HttpClient client = new HttpClient())
//        {
//            HttpResponseMessage response = await client.GetAsync("http://localhost:54529/api/admin");

//            if (response.IsSuccessStatusCode)
//            {
//                string responseBody = await response.Content.ReadAsStringAsync();
//                Console.WriteLine(responseBody); // Hacer algo con la respuesta de la página
//            }
//            else
//            {
//                Console.WriteLine("Error en la solicitud: " + response.StatusCode);
//            }
//        }
//    }
//}