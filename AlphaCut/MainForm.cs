using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AlphaCut
{
    public partial class MainForm : Form
    {
        string hasilTitikX1, hasilTitikX2;
        double panjangXMaksimal, ALPHA_CUT;
        int A, B, C, D;

        public MainForm()
        {
            InitializeComponent();
        }

        string menghitungAlphaCut(int x1, int y1, int x2, int y2, double alpha)
        {
            double rumusAlphaCut = (((alpha - y1) * (x2 - x1) / (y2 - y1)) + x1);
            return Convert.ToString(rumusAlphaCut);
        }

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            A = Convert.ToInt32(textboxTitikA.Text);
            B = Convert.ToInt32(textboxTitikB.Text);
            C = Convert.ToInt32(textboxTitikC.Text);

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;

            if (comboBoxPilih.Text == "Trapesium")
            {
                D = Convert.ToInt32(textboxTitikD.Text);
                chart1.ChartAreas[0].AxisX.Maximum = D + 10;
                panjangXMaksimal = D + 10;
                chart1.Series[0].Points.AddXY(A, 0);
                chart1.Series[0].Points.AddXY(B, 1);
                chart1.Series[0].Points.AddXY(C, 1);
                chart1.Series[0].Points.AddXY(D, 0);
            }
            else
            {
                chart1.ChartAreas[0].AxisX.Maximum = C + 10;
                panjangXMaksimal = C + 10;
                chart1.Series[0].Points.AddXY(A, 0);
                chart1.Series[0].Points.AddXY(B, 1);
                chart1.Series[0].Points.AddXY(C, 0);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            comboBoxPilih.Text = "Pilih Gambar";
            textboxTitikA.Text = "";
            textboxTitikB.Text = "";
            textboxTitikC.Text = "";
            textboxTitikD.Text = "";
            textboxAlphaCut.Text = "";
            textboxHasilAlphaCut.Text = "";
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            ALPHA_CUT = Convert.ToDouble(textboxAlphaCut.Text);

            if (comboBoxPilih.Text == "Trapesium")
            {
                hasilTitikX1 = menghitungAlphaCut(A, 0, B, 1, ALPHA_CUT);
                hasilTitikX2 = menghitungAlphaCut(D, 0, C, 1, ALPHA_CUT);
            }
            else
            {
                hasilTitikX1 = menghitungAlphaCut(A, 0, B, 1, ALPHA_CUT);
                hasilTitikX2 = menghitungAlphaCut(C, 0, B, 1, ALPHA_CUT);
            }
			
            chart1.Series[1].Points.AddXY(0, ALPHA_CUT);
            chart1.Series[1].Points.AddXY(panjangXMaksimal, ALPHA_CUT);
            chart1.Series[2].Points.AddXY(Convert.ToInt32(hasilTitikX1), ALPHA_CUT);
            chart1.Series[2].Points.AddXY(Convert.ToInt32(hasilTitikX1), 0);
            chart1.Series[2].IsValueShownAsLabel = true;
            chart1.Series[3].Points.AddXY(Convert.ToInt32(hasilTitikX2), ALPHA_CUT);
            chart1.Series[3].Points.AddXY(Convert.ToInt32(hasilTitikX2), 0);
            chart1.Series[3].IsValueShownAsLabel = true;
            textboxHasilAlphaCut.Text = "[" + hasilTitikX1 + "," + hasilTitikX2 + "]";
        }
    }
}
