using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
namespace PTUD_GUI
{
    public partial class FormDSBN : Form
    {
        BenhNhanBLL bnBLL;
        List<eBenhNhan> dsBN;
        BindingSource bsBN;
        public FormDSBN()
        {
            InitializeComponent();
            bsBN = new BindingSource();
            bnBLL = new BenhNhanBLL();
            dsBN = new List<eBenhNhan>();
            dsBN = bnBLL.LayThongTinBenhNhan();
            HienThiThongTinBenhNhan();
            AutoComplete();
            tbTimKiemBN.Text = "Nhập mã bệnh nhân";
            tbTimKiemBN.ForeColor = Color.Gray;
        }
        private void FormDSBN_Load(object sender, EventArgs e)
        {

        }
        public void HienThiThongTinBenhNhan()
        {
            var gridviewInfo = dsBN.Select(dt => new
            {
                MaBenhNhan = dt.MaBenhNhan,
                TenBenhNhan = dt.TenBenhNhan,
                NamSinh = dt.NamSinh,
                GioiTinh = dt.GioiTinh,
                SDT = dt.SDT,
                DiaChi=dt.DiaChi,
            }).ToList();
            bsBN.DataSource = gridviewInfo;
            dgvDSBN.DataSource = bsBN;
            dgvDSBN.Columns[0].HeaderText = "Mã Bệnh Nhân";
            dgvDSBN.Columns[1].HeaderText = "Tên Bệnh Nhân";
            dgvDSBN.Columns[2].HeaderText = "Năm Sinh";
            dgvDSBN.Columns[3].HeaderText = "Giới Tính";
            dgvDSBN.Columns[4].HeaderText = "SĐT";
            dgvDSBN.Columns[5].HeaderText = "Địa Chỉ";
            dgvDSBN.Columns[1].Width = 170;
            dgvDSBN.Columns[0].Width = 150;
            dgvDSBN.Columns[2].Width = 60;
            dgvDSBN.Columns[3].Width = 57;
        }
        public delegate void GetString(String mbn, String tkh, String ns, String gt,String sdt,String diachi);
        public GetString MyGetData;
        public void button1_Click(object sender, EventArgs e)
        {
            int index = dgvDSBN.CurrentRow.Index;
            if (MyGetData != null)
            {
                MyGetData(dgvDSBN.Rows[index].Cells[0].Value.ToString(), dgvDSBN.Rows[index].Cells[1].Value.ToString(), dgvDSBN.Rows[index].Cells[2].Value.ToString(), dgvDSBN.Rows[index].Cells[3].Value.ToString(), dgvDSBN.Rows[index].Cells[4].Value.ToString(), dgvDSBN.Rows[index].Cells[5].Value.ToString());
            }
            this.Close();
            this.Dispose();
        }
        private void AutoComplete()
        {
            tbTimKiemBN.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbTimKiemBN.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            foreach (var item in dsBN)
            {
                col.Add(item.MaBenhNhan);
            }
            tbTimKiemBN.AutoCompleteCustomSource = col;
        }

        private void tbTimKiemBN_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiemBN.Text == "Nhập mã bệnh nhân")
            {
                HienThiThongTinBenhNhan();
            }
            else
            {
                var newList = dsBN.Where(bn1 => bn1.MaBenhNhan.Contains(tbTimKiemBN.Text))
                .Select(t2 => new
                {
                    MaBenhNhan = t2.MaBenhNhan,
                    TenBenhNhan = t2.TenBenhNhan,
                    NamSinh = t2.NamSinh,
                    GioiTinh = t2.GioiTinh,
                }).ToList();
                bsBN.DataSource = newList;
                dgvDSBN.DataSource = bsBN;
            }
        }

        private void tbTimKiemBN_Enter_1(object sender, EventArgs e)
        {
            if (tbTimKiemBN.Text == "Nhập mã bệnh nhân")
            {
                tbTimKiemBN.Text = "";
                tbTimKiemBN.ForeColor = Color.Black;
            }
        }

        private void tbTimKiemBN_Leave_1(object sender, EventArgs e)
        {
            if (tbTimKiemBN.Text == "")
            {
                tbTimKiemBN.Text = "Nhập mã bệnh nhân";
                tbTimKiemBN.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDSBN.CurrentRow.Index;
            dgvDSBN.Rows[index].Selected = true;
        }

        private void dgvDSBN_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvDSBN.CurrentRow.Index;
            if (MyGetData != null)
            {
                MyGetData(dgvDSBN.Rows[index].Cells[0].Value.ToString(), dgvDSBN.Rows[index].Cells[1].Value.ToString(), dgvDSBN.Rows[index].Cells[2].Value.ToString(), dgvDSBN.Rows[index].Cells[3].Value.ToString(), dgvDSBN.Rows[index].Cells[4].Value.ToString(), dgvDSBN.Rows[index].Cells[5].Value.ToString());
            }
            this.Close();
            this.Dispose();
        }
    }
}
