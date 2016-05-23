using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System.Xml;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;

namespace Fire_and_Plan_Builder_V2
{
    public partial class Form1 : Form
    {
        GMapOverlay markerOverlay = new GMapOverlay("markers");

        private class ComboElement
        {
            public string type;
            public string name;
            public string markerColor;

            public ComboElement(string _type,string _name, string _markerColor)
            {
                type = _type;
                name = _name;
                markerColor = _markerColor;
            }

            public override string ToString()
            {
                return name;
            }
        }

        public Form1()
        {
            InitializeComponent();
            singoloEffettoCB.SelectedIndex = -1;
            singoloEffettoCB.DropDownStyle = ComboBoxStyle.DropDownList;
            lineaEffettoCB.SelectedIndex = -1;
            lineaEffettoCB.DropDownStyle = ComboBoxStyle.DropDownList;

            gMC.DragButton = MouseButtons.Left;
            //gMC.MapProvider = GMapProviders.GoogleMap;
            gMC.Position = new PointLatLng(41.961691, 12.7528982);
            gMC.Zoom = 5;
            gMC.Overlays.Add(markerOverlay);
            panelOverIncendio.BringToFront();

           
        }

        private void FillComboBoxes()
        {
            singoloEffettoCB.Items.Clear();
            lineaEffettoCB.Items.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + Path.Combine(@"\Effetti\Effetti.xml"));

            foreach (XmlElement el in doc.GetElementsByTagName("EffettiComboSingolo")[0].ChildNodes)
            {
                singoloEffettoCB.Items.Add(new ComboElement(el.LocalName, el.InnerText, el.Attributes[0].Value));
            }
            foreach (XmlElement el in doc.GetElementsByTagName("EffettiComboLinea")[0].ChildNodes)
            {
                lineaEffettoCB.Items.Add(new ComboElement(el.LocalName, el.InnerText, el.Attributes[0].Value));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.COMPILER == "\"\"")
            {
                compilerPathTB.Text = "NON IMPOSTATO!";
            }
            else
            {
                compilerPathTB.Text = Properties.Settings.Default.COMPILER;
                
            }
            #region vecchia lettura
            /*StreamReader file = new StreamReader(Application.StartupPath + Path.Combine(@"\Effetti\Elenco effetti.txt"));
            string line = "";
            string fase = "";
            while((line = file.ReadLine()) != null)
            {
                if(line.Contains("singolo:"))
                {
                    fase = "singolo";
                    continue;
                }
                else if (line.Contains("linea:"))
                {
                    fase = "linea";
                    continue;

                }

                switch (fase)
                {
                    case "singolo":
                        if (!line.Contains("linea:"))
                        {
                            singoloEffettoCB.Items.Add(new ComboElement(line.Split('|')[0], line.Split('|')[1]));
                        }
                        break;
                    case "linea":
                        if (!line.Contains("singolo:"))
                        {
                            lineaEffettoCB.Items.Add(new ComboElement(line.Split('|')[0], line.Split('|')[1]));
                        }
                        break;
                }
                
            }
            file.Close();*/
            #endregion

            FillComboBoxes();
        }

        private SceneryObject GetSceneryObjectFromComboBox(ref ComboBox cb)
        {
            if(((ComboElement)cb.SelectedItem).type == "Fire")
            {
                SceneryObject obj = new Fire(cb.Text, Convert.ToDouble(singoloLatTB.Text), Convert.ToDouble(singoloLonTB.Text));
                return obj;
            }
            else if (((ComboElement)cb.SelectedItem).type == "Smoke")
            {
                SceneryObject obj = new Smoke(cb.Text, Convert.ToDouble(singoloLatTB.Text), Convert.ToDouble(singoloLonTB.Text));
                return obj;
            }
            else if (((ComboElement)cb.SelectedItem).type == "Autocisterna")
            {
                SceneryObject obj = new Autocisterna(Convert.ToDouble(singoloLatTB.Text), Convert.ToDouble(singoloLonTB.Text));
                return obj;
            }
            else
            {
                SceneryObject obj = new CustomObject(((ComboElement)cb.SelectedItem).type, ((ComboElement)cb.SelectedItem).name,
                    Convert.ToDouble(singoloLatTB.Text), Convert.ToDouble(singoloLonTB.Text),
                    (GMarkerGoogleType) Enum.Parse(typeof(GMarkerGoogleType), ((ComboElement)cb.SelectedItem).markerColor));
                return obj;
            }
        }

        private void SingoloTBtextChange(object sender,EventArgs e)
        {
            if(singoloLatTB.Text != "" && singoloLonTB.Text != "")
            {
                creaWaypointBtn.Enabled = true;
            }
            else
            {
                creaWaypointBtn.Enabled = false;
            }

            if(creaWaypointBtn.Enabled && singoloEffettoCB.SelectedIndex != -1)
            {
                aggiungiScenarioBtn.Enabled = true;
            }
        }

        private void singoloEffettoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(singoloEffettoCB.SelectedIndex != -1 && creaWaypointBtn.Enabled)
            {
                aggiungiScenarioBtn.Enabled = true;

                if(singoloEffettoCB.Text.Contains("moke"))
                {
                    altezzaUpDn.Enabled = true;
                }
                else
                {
                    altezzaUpDn.Enabled = false;
                }
            }
            else if (singoloEffettoCB.SelectedIndex == -1)
            {
                aggiungiScenarioBtn.Enabled = false;
            }
        }

        private void SingoloFieldsClearAll()
        {
            singoloLatTB.Text = singoloLonTB.Text = "";
            singoloEffettoCB.SelectedIndex = -1;
        }

        private void LineaFieldsClearAll()
        {
            lineaLat1TB.Text = lineaLon1TB.Text = lineaLat2TB.Text = lineaLon2TB.Text = "";
            lineaEffettoCB.SelectedIndex = -1;
            lineaP1RB.Checked = true;
            lineaP2RB.Checked = false;
        }

        private void LineaCheckRadioButton(object sender,EventArgs e)
        {
            if (lineaP1RB.Checked)
            {
                lineaGB1.Enabled = true;
                lineaGB2.Enabled = false;
            }
            else if (lineaP2RB.Checked)
            {
                lineaGB2.Enabled = true;
                lineaGB1.Enabled = false;
            }
        }

        private void LineaCheckTextBox(object sender, EventArgs e)
        {
            if(lineaLat1TB.Text != "" && lineaLon1TB.Text != "" && lineaLat2TB.Text != "" && lineaLon2TB.Text != "")
            {
                lineaEffettoCB.Enabled = true;
            }
            else
            {
                lineaEffettoCB.Enabled = false;
            }
        }

        private void EnableSelezionatuttiAndCompilaBGL()
        {
            if(listBox.Items.Count > 0)
            {
                if (!selezionaTuttiCB.Enabled) selezionaTuttiCB.Enabled = true;
                if (!compilaBGLbtn.Enabled) compilaBGLbtn.Enabled = true;
            }
            else
            {
                if (selezionaTuttiCB.Enabled) selezionaTuttiCB.Enabled = false;
                if (compilaBGLbtn.Enabled) compilaBGLbtn.Enabled = false;
                if (selezionaTuttiCB.Checked) selezionaTuttiCB.Checked = false;
            }
        }

        private void StradeSatelliteRadioButtonChange(object sender, EventArgs e)
        {
            if (stradeRB.Checked)
            {
                gMC.MapProvider = GMapProviders.GoogleMap;
                Makefire.InsertTypeMapInComment("Str");
            }
            else if (satelliteRB.Checked)
            {
                gMC.MapProvider = GMapProviders.BingSatelliteMap;
                Makefire.InsertTypeMapInComment("Sat");
            }
        }

        private void aggiungiScenarioBtn_Click(object sender, EventArgs e)
        {
            SceneryObject toAdd = GetSceneryObjectFromComboBox(ref singoloEffettoCB);

            if(toAdd == null)
            {
                MessageBox.Show("Non è stato possibile creare l'oggetto. Errore sulla GetSceneryObjectFromComboBox.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SingoloFieldsClearAll();
                return;
            }
            else
            {
                if (toAdd.AddToXml(Makefire.filePath))
                {
                    
                    listBox.Items.Add(toAdd);
                    toAdd.AddMarkerToMap(ref markerOverlay);
  
                    MessageBox.Show("Oggetto creato ed inserito correttamente nel file XML.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SingoloFieldsClearAll();
                    EnableSelezionatuttiAndCompilaBGL();
                    return;
                }
                else
                {
                    MessageBox.Show("Errore nell'inserire l'oggetto nel file XML. Riprova.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SingoloFieldsClearAll();
                    return;
                }
            }
        }

        private void creaWaypointBtn_Click(object sender, EventArgs e)
        {
            Waypoint toAdd = new Waypoint(Convert.ToDouble(singoloLatTB.Text), Convert.ToDouble(singoloLonTB.Text));

            if (toAdd.AddToXml(Makefire.filePath))
            {
                listBox.Items.Add(toAdd);
                toAdd.AddMarkerToMap(ref markerOverlay);
                //gMC.Overlays.Add(markerOverlay);
                MessageBox.Show("Oggetto creato ed inserito correttamente nel file XML.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SingoloFieldsClearAll();
                EnableSelezionatuttiAndCompilaBGL();
                return;
            }
            else
            {
                MessageBox.Show("Errore nell'inserire l'oggetto nel file XML. Riprova.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SingoloFieldsClearAll();
                return;
            }
        }

        private void gMC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (tabControl2.SelectedIndex == 0)
                {
                    singoloLatTB.Text = gMC.FromLocalToLatLng(e.X, e.Y).Lat.ToString();
                    singoloLonTB.Text = gMC.FromLocalToLatLng(e.X, e.Y).Lng.ToString();
                }
                else if(tabControl2.SelectedIndex == 1)
                {
                    if (lineaP1RB.Checked)
                    {
                        lineaLat1TB.Text = gMC.FromLocalToLatLng(e.X, e.Y).Lat.ToString();
                        lineaLon1TB.Text = gMC.FromLocalToLatLng(e.X, e.Y).Lng.ToString();
                    }
                    else if (lineaP2RB.Checked)
                    {
                        lineaLat2TB.Text = gMC.FromLocalToLatLng(e.X, e.Y).Lat.ToString();
                        lineaLon2TB.Text = gMC.FromLocalToLatLng(e.X, e.Y).Lng.ToString();
                    }
                }
            }
        }

        private void cercaAreaBtn_Click(object sender, EventArgs e)
        {
            if(areaTB.Text != "")
            {
                GeoCoderStatusCode gcsc;

                try
                {
                    gMC.Position = (PointLatLng)GMapProviders.GoogleMap.GetPoint(areaTB.Text, out gcsc);

                    gMC.Zoom = 15;

                    if (!Makefire.InsertAreaInComment(areaTB.Text))
                    {
                        MessageBox.Show("Attenzione non hai ancora creato il file XML oppure non è stato creato correttamente.", "Attenzione", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Impossibile Trovare l'area ricercata al momento. Potrebbe essere un problema dei server Google.");
                }
            }
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML |*.xml";

            DialogResult result = save.ShowDialog();

            if(result == DialogResult.OK)
            {
                if (Makefire.CreateFile(save.FileName))
                {
                    listBox.Items.Clear();
                    markerOverlay.Markers.Clear();
                    MessageBox.Show("File XML creato correttamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelOverIncendio.Visible = false;
                    areaTB.Focus();
                }
                else
                {
                    MessageBox.Show("Errore nel creare il file XML.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    panelOverIncendio.Visible = true;
                }
            }
        }

        private void apriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = Makefire.LoadFile();
            if(result == DialogResult.OK)
            {
                listBox.Items.Clear();
                markerOverlay.Markers.Clear();

                double lat = 0;
                double lon = 0;
                SceneryObject n;

                foreach (XmlElement el in Makefire.doc.GetElementsByTagName("SceneryObject"))
                {
                    lat = Convert.ToDouble(el.Attributes["lat"].InnerText.Replace(".",","));
                    lon = Convert.ToDouble(el.Attributes["lon"].InnerText.Replace(".",","));

                    if (el.FirstChild.Name == "Effect")
                    {
                        if (el.FirstChild.Attributes[0].InnerText.Contains("Fire"))
                        {
                            n = new Fire(el.FirstChild.Attributes[0].InnerText, lat, lon);
                            
                            n.AddMarkerToMap(ref markerOverlay);
                            n.MarkAsAddedToXml();
                            listBox.Items.Add(n);
                            
                        }
                        else if (el.FirstChild.Attributes[0].InnerText.Contains("moke"))
                        {
                            n = new Smoke(el.FirstChild.Attributes[0].InnerText, lat, lon);
                           
                            n.AddMarkerToMap(ref markerOverlay);
                            n.MarkAsAddedToXml();
                            listBox.Items.Add(n);
                           
                        }

                        else
                        {
                            XDocument doc = XDocument.Load(Application.StartupPath + Path.Combine(@"\Effetti\Effetti.xml"));

                            foreach (XElement i in doc.Root.Element("EffettiComboSingolo").Elements())
                            {
                                if (i.Value == el.FirstChild.Attributes[0].Value)
                                {
                                    n = new CustomObject(i.Name.ToString(), i.Value, lat, lon,
                                        (GMarkerGoogleType)Enum.Parse(typeof(GMarkerGoogleType), i.FirstAttribute.Value));
                                    n.AddMarkerToMap(ref markerOverlay);
                                    n.MarkAsAddedToXml();
                                    listBox.Items.Add(n);

                                    break;
                                }
                            }

                            foreach (XElement i in doc.Root.Element("EffettiComboLinea").Elements())
                            {
                                if (i.Value == el.FirstChild.Attributes[0].Value)
                                {
                                    n = new CustomObject(i.Name.ToString(), i.Value, lat, lon,
                                        (GMarkerGoogleType)Enum.Parse(typeof(GMarkerGoogleType), i.FirstAttribute.Value));
                                    n.AddMarkerToMap(ref markerOverlay);
                                    n.MarkAsAddedToXml();
                                    listBox.Items.Add(n);

                                    break;
                                }
                            }

                        }
                    }
                    else if (el.FirstChild.Name == "LibraryObject")
                    {
                        n = new Autocisterna(lat, lon);
                       
                        n.AddMarkerToMap(ref markerOverlay);
                        n.MarkAsAddedToXml();
                        listBox.Items.Add(n);

                    }
                }

                foreach (XmlElement el in Makefire.doc.GetElementsByTagName("Waypoint"))
                {
                    lat = Convert.ToDouble(el.Attributes["lat"].InnerText.Replace(".", ","));
                    lon = Convert.ToDouble(el.Attributes["lon"].InnerText.Replace(".", ","));
                    n = new Waypoint(lat, lon);
                  
                    n.AddMarkerToMap(ref markerOverlay);
                    n.MarkAsAddedToXml();
                    listBox.Items.Add(n);
                }
                panelOverIncendio.Visible = false;
                areaTB.Focus();
            }

            EnableSelezionatuttiAndCompilaBGL();
            areaTB.Text = Makefire.GetAreaFromComment().Substring(6);
            string position = Makefire.GetPositionFromComment().Substring(11);
            double Lat = 0;
            double Lng = 0;
            int index = 16;
            bool continua = true;
            do
            {
                try
                {
                    Lat = Convert.ToDouble(position.Substring(5, index));
                    continua = false;

                }
                catch
                {
                    index--;
                }
            } while (continua);


            continua = true;
            index = 16;
            do
            {
                try
                {
                    Lng = Convert.ToDouble(position.Substring(27, index));
                    continua = false;

                }
                catch
                {
                    index--;
                }
            } while (continua);
         
            if (areaTB.Text != "")
            {
                //gMC.Position = (PointLatLng)GMapProviders.GoogleMap.GetPoint(areaTB.Text, out gcsc);
                gMC.Position = new PointLatLng(Lat, Lng);
                gMC.Zoom = 15;
            }

            if(Makefire.GetMapTypeFromComment().Contains("Sat"))
            {
                gMC.MapProvider = GMapProviders.BingSatelliteMap;
                satelliteRB.CheckedChanged -= StradeSatelliteRadioButtonChange;
                satelliteRB.Checked = true;
                satelliteRB.CheckedChanged += StradeSatelliteRadioButtonChange;
                /*stradeRB.CheckedChanged -= StradeSatelliteRadioButtonChange;
                stradeRB.Checked = false;
                stradeRB.CheckedChanged += StradeSatelliteRadioButtonChange;*/

            }
            else if(Makefire.GetMapTypeFromComment().Contains("Str"))
            {
                gMC.MapProvider = GMapProviders.GoogleMap;
                stradeRB.CheckedChanged -= StradeSatelliteRadioButtonChange;
                stradeRB.Checked = true;
                stradeRB.CheckedChanged += StradeSatelliteRadioButtonChange;
                /*satelliteRB.CheckedChanged -= StradeSatelliteRadioButtonChange;
                satelliteRB.Checked = false;
                satelliteRB.CheckedChanged += StradeSatelliteRadioButtonChange;*/

            }
            else
            {
                gMC.MapProvider = GMapProviders.GoogleMap;
            }
            
        }

        private void listBox_Format(object sender, ListControlConvertEventArgs e)
        {
            foreach(SceneryObject s in listBox.Items)
            {
                s.ToString();
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox.SelectedItems.Count > 0)
            {
                eliminaSelezionatiBtn.Enabled = true;
            }
            else
            {
                eliminaSelezionatiBtn.Enabled = false;
            }
        }

        private void eliminaSelezionatiBtn_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection elements = new ListBox.SelectedObjectCollection(listBox);
            elements = listBox.SelectedItems;
            string name = "";
            string messaggioErroreEliminati = " 0";
            int eliminati = 0;
            MessageBoxIcon icona = MessageBoxIcon.Information;
            for(int i = elements.Count - 1; i >= 0; i--)
            {
                name = ((SceneryObject)elements[i]).ToString();
                if (((SceneryObject)elements[i]).RemoveFromXml(Makefire.filePath))
                {

                    ((SceneryObject)elements[i]).RemoveMarkerFromMap(ref markerOverlay);
                    
                    listBox.Items.Remove(elements[i]);
                    //MessageBox.Show( name + " eliminato correttamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    eliminati++;
                }
                else
                {
                    // MessageBox.Show("Errore nell'eliminare " + name, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    messaggioErroreEliminati += "\n" + "Errore nell'eliminare " + name;
                }
                if(listBox.SelectedItems.Count == 0) eliminaSelezionatiBtn.Enabled = false;

                if(eliminati == 0 && messaggioErroreEliminati != " 0")
                {
                    icona = MessageBoxIcon.Error;
                }
                else if(eliminati > 0 && messaggioErroreEliminati != " 0")
                {
                    icona = MessageBoxIcon.Warning;
                }
            }
            MessageBox.Show("Itmes eliminati correttamente: " + eliminati + "\nErrori: " + messaggioErroreEliminati,"Informazini",MessageBoxButtons.OK, icona);

            EnableSelezionatuttiAndCompilaBGL();
        }

        private void gMC_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            foreach(SceneryObject s in listBox.Items)
            {
                if (s.ContainsMarker((GMarkerGoogle)item))
                {
                    if (!listBox.SelectedItems.Contains(s))
                    {
                        listBox.SelectedItems.Add(s);
                    }
                    else
                    {
                        listBox.SelectedItems.Remove(s);
                    }
                    break;
                }
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lineaEffettoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lineaEffettoCB.SelectedIndex != -1)
            {
                lineaCreaBtn.Enabled = true;
            }
            else
            {
                lineaCreaBtn.Enabled = false;
            }
        }

        private void lineaCreaBtn_Click(object sender, EventArgs e)
        {
            double lat1 = 0;
            double lon1 = 0;
            double lat2 = 0;
            double lon2 = 0;

                lat1 = Convert.ToDouble(lineaLat1TB.Text);
                lon1 = Convert.ToDouble(lineaLon1TB.Text);
                lat2 = Convert.ToDouble(lineaLat2TB.Text);
                lon2 = Convert.ToDouble(lineaLon2TB.Text);


            SceneryObject f1;// new Fire(lineaEffettoCB.Text, lat1, lon1);
            SceneryObject f2; //new Fire(lineaEffettoCB.Text, lat2, lon2);

            switch (((ComboElement)lineaEffettoCB.SelectedItem).type)
            {
                case "Fire":
                    f1 = new Fire(((ComboElement)lineaEffettoCB.SelectedItem).name, lat1, lon1);
                    f2 = new Fire(((ComboElement)lineaEffettoCB.SelectedItem).name, lat2, lon2);
                    break;
                case "Smoke":
                    f1 = new Smoke(((ComboElement)lineaEffettoCB.SelectedItem).name, lat1, lon1);
                    f2 = new Smoke(((ComboElement)lineaEffettoCB.SelectedItem).name, lat2, lon2);
                    break;
                case "Autocisterna":
                    f1 = new Autocisterna(lat1, lon1);
                    f2 = new Autocisterna(lat2, lon2);
                    break;
                default:
                    f1 = new CustomObject(((ComboElement)lineaEffettoCB.SelectedItem).type, ((ComboElement)lineaEffettoCB.SelectedItem).name, lat1, lon1,
                        (GMarkerGoogleType) Enum.Parse(typeof(GMarkerGoogleType), ((ComboElement)lineaEffettoCB.SelectedItem).markerColor)
                        );
                    f2 = new CustomObject(((ComboElement)lineaEffettoCB.SelectedItem).type, ((ComboElement)lineaEffettoCB.SelectedItem).name, lat2, lon2,
                        (GMarkerGoogleType)Enum.Parse(typeof(GMarkerGoogleType), ((ComboElement)lineaEffettoCB.SelectedItem).markerColor)
                        );
                    break;
            }

            List<SceneryObject> objects = Makefire.CreateLineFire(f1, f2);
            foreach(SceneryObject f in objects)
            {
                f.AddToXml(Makefire.filePath);
                f.AddMarkerToMap(ref markerOverlay);
                listBox.Items.Add(f);

            }
            LineaFieldsClearAll();
            EnableSelezionatuttiAndCompilaBGL();
            MessageBox.Show("Sono stati aggiunti " + objects.Count + " oggetti correttamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void selezionaTuttiCB_CheckedChanged(object sender, EventArgs e)
        {
            if (selezionaTuttiCB.Checked)
            {
                for(int i =0;i < listBox.Items.Count;i++)
                {
                    listBox.SelectedItems.Add(listBox.Items[i]);
                }
            }
            else
            {
                listBox.SelectedItems.Clear();
            }
        }

        private void compilaBGLbtn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.COMPILER != "\"\"")
            {
                if (Makefire.filePath != "")
                {
                    string message = "";
                    Process compiler = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = Properties.Settings.Default.COMPILER,
                            Arguments = Makefire.filePath,
                            UseShellExecute = false,
                            RedirectStandardOutput = true
                        }
                    };

                    compiler.Start();

                    while (!compiler.StandardOutput.EndOfStream)
                    {
                        message += compiler.StandardOutput.ReadLine();
                    }

                    if (message.Contains("Parse complete"))
                    {
                        MessageBox.Show("File BGL creato correttamente. Si trova nella stessa cartella del file XML.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ops! Qualcosa è andato storto: non non risulta creato o caricato un file XML.\n"
                       +"Se lo avete creato o caricato riportare il bug.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Non è stato ancora impostato il percorso del compilatore BGL.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void impostaCompilatoreBGLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "EXE |bglcomp.exe";

            if(open.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.COMPILER = compilerPathTB.Text = open.FileName;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Viene mantenuto il seguente percorso per il compilatore BGL:\n" + Properties.Settings.Default.COMPILER
                    ,"Attenzione" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuovoToolStripMenuItem_Click(sender, e);
            if(Makefire.filePath != "")
            {
                panelOverIncendio.Visible = false;
                gMC.MapProvider = GMapProviders.GoogleMap;
                areaTB.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            apriToolStripMenuItem_Click(sender, e);
            if (Makefire.filePath != "")
            {
                panelOverIncendio.Visible = false;
                areaTB.Focus();
            }
        }

        private void gMC_OnPositionChanged(PointLatLng point)
        {
            Makefire.InsertPositionInComment(gMC.Position.ToString());
        }

        private void singoloEffettoCB_Format(object sender, ListControlConvertEventArgs e)
        {
            foreach (ComboElement ce in singoloEffettoCB.Items)
            {
                ce.ToString();
            }
        }

        private void aggiungiNuovoEffettoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            foreach(ComboElement cb in singoloEffettoCB.Items)
            {
                a.Add(cb.name);
            }
            foreach(ComboElement cb in lineaEffettoCB.Items)
            {
                b.Add(cb.name);
            }

            AddCustomObcjectForm form = new AddCustomObcjectForm(a,b);
            form.ShowDialog();
            FillComboBoxes();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();

            info.ShowDialog();
        }

        private void LoadPanelSection(string type)
        {
            flightRulesCB.SelectedItem = "V";
            tofCB.SelectedItem = "X";
            typeOfAircraftTB.Text = "CL2T";
            wakeCB.SelectedItem = "L";
            speedCB.SelectedItem = "N";
            speedTB.Text = "170";
            pobTB.Text = "2";

            switch (type)
            {
                case "AIB":
                    break;
            }
        }
    }
}
