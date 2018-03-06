<%@ Page Title="" Language="C#" MasterPageFile="~/page3.master" AutoEventWireup="true" CodeFile="Schedule.aspx.cs" Inherits="page_Schedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <meta http-equiv=Content-Type content="text/html; charset=utf-8">
              <link href="../css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet" href="../css/style.css">
    <body>
  <center>  <P1>ตารางปฏิบัติงานแพทย์</P1> </center>
      <meta name="description" content="A schedule management with jQuery.">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://code.jquery.com/ui/1.12.1/themes/smoothness/jquery-ui.css">
    <link rel="stylesheet" href="dist/jquery.schedule.css">
    <link rel="stylesheet" href="dist/jquery.schedule-demo.css">
</head>
<body>

<header>
    <nav class="navbar navbar-dark bg-dark mb-3">
        <h1 class="navbar-brand mb-0">jQuery Schedule Demo v2.0</h1>
    </nav>
</header>

<main>
    <div class="container">
        <div class="row">
            <div class="col">
                <h2>Basic</h2>
                <pre class="p-2 mb-3">$("#schedule").jqs();</pre>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div id="schedule" class="jqs-demo mb-3"></div>
            </div>
        </div>


        <div class="row">
            <div class="col">
                <h2>Read mode</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-8">
                <div id="schedule2" class="jqs-demo mb-3"></div>
            </div>
            <div class="col-lg-4">
            <pre class="p-2 mb-3 large">
$("#schedule2").jqs({
    mode: "read",
    data: [{
        day: 0,
        periods: [
            ["20:00", "00:00"],
            ["20:00", "22:00"], // Invalid period, not displayed
            ["00:00", "02:00"]
        ]
    }, {
        day: 3,
        periods: [
            ["00:00", "08:30"],
            ["09:00", "12:00"]
        ]
    }]
});
</pre>
            </div>
        </div>


</body>
</asp:Content>

