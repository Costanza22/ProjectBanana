import java.util.ArrayList;
import java.util.List;

public class GerenciamentoBananas {
    private List<Banana> listaBananas;

    public GerenciamentoBananas() {
        this.listaBananas = new ArrayList<>();
    }

    public void cadastrarBanana(Banana banana) {
        listaBananas.add(banana);
    }

    public Banana buscarBanana(int id) {
        for (Banana banana : listaBananas) {
            if (banana.getId() == id) {
                return banana;
            }
        }
        return null;
    }

    public List<Banana> listarBananas() {
        return listaBananas;
    }

    public void atualizarBanana(int id, String nome, String origem, double peso, boolean madura) {
        Banana banana = buscarBanana(id);
        if (banana != null) {
            banana.setNome(nome);
            banana.setOrigem(origem);
            banana.setPeso(peso);
            banana.setMadura(madura);
        }
    }

    public void excluirBanana(int id) {
        Banana banana = buscarBanana(id);
        if (banana != null) {
            listaBananas.remove(banana);
        }
    }
}

