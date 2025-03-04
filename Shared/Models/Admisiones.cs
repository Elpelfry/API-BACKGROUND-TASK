﻿namespace Shared.Models;

public class Admisiones
{
    public int AdmisioneId { get; set; }

    public string? Nombres { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? Cedula { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? LugarNacimiento { get; set; }

    public string? CiudadNacimiento { get; set; }

    public string? Telefono { get; set; }

    public string? TelefonoCasa { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Contrasena { get; set; }

    public int CarreraId { get; set; }

    public byte[]? RecordNotas { get; set; }

    public byte[]? ActaNacimiento { get; set; }

    public byte[]? CertificadoMedico { get; set; }

    public byte[]? CertificadoBachiller { get; set; }

    public byte[]? Fotografia { get; set; }

    public byte[]? Tarjetavacunacion { get; set; }

    public string? Direccion { get; set; }

    public int EstadoAdmicionId { get; set; }

    public string? FotoExtension { get; set; }

    public string? TarjetavacunacionExtension { get; set; }

    public string? CertificadoBachillerExtension { get; set; }

    public string? CertificadoMedicoExtension { get; set; }

    public string? ActaNacimientoExtension { get; set; }

    public string? RecordNotasExtension { get; set; }
}
