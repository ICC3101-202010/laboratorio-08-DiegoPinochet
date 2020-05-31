using Lab8_Diego_Pinochet.CustomArgs;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Diego_Pinochet
{
    public partial class Form1 : Form
    {
        public delegate string AddLocalEventHandler(object source, LocalesEventArgs args);
        public event AddLocalEventHandler AddLocalCreateLocalButton_Clicked;
        public delegate List<Locales> ListLocalEventHandler(object source, LocalesEventArgs args);
        public event ListLocalEventHandler InfoPanelChooseButton_Clicked;


        public Form1()
        {
            InitializeComponent();
        }

        //<<ADD LOCAL>>
        private void InitializeAddLocalButton_Click(object sender, EventArgs e)
        {
            DisplayListPanel.BringToFront();

        }
        private void AddLocalChooseButton_Click(object sender, EventArgs e)
        {
            string localType = AddLocalDomainUp.Text;
            switch (localType)
            {
                case "Tienda":
                    AddLocalStoreCatLabel.Visible = true;
                    AddLocalStoreCatTextBox.Visible = true;
                    break;
                case "Cine":
                    AddLocalNumSalaLabel.Visible = true;
                    AddLocalNumSalaTextBox.Visible = true;              
                    break;
                case "Restaurant":
                    AddLocalVipTablesLabel.Visible = true;
                    AddLocalVipTablesCheckBox.Visible = true;
                    break;
            }
        }
        private void AddLocalCreateLocalButton_Click(object sender, EventArgs e)
        {
            string ownerName = AddLocalOwnerNameTextBox.Text;
            int identNum = int.Parse(AddLocalIdentNumTextbox.Text);
            string attentionHour = AddLocalAttentionHourTextbox.Text;
            string localType = AddLocalDomainUp.Text;
            string especific = null;

            switch (localType)
            {
                case "Tienda":
                    especific = AddLocalStoreCatTextBox.Text;
                  
                    break;
                case "Cine":
                    especific = AddLocalNumSalaTextBox.Text;
                  
                    break;
                case "Restaurant":
                    especific = AddLocalVipTablesCheckBox.Checked.ToString();
                    
                    break;
            }
            OnAddLocalCreateLocalButton_Click(ownerName, identNum, attentionHour, especific);
            AddLocalStoreCatLabel.Visible = false;
            AddLocalStoreCatTextBox.Visible = false;
            AddLocalNumSalaLabel.Visible = false;
            AddLocalNumSalaTextBox.Visible = false;
            AddLocalVipTablesLabel.Visible = false;
            AddLocalVipTablesCheckBox.Visible = false;
        }

        //<<INFO LOCAL>>
        private void InitializeInfoButton_Click(object sender, EventArgs e)
        {
            InfoPanel.BringToFront();
        }
        private void InfoPanelChooseButton_Click(object sender, EventArgs e)
        {
            //InfoPanelDisplayInfoTextBox.Clear();
            int indentNum = int.Parse(InfoPanelIdentNumTextbox.Text);
            OnInfoPanelChooseButton_Click(indentNum);
        }

        private void InfoPanelGoBackButton_Click(object sender, EventArgs e)
        {
            InitializePanel.BringToFront();
            InfoPanelIdentNumTextbox.Clear();
            InfoPanelDisplayInfoTextBox.Clear();
        }

        //<<LOCAL LIST>>
        private void InitializeAllLocalsButton_Click(object sender, EventArgs e)
        {
            AddLocalPanel.BringToFront();
            InitializeAllLocalsButton_Click();
        }
        private void DisplayListGoBackButton_Click(object sender, EventArgs e)
        {
            InitializePanel.BringToFront();
            DisplayListLocalsTextbox.Clear();
        }

        //<<METODOS INTERNOS>>

        public void OnAddLocalCreateLocalButton_Click(string lName, int lnum, string lhour, string lespecific)
        {
            if(AddLocalCreateLocalButton_Clicked != null)
            {
                string result = AddLocalCreateLocalButton_Clicked(this, new LocalesEventArgs() { EspecificText = lespecific, HoursText = lhour, IdentNumText = lnum, NameText = lName });
                if(result == null)
                {
                    AddLocalInvalidCredentialsTextBox.AppendText("Local creado correctamente!!");
                    Thread.Sleep(2000);
                    AddLocalOwnerNameTextBox.Clear();
                    AddLocalAttentionHourTextbox.Clear();
                    AddLocalIdentNumTextbox.Clear();
                    AddLocalInvalidCredentialsTextBox.Clear();
                    InitializePanel.BringToFront();
                    AddLocalStoreCatTextBox.Clear();
                    AddLocalNumSalaTextBox.Clear();

                }
                else
                {
                    AddLocalInvalidCredentialsTextBox.AppendText(result);
                    Thread.Sleep(2000);
                    AddLocalOwnerNameTextBox.Clear();
                    AddLocalAttentionHourTextbox.Clear();
                    AddLocalIdentNumTextbox.Clear();
                    AddLocalInvalidCredentialsTextBox.Clear();
                    InitializePanel.BringToFront();
                    AddLocalStoreCatTextBox.Clear();
                    AddLocalNumSalaTextBox.Clear();
                }
            }
        }  
        
        public void OnInfoPanelChooseButton_Click(int identNum)
        {
            InfoPanelDisplayInfoTextBox.Clear();
            List<Locales> tiendasTotales = new List<Locales>();
            List<Locales> cineTotales = new List<Locales>();
            List<Locales> restTotales = new List<Locales>();
            List<int> identTotales = new List<int>();
            if(InfoPanelChooseButton_Clicked != null)
            {
                List<Locales> localesList = InfoPanelChooseButton_Clicked(this, new LocalesEventArgs());
                if(localesList != null)
                {
                    InfoPanelDisplayInfoTextBox.Visible = true;
                    foreach (Locales local in localesList)
                    {

                        if (local.LocalType == "Tienda") 
                        {
                            tiendasTotales.Add(local);
                            foreach (Tienda tienda in tiendasTotales)
                            {
                                if (tienda.IdentifierNum == identNum)
                                {
                                    InfoPanelDisplayInfoTextBox.Clear();
                                    InfoPanelDisplayInfoTextBox.AppendText(tienda.ToString());
                                    DisplayListLocalsTextbox.AppendText(tienda.ToString());
                                    identTotales.Add(tienda.IdentifierNum);
                                }
                            }        
                        }
                        else if (local.LocalType == "Cine")
                        {
                            cineTotales.Add(local);
                            foreach (Cine cine in cineTotales)
                            {
                                if (cine.IdentifierNum == identNum)
                                {
                                    InfoPanelDisplayInfoTextBox.Clear();
                                    InfoPanelDisplayInfoTextBox.AppendText(cine.ToString());
                                    DisplayListLocalsTextbox.AppendText(cine.ToString());
                                    identTotales.Add(cine.IdentifierNum);
                                }
                            }
                            
                        }
                        else if (local.LocalType == "Rest")
                        {
                            restTotales.Add(local);
                            foreach (Restaurant restaurant in restTotales)
                            {
                                if (restaurant.IdentifierNum == identNum)
                                {
                                    InfoPanelDisplayInfoTextBox.Clear();
                                    InfoPanelDisplayInfoTextBox.AppendText(restaurant.ToString());
                                    DisplayListLocalsTextbox.AppendText(restaurant.ToString());
                                    identTotales.Add(restaurant.IdentifierNum);
                                }
                            }
                            
                        }
                        if (identTotales.Contains(identNum) == false)
                        {
                           InfoPanelDisplayInfoTextBox.Clear();
                           InfoPanelDisplayInfoTextBox.AppendText("Este local no existe");
                        }
                    }
                    
                    
                }
            }
        }
        public void InitializeAllLocalsButton_Click()
        {
            DisplayListLocalsTextbox.Clear();
            List<Locales> tiendasTotales = new List<Locales>();
            List<Locales> cineTotales = new List<Locales>();
            List<Locales> restTotales = new List<Locales>();
            string var = "";
            if (InfoPanelChooseButton_Clicked != null)
            {
                List<Locales> localesList = InfoPanelChooseButton_Clicked(this, new LocalesEventArgs());
                if (localesList != null)
                {
                    foreach (Locales local in localesList)
                    {
                        if (local.LocalType == "Tienda")
                        {
                            tiendasTotales.Add(local);
                            foreach (Tienda tienda in tiendasTotales)
                            {
                                var += tienda.ToString() + "\n";
                                
                            }
                        }
                        else if (local.LocalType == "Cine")
                        {
                            cineTotales.Add(local);
                            foreach (Cine cine in cineTotales)
                            {
                                var += cine.ToString() + "\n";
                            }

                        }
                        else if (local.LocalType == "Rest")
                        {
                            restTotales.Add(local);
                            foreach (Restaurant restaurant in restTotales)
                            {
                                var += restaurant.ToString() + "\n";
                            }

                        }
                    }
                }
                DisplayListLocalsTextbox.Text = var;
            }
        }
    }
}
