using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DiagnosticoTratamientoService
    {
        AppDbContext db;
        public DiagnosticoTratamientoService(AppDbContext _db)
        {
            db = _db;
        }
    }
}
