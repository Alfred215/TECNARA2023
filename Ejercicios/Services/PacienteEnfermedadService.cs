using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PacienteEnfermedadService
    {
        AppDbContext db;
        public PacienteEnfermedadService(AppDbContext _db)
        {
            db = _db;
        }
    }
}
