<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Webforms.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:TextBox ID="textbox1" runat="server" OnTextChanged="textbox1_TextChanged" ></asp:TextBox>
        <asp:Label ID="label1" runat="server" text="Label"></asp:Label>
        <asp:Button ID="buton1" runat="server" text="Button" OnClick="buton1_Click"/>
        <asp:HyperLink ID="link1" runat="server"></asp:HyperLink>
        <asp:Panel ID="panel1"  runat="server"></asp:Panel>

    </div>
    </form>
   
</body>
</html>
