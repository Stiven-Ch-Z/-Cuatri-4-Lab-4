using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerMecanico.Controllers; // Usar AutoController 

namespace TallerMecanico.Views.Autos
{
    public partial class Consultar : System.Web.UI.Page
    {
        private readonly AutoController _controller = new AutoController();
        // Instancia Controlador 

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Solo la primera vez 
            {
                CargarAutos(); // Cargamos todos los autos 
            }
        }

        private void CargarAutos(string filtroPlaca = null) // Método auxiliar 
        { 
            var lista = _controller.Listar(filtroPlaca); // Pedimos datos al “controlador” 
            gvAutos.DataSource = lista; // Asignamos al GridView 
            gvAutos.DataBind(); // Enlazamos datos 
        } 
 
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarAutos(txtFiltro.Text.Trim()); // Cargar filtrando por placa
        }

        protected void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty; // Limpiamos filtro 
            CargarAutos(); // Cargamos todos 
        }
    }
} 
