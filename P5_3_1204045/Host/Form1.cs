using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(816, 401);
        }

        

        private void matkul_Click(object sender, EventArgs e)
        {
            if (npm.Text != "")
            {
                if (nama.Text != "")
                {
                    if (pria.Checked || wanita.Checked)
                    {
                        if (alamat.Text != "")
                        {
                            if (prodi.Text != "– Pilih Program Studi –")
                            {
                                if (tahun.Text != "" && Regex.IsMatch(tahun.Text, @"^\d{4}/\d{4}$"))
                                {
                                    if (sems.Text != "")
                                    {
                                        MessageBox.Show
                                                    ("Data Lengkap!",
                                                    "Informasi Data Mahasiswa",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Size = new Size(816, 640);

                                    }
                                    else
                                    {
                                        MessageBox.Show
                                                    ("Semester belum diisi, harap isi semester yang ditempuh!",
                                                    "Informasi Data Mahasiswa",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    if (tahun.Text != "")
                                    {
                                        if (Regex.IsMatch(tahun.Text, @"^\d{4}/\d{4}$"))
                                        {
                                            warning.SetError(tahun, "");
                                        }
                                        else
                                        {
                                            wrong.SetError(tahun, "Format Tahun Akademik Salah!");
                                            MessageBox.Show
                                                ("Format Tahun Akademik Salah!",
                                                "Informasi Data Mahasiswa",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show
                                                ("Tahun Akademik belum diisi, harap isi tahun akademik!",
                                                "Informasi Data Mahasiswa",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show
                                            ("Program Studi belum diisi!",
                                            "Informasi Data Mahasiswa",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                                        ("Alamat belum diisi!",
                                        "Informasi Data Mahasiswa",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show
                                    ("Jenis Kelamin belum diisi!",
                                    "Informasi Data Mahasiswa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                                ("Nama belum diisi!",
                                "Informasi Data Mahasiswa",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                            ("NPM belum diisi!",
                            "Informasi Data Mahasiswa",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tahun_TextChanged(object sender, EventArgs e)
        {
            if (tahun.Text != "")
            {
                if (Regex.IsMatch(tahun.Text, @"^\d{4}/\d{4}$"))
                {
                    correct.SetError(tahun, "");
                }
                else
                {
                    wrong.SetError(tahun, "Format Tahun Akademik Salah!, Contoh : 2021/2022");
                }
            }
            else
            {
                warning.SetError(tahun, "Wajib Diisi");
            }
        }

        private void Kur06RB_CheckedChanged(object sender, EventArgs e)
        {
            MatematikaCB.Enabled = true; MatematikaCB.Checked = false;
            Pemrog1CB.Enabled = true; Pemrog1CB.Checked = false;
            Pemrog2CB.Enabled = true; Pemrog2CB.Checked = false;
            Pemrog3CB.Enabled = true; Pemrog3CB.Checked = false;
            Pemrog4CB.Enabled = true; Pemrog4CB.Checked = false;
            Pemrog5CB.Enabled = true; Pemrog5CB.Checked = false;
            Pemrog6CB.Enabled = true; Pemrog6CB.Checked = false;
            Pemrog7CB.Enabled = true; Pemrog7CB.Checked = false;
            JarkomCB.Enabled = true; JarkomCB.Checked = false;
            SisOpCB.Enabled = true; SisOpCB.Checked = false;
            PLCB.Enabled = false; PLCB.Checked = false;
            MRPCB.Enabled = false; MRPCB.Checked = false;
        }

        private void Kur10RB_CheckedChanged(object sender, EventArgs e)
        {
            MatematikaCB.Enabled = false; MatematikaCB.Checked = false;
            Pemrog1CB.Enabled = true; Pemrog1CB.Checked = false;
            Pemrog2CB.Enabled = true; Pemrog2CB.Checked = false;
            Pemrog3CB.Enabled = true; Pemrog3CB.Checked = false;
            Pemrog4CB.Enabled = true; Pemrog4CB.Checked = false;
            Pemrog5CB.Enabled = true; Pemrog5CB.Checked = false;
            Pemrog6CB.Enabled = true; Pemrog6CB.Checked = false;
            Pemrog7CB.Enabled = true; Pemrog7CB.Checked = false;
            JarkomCB.Enabled = true; JarkomCB.Checked = false;
            SisOpCB.Enabled = true; SisOpCB.Checked = false;
            PLCB.Enabled = false; PLCB.Checked = false;
            MRPCB.Enabled = true; MRPCB.Checked = false;
        }

        private void Kur14RB_CheckedChanged(object sender, EventArgs e)
        {
            MatematikaCB.Enabled = false; MatematikaCB.Checked = false;
            Pemrog1CB.Enabled = true; Pemrog1CB.Checked = false;
            Pemrog2CB.Enabled = true; Pemrog2CB.Checked = false;
            Pemrog3CB.Enabled = true; Pemrog3CB.Checked = false;
            Pemrog4CB.Enabled = true; Pemrog4CB.Checked = false;
            Pemrog5CB.Enabled = true; Pemrog5CB.Checked = false;
            Pemrog6CB.Enabled = true; Pemrog6CB.Checked = false;
            Pemrog7CB.Enabled = true; Pemrog7CB.Checked = false;
            JarkomCB.Enabled = true; JarkomCB.Checked = false;
            SisOpCB.Enabled = true; SisOpCB.Checked = false;
            PLCB.Enabled = true; PLCB.Checked = false;
            MRPCB.Enabled = false; MRPCB.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jenisKelamin = null;
            if (pria.Checked)
            {
                jenisKelamin = pria.Text;
            }
            else if (wanita.Checked)
            {
                jenisKelamin = wanita.Text;
            }

            string kurikulum = null;
            if (Kur06RB.Checked)
            {
                kurikulum = Kur06RB.Text;
            }
            else if (Kur10RB.Checked)
            {
                kurikulum = Kur10RB.Text;
            }
            else if (Kur14RB.Checked)
            {
                kurikulum = Kur14RB.Text;
            }

            string matkul = null;
            if (MatematikaCB.Checked)
            {
                matkul += MatematikaCB.Text + ", ";
            }
            if (Pemrog1CB.Checked)
            {
                matkul += Pemrog1CB.Text + ", ";
            }
            if (Pemrog2CB.Checked)
            {
                matkul += Pemrog2CB.Text + ", ";
            }
            if (Pemrog3CB.Checked)
            {
                matkul += Pemrog3CB.Text + ", ";
            }
            if (Pemrog4CB.Checked)
            {
                matkul += Pemrog4CB.Text + ", ";
            }
            if (Pemrog5CB.Checked)
            {
                matkul += Pemrog5CB.Text + ", ";
            }
            if (Pemrog6CB.Checked)
            {
                matkul += Pemrog6CB.Text + ", ";
            }
            if (Pemrog7CB.Checked)
            {
                matkul += Pemrog7CB.Text + ", ";
            }
            if (PLCB.Checked)
            {
                matkul += PLCB.Text + ", ";
            }
            if (JarkomCB.Checked)
            {
                matkul += JarkomCB.Text + ", ";
            }
            if (SisOpCB.Checked)
            {
                matkul += SisOpCB.Text + ", ";
            }
            if (MRPCB.Checked)
            {
                matkul += MRPCB.Text + ", ";
            }

            MessageBox.Show
                        ("NIM: " + npm.Text +
                        "\nNama: " + nama.Text +
                        "\nJenis Kelamin: " + jenisKelamin +
                        "\nAlamat: " + alamat.Text +
                        "\nProgram Studi: " + prodi.Text +
                        "\nTahun Akademik: " + tahun.Text +
                        "\nSemester: " + sems.Text +
                        "\n==================================" +
                        "\nKurikulum: " + kurikulum +
                        "\nMata Kuliah: " + matkul,
                        "Informasi Data Mahasiswa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            npm.Text = null;
            nama.Text = null;
            pria.Checked = false;
            wanita.Checked = false;
            alamat.Text = null;
            prodi.Text = null;
            tahun.Text = null;
            sems.Text = null;

            Kur06RB.Checked = false;
            Kur10RB.Checked = false;
            Kur14RB.Checked = false;

            MatematikaCB.Enabled = false; MatematikaCB.Checked = false;
            Pemrog1CB.Enabled = false; Pemrog1CB.Checked = false;
            Pemrog2CB.Enabled = false; Pemrog2CB.Checked = false;
            Pemrog3CB.Enabled = false; Pemrog3CB.Checked = false;
            Pemrog4CB.Enabled = false; Pemrog4CB.Checked = false;
            Pemrog5CB.Enabled = false; Pemrog5CB.Checked = false;
            Pemrog6CB.Enabled = false; Pemrog6CB.Checked = false;
            Pemrog7CB.Enabled = false; Pemrog7CB.Checked = false;
            JarkomCB.Enabled = false; JarkomCB.Checked = false;
            SisOpCB.Enabled = false; SisOpCB.Checked = false;
            PLCB.Enabled = false; PLCB.Checked = false;
            MRPCB.Enabled = false; MRPCB.Checked = false;

            this.Size = new Size(816, 401);

            MessageBox.Show
                        ("Form telah direset",
                        "Informasi Data Mahasiswa",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
