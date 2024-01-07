using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Dava_Virgio_Kertawijaya_00000056848_IS431_B_UTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            string pesan;
            string output = null;
            String grade = null;
            int total = 0;

            int nilai = Convert.ToInt32(textBoxInput.Text);
            int[] array = new int[nilai];
            for (int i = 0; i < nilai; i++)
            {
                array[i] = Convert.ToInt32(Interaction.InputBox(pesan = "Masukan Nilai ke - " + (i + 1)));
                total = total + array[i];
                output += (i + 1) + " Nilainya " + array[i] + "\r";
                richTextBoxOutput.Text = Convert.ToString(output);
                labelTotalOutput.Text = Convert.ToString(total);
                
                Grade nilaiHuruf = new Grade();
                grade = nilaiHuruf.hitungGrade(nilai, total);
                labelGradeOutput.Text = grade;
            }
        }
    }
}
