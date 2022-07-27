using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH3Pr7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SentenceLabel.Text = "";
        }

        private void SentenceLabel_Click(object sender, EventArgs e)
        {
            String Caviden = cavidenButton.Text;

            cavidenButton.Click += new EventHandler(this.SentenceLabel_Click);
            Button clickedButton = (Button)sender;

            //clickedButton.Text = "...button clicked...";
            Caviden = cavidenButton.Text;
            clickedButton.Enabled = false;

            SentenceLabel.Text = Caviden;



        }

        private void letterAButton_Click(object sender, EventArgs e)
        {
            letterAButton.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lowercaseaButton_Click(object sender, EventArgs e)
        {
            ///say hey if something is allready there add another word 
            ///How do I add to what has allready been clicked
            ///maybe generate this to where the application moves over on 
            ///spot with an equation moving over a space allways to not overwite what was allready written 
            ///but instead adding to it 
            // add a space button 

            //this.Click(SentenceLabel);
            //lowercaseaButton.Enabled = true;
            //String a = lowercaseaButton.Text;
            String output =lowercaseaButton.Text;

    lowercaseaButton.Click += new EventHandler(this.SentenceLabel_Click);
            Button clickedButton = (Button)sender;

            //clickedButton.Text = "...button clicked...";
            output = lowercaseaButton.Text ;
            clickedButton.Enabled = false;

            SentenceLabel.Text = output;

            //when the button is clicked move to sentenceLabel
        }

        private void cavidenButton_Click(object sender, EventArgs e)
        {
            String Caviden = cavidenButton.Text;

            cavidenButton.Click += new EventHandler(this.SentenceLabel_Click);
            Button clickedButton = (Button)sender;

            //clickedButton.Text = "...button clicked...";
            Caviden = cavidenButton.Text;
            clickedButton.Enabled = false;

            SentenceLabel.Text = Caviden ;

        }

        private void BisouBisouButton_Click(object sender, EventArgs e)
        {
            String Caviden = cavidenButton.Text;

            cavidenButton.Click += new EventHandler(this.SentenceLabel_Click);
            Button clickedButton = (Button)sender;

            //clickedButton.Text = "...button clicked...";
            Caviden = cavidenButton.Text;
            clickedButton.Enabled = false;

            SentenceLabel.Text = Caviden;



          

        }

        private void JeButton_Click(object sender, EventArgs e)
        {
            String Je = JeButton.Text;
            JeButton.Enabled = false;


            JeButton.Text = Je;


            JeButton.Click += new EventHandler(this.SentenceLabel_Click);
            Button clickedButton = (Button)sender;

            //clickedButton.Text = "...button clicked...";
          
            clickedButton.Enabled = false;

            SentenceLabel.Text = Je;


        }

        private void suisButton_Click(object sender, EventArgs e)
        {

        }

        private void exaclimationbutton_Click(object sender, EventArgs e)
        {

        }

        private void CoolButton_Click(object sender, EventArgs e)
        {

        }

        private void coucouButton_Click(object sender, EventArgs e)
        {

        }

        private void baibaiButton16_Click(object sender, EventArgs e)
        {

        }

        private void woButton_Click(object sender, EventArgs e)
        {

        }

        private void meigouButton_Click(object sender, EventArgs e)
        {

        }

        private void Renbutton_Click(object sender, EventArgs e)
        {

        }

        private void HereuseButton_Click(object sender, EventArgs e)
        {

        }

        private void cavaButton_Click(object sender, EventArgs e)
        {

        }

        private void masamenosbutton7_Click(object sender, EventArgs e)
        {

        }

        private void estbutton_Click(object sender, EventArgs e)
        {

        }

        private void bienButton_Click(object sender, EventArgs e)
        {

        }

        private void shiButton_Click(object sender, EventArgs e)
        {

        }

        private void questionButton_Click(object sender, EventArgs e)
        {

        }

        private void periodButton_Click(object sender, EventArgs e)
        {

        }

        private void CperiodButton_Click(object sender, EventArgs e)
        {
            CperiodButton.Enabled = false;  
        }

        private void Marissabutton_Click(object sender, EventArgs e)
        {
            Marissabutton.Enabled = false;
        }

        private void sympaButton_Click(object sender, EventArgs e)
        {
            sympaButton.Enabled = false;    

        }

        private void IlButton_Click(object sender, EventArgs e)
        {
            IlButton.Enabled = false;
        }

        private void SpaceButton_Click(object sender, EventArgs e)
        {
      
        }
    }
}
