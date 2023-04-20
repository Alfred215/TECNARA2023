using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.DTO.FuncionDTOs
{
    public class FuncionMiniDTO
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }

        #region AREA
        public Guid AreaId { get; set; }
        public string AreaNombre { get; set; }
        public int AreaTamaño { get; set; } 
        #endregion
    }
}
