using Infraestructure.Enumerables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.AreaDTOs
{
    public class AreaMiniDTO 
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public int Tamaño { get; set; }

        #region Hospital
        public Guid HospitalId { get; set; }
        public string HospitalNombre { get; set; }
        public LocalizacionType HospitalLocalizacion { get; set; }
        public string HospitalEspecialidades { get; set; }
        #endregion
    }
}
