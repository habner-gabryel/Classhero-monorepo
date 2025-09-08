using System;
using System.Text.RegularExpressions;

class PoliticaSenha
{
    public string senha { get; private set; }
    const int TAMANHO_MINIMO = 8;

    public PoliticaSenha(string senha)
    {
        validarTamanhoSenha(senha);
        validarLetraMaiuscula(senha);
        validarCaractereEspecial(senha);

        this.senha = senha;
    }

    private void validarTamanhoSenha(string senha)
    {
        if (senha.Length < TAMANHO_MINIMO)
        {
            throw new ArgumentException("A senha deve conter no mínimo " + TAMANHO_MINIMO + " caracteres.");
        }
    }

    private void validarLetraMaiuscula(string senha)
    {
        if (senha == senha.ToLower())
        {
            throw new ArgumentException("A senha deve conter no mínimo um caractere maiúsculo.");
        }
    }

    private void validarCaractereEspecial(string senha)
    {
        string pattern = "[^a-zA-Z0-9]";
        if (!Regex.IsMatch(senha, pattern))
        {
            throw new ArgumentException("A senha deve conter no mínimo um caractere especial.");
        }
    }
}