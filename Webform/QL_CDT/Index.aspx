<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="QL_CDT.Index" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">    
    <div class="row">
        <div id="myCarousel" class="carousel slide" data-ride="carousel" style="margin-bottom:40px">
            <!-- Indicators -->
            <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner">
            <div class="item active">
                <img style="width:100%; height:400px" src="images/banner1.png" alt="khuyenmai1">
            </div>

            <div class="item">
                <img style="width:100%;height:400px" src="images/banner2.jpg" alt="khuyenmai2">
            </div>

            <div class="item">
                <img style="width:100%;height:400px" src="images/banner3.jpg" alt="khuyenmai3">
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
    <div class="row">
        <ul class="nav nav-tabs" style="font-size:24px; font-weight:bold;margin:2%">
            <li class="active"><a data-toggle="tab" href="#" data-target="#home">Trang chủ</a></li>      
            <li><a data-toggle="tab" href="#kh" data-target="#khachhang">Thông tin khách hàng</a></li>              
            <li><a data-toggle="tab" href="#cp" data-target="#cuocphi">Tra cứu cước phí</a></li>      
        </ul>

    </div>
    <div class="tab-content">
        <div id="home" class="tab tab-pane fade in active "; style="margin:2%">  
            <div>
                <h3>My Viettel – Tra cước nhanh, sống hiện đại</h3>
                <P style="text-align:justify"><b>Ứng dụng My Viettel hỗ trợ tra cứu dễ dàng, nhanh chóng các dịch vụ viễn thông như truyền hình, cố định, di động trả trước/trả sau giúp bạn chủ động chi tiêu, tiết kiệm thời gian, sẵn sàng cho cuộc sống hối hả hiện đại.
</b></P>
                <div class="col-md-12 article_content" style="text-align: center;">
                    <div class="hidden-xs col-md-2"></div>
                    <div class="col-md-8">
                        <video controls="controls" height="240px;" id="QXJ0aWNs15ac1a78613e82" poster="http://media.vietteltelecom.vn/upload/video_cskh/3e/ce/e3/11b3debf68185aa4c7f8bfa7b027795de346918f.png" width="100%">
                            <source src="http://media.vietteltelecom.vn/upload/video_cskh/96/0f/f9/e0e5edc7273bbb189edc17aee5fcc4a2e42d57e6.mp4" type="video/mp4">
                            Your browser doesn't support video.<br>
                            Please download the file: <a href="http://media.vietteltelecom.vn/upload/video_cskh/96/0f/f9/e0e5edc7273bbb189edc17aee5fcc4a2e42d57e6.mp4">video/mp4</a></video>
                    </div>
                    <div class="hidden-xs col-md-2"></div>

                </div>
                <p style="text-align:justify">Ứng dụng My Viettel cung cấp thông tin tra cứu cước chi tiết, trực quan theo yêu cầu bất cứu khi nào bạn muốn, ngay trên chiếc điện thoại di động của bạn, mang lại trải nghiệm mới khác xa với các công cụ tra cước truyền thống như gọi tổng đài, bấm cú pháp *101#, tới cửa hàng giao dịch. Một điểm cực kỳ tiện lợi là My Viettel hỗ trợ tính năng đa tài khoản. Điều đó có nghĩa là nếu bạn hòa mạng nhiều dịch vụ trên cùng một chứng minh nhân dân thì bạn có thể linh hoạt chuyển qua các tài khoản khác nhau để tiện tra cứu mà không cần phải đăng nhập nhiều lần.

   Với các thuê bao sử dụng dịch vụ truyền hình, internet cố định có thể dễ dàng tìm thấy mục tra cước, xem chi tiết cước trên giao diện trang chủ của ứng dụng My Viettel.

   Với các thuê bao trả trước, bạn có thể tra cứu cước theo khung thời gian bất kỳ (tuần, tháng….). Cước tiêu dùng được minh họa trực quan bằng biểu đồ, giúp bạn dễ dàng cân đối chi tiêu, lựa chọn gói cước phù hợp với nhu cầu.

       Với thuê bao trả sau, ngoài việc tra cứu theo khung thời gian, bạn còn có thể tra cứu hóa đơn điện tử nhanh chóng và linh hoạt.

Tất cả các thao tác trên ứng dụng My Viettel chỉ lấy đi 1-2 phút trong quỹ thời gian vàng ngọc của bạn, để bạn có thêm thời gian tận hưởng trọn vẹn cuộc sống.

Hãy tải ứng dụng My Viettel tại www.viettel.vn/myviettel và trở thành người tiêu dùng thông minh ngay hôm nay.</p>
            </div>
    </div>
    <div id="khachhang" class="tab tab-pane fade  "; style="margin:2%"> 
           <div class="row" style="font-size:20px;">
                <div class="col-sm-1 form-group"></div>
                <div class="col-sm-2 form-group">
                    <label class="control-label" for="search_by" style="font-weight:bold">Nhập SĐT:</label>                                                             
                </div>

                <div class="col-sm-5 form-group"> 
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>                                                                                      
                </div>                   
                <div class="col-sm-1 form-group">                                
                    <asp:Button ID="Button1" runat="server" Text="Tìm" CssClass="btn btn-primary" OnClick="btn_find_Click"   />          
                </div>   
                <div class="col-sm-3 form-group"></div>
                <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2" Width="355px">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" Visible="False" InsertVisible="False" />
                                <asp:BoundField DataField="TENKH" HeaderText="Họ Tên" SortExpression="TENKH" />
                                <asp:BoundField DataField="CMND" HeaderText="CMND" SortExpression="CMND" />
                                <asp:BoundField DataField="NGHENGHIEP" HeaderText="Nghề Nghiệp" SortExpression="NGHENGHIEP" />
                                <asp:BoundField DataField="CHUCVU" HeaderText="Chức vụ" SortExpression="CHUCVU" />
                                <asp:BoundField DataField="DIACHI" HeaderText="Địa Chỉ" SortExpression="DIACHI" />
                                <asp:CheckBoxField DataField="TINHTRANG" HeaderText="Tình Trạng" SortExpression="TINHTRANG" />
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CuocDTConnectionString %>" SelectCommand="SELECT * FROM [KHACHHANG]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CuocDTConnectionString %>" SelectCommand="SELECT * FROM [KHACHHANG]"></asp:SqlDataSource>
               <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
            </div>
  </div>
  <div id="cuocphi" class="tab tab-pane fade"; style="margin:2%"> 
        <div class="row" style="font-size:20px;">
                <div class="col-sm-1 form-group"></div>
                <div class="col-sm-2 form-group">
                    <label class="control-label" for="search_by" style="font-weight:bold">Nhập SĐT:</label>    
                </div>
                <div class="col-sm-5 form-group"> 
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>                                                                                      
                </div>                   
                <div class="col-sm-1 form-group">                                
                    <asp:Button ID="Button2" runat="server" Text="Tìm" CssClass="btn btn-primary" OnClick="btn_find_Click"   />          
                </div>   
                <div class="col-sm-3 form-group"></div>
            </div>
             <hr />
                <div class="row" style="font-size:20px;">
                
                <div class="col-sm-1 form-group">
                    <asp:Button ID="ngaybd" runat="server" CssClass="btn btn-primary" Text="Ngày bắt đầu" />                                                             
                </div>
                <div class="col-sm-2 form-group">
                     <asp:TextBox ID="day_start" runat="server" CssClass="text-center" ></asp:TextBox>                    
                    <cc1:CalendarExtender ID="CalendarExtender1" TargetControlID="day_start" PopupButtonID="ngaybd" Format="MM/dd/yyyy" runat="server"></cc1:CalendarExtender>                                                                                                                        
                </div> 
                <div class="col-sm-1 form-group"></div>  
                <div class="col-sm-1 form-group">
                <asp:Button ID="Button3" runat="server" Text="Tổng tiền" CssClass="btn btn-primary" OnClick="btn_display_Click"/>                                 
                </div>
                 <div class="col-sm-2 form-group">
                 <asp:TextBox CssClass="form-control" runat="server" ID="TextBox3"></asp:TextBox>
                </div>
                </div>
             <div class="row" style="font-size:20px;">
                <div class="col-sm-1 form-group">
                 <asp:Button ID="ngaykt" runat="server"  CssClass="btn btn-primary" Text="Ngày kết thúc" />                                                                               
                </div> 
                <div class="col-sm-2 form-group"> 
                    <asp:TextBox ID="day_end" runat="server" CssClass="text-center"  ></asp:TextBox>                  
                    <cc1:CalendarExtender ID="CalendarExtender2" TargetControlID="day_end" PopupButtonID="ngaykt" Format="MM/dd/yyyy" runat="server"></cc1:CalendarExtender>                                                                                                                                                                                                             
                </div>  
                 <hr />
                 <div class="col-sm-3 form-group">
                <div  class="row" style="margin:auto">
                <h2 style="text-align:center; color:red; font-weight:bold">CHI TIẾT SỬ DỤNG</h2>
                <p style="text-align:center">Danh sách chi tiết sử dụng dịch vụ cước điện thoại</p>  
                <div class="col-sm-3 form-group"></div>  
                <asp:GridView ID="tb_KhachHang" runat="server" AutoGenerateColumns="false" CssClass="table table-hover">
                <Columns>            
                    <asp:BoundField DataField="TGBD" HeaderText="Thời gian bắt đầu" />
                    <asp:BoundField DataField="TGKT" HeaderText="Thời gian kết thúc" />
                    <asp:BoundField DataField="SOPHUTSD" HeaderText="Số phút sử dụng" />
                    <asp:BoundField DataField="CUOCPHI" HeaderText="Cước phí" />
                </Columns>

                <HeaderStyle BackColor="#99CCFF" />
            </asp:GridView>
                         <div class="row" style="text-align:right;font-size:20px;">
                        <div class="col-sm-8"></div>
                        <div class="col-sm-2" style="font-weight:bold;">
                           Tổng giá cước: 
                        </div>
                        <div class="col-sm-2" style="text-align:center">
                            <asp:Label ID="id_tonggiacuoc" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                        </div>
                        
                    </div>

            </div>
        <script>
            $(document).ready(function () {
                $("#MainContent_btn_find").click(function () {
                    $("#chitietsd").css("display", "inherit");
                });
              
            });
        </script>
    </div>
              </div>
             </div>
        
    </div>
     
</asp:Content>
