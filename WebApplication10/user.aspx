<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="WebApplication10.user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td style="height: 32px">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="username" ForeColor="#CC0000"></asp:Label>
            </td>
            <td style="height: 32px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td style="height: 32px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 87px; height: 32px;"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="useraddress" ForeColor="#CC0000"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="userphone" ForeColor="#CC0000"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="enter valid phone number" ValidationExpression="^[789]\d{9}$" ControlToValidate="TextBox3" ForeColor="#CC0000"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="useremail" ForeColor="#CC0000"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="enter valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBox4" ForeColor="#CC0000"></asp:RegularExpressionValidator>
            </td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="userpin" ForeColor="#CC0000"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="TextBox5" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="userstate" ForeColor="#CC0000"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>gujarat</asp:ListItem>
                    <asp:ListItem>maharashtra</asp:ListItem>
                    <asp:ListItem>kerala</asp:ListItem>
                    <asp:ListItem>tamil nadu</asp:ListItem>
                    <asp:ListItem>goa</asp:ListItem>
                    <asp:ListItem>punjab</asp:ListItem>
                    <asp:ListItem>karanataka</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="DropDownList3" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="userdistrict" ForeColor="#CC0000"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>thiruvananthapuram</asp:ListItem>
                    <asp:ListItem>alappuzha</asp:ListItem>
                    <asp:ListItem>malappuram</asp:ListItem>
                    <asp:ListItem>palakkad</asp:ListItem>
                    <asp:ListItem>thrissur</asp:ListItem>
                    <asp:ListItem>kozhikod</asp:ListItem>
                    <asp:ListItem>kollam</asp:ListItem>
                    <asp:ListItem>ernamkulam</asp:ListItem>
                    <asp:ListItem>tirur</asp:ListItem>
                    <asp:ListItem>pathanamthitta</asp:ListItem>
                    <asp:ListItem>idukki</asp:ListItem>
                    <asp:ListItem>kasargod</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="DropDownList4" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 32px">
                <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="userstatus"></asp:Label>
            </td>
            <td style="height: 32px">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
            <td style="height: 32px"></td>
            <td style="width: 87px; height: 32px;"></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="username" ForeColor="#CC0000"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox7" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 32px">
                <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="password" ForeColor="#CC0000"></asp:Label>
            </td>
            <td style="height: 32px">
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </td>
            <td style="height: 32px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox8" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td style="width: 87px; height: 32px;"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="register" />
            </td>
            <td>&nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 87px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
