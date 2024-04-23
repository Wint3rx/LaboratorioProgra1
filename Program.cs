using LaboratorioProgra1.Deportes;
using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 10;
    videoJuego.AnioLanzamiento = 2017;
    videoJuego.MostrarInformacion();
}

static void juegodeportes()
{
    futbol futbol = new futbol();
    futbol.Titulo = "FIFA 2024";
    futbol.Desarrolladora = "EA SPORTS";
    futbol.Calificacion = 5;
    futbol.AnioLanzamiento = 2024;
    futbol.MedidasCancha();

    baloncesto Baloncesto = new baloncesto();
    Baloncesto.Titulo = "NBA 2K24";
    Baloncesto.Desarrolladora = "EA SPORTS";
    Baloncesto.Calificacion = 7;
    Baloncesto.AnioLanzamiento = 2024;
    Baloncesto.MedidasCancha();
}
//Laboratorio();
VideoJuego.listaDeJuegos();



