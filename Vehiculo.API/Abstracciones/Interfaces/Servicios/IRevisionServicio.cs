using Abstracciones.Modelos.Servicios.Registro;

namespace Abstracciones.Interfaces.Servicios
{
    public interface IRevisionServicio
    {

        Task<Revision> Obtener(string placa);
    }
}
