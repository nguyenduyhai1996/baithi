using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class QuanLyTheLoai : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            laybangchogridview();

            HienThiHangDauTienChoCacTextBox();

            //không cho phép chọn một số nút
            cmdGhi.Enabled = false;
            cmdKhongGhi.Enabled = false;

            //Không hiển thị một số nút sau
            //lblThongBao.Text = "";
            lblThongBao.Visible = false;
            cmdCo.Visible = false;
            cmdKhong.Visible = false;
        }
    }


    public void laybangchogridview()
    {
        ketnoi kn = new ketnoi();
        DataTable dt = new DataTable();
        dt = kn.laybang("select * from TheLoai");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }


    public void HienThiHangDauTienChoCacTextBox()
    {
        ketnoi kn = new ketnoi();
        DataTable dt = new DataTable();
        dt = kn.laybang("select * from TheLoai");

        txtMaLoai.Text = dt.Rows[0]["MaLoai"].ToString();
        txtTenLoai.Text = dt.Rows[0]["TenLoai"].ToString();

        //Sau khi hiển thị không cho chọn vào hộp văn bản
        txtMaLoai.Enabled = false;
        txtTenLoai.Enabled = false;
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Lấy giá trị dong được chọn trên GridView
        int dong = GridView1.SelectedIndex;

        ketnoi kn = new ketnoi();
        DataTable dt = new DataTable();
        dt = kn.laybang("select * from TheLoai");

        txtMaLoai.Text = dt.Rows[dong][0].ToString();
        txtTenLoai.Text = dt.Rows[dong][1].ToString();
    }


    protected void cmdThem_Click(object sender, EventArgs e)
    {
        //Trường khóa chính luôn vô hiệu hóa
        txtMaLoai.Enabled = false;

        //Cho phép nhập dữ liệu vào các hộp văn bản (ở GridView đã vô hiệu hóa nhập, lệnh này cho phép nhập trở lại)
        txtTenLoai.Enabled = true;

        //Cho giá trị trong các hộp văn bản là rỗng
        txtMaLoai.Text = "";
        txtTenLoai.Text = "";

        txtTenLoai.Focus();

        //Cho phép chọn một số nút
        cmdGhi.Enabled = true;
        cmdKhongGhi.Enabled = true;

        //Vô hiệu hóa một số nút sau
        cmdThem.Enabled = false;
        cmdXoa.Enabled = false;
        cmdSua.Enabled = false;

        //Nút "Thêm": khi nhấn nút "Ghi" nó sẽ ghi (insert) vào cơ sở dữ liệu
        //Nút "Sửa": khi nhấn nút "Ghi" nó sẽ cập nhật (update) dữ liệu
        // Do đó cần đánh dấu nó để phân biệt khi nào nhấn nút "Thêm", khi nào nhấn nút "Sửa"
        // ViewState["flag"] = true; nghĩa là nút "Thêm" đang được nhấn
        ViewState["flag"] = true;
    }


    protected void cmdXoa_Click(object sender, EventArgs e)
    {
        lblThongBao.Visible = true;
        lblThongBao.Text = "Bạn có muốn xóa không?";
        cmdCo.Visible = true;
        cmdKhong.Visible = true;
    }


    protected void cmdCo_Click(object sender, EventArgs e)
    {
        ketnoi kn = new ketnoi();
        int kq = kn.xulydulieu("delete TheLoai where MaLoai='" + txtMaLoai.Text + "'");
        if (kq > 0)
        {
            lblThongBao.Visible = true;
            lblThongBao.Text = "Bạn đã xóa thành công!";
            laybangchogridview();
            cmdCo.Visible = false;
            cmdKhong.Visible = false;

            HienThiHangDauTienChoCacTextBox();
        }
    }


    protected void cmdKhong_Click(object sender, EventArgs e)
    {
        lblThongBao.Visible = false;
        cmdCo.Visible = false;
        cmdKhong.Visible = false;
    }


    protected void cmdSua_Click(object sender, EventArgs e)
    {
        //Trường khóa chính luôn vô hiệu hóa
        txtMaLoai.Enabled = false;

        //Cho phép nhập dữ liệu vào các hộp văn bản (ở GridView đã vô hiệu hóa nhập, lệnh này cho phép nhập trở lại)
        txtTenLoai.Enabled = true;

        //Cho phép chọn một số nút
        cmdGhi.Enabled = true;
        cmdKhongGhi.Enabled = true;

        //Vô hiệu hóa một số nút sau
        cmdThem.Enabled = false;
        cmdXoa.Enabled = false;
        cmdSua.Enabled = false;

        //Nút "Thêm": khi nhấn nút "Ghi" nó sẽ ghi (insert) vào cơ sở dữ liệu
        //Nút "Sửa": khi nhấn nút "Ghi" nó sẽ cập nhật (update) dữ liệu
        // Do đó cần đánh dấu nó để phân biệt khi nào nhấn nút "Thêm", khi nào nhấn nút "Sửa"
        // ViewState["flag"] = false; nghĩa là nút "Sửa" đang được nhấn
        ViewState["flag"] = false;
    }


    public void sua()
    {
        ketnoi kn = new ketnoi();
        int kq = kn.xulydulieu("Update TheLoai set TenLoai=N'" + txtTenLoai.Text + "' where MaLoai='" + txtMaLoai.Text + "'");
        if (kq > 0)
        {
            lblThongBao.Visible = true;
            lblThongBao.Text = "Bạn đã sửa thành công!";
            laybangchogridview();
        }
        else
        {
            lblThongBao.Visible = true;
            lblThongBao.Text = "Bạn đã sửa không thành công!";
        }
    }


    public void them()
    {
        ketnoi kn = new ketnoi();
        int kq = kn.xulydulieu("Insert into TheLoai(TenLoai) Values(N'" + txtTenLoai.Text + "')");
        if (kq > 0)
        {
            lblThongBao.Visible = true;
            lblThongBao.Text = "Bạn đã thêm thành công!";
            laybangchogridview();
        }
        else
        {
            lblThongBao.Visible = true;
            lblThongBao.Text = "Bạn đã thêm không thành công!";
        }
    }


    protected void cmdGhi_Click(object sender, EventArgs e)
    {
        if ((bool)ViewState["flag"] == true)
        {
            them();

            //Vô hiệu hóa một số nút sau
            cmdGhi.Enabled = false;
            cmdKhongGhi.Enabled = false;

            //Cho phép các nút sau hoạt động
            cmdThem.Enabled = true;
            cmdXoa.Enabled = true;
            cmdSua.Enabled = true;

            HienThiHangDauTienChoCacTextBox();
        }
        else
        {
            sua();

            //Vô hiệu hóa một số nút sau
            cmdGhi.Enabled = false;
            cmdKhongGhi.Enabled = false;

            //Cho phép các nút sau hoạt động
            cmdThem.Enabled = true;
            cmdXoa.Enabled = true;
            cmdSua.Enabled = true;

            HienThiHangDauTienChoCacTextBox();
        }
    }


    protected void cmdKhongGhi_Click(object sender, EventArgs e)
    {
        lblThongBao.Visible = true;
        lblThongBao.Text = "Đã hủy!";

        //Cho phép các nút sau hoạt động
        cmdThem.Enabled = true;
        cmdXoa.Enabled = true;
        cmdSua.Enabled = true;

        //Vô hiệu hóa một số nút sau
        cmdGhi.Enabled = false;
        cmdKhongGhi.Enabled = false;

        HienThiHangDauTienChoCacTextBox();
    }
}