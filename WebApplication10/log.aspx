﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="log.aspx.cs" Inherits="WebApplication10.log" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 32px"></td>
        <td style="height: 32px"></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="False" Text="username"></asp:Label>
        </td>
        <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="password"></asp:Label>
        </td>
        <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="login" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
