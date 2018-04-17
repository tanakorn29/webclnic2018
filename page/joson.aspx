<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="joson.aspx.cs" Inherits="page_joson" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>

 <script>
     function updatejson() {
        
         if (confirm("Confirm Proceed Further?")) {
             myMethod1(); //OK Callback function here..
         } else {
             myMethod2(); //CANCEL Callback function here..
         }


     }
     function myMethod1() {
         //any stuff here..
         $.ajax({

             type: "POST",

             url: "joson.aspx/GetData",

             contentType: "application/json; charset=utf-8",

             dataType: "json",

             success: function (response) {

                 var names = response.d;

                 //alert(names);
                 alert("อัพเดตแล้ว");
             },

             failure: function (response) {

                 alert(response.d);

             }

         });

     }

     function myMethod2() {
         //any stuff here..
         alert("2");
     }

 </script>

   

 

 

</head>

<body>

 

<form id="frm" method="post">

    <div id="Content">


        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                 <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Height="48px" Width="211px" />               
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>      
                    



    </div>

 

</form>

 

</body>
</asp:Content>

