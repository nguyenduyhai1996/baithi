using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class QuanLySach : System.Web.UI.Page
{
    public void laybangchogridview()
    {
        ketnoi kn = new ketnoi();
        DataTable dt = new DataTable();
        dt = kn.laybang("select * from Sach order by MaSach desc");
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }


    public void HienThiHangDauTienTrongBangSachChoCacTextBox()
    {
        ketnoi kn = new ketnoi();
        DataTable dt = new DataTable();
        dt = kn.laybang("select * from Sach order by MaSach desc");
        GridView1.DataSource = dt;
        GridView1.DataBind();

        txtMaSach.Text = dt.Rows[0]["MaSach"].ToString();  //0: là dòng đầu tiên trong bảng Sach được chọn ; MaSach: là cột được chọn
        txtTenSach.Text = dt.Rows[0]["TenSach"].ToString();
        txtTacGia.Text = dt.Rows[0]["TacGia"].ToString();
        txtGia.Text = dt.Rows[0]["Gia"].ToString();
        txtSoLuong.Text = dt.Rows[0]["SoLuong"].ToString();
        txtMoTa.Text = dt.Rows[0]["MoTa"].ToString();
        //Hiển thị ảnh của sách tương ứng ra điều khiển Image
        imgSach.ImageUrl = "~/Images/" + dt.Rows[0]["TenFileAnh"].ToString();
        //Hiển thị tên file ảnh sách từ csdl vào trong hộp văn bản txtTenFileAnh
        txtTenFileAnh.Text = dt.Rows[0]["TenFileAnh"].ToString();
        txtMaLoai.Text = dt.Rows[0]["MaLoai"].ToString();

        //Sau khi hiển thị lên hộp văn bản, không cho chọn vào trong hộp văn bản như sau
        txtMaSach.Enabled = false;
        txtTenSach.Enabled = false;
        txtTacGia.Enabled = false;
        txtGia.Enabled = false;
        txtSoLuong.Enabled = false;
        txtMoTa.Enabled = false;
        txtTenFileAnh.Enabled = false;
        txtMaLoai.Enabled = false;

        //Vô hiệu hóa nút Upload ảnh và điều khiển chọn ảnh FileUpload1
        btnUploadAnh.Enabled = false;
        FileUpload1.Enabled = false;
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)       //có IsPostBack thì khi chọn một mục trên GridView và bấm nút "Sửa" thì mới có tác dụng sửa cho mục được chọn đó
        {
            laybangchogridview();

            //Không hiển thị một số nút sau
            //lblThongBao.Text = "";
            lblThongBao.Visible = false;
            cmdCo.Visible = false;
            cmdKhong.Visible = false;

            //không cho phép chọn một số nút
            cmdGhi.Enabled = false;
            cmdKhongGhi.Enabled = false;

            //Luôn cho hộp văn bản mã sách không được chọn
            txtMaSach.Enabled = false;

            //Muốn khi chạy ứng dụng, hàng đầu tiên trong bảng Sach được tải lên các TextBox: txtMaSach, txtTenSach,... thì viết như sau:
            HienThiHangDauTienTrongBangSachChoCacTextBox();

            // ViewState["flag"] = false; nghĩa là nút "Sửa" đang được nhấn
            ViewState["flag"] = false;
        }
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        imgSach.Visible = true;

        int dong = GridView1.SelectedIndex;   //Khai báo dòng
        ketnoi kn = new ketnoi();
        DataTable dt = new DataTable();
        dt = kn.laybang("select * from Sach order by MaSach desc");

        txtMaSach.Text = dt.Rows[dong][0].ToString();  //dong: là dòng được chọn ; 0: là cột MaSach
        txtTenSach.Text = dt.Rows[dong][1].ToString();  //dong: là dòng được chọn ; 1: là cột TenSach
        txtTacGia.Text = dt.Rows[dong][2].ToString();
        txtGia.Text = dt.Rows[dong][3].ToString();
        txtSoLuong.Text = dt.Rows[dong][4].ToString();
        txtMoTa.Text = dt.Rows[dong][5].ToString();
        //Hiển thị ảnh của sách tương ứng ra điều khiển Image
        imgSach.ImageUrl = "~/Images/" + dt.Rows[dong][6].ToString();
        //Hiển thị tên file ảnh sách từ csdl vào trong hộp văn bản txtTenFileAnh
        txtTenFileAnh.Text = dt.Rows[dong][6].ToString();
        txtMaLoai.Text = dt.Rows[dong][7].ToString();

        txtTenFileAnh.Visible = true;
        lblAnhSach.Visible = true;

        //Sau khi hiển thị lên hộp văn bản, không cho chọn vào trong hộp văn bản như sau
        txtMaSach.Enabled = false;
        txtTenSach.Enabled = false;
        txtTacGia.Enabled = false;
        txtGia.Enabled = false;
        txtSoLuong.Enabled = false;
        txtMoTa.Enabled = false;
        txtTenFileAnh.Enabled = false;
        txtMaLoai.Enabled = false;

        //Cho phép các nút sau hoạt động
        cmdThem.Enabled = true;
        cmdXoa.Enabled = true;
        cmdSua.Enabled = true;

        //Vô hiệu hóa một số nút sau
        cmdGhi.Enabled = false;
        cmdKhongGhi.Enabled = false;

        //Không Cho phép nút Upload ảnh và điều khiển chọn ảnh FileUpload1 được hoạt động
        btnUploadAnh.Enabled = false;
        FileUpload1.Enabled = false;
    }


    protected void btnUploadAnh_Click(object sender, EventArgs e)
    {
        string TenFileAnhLayDuoc;
        //Tách lấy tên tập tin
        TenFileAnhLayDuoc = FileUpload1.FileName;
        //Thực hiện chép file ảnh lấy được lên thư mục Images nằm trong ứng dụng Website
        FileUpload1.SaveAs(MapPath("~/Images/" + TenFileAnhLayDuoc));

        //Đưa tên ảnh lấy được ra điều khiển Image để hiển thị ảnh
        imgSach.ImageUrl = "~/Images/" + TenFileAnhLayDuoc;

        //Đưa tên ảnh lấy được vào hộp văn bản txtTenFileAnh để hiển thị tên file ảnh lấy được vào hộp văn bản này
        txtTenFileAnh.Text = TenFileAnhLayDuoc;
    }


    protected void cmdThem_Click(object sender, EventArgs e)
    {
        txtMaSach.Enabled = false;

        //Cho phép nhập dữ liệu vào các hộp văn bản (ở GridView đã vô hiệu hóa nhập, lệnh này cho phép nhập trở lại)
        txtTenSach.Enabled = true;
        txtTacGia.Enabled = true;
        txtGia.Enabled = true;
        txtSoLuong.Enabled = true;
        txtMoTa.Enabled = true;
        txtTenFileAnh.Enabled = true;
        txtMaLoai.Enabled = true;

        //Cho phép nút Upload ảnh và điều khiển chọn ảnh FileUpload1 được hoạt động
        btnUploadAnh.Enabled = true;
        FileUpload1.Enabled = true;

        //Cho giá trị trong các hộp văn bản là rỗng
        txtMaSach.Text = "";
        txtTenSach.Text = "";
        txtTacGia.Text = "";
        txtGia.Text = "";
        txtSoLuong.Text = "";
        txtMoTa.Text = "";
        txtTenFileAnh.Text = "";
        txtMaLoai.Text = "";

        imgSach.ImageUrl = "";

        txtTenSach.Focus();

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
        int kq = kn.xulydulieu("Delete Sach where MaSach='" + txtMaSach.Text + "'");
        if (kq > 0)
        {
            lblThongBao.Visible = true;
            lblThongBao.Text = "Bạn đã xóa thành công!";
            laybangchogridview();
            cmdCo.Visible = false;
            cmdKhong.Visible = false;

            //Muốn khi chạy ứng dụng, hàng đầu tiên trong bảng Sach được tải lên các TextBox: txtMaSach, txtTenSach,... thì viết như sau:
            HienThiHangDauTienTrongBangSachChoCacTextBox();
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
        //nút sửa có lệnh như nút thêm nhưng không có xóa rỗng các hộp văn bản

        txtMaSach.Enabled = false;

        //Cho phép nhập dữ liệu vào các hộp văn bản (ở GridView đã vô hiệu hóa nhập, lệnh này cho phép nhập trở lại)
        txtTenSach.Enabled = true;
        txtTacGia.Enabled = true;
        txtGia.Enabled = true;
        txtSoLuong.Enabled = true;
        txtMoTa.Enabled = true;
        txtTenFileAnh.Enabled = true;
        txtMaLoai.Enabled = true;

        //Cho phép nút Upload ảnh và điều khiển chọn ảnh FileUpload1 được hoạt động
        btnUploadAnh.Enabled = true;
        FileUpload1.Enabled = true;

        txtTenSach.Focus();

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
        int kq = kn.xulydulieu("Update Sach set TenSach=N'" + txtTenSach.Text + "',TacGia=N'" + txtTacGia.Text + "',Gia='" + txtGia.Text + "',SoLuong='" + txtSoLuong.Text + "',MoTa=N'" + txtMoTa.Text + "',TenFileAnh=N'" + txtTenFileAnh.Text + "',MaLoai='" + txtMaLoai.Text + "' where MaSach='" + txtMaSach.Text + "'");
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
        int kq = kn.xulydulieu("Insert into Sach(TenSach,TacGia,Gia,SoLuong,MoTa,TenFileAnh,MaLoai) Values(N'" + txtTenSach.Text + "',N'" + txtTacGia.Text + "','" + txtGia.Text + "','" + txtSoLuong.Text + "',N'" + txtMoTa.Text + "',N'" + txtTenFileAnh.Text + "','" + txtMaLoai.Text + "')");
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

            HienThiHangDauTienTrongBangSachChoCacTextBox();
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

            HienThiHangDauTienTrongBangSachChoCacTextBox();
        }
    }


    protected void cmdKhongGhi_Click(object sender, EventArgs e)
    {
        lblThongBao.Visible = true;
        lblThongBao.Text = "Đã hủy!";

        cmdThem.Enabled = true;
        cmdXoa.Enabled = true;
        cmdSua.Enabled = true;

        cmdGhi.Enabled = false;
        cmdKhongGhi.Enabled = false;

        HienThiHangDauTienTrongBangSachChoCacTextBox();
    }
}