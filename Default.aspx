<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Captcha.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Güvenlik Kodu : <asp:Image ID="imgKod" runat="server" />
        <br />
        <br />
        Güvenlik Kodunu Girin : <asp:TextBox ID="txtkontrolKodu" runat="server"></asp:TextBox>  
        <br />
        <br />
        <asp:Button ID="btnKontrol" runat="server" Text="Kontrol" OnClick="btnKontrol_Click" />  
        <br />
        <br />
        <asp:Label ID="lblMesaj" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
