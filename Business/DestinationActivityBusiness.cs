using Data;
using Entity.DTO;
using Entity.Model;
using Microsoft.Extensions.Logging;
using Utilities.Exceptions;

namespace Business
{
    public class DestinationActivity
    {
        private readonly DestinationActivityData _destinationActivityData;
        private readonly ILogger _logger;

        public DestinationActivity(DestinationActivityData destinationActivityData, ILogger logger)
        {
            _destinationActivityData = destinationActivityData;
            _logger = logger;
        }

        // Obtener todas las actividades destino
        public async Task<IEnumerable<DestinationActivityDTO>> GetAllAsync()
        {
            try
            {
                var list = await _destinationActivityData.GetAllAsync();
                return list.Select(a => new DestinationActivityDTO
                {
                    DestinationActivityId = a.DestinationActivityId,
                    Name = a.Name
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener todas las actividades destino");
                throw new ExternalServiceException("Base de datos", "Error al recuperar actividades destino", ex);
            }
        }

        // Obtener por ID
        public async Task<DestinationActivityDTO> GetByIdAsync(int id)
        {
            if (id <= 0)
            {
                _logger.LogWarning("ID inválido: {DestinationActivityId}", id);
                throw new ValidationException("id", "El ID debe ser mayor que cero");
            }

            try
            {
                var activity = await _destinationActivityData.GetByIdAsync(id);
                if (activity == null)
                {
                    _logger.LogInformation("Actividad destino no encontrada: {DestinationActivityId}", id);
                    throw new EntityNotFoundException("DestinationActivity", id);
                }

                return new DestinationActivityDTO
                {
                    DestinationActivityId = activity.DestinationActivityId,
                    Name = activity.Name
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener la actividad destino con ID: {DestinationActivityId}", id);
                throw new ExternalServiceException("Base de datos", $"Error al recuperar la actividad destino con ID {id}", ex);
            }
        }

        // Crear nueva actividad destino
        public async Task<DestinationActivityDTO> CreateAsync(DestinationActivityDTO dto)
        {
            try
            {
                Validate(dto);

                var entity = new Entity.Model.DestinationActivity
                {
                    Name = dto.Name
                };

                var created = await _destinationActivityData.CreateAsync(entity);

                return new DestinationActivityDTO
                {
                    DestinationActivityId = created.DestinationActivityId,
                    Name = created.Name
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear actividad destino: {Name}", dto?.Name ?? "null");
                throw new ExternalServiceException("Base de datos", "Error al crear la actividad destino", ex);
            }
        }

        // Validar DTO
        private void Validate(DestinationActivityDTO dto)
        {
            if (dto == null)
                throw new ValidationException("El objeto actividad no puede ser nulo");

            if (string.IsNullOrWhiteSpace(dto.Name))
            {
                _logger.LogWarning("Intento de crear actividad destino con Name vacío");
                throw new ValidationException("Name", "El Name de la actividad destino es obligatorio");
            }
        }
    }
}