using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Repository;
using Repository.Model;

namespace TPEncuestaWin
{
    public partial class FormEncuesta : Form
    {
        public FormEncuesta()
        {
            InitializeComponent();
        }

        private void FormEncuesta_Load(object sender, EventArgs e)
        {
            //ContextRepository cx = new ContextRepository();
            //Encuesta e = nuevaEncuesta();

            foreach(PreguntaEncuesta p in e.preguntas)
            {
                Panel p1 = new Panel();
                p1.Parent = this;
                p1.Dock = DockStyle.Top;
                Label l1 = new Label();
                l1.Parent = p1;
                //l1.Dock = DockStyle.Left;
                l1.Text = "Holi " + i;

                if (p1.Opciones.Count > 0)
                {
                    ComboBox cb = new ComboBox();
                    cb.Parent = p1;
                    cb.Dock = DockStyle.Fill;
                    cb.DataSource = p1.Opciones;
                }
                else
                {
                    TextBox tb = new TextBox();
                    tb.Parent = p1;
                    tb.Multiline = true;
                    tb.Dock = DockStyle.Fill;
                }
            }
        }
    }
}
