
/* Punto 1 */

Console.WriteLine("Coloque los ingresos del primer semestre: ");
uint ingresosSemestre1 = uint.Parse(Console.ReadLine());

Console.WriteLine("Coloque los ingresos del segundo semestre: ");
double ingresosSemestre2 = double.Parse(Console.ReadLine());

double ingresosAnuales = ingresosSemestre1 + ingresosSemestre2;

double cincoPorciento = ingresosAnuales * 0.05;
double diezPorciento = ingresosAnuales * 0.1;
double quincePorciento = ingresosAnuales * 0.15;
double veintePorciento = ingresosAnuales * 0.2;
double treintaPorciento = ingresosAnuales * 0.3;

if( ingresosAnuales < 10000){
    Console.WriteLine("El valor  a tributar es: " + cincoPorciento);
    Environment.Exit(0);
}else if(ingresosAnuales >= 10000 && ingresosAnuales < 20000){
    Console.WriteLine("El valor  a tributar es: " + diezPorciento);
    Environment.Exit(0);
}
else if(ingresosAnuales >= 20000 && ingresosAnuales < 35000){
    Console.WriteLine("El valor  a tributar es: " + quincePorciento);
    Environment.Exit(0);
}else if(ingresosAnuales >= 35000 && ingresosAnuales < 45000){
    Console.WriteLine("El valor  a tributar es: " + veintePorciento);
    Environment.Exit(0);
}else if(ingresosAnuales > 45000){
    Console.WriteLine("El valor  a tributar es: " + treintaPorciento);
    Environment.Exit(0);
}



