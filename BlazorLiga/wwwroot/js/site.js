window.inicializarCarrusel = (id) => {
    const elemento = document.getElementById(id);

    if (elemento && window.bootstrap) {
        const carrusel = bootstrap.Carousel.getOrCreateInstance(elemento, {
            interval: 4000,
            ride: 'carousel',
            pause: false,
            wrap: true
        });

        carrusel.cycle();
    }
};