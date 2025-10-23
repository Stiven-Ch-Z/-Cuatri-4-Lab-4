using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerMecanico.Controllers; 

namespace TallerMecanico.Views.Autos
{
    public partial class Eliminar : System.Web.UI.Page
    {
        private readonly AutoController _controlador = new AutoController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEliminar_Click(Object sender, EventArgs e)
        { 
            string placa = txtPlaca.Text.Trim();
            try
            {
                bool eliminado = _controlador.Eliminar(placa);
                
                if (eliminado)
                {
                    lblMensaje.Text = "Auto con placa " + placa + " eliminado correctamente.";
                }
                else
                {
                    lblMensaje.Text = "No se encontró un auto con la placa " + placa + ".";
                }
            } 
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}