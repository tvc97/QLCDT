
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
            <li class="active"><a data-toggle="tab" href="#trangchu">Trang chủ</a></li>      
            <li><a data-toggle="tab" href="#khachhang">Khách hàng</a></li> 
            <li><a data-toggle="tab" href="#cuocphi">Cước chi tiết sử dụng</a></li>              
        </ul>

    </div>
    <div class="tab-content">
        <div id="trangchu" class="tab-pane fade in active "; style="margin:2%"> 
            <div>
                <h3> My Viettel là một trong những doanh nghiệp viễn thông có tốc độ tăng trưởng nhanh nhất thế giới.</h3>
                <P style="text-align:justify"><b> My Viettel hỗ trợ tra cứu dễ dàng, nhanh chóng các dịch vụ viễn thông như truyền hình, di động trả trước/ sau giúp bạn tiết kiệm chi tiêu, tiết kiệm thời gian, sẵn sàng cho cuộc sống hiện đại.
</b></P>
                <div class="col-md-12 article_content" style="text-align: center;">
                    <div class="hidden-xs col-md-2"></div>
                    <div class="col-md-8">
                        <video controls="controls" height="" id="QXJ0aWNs15ac1a78613e82" poster="http://media.vietteltelecom.vn/upload/video_cskh/3e/ce/e3/11b3debf68185aa4c7f8bfa7b027795de346918f.png" width="100%">
                            <source src="http://media.vietteltelecom.vn/upload/video_cskh/96/0f/f9/e0e5edc7273bbb189edc17aee5fcc4a2e42d57e6.mp4" type="video/mp4">
                            Your browser doesn't support video.<br>
                            Please download the file: <a href="http://media.vietteltelecom.vn/upload/video_cskh/96/0f/f9/e0e5edc7273bbb189edc17aee5fcc4a2e42d57e6.mp4">video/mp4</a></video>
                    </div>
                    <div class="hidden-xs col-md-2"></div>

                </div>
                <p style="text-align:justify">Viettel là một trong những doanh nghiệp viễn thông có số lượng khách hàng lớn nhất trên thế giới. Với kinh nghiệm phổ cập hoá viễn thông tại nhiều quốc gia đang phát triển, chúng tôi hiểu rằng được kết nối là một nhu cầu rất cơ bản của con người. Chúng tôi cũng hiểu rằng, kết nối con người giờ đây không chỉ là thoại và tin nhắn, đó còn là phương tiện để con người tận hưởng cuộc sống, sáng tạo và làm giàu. Bởi vậy, bằng cách tiếp cận sáng tạo của mình, chúng tôi luôn nỗ lực để kết nối con người vào bất cứ lúc nào cho dù họ là ai và họ đang ở bất kỳ đâu.</p>
            </div>
        </div>
        

        <div id="khachhang" class="tab-pane fade "; style="margin:2%">    
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>         
                    <div class="row" style="font-size:20px;">
                        <div class="col-sm-1 form-group"></div>
                        <div class="col-sm-2 form-group">
                            <label class="control-label" for="search_by" style="font-weight:bold">Nhập số CMND:</label>                                                             
                        </div>
                        <div class="col-sm-5 form-group"> 
                            <asp:TextBox ID="nhapCMND" runat="server" CssClass="form-control"></asp:TextBox>                                                                                      
                        </div>                   
                        <div class="col-sm-1 form-group">                                
                            <asp:Button ID="btn_find" runat="server" Text="Tìm" CssClass="btn btn-primary" OnClick="btn_find_Click"   />          
                        </div>   
                        <div class="col-sm-3 form-group"></div>
                        </div>
                     <div class="row" style="font-size:20px; padding-bottom:50px">
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                        <asp:GridView ID="GridView1" runat="server" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#0000A9" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#000065" />
                        </asp:GridView>
                         <hr />
                         </div>
                     <div class="row" style="font-size:20px;padding-bottom:50px">
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
                        <asp:GridView ID="GridView2" runat="server" CellPadding="3" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#0000A9" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#000065" />
                        </asp:GridView>
                         <hr />
                         </div>
                    <div class="row" style="font-size:20px;padding-bottom:50px">
                        <asp:GridView ID="GridView3" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#0000A9" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#000065" />
                        </asp:GridView>
                        <hr />
                         </div>
                       
                </ContentTemplate>
            </asp:UpdatePanel>                      
        </div>
        
    
        
        <div id="cuocphi" class="tab-pane fade">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
                    <div class="row" style="font-size:20px;">
                        <div class="col-sm-1 form-group"></div>
                        <div class="col-sm-2 form-group">
                            <label class="control-label" for="search_by" style="font-weight:bold">Nhập SĐT:</label>                                                             
                        </div>
                        <div class="col-sm-5 form-group"> 
                            <asp:TextBox ID="nhapSDT_tracuoc" runat="server" CssClass="form-control"></asp:TextBox>                                                                                      
                        </div>                   
                        <div class="col-sm-1 form-group">                                
                            <asp:Button ID="btn_find_tracuoc" runat="server" Text="Tìm" CssClass="btn btn-primary" OnClick="btn_find_tracuoc_Click"   />          
                        </div>   
                        <div class="col-sm-3 form-group"></div>
                    </div>
                    <div class="row" style="text-align:right;font-size:20px;">
                        <div class="col-sm-8"></div>
                        <div class="col-sm-2" style="font-weight:bold;">
                        </div>
                        <div class="col-sm-2" style="text-align:center">
                        </div>
                        
                    </div>
                </ContentTemplate>
                </asp:UpdatePanel>
            <div class="row" style="margin:2%">
                <h2 style="text-align:center; color:red; font-weight:bold">CHI TIẾT SỬ DỤNG</h2>
                <p style="text-align:center">Danh sách chi tiết
                        sử dụng dịch vụ cước điện thoại</p> 
                <hr />           
                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                <ContentTemplate>    
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
                            <asp:Button ID="ngaykt" runat="server"  CssClass="btn btn-primary" Text="Ngày kết thúc" />                                                                               
                        </div> 
                        <div class="col-sm-2 form-group"> 
                            <asp:TextBox ID="day_end" runat="server" CssClass="text-center"  ></asp:TextBox>                  
                            <cc1:CalendarExtender ID="CalendarExtender2" TargetControlID="day_end" PopupButtonID="ngaykt" Format="MM/dd/yyyy" runat="server"></cc1:CalendarExtender>                                                                                                                                                                                                             
                        </div>    
                        <div class="col-sm-1 form-group"></div>    
                        <div class="col-sm-1 form-group"> 
                        </div>   
                    </div>
                    </hr>
                    <div class="row" style="text-align:right;font-size:20px;">
                        <div class="col-sm-10" style="text-align:center">
                            <asp:GridView ID="GridView4" runat="server" CssClass="container" CellPadding="3" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                <RowStyle ForeColor="#000066" />
                                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#00547E" />
                            </asp:GridView>
                            </div>
                        <div class="col-sm-2" style="text-align:center"></div>
                        <br />
                        <hr />
                        <%--<div class="col-sm-2" style="font-weight:bold;text-align:center; float:left; padding-left:20px"></div>                        
                      --%>
                    <div class="row" style="font-size:20px;float:left; padding-top:20px">
                        <div class="col-sm-5 form-group">
                            <label class="control-label" for="search_by" style="font-weight:bold;">Tổng giá cước:</label>                                                             
                        </div>
                        <div class="col-sm-4 form-group" style="float:left;">
                              <asp:TextBox ID="TextCuoc" runat="server" Width="160px"></asp:TextBox>                                                                                     
                        </div>
                        <div class="col-sm-3 form-group"></div>
                    </div>
                    </div>
                </ContentTemplate>
                </asp:UpdatePanel>
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

               
</asp:Content>
