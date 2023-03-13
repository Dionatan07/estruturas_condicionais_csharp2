double value = double.Parse(Console.ReadLine());

double imposto;


if (value <= 2000){
    imposto = 0;
} 

else if (value <= 3000){
    imposto = (value - 2000) * 0.08;
}
else if (value <= 4500){
    imposto = (value - 3000) * 0.18 + 1000 * 0.08;
}
else{
    imposto = (value - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
}

if (imposto == 0.00){
    Console.WriteLine("Isento");
}
else{
    Console.WriteLine("R$ " + imposto.ToString("F"));
} 