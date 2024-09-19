namespace Mapas;

public interface IProvedorMapa
{
    public string NomeProvedor { get; }

    public string Mapa(string coordenadas);
    public string Rota(string origem, string destino);
} 