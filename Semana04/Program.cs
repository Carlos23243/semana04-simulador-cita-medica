using System;
public class Paciente
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public required string Telefono { get; set; }
    public required string Email { get; set; }

}

public class Medico
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Especialidad { get; set; }

}

public class Turno
{
    public int Id { get; set; }
    public DateTime FechaHora { get; set; }
    public int PacienteId { get; set; }
    public int MedicoId { get; set; }
    public required string Estado { get; set; }
    public required Paciente Paciente { get; set; }
    public required Medico Medico { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- SIMULACIÓN DE GESTIÓN DE TURNOS ---");

        Paciente paciente1 = new Paciente
        {
            Id = 1,
            Nombre = "Ana",
            Apellido = "Garcia",
            Telefono = "0999999999",
            Email = "ana.garcia@mail.com"
        };

        Medico medico1 = new Medico
        {
            Id = 101,
            Nombre = "Dr. Javier Pérez",
            Especialidad = "Cardiología"
        };

        Turno turno1 = new Turno
        {
            Id = 5001,
            FechaHora = new DateTime(2025, 12, 20, 10, 30, 0),
            PacienteId = paciente1.Id,
            MedicoId = medico1.Id,
            Estado = "Confirmado", 
            Paciente = paciente1, 
            Medico = medico1  
        };
        
        Console.WriteLine("\n--- DATOS DEL TURNO PROGRAMADO ---");
        Console.WriteLine($"ID del Turno: {turno1.Id}");
        Console.WriteLine($"Fecha y Hora: {turno1.FechaHora}");
        Console.WriteLine($"Estado: {turno1.Estado}");

        Console.WriteLine("\n** Detalle del Paciente **");
        Console.WriteLine($"Nombre: {turno1.Paciente.Nombre} {turno1.Paciente.Apellido}");
        Console.WriteLine($"Contacto: {turno1.Paciente.Email}");

        Console.WriteLine("\n** Detalle del Médico **");
        Console.WriteLine($"Médico: {turno1.Medico.Nombre}");
        Console.WriteLine($"Especialidad: {turno1.Medico.Especialidad}");

        Console.WriteLine("\n--- FIN DEL PROGRAMA ---");
    }
}
