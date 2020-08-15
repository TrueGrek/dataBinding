<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBinding.aspx.cs" Inherits="Practice6_DataConnection.DataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--
            Выражения <%# %> позволяют привязать свойства элементов управления к защищенным или открытым
            полям и свойствам текущей страницы. Для того что бы фактически произвести привязку и извлечь
            значения из свойств, нужно вызвать метод DataBind();
        --%>
            <%//If compiler give you exception, it not mean that it is %>
        <asp:Literal Text="<%# FirstName %>" runat="server" />
        <asp:Label runat="server" 
        Text="<%# LastName %>"  
        Font-Size="<%# size %>"
        Font-Bold="true" />
        </div>
    </form>
</body>
</html>
