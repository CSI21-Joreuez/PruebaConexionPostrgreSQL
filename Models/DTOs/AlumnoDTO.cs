namespace pruebaConexionPostgreSQLV.Models.DTOs
{
    /* AlumnoDTO - DTO de la tabla alumno
     * @autor garfe
     * 02/10/2022
     */

    public class AlumnoDTO
    {
        public AlumnoDTO(int id_alumno, string? nombre, string? apellidos, string? email)
        {
            this.id_alumno = id_alumno;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
        }

        public int id_alumno { get;private set; }
        //Al añadir al tipo el símbolo ? se admite null en el campo al salir del constructor.
        public string? nombre { get;private set; }
        public string? apellidos { get;private set; }
        public string? email { get;private set; }

    }
}
