<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="View.aspx.cs" Inherits="Login.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>View Leaves </h2>
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
        <asp:Button ID="Button1" runat="server" Text="View Leave Details" OnClick="Button1_Click" />
    </form>
</body>
</html>
