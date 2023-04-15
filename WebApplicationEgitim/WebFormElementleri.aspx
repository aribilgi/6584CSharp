<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormElementleri.aspx.cs" Inherits="WebApplicationEgitim.WebFormElementleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tarayıcıdaki sekme başlık alanı verisi</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Tıkla" />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Onaylıyorum" />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem Value="1">Onayla</asp:ListItem>
                <asp:ListItem Value="0">Reddet</asp:ListItem>
            </asp:CheckBoxList>
        </div>
    </form>
</body>
</html>
