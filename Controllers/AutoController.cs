using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TallerMecanico.Models;

namespace TallerMecanico.Controllers
{
    public class AutoController
    {
        private static readonly List<Auto> _autos = new List<Auto>();//lista estatica de autos
        
        public void Registrar(Auto nuevo)
        {
            if (string.IsNullOrWhiteSpace(nuevo.Placa))
            {
                throw new ArgumentException("Todos los campos son obligatorios.");
            }
            bool existe = _autos.Any(a => a.Placa.Equals(nuevo.Placa, StringComparison.OrdinalIgnoreCase));
            if (existe)
            {
                throw new InvalidOperationException("Ya existe un auto con esa placa.");
            }
            _autos.Add(nuevo);
        }
        public List<Auto> Listar(string placa=null)
        {
            if (string.IsNullOrWhiteSpace(placa))
            {
                return _autos.ToList();
            }
            return _autos
                .Where(a=> a.Placa.IndexOf(placa, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();



        }
        
            
        
    }
}