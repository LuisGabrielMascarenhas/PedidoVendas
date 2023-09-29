using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidoVenda
{
    public partial class formPrincipal : Form
    {

        private List<Pedido> pedido = new List<Pedido>();

        public formPrincipal()
        {
            InitializeComponent();

        }
       
       
     

        private void btnAdicionarPedido_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {

        }

        private void listaPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class Pedido{ 
            public string nomeProduto { get; set; }

            public double precoUnitario { get; set; }
            
            public int quantidade { get; set; }

            public double calcularTotal()
            {
                return precoUnitario * quantidade;
            
            }
        }
    }
}
