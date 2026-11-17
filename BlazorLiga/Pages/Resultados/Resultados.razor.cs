using Microsoft.AspNetCore.Components;

namespace BlazorLiga.Pages.Resultados;

public partial class Resultados : ComponentBase
{
    private string opcionSeleccionada = "Mixto";

    private void Seleccionar(string opcion)
    {
        opcionSeleccionada = opcion;
    }

    private string GetButtonClass(string opcion)
    {
        return opcionSeleccionada == opcion
            ? "btn btn-sm btn-dark mx-1"
            : "btn btn-sm btn-outline-dark mx-1";
    }
}