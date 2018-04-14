using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acoes
{
    public partial class Form1 : Form
    {
        //ResultsMemento resultsMemento;
        //Results results;

        UIImplementor _ui;

        //public Form1(UIAbstraction ui)
        public Form1(UIImplementor ui)
        {
            InitializeComponent();
            _ui = ui;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();
                        
            try
            {
                _ui.OpenFile();
            }
            catch
            {
                textBoxResult.Text = "Erro ao carregar arquivo";
                return;
            }
            textBoxResult.Text = "Arquivo carregado com sucesso";            
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            //_ui.p

            textBoxResult.Clear();

            try
            {
                _ui.ProcessFile(checkBoxLastYear.Checked, checkBoxAllAsset.Checked, textBoxAsset.Text.Trim());
            }
            catch
            {
                textBoxResult.Text = "Erro ao processar arquivo";
                return;
            }

            refreshTextBox();           
            
        }

        public void refreshTextBox()
        {
            textBoxResult.Clear();
            textBoxResult.Text = _ui.results.TextResult();            
        }

        //public ResultsMemento SaveMemento(Results results)
        //{
        //    return new ResultsMemento(results);
        //}

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                _ui.RestoreLastResult();
            }
            catch
            {
                //MessageBox("Não há resultados a restaurar");
            }
            refreshTextBox();
        }

        private void checkBoxAllAsset_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxAllAsset.Checked == true)
            //    textBoxAsset.Enabled = false;
            //else
            //    textBoxAsset.Enabled = true;
        }
    }
}
