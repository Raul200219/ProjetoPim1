using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPim1
{

}
public class TelaPrincipal : Form
{
    private Panel telaBemVindo;
    private Panel telaProxima;
    private Panel telaCadastro;

    public TelaPrincipal()
    {
        Text = "Tela Principal";
        Size = new System.Drawing.Size(1200,600);



        // Tela de Boas-Vindas
        telaBemVindo = new Panel();
        telaBemVindo.Dock = DockStyle.Fill;

        Label labelBemVindo = new Label();
        labelBemVindo.Text = "Bem Vindo";
        labelBemVindo.Font = new Font("Arial", 20, FontStyle.Bold);
        labelBemVindo.TextAlign = ContentAlignment.MiddleCenter;
        labelBemVindo.Dock = DockStyle.Fill;

        Button btnProximaTela = new Button();
        btnProximaTela.Text = "Próxima Tela";
        btnProximaTela.Dock = DockStyle.Bottom;
        btnProximaTela.Font = new Font("Arial", 12, FontStyle.Bold);
        btnProximaTela.Click += (sender, e) => MostrarTelaProxima();

        telaBemVindo.Controls.Add(labelBemVindo);
        telaBemVindo.Controls.Add(btnProximaTela);

        // Tela da Próxima Etapa
        telaProxima = new Panel();
        telaProxima.Dock = DockStyle.Fill;

        Label labelProxima = new Label();
        labelProxima.Text = "Esta é a próxima tela!";
        labelProxima.Font = new Font("Arial", 20, FontStyle.Bold);
        labelProxima.TextAlign = ContentAlignment.MiddleCenter;
        labelProxima.Dock = DockStyle.Fill;

        Button btnCadastrarUsuario = new Button();
        btnCadastrarUsuario.Text = "Cadastrar Usuario";
        btnCadastrarUsuario.Dock = DockStyle.Bottom;
        btnCadastrarUsuario.Font = new Font("Arial", 12, FontStyle.Bold);
        btnCadastrarUsuario.Click += (sender, e) => MostrarTelaCadastro();


        Button btnVoltar = new Button();
        btnVoltar.Text = "Voltar";
        btnVoltar.Dock = DockStyle.Bottom;
        btnVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
        btnVoltar.Click += (sender, e) => MostrarTelaBemVindo();



        telaProxima.Controls.Add(labelProxima);
        telaProxima.Controls.Add(btnCadastrarUsuario);
        telaProxima.Controls.Add(btnVoltar);

        

        Controls.Add(telaBemVindo);

        //Tela De Cadastrar Funcionario

        telaCadastro = new Panel();
        telaCadastro.Dock = DockStyle.Fill;

        Label labelCadastro = new Label();
        labelCadastro.Text = "Esta é a tela de Cadastro de Funcionário!";
        labelCadastro.Font = new Font("Arial", 20, FontStyle.Bold);
        labelCadastro.TextAlign = ContentAlignment.MiddleCenter;
        labelCadastro.Dock = DockStyle.Fill;



        telaCadastro.Controls.Add(labelCadastro);

        
        




    }

    private void MostrarTelaProxima()
    {
        Controls.Remove(telaBemVindo);
        Controls.Add(telaProxima);
    }

    private void MostrarTelaBemVindo()
    {
        Controls.Remove(telaProxima);
        Controls.Add(telaBemVindo);
    }

    private void MostrarTelaCadastro()
    {
        Controls.Remove(telaCadastro);
        Controls.Add(telaCadastro);
    }

        [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new TelaPrincipal());
    }
}