namespace FinalProyect;
using System;
using System.Collections.Generic;
using System.IO;

public abstract class Cerradura
{
    public string Nombre { get; protected set; }
    public int Intentos { get; protected set; }
    public bool EstaAbierta { get; protected set; }

   
    public abstract bool Intentar(string entrada);

    
    public abstract bool Intentar(bool fuerzaBruta);

    public abstract string ObtenerDescripcion();
    public abstract string ObtenerEstado();
    public abstract string SolicitarPista();
    public abstract string HintCalor(int numero);
}


public class CerraduraPerezoso : Cerradura
{
    private int _secreto = 7;

    public CerraduraPerezoso() { Nombre = "El Perezoso"; }

    public override bool Intentar(string entrada)
    {
        Intentos++;
        if (int.TryParse(entrada, out int n))
        {
            EstaAbierta = (n == _secreto);
            return EstaAbierta;
        }
        return false;
    }

    public override bool Intentar(bool fuerzaBruta)
    {
        Intentos += 50;
        EstaAbierta = true;
        return true;
    }

    public override string ObtenerDescripcion() =>
        "  El Perezoso nunca cambia su contraseña.\n  Siempre usa su número favorito... ¿cuál será?";

    public override string SolicitarPista() =>
        "  Pista: Es un número de un solo dígito, impar, y el más pequeño con suerte.";

    public override string HintCalor(int numero)
    {
        int diff = Math.Abs(numero - _secreto); 
        if (diff == 0) return "¡Exacto!";
        if (diff <= 2) return "Muy caliente";
        if (diff <= 5) return "Tibio";
        return "Frío";
    }

    public override string ObtenerEstado() =>
        $"{Nombre}: {(EstaAbierta ? "ABIERTA" : "CERRADA")} | Intentos: {Intentos}";
}


public class CerraduraParanoico : Cerradura
{
    private int _secreto;
    private Random _rng = new Random();

    public CerraduraParanoico()
    {
        Nombre = "El Paranoico";
        _secreto = _rng.Next(1, 51);
    }

    public override bool Intentar(string entrada)
    {
        Intentos++;
        if (Intentos % 3 == 0 && !EstaAbierta)
            _secreto = _rng.Next(1, 51);

        if (int.TryParse(entrada, out int n))
        {
            EstaAbierta = (n == _secreto);
            return EstaAbierta;
        }
        return false;
    }

    public override bool Intentar(bool fuerzaBruta)
    {
        Intentos += 50;
        EstaAbierta = true;
        return true;
    }

    public override string ObtenerDescripcion() =>
        "  El Paranoico cambia su clave cada 3 intentos fallidos.\n  Piénsalo bien antes de adivinar.";

    public override string SolicitarPista() =>
        $"Pista: El número actual está entre {Math.Max(1, _secreto - 10)} y {Math.Min(50, _secreto + 10)}.";

    public override string HintCalor(int numero)
    {
        int diff = Math.Abs(numero - _secreto);
        if (diff == 0) return "¡Exacto!";
        if (diff <= 5) return "Muy caliente";
        if (diff <= 15) return "Tibio";
        return "Frío";
    }

    public override string ObtenerEstado() =>
        $"{Nombre}: {(EstaAbierta ? "ABIERTA" : "CERRADA")} | Intentos: {Intentos}";
}


public class CerraduraDescuidado : Cerradura
{
    private int _secreto;

    public CerraduraDescuidado()
    {
        Nombre = "El Descuidado";
        _secreto = new Random().Next(1, 51);
    }

    public override bool Intentar(string entrada)
    {
        Intentos++;
        if (int.TryParse(entrada, out int n))
        {
            EstaAbierta = (n == _secreto);
            return EstaAbierta;
        }
        return false;
    }

    public override bool Intentar(bool fuerzaBruta)
    {
        Intentos += 50;
        EstaAbierta = true;
        return true;
    }

    public override string ObtenerDescripcion() =>
        "  El Descuidado escribió su clave en un papel... y lo perdió.\n  Pide una pista, capaz se acuerda.";

    public override string SolicitarPista() =>
        $" Pista: Creo que era... ¿{_secreto}? Sí, ese era.";

    public override string HintCalor(int numero)
    {
        int diff = Math.Abs(numero - _secreto);
        if (diff == 0) return "¡Exacto!";
        if (diff <= 3) return "Muy caliente";
        if (diff <= 10) return "Tibio";
        return "Frío";
    }

    public override string ObtenerEstado() =>
        $"{Nombre}: {(EstaAbierta ? "ABIERTA" : "CERRADA")} | Intentos: {Intentos}";
}

public class CajaFuerte
{
    private List<Cerradura> _cerraduras;
    private int _cerraduraActual;
    private string _archivoLog;
    private DateTime _inicioSesion;

    public bool EstaCompleta => _cerraduraActual >= _cerraduras.Count;
    public Cerradura CerraduraActiva => _cerraduras[_cerraduraActual];

    public CajaFuerte()
    {
        _cerraduras = new List<Cerradura>
        {
            new CerraduraPerezoso(),
            new CerraduraParanoico(),
            new CerraduraDescuidado()
        };
        _cerraduraActual = 0;
        _archivoLog = "sesion_safecracker.txt";
        _inicioSesion = DateTime.Now;

        IniciarArchivoLog();
    }

    private void IniciarArchivoLog()
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(_archivoLog, append: false))
            {
                sw.WriteLine("=== SAFECRACKER — Registro de sesión ===");
                sw.WriteLine($"Inicio: {_inicioSesion:yyyy-MM-dd HH:mm:ss}");
                sw.WriteLine("=========================================");
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"[!] No se pudo crear el archivo de log: {e.Message}");
        }
    }

    public void RegistrarIntento(string cerradura, int numero, bool exito, string calor)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(_archivoLog, append: true))
                sw.WriteLine($"[{DateTime.Now:HH:mm:ss}] {cerradura} | Intento: {numero} | {calor} | Éxito: {exito}");
        }
        catch (IOException) { }
    }

    public void RegistrarEvento(string mensaje)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(_archivoLog, append: true))
                sw.WriteLine($"[{DateTime.Now:HH:mm:ss}] {mensaje}");
        }
        catch (IOException) { }
    }

    public void MostrarHistorial()
    {
        Console.WriteLine("\n   === HISTORIAL DE SESIÓN ===");
        try
        {
            if (!File.Exists(_archivoLog))
            {
                Console.WriteLine("  No se encontró el archivo de log.");
                return;
            }
            string[] lineas = File.ReadAllLines(_archivoLog);
            foreach (string linea in lineas)
                Console.WriteLine($"  {linea}");
        }
        catch (IOException e)
        {
            Console.WriteLine($"  [!] Error al leer el historial: {e.Message}");
        }
    }

    public void GuardarResumen(bool victoria)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(_archivoLog, append: true))
            {
                sw.WriteLine("\n");
                sw.WriteLine($"Fin: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                sw.WriteLine($"Duración: {(DateTime.Now - _inicioSesion).TotalMinutes:F1} minutos");
                sw.WriteLine($"Resultado: {(victoria ? "CAJA ABIERTA" : "SESIÓN TERMINADA")}");
                foreach (var c in _cerraduras)
                    sw.WriteLine($"  → {c.ObtenerEstado()}");
                sw.WriteLine("\n");
            }
        }
        catch (IOException) { }
    }

    public void AvanzarCerradura() { _cerraduraActual++; }

    public int NumCerraduraActual => _cerraduraActual + 1;
    public int TotalCerraduras => _cerraduras.Count;
}