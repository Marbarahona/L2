public class Cliente: Persona
{
    public string LugarOrigen { get; set; }

    public Cliente(int Id, string nombre, int edad, string sexo, string lugarorigen, int telefono, string correo)
    {
        id = Id;
        Nombre = nombre;
        Edad = edad;
        Sexo=sexo;
        LugarOrigen = lugarorigen;
        Telefono = Telefono;
        Correo = correo;
    }


    
}