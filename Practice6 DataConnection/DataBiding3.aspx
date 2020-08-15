<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBiding3.aspx.cs" Inherits="Practice6_DataConnection.DataBiding3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label1" runat="server" Text="Пока пусто."></asp:Label>
        </div>
    </form>
</body>
</html>
