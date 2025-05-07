using Data;
using Entity.DTO;
using Entity.Model;
using Microsoft.Extensions.Logging;
using Utilities.Exceptions;

namespace Business
{
    public class ActivityBusiness
    {
        private readonly ActivityData _ActivityData;
        private readonly ILogger<Activity> _logger;

        public ActivityBusiness(ActivityData ActivityData, ILogger<Activity> logger)
        {
            _ActivityData = ActivityData;
            _logger = logger;
        }

        // Método para obtener todos los cambios como DTOs
        public async Task<IEnumerable<ActivityDTO>> GetAllActivitysAsync()
        {
            try
            {
                var changesLogs = await _ActivityData.GetAllAsync();
                var changesLogsDTO = new List<ActivityDTO>();

                foreach (var Activity in changesLogs)
                {
                    changesLogsDTO.Add(new ActivityDTO
                    {
                        ActivityId = Activity.ActivityId,
                        Description = Activity.Description,
                        Name = Activity.Name
                    });
                }

                return changesLogsDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener todos los cambios");
                throw new ExternalServiceException("Base de datos", "Error al recuperar la lista de cambios", ex);
            }
        }

        // Método para obtener un cambio por ID como DTO
        public async Task<ActivityDTO> GetActivityByIdAsync(int id)
        {
            if (id <= 0)
            {
                _logger.LogWarning("Se intentó obtener un cambio con ID inválido: {ActivityId}", id);
                throw new Utilities.Exceptions.ValidationException("id", "El ID del cambio debe ser mayor que cero");
            }

            try
            {
                var Activity = await _ActivityData.GetByIdAsync(id);
                if (Activity == null)
                {
                    _logger.LogInformation("No se encontró ningún cambio con ID: {ActivityId}", id);
                    throw new EntityNotFoundException("Usuario", id);
                }

                return new ActivityDTO
                {
                    ActivityId = Activity.ActivityId,
                    Description = Activity.Description,
                    Name = Activity.Name
                };
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el cambio con ID: {ActivityId}", id);
                throw new ExternalServiceException("Base de datos", $"Error al recuperar el cambio con ID {id}", ex);
            }
        }

        // Método para crear un cambio desde un DTO
        public async Task<ActivityDTO> CreateActivityAsync(ActivityDTO ActivityDto)
        {
            try
            {
                ValidateActivity(ActivityDto);

                var Activity = new Activity
                {
                    Description = ActivityDto.Description,
                    Name = ActivityDto.Name
                };

                var ActivityCreado = await _ActivityData.CreateAsync(Activity);

                return new ActivityDTO
                {
                    ActivityId = ActivityCreado.ActivityId,
                    Description = ActivityCreado.Description,
                    Name = ActivityCreado.Name
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear nuevo cambio: {Description}", ActivityDto?.Description ?? "null");
                throw new ExternalServiceException("Base de datos", "Error al crear el cambio", ex);
            }
        }

        // Método para validar el DTO
        private void ValidateActivity(ActivityDTO ActivityDto)
        {
            if (ActivityDto == null)
            {
                throw new Utilities.Exceptions.ValidationException("El objeto cambio no puede ser nulo");
            }

            if (string.IsNullOrWhiteSpace(ActivityDto.Description))
            {
                _logger.LogWarning("Se intentó crear/actualizar un cambio con Description vacío");
                throw new Utilities.Exceptions.ValidationException("Description", "El Description del cambio es obligatorio");
            }
        }
    }
}