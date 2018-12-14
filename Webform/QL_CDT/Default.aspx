<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QL_CDT._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div id="myCarousel" class="carousel slide" data-ride="carousel" style="margin-bottom: 40px">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner">
                <div class="item active">
                    <img style="width: 100%; height: 400px" src="images/banner1.png" alt="khuyenmai1">
                </div>

                <div class="item">
                    <img style="width: 100%; height: 400px" src="images/banner2.jpg" alt="khuyenmai2">
                </div>

                <div class="item">
                    <img style="width: 100%; height: 400px" src="images/banner3.jpg" alt="khuyenmai3">
                </div>
            </div>

            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>


    <div class="row" style="margin-bottom: 30px">
        <div class="col-md-12">
            <h2>Tra cứu thông tin sử dụng</h2>
        </div>

        <div runat="server" id="divError" class="row">
            <div class="col-md-6">
                <div style="color: #721c24; background-color: #f8d7da; border-color: #f5c6cb; position: relative; padding: 1.15rem; margin-bottom: 1rem; border: 1px solid transparent; border-radius: .25rem; margin: 10px">
                    <asp:Label runat="server" ID="lblError" Font-Bold="true" />
                </div>
            </div>
        </div>

        <div class="col-md-5" style="margin-top: 15px">
            <label>Số Chứng Minh Nhân Dân:</label>
            <asp:TextBox runat="server" ID="tbCMND" CssClass="form-control" Style="margin-top: 10px; margin-bottom: 10px" />
        </div>
        <div class="col-md-1" style="margin-top: 24px">
            <label>Tháng:</label>
            <asp:DropDownList runat="server" ID="ddlThang" CssClass="form-control">
            </asp:DropDownList>
        </div>
        <div class="col-md-1" style="margin-top: 24px">
            <label>Năm:</label>
            <asp:DropDownList runat="server" ID="ddlNam" CssClass="form-control">
            </asp:DropDownList>
        </div>
        <div class="col-md-2" style="margin-top: 40px">
            <asp:Button runat="server" ID="btnSearch" Text="Tra cứu" CssClass="btn btn-success" Style="margin-top: 10px" OnClick="btnSearch_Click" />
        </div>
    </div>

    <div class="row" runat="server" id="generalInfo">
        <div class="col-md-12" style="margin: 8px 0">
            <h4>Tên khách hàng: <asp:Label runat="server" ID="lblName" /></h4>
        </div>
    </div>

    <div class="row" runat="server" id="divHDDK" visible="false">
        <div class="col-md-12" style="margin: 8px 0">
            <h4>Danh sách hợp đồng đăng ký</h4>
        </div>
    </div>
    <asp:GridView ID="gvHDDK" runat="server" CellPadding="4" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:BoundField DataField="IDSIM" HeaderText="Số điện thoại" />
            <asp:BoundField DataField="NGAYBD" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Ngày bắt đầu" />
            <asp:BoundField DataField="NGAYKT" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Hạn hợp đồng" />
            <asp:BoundField DataField="CUOCDK" HeaderText="Cước duy trì" DataFormatString="{0:#,##0}">
                <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>

    <div class="row" runat="server" id="divHDTC" visible="false">
        <div class="col-md-12" style="margin: 8px 0">
            <h4>Danh sách thanh toán</h4>
        </div>
    </div>
    <asp:GridView ID="gvHDTC" runat="server" CellPadding="4" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:BoundField DataField="IDSIM" HeaderText="Số điện thoại" />
            <asp:BoundField DataField="THANG" HeaderText="Tháng" />
            <asp:BoundField DataField="NAM" HeaderText="Năm" />
            <asp:BoundField DataField="TONGTIEN" HeaderText="Tổng tiền" DataFormatString="{0:#,##0}" />
            <asp:TemplateField HeaderText="Trạng thái">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("THANHTOAN").ToString() == "True" ? "Đã thanh toán" : "Chưa thanh toán" %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Right" />
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>


    <div class="row" runat="server" id="divCTSD" visible="false">
        <div class="col-md-12" style="margin: 8px 0">
            <h4>Chi tiết sử dụng tháng <%= ddlThang.SelectedValue %> năm <%= ddlNam.SelectedValue %></h4>
        </div>
    </div>
    <asp:GridView ID="gvCTSD" runat="server" CellPadding="4" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
        <Columns>
            <asp:BoundField DataField="IDSIM" HeaderText="Số điện thoại" />
            <asp:BoundField DataField="TGBD" DataFormatString="{0:HH:mm:ss dd/MM/yyyy}" HeaderText="Thời gian bắt đầu" />
            <asp:BoundField DataField="TGKT" DataFormatString="{0:HH:mm:ss dd/MM/yyyy}" HeaderText="Thời gian kết thúc" />
            <asp:BoundField DataField="SOPHUTSD" HeaderText="Số phút" />
            <asp:BoundField DataField="CUOCPHI" HeaderText="Thành tiền" DataFormatString="{0:#,##0}">
                <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>

    <div class="row" runat="server" id="divFooter" visible="false">
        <div class="col-md-12" style="margin: 8px 0">
            <h4>Tổng số phút: <asp:Label runat="server" ID="lblSoPhut" /></h4>
            <h4>Tổng số tiền: <asp:Label runat="server" ID="lblSoTien" /></h4>
        </div>
    </div>

</asp:Content>
