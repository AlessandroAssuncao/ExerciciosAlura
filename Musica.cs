﻿namespace ExerciciosAlura
{
    public class Musica
    {
        public Musica(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Id { get; set; }
        public string Artista { get; set; }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");

        }

        public override string ToString()
        {
            return @$"Id: {Id} Nome: {Nome}";
        }
    }
}
