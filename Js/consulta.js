document.addEventListener('DOMContentLoaded', function () {
    const titulo = document.querySelector('h2');
    if (titulo && titulo.textContent.includes("Consultar Autos")) {
        alert("¡Bienvenido a la sección de consulta de autos!");
    }
        const btnFondo = document.getElementById('btnFondo');
        if (btnFondo) {
            btnFondo.addEventListener('click', function () {
                document.querySelector(".container").classList.toggle= ("fondo-alterno");
            });
        }
    });