using GMap.NET.WindowsForms.Markers;
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
using System.Xml;
using System.Xml.Linq;

namespace Fire_and_Plan_Builder_V2
{
    public partial class AddCustomObcjectForm : Form
    {
        private List<string> _SingoloItems;
        private List<string> _LineaItems;

        public AddCustomObcjectForm(List<string> SingoloItems,List<string> LineaItems)
        {
            InitializeComponent();
            ColorMarkerCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ColorMarkerCB.Enabled = false;
            tipoCB.DropDownStyle = ComboBoxStyle.DropDownList;
            Array a = Enum.GetValues(typeof(GMarkerGoogleType));

            _SingoloItems = SingoloItems;
            _LineaItems = LineaItems;

            foreach( GMarkerGoogleType gmt in a)
            {
                ColorMarkerCB.Items.Add(gmt);
            }
            ColorMarkerCB.Items.RemoveAt(0);
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            if(nameTB.Text != "" && tipoCB.SelectedIndex  != -1 && ColorMarkerCB.SelectedIndex != -1 
               && (singoloRB.Checked || lineaRB.Checked || entrambiRB.Checked) && 
               (tipoCB.SelectedIndex == 3 && typeTB.Text !=""))
            {
                btnAggiungi.Enabled = true;
            }
            else
            {
                btnAggiungi.Enabled = false;
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            
            doc.Load(Application.StartupPath + Path.Combine(@"\Effetti\Effetti.xml"));

            
            if (singoloRB.Checked)
            {
                try
                {
                    XmlElement el = doc.CreateElement(typeTB.Text);

                    el.InnerText = valoreTB.Text;
                    el.SetAttribute("name", nameTB.Text);
                    el.SetAttribute("marker", ColorMarkerCB.Text);
                    doc.GetElementsByTagName("EffettiComboSingolo")[0].AppendChild(el);
                    doc.Save(Application.StartupPath + Path.Combine(@"\Effetti\Effetti.xml"));
                    MessageBox.Show("Effetto aggiunto correttamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBoxEffettiSingolo.Items.Add(nameTB.Text);
                    
                }
                catch
                {
                    MessageBox.Show("Errore nell'inserimento dell'effetto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (lineaRB.Checked)
            {
                try
                {
                    XmlElement el = doc.CreateElement(typeTB.Text);

                    el.InnerText = valoreTB.Text;
                    el.SetAttribute("name", nameTB.Text);
                    el.SetAttribute("marker", ColorMarkerCB.Text);
                    doc.GetElementsByTagName("EffettiComboLinea")[0].AppendChild(el);
                    doc.Save(Application.StartupPath + Path.Combine(@"\Effetti\Effetti.xml"));
                    MessageBox.Show("Effetto aggiunto correttamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBoxEffettiLinea.Items.Add(nameTB.Text);
                }
                catch
                {
                    MessageBox.Show("Errore nell'inserimento dell'effetto.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (entrambiRB.Checked)
            {
                try
                {
                    XmlElement el = doc.CreateElement(typeTB.Text);

                    el.InnerText = valoreTB.Text;
                    el.SetAttribute("name", nameTB.Text);
                    el.SetAttribute("marker", ColorMarkerCB.Text);
                    doc.GetElementsByTagName("EffettiComboSingolo")[0].AppendChild(el);
                    doc.Save(Application.StartupPath + Path.Combine(@"\Effetti\Effetti.xml"));
                    MessageBox.Show("Effetto aggiunto correttamente nella combo del panel Singolo.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBoxEffettiSingolo.Items.Add(nameTB.Text);
                }
                catch
                {
                    MessageBox.Show("Errore nell'inserimento dell'effetto nella combo del panel Singolo.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    XmlElement el = doc.CreateElement(typeTB.Text);

                    el.InnerText = valoreTB.Text;
                    el.SetAttribute("name", nameTB.Text);
                    el.SetAttribute("marker", ColorMarkerCB.Text);
                    doc.GetElementsByTagName("EffettiComboLinea")[0].AppendChild(el);
                    doc.Save(Application.StartupPath + Path.Combine(@"\Effetti\Effetti.xml"));
                    MessageBox.Show("Effetto aggiunto correttamente nella combo del panel Linea.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBoxEffettiLinea.Items.Add(nameTB.Text);
                }
                catch
                {
                    MessageBox.Show("Errore nell'inserimento dell'effetto nella combo del panel Linea.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void AddCustomObcjectForm_Load(object sender, EventArgs e)
        {
            foreach ( string s in _SingoloItems)
            {
                listBoxEffettiSingolo.Items.Add(s);
            }
            foreach (string s in _LineaItems)
            {
                listBoxEffettiLinea.Items.Add(s);
            }
        }

        private void btnAnnulla2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxesSelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxEffettiSingolo.SelectedItems.Count > 0 || listBoxEffettiLinea.SelectedItems.Count > 0)
            {
                btnElimina.Enabled = true;
            }
            else
            {
                btnElimina.Enabled = false;
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(Application.StartupPath + Path.Combine(@"\Effetti\Effetti.xml"));
            List<string> itemsToRemove = new List<string>();

            if(listBoxEffettiSingolo.SelectedItems.Count > 0)
            {
                try
                {

                    foreach (string s in listBoxEffettiSingolo.SelectedItems)
                    {
                        foreach (XElement el in doc.Root.Element("EffettiComboSingolo").Elements())
                        {
                            if (el.Value == s)
                            {
                                el.Remove();
                                itemsToRemove.Add(el.Value);
                            }

                            break;
                        }
                    }
                    foreach (string s in itemsToRemove)
                    {
                        listBoxEffettiSingolo.Items.Remove(s);
                    }
                    MessageBox.Show("Effetti eliminati correttamente dalla combo effetti Singolo.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Errore nell'eliminare un effetto dalla combo effetti Singolo.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            itemsToRemove.Clear();

            if(listBoxEffettiLinea.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (string s in listBoxEffettiLinea.SelectedItems)
                    {
                        foreach (XElement el in doc.Root.Element("EffettiComboLinea").Elements())
                        {
                            if (el.Value == s)
                            {
                                el.Remove();
                                itemsToRemove.Add(el.Value);
                            }


                            break;
                        }
                    }

                    foreach (string s in itemsToRemove)
                    {
                        listBoxEffettiLinea.Items.Remove(s);
                    }
                    MessageBox.Show("Effetti eliminati correttamente dalla combo effetti Linea.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Errore nell'eliminare un effetto dalla combo effetti Linea.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            doc.Save(Application.StartupPath + Path.Combine(@"\Effetti\Effetti.xml"));
        }

        private void tipoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tipoCB.SelectedIndex)
            {
                case 0 :
                case 1 :
                    ColorMarkerCB.SelectedItem = GMarkerGoogleType.red;
                    ColorMarkerCB.Enabled = false;
                    typeTB.Enabled = false;
                    break;
                case 2:
                    ColorMarkerCB.SelectedItem = GMarkerGoogleType.yellow;
                    ColorMarkerCB.Enabled = false;
                    typeTB.Enabled = false;
                    break;
                case 3:
                    ColorMarkerCB.Enabled = true;
                    typeTB.Enabled = true;
                    break;
                default:
                    ColorMarkerCB.Enabled = false;
                    typeTB.Enabled = false;
                    btnAggiungi.Enabled = false;
                    break;
            }
        }
    }
}
