using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace teste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CriarTela();
        }

        private void CriarTela()
        {
            this.Text = "Cafeteria Login";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 230, 202);

            grid.Dock = DockStyle.Fill;
            grid.ColumnCount = 3;
            grid.RowCount = 6;

            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            for (int i = 0; i < 6; i++)
            {
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 16));
            }

            lblTitulo.Text = "☕ Café Aurora";
            lblTitulo.Font = new Font("Poppins", 24, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(111, 78, 55);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Dock = DockStyle.Fill;

            txtEmail.PlaceholderText = "Digite seu email";
            txtEmail.Font = new Font("Poppins", 12);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Height = 40;
            txtEmail.BackColor = Color.White;

            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Font = new Font("Poppins", 12);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.BackColor = Color.White;

            btnEntrar.Text = "Entrar";
            btnEntrar.Font = new Font("Poppins", 12, FontStyle.Bold);
            btnEntrar.BackColor = Color.FromArgb(111, 78, 55);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.Height = 45;
            btnEntrar.Cursor = Cursors.Hand;

            linkCadastro.Text = "Criar conta";
            linkCadastro.TextAlign = ContentAlignment.MiddleCenter;
            linkCadastro.LinkColor = Color.FromArgb(111, 78, 55);
            linkCadastro.Font = new Font("Poppins", 10);

            Panel card = new Panel();
            card.BackColor = Color.White;
            card.Dock = DockStyle.Fill;
            card.Padding = new Padding(30);

            TableLayoutPanel cardGrid = new TableLayoutPanel();
            cardGrid.Dock = DockStyle.Fill;
            cardGrid.RowCount = 5;
            cardGrid.ColumnCount = 1;

            for (int i = 0; i < 5; i++)
            {
                cardGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
            }

            cardGrid.Controls.Add(lblTitulo, 0, 0);
            cardGrid.Controls.Add(txtEmail, 0, 1);
            cardGrid.Controls.Add(txtSenha, 0, 2);
            cardGrid.Controls.Add(btnEntrar, 0, 3);
            cardGrid.Controls.Add(linkCadastro, 0, 4);

            card.Controls.Add(cardGrid);

            grid.Controls.Add(card, 1, 1);
            grid.SetRowSpan(card, 4);

            this.Controls.Add(grid);
        }
    }
}
        }
    }
}