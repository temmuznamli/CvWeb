<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.ascx.cs" Inherits="CvWeb.Ogrenci.UserLogin" %>
<p>
    Giriş Yap:</p>

<p style="width: 99px">
    Kullanıcı Adı:</p>
<asp:TextBox ID="TextBox1" runat="server" Width="91px"></asp:TextBox>
<p style="width: 99px">
    Şifre:</p>
<p>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p style="width: 349px">
    <asp:Button ID="girisyap" runat="server" OnClick="Button1_Click" Text="Giriş Yap" style="margin-left: 72px" Width="200px" />
</p>



