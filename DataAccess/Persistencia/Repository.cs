using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistencia
{
    public class Repository
    {
        private UsuarioRepository _UsuarioRepository;
        private ReclamoRepository _ReclamoRepository;
        private ZonaRepository _ZonaRepository;
        private CuadrillaRepository _CuadrillaRepository;

        public Repository()
        {
            this._UsuarioRepository = new UsuarioRepository();
            this._ReclamoRepository = new ReclamoRepository();
            this._ZonaRepository = new ZonaRepository();
            this._CuadrillaRepository = new CuadrillaRepository();
        }

        public UsuarioRepository getUsuarioRepository()
        {
            return this._UsuarioRepository;
        }

        public ReclamoRepository getReclamoRepository()
        {
            return this._ReclamoRepository;
        }
        public ZonaRepository getZonaRepository()
        {
            return this._ZonaRepository;
        }
        public CuadrillaRepository getCuadrillaRepository()
        {
            return this._CuadrillaRepository;
        }
    }
}
