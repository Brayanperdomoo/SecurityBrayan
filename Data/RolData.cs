using Entity.Context;
using Entity.Model;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data
{
    /// <summary>
    /// Repositorio encargado de la gestión de la entidad Rol en la base de datos.
    /// </summary>
    public class RolData
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;
    }
}
