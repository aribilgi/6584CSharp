<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormElementleri.aspx.cs" Inherits="WebApplicationEgitim.WebFormElementleri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tarayıcıdaki sekme başlık alanı verisi</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Onaylıyorum" />
                    </td>
                    <td>
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <asp:ListItem Value="1">Onayla</asp:ListItem>
                            <asp:ListItem Value="0">Reddet</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Selected="True" Value="0">Seçiniz</asp:ListItem>
                            <asp:ListItem Value="1">Elektronik</asp:ListItem>
                            <asp:ListItem Value="2">Bilgisayar</asp:ListItem>
                            <asp:ListItem Value="3">Telefon</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                    <td>
                        <asp:HiddenField ID="HiddenField1" runat="server" />
                    </td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Image ID="Image1" runat="server" ImageUrl="/Images/Desktop image.png" Height="150" />
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>
                        <asp:ListBox ID="ListBox1" runat="server">
                            <asp:ListItem Selected="True" Value="0">Seçiniz</asp:ListItem>
                            <asp:ListItem Value="1">Elektronik</asp:ListItem>
                            <asp:ListItem Value="2">Bilgisayar</asp:ListItem>
                            <asp:ListItem Value="3">Telefon</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td>
                        <asp:Literal ID="Literal1" runat="server" Text="Literal kontrolü ekrana html tag sız içerik yazdırmamızı sağlar"></asp:Literal>
                    </td>
                    <td>
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Onaylıyorum" />
                    </td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <asp:ListItem Value="1">Onayla</asp:ListItem>
                            <asp:ListItem Value="0">Reddet</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Label ID="Label1" runat="server" Text="Label elementi"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Tıkla" OnClick="Button1_Click" />


        </div>
    </form>
</body>
</html>
