using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_VizualizadorImagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void bt_show_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Load(openFileDialog1.FileName);
                }
            }
            catch(Exception ex) { MessageBox.Show($"Erro: {ex.Message}"); }
           
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
            }
            catch (Exception ex) { MessageBox.Show($"Erro: {ex.Message}"); }

        }

        private void bt_corImagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                    pictureBox1.BackColor = colorDialog1.Color;
            }
            catch (Exception ex) { MessageBox.Show($"Erro: {ex.Message}"); }

        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show($"Erro: {ex.Message}"); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                else
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
            catch (Exception ex) { MessageBox.Show($"Erro: {ex.Message}"); }
        }
    }
}
