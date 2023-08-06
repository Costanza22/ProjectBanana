public class Banana
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Origem { get; set; }
    public double Peso { get; set; }
    public bool Madura { get; set; }

    public Banana(int id, string nome, string origem, double peso, bool madura)
    {
        Id = id;
        Nome = nome;
        Origem = origem;
        Peso = peso;
        Madura = madura;
    }
}
