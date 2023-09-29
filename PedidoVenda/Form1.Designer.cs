
namespace PedidoVenda
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionarPedido = new System.Windows.Forms.Button();
            this.btnListarPedido = new System.Windows.Forms.Button();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(569, 113);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 0;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(133, 113);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(350, 113);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoUnitario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnAdicionarPedido
            // 
            this.btnAdicionarPedido.Location = new System.Drawing.Point(133, 139);
            this.btnAdicionarPedido.Name = "btnAdicionarPedido";
            this.btnAdicionarPedido.Size = new System.Drawing.Size(100, 23);
            this.btnAdicionarPedido.TabIndex = 6;
            this.btnAdicionarPedido.Text = "Adicionar Pedido";
            this.btnAdicionarPedido.UseVisualStyleBackColor = true;
            this.btnAdicionarPedido.Click += new System.EventHandler(this.btnAdicionarPedido_Click);
            // 
            // btnListarPedido
            // 
            this.btnListarPedido.Location = new System.Drawing.Point(350, 139);
            this.btnListarPedido.Name = "btnListarPedido";
            this.btnListarPedido.Size = new System.Drawing.Size(100, 23);
            this.btnListarPedido.TabIndex = 7;
            this.btnListarPedido.Text = "Listar Pedidos";
            this.btnListarPedido.UseVisualStyleBackColor = true;
            this.btnListarPedido.Click += new System.EventHandler(this.btnListarPedido_Click);
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Location = new System.Drawing.Point(569, 139);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(100, 23);
            this.btnCalcularTotal.TabIndex = 8;
            this.btnCalcularTotal.Text = "Calcular Total";
            this.btnCalcularTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.btnListarPedido);
            this.Controls.Add(this.btnAdicionarPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Name = "formPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionarPedido;
        private System.Windows.Forms.Button btnListarPedido;
        private System.Windows.Forms.Button btnCalcularTotal;
    }
}

