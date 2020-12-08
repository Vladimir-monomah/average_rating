using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Средняя_оценка
{
    

    public partial class FormAvgNote : Form
    {
        Note note=new Note();

        public FormAvgNote()
        {
            InitializeComponent();
            show_notes();
        }

        

        private void show_notes()
        {
            label_avg.Text = note.getAvg();
            label_qty.Text = note.getQty();
        }


        private void button_5_Click(object sender, EventArgs e)
        {
            note.AddNote(5);
            show_notes();
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            note.AddNote(4);
            show_notes();
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            note.AddNote(3);
            show_notes();
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            note.AddNote(2);
            show_notes();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            note.Clear();
            show_notes();
        }
    }
}
