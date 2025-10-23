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
            if (string.IsNullOrWhiteSpace(nuevo.Placa) || string.IsNullOrWhiteSpace(nuevo.Trabajo))
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
        public bool Eliminar(string placa)
        {
            if (string.IsNullOrWhiteSpace(placa))
            {
                throw new ArgumentException("La placa no puede estar vacía.");
            }
            var auto = _autos.FirstOrDefault(a => a.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase));
            if (auto == null)
            {
                return false; // no se encontró el auto
            }
            _autos.Remove(auto);
            return true; // se elimina el auto
        }


    }
}