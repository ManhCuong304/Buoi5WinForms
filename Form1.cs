using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab5_Entity
{
    public partial class Form1 : Form
    {
        private Model1 md1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            md1 = new Model1();
            List<SinhVien> students = md1.SinhViens.ToList();
            List<Khoa> khoastd = md1.Khoas.ToList();
            cmbKhoa.DataSource = khoastd;
            cmbKhoa.DisplayMember = "MaKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
            dataGridView1.Rows.Clear();
            foreach (var student in students)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["clMa"].Value = student.MSSV;
                dataGridView1.Rows[index].Cells["clTen"].Value = student.TenSinhVien;
                dataGridView1.Rows[index].Cells["clKhoa"].Value = student.MaKhoa;
                dataGridView1.Rows[index].Cells["clDiem"].Value = student.DiemTrungBinh;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string msv = txtMSSV.Text;
                string ten = txtHoTen.Text;
                string khoa = cmbKhoa.Text;
                decimal dtb = decimal.Parse(txtDTB.Text);
                var udsinhvien = md1.SinhViens.FirstOrDefault(student => student.MSSV == msv);
                if (udsinhvien != null)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại.");
                    return;
                }
                SinhVien s = new SinhVien()
                {
                    MSSV = msv,
                    TenSinhVien = ten,
                    MaKhoa = khoa,
                    DiemTrungBinh = dtb,
                };
                md1.SinhViens.Add(s);
                md1.SaveChanges();
                LoadDataGridView();
                MessageBox.Show("Thêm sinh viên thành công!");
                txtMSSV.Clear();
                txtHoTen.Clear();
                txtDTB.Clear();
                cmbKhoa.SelectedIndex = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho Mã, Điểm.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
            }

        }

        private void LoadDataGridView()
        {
            List<SinhVien> students = md1.SinhViens.ToList();
            dataGridView1.Rows.Clear();
            foreach(var student in students)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells["clMa"].Value = student.MSSV;
                dataGridView1.Rows[index].Cells["clTen"].Value = student.TenSinhVien;
                dataGridView1.Rows[index].Cells["clKhoa"].Value = student.MaKhoa;
                dataGridView1.Rows[index].Cells["clDiem"].Value = student.DiemTrungBinh;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string msv = dataGridView1.SelectedRows[0].Cells["clMa"].Value.ToString();
                var sinhvien1 = md1.SinhViens.FirstOrDefault(student => student.MSSV == msv);

                if (sinhvien1 != null)
                {
                    md1.SinhViens.Remove(sinhvien1);
                    md1.SaveChanges();
                    LoadDataGridView();
                    MessageBox.Show("Xóa sinh viên thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên với mã này.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    string msv = dataGridView1.SelectedRows[0].Cells["clMa"].Value.ToString();
                    var studentEdit = md1.SinhViens.FirstOrDefault(s => s.MSSV == msv);

                    if (studentEdit != null)
                    {
                        string newMSSV = txtMSSV.Text;
                        if (newMSSV != studentEdit.MSSV)
                        {
                            var existingStudent = md1.SinhViens.FirstOrDefault(s => s.MSSV == newMSSV);
                            if (existingStudent != null)
                            {
                                MessageBox.Show("Mã sinh viên mới đã tồn tại. Vui lòng nhập mã khác.");
                                return;
                            }
                            studentEdit.MSSV = newMSSV;
                        }
                        studentEdit.TenSinhVien = txtHoTen.Text;
                        studentEdit.MaKhoa = cmbKhoa.SelectedValue.ToString();
                        studentEdit.DiemTrungBinh = decimal.Parse(txtDTB.Text);
                        md1.SaveChanges();
                        LoadDataGridView();

                        MessageBox.Show("Cập nhật sinh viên thành công!");
                        txtMSSV.Clear();
                        txtHoTen.Clear();
                        txtDTB.Clear();
                        cmbKhoa.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên không tồn tại!");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho Mã, Điểm.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để chỉnh sửa.");
            }
        }
    }
}
