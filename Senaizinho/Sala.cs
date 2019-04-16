namespace Senaizinho
{
    public class Sala
    {
        public int numeroSala;
        public int capacidadeAtual = 0;
        public int capacidadeTotal = 1;
        public string[] alunos;

        public void Alocar(string nomeAluno){
            
            capacidadeAtual++;
            capacidadeTotal--;
            
        }
    }

}