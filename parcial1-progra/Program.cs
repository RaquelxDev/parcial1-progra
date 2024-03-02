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
Console.WriteLine(empieza); //Esto imprime true, porque "Guatemala" empieza por "Tel"

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
*/
