using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LajesCA
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
            comboTipoAco.SelectedIndex = 0;
            comboClasseConcreto.SelectedIndex = 0;
            comboCAA.SelectedIndex = 0;
            comboDireita.SelectedIndex = 0;
            comboEsquerda.SelectedIndex = 0;
            comboTopo.SelectedIndex = 0;
            comboFundo.SelectedIndex = 0;
            comboRigidez.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkCobrimento_CheckedChanged(object sender, EventArgs e)
        {
            txtCobrimento.ReadOnly = !chkCobrimento.Checked;
            this.comboCAA_SelectedIndexChanged(sender, e);
        }

        private void comboTopo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AtualizaDesenho();
        }

        private void comboDireita_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AtualizaDesenho();
        }

        private void comboFundo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AtualizaDesenho();
        }

        private void comboEsquerda_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AtualizaDesenho();
        }


        private void AtualizaDesenho()
        {
            int index = comboTopo.SelectedIndex;
            if (index == 0)
            {
                imgTopo.Image = LajesCA.Properties.Resources.Topo_apoio;
                grauEngasteTopo.ReadOnly = true;
                grauEngasteTopo.Enabled = false;
                grauEngasteTopo.Minimum = 0;
                grauEngasteTopo.Value = 0;
            }
            else if (index == 1)
            {
                imgTopo.Image = LajesCA.Properties.Resources.Topo_engaste;
                grauEngasteTopo.ReadOnly = false;
                grauEngasteTopo.Enabled = true;
                grauEngasteTopo.Minimum = 0.70M;
                grauEngasteTopo.Value = 1.50M;
            }
            else
            { 
                imgTopo.Image = LajesCA.Properties.Resources.Topo_bordolivre;
                grauEngasteTopo.ReadOnly = true;
                grauEngasteTopo.Enabled = false;
                grauEngasteTopo.Minimum = 0;
                grauEngasteTopo.Value = 0;
            }


            index = comboDireita.SelectedIndex;
            if (index == 0)
            {
                imgDireita.Image = LajesCA.Properties.Resources.Direita_apoio;
                grauEngasteDireita.ReadOnly = true;
                grauEngasteDireita.Enabled = false;
                grauEngasteDireita.Minimum = 0;
                grauEngasteDireita.Value = 0;
            }
            else if (index == 1)
            {
                imgDireita.Image = LajesCA.Properties.Resources.Direita_engaste;
                grauEngasteDireita.ReadOnly = false;
                grauEngasteDireita.Enabled = true;
                grauEngasteDireita.Minimum = 0.70M;
                grauEngasteDireita.Value = 1.50M;
            }
            else
            {
                imgDireita.Image = LajesCA.Properties.Resources.Direita_bordolivre;
                grauEngasteDireita.ReadOnly = true;
                grauEngasteDireita.Enabled = false;
                grauEngasteDireita.Minimum = 0;
                grauEngasteDireita.Value = 0;
            }
                

            index = comboFundo.SelectedIndex;
            if (index == 0)
            {
                imgFundo.Image = LajesCA.Properties.Resources.Fundo_apoio;
                grauEngasteFundo.ReadOnly = true;
                grauEngasteFundo.Enabled = false;
                grauEngasteFundo.Minimum = 0;
                grauEngasteFundo.Value = 0;
            }
                
            else if (index == 1)
            {
                imgFundo.Image = LajesCA.Properties.Resources.Fundo_engaste;
                grauEngasteFundo.ReadOnly = false;
                grauEngasteFundo.Enabled = true;
                grauEngasteFundo.Minimum = 0.70M;
                grauEngasteFundo.Value = 1.50M;
            }
            else
            {
                imgFundo.Image = LajesCA.Properties.Resources.Fundo_bordolivre;
                grauEngasteFundo.ReadOnly = true;
                grauEngasteFundo.Enabled = false;
                grauEngasteFundo.Minimum = 0;
                grauEngasteFundo.Value = 0;
            }
                


            index = comboEsquerda.SelectedIndex;
            if (index == 0)
            {
                imgEsquerda.Image = LajesCA.Properties.Resources.Esquerda_apoio;
                grauEngasteEsquerda.ReadOnly = true;
                grauEngasteEsquerda.Enabled = false;
                grauEngasteEsquerda.Minimum = 0;
                grauEngasteEsquerda.Value = 0;
            }  
            else if (index == 1)
            {
                imgEsquerda.Image = LajesCA.Properties.Resources.Esquerda_engaste;
                grauEngasteEsquerda.ReadOnly = false;
                grauEngasteEsquerda.Enabled = true;
                grauEngasteEsquerda.Minimum = 0.70M;
                grauEngasteEsquerda.Value = 1.50M;
            }
            else
            {
                imgEsquerda.Image = LajesCA.Properties.Resources.Esquerda_bordolivre;
                grauEngasteEsquerda.ReadOnly = true;
                grauEngasteEsquerda.Enabled = false;
                grauEngasteEsquerda.Minimum = 0;
                grauEngasteEsquerda.Value = 0;
            }
                
        }

        private void comboCAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chkCobrimento.Checked)
            {
                int index = comboCAA.SelectedIndex;
                switch (index)
                {
                    case 0:
                        txtCobrimento.Text = "2.0";
                        break;
                    case 1:
                        txtCobrimento.Text = "2.5";
                        break;
                    case 2:
                        txtCobrimento.Text = "3.5";
                        break;
                    default:
                        txtCobrimento.Text = "4.5";
                        break;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double vaoHorizontal = double.Parse(txtVaoHorizontal.Text);
                double vaoVertical = double.Parse(txtVaoVertical.Text);
                double adicionalG = double.Parse(txtCargaPermanente.Text);
                double adicionalQ = double.Parse(txtCargaVariavel.Text);

                txtBoxResultados.Text =  this.calculaLajes(vaoHorizontal, vaoVertical, adicionalQ, adicionalG);

            }
            catch (Exception)
            {
                MessageBox.Show("Informe corretamente os valores de vãos e cargas! \nSeparador decimal: ponto","ERRO!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
            }
        }
    
        private string calculaLajes(double VaoH, double VaoV, double cargaQ, double cargaG)
        {
            double VaoA, VaoB;
            string maiorVao, textoResultado = "";
            int tipoLaje; // 0 - Isótropa | 1 - Ortótropa | 2 - 1 direção


            if (VaoH > VaoV)
            {
                maiorVao = "H";
                VaoA = VaoV;
                VaoB = VaoH;
            } else if (VaoV > VaoH)
            {
                maiorVao = "V";
                VaoA = VaoH;
                VaoB = VaoV;
            } else
            {
                maiorVao = "=";
                VaoA = VaoV;
                VaoB = VaoH;
            }

            if (VaoA/VaoB >= 0.80)
            {
                tipoLaje = 0;
            } else if (VaoA/VaoB >= 0.50)
            {
                tipoLaje = 1;
            } else
            {
                tipoLaje = 2;
            }

            double fck = this.pegaFck();
            double fcd = fck / 1.4;
            double fctm = Math.Pow((10 * fck), 0.66667)* 0.03;

            double lambda = 0.80;
            double alpha_c = 0.85;
            double eta_c = 1.00;
            
            double Eci = (560 * Math.Sqrt(fck*10));
            double alpha_i = 0.80 + 0.20 * (fck / 8);

            if (alpha_i > 1)
                alpha_i = 1;

            if (fck > 50)
            {
                lambda = 0.8 - (fck - 50) / 400;
                alpha_c = 0.85 * (1.0 - (fck - 50) / 200);
                Eci = 21.5 * 100 * 1.0 * Math.Pow((fck + 1.25), 1 / 3 );
            }

            double fc = fcd * alpha_c * eta_c;

            if (fck > 40)
            {
                eta_c = Math.Pow((40 / fck), 1 / 3);
            }

            double Ecs = Eci * alpha_i;

            bool flagEspessura = true;
            double espessura = double.Parse(txtHInicial.Text);

            switch (tipoLaje)
            {
                case 0: // LAJE ISOTROPA

                    while (flagEspessura)
                    {
                        textoResultado = "Laje Armada em duas direções - Isótropa:\n";
                        double qperm = (25 * (espessura / 100) + (cargaG)) / 100 / 100;
                        double qac = (cargaQ / 100 / 100);
                        double psi2 = double.Parse(txtPsi2.Text);
                        double cqperm = qperm + psi2 * qac;
                        double cqELU = 1.4 * (qperm + qac);

                        double engaste1P, engaste2P, engaste1S, engaste2S;

                        if (maiorVao == "H")
                        {
                            engaste1P = (double) grauEngasteFundo.Value;
                            engaste2P = (double) grauEngasteTopo.Value;
                            engaste1S = (double) grauEngasteEsquerda.Value;
                            engaste2S = (double) grauEngasteDireita.Value;
                        } else
                        {
                            engaste1S = (double)grauEngasteFundo.Value;
                            engaste2S = (double)grauEngasteTopo.Value;
                            engaste1P = (double)grauEngasteEsquerda.Value;
                            engaste2P = (double)grauEngasteDireita.Value;
                        }

                        double ar = (2 * VaoA) / (Math.Sqrt(1 + engaste1P) + Math.Sqrt(1 + engaste2P));
                        double br = (2 * VaoB) / (Math.Sqrt(1 + engaste1S) + Math.Sqrt(1 + engaste2S));
                        textoResultado += $"Vaos efetivos: {ar:F0} x {br:F0} cm\n";

                        double mELSVao = 0;
                        double mELUVao = cqELU * ar * br / 8 / (1 + ar/br + br/ar);

                        double mELUApoio1P = mELUVao * engaste1P;
                        double mELUApoio2P = mELUVao * engaste2P;
                        double mELUApoio1S = mELUVao * engaste1S;
                        double mELUApoio2S = mELUVao * engaste2S;

                        double relab = VaoA / VaoB;
                        double relab_inf = 1.0, relab_sup = 1.0;
                        double[] kInf = new double[9];
                        double[] kSup = new double[9];
                        double[] mELSInf = new double[9];
                        double[] mELSSup = new double[9];

                        // ELS:
                        if (relab < 0.55)
                        {
                            kInf = new double[] { 0.99, 0.25, 0.46, 0.83, 0.25, 0.91, 0.48, 0.24, 0.44 };
                            kSup = new double[] { 0.85, 0.23, 0.41, 0.63, 0.25, 0.73, 0.44, 0.24, 0.38 };
                            mELSInf = new double[] { 0.099, 0.041, 0.057, 0.084, 0.042, 0.091, 0.060, 0.042, 0.055 };
                            mELSSup = new double[] { 0.086, 0.038, 0.052, 0.065, 0.041, 0.075, 0.051, 0.037, 0.058 };
                            relab_inf = 0.50;
                            relab_sup = 0.60;
                        } else if ( relab < 0.65) 
                        {
                            mELSInf = new double[] { 0.086, 0.038, 0.052, 0.065, 0.041, 0.075, 0.051, 0.037, 0.058 };
                            mELSSup = new double[] { 0.073, 0.034, 0.045, 0.049, 0.039, 0.060, 0.051, 0.037, 0.040 };
                            kInf = new double[] { 0.85, 0.23, 0.41, 0.63, 0.25, 0.73, 0.44, 0.24, 0.38 };
                            kSup = new double[] { 0.71, 0.21, 0.36, 0.48, 0.24, 0.58, 0.41, 0.23, 0.32 };
                            relab_inf = 0.60;
                            relab_sup = 0.70;
                        } else if (relab < 0.75)
                        {
                            mELSInf = new double[] { 0.073, 0.034, 0.045, 0.049, 0.039, 0.060, 0.051, 0.037, 0.040 };
                            mELSSup = new double[] { 0.061, 0.029, 0.039, 0.037, 0.037, 0.048, 0.046, 0.033, 0.033 };
                            kInf = new double[] { 0.71, 0.21, 0.36, 0.48, 0.24, 0.58, 0.41, 0.23, 0.32 };
                            kSup = new double[] { 0.59, 0.18, 0.30, 0.35, 0.23, 0.46, 0.36, 0.20, 0.25 };
                            relab_inf = 0.70;
                            relab_sup = 0.80;
                        } else if (relab < 0.85)
                        {
                            mELSInf = new double[] { 0.061, 0.029, 0.039, 0.037, 0.037, 0.048, 0.046, 0.033, 0.033 };
                            mELSSup = new double[] { 0.051, 0.025, 0.033, 0.027, 0.034, 0.037, 0.040, 0.029, 0.026 };
                            kInf = new double[] { 0.59, 0.18, 0.30, 0.35, 0.23, 0.46, 0.36, 0.20, 0.25 };
                            kSup = new double[] { 0.48, 0.15, 0.25, 0.26, 0.21, 0.35, 0.31, 0.18, 0.20 };
                            relab_inf = 0.80;
                            relab_sup = 0.90;
                        } else if (relab < 0.95)
                        {
                            mELSInf = new double[] { 0.051, 0.025, 0.033, 0.027, 0.034, 0.037, 0.040, 0.029, 0.026 };
                            mELSSup = new double[] { 0.042, 0.021, 0.027, 0.020, 0.031, 0.030, 0.036, 0.026, 0.021 };
                            kInf = new double[] { 0.48, 0.15, 0.25, 0.26, 0.21, 0.35, 0.31, 0.18, 0.20 };
                            kSup = new double[] { 0.40, 0.13, 0.21, 0.19, 0.19, 0.28, 0.28, 0.16, 0.16 };
                            relab_inf = 0.90;
                            relab_sup = 1.00;
                        } else
                        {
                            mELSInf = new double[] { 0.042, 0.021, 0.027, 0.020, 0.031, 0.030, 0.036, 0.026, 0.021 };
                            mELSSup = new double[] { 0.042, 0.021, 0.027, 0.020, 0.031, 0.030, 0.036, 0.026, 0.021 };
                            kInf = new double[] { 0.40, 0.13, 0.21, 0.19, 0.19, 0.28, 0.28, 0.16, 0.16 };
                            kSup = new double[] { 0.40, 0.13, 0.21, 0.19, 0.19, 0.28, 0.28, 0.16, 0.16 };
                            relab_inf = 1.00;
                            relab_sup = 1.10;
                        }

                        int index = 0;
                        if (engaste1P != 0 && engaste2P != 0) // VAO PRINCIPAL DUPLAMENTE ENGASTADO
                        {
                            if (engaste1S != 0 && engaste2S != 0) { index = 1; } // VAO SECUNDARIO DUPLAMENTE ENGASTADO
                            else if (engaste1S == 0 && engaste2S == 0) { index = 4; } // VAO SECUNDARIO DUPLAMENTE APOIADO
                            else { index = 7; }  // VAO SECUNDARIO ENGASTADO-APOIADO

                        } 
                        else if (engaste1P == 0 && engaste2P == 0) // VAO PRINCIPAL DUPLAMENTE APOIADO
                        {
                            if (engaste1S != 0 && engaste2S != 0) { index = 3; } // VAO SECUNDARIO DUPLAMENTE ENGASTADO
                            else if (engaste1S == 0 && engaste2S == 0) { index = 0; } // VAO SECUNDARIO DUPLAMENTE APOIADO
                            else { index = 5; }  // VAO SECUNDARIO ENGASTADO-APOIADO
                        }
                        else // VAO PRINCIPAL ENGASTADO-APOIADO
                        {
                            if (engaste1S != 0 && engaste2S != 0) { index = 8; } // VAO SECUNDARIO DUPLAMENTE ENGASTADO
                            else if (engaste1S == 0 && engaste2S == 0) { index = 6; } // VAO SECUNDARIO DUPLAMENTE APOIADO
                            else { index = 2; }  // VAO SECUNDARIO ENGASTADO-APOIADO
                        }

                        double coefFlecha = kInf[index]; //(relab - relab_inf) * (kSup[index] - kInf[index]) /(relab_sup - relab_inf) + kInf[index];
                        double coefMELS = mELSInf[index]; //(relab - relab_inf) * (mELSSup[index] - mELSInf[index]) / (relab_sup - relab_inf) + mELSInf[index];

                        mELSVao = coefMELS * cqperm * VaoA * VaoA;

                        double mFissuracao = 0.25 * fctm * espessura * espessura;
                        double Ieq;

                        if (mELSVao > mFissuracao)
                            Ieq = 0.30 * 100 * Math.Pow(espessura, 3) / 12;
                        else
                            Ieq = 1.00 * 100 * Math.Pow(espessura, 3) / 12;

                        double flecha0 = (cqperm * Math.Pow(VaoA, 4) * coefFlecha / (Ecs * Ieq));
                        double flechainf = flecha0 * (1 + 1.32);
                        double flechaAdm = (VaoA / 250);

                        if (flechaAdm > flechainf)
                        {
                            //flagEspessura = false;
                            textoResultado += $"\nCarga de serviço: {cqperm * 100 * 100:F2} kN/m²\n";
                            textoResultado += $"Momento em serviço: {mELSVao:F2} kN.m/m\n";
                            textoResultado += $"Momento de fissuração: {mFissuracao:F2} kN.m/m\n";
                            textoResultado += "Espessura calculada: " + espessura + "cm.\n";
                            textoResultado += $"Flecha estimada: {flechainf:F2} cm - Flecha Admissível: {flechaAdm:F2} cm\n";
                        }
                        else
                        {
                            espessura++;
                            continue;
                        }

                        string vaoPrincipal, vaoSecundario;

                        textoResultado += "\nResultado das Armaduras - ELU:\n";

                        if (maiorVao == "H")
                        {
                            vaoPrincipal = "Vertical";
                            vaoSecundario = "Horizontal";
                        }
                        else
                        {
                            vaoPrincipal = "Horizontal";
                            vaoSecundario = "Vertical";
                        }

                        // Armadura do vão:
                        double cobrimento = double.Parse(txtCobrimento.Text);

                        textoResultado += $"\nArmadura do vão: \n";
                        textoResultado += $"Momento de cálculo: {mELUVao:F2} kN.m/m\n";

                        double d_vao = espessura - cobrimento - 0.5;
                        double x_vao = (d_vao / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUVao / (fc * d_vao * d_vao)));
                        double xd_vao = (x_vao / d_vao);

                        if (fck > 5.0)
                        {
                            if (xd_vao > 0.15)
                            {
                                espessura++;
                                continue;
                            }
                        }
                        else
                        {
                            if (xd_vao > 0.25)
                            {
                                espessura++;
                                continue;
                            }
                        }

                        double fyd = (this.pegaFyk() / 1.15);

                        double as_vao = lambda * fc * 100 * x_vao / fyd;

                        textoResultado += $"Altura efetiva: {d_vao:F2}cm\n";
                        textoResultado += $"X: {x_vao:F2}cm | x/d: {xd_vao:F2}\n";
                        textoResultado += $"As,vao calculada: {as_vao:F2} cm²/m\n";


                        if (engaste1P != 0)
                        {
                            double d_1P = espessura - cobrimento;
                            double x_1P = (d_1P / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUApoio1P / (fc * d_1P * d_1P)));
                            double xd_1P = (x_1P / d_1P);
                            if (fck > 5.0)
                            {
                                if (xd_1P > 0.15)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            else
                            {
                                if (xd_1P > 0.25)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            double as_1P = lambda * fc * 100 * x_1P / fyd;

                            if (maiorVao == "H") textoResultado += "\nArmadura do Engaste Inferior:\n";
                            else textoResultado += "\n\nArmadura do Engaste Esquerdo:\n";
                            textoResultado += $"Momento de cálculo: {mELUApoio1P:F2} kN.m/m\n";
                            textoResultado += $"Altura efetiva: {d_1P:F2}cm\n";
                            textoResultado += $"X: {x_1P:F2}cm | x/d: {xd_1P:F2}\n";
                            textoResultado += $"As,calculada: {as_1P:F2} cm²/m\n";

                        }

                        if (engaste2P != 0)
                        {
                            double d_2P = espessura - cobrimento;
                            double x_2P = (d_2P / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUApoio2P / (fc * d_2P * d_2P)));
                            double xd_2P = (x_2P / d_2P);
                            if (fck > 5.0)
                            {
                                if (xd_2P > 0.15)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            else
                            {
                                if (xd_2P > 0.25)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            double as_2P = lambda * fc * 100 * x_2P / fyd;

                            if (maiorVao == "H") textoResultado += "\nArmadura do Engaste Superior:\n";
                            else textoResultado += "\n\nArmadura do Engaste Direito:\n";
                            textoResultado += $"Momento de cálculo: {mELUApoio2P:F2} kN.m/m\n";
                            textoResultado += $"Altura efetiva: {d_2P:F2}cm\n";
                            textoResultado += $"X: {x_2P:F2}cm | x/d: {xd_2P:F2}\n";
                            textoResultado += $"As,calculada: {as_2P:F2} cm²/m\n";

                        }

                        if (engaste1S != 0)
                        {
                            double d_1S = espessura - cobrimento;
                            double x_1S = (d_1S / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUApoio1S / (fc * d_1S * d_1S)));
                            double xd_1S = (x_1S / d_1S);
                            if (fck > 5.0)
                            {
                                if (xd_1S > 0.15)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            else
                            {
                                if (xd_1S > 0.25)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            double as_1S = lambda * fc * 100 * x_1S / fyd;

                            if (maiorVao == "H") textoResultado += "\nArmadura do Engaste Esquerdo:\n";
                            else textoResultado += "\n\nArmadura do Engaste Inferior:\n";
                            textoResultado += $"Momento de cálculo: {mELUApoio1S:F2} kN.m/m\n";
                            textoResultado += $"Altura efetiva: {d_1S:F2}cm\n";
                            textoResultado += $"X: {x_1S:F2}cm | x/d: {xd_1S:F2}\n";
                            textoResultado += $"As,calculada: {as_1S:F2} cm²/m\n";

                        }

                        if (engaste2S != 0)
                        {
                            double d_2S = espessura - cobrimento;
                            double x_2S = (d_2S / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUApoio2S / (fc * d_2S * d_2S)));
                            double xd_2S = (x_2S / d_2S);
                            if (fck > 5.0)
                            {
                                if (xd_2S > 0.15)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            else
                            {
                                if (xd_2S > 0.25)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            double as_2S = lambda * fc * 100 * x_2S / fyd;

                            if (maiorVao == "H") textoResultado += "\nArmadura do Engaste Direito:\n";
                            else textoResultado += "\n\nArmadura do Engaste Superior:\n";
                            textoResultado += $"Momento de cálculo: {mELUApoio2S:F2} kN.m/m\n";
                            textoResultado += $"Altura efetiva: {d_2S:F2}cm\n";
                            textoResultado += $"X: {x_2S:F2}cm | x/d: {xd_2S:F2}\n";
                            textoResultado += $"As,calculada: {as_2S:F2} cm²/m\n";

                        }


                        flagEspessura = false;
                    }

                    break;
                case 1: // LAJE ORTOTROPA
                    while (flagEspessura)
                    {
                        textoResultado = "Laje Armada em duas direções - Ortótropa:\n";
                        if (maiorVao == "H") textoResultado += "Vão Principal: Vertical\n";
                        else textoResultado += "Vão Principal: Horizontal\n";

                        double qperm = (25 * (espessura / 100) + (cargaG)) / 100 / 100;
                        double qac = (cargaQ / 100 / 100);
                        double psi2 = double.Parse(txtPsi2.Text);
                        double cqperm = qperm + psi2 * qac;
                        double cqELU = 1.4 * (qperm + qac);

                        double engaste1P, engaste2P, engaste1S, engaste2S;

                        if (maiorVao == "H")
                        {
                            engaste1P = (double)grauEngasteFundo.Value;
                            engaste2P = (double)grauEngasteTopo.Value;
                            engaste1S = (double)grauEngasteEsquerda.Value;
                            engaste2S = (double)grauEngasteDireita.Value;
                        }
                        else
                        {
                            engaste1S = (double)grauEngasteFundo.Value;
                            engaste2S = (double)grauEngasteTopo.Value;
                            engaste1P = (double)grauEngasteEsquerda.Value;
                            engaste2P = (double)grauEngasteDireita.Value;
                        }

                        double ar = (2 * VaoA) / (Math.Sqrt(1 + engaste1P) + Math.Sqrt(1 + engaste2P));
                        double br = (2 * VaoB) / (Math.Sqrt(1 + engaste1S) + Math.Sqrt(1 + engaste2S));
                        double phi = (12 - engaste1P - engaste2P) / (12 - engaste1S - engaste2S) * Math.Pow(VaoA / VaoB, 1.70);
                        textoResultado += $"Coeficiente de Ortotropia: {phi:F3}\n";

                        double bra = br / Math.Sqrt(phi);
                        textoResultado += $"Vaos efetivos: {ar:F0} x {br:F0} cm\n";

                        double mELSVao = 0;
                        double mELUVaoA = cqELU * ar * bra / 8 / (1 + ar / bra + bra / ar);
                        double mELUVaoB = phi * mELUVaoA;

                        double mELUApoio1P = mELUVaoA * engaste1P;
                        double mELUApoio2P = mELUVaoA * engaste2P;
                        double mELUApoio1S = mELUVaoB * engaste1S;
                        double mELUApoio2S = mELUVaoB * engaste2S;

                        double relab = VaoA / VaoB;
                        double relab_inf = 1.0, relab_sup = 1.0;
                        double[] kInf = new double[9];
                        double[] kSup = new double[9];
                        double[] mELSInf = new double[9];
                        double[] mELSSup = new double[9];

                        // ELS:
                        if (relab < 0.55)
                        {
                            kInf = new double[] { 0.99, 0.25, 0.46, 0.83, 0.25, 0.91, 0.48, 0.24, 0.44 };
                            kSup = new double[] { 0.85, 0.23, 0.41, 0.63, 0.25, 0.73, 0.44, 0.24, 0.38 };
                            mELSInf = new double[] { 0.099, 0.041, 0.057, 0.084, 0.042, 0.091, 0.060, 0.042, 0.055 };
                            mELSSup = new double[] { 0.086, 0.038, 0.052, 0.065, 0.041, 0.075, 0.051, 0.037, 0.058 };
                            relab_inf = 0.50;
                            relab_sup = 0.60;
                        }
                        else if (relab < 0.65)
                        {
                            mELSInf = new double[] { 0.086, 0.038, 0.052, 0.065, 0.041, 0.075, 0.051, 0.037, 0.058 };
                            mELSSup = new double[] { 0.073, 0.034, 0.045, 0.049, 0.039, 0.060, 0.051, 0.037, 0.040 };
                            kInf = new double[] { 0.85, 0.23, 0.41, 0.63, 0.25, 0.73, 0.44, 0.24, 0.38 };
                            kSup = new double[] { 0.71, 0.21, 0.36, 0.48, 0.24, 0.58, 0.41, 0.23, 0.32 };
                            relab_inf = 0.60;
                            relab_sup = 0.70;
                        }
                        else if (relab < 0.75)
                        {
                            mELSInf = new double[] { 0.073, 0.034, 0.045, 0.049, 0.039, 0.060, 0.051, 0.037, 0.040 };
                            mELSSup = new double[] { 0.061, 0.029, 0.039, 0.037, 0.037, 0.048, 0.046, 0.033, 0.033 };
                            kInf = new double[] { 0.71, 0.21, 0.36, 0.48, 0.24, 0.58, 0.41, 0.23, 0.32 };
                            kSup = new double[] { 0.59, 0.18, 0.30, 0.35, 0.23, 0.46, 0.36, 0.20, 0.25 };
                            relab_inf = 0.70;
                            relab_sup = 0.80;
                        }
                        else if (relab < 0.85)
                        {
                            mELSInf = new double[] { 0.061, 0.029, 0.039, 0.037, 0.037, 0.048, 0.046, 0.033, 0.033 };
                            mELSSup = new double[] { 0.051, 0.025, 0.033, 0.027, 0.034, 0.037, 0.040, 0.029, 0.026 };
                            kInf = new double[] { 0.59, 0.18, 0.30, 0.35, 0.23, 0.46, 0.36, 0.20, 0.25 };
                            kSup = new double[] { 0.48, 0.15, 0.25, 0.26, 0.21, 0.35, 0.31, 0.18, 0.20 };
                            relab_inf = 0.80;
                            relab_sup = 0.90;
                        }
                        else if (relab < 0.95)
                        {
                            mELSInf = new double[] { 0.051, 0.025, 0.033, 0.027, 0.034, 0.037, 0.040, 0.029, 0.026 };
                            mELSSup = new double[] { 0.042, 0.021, 0.027, 0.020, 0.031, 0.030, 0.036, 0.026, 0.021 };
                            kInf = new double[] { 0.48, 0.15, 0.25, 0.26, 0.21, 0.35, 0.31, 0.18, 0.20 };
                            kSup = new double[] { 0.40, 0.13, 0.21, 0.19, 0.19, 0.28, 0.28, 0.16, 0.16 };
                            relab_inf = 0.90;
                            relab_sup = 1.00;
                        } else
                        {
                            mELSInf = new double[] { 0.042, 0.021, 0.027, 0.020, 0.031, 0.030, 0.036, 0.026, 0.021 };
                            mELSSup = new double[] { 0.042, 0.021, 0.027, 0.020, 0.031, 0.030, 0.036, 0.026, 0.021 };
                            kInf = new double[] { 0.40, 0.13, 0.21, 0.19, 0.19, 0.28, 0.28, 0.16, 0.16 };
                            kSup = new double[] { 0.40, 0.13, 0.21, 0.19, 0.19, 0.28, 0.28, 0.16, 0.16 };
                            relab_inf = 1.00;
                            relab_sup = 1.10;
                        }

                        int index = 0;
                        if (engaste1P != 0 && engaste2P != 0) // VAO PRINCIPAL DUPLAMENTE ENGASTADO
                        {
                            if (engaste1S != 0 && engaste2S != 0) { index = 1; } // VAO SECUNDARIO DUPLAMENTE ENGASTADO
                            else if (engaste1S == 0 && engaste2S == 0) { index = 4; } // VAO SECUNDARIO DUPLAMENTE APOIADO
                            else { index = 7; }  // VAO SECUNDARIO ENGASTADO-APOIADO

                        }
                        else if (engaste1P == 0 && engaste2P == 0) // VAO PRINCIPAL DUPLAMENTE APOIADO
                        {
                            if (engaste1S != 0 && engaste2S != 0) { index = 3; } // VAO SECUNDARIO DUPLAMENTE ENGASTADO
                            else if (engaste1S == 0 && engaste2S == 0) { index = 0; } // VAO SECUNDARIO DUPLAMENTE APOIADO
                            else { index = 5; }  // VAO SECUNDARIO ENGASTADO-APOIADO
                        }
                        else // VAO PRINCIPAL ENGASTADO-APOIADO
                        {
                            if (engaste1S != 0 && engaste2S != 0) { index = 8; } // VAO SECUNDARIO DUPLAMENTE ENGASTADO
                            else if (engaste1S == 0 && engaste2S == 0) { index = 6; } // VAO SECUNDARIO DUPLAMENTE APOIADO
                            else { index = 2; }  // VAO SECUNDARIO ENGASTADO-APOIADO
                        }

                        double coefFlecha = kInf[index];  // (relab - relab_inf) * (kSup[index] - kInf[index]) / (relab_sup - relab_inf) + kInf[index];
                        double coefMELS = mELSInf[index]; // (relab - relab_inf) * (mELSSup[index] - mELSInf[index]) / (relab_sup - relab_inf) + mELSInf[index];

                        mELSVao = coefMELS * cqperm * VaoA * VaoA;

                        double mFissuracao = 0.25 * fctm * espessura * espessura;
                        double Ieq;

                        if (mELSVao > mFissuracao)
                            Ieq = 0.30 * 100 * Math.Pow(espessura, 3) / 12;
                        else
                            Ieq = 1.00 * 100 * Math.Pow(espessura, 3) / 12;

                        double flecha0 = (cqperm * Math.Pow(VaoA, 4) * coefFlecha / (Ecs * Ieq));
                        double flechainf = flecha0 * (1 + 1.32);
                        double flechaAdm = (VaoA / 250);

                        if (flechaAdm > flechainf)
                        {
                            //flagEspessura = false;
                            textoResultado += $"\nCarga de serviço: {cqperm*100*100:F2} kN/m²\n";
                            textoResultado += $"Momento em serviço: {mELSVao:F2} kN.m/m\n";
                            textoResultado += $"Momento de fissuração: {mFissuracao:F2} kN.m/m\n";
                            textoResultado += "Espessura calculada: " + espessura + "cm.\n";
                            textoResultado += $"Flecha estimada: {flechainf:F2} cm - Flecha Admissível: {flechaAdm:F2} cm\n";
                        }
                        else
                        {
                            espessura++;
                            continue;
                        }

                        string vaoPrincipal, vaoSecundario;

                        textoResultado += "\nResultado das Armaduras - ELU:\n";

                        if (maiorVao == "H")
                        {
                            vaoPrincipal = "Vertical";
                            vaoSecundario = "Horizontal";
                        }
                        else
                        {
                            vaoPrincipal = "Horizontal";
                            vaoSecundario = "Vertical";
                        }

                        // Armadura do vão principal:
                        double cobrimento = double.Parse(txtCobrimento.Text);

                        textoResultado += $"\nArmadura do vão " + vaoPrincipal + ": \n";
                        textoResultado += $"Momento de cálculo: {mELUVaoA:F2} kN.m/m\n";

                        double d_vao = espessura - cobrimento - 0.5;
                        double x_vao = (d_vao / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUVaoA / (fc * d_vao * d_vao)));
                        double xd_vao = (x_vao / d_vao);

                        if (fck > 5.0)
                        {
                            if (xd_vao > 0.15)
                            {
                                espessura++;
                                continue;
                            }
                        }
                        else
                        {
                            if (xd_vao > 0.25)
                            {
                                espessura++;
                                continue;
                            }
                        }

                        double fyd = (this.pegaFyk() / 1.15);

                        double as_vao = lambda * fc * 100 * x_vao / fyd;

                        textoResultado += $"Altura efetiva: {d_vao:F2}cm\n";
                        textoResultado += $"X: {x_vao:F2}cm | x/d: {xd_vao:F2}\n";
                        textoResultado += $"As,vao calculada: {as_vao:F2} cm²/m\n";


                        // Armadura do vão secundario:

                        textoResultado += $"\nArmadura do vão " + vaoSecundario + ": \n";
                        textoResultado += $"Momento de cálculo: {mELUVaoB:F2} kN.m/m\n";

                        double d_vaoS = espessura - cobrimento - 0.5 - 1.0;
                        double x_vaoS = (d_vaoS / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUVaoB / (fc * d_vaoS * d_vaoS)));
                        double xd_vaoS = (x_vaoS / d_vaoS);

                        if (fck > 5.0)
                        {
                            if (xd_vaoS > 0.15)
                            {
                                espessura++;
                                continue;
                            }
                        }
                        else
                        {
                            if (xd_vaoS > 0.25)
                            {
                                espessura++;
                                continue;
                            }
                        }

                        double as_vaoS = lambda * fc * 100 * x_vaoS / fyd;

                        textoResultado += $"Altura efetiva: {d_vaoS:F2}cm\n";
                        textoResultado += $"X: {x_vaoS:F2}cm | x/d: {xd_vaoS:F2}\n";
                        textoResultado += $"As,vao calculada: {as_vaoS:F2} cm²/m\n";


                        if (engaste1P != 0)
                        {
                            double d_1P = espessura - cobrimento;
                            double x_1P = (d_1P / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUApoio1P / (fc * d_1P * d_1P)));
                            double xd_1P = (x_1P / d_1P);
                            if (fck > 5.0)
                            {
                                if (xd_1P > 0.15)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            else
                            {
                                if (xd_1P > 0.25)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            double as_1P = lambda * fc * 100 * x_1P / fyd;

                            if (maiorVao == "H") textoResultado += "\nArmadura do Engaste Inferior:\n";
                            else textoResultado += "\n\nArmadura do Engaste Esquerdo:\n";
                            textoResultado += $"Momento de cálculo: {mELUApoio1P:F2} kN.m/m\n";
                            textoResultado += $"Altura efetiva: {d_1P:F2}cm\n";
                            textoResultado += $"X: {x_1P:F2}cm | x/d: {xd_1P:F2}\n";
                            textoResultado += $"As,calculada: {as_1P:F2} cm²/m\n";

                        }

                        if (engaste2P != 0)
                        {
                            double d_2P = espessura - cobrimento;
                            double x_2P = (d_2P / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUApoio2P / (fc * d_2P * d_2P)));
                            double xd_2P = (x_2P / d_2P);
                            if (fck > 5.0)
                            {
                                if (xd_2P > 0.15)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            else
                            {
                                if (xd_2P > 0.25)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            double as_2P = lambda * fc * 100 * x_2P / fyd;

                            if (maiorVao == "H") textoResultado += "\nArmadura do Engaste Superior:\n";
                            else textoResultado += "\n\nArmadura do Engaste Direito:\n";
                            textoResultado += $"Momento de cálculo: {mELUApoio2P:F2} kN.m/m\n";
                            textoResultado += $"Altura efetiva: {d_2P:F2}cm\n";
                            textoResultado += $"X: {x_2P:F2}cm | x/d: {xd_2P:F2}\n";
                            textoResultado += $"As,calculada: {as_2P:F2} cm²/m\n";

                        }

                        if (engaste1S != 0)
                        {
                            double d_1S = espessura - cobrimento;
                            double x_1S = (d_1S / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUApoio1S / (fc * d_1S * d_1S)));
                            double xd_1S = (x_1S / d_1S);
                            if (fck > 5.0)
                            {
                                if (xd_1S > 0.15)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            else
                            {
                                if (xd_1S > 0.25)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            double as_1S = lambda * fc * 100 * x_1S / fyd;

                            if (maiorVao == "H") textoResultado += "\nArmadura do Engaste Esquerdo:\n";
                            else textoResultado += "\n\nArmadura do Engaste Inferior:\n";
                            textoResultado += $"Momento de cálculo: {mELUApoio1S:F2} kN.m/m\n";
                            textoResultado += $"Altura efetiva: {d_1S:F2}cm\n";
                            textoResultado += $"X: {x_1S:F2}cm | x/d: {xd_1S:F2}\n";
                            textoResultado += $"As,calculada: {as_1S:F2} cm²/m\n";

                        }

                        if (engaste2S != 0)
                        {
                            double d_2S = espessura - cobrimento;
                            double x_2S = (d_2S / lambda) * (1 - Math.Sqrt(1 - 2.0 * mELUApoio2S / (fc * d_2S * d_2S)));
                            double xd_2S = (x_2S / d_2S);
                            if (fck > 5.0)
                            {
                                if (xd_2S > 0.15)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            else
                            {
                                if (xd_2S > 0.25)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            double as_2S = lambda * fc * 100 * x_2S / fyd;

                            if (maiorVao == "H") textoResultado += "\nArmadura do Engaste Direito:\n";
                            else textoResultado += "\n\nArmadura do Engaste Superior:\n";
                            textoResultado += $"Momento de cálculo: {mELUApoio2S:F2} kN.m/m\n";
                            textoResultado += $"Altura efetiva: {d_2S:F2}cm\n";
                            textoResultado += $"X: {x_2S:F2}cm | x/d: {xd_2S:F2}\n";
                            textoResultado += $"As,calculada: {as_2S:F2} cm²/m\n";

                        }


                        flagEspessura = false;
                    }
                    break;
                case 2: // LAJE EM UMA DIRECAO
                    while (flagEspessura)
                    {
                        textoResultado = "Laje Armada em uma direção:\n";
                        double qperm = (25 * (espessura / 100) + (cargaG))/100;
                        double qac = (cargaQ/100);
                        double psi2 = double.Parse(txtPsi2.Text);
                        double cqperm = qperm + psi2 * qac;
                        double cqELU = 1.4 * (qperm + qac);

                        double engaste1, engaste2;
                        if (maiorVao == "H")
                        {
                            engaste1 = (double) grauEngasteFundo.Value;
                            engaste2 = (double) grauEngasteTopo.Value;
                        } else
                        {
                            engaste1 = (double) grauEngasteEsquerda.Value;
                            engaste2 = (double) grauEngasteDireita.Value;
                        }

                        double mELSVao = 0;
                        double coefFlecha = 0;
                        double mELUVao = 0;
                        double mELUApoio = 0;

                        if (engaste1 == 0 && engaste2 == 0)
                        {
                            mELSVao = (cqperm * VaoA * VaoA / 8)/100;
                            coefFlecha = (5.0 / 384.0);
                            mELUVao = (cqELU*VaoA * VaoA / 8) / 100;
                        } 
                        else if ((engaste1 == 0 && engaste2 != 0) | (engaste1 != 0 && engaste2 == 0))
                        {
                            mELSVao = ((9 / 128) * cqperm * VaoA * VaoA)/100;
                            coefFlecha = (1.0 / 185.0);
                            mELUVao = ((1 / 13.32) * cqELU * VaoA * VaoA)/ 100;
                            mELUApoio = ((1 / 8.88) * cqELU * VaoA * VaoA) / 100;
                        } 
                        else if (engaste1 != 0 && engaste2 != 0)
                        {
                            mELSVao = (cqperm * VaoA * VaoA / 24) / 100;
                            coefFlecha = (1.0 / 384.0);
                            mELUVao = ((1 / 20.00) * cqELU * VaoA * VaoA) / 100;
                            mELUApoio = ((3 / 40.00) * cqELU * VaoA * VaoA) / 100;
                        }


                        double mFissuracao = 0.25 * fctm  * espessura * espessura;
                        double Ieq;

                        if (mELSVao > mFissuracao)
                            Ieq = 0.30 * 100 * Math.Pow(espessura, 3) / 12;
                        else
                            Ieq = 1.00 * 100 * Math.Pow(espessura, 3) / 12;

                        double flecha0 = (cqperm * Math.Pow(VaoA, 4) * coefFlecha / (Ecs * Ieq));
                        double flechainf = flecha0 * (1 + 1.32);
                        double flechaAdm = (VaoA / 250);
                        
                        if (flechaAdm > flechainf)
                        {
                            //flagEspessura = false;
                            textoResultado += $"\nCarga de serviço: {cqperm*100:F2} kN/m²\n";
                            textoResultado += $"Momento em serviço: {mELSVao:F2} kN.m/m\n";
                            textoResultado += $"Momento de fissuração: {mFissuracao:F2} kN.m/m\n";
                            textoResultado += "Espessura calculada: " + espessura + "cm.\n";
                            textoResultado += $"Flecha estimada: {flechainf:F2} cm - Flecha Admissível: {flechaAdm:F2} cm\n";
                        } else
                        {
                            espessura++;
                            continue;
                        }

                        string vaoPrincipal, vaoSecundario;

                        textoResultado += "\nResultado das Armaduras - ELU:\n";

                        if (maiorVao == "H"){
                            textoResultado += "Vão Principal: Vertical\n";
                            vaoPrincipal = "Vertical";
                            vaoSecundario = "Horizontal";
                        } else
                        {
                            textoResultado += "Vão Principal: Horizontal\n";
                            vaoPrincipal = "Horizontal";
                            vaoSecundario = "Vertical";
                        }

                        // Armadura do vão:
                        double cobrimento = double.Parse(txtCobrimento.Text);

                        textoResultado += $"\nArmadura do vão {vaoPrincipal}:\n";
                        textoResultado += $"Momento de cálculo: {mELUVao:F2} kN.m/m\n";

                        double d_vao = espessura - cobrimento - 0.5;
                        double x_vao = (d_vao / lambda) * (1 - Math.Sqrt(1 - (2 * mELUVao) / (fc * d_vao * d_vao)));
                        double xd_vao = (x_vao / d_vao);

                        if (fck > 5.0)
                        {
                            if (xd_vao > 0.15)
                            {
                                espessura++;
                                continue;
                            }
                        } 
                        else
                        {
                            if (xd_vao > 0.25)
                            {
                                espessura++;
                                continue;
                            }
                        }

                        double fyd = (this.pegaFyk() / 1.15);

                        double as_vao = lambda * fc * 100 * x_vao / fyd;

                        textoResultado += $"Altura útil: {d_vao:F2} cm\n";
                        textoResultado += $"X: {x_vao:F2}cm | x/d: {xd_vao:F2}\n";
                        textoResultado += $"As,vao calculada: {as_vao:F2} cm²/m\n";

                        if ((engaste1 != 0) | (engaste2 != 0))
                        {
                            textoResultado += $"\nArmadura do engaste {vaoPrincipal}:\n";
                            textoResultado += $"Momento de cálculo: {mELUApoio:F2} kN.m/m\n";

                            double d_apoio = espessura - (cobrimento - 0.5) - 0.5;
                            double x_apoio = (d_apoio / lambda) * (1 - Math.Sqrt(1 - (2 * mELUApoio) / (fc * d_apoio * d_apoio)));
                            double xd_apoio = (x_apoio / d_apoio);

                            if (fck > 5.0)
                            {
                                if (xd_apoio > 0.15)
                                {
                                    espessura++;
                                    continue;
                                }
                            }
                            else
                            {
                                if (xd_apoio > 0.25)
                                {
                                    espessura++;
                                    continue;
                                }
                            }

                            double as_apoio = lambda * fc * 100 * x_apoio / fyd;
                            textoResultado += $"Altura útil: {d_apoio:F2} cm\n";
                            textoResultado += $"X: {x_apoio:F2}cm | x/d: {xd_apoio:F2}\n";
                            textoResultado += $"As,engaste calculada: {as_apoio:F2} cm²/m\n";
                        }

                        flagEspessura = false;
                    }

                    break;
            }

            return textoResultado;
        }
    
        private double pegaFck()
        {
            switch (comboClasseConcreto.Text)
            {
                case "C20":
                    return 2.0;
                case "C25":
                    return 2.5;
                case "C30":
                    return 3.0;
                case "C35":
                    return 3.5;
                case "C40":
                    return 4.0;
                case "C45":
                    return 4.5;
                case "C50":
                    return 5.0;
                case "C55":
                    return 5.5;
                case "C60":
                    return 6.0;
                case "C65":
                    return 6.5;
                case "C70":
                    return 7.0;
                case "C75":
                    return 7.5;
                case "C80":
                    return 8.0;
                case "C85":
                    return 8.5;
                default:
                    return 9.0;
            }
        }

        private double pegaFyk()
        {
            switch (comboTipoAco.Text)
            {
                case "CA-60":
                    return 60.0;
                default:
                    return 50.0;
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desenvolvido por:\nGabriel Orso Garcia\nMestrando do PPGEC/UFRGS\nggaarcia2@gmail.com\n","Informações:",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
