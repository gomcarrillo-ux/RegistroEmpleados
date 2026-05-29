Empleado[] empleados = new Empleado[10];
void agregarEmpleados(int pos)
{
    Console.Write("Nombres: ");
    empleados[pos].nombres = Console.ReadLine()!;
    Console.Write("Apellidos: ");
    empleados[pos].apellidos = Console.ReadLine()!;
    Console.Write("Cargo: ");
    empleados[pos].cargo = Console.ReadLine()!;
    Console.Write("Salario: ");
    empleados[pos].salario = double.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Registro guardado exitosamente");
    Console.ResetColor();
}
struct Empleado
{
    public string nombres;
    public string apellidos;
    public string cargo;
    public double salario;
}
