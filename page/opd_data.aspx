<%@ Page Title="" Language="C#" MasterPageFile="~/page2.master" AutoEventWireup="true" CodeFile="opd_data.aspx.cs" Inherits="page_opd_data" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
<body>
  <center>  <P1>ข้อมูลคนไข้</P1> </center>
      <table class="table table-condensed">
  <tr class="active">
      <td class="active" style="width: 230px">
        <k2>ชื่อคนไข้</k2>  
      </td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtpatient" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          อายุ</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtage" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          รหัสประจำตัวประชาชน</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtidcard" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          วัน/เดือน/ปีเกิด</td>
        <td class="active" style="width: 342px">
            <asp:ImageButton ID="btbirthday" runat="server" Height="77px" ImageUrl="~/image/image3.png" Width="88px"  />
            <asp:Label ID="lblbirthday" runat="server"></asp:Label>
            <asp:Calendar id="Calendarbirthday" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth"  Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          สังกัด</td>
        <td class="active" style="width: 342px">
            <asp:DropDownList ID="ddworklocation"   class="form-control" runat="server">
                <asp:ListItem>คณะนิติศาสตร์</asp:ListItem>
                <asp:ListItem>คณะบริหารธุรกิจ</asp:ListItem>
                <asp:ListItem>คณะมนุษย์ศาสตร์</asp:ListItem>
                <asp:ListItem>คณะศึกษาศาสตร์</asp:ListItem>
                <asp:ListItem>คณะวิทยาศาสตร์</asp:ListItem>
                <asp:ListItem>คณะรัฐศาสตร์</asp:ListItem>
                <asp:ListItem>คณะเศษฐศาสตร์</asp:ListItem>
                <asp:ListItem>บัณฑิตวิทยาลัย</asp:ListItem>
                <asp:ListItem>คณะวิศวกรรมศาสตร์</asp:ListItem>
                <asp:ListItem>คณะศิลปกรรมศาสตร์</asp:ListItem>
                <asp:ListItem>คณะทรัพยากรณ์มนุษย์</asp:ListItem>
                <asp:ListItem>คณะสื่อสารมวลชน</asp:ListItem>
                <asp:ListItem>คณะทัศนมาตรศาสตร์</asp:ListItem>
                <asp:ListItem>คณะสาธารณสุขศาสตร์</asp:ListItem>
                <asp:ListItem>โรงเรียนสาธิต ม.ร. (มัธยม)</asp:ListItem>
                <asp:ListItem>โรงเรียนสาธิต ม.ร.(ประถม)</asp:ListItem>
                 <asp:ListItem>สำนักงานอธิการบดี</asp:ListItem>
                <asp:ListItem>กองกลาง</asp:ListItem>
                <asp:ListItem>กองคลัง</asp:ListItem>
                <asp:ListItem>กองแผนงาน</asp:ListItem>
                <asp:ListItem>กองอาคารสถานที่</asp:ListItem>
                <asp:ListItem>กองการเจ้าหน้าที่</asp:ListItem>
                <asp:ListItem>กองกิจการนักศึกษา</asp:ListItem>
                <asp:ListItem>กองงานวิทยาเขตบางนา</asp:ListItem>
                <asp:ListItem>กองบริการการศึกษา</asp:ListItem>
                <asp:ListItem>สภาคณาจารย์</asp:ListItem>
                <asp:ListItem>สภาข้าราชการและลูกจ้าง</asp:ListItem>
                <asp:ListItem>สำนักงานตรวจสอบภายใน</asp:ListItem>
                <asp:ListItem>งานแนะแนวจัดหางานและทุนการศึกษา</asp:ListItem>
                <asp:ListItem>หน่วยทุนการศึกษากองกิจการนักศึกษา</asp:ListItem>
                 <asp:ListItem>สถาบันคอมพิวเตอร์</asp:ListItem>
                <asp:ListItem>สถาบันวิจัยและพัฒนา</asp:ListItem>
                <asp:ListItem>สถาบันศิลปวัฒนธรรมเฉลิมพระเกียรติ</asp:ListItem>
                <asp:ListItem>สถาบันการศึกษานานาชาติ</asp:ListItem>
                <asp:ListItem>สถาบันภาษา</asp:ListItem>
                <asp:ListItem>สถาบันพัฒนาทรัพยากรมนุษย์</asp:ListItem>
                <asp:ListItem>สถาบันกฎหมายไทย</asp:ListItem>
                <asp:ListItem>สถาบันวิจัยสัตว์ในภูมิภาคเขตร้อน</asp:ListItem>
                <asp:ListItem>สถาบันบริการวิชาการทางอิเล็กทรอนิกส์</asp:ListItem>
                <asp:ListItem>ศูนย์บ่มเพาะวิสาหกิจและจัดการทรัพย์สินทางปัญญา</asp:ListItem>
                <asp:ListItem>สำนักบริการทางวิชาการและทดสอบประเมินผล(สวป.)</asp:ListItem>
                <asp:ListItem>สำนักหอสมุดกลาง</asp:ListItem>
                <asp:ListItem>สำนักเทคโนโลยีการศึกษา</asp:ListItem>
                <asp:ListItem>สำนักพิมพ์</asp:ListItem>
                <asp:ListItem>สำนักกีฬา</asp:ListItem>
                <asp:ListItem>สำนักประกันคุณภาพการศึกษา</asp:ListItem>
                <asp:ListItem>สหกรณ์ออมทรัพย์และการธนกิจ</asp:ListItem>
                <asp:ListItem>สำนักวิทยบริการ</asp:ListItem>
                <asp:ListItem>สำนักสหกิจศึกษาและพัฒนาอาชีพ(RAM3000)</asp:ListItem>
                <asp:ListItem>บัณฑิตวิทยาลัย</asp:ListItem>
                <asp:ListItem>ศูนย์บริการนักศึกษาพิการ</asp:ListItem>
            </asp:DropDownList>
      </td>
        
  </tr>
          <tr class="active">
      <td class="active" style="width: 230px">
          ประเภทคนไข้</td>
        <td class="active" style="width: 342px">
            <asp:DropDownList ID="DropDownList1"   class="form-control" runat="server">
                <asp:ListItem>นักศึกษา</asp:ListItem>
                <asp:ListItem>เจ้าหน้าที่</asp:ListItem>
                <asp:ListItem>อาจารย์</asp:ListItem>
            </asp:DropDownList>
      </td>
        
  </tr>
  <tr class="active">
      <td class="active" style="width: 230px">
          เบอร์โทรศัพท์ที่ทำงาน</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txttelwork" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px; height: 55px;">
          ที่อยู่ปัจจุบัน  
      </td>
        <td class="active" style="width: 342px; height: 55px;">
            <asp:TextBox ID="teladdressnow" class="form-control"   runat="server" Height="46px" TextMode="MultiLine" Width="449px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          เบอร์โทรศัพท์</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="telmyself" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          ชื่อบิดา</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="name_dad" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
        <k2>ชื่อมารดา</k2></td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="name_mom" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
        <k2>ชื่อ สามี/ภรรยา (ถ้ามี)</k2></td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtnamehusbandwide" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          ชื่อผู้ปกครองที่สามารถติดต่อได้ และเกี่ยวข้องเป็น</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtparentname" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
            <br />
        <asp:RadioButtonList ID="Rdpeople" runat="server">
            <asp:ListItem>บิดา</asp:ListItem>
            <asp:ListItem>มารดา</asp:ListItem>
            <asp:ListItem>สามี</asp:ListItem>
            <asp:ListItem>ภรรยา</asp:ListItem>
            </asp:RadioButtonList>  
         
    
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          ที่อยู่และโทรศัพท์ที่ติดต่อได้สะดวก ผู้ปกครอง</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtteladdressparent" class="form-control"  runat="server" Height="41px" Width="438px" TextMode="MultiLine"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          โทรศัพท์ที่ทำงาน (ผู้ปกครอง)</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="telworkparent" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          โทรศัพท์ที่บ้าน (ผู้ปกครอง)</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txttelhomeparent" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
           
            <tr class="active">
      <td class="active" style="width: 230px" colspan="2">
        <k2><asp:Button ID="btnsubmit" runat="server" class="btn btn-default" Text="submit" ></asp:Button></k2>  
      </td>
        
        
  </tr>
    </table>

</body>
</asp:Content>

