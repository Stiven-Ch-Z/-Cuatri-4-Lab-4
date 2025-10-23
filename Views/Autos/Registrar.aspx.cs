using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TallerMecanico.Controllers; // Para usar AutoController 
using TallerMecanico.Models; // Para crear objetos Auto 

namespace TallerMecanico.Views.Autos
{
    public partial class Registrar : System.Web.UI.Page
    {
        private readonly AutoController _controller = new AutoController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Construimos el modelo Auto desde los textbox 
                var auto = new Auto
                {
                    Placa = txtPlaca.Text.Trim(), // Tomamos la placa 
                    Marca = txtMarca.Text.Trim(), // Tomamos la marca 
                    Modelo = txtModelo.Text.Trim(), // Tomamos el modelo 
                    NombreDueno = txtDueno.Text.Trim(), // Tomamos el nombre del dueño
                    FechaIngreso = DateTime.Parse(txtFecha.Text.Trim()), // Convertimos fecha
                    Trabajo = txtTrabajo.Text.Trim() // Tomamos el trabajo solicitado    
                };

                // 2) Llamamos a la “acción” del controlador para registrar 
                _controller.Registrar(auto); // Intenta registrar 

                // 3) Mostramos mensaje de éxito 
                lblMensaje.Text = "Auto registrado correctamente."; //Feedback al usuario
                lblMensaje.ForeColor = System.Drawing.Color.Green; // Color verde

                // 4) Limpiamos campos (opcional para la demo) 
                txtPlaca.Text = txtMarca.Text = txtModelo.Text =
                txtDueno.Text = txtFecha.Text = txtTrabajo.Text= string.Empty;
                
            }
            catch (Exception ex)
            {
                // Si algo falla (placa vacía, duplicado, fecha inválida),lo mostramos
                lblMensaje.Text = "Error: " + ex.Message; // Mensaje de error
                lblMensaje.ForeColor = System.Drawing.Color.Red; // Color rojo
            }
        }
    }
} 
    
