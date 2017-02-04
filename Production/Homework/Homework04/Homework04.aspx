<%@ Page Title="Homework 04" Language="C#" MasterPageFile="~/Master/Main.master" AutoEventWireup="true" CodeFile="Homework04.aspx.cs" Inherits="Homework_Homework04_Homework04" %>

<%--//Class: ASP.NET with C# 2
//Author: Chris Boylan
//Abstract: Homework 4--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" Runat="Server">
    <div id="Home4" class="imagebox">
    <table class="center-block table " style="width:80%;">
        <tr>
            <td>Input 1</td>
            <td><asp:TextBox ID="txtInput1" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>Input 2</td>
            <td>
                <asp:TextBox ID="txtInput2" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnProblem1" runat="server" Text="Problem 1" OnClick="btnProblem1_Click" /></td>
            <td>
                <asp:Button ID="btnProblem2" runat="server" Text="Problem 2" OnClick="btnProblem2_Click" />
            </td>
           
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnProblem3" runat="server" Text="Problem 3" OnClick="btnProblem3_Click" /></td>
            <td>
                <asp:Button ID="btnProblem4" runat="server" Text="Problem 4" OnClick="btnProblem4_Click" />
            </td>
           
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnProblem5" runat="server" Text="Problem 5" OnClick="btnProblem5_Click" /></td>
            <td>
                <asp:Button ID="btnProblem6" runat="server" Text="Problem 6" OnClick="btnProblem6_Click" />
            </td>
           
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnProblem7" runat="server" Text="Problem 7" OnClick="btnProblem7_Click" /></td>
            <td>
                <asp:Button ID="btnProblem8" runat="server" Text="Problem 8" OnClick="btnProblem8_Click" />
            </td>
           
        </tr>
        <tr>
            <td colspan="2" class="text-center"><asp:Label ID="lblDescription" runat="server" Text="Press A Button"></asp:Label></td>
        </tr>
        
    </table>
        </div>
</asp:Content>

