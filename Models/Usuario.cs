﻿namespace LojaVirtualAPI.Models;


public class Usuario
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string SenhaHash { get; set; } = string.Empty;

    public bool IsAdmin { get; set; } = false;

    public DateTime CriadoEm { get; set; } = DateTime.Now;

}
