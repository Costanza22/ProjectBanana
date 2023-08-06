using System;
using System.Collections.Generic;

public class GerenciamentoBananas
{
    private List<Banana> listaBananas;

    public GerenciamentoBananas()
    {
        listaBananas = new List<Banana>();
    }

    public void CadastrarBanana(Banana banana)
    {
        listaBananas.Add(banana);
    }

    public Banana BuscarBanana(int id)
    {
        return listaBananas.Find(b => b.Id == id);
    }

    public List<Banana> ListarBananas()
    {
        return listaBananas;
    }

    public void AtualizarBanana(int id, string nome, string origem, double peso, bool madura)
    {
        Banana banana = BuscarBanana(id);
        if (banana != null)
        {
            banana.Nome = nome;
            banana.Origem = origem;
            banana.Peso = peso;
            banana.Madura = madura;
        }
    }

    public void ExcluirBanana(int id)
    {
        Banana banana = BuscarBanana(id);
        if (banana != null)
        {
            listaBananas.Remove(banana);
        }
    }
}
