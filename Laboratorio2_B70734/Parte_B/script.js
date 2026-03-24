// Variable global para controlar el estado del fondo
let fondo = false;

// Funcion que agrega un nuevo elemento a la lista
function agregar() {
    // Obtenemos la lista por su ID
    const lista = document.getElementById("lista");

    // Obtenemos la cantidad total de elementos actuales en la lista
    const cantidad = lista.children.length;

    // Creamos un nuevo elemento li y asignamos su texto con el numero correspondiente
    const nuevoElemento = document.createElement("li");
    nuevoElemento.textContent = "Elemento" + (cantidad + 1);

    // agregamos el nuevo elemento a la lista
    lista.appendChild(nuevoElemento);
}

function cambiarFondo() {
    // si fondo es falso, cambiamos a fondo oscuro e invertimos el valor de fondo, de lo contrario, cambiamos a fondo claro e invertimos 
    // el valor de fondo
    if (!fondo) {
        document.body.style.backgroundColor = "black";
        fondo = true;
    } else {
        document.body.style.backgroundColor = "white";
        fondo = false;
    }
}

function borrar() {
    // obtenemos la lista por su ID
    const lista = document.getElementById("lista");

    // hacemos una verificacion de que la lista tenga al menos 1 elemento. Si es asi, eliminamos el ultimo elemento de la lista
    if (lista.children.length > 0) {
        lista.removeChild(lista.lastElementChild);
    }
}