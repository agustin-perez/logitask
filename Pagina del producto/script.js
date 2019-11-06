/**Fertspa studios javascript source*/
var menuActual = null;
var posicionTopLogo = '30%';
var timer;

/**
 * Función encargada de mostrar el menú desplegable al hacer click en el botón correspondiente
 * @param {menuId} menuId ID del div conteniendo las opciones del menú desplegable
 */
function mostrarSub(menuId) 
{
  if (menuActual != null)
  {
    document.getElementById(menuActual).classList.remove('show');
  }
  menuActual=menuId;
  document.getElementById(menuId).classList.toggle("show");
}

function actualizarIframe(pagina)
{
  document.getElementById('contenidos').src = pagina;
}

function responsiveButton() 
{
  var menu = document.getElementById("responsiveStandard");
  if (menu.className === "barraMenu") 
  {
    menu.className += " responsive";
  } 
  else 
  {
    menu.className = "barraMenu";
  }
} 

function cerrarResponsive()
{
  var menu = document.getElementById("responsiveStandard");
  if(menu.className != "barraMenu")
  {
    menu.className="barraMenu";
  }
}

function movimientoLogo()
{
  imagen = document.getElementById('logoInicio');
  imagen.style.position= 'absolute'; 
  imagen.style.top = posicionTopLogo;
  imagen.style.left = '-400px';
  imagen.style.visibility='hidden';
  movimientoDerecha();
} 
function movimientoDerecha()
{
    if (parseFloat(imagen.style.left)<=parseFloat(window.outerWidth)/4)
    { 
        imagen.style.left = parseInt(imagen.style.left) + 10 + 'px';
        imagen.style.visibility = 'visible';
        time = setTimeout(movimientoDerecha,10);
    }
    else
    pararAnimacion();
}

function pararAnimacion()
{
  clearTimeout(timer);
} 

function cerrarMenus()
{
  var busMenu = document.getElementsByClassName('contenedorBoton-content');
    for (var i = 0; i < busMenu.length; i++)
    {
      var menuAbierto = busMenu[i];
      if (menuAbierto.classList.contains('show')) 
      {
        menuAbierto.classList.remove('show');
        cerrarResponsive();
      }
    }
}

/**Eventos**/

/**
 * Funcion encargada de tomar el evento al activarse la función onclick mediante el DOM y cerrar el menu desplegable.
 * @param {e} evento Variable de evento.
 */
window.onclick = function(e) 
{
  if (!e.target.matches('.dropContenedor')) 
  {
    cerrarMenus();
  }
} 


window.addEventListener("resize", movimientoLogo);

window.onload = movimientoLogo;
