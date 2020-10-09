<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PozdravnaPoruka.aspx.cs" Inherits="WebFormsPrimjer.PozdravnaPoruka" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="ime" runat="server" Text="Ime"></asp:Label>
        <input id="txtIme" type="text" /><asp:Button ID="btnObradi" runat="server" OnClick="Button1_Click" Text="Pošalji" />
        <p>
            <asp:Label ID="lblRezultat" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
