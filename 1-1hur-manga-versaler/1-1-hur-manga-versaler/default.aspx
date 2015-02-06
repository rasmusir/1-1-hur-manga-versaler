<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_1_1_hur_manga_versaler._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:TextBox ID="TextBox" runat="server" Height="200px" TextMode="MultiLine" Width="450px"></asp:TextBox>
        <br />
        <asp:label runat="server" text="" ID="Result"></asp:label>
        <br />
        <asp:button runat="server" text="Count uppercase letters" ID="Button" OnClick="Button_Click" />
    </div>
    
    </form>
</body>
</html>
