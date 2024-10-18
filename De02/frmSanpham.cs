using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De02
{
    public partial class frmSanpham : Form
    {
        Model1 model1 = new Model1();
        public frmSanpham()
        {
            InitializeComponent();
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            List<Sanpham> listSanpham = model1.Sanphams.ToList();
            List<LoaiSP> listLoaiSP = model1.LoaiSPs.ToList();
            fillDGVSP(listSanpham);
            fillCBBLOAI(listLoaiSP);
        }

        private void fillDGVSP(List<Sanpham> listSanpham)
        {
            dgvsp.Rows.Clear();//Xóa trắng bảng
            foreach (Sanpham sanpham in listSanpham)
            {
                int newRows = dgvsp.Rows.Add();
                dgvsp.Rows[newRows].Cells[0].Value = sanpham.MaSP;
                dgvsp.Rows[newRows].Cells[1].Value = sanpham.TenSP;
                dgvsp.Rows[newRows].Cells[2].Value = sanpham.NgayNhap;
                dgvsp.Rows[newRows].Cells[3].Value = sanpham.LoaiSP;

            }
        }

        private void fillCBBLOAI(List<LoaiSP> listLoaiSP)
        {
            cbbloai.DataSource = listLoaiSP;
            //đặt tên hiển thị
            cbbloai.DisplayMember = "TenLoai"; //TenLoai
            //đặt tên xử lí 
            cbbloai.SelectedItem = "Maloai";// Maloai
        }

        private void dgvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvsp.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    txtmasp.Text = dgvsp.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txttensp.Text = dgvsp.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dtpngaynhap.Text = dgvsp.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbbloai.Text = dgvsp.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
            }
        }

        private void bttthem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng sinh viên mới từ các thông tin nhập
            Sanpham sanpham = new Sanpham()
            {
                MaSP = txtmasp.Text,
                TenSP = txttensp.Text,
                MaLoai = (cbbloai.SelectedItem as LoaiSP).Maloai,
                NgayNhap = dtpngaynhap.Value,
            };

            // Thêm vào database context
            model1.Sanphams.Add(sanpham);

            // Lưu thay đổi vào cơ sở dữ liệu
            model1.SaveChanges();

            // Cập nhật lại danh sách sinh viên trên giao diện
            fillDGVSP(model1.Sanphams.ToList());
        }

        private void bttsua_Click(object sender, EventArgs e)
        {

            string MaSP = txtmasp.Text;
            Sanpham sanpham = model1.Sanphams.FirstOrDefault(s => s.MaSP == MaSP);

            if (sanpham != null)
            {

                sanpham.TenSP = txttensp.Text;
                sanpham.MaLoai = (cbbloai.SelectedItem as LoaiSP).Maloai;


                // Lưu thay đổi vào cơ sở dữ liệu
                model1.SaveChanges();


                fillDGVSP(model1.Sanphams.ToList());
            }
        }

        private void bttxoa_Click(object sender, EventArgs e)
        {
            
            string MaSP = txtmasp.Text;
            Sanpham sanpham = model1.Sanphams.FirstOrDefault(s => s.MaSP == MaSP);

            if (sanpham != null)
            {
               
                model1.Sanphams.Remove(sanpham);

                
                model1.SaveChanges();

                
                fillDGVSP(model1.Sanphams.ToList());
            }
        }

        private void bttthoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btttim_Click(object sender, EventArgs e)
        {
            string keyword = txttim.Text.Trim(); // Lấy từ khóa tìm kiếm từ TextBox

            // Tìm kiếm sản phẩm theo tên
            var searchResults = model1.Sanphams
                .Where(s => s.TenSP.Contains(keyword)) // Sử dụng Contains để tìm kiếm
                .ToList();

            // Cập nhật DataGridView với kết quả tìm kiếm
            fillDGVSP(searchResults);
        }
    }
    }

