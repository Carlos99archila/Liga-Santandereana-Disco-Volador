using Microsoft.AspNetCore.Components;
using BlazorLiga.Models;
using Microsoft.JSInterop;

namespace BlazorLiga.Pages.Home;

public partial class Home : ComponentBase
{
    private readonly List<string> imagenes =
    [
        "images/teams/Comunidad Cacique.png",
        "images/teams/Lebrija.png",
        "images/teams/Resistencia.png",
        "images/teams/Sudacas.png",
        "images/teams/Voltaje.png",
        "images/teams/Zen.png"
    ];

    private readonly Dictionary<string, Club> equipos = new()
    {
        ["Cacique"] = new Club
        {
            Nombre = "Comunidad Cacique",
            Imagen = "images/teams/Comunidad Cacique.png",
            Enlace = "https://www.instagram.com/comunidadcaciqueuc"
        },

        ["Lebrija"] = new Club
        {
            Nombre = "Lebrija",
            Imagen = "images/teams/Lebrija.png",
            Enlace = "https://www.instagram.com/lebrijaultimateclub"
        },

        ["Resistencia"] = new Club
        {
            Nombre = "Resistencia",
            Imagen = "images/teams/Resistencia.png",
            Enlace = "https://www.instagram.com/resistenciaultimateclub"
        },

        ["Sudacas"] = new Club
        {
            Nombre = "Sudacas",
            Imagen = "images/teams/Sudacas.png",
            Enlace = "https://www.instagram.com/sudacasuc"
        },

        ["Voltaje"] = new Club
        {
            Nombre = "Voltaje",
            Imagen = "images/teams/Voltaje.png",
            Enlace = "https://www.instagram.com/voltajeuc"
        },

        ["Zen"] = new Club
        {
            Nombre = "Zen",
            Imagen = "images/teams/Zen.png",
            Enlace = "https://www.instagram.com/zenultimateco"
        }
    };

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JS.InvokeVoidAsync(
                "inicializarCarrusel",
                "carouselPrincipal"
            );
        }
    }
}