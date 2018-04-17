<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="page_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Button AccessKey="S" ID="submitBtn" runat="server" OnClick="Submit" Text="Submit"
                                        Width="90px" ValidationGroup="vg" CausesValidation="true" OnClientClick = "Confirm()" />

         <script type="text/javascript">

         function Confirm() {
             if (Page_ClientValidate()) {
                 var confirm_value = document.createElement("INPUT");
                 confirm_value.type = "hidden";
                 confirm_value.name = "confirm_value";
                 if (alert("Data has been Added. Do you wish to Continue ?")) {
                     confirm_value.value = "Yes";
                 }
                 else {
                     confirm_value.value = "No";
                 }
                 document.forms[0].appendChild(confirm_value);
             }
         }

   </script>
</asp:Content>

