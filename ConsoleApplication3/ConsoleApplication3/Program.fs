// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let siguiente x = x+1
let suma a b = a + b
let resta a b = a - b
let multi a b = a * b
let divide a b = a / b

[<EntryPoint>]
let main argv = 
   
    System.Console.WriteLine("Introduzca a");
    let a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Introduzca b");
    let b = Convert.ToInt32(Console.ReadLine());
    
    let d = suma a b 
    
    System.Console.WriteLine(d);
          
    System.Console.WriteLine("El resultado de sumar es: " + d.ToString(); ); 

    let d = resta a b 
    
    System.Console.WriteLine(d);
          
    System.Console.WriteLine("El resultado de restar es: " + d.ToString(); ); 

    let d = multi a b 
    
    System.Console.WriteLine(d);
          
    System.Console.WriteLine("El resultado de multiplicar es: " + d.ToString(); ); 

    let d = divide a b 
    
    System.Console.WriteLine(d);
          
    System.Console.WriteLine("El resultado de dividir es: " + d.ToString(); ); 

    let tecla1 = Console.ReadKey();

    0 // devolver un código de salida entero
