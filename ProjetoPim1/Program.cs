using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPim1
{

}
public class TelaPrincipal : Form
{
    private Panel telaBemVindo;
    private Panel telaProxima;

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

        Button cadastrarUsuario = new Button();
        btnCadastrar.Text = "Cadastrar Usuario";


        Button btnVoltar = new Button();
        btnVoltar.Text = "Voltar";
        btnVoltar.Dock = DockStyle.Bottom;
        btnVoltar.Font = new Font("Arial", 12, FontStyle.Bold);
        btnVoltar.Click += (sender, e) => MostrarTelaBemVindo();



        telaProxima.Controls.Add(labelProxima);
        telaProxima.Controls.Add(btnVoltar);

        Controls.Add(telaBemVindo);
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

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new TelaPrincipal());
    }
}