<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormRandom.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="ResultBoX" runat="server" Height="180px" Width="937px" Enabled="False"></asp:TextBox>
            <br />
            <asp:Button ID="BtnRanNO" runat="server" Text="產生亂數" OnClick="BtnRanNO_Click" />
        </div>
    </form>
</body>
</html>
