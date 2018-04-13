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
            <asp:TextBox ID="TextBox1" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
      </td>
        
  </tr>
            <tr class="active">
      <td class="active" style="width: 230px">
          สังกัด</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtidcard0" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
      </td>
        
  </tr>
          <tr class="active">
      <td class="active" style="width: 230px">
          ประเภทคนไข้</td>
        <td class="active" style="width: 342px">
            <asp:TextBox ID="txtidcard1" class="form-control"  runat="server" Height="41px" Width="438px"></asp:TextBox>
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

