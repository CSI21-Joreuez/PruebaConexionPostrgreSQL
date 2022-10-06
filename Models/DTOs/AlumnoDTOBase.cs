﻿namespace pruebaConexionPostgreSQLV.Models.DTOs
{
    public class AlumnoDTOBase
    {

        public int id_alumno { get; private set; }
        //Al añadir al tipo el símbolo ? se admite null en el campo al salir del constructor.
        public string? nombre { get; private set; }
        public string? apellidos { get; private set; }
        public string? email { get; private set; }
    }
}