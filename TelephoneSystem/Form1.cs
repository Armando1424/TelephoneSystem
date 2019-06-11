using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelephoneSystem.Librerias;

namespace TelephoneSystem
{
    public partial class Form1 : Form
    {
        List<string> listTelefonos = new List<string>();
        List<bool> listTelDispo = new List<bool>();
        Random rnd = new Random();
        ArmandLibrary armand = new ArmandLibrary();
        int CallProcessed,CallBlocked,BusyCall,CallCompleted,IncomingCall,TotalTime;

        public Form1()
        {
            InitializeComponent();
            for (int i = 65; i < 79; i++)
            {
                listTelefonos.Add(""+Convert.ToChar(i));
                listTelDispo.Add(true);
            }            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            dgbMostrar.Rows.Clear();
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            btnContinue.Enabled = false;
            btnStop.Enabled = true;
            for (int i = 0; i < Convert.ToInt32(txtNumEnlace.Text); i++)
            {
                dgbMostrar.Rows.Add(false," "," "," ");                
            }
            initializeVar();
            Proceso.Enabled = true;
            Restar.Enabled = true;
        }        

        private void Proceso_Tick(object sender, EventArgs e)
        {
            int Ori = rnd.Next(0, listTelefonos.Count);
            int Dest = rnd.Next(0, listTelefonos.Count);
            int Dura = rnd.Next(1, 4);
            if (IncomingCall < Convert.ToInt32(txtNumLlama.Text))
            {
                if (Ori != Dest)
                {
                    if (listTelDispo[Ori] && listTelDispo[Dest])
                    {
                        for (int i = 0; i < Convert.ToInt32(txtNumEnlace.Text); i++)
                        {
                            if (!Convert.ToBoolean(dgbMostrar.Rows[i].Cells[0].Value))
                            {
                                listTelDispo[Ori] = false;
                                listTelDispo[Dest] = false;
                                dgbMostrar.Rows[i].Cells[0].Value = true;
                                dgbMostrar.Rows[i].Cells[1].Value = listTelefonos[Ori];
                                dgbMostrar.Rows[i].Cells[2].Value = listTelefonos[Dest];
                                dgbMostrar.Rows[i].Cells[3].Value = "0" + Dura + ":00";
                                CallProcessed++;
                                txtProcessed.Text = "" + CallProcessed;
                                TotalTime += Dura;                                
                                break;
                            }
                            else
                            {
                                if (i == Convert.ToInt32(txtNumEnlace.Text)-1)
                                {
                                    CallBlocked++;
                                    txtBlocked.Text = "" + CallBlocked;
                                }
                            }
                        }
                    }
                    else
                    {
                        BusyCall++;
                        txtBusy.Text = "" + BusyCall;
                    }
                }
                else
                {
                    IncomingCall--;
                }
                IncomingCall++;
            }
            else
            {
                Proceso.Enabled = false;
                txtTotalTime.Text = "" + (TotalTime/Convert.ToInt32(txtNumEnlace.Text));
                txtOtrher.Text = "" + (TotalTime );
            }            
        }

        private void Relog_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }

        private void Restar_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(txtNumEnlace.Text); i++)
            {
                if (Convert.ToBoolean(dgbMostrar.Rows[i].Cells[0].Value))
                {
                    dgbMostrar.Rows[i].Cells[3].Value = armand.RestarTime(dgbMostrar.Rows[i].Cells[3].Value.ToString(), "00:01");
                    if (dgbMostrar.Rows[i].Cells[3].Value.ToString().Equals("00:00"))
                    {
                        for (int j = 0; j < listTelDispo.Count; j++)
                        {
                            if (dgbMostrar.Rows[i].Cells[1].Value.ToString().Equals(listTelefonos[j]) || dgbMostrar.Rows[i].Cells[2].Value.ToString().Equals(listTelefonos[j]))
                            {
                                listTelDispo[j] = true;
                            }
                        }
                        dgbMostrar.Rows[i].Cells[0].Value = false;
                        dgbMostrar.Rows[i].Cells[1].Value = " ";
                        dgbMostrar.Rows[i].Cells[2].Value = " ";
                        dgbMostrar.Rows[i].Cells[3].Value = " ";
                        CallCompleted++;
                        txtCompleted.Text = "" + CallCompleted;
                    }
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
            btnPause.Enabled = false;
            btnContinue.Enabled = true;
            btnStop.Enabled = true;
            Proceso.Enabled = false;
            Restar.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            btnContinue.Enabled = false;
            btnStop.Enabled = true;

            Proceso.Enabled = true;
            Restar.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnPlay.Enabled = true;
            btnPause.Enabled = false;
            btnContinue.Enabled = false;
            btnStop.Enabled = false;
            for (int i = 0; i < listTelDispo.Count; i++)
            {
                listTelDispo[i] = true;
            }
            Proceso.Enabled = false;
            Restar.Enabled = false;
        }

        private void initializeVar()
        {
            CallProcessed = 0;
            CallBlocked = 0;
            CallCompleted = 0;
            BusyCall = 0;
            IncomingCall = 0;
            TotalTime = 0;

            txtProcessed.Text = "" + CallProcessed;
            txtBlocked.Text = "" + CallBlocked;
            txtCompleted.Text = "" + CallCompleted;
            txtBusy.Text = "" + BusyCall;
            txtTotalTime.Text = "" + TotalTime;
            txtOtrher.Text = "" + TotalTime;
        }
    }
}
