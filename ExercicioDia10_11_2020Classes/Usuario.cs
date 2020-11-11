namespace Exercicios_AED1.ExercicioDia10_11_2020Classes
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public Usuario(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString(){return "Nome: "+Nome+" Email: "+Email;} 
    }
}