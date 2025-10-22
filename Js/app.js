console.log("Talller Mecanico-Unidad 4")
// ===== DEMO JS BÁSICO (Aislado) ===== 
// Este bloque muestra conceptos base de JS SIN tocar el resto del sitio. 
// Se ejecuta solo en la página de demo que contiene un <div id="demoJS">. 

document.addEventListener('DOMContentLoaded', function () {
    // DOMContentLoaded: garantiza que el árbol HTML esté cargado 
    // antes de buscar elementos por id y registrar eventos. 

    // --- GATE / PUERTA DE ENTRADA --- 
    // "demoRoot" es el contenedor exclusivo de la página de demo. 
    // Si NO existe, salimos inmediatamente y no hacemos nada. 
    var demoRoot = document.getElementById('demoJS');
    if (!demoRoot) return;

    // --- UTILIDAD DE LOG --- 
    // logArea es un <div id="log"> donde imprimimos mensajes para 
    // que el estudiantado vea resultados sin abrir la consola. 
    var logArea = document.getElementById('log');

    // Función auxiliar para mostrar texto en consola y en #log. 
    function log(msg) {
        console.log(msg);                 // imprime en consola del navegador 
        if (!logArea) return;             // si no hay #log, no intentamos 
        escribir
        var p = document.createElement('div'); // creamos un <div> por mensaje 
        p.textContent = String(msg);           // textContent evita HTML 
        injection
        logArea.appendChild(p);                // agregamos el mensaje a #log 
    }

    // --- CONCEPTOS BÁSICOS --- 
    // "let": variable reasignable (ámbito de bloque). 
    let curso = 'Unidad 4';

    // "const": constante. No se puede reasignar (el binding es constante). 
    // Para objetos/arrays, el contenido sí puede mutar, pero no el binding. 
    const tema = 'JavaScript básico';

    // Declaración de función "clásica" (hoisting de la declaración). 
    // Podríamos usar arrow function, pero aquí preferimos lo más básico: 
    function saludar(nombre) {
        // Usamos concatenación de strings para mantenerlo simple. 
        // Alternativa (no ejecutada): template string → `Hola, ${nombre}...` 
        return 'Hola, ' + nombre + '. Bienvenido a ' + curso + ' - ' + tema +'.';
    }

    // Ejecución de la función y ejemplos de tipos/operaciones. 
    log(saludar('estudiantes')); // → Hola, estudiantes... 
    log(typeof curso);           // → "string" (typeof devuelve el tipo primitivo)
    log(10 + 5);                 // → 15 (operación aritmética básica) 

        // --- DOM + EVENTOS: SUMA DE DOS NÚMEROS --- 
    // Obtenemos referencias a los elementos de entrada y resultado. 
    var n1 = document.getElementById('n1');                 // <input id="n1"> 
    var n2 = document.getElementById('n2');                 // <input id="n2"> 
    var btnSumar = document.getElementById('btnSumar');     // <button id = "btnSumar" > 
    var resultadoSuma = document.getElementById('resultadoSuma'); // <span id = "resultadoSuma" >

    // Registramos el evento SOLO si los elementos existen (página aislada). 
    if (btnSumar && n1 && n2 && resultadoSuma) {
        btnSumar.addEventListener('click', function () {
        // parseFloat convierte texto a número (punto decimal). 
        // Reemplazamos ',' por '.' para tolerar separadores decimales comunes.
            var a = parseFloat(String(n1.value).replace(',', '.')); // NaN si no es número
            var b = parseFloat(String(n2.value).replace(',', '.'));

        // isNaN(a) es true cuando "a" no es un número válido. 
            if (isNaN(a) || isNaN(b)) {
            // textContent escribe texto plano (no interpreta HTML). 
                resultadoSuma.textContent = ' Ingresa números válidos.';
                return; // detenemos la función si hay error 
            }

        // Si pasó la validación: calculamos y mostramos. 
            var suma = a + b;
            resultadoSuma.textContent = ' Resultado: ' + suma;
    });
}

        // --- ARREGLOS Y BUCLES: RENDERIZAR LISTA --- 
        // Arreglo simple de cadenas. forEach recorre cada elemento. 
    var marcas = ['Toyota', 'Nissan', 'Hyundai', 'Kia', 'Mazda'];

        // Botón que dispara el renderizado y la <ul> donde se insertan <li>. 
    var btnListar = document.getElementById('btnListar');   // <button id = "btnListar" > 
    var ul = document.getElementById('listaMarcas'); // <ul id = "listaMarcas" > 
 
    if (btnListar && ul) {
        btnListar.addEventListener('click', function () {
            // Limpiamos la lista antes de volver a poblarla. 
            // innerHTML = '' es suficiente aquí (contenido controlado). 
            ul.innerHTML = '';

            // Recorremos el arreglo y creamos un <li> por marca. 
            marcas.forEach(function (m) {
            var li = document.createElement('li'); // creamos el nodo de lista 
            li.textContent = m;                    // asignamos el texto visible 
            ul.appendChild(li);                    // lo agregamos al <ul> 
        });
    });
}

    // --- ESTADO EN MEMORIA: CONTADOR --- 
    // "contador" vive en el cierre (closure) de esta función. Se conserva 
    // entre clics mientras la página no se recargue. 
    var contador = 0;
    var btnContar = document.getElementById('btnContar');   // <button id = "btnContar" > 
    var lblContador = document.getElementById('lblContador');// <span id = "lblContador" > 
 
    if (btnContar && lblContador) {
        btnContar.addEventListener('click', function () {
            contador = contador + 1;                    // incremento (equivalente a contador++)
            lblContador.textContent = String(contador); // convertimos a string y mostramos
        }); 
    }

    // --- OBJETOS Y JSON --- 
    // Demostración de objeto literal y serialización/desserialización JSON. 
    var btnJson = document.getElementById('btnJson');   // <button id = "btnJson" > 
    var jsonOut = document.getElementById('jsonOut');   // <pre id="jsonOut"> 

    if (btnJson && jsonOut) {
        btnJson.addEventListener('click', function () {
        // Objeto literal "auto" con propiedades simples (clave: valor). 
            var auto = {
                placa: 'ABC123',
                marca: 'Toyota',
                modelo: 'Corolla',
                dueno: 'Karla',
                anio: 2018
            };

             // JSON.stringify(obj, replacer, space) 
            // - replacer: null (no filtramos propiedades) 
            // - space: 2   (identación de 2 espacios para que sea legible) 
            var texto = JSON.stringify(auto, null, 2);   // objeto → texto JSON "bonito"
            jsonOut.textContent = texto;   // lo mostramos en el  <pre>

            // JSON.parse(texto): convierte texto JSON válido a objeto JS.
            var copia = JSON.parse(texto);

            // Usamos nuestra utilidad de "log" para demostrar acceso a propiedades.
            log('El dueño del auto es ' + copia.dueno); 
       }); 
    } 
});