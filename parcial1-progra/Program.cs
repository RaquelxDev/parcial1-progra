//METODOS Y PROPIEDADES
//METODOS
/*
//Length
string nombre = "Raquel";
int longitud = nombre.Length;
Console.WriteLine(longitud); //Esto imprime 6

//ToUpper
string dulce = "chocolate";
string mayuscula = dulce.ToUpper();//Crea nueva cadena convertido a mayúscilas
Console.WriteLine(mayuscula);//Esto imprime CHOCOLATE

//ToLower()
string dulce = "CHOCOLATE";
string minuscula = dulce.Tolower(); //Crea nueva cadena convertido a minúscula
Console.WriteLine(minuscula);//Esto imprime chocolate

//IndexOf()
string dulce = "Chocolate";
int posicion = dulce.IndexOf('a') //El parámetro es la letra que queremos buscar
Console.WriteLine(posicion); //Esto imprime 6, porque la primera "a" está en la 
                             //sexta posición, y se empieza a contar desde 0

//LasIntdexOf()
string fruta = "Manzana";
int posicion = fruta.LastIndexOf('a'); //El parámetro es el carácter que vamos a buscar
Console.WriteLine(posicion); //Esto imprime 6, porque la última "a" está en la sexta
                             //posición, y se empieza a ocntar desde 0

//Substring()
string dulce = "chocolate", parte;
parte = dulce.Subtring(0, 3); //El primer número es la posición
                              //donde empieza la parte, y el segundo número
                              //es cuántas letras se quiere extraer
Console.WriteLine(parte);     //Esto imprime cho

//Replace()
string dulce = "Chocolate";
string reemplazo = dulce.Replace('a', 'e'); //El primer parámetro es la letra que
                                            //se reemplazara, y el segundo parámetro
                                            //es la letra por la que queremos reemplazar
Console.WriteLine(reemplazo); //Esto imprime Chocolete

//trim()
string saludo = "Hola Mundo";
string sinEspacios = saludo.Trim(); //Crea nueva cadena sin los espacios iniciales y finales
Console.WriteLine(sinEspacios); //Esto imprimiria Hola Mundo

// StartsWith():
string aparato = "Telefono";
bool empieza = aparato.StartsWith("Tel"); //El parámetro es la cadena a comprobar
Console.WriteLine(empieza); //Esto imprime true, porque "Telefono" empieza por "Tel"

//EndsWith()
string aparato = "Telefono";
bool termina = aparato.EndsWith("fono"); //El parámetro es la cadena a comprobar
Console.WriteLine(termina); //Imprimiria true, porque "telefono" termina con "fono"

//PROPIEDADES
//Length
string nombre = "Raquel";
int longitud = nombre.Length;
Console.WriteLine(longitud); //Esto imprime 6

//Lista de números
List<int> numeros = new List<int>() { 1, 2, 3 };
//Comprobar si la lista es de solo lectura
Console.WriteLine("la lista es de solo lectura: {0},
    ((ICollection<int>)numeros).IsReadOnly);

//Chars
string saludo = "hola";
char primerCaracter = saludo[0]; // Asigna el valor 'H' a la variable primerCaracter
Console.WriteLine((primerCaracter); //imprime H en la consola

//Empty
string vacia = String.Empty; //asigna una cadena vacía a la variable vacia
bool esVacia = vacia == String.Empty; // comprueba si la cadena es vacía
Console.WriteLine(esVacia); // imprimiria true

//Format
string nombre = "Raquel";
int edad = 19;
string saludo = String.Format("Hola, me llamo {0} y tengo {1} años", nombre, edad);
//Crea una cadena formateada con los valores de las variables nombre y edad
Console.WriteLine(saludo); //imprimiria: Hola me llamo Raquel y tengo 19 años.

//Compare
string[] nombres = { "Karla", "Maritza", "Olga" };
Array.Sort(nombres, StringComparer.OrdinalIgnoreCase);
//ordena el array de cadenas ignorando las mayúsculas y minúsculas
foreach (string nombre in nombres)
{
    Console.WriteLine(nombre); //imprimiria Karla, Maritza, Olga
}


//OPERACIONES CON CADENAS
//Comparación de Cadenas
// 1 - Pedir al usuario dos cadenas
Console.WriteLine("\n1 - Pedir al usuario dos cadenas");
Console.WriteLine("\nIngrese la primera cadena:");
string cadena1 = Console.ReadLine()!;
Console.WriteLine("\nIngrese la segunda cadena:");
string cadena2 = Console.ReadLine()!;

// Comparar las cadenas usando el método CompareTo
int resultadow = cadena1.CompareTo(cadena2);

//  Mostrar el resultado de la comparación
if (resultadow == 0)
{
    Console.WriteLine("\nLas cadenas son iguales.");
}
else if (resultadow < 0)
{
    Console.WriteLine("\nLa primera cadena es menor que la segunda.");
}
else
{
    Console.WriteLine("\nLa primera cadena es mayor que la segunda.");
}
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();


//Contatenación de Cadenas
// 2 - Pedir al usuario su nombre y su apellido
Console.WriteLine("\n2 - Pedir al usuario su nombre y su apellido");
Console.WriteLine("\nIngrese su nombre:");
string nombrem = Console.ReadLine()!;
Console.WriteLine("\nIngrese su apellido:");
string apellido = Console.ReadLine()!;

// Concatenar el nombre y el apellido usando el operador +
string nombreCompleto = nombrem + " " + apellido;

// Mostrar un saludo con el nombre completo
Console.WriteLine("\nHola, " + nombreCompleto + ". Bienvenida.");
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();


//Busqueda de Patrones
// 3 - Pedir al usuario una cadena y un carácter
Console.WriteLine("\n3 - Pedir al usuario una cadena y un carácter");
Console.WriteLine("\nIngrese una cadena:");
string cadenat = Console.ReadLine()!;
Console.WriteLine("\nIngrese un carácter:");
char caractert = Console.ReadKey().KeyChar;

// Buscar el carácter en la cadena usando el método IndexOf
int indice = cadenat.IndexOf(caractert);

// Mostrar el resultado de la búsqueda
if (indice == -1)
{
    Console.WriteLine("\nEl carácter no se encuentra en la cadena.");
}
else
{
    Console.WriteLine("\nEl carácter se encuentra en la posición {0} de la cadena.", indice + 1);
}
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();


//Formateo de Cadenas
// 4 - Pedir al usuario su nombre, su edad y su país
Console.WriteLine("\n4 - Pedir al usuario su nombre, su edad y su país");
Console.WriteLine("\nIngrese su nombre:");
string nombre2 = Console.ReadLine()!;
Console.WriteLine("\nIngrese su edad:");
int edad2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("\nIngrese su país:");
string pais2 = Console.ReadLine()!;

// Formatear el mensaje usando el método String.Format
string mensaje2 = String.Format("\nHola, me llamo {0}, tengo {1} años y soy de {2}.", nombre2, edad2, pais2);


Console.WriteLine(mensaje2);// Mostrar el mensaje
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();


//EJEMPLOS PRACTICOS

//Ejemplo 1
//usando el método Replace para reemplazar una subcadena
//por otra, y la propiedad Length para obtener la
//longitud de una cadena.


string cadena3 = "Hola mundo";
Console.WriteLine("\nCadena original: " + cadena3);

// Reemplazar "mundo" por "amigo"
cadena3 = cadena3.Replace("\nmundo", "amigo");
Console.WriteLine("\nCadena modificada: " + cadena3);

// Obtener la longitud de la cadena
int longitud3 = cadena3.Length;
Console.WriteLine("\nLongitud de la cadena: " + longitud3);
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();


//Ejemplo 2
//usando el método Split para dividir una cadena
//de un arreglo de cadenas, y el método Join para
//unir un arreglo de cadenas en una sola cadena.


// Crear una cadena
string cadena4 = "Uno,Dos,Tres,Cuatro";
Console.WriteLine("\nCadena original: " + cadena4);

// Dividir la cadena por la coma
string[] arreglo1 = cadena4.Split(',');
Console.WriteLine("\nArreglo de cadenas:");
foreach (string elemento1 in arreglo1)
{
    Console.WriteLine(elemento1);
}

// Unir el arreglo de cadenas con un guión
cadena4 = string.Join("-", arreglo1);
Console.WriteLine("\nCadena unida: " + cadena4);
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();
*/

