using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace womens_race_project
{
    public partial class Form1 : Form
    {
        String []record=new string[3];
        private int peter = 120, john=120,goldi=120;
        public Form1()
        {
            InitializeComponent();
            record[0] = "";
            record[1] = "";
            record[2] = "";
        }

        private void Katie_pic_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        // 

        private void button2_Click(object sender, EventArgs e)
        {
            String playerName = "";
            int index = 0;
            if (Katie_pic.Checked == true)
            {
                playerName = "Katie";
             
            }
            else if (Jenny_pic.Checked == true)
            {
                playerName = "Jenny";
             
            }

            else if (filaspy_pic.Checked == true)
            {
                playerName = "Filasy";
             
            }
            if (!playerName.Equals(""))
            {
                if (!cbBetter.Text.Equals("") && !cbAmount.Text.Equals("")) {

                    record[cbBetter.SelectedIndex] = cbBetter.Text + " " + cbAmount.Text + " " + playerName;

                    btn_Play.Enabled = true;
                    int id = cbBetter.SelectedIndex;
                    if (id==0) {
                        record[id] += " " + peter;
                    }else if (id == 1)
                    {
                        record[id] += " " + john;
                    }
                    else if (id == 2)
                    {
                        record[id] += " " + goldi;
                    }
                    
                 

                }
                else
                {
                    MessageBox.Show("Must need to check the details ");

                }

            }




        }

        //timer object to run the objects

        private void timer1_Tick(object sender, EventArgs e)
        {
            rand rd = new rand();
            ControlGame cg = new ControlGame();
            if (pb1.Left < 750)
            {
                pb1.Left += rd.start();
            }
            else {
                timer1.Stop();
                MessageBox.Show("Katie Won the race ");

                if (!record[0].Equals(""))
                {

                    String peterAmt = cg.checkArray(record[0], "Katie");
                    peter = Convert.ToInt32(peterAmt);
                    peter_have.Text = "Peter has " + peter;
                }
                if (!record[1].Equals(""))
                {


                    String johnAmt = cg.checkArray(record[1], "Katie");
                    john = Convert.ToInt32(johnAmt);
                    john_have.Text = "John has " + john;
                }
                if (!record[2].Equals(""))
                {
                    String goldiAmt = cg.checkArray(record[2], "Katie");
                    goldi = Convert.ToInt32(goldiAmt);
                    goldi_have.Text = "Peter has " + goldi;
                }

                cbAmount.Text = "";
                cbBetter.Text = "";

                record[0] = "";
                record[1] = "";
                record[2] = "";

                pb1.Left = 0;
                pb2.Left = 0;
                Pb3.Left = 0;
                pb4.Left = 0;
            }
            if (pb2.Left < 750)
            {
                pb2.Left += rd.start();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Jenny Won the race ");

                if (!record[0].Equals("")) {
                    String peterAmt = cg.checkArray(record[0], "Jenny");
                    peter = Convert.ToInt32(peterAmt);
                    peter_have.Text = "Peter has " + peter;

                }

                if (!record[1].Equals("")) {
                    String johnAmt = cg.checkArray(record[1], "Jenny");
                    john = Convert.ToInt32(johnAmt);
                    john_have.Text = "John has " + john;
                }

                if (!record[2].Equals("")) {
                    String goldiAmt = cg.checkArray(record[2], "Jenny");
                    goldi = Convert.ToInt32(goldiAmt);
                    goldi_have.Text = "Peter has " + goldi;
                }



                cbAmount.Text = "";
                cbBetter.Text = "";

                record[0] = "";
                record[1] = "";
                record[2] = "";

                pb1.Left = 0;
                pb2.Left = 0;
                Pb3.Left = 0;
                pb4.Left = 0;
            }
            if (Pb3.Left < 750)
            {
                Pb3.Left += rd.start();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Filsay Won the race ");
                if (!record[0].Equals(""))
                {
                    String peterAmt = cg.checkArray(record[0], "Filasy");
                    peter = Convert.ToInt32(peterAmt);
                    peter_have.Text = "Peter has " + peter;

                }

                if (!record[1].Equals(""))
                {

                    String johnAmt = cg.checkArray(record[1], "Filasy");
                    john = Convert.ToInt32(johnAmt);
                    john_have.Text = "John has " + john;
                }

                if (!record[2].Equals(""))
                {

                    String goldiAmt = cg.checkArray(record[2], "Filasy");
                    goldi = Convert.ToInt32(goldiAmt);
                    goldi_have.Text = "Peter has " + goldi;

                }
                cbAmount.Text = "";
                cbBetter.Text = "";

                record[0] = "";
                record[1] = "";
                record[2] = "";
                pb1.Left = 0;
                pb2.Left = 0;
                Pb3.Left = 0;
                pb4.Left = 0;

            }
            if (pb4.Left < 750)
            {
                pb4.Left += rd.start();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Gosy Won the race ");

                if (!record[0].Equals(""))
                {

                    String peterAmt = cg.checkArray(record[0], "Gosy");
                    peter = Convert.ToInt32(peterAmt);
                    peter_have.Text = "Peter has " + peter;
                }
                if (!record[1].Equals(""))
                {
                    String johnAmt = cg.checkArray(record[1], "Gosy");
                    john = Convert.ToInt32(johnAmt);
                    john_have.Text = "John has " + john;
                }
                if (!record[2].Equals(""))
                {
                    String goldiAmt = cg.checkArray(record[2], "Gosy");
                    goldi = Convert.ToInt32(goldiAmt);
                    goldi_have.Text = "Peter has " + goldi;
                }

                cbAmount.Text = "";
                cbBetter.Text = "";

                record[0] = "";
                record[1] = "";
                record[2] = "";

                pb1.Left = 0;
                pb2.Left = 0;
                Pb3.Left = 0;
                pb4.Left = 0;
            }


        }

        // play button for running comands
        private void btn_Play_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (!record[0].Equals("")) {
                peter_have.Text = record[0];
            }
            if (!record[1].Equals(""))
            {
                john_have.Text = record[1];
            }
            if (!record[2].Equals(""))
            {
                goldi_have.Text = record[2];
            }

        }
    }
    class rand {
        Random rd = new Random();
        public int start() {
            
            return rd.Next(1, 50);
        }
    }
}
